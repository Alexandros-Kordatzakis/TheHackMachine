using System;
using System.Threading;
using System.Text;
using System.Timers;
using System.Diagnostics;
using System.IO;

namespace TheHackMachine {
    class Program {
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


            string IP = "6.55.126.1";
            //string IP2 = "104.89.49.11";
            //string IP3 = "104.107.158.41";
            //string IP4 = "23.214.28.211";

            string Port = "995";
            //string Port2 = "80";
            //string Port3 = "128";
            //string Port4 = "443";

            //TODO: Implement  "random.choice()()"  for the multiple IP's and Port's.



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


            // Generate Report

            string path = @"c:\Users\ALMANKA\Documents\Report.txt";     //FIXME: Set file to be created at a location that can find it in another PC. (Do not use "User\...\" on path) Might use just "C:\" ?

            if (!File.Exists(path)) {

                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("The site was HACKED succesfully!");

                    sw.WriteLine("\n");

                    sw.WriteLine("\nSite: {0}", hckd_site);

                    sw.WriteLine("\n");

                    sw.WriteLine("IP: {0}", IP);
                    sw.WriteLine("Port: {0}", Port);

                    sw.WriteLine("\n");

                    sw.WriteLine("Time Elapsed: {0} (HH:mm:ss:msssss)", stopWatch.Elapsed);

                    //sw.WriteLine("Report Generated: {0}", );     -- GET CURRENT AND GMT TIME

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

                    sw.WriteLine("IP: {0}", IP);
                    sw.WriteLine("Port: {0}", Port);

                    sw.WriteLine("\n");

                    sw.WriteLine("Time Elapsed: {0} (HH:mm:ss:msssss)", stopWatch.Elapsed);

                    //sw.WriteLine("Report Generated: {0}", );     -- GET CURRENT AND GMT TIME
                    sw.WriteLine("___________________________________________________________");

                    sw.Close();
                }
            }


            Console.WriteLine("Done! Check the Report at C:/Users/ALMANKA/Documents/Report.txt");

            Console.WriteLine("Time elapsed: {0} (HH:mm:ss:msssss)", stopWatch.Elapsed);
        }
    }
}
