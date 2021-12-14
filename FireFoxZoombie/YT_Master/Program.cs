using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using YT_Master.MyCode;

namespace YT_Master
{
    class Program
    {
        private static string LinkToManga;
        static void Main(string[] args)
        {
            //rec_funck();

            saveLinks();
            //start();
            Console.WriteLine("\n\n---Waiting For [Enter] To Break---\n\n");
            Console.ReadLine();
        }
        static void saveLinks()
        {
            int index = 0;
            List<string> links = new LinksReader().GetLinkList();
            LinkToManga = links[index];

            using (StreamWriter outputFile = new StreamWriter(@"C:\Users\pkubo\OneDrive\Dokumenty\GitHub\Stuff\FireFoxZoombie\YT_Master\Files\JC-Links.txt"))
            {
                foreach (string line in links)
                    outputFile.WriteLine(line);
            }
        }
        static void start()
        {
            string url = LinkToManga;
            int ms_delay = 5000;

            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(".", "geckodriver.exe");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe -private ";
            FirefoxDriver driver = new FirefoxDriver(service);

            driver.Navigate().GoToUrl(url);

            int tmp = 10;
            for (int i = 0; i < ms_delay/tmp; i++)
            {
                Thread.Sleep(tmp);
            }

            string js_script = @"
                                function sleep(ms) {
                                  return new Promise(resolve => setTimeout(resolve, ms));
                                }

                                async function demo() {
                                  for (let i = 0; i < 100000; i+=8) {
		                                window.scroll(0,i);
                                    await sleep(100);
                                  }
                                }

                                demo();
                                ";

            IJavaScriptExecutor exec = (IJavaScriptExecutor)driver;
            exec.ExecuteScript(js_script);

            Console.ReadLine();
        }




















        /*
        static void rec_funck()
        {
            try
            {
                Console.WriteLine("\n\n---Here we are again xD---\n\n");

                Task.Factory.StartNew(() => new SlaveLink().Watch());
                Task.Factory.StartNew(() => new SlaveList().Watch());
            }
            catch (Exception exx)
            {
                Console.WriteLine("*\n*\n*\n*\n*\n");
                Console.WriteLine("Error: "+exx.Message);
                Console.WriteLine("*\n*\n*\n*\n*\n");
                kill_firefox();
                rec_funck();
            }
        }
        static void kill_firefox()
        {
            Process[] AllProcesses = Process.GetProcesses();
            foreach (var process in AllProcesses)
            {
                if (process.MainWindowTitle != "")
                {
                    string s = process.ProcessName.ToLower();
                    if (s == "firefox")                                                //  s == "iexplore" || s == "iexplorer" || s == "chrome" ||
                        process.Kill();
                }
            }
        }
        */
    }
}
