using System;
using System.Threading;
using System.Text;
using System.Timers;
using System.Diagnostics;
using System.IO;

namespace TheHackMachine {
    class Program {

        // Random IPs and Ports Generator.      -Working after 157 tests xD.

        public static string random_ip_algorithm() {
            var random = new Random();
            //Console.WriteLine($"{random.Next(1, 255)}.{random.Next(1, 255)}.{random.Next(1, 255)}.{random.Next(1, 255)}");
            return $"{random.Next(1, 255)}.{random.Next(1, 255)}.{random.Next(1, 255)}.{random.Next(1, 255)}";
        }

        public static uint random_port_algorithm() {
            var random = new Random();
            return (uint)random.Next(8, 65000);
        }

        static void Main(string[] args) {

            Console.WriteLine("TheHackMachine !");
            Console.WriteLine("Write the Site's Name you want to HACK!\n");
            string hck_site = Console.ReadLine();
            string hckd_site = hck_site.ToUpper();  // hckd_site to be used from now and on

            void mainFunc() {

                Console.Clear();
                Console.WriteLine($"\nI'm starting to HACK {hckd_site} ! ");
                Console.WriteLine("\n");
            }

            mainFunc();
            Thread.Sleep(4000);


            // Animations

            void mainAlgOp1() {   // Might put them in another file in the future, so there isn't such a mess.. But looks cool tho :)

                Console.Write("Computing: ");
                using (var progress = new ProgressBar()) {

                    for (int i = 0; i <= 100; i++) {

                        progress.Report((double)i / 100);
                        Thread.Sleep(60);
                    }
                }
                Console.WriteLine("  [##########]  100%");

                Console.WriteLine("\n");

                Console.Write("IP: ");
                using (var progress = new ProgressBar()) {

                    for (int i = 0; i <= 100; i++) {

                        progress.Report((double)i / 100);
                        Thread.Sleep(20);
                    }
                }
                Console.WriteLine("  [##########]  100%");

                Console.Write("MAC: ");
                using (var progress = new ProgressBar())  {

                    for (int i = 0; i <= 100; i++) {

                        progress.Report((double)i / 100);
                        Thread.Sleep(55);
                    }
                }
                Console.WriteLine("  [##########]  100%");

                Console.Write("NMap: ");
                using (var progress = new ProgressBar()) {

                    for (int i = 0; i <= 100; i++) {

                        progress.Report((double)i / 100);
                        Thread.Sleep(80);
                    }
                }
                Console.WriteLine("  [##########]  100%");

                Console.WriteLine("\n");

                Console.Write("Sever: ");
                using (var progress = new ProgressBar()) {

                    for (int i = 0; i <= 100; i++) {

                        progress.Report((double)i / 100);
                        Thread.Sleep(30);
                    }
                }
                Console.WriteLine("  [##########]  100%");

                Console.Write("Server #### #####: ");
                using (var progress = new ProgressBar()) {

                    for (int i = 0; i <= 100; i++) {

                        progress.Report((double)i / 100);
                        Thread.Sleep(90);
                    }
                }
                Console.WriteLine("  [##########]  100%");

                Console.WriteLine("\n");

                Console.Write("####: ");
                using (var progress = new ProgressBar()) {

                    for (int i = 0; i <= 100; i++) {

                        progress.Report((double)i / 100);
                        Thread.Sleep(80);
                    }
                }
                Console.WriteLine("  [##########]  100%");

                Console.Write("#### ## #### ###: ");
                using (var progress = new ProgressBar()) {

                    for (int i = 0; i <= 100; i++) {

                        progress.Report((double)i / 100);
                        Thread.Sleep(45);
                    }
                }
                Console.WriteLine("  [##########]  100%");

                Thread.Sleep(5000);

            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            mainAlgOp1();      // -- COMMENTED FOR TESTING PURPOSES ?!
            stopWatch.Stop();
            var elapsedMs = stopWatch.ElapsedMilliseconds;


            DateTime time_now = DateTime.Now;       //  GET Current Time
            DateTime time_utc = DateTime.UtcNow;        //   GET UTC Time

            // Generate Report

            string path = @"C:\Users\Default\Documents\Report.txt";     //FIXED!

            if (!File.Exists(path)) {       // If file !exists, create and write:

                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("The site was HACKED succesfully!");

                    sw.WriteLine("\n");

                    sw.WriteLine("\nSite: {0}", hckd_site);

                    sw.WriteLine("\n");

                    sw.WriteLine("IP: {0}", random_ip_algorithm());
                    sw.WriteLine("Port: {0}", random_port_algorithm());

                    sw.WriteLine("\n");

                    sw.WriteLine("Time Elapsed: {0} (HH:mm:ss:msssss)", stopWatch.Elapsed);

                    sw.WriteLine("\n");

                    sw.WriteLine("Report Generated: {0} Local Time", time_now);     // -- GET CURRENT AND GMT TIME
                    sw.WriteLine("Report Generated: {0} GMT/UTC", time_utc);

                    sw.Close();
                }
            }
            else if (File.Exists(path)) {    // If file = exists, add: 

                using (var sw = new StreamWriter(path, true)) {
                    sw.WriteLine("\n\n\n\n\n");
                    sw.WriteLine("___________________________________________________________");
                    sw.WriteLine("The site was HACKED succesfully!");

                    sw.WriteLine("\n");

                    sw.WriteLine("\nSite: {0}", hckd_site);

                    sw.WriteLine("\n");

                    sw.WriteLine("IP: {0}", random_ip_algorithm());
                    sw.WriteLine("Port: {0}", random_port_algorithm());

                    sw.WriteLine("\n");

                    sw.WriteLine("Time Elapsed: {0} (HH:mm:ss:msssss)", stopWatch.Elapsed);

                    sw.WriteLine("\n");

                    sw.WriteLine("Report Generated: {0} Local Time", time_now);     // -- GET CURRENT AND GMT TIME
                    sw.WriteLine("Report Generated: {0} GMT/UTC", time_utc);
                    sw.WriteLine("___________________________________________________________");

                    sw.Close();
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Done! Check the Report at C:/Users/Default/Documents/Report.txt");

            Console.WriteLine("\nTime elapsed: {0} (HH:mm:ss:msssss)", stopWatch.Elapsed);

            Console.WriteLine("\n");
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
