using System;
using System.Net;

namespace Demos
{

    class Program
    {


        static void Main(string[] args)
        {
            ThreadAndDelegates.SimpleThread();
            ThreadAndDelegates.AsyncDelegate();

            AsyncNet.AsyncTaskDownload();

            AsyncIO.ReadFileAsyncCall();
            AsyncIO.ReadFileSync();

            AsyncDB.ReadDBAsync();
            AsyncDB.ReadDBSync();

            PLinq.ParallelOperations();
            PLinq.PLinqCollections();

            Console.ReadLine();
        }



        //private static void AsyncDownloadFiles()
        //{
        //    var baseUri = "https://www.ietf.org/rfc/";
        //    var basePath = @"C:\tmp\";

        //    WebClient client = new WebClient();
        //    AsyncCallback downloadCompleted =
        //        ar => Console.WriteLine("{0} download completed", ar.AsyncState);
        //    var state1 = "rfc2616.txt";
        //    Action<string, string> download = client.DownloadFile;

        //    //  var bigFile1 = "http://www.twain.org/docs/530fe0d785f7511c510004fb/TWAIN-2.2-Spec.pdf";
        //    var r1 = download.BeginInvoke(
        //        baseUri + state1, basePath + state1, downloadCompleted, state1);

        //    var state2 = "rfc4180.txt";
        //    while (!r1.IsCompleted)
        //    {
        //        Console.WriteLine("download progress");
        //    }

        //    var r2 = download.BeginInvoke(
        //        baseUri + state2, basePath + state2, downloadCompleted, state2);
        //}

    }
}
