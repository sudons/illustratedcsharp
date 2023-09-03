using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.Design;
using System.Web.Mvc;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        
    }
    public class MvcEngine
    {
        public IMvcEngineFactory EngineFactory { get; }
        public MvcEngine(IMvcEngineFactory engineFactory=null)
        {
            EngineFactory = engineFactory ?? new MvcEngineFactory();
        }
        public async Task StartAsync(Uri address)
        {
            var listener = EngineFactory.GetWebListener();
            var activator = EngineFactory.GetControllerActivator();
            var executor = EngineFactory.GetControllerExecutor();
            var renderer = EngineFactory.GetViewRenderer();
            await listener.ListenAsync(address);
            while (true)
            {
                var httpContext = await listener.ReceiveAsync();
                var controller = await activator.CreateControllerAsync(httpContext);
                try
                {
                    var view = await executor.ExecuteAsync(controller, httpContext);
                    await renderer.RendAsync(view, httpContext);
                }
                finally
                {
                    await activator.ReleaseAsync(controller);
                }
            }
        }
        protected virtual IWebListener GetWebListener()
        {
            throw new NotImplementedException();
        }
        protected virtual IControllerActivator GetControllerActivator()
        {
            throw new NotImplementedException();
        }
        protected virtual IControllerExecutor GetControllerExecutor()
        {
            throw new NotImplementedException();
        }
        protected virtual IViewRenderer GetViewRenderer()
        {
            throw new NotImplementedException();
        }
    }
    public interface IWebListener
    {
        Task ListenAsync(Uri address);
        Task<HttpContext> ReceiveAsync();
    }
    public interface IControllerActivator
    {
        Task<Controller> CreateControllerAsync(HttpContext httpContext);
        Task ReleaseAsync(Controller controller);
    }
    public interface IControllerExecutor
    {
        Task<View> ExecuteAsync(Controller controller, HttpContext httpContext);
    }
    public interface IViewRenderer
    {
        Task RendAsync(View view, HttpContext httpContext);
    }

    public interface IMvcEngineFactory
    {
        IWebListener GetWebListener();
        IControllerActivator GetControllerActivator();
        IControllerExecutor GetControllerExecutor();
        IViewRenderer GetViewRenderer();
    }
    public class MvcEngineFactory : IMvcEngineFactory
    {
        public virtual IControllerActivator GetControllerActivator()
        {
            throw new NotImplementedException();
        }

        public virtual IControllerExecutor GetControllerExecutor()
        {
            throw new NotImplementedException();
        }

        public virtual IViewRenderer GetViewRenderer()
        {
            throw new NotImplementedException();
        }

        public virtual IWebListener GetWebListener()
        {
            throw new NotImplementedException();
        }
    }
}