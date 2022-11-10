using System.Diagnostics;

namespace DownloadWebsites
{
    public partial class DownloadForm : Form
    {
        private readonly HttpClient httpClient = new HttpClient();
        public DownloadForm()
        {
            InitializeComponent();
        }

        private void SyncDownloadButton_Click(object sender, EventArgs e)
        {
            ShowResultLabel.Text = "";
            Stopwatch stopwatch = Stopwatch.StartNew();
            DownloadWebsitesSync();
            ShowResultLabel.Text += $"Elapsed time:{stopwatch.Elapsed}{Environment.NewLine}";
        }

        private async void AsyncDownloadButton_Click(object sender, EventArgs e)
        {
            ShowResultLabel.Text = "";
            Stopwatch stopwatch = Stopwatch.StartNew();
            await DownloadWebsitesAsync();
            ShowResultLabel.Text += $"Elapsed time:{stopwatch.Elapsed}{Environment.NewLine}";
        }

        private void DownloadWebsitesSync()
        {
            foreach (var site in Contents.WebSites)
            {
                var result = DownloadWebsiteSync(site);
                ReportResult(result);
            }
        }
        private async Task DownloadWebsitesAsync()
        {
            List<Task<string>> downloadWebSiteTasks = new List<Task<string>>();

            foreach (var site in Contents.WebSites)
            {
                downloadWebSiteTasks.Add(DownloadWebsiteAsync(site));
            }
            var results = await Task.WhenAll(downloadWebSiteTasks);
            foreach (var result in results)
            {
                ReportResult(result);
            }
        }

        private string DownloadWebsiteSync(string url)
        {
            var response= httpClient.GetAsync(url).GetAwaiter().GetResult();
            var responsePlayloadBytes = response.Content.ReadAsByteArrayAsync().GetAwaiter().GetResult();
            return $"Finish downloading data from {url}.Total bytes returned {responsePlayloadBytes.Length}.{Environment.NewLine}";

        }
        private async Task<string> DownloadWebsiteAsync(string url)
        {
            var response = await httpClient.GetAsync(url);
            var responsePlayloadBytes =await response.Content.ReadAsByteArrayAsync();
            return $"Finish downloading data from {url}.Total bytes returned {responsePlayloadBytes.Length}.{Environment.NewLine}";

        }

        private void ReportResult(string result)
        {
            ShowResultLabel.Text += result;
        }


    }
}