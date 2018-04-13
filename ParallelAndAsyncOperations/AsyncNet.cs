using System;
using System.Net;
using System.Threading.Tasks;

namespace Demos
{
    class AsyncNet
    {
        public static void AsyncTaskDownload()
        {
            var baseUri = "https://www.ietf.org/rfc/";
            var basePath = @"C:\tmp\";
            var file = "rfc2616.txt";

            DownloadFileTaskAsync(baseUri + file, basePath + file);

        }
        static async Task DownloadFileTaskAsync(string url, string file)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    await client.DownloadFileTaskAsync(url, file);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
