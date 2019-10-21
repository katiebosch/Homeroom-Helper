using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Senior_Project
{
     static class IO
     {
          /// <summary>
          /// The class responsible for importing and exporting student and teacher files.
          /// </summary>


          /*
               NAME

                    IO::Import_Many - Import multiple files into the database.

               DESCRIPTION

                    This function allows the user to select the files they would like to import, 
                    turns them into a standard format, and sends them to the database interface.

               RETURNS

                    True if completed successfully, false if not.
          */
          public static bool Import_Many()
          {
               string[] files = GetFiles(false);
               if(files[0] == "-1")
               {
                    return false; //Import canceled
               }
               else
               {
                    foreach(string file in files)
                    {
                         Import(file);
                    }
                    return true;
               }
          }

          /*
               NAME

                    IO::GetFiles - Prompts the user to select files for import.

               SYNOPSIS

                    string[] GetFiles(bool is_single_file);

                         is_single_file      --> true if the user is only allowed to select one file, false if not

               DESCRIPTION

                    This function is how the user actually selects import files. 
                    The function displays the system directory window, and then
                    returns the paths of the files selected.

               RETURNS

                    String array of file paths to import.
          */
          private static string[] GetFiles(bool is_single_file)
          {
               string[] filenames = { };

               OpenFileDialog dialog = new OpenFileDialog();
               dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\HomeroomHelper";

               if(is_single_file == true)
               {
                    dialog.Multiselect = false;
               }
               else
               {
                    dialog.Multiselect = true;
               }

               if(dialog.ShowDialog() == DialogResult.OK)
               {
                    filenames = dialog.FileNames;
               }
               else
               {
                    filenames[0] = "-1";
               }

               return filenames;
          }

          /*
               NAME

                    IO::Import - Imports the data from a file

               SYNOPSIS

                    void Import(string filename);

                         filename      --> the name of the file to import

               DESCRIPTION

                    This function contains the brunt of the importing work. It takes a filename,
                    reads the file line by line and converts it into data to be stored on the database.
          */
          private static void Import(string filename)
          {
               StreamReader reader = new StreamReader(filename);
               int count = 0;
               string line;

               while ((line = reader.ReadLine()) != null) //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-a-text-file-one-line-at-a-time
               {
                    if (count == 0) //if we are on the first line, then it is student data
                    {
                         try
                         {
                              Student import_student = String_To_Student(line);
                              Database_Interface.Add_Student(import_student);
                         }
                         catch(Exception e)
                         {
                              new Log(e, "IO.cs: Import.", "Could not import file.");
                              MessageBox.Show("Error importing student.");
                              return;
                         }
                         
                    }
                    else if (line.Substring(0, 4).ToLower() == "note")
                    {
                         Note import_note = String_To_Note(line);
                         Database_Interface.Add_Note(import_note);
                    }
                    else if (line.Substring(0, 4).ToLower() == "hist")
                    {
                         History_Entry import_entry = String_To_History_Entry(line);
                         Database_Interface.Add_History(import_entry);
                    }
                    count++;
               }
          }

          /*
               NAME

                    IO::Import_One - Imports one file into the database.

               DESCRIPTION

                    This function allows the user to select the file they would like to import, 
                    turns it into a standard format, and sends it to the database interface.

               RETURNS

                    True if completed successfully, false if not.
          */
          public static bool Import_One()
          {
               string filepath = GetFiles(true)[0];  //Open dialog and retrieve import files
               if(filepath == "-1")
               {
                    return false; //Import canceled
               }
               else
               {
                    Import(filepath);
                    return true;
               }
          }

          /*
               NAME

                    IO::String_To_History_Entry - Imports the data from a file

               SYNOPSIS

                    History_Entry String_To_History_Entry(string line);

                         line      --> the line of text from an import file

               DESCRIPTION

                    This function converts a line of text from a file to a history entry object and returns it.

               RETURNS
                    
                    History_Entry object containing the data from the file.
          */
          private static History_Entry String_To_History_Entry(string line)
          {
               try
               {
                    History_Entry temp = new History_Entry();
                    string[] values = line.Split(',');

                    temp.id = Convert.ToInt32(values[1]);
                    temp.student_id = Convert.ToInt32(values[2]);
                    temp.date = values[3];
                    temp.current_lvl = Convert.ToChar(values[4]);

                    return temp;
               }
               catch (Exception e)
               {
                    new Log(e, "IO.cs: String_To_History_Entry.", "Error loading history entry.");
               }

               return null;
          }

          /*
               NAME

                    IO::String_To_Student - Imports the data from a file

               SYNOPSIS

                    Student String_To_Student(string line);

                         line      --> the line of text from an import file

               DESCRIPTION

                    This function converts a line of text from a file to a student object and returns it.

               RETURNS
                    
                    Student object containing the data from the file.
          */
          private static Student String_To_Student(string line)
          {
               try
               {
                    Student temp = new Student();
                    string[] values = line.Split(',');

                    temp.FirstName = values[1];
                    temp.LastName = values[2];
                    temp.StartLevel = Convert.ToChar(values[3]);
                    temp.CurrentLevel = Convert.ToChar(values[4]);
                    temp.GoalLevel = Convert.ToChar(values[5]);

                    return temp;
               }
               catch(Exception e)
               {
                    new Log(e, "IO.cs: String_To_Student", "Error loading student from file.");
               }

               return null;
          }

          /*
               NAME

                    IO::String_To_Note - Imports the data from a file

               SYNOPSIS

                    Note String_To_Note(string line);

                         line      --> the line of text from an import file

               DESCRIPTION

                    This function converts a line of text from a file to a note object and returns it.

               RETURNS
                    
                    Note object containing the data from the file.
          */
          private static Note String_To_Note(string line)
          {
               try
               {
                    Note temp = new Note();
                    string[] data = line.Split(',');
                    temp.student_id = Convert.ToInt32(data[2]); //skip 0 and 1, since they represent "note" and note id, which will be generated for new class to ensure uniqueness
                    temp.date = data[3];
                    temp.note = data[4];
                    temp.category = data[5];

                    return temp;
               }
               catch(Exception e)
               {
                    new Log(e, "IO.cs: String_To_Note", "Error loading note data from file");
               }

               return null;

          }

          /*
               NAME

                    IO::Generate_File_Date - Generates the date in a file friendly format.

               DESCRIPTION

                    This function uses today's date to generate a string that can uniquely identify a student export file.

               RETURNS
                    
                    String of the date in the preferred format.
          */
          private static string Generate_File_Date()
          {
               DateTime current_date_and_time = DateTime.Now;
               string month = current_date_and_time.Month.ToString();
               string day = current_date_and_time.Day.ToString();
               string year = current_date_and_time.Year.ToString();
               string hour = current_date_and_time.Hour.ToString();
               string minute = current_date_and_time.Minute.ToString();

               string result = month + "." + day + "." + year + "." + hour + "." + minute;
               return result;
          }

          /*
               NAME

                    IO::Students_To_File - Exports students to individual files

               SYNOPSIS

                    void Students_To_File (List<Student> students);

                         students       --> a list of student objects to be exported.

               DESCRIPTION

                    This function takes each student and saves their data to a unique file.
          */
          //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file
          public static void Students_To_File (List<Student> students) 
          {
               try
               {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\HomeroomHelper\";
                    foreach (Student s in students)
                    {
                         string filename = path + s.FirstName + s.LastName + Generate_File_Date() + ".csv";

                         string line = "";
                         line += s.ID + ",";
                         line += s.FirstName + ",";
                         line += s.LastName + ",";
                         line += s.StartLevel + ",";
                         line += s.CurrentLevel + ",";
                         line += s.GoalLevel + Environment.NewLine;

                         System.IO.File.WriteAllText(filename, line);

                         List<Note> notes = Database_Interface.Query_Note(s.ID);
                         foreach(Note n in notes)
                         {
                              string note_line = "note,";
                              note_line += n.id + ",";
                              note_line += n.student_id + ",";
                              note_line += n.date + ",";
                              note_line += n.note + ",";
                              note_line += n.category + Environment.NewLine;

                              System.IO.File.AppendAllText(filename, note_line);
                         }

                         List<History_Entry> entries = Database_Interface.Query_History_Entries(s.ID);
                         foreach(History_Entry h in entries)
                         {
                              string entry_line = "entry,";
                              entry_line += h.id + ",";
                              entry_line += h.student_id + ",";
                              entry_line += h.date + ",";
                              entry_line += h.current_lvl + Environment.NewLine;

                              System.IO.File.AppendAllText(filename, entry_line);
                         }

                    }
               }
               catch(Exception e)
               {
                    new Log(e, "IO.cs: Students_To_File", "Failed to save student data to file.");
               }
          }

          /*
               NAME

                    IO::Teacher_To_File - Exports teacher data to csv file

               SYNOPSIS

                    void Teacher_To_File (Teacher teacher);

                         teacher       --> the teacher object to save

               DESCRIPTION

                    This function takes the teacher object and saves its data to teacher.csv.
          */
          public static void Teacher_To_File (Teacher teacher)
          {
               try
               {
                    string file = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\HomeroomHelper\Settings\teacher.csv";
                    string teacher_data = "";
                    teacher_data += teacher.First_Name + ",";
                    teacher_data += teacher.Last_Name + ",";
                    teacher_data += teacher.Grade;

                    System.IO.File.WriteAllText(file, teacher_data);
               }
               catch(Exception e)
               {
                    new Log(e, "IO.cs: Teacher_To_File", "Error saving teacher to file.");
               }
          }

          /*
               NAME

                    IO::Load_Teacher - Exports teacher data to csv file

               DESCRIPTION

                    This function takes the teacher.csv and loads its data into a Teacher object.

               RETURNS 

                    A teacher object containing the data from teacher.csv
          */
          public static Teacher Load_Teacher()
          {
               //Load file
               string[] teacher_data = { };
               try
               {
                    string file = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\HomeroomHelper\Settings\teacher.csv";
                    StreamReader reader = new StreamReader(file);
                    teacher_data = reader.ReadLine().Split(',');

                    //Create teacher object
                    Teacher temp = new Teacher();
                    temp.First_Name = teacher_data[0];
                    temp.Last_Name = teacher_data[1];
                    temp.Grade = teacher_data[2];

                    return temp;
               }
               catch(FileNotFoundException e)
               {
                    new Log(e, "IO.cs: Load_Teacher", "teacher file not found. could not load teacher data.");
               }
               catch (Exception e)
               {
                    new Log(e, "IO.cs: Load_Teacher", "failed to read teacher from file.");
               }

               return null; //if exception occurs, return null

          }
     }
}
