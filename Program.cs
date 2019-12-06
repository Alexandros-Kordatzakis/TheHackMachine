using System;
using System.Threading;
using System.Text;
using System.Timers;

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


            // Animations

            void mainAlgOp1() {   // Might put them in another file in the future, so there isn't such a mess :)

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
                using (var progress = new ProgressBar())
                {

                    for (int i = 0; i <= 100; i++)
                    {

                        progress.Report((double)i / 100);
                        Thread.Sleep(45);
                    }
                }
                Console.WriteLine("  [##########]  100%");

                Thread.Sleep(5000);

            }

        }
    }
}
