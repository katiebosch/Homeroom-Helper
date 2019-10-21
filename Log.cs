using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Senior_Project
{
     public class Log //https://stackoverflow.com/questions/20185015/how-to-write-log-file-in-c
     {
          /// <summary>
          /// A logging class used to track any errors and exceptions that appear in the program.
          /// </summary>

          private string logpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\HomeroomHelper\Logs\";

          /*
               NAME

                    Log::Log - Constructor that logs an exception or error to a file.

               SYNOPSIS

                    Log (Exception e, string function, string message);

                         e              --> the exception being recorded.
                         function       --> the file and function where the error occurred.
                         message        --> a custom message to include in the log file.

                    Log(string function, string message);
                         
                         function       --> the file and function where the error occurred.
                         message        --> a custom message to include in the log file.

               DESCRIPTION

                    When invoked, the log class records the data above to a file for that day. This function formats
                    the message and then calls AddLog to save it to a file.

          */
          public Log (Exception e, string function, string message)
          {
               string log_message = DateTime.Now.ToString("MM.dd.yyyy") + Environment.NewLine;
               log_message += "Error in function " + function + ": ";
               log_message += message + ". ";
               log_message += Environment.NewLine + "Exception: " + e.ToString();

               AddLog(log_message);
          }
          public Log(string function, string message)
          {
               string log_message = DateTime.Now.ToString("MM.dd.yyyy") + Environment.NewLine;
               log_message += "Error in function " + function + ": ";
               log_message += message + ". ";

               AddLog(log_message);
          }

          /*
               NAME

                    Log::AddLog - Function that adds a log to a file

               SYNOPSIS

                     void AddLog(string message);

                         message        --> a custom message to include in the log file.


               DESCRIPTION

                    This function accesses the log file of the day and saves the message to the file.

          */
          public void AddLog(string message)
          {
               try
               {
                    using (System.IO.StreamWriter w = System.IO.File.AppendText(logpath + DateTime.Now.ToString("MM.dd.yyyy")))
                    {
                         w.WriteLine("\r\nLog Entry: ");
                         w.Write(message);
                         w.WriteLine();
                    }

               }
               catch (Exception e)
               {
                    Console.Write("Error generating log: " + e.ToString());
                    return;
               }
          }

     }
}
