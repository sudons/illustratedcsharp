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
            foreach (var site in Contents.WebSites)
            {
                var result = await Task.Run(()=> DownloadWebsiteSync(site));
                ReportResult(result);
            }
        }

        private string DownloadWebsiteSync(string url)
        {
            var response= httpClient.GetAsync(url).GetAwaiter().GetResult();
            var responsePlayloadBytes = response.Content.ReadAsByteArrayAsync().GetAwaiter().GetResult();
            return $"Finish downloading data from {url}.Total bytes returned {responsePlayloadBytes.Length}.{Environment.NewLine}";

        }

        private void ReportResult(string result)
        {
            ShowResultLabel.Text += result;
        }


    }
}