using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_9
{
    internal class Downloader
    {
        public async Task DownloadDataAsync(string url, string filePath)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("URL cannot be null or empty", nameof(url));
            }
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty", nameof(filePath));
            }
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string content = await client.GetStringAsync(url);
                    await File.WriteAllTextAsync(filePath, content);
                    Console.WriteLine($"Data {url} downloaded");
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Error downloading data: {e.Message}");
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Error writing to file: {e.Message}");
                }

            }
        }
    }
}
