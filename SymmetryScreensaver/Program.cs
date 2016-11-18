using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymmetryScreensaver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(args.Length > 0) //If we have args
            {
                string fstArg = args[0].ToLower().Trim();
                string sndArg = null;

                if(fstArg.Length > 2) //If arguments are separated with colons
                {
                    sndArg = fstArg.Substring(3).Trim(); //What is after the colon
                    fstArg = fstArg.Substring(0, 2);
                }
                else if(args.Length > 1) //If arguments are separated with space
                {
                    sndArg = args[1];
                }

                switch (fstArg)
                {
                    case "/c": //Config mode
                        //TODO
                        break;
                    case "/p": //Preview mode
                        //Todo
                        break;
                    case "/s": //Fullscreen mode
                        ShowScreenSaver();
                        Application.Run();
                        break;
                    default:
                        MessageBox.Show("Invalid argument!", "Symmetry Screensaver",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        break;
                }
            }
            else //No arguments, default to /c
            {
                //TODO
            }
            
        }

        static void ShowScreenSaver()
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                SymmetryScr scr = new SymmetryScr(screen.Bounds); //Start with constructor to adjust to screen size
                scr.Show();
            }
        }
    }
}
