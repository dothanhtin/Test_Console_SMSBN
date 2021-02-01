using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        private static System.Diagnostics.Stopwatch watch = null;
        private static int error_count = 0, count = 0;
        private static bool isExit = false;
        private static Random r = new Random();

        static void Main(string[] args)
        {
            /*  CHÚ Ý CHECK CÁC THAM SO SAU
             *  1. Url webservice gọi tới : test 42, thật 45, 41
             *  2. Số sđt : random or vina
             *  3. Acc gửi đi: brand_test or doitaccskh
             */
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);
           

            try
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                //VnptWs.SendMT2SoapClient x = new VnptWs.SendMT2SoapClient();
                //Console.WriteLine("Testing ws server ["+ x.Endpoint.Address + "] Press ESC to stop...");
                //x.Close();
                //x = null;

                isExit = false;
                GoMultiThreading();
                do
                {
                    while (!Console.KeyAvailable)
                    {
                        //loop
                    }
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                isExit = true;


                watch.Stop();
                TimeSpan timeSpan = watch.Elapsed;
                Console.WriteLine("App Fisnish : Total sms send = {0}, Total elapsed time = {1}h {2}m {3}s {4}ms, Error count = {5} ", count, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds, error_count);
                AppUtil.Log("TestApp Fisnish : Total sms send = " + count + ", Total elapsed time = " + timeSpan.Hours + "h " + timeSpan.Minutes + "m " + timeSpan.Seconds + "s " + timeSpan.Milliseconds + "ms, Error count = " + error_count);
            }
            catch (Exception ex)
            {
                AppUtil.Log("Outside Exception!. ex.message = " + ex.Message);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void GoMultiThreading()
        {

            Console.WriteLine("Starting");
            Thread[] Threads = new Thread[20];
            for (int i=0; i<20; i++)
            {
                Work work = new Work();
                work.ThreadName = i + "";
                Threads[i] = new Thread(new ThreadStart(work.DoWork));
                Threads[i].Start();
            }
        }

        static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            if (!isExit)
            {
                isExit = true;
                Thread.Sleep(5000); // wait 5s wait for threads stop
            }
            if (watch != null)
            {
                TimeSpan timeSpan = watch.Elapsed;
                AppUtil.Log("TestApp Fisnish : Total sms send = " + count + ", Total elapsed time = " + timeSpan.Hours + "h " + timeSpan.Minutes + "m " + timeSpan.Seconds + "s " + timeSpan.Milliseconds + "ms, Error count = " + error_count);
            }
            AppUtil.Log("TestApp Fisnish : Total sms send = " + count + ", Error count = " + error_count);
        }

        class Work
        {
            public string ThreadName = "";
            public void DoWork()
            {
                // start comment here
                int x = 0;
                do
                {
                    x = r.Next(20, 1000);
                    Console.WriteLine("Thread [" + ThreadName + "] sleep --> " + x);
                    Thread.Sleep(x);
                } while (!isExit);
                // end comment here


                /*
                //string account_name = "doitaccskh", account_password = "AFLFexlc0HdPAtTMyadDSstMjzt";
                string account_name = "brand_test", account_password = "UiT@q4bVGIiJ";
                string Service_ID = "Sacombank", Command_Code = "Sacombank", Message_Type = "1", Content_Type = "0";
                string Request_ID = "0"; //AppUtil.GetRandomNumbers(5);
                string IsMore = "0", Total_Message = "1", Message_Index = "1";  // Start with 1
                int result = 0;
                Random r = new Random();
                string sdt = null;
                do {
                    try
                    {
                        VnptWs.SendMT2SoapClient client = new VnptWs.SendMT2SoapClient();

                        sdt = AppUtil.GetRandomVinaSDT();   // Vina
                                                            //sdt = AppUtil.GetRandomValidSDT();
                        string noidung = "TEST--" + AppUtil.GetRandomString(50);
                        var watch_inner = System.Diagnostics.Stopwatch.StartNew();

                        TimeSpan timeSpan_inner = watch.Elapsed;
                        Console.WriteLine("[" + error_count + "|" + count + "] Sending : sdt = " + sdt);
                        result = client.SendSMS(account_name, account_password, sdt, noidung, Service_ID, Command_Code, Request_ID, Message_Type, Total_Message, Message_Index, IsMore, Content_Type);

                        watch_inner.Stop();
                        long elapsedMs_inner = watch_inner.ElapsedMilliseconds;
                        Console.WriteLine("[" + error_count + "|" + count + "] Fisnish : return code = " + result + ", elapsed time = " + elapsedMs_inner);
                        //Console.WriteLine("Summary -->  Count: " + count + ", Errors: "+error_count+ ", Elapsed: " + timeSpan_inner.Hours + "h" + timeSpan_inner.Minutes + "m" + timeSpan_inner.Seconds + "s]");
                        Console.WriteLine("//---------------------------------------------------------------");
                        count++;

                        client.Close();

                        Thread.Sleep(r.Next(20, 1000));
                    }
                    catch (Exception ex)
                    {
                        error_count++;
                        AppUtil.Log("Exception!: Message = " + ex.Message + ", sdt = " + sdt + ", Total sms = " + count + ", Error count = " + error_count);
                        AppUtil.Log("----------------------------------------------------------------------------------------");
                        Console.WriteLine("--> Exception occurred, wait for 5secs to retry...");
                        Console.WriteLine("//---------------------------------------------------------------");
                        Thread.Sleep(5000); // wait 5s to restart
                    }
                } while (!isExit);
                */
            }

        }
    }
}
