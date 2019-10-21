using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senior_Project
{
    static class Program
    {
          /// <summary>
          /// The main entry point for the application. This class' primary responsibility is controlling the initialization of the entire program.
          /// </summary>

          [STAThread]
          
          /*
          Program::Main

          NAME

                    Program::Main - The main function for the application.

          DESCRIPTION

                    This function is the starting point for the application.  
                    It runs the welcome form if it detects that the program has 
                    not been run before, or the main menu if the program has 
                    been used before.
          */
          static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

               string filename = @"\startup.txt";
               string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\HomeroomHelper\Settings";
               string logpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\HomeroomHelper\Logs";

               if (!System.IO.File.Exists(filepath + filename))
               {
                    //Intialize folders and database
                    System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\HomeroomHelper");
                    System.IO.Directory.CreateDirectory(filepath);
                    System.IO.Directory.CreateDirectory(logpath);
                    Database_Interface.Create_DB();

                    //One-time form
                    Application.Run( new Welcome_Form());

                    System.IO.File.WriteAllText(filepath + filename, "1");
               }
               else
               {
                    Application.Run(new App());
               }

          }
          /*
          Program::Quit

          NAME

                    Program::Quit - A way for the program to terminate artificially.

          DESCRIPTION

                    This function terminates the program.  Because the Program class is static, it can be called from any point in the program.

          */
          public static void Quit() //http://geekswithblogs.net/mtreadwell/archive/2004/06/06/6123.aspx
          {
               Application.Exit();
          }
    }
}

