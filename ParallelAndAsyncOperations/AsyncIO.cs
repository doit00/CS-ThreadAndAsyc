using System;
using System.IO;

namespace Demos
{
    class AsyncIO
    {
        public static void ReadFileAsyncCall()
        {
            ReadFileAsync();
            Console.WriteLine("--------------------------");
        }
        public static void ReadFileSync()
        {
            var file = @"C:\tmp\rfc2616.txt";
            //var lines = File.ReadAllLines(file);
            //foreach (var item in lines)
            //{
            //    Console.WriteLine(item);
            //}

            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close();

        }
        static async void ReadFileAsync()
        {
            var file = @"C:\tmp\rfc2616.txt";
            var sr = File.OpenText(file);
            string line;
            while ((line = await sr.ReadLineAsync()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close();

        }

    }
}
