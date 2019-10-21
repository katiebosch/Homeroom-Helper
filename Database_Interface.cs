using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Senior_Project
{
    static class Database_Interface
    {
          /// <summary>
          /// This class is how the program connects to the database. 
          /// </summary>

          static SQLiteConnection m_dbConnection= new SQLiteConnection(@"Data Source=Students.sqlite;Version=3;");

          //Creates the database and tables
          public static void Create_DB()
          {
               SQLiteConnection.CreateFile("Students.sqlite"); //Create database

               //Create Students Table
               {
                    //Create connection
                    bool wasOpen = false;

                    if (m_dbConnection.State == System.Data.ConnectionState.Closed)
                    {
                         m_dbConnection.Open();
                         wasOpen = true;
                    }


                    string sql;

                    //Create student table

                    sql = "CREATE TABLE IF NOT EXISTS students (id INT, fname VARCHAR(20), lname VARCHAR(20), startingLvl VARCHAR(1), currentLvl VARCHAR(1), goalLvl VARCHAR(1))";

                    //Execute sql command on server -> load command
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

                    //Execute command 
                    command.ExecuteNonQuery();

                    //Add example student to table 
                    Add_Student("Example", "Student", 'A', 'C', 'E');

                    if (wasOpen == false)
                    {
                         m_dbConnection.Close();
                    }
               }

               //Create Notes Table
               {
                    //Create connection
                    bool wasOpen = false;

                    if (m_dbConnection.State == System.Data.ConnectionState.Closed)
                    {
                         m_dbConnection.Open();
                         wasOpen = true;
                    }

                    //Create notes table
                    string sql = "CREATE TABLE IF NOT EXISTS notes (id INT, student_id INT, date VARCHAR(10), note VARCHAR(500), category VARCHAR(30))";

                    //Execute sql command on server -> load command
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

                    //Execute command 
                    command.ExecuteNonQuery();

                    //Add example note to table
                    Add_Note(1, "Example note. You can post up to 500 characters", "Demonstration");

                    if (wasOpen == false)
                    {
                         m_dbConnection.Close();
                    }
               }

               //Create History Table
               {
                    //Create connection
                    bool wasOpen = false;

                    if (m_dbConnection.State == System.Data.ConnectionState.Closed)
                    {
                         m_dbConnection.Open();
                         wasOpen = true;
                    }

                    //Create table
                    string sql = "CREATE TABLE IF NOT EXISTS history (id INT, student_id INT, date VARCHAR(10), level VARCHAR(1))";

                    //Load command
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

                    //Execute command
                    command.ExecuteNonQuery();
                    Add_History(-1, -1, 'A');

                    if (wasOpen == false)
                    {
                         m_dbConnection.Close();
                    }
               }
          }

          /*-----------------*/
          /*Student Functions*/
          /*-----------------*/

          /*
          NAME

                  Database_Interface::Add_Student - Adds a student to the database.

          SYNOPSIS

                  void Add_Student(string firstName, string lastName, char startingLevel, char currentLevel, char goalLevel);
                                                                                
                      firstName        --> student's first name.
                      lastName         --> student's last name.
                      startingLevel    --> the reading level of the student at the start of the school year.
                      currentLevel     --> the current reading level of the student.
                      goalLevel        --> the goal level for the student by the end of the year.

                  void Add_Student(Student student)

                      student          --> student object containing all necessary information.

          DESCRIPTION

                  This function connects to the database and executes the SQL function to add a new student. 
                  It generates a new student id, and inputs the other data to associate with that id. It also
                  starts the history for the student in the History table.
          */
          private static void Add_Student(string firstName, string lastName, char startingLevel, char currentLevel, char goalLevel)    //override adding students to db
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               int student_id = Student.Generate_Student_ID();
               SQLiteCommand sql = m_dbConnection.CreateCommand();
               sql.CommandText = "INSERT INTO students ( id, fname, lname, startingLvl, currentLvl, goalLvl) VALUES (@ID, @FNAME, @LNAME, @SLVL, @CLVL, @GLVL);";
               sql.Parameters.Add("@ID", System.Data.DbType.Int32).Value = student_id;
               sql.Parameters.Add("@FNAME", System.Data.DbType.String).Value = firstName;
               sql.Parameters.Add("@LNAME", System.Data.DbType.String).Value = lastName;
               sql.Parameters.Add("@SLVL", System.Data.DbType.String).Value = startingLevel;
               sql.Parameters.Add("@CLVL", System.Data.DbType.String).Value = currentLevel;
               sql.Parameters.Add("@GLVL", System.Data.DbType.String).Value = goalLevel;
               sql.ExecuteNonQuery();

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               Add_History(student_id, currentLevel);

          }
          public static void Add_Student(Student student)
          {
               bool student_exists = Query_Student_Exist(student.FirstName, student.LastName);
               DialogResult result = DialogResult.No; //Will default to adding student if does not exist

               //Check if student exists. If so, ask user how to proceed.
               if (student_exists == true)
               {
                    result = MessageBox.Show("This student already exists. Would you like to update their record? \r\n Yes - Update record. No - Import another record. Cancel - Go back to classroom manager.", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
               }

               if (result == DialogResult.Yes)
               {
                    Update_Student(student); //Use update query instead
               }
               else if (result == DialogResult.No)
               {
                    Add_Student(student.FirstName, student.LastName, student.StartLevel, student.CurrentLevel, student.GoalLevel);
               }
               else if (result == DialogResult.Cancel)
               {
                    //Do nothing
               }
          }
          public static void Add_Students(List<Student> students)
          {
               foreach (Student s in students)
               {
                    Add_Student(s.FirstName, s.LastName, s.StartLevel, s.CurrentLevel, s.GoalLevel);
               }
          } //Add multiple students

          /*
          NAME

                  Database_Interface::Update_Student - Update a student's info in the database.

          SYNOPSIS

                  void Update_Student(Student student);
                                                                                
                      student        --> student object contaning all student data.

          DESCRIPTION

                  This function connects to the database and executes the SQL function to  update an existing student. 
                  It matches the student id and updates based on the new information provided. It also adds a history
                  entry for the student at this point in time.
          */
          public static void Update_Student(Student student)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               SQLiteCommand sql = m_dbConnection.CreateCommand();
               sql.CommandText = "UPDATE students SET fname = @FNAME, lname = @LNAME, startingLvl = @SLVL, currentLvl = @CLVL, goalLvl = @GLVL WHERE id = @ID";
               sql.Parameters.Add("@ID", System.Data.DbType.Int32).Value = student.ID;
               sql.Parameters.Add("@FNAME", System.Data.DbType.String).Value = student.FirstName;
               sql.Parameters.Add("@LNAME", System.Data.DbType.String).Value = student.LastName;
               sql.Parameters.Add("@SLVL", System.Data.DbType.String).Value = student.StartLevel;
               sql.Parameters.Add("@CLVL", System.Data.DbType.String).Value = student.CurrentLevel;
               sql.Parameters.Add("@GLVL", System.Data.DbType.String).Value = student.GoalLevel;
               sql.ExecuteNonQuery();

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               Add_History(student.ID, student.CurrentLevel);
          }

          /*
          NAME

                  Database_Interface::Delete_Student - Deletes a student entirely from the database.

          SYNOPSIS

                  void Delete_Student(int id);
                                                                                
                      id        --> student's unique identifier

          DESCRIPTION

                  This function connects to the database and executes the SQL function to delete an existing student. 
                  It matches the student id and deletes the student data so it can no longer be accessed. If the student table is empty, 
                  it drops all tables and calls the Create_DB function.
          */
          public static void Delete_Student(int id)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               string sql = "DELETE FROM students WHERE id = " + id;
               SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
               command.ExecuteNonQuery();

               if (Query_Num_Students() == 0)
               {
                    try
                    {
                         //Drop Students table
                         sql = "DROP Table 'students'";
                         command = new SQLiteCommand(sql, m_dbConnection);
                         command.ExecuteNonQuery();
                         command.Dispose(); //free memory

                         //Drop notes table
                         sql = "DROP Table 'notes'";
                         command = new SQLiteCommand(sql, m_dbConnection);
                         command.ExecuteNonQuery();

                         //Drop history table
                         sql = "DROP Table 'history'";
                         command = new SQLiteCommand(sql, m_dbConnection);
                         command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                         new Log(e, "DB_Interface.cs: Delete_Student", "Cannot delete tables.");
                    }
                    finally
                    {
                         Create_DB();
                    }

               }

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

          }
          public static void Delete_All_Students()
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               try
               {
                    //Drop Students table
                    string sql = "DROP Table 'students'";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    command.Dispose(); //free memory

                    //Drop notes table
                    sql = "DROP Table 'notes'";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();

                    //Drop history table
                    sql = "DROP Table 'history'";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
               }
               catch (Exception e)
               {
                    new Log(e, "DB_Interface.cs: Delete_All_Students", "Could not drop tables.");
               }


               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               //Reset DB
               Create_DB();
          } //Deletes all students from the database

          /*
          NAME

                  Database_Interface::Query_All_Students - Queries all data about all students in the database.

          DESCRIPTION

                  This function connects to the database and executes the SQL query for all fields on all students. 
                  It returns those students as individual objects to better encapsulate the data.

          RETURNS
               
               List of Students containing all student data in the student table.
                  
          */
          public static List<Student> Query_All_Students()
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               List<Student> students_arr = new List<Student>();
               try
               {
                    //Use SQL to query by reading level
                    string sql = "SELECT * FROM students ORDER BY lname";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    SQLiteDataReader reader = command.ExecuteReader(); //Returns all students info

                    //Parse data and create temp student models
                    while (reader.Read())
                    {
                         Student temp = new Student(Convert.ToInt32(reader["id"]), reader["fname"].ToString(), reader["lname"].ToString(), Convert.ToChar(reader["startingLvl"]), Convert.ToChar(reader["currentLvl"]), Convert.ToChar(reader["goalLvl"]));
                         students_arr.Add(temp);
                    }
               }
               catch (Exception e)
               {
                    new Log(e, "DB_Interface.cs: Query_All_Students", "No student table exists");
               }


               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               //Return student array
               return students_arr;
          }

          /*
          NAME

                  Database_Interface::Query_Student_Names - Queries all the first and last names of all students.

          DESCRIPTION

                  This function connects to the database and executes the SQL query for the first and last name fields on all students. 
                  It returns the names as individual string arrays, each with 2 indicies.

          RETURNS
               
               List of string arrays. Each array is a first and last name together.
                  
          */
          public static List<string[]> Query_Student_Names()
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               List<string[]> names = new List<string[]>();

               try
               {
                    //Use SQL to query by reading level
                    string sql = "SELECT fname, lname FROM students";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    SQLiteDataReader reader = command.ExecuteReader(); //Returns all student names

                    //Parse data and create list

                    while (reader.Read())
                    {
                         string[] temp = new string[2];
                         temp[0] = reader["fname"].ToString();
                         temp[1] = reader["lname"].ToString();
                         names.Add(temp);
                    }
               }
               catch (Exception e)
               {
                    new Log(e, "DB_Interface.cs: Query_Student_Names", "No student table exists");
               }


               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               return names;
          }

          /*
          NAME

                  Database_Interface::Query_Student_Exist - Queries all the first and last names of all students.

          SYNOPSIS

                  Boolean Query_Student_Exist(string firstname, string lastname);

                         firstname      --> student's first name.
                         lastname       --> student's last name.

          DESCRIPTION

                  This function connects to the database and executes the SQL query for the first and last name fields on one student. 
                  It returns whether or not the student exists in the database. This is used to check before adding a new student to 
                  see if that student has already been created.

          RETURNS
               
               True if student exists in table, false is student does not exist in the table.
                  
          */
          public static Boolean Query_Student_Exist(string firstname, string lastname)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               //Use SQL to query by reading level
               string sql = "SELECT * FROM students WHERE fname = '" + firstname + "' AND lname = '" + lastname + "'";
               SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
               SQLiteDataReader reader = command.ExecuteReader(); //Returns all student names

               //Parse data and create list
               bool doesExist = false;
               if (reader.HasRows) { doesExist = true; }

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               return doesExist;
          }

          /*
          NAME

                  Database_Interface::Query_Num_Students - Queries the number of students in the table.

          DESCRIPTION

                  This function connects to the database and executes the SQL query for the number of students in the student table.
                  It returns an integer of the student count. 

          RETURNS
               
                  An integer representing the count of students in the table. 
                  
          */
          public static int Query_Num_Students()  //count number of students stored in db
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               int count = 0;
               try
               {
                    //Use SQL to query by reading level
                    string sql = "SELECT COUNT(id) FROM students";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    SQLiteDataReader reader = command.ExecuteReader();

                    //Get returned count from reader
                    count = Convert.ToInt32(reader[0]);
               }
               catch (Exception e)
               {
                    new Log(e, "DB_Interface.cs", "Student table does not exist");
               }

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               return count;
          }

          /*
               NAME

                         Database_Interface::Query_Student - Queries the information about one student.

               SYNOPSIS

                         Student Query_Student(int student_id);

                              student_id          --> the unique id for a student.

               DESCRIPTION

                         This function connects to the database and executes the SQL query for all 
                         of the data related to one student id.
                         It returns a student object containing that data.

               RETURNS

                         A student object containing all the data related to the given student id.

          */
          public static Student Query_Student(int student_id)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               //Use SQL to query by reading level
               string sql = "SELECT * FROM students WHERE id = " + student_id;
               SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
               SQLiteDataReader reader = command.ExecuteReader(); //Returns all student names

               //Create student to return
               Student student = new Student(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), Convert.ToChar(reader[3]), Convert.ToChar(reader[4]), Convert.ToChar(reader[5]));

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               return student;
          }

          /*
               NAME

                         Database_Interface::Query_ID - Queries the id of one student.

               SYNOPSIS

                         int Query_ID(string firstname, string lastname);

                              firstname          --> the first name of the student.
                              lastname           --> the last name of the student.

               DESCRIPTION

                         This function connects to the database and executes the SQL query for the id
                         of the student identified by first and last name.
                         It returns an integer representation of that id.

               RETURNS

                         The student's id in integer format.

          */
          public static int Query_ID(string firstname, string lastname)
          {
               int id;
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               //Use SQL to query by reading level
               string sql = "SELECT id FROM students WHERE fname = '" + firstname + "' AND lname = '" + lastname + "'";
               SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
               SQLiteDataReader reader = command.ExecuteReader();

               //Get id from reader
               reader.Read();
               id = Convert.ToInt32(reader[0]);

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               return id;
          }

          /*--------------*/
          /*Note Functions*/
          /*--------------*/

          /*
               NAME

                         Database_Interface::Add_Note - Adds a note.

               SYNOPSIS

                         void Add_Note(int student_id, string note, string category);

                              student_id          --> the id of the student.
                              note                --> the note contents.
                              category            --> the conference category from Conference_Types.cs

                         void Add_Note(Note import_note);

                              import_note         --> all note data in a Note object.

               DESCRIPTION

                         This function connects to the database and executes the SQL query to add
                         a new note to the notes table.
          */
          public static void Add_Note(int student_id, string note, string category)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               SQLiteCommand sql = m_dbConnection.CreateCommand();
               sql.CommandText = "INSERT INTO notes (id, student_id, date, note, category) VALUES (@ID, @STUDENT_ID, @DATE, @NOTE, @CAT);";
               sql.Parameters.Add("@ID", System.Data.DbType.Int32).Value = Note.Generate_Note_ID();
               sql.Parameters.Add("@STUDENT_ID", System.Data.DbType.Int32).Value = student_id;
               sql.Parameters.Add("@DATE", System.Data.DbType.String).Value = DateTime.Now.ToString("MM.dd.yyyy");
               sql.Parameters.Add("@NOTE", System.Data.DbType.String).Value = note;
               sql.Parameters.Add("@CAT", System.Data.DbType.String).Value = category;
               sql.ExecuteNonQuery();

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }
          }
          public static void Add_Note(Note import_note)
          {
               Add_Note(import_note.student_id, import_note.note, import_note.category);
          }

          /*
               NAME

                         Database_Interface::Update_Note - Updates a note.

               SYNOPSIS

                         void Update_Note(int student_id, string note, string category);

                              note_id             --> the id of the note.
                              note                --> the note contents.
                              category            --> the conference category from Conference_Types.cs

               DESCRIPTION

                         This function connects to the database and executes the SQL query to update
                         a note to the notes table.
          */
          public static void Update_Note(int note_id, string note, string category)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               SQLiteCommand sql = m_dbConnection.CreateCommand();
               sql.CommandText = "UPDATE notes SET note = @NOTE, category = @CAT, date = @DATE WHERE id = @ID";
               sql.Parameters.Add("@ID", System.Data.DbType.Int32).Value = note_id;
               sql.Parameters.Add("@NOTE", System.Data.DbType.String).Value = note;
               sql.Parameters.Add("@CAT", System.Data.DbType.String).Value = category;
               sql.Parameters.Add("@DATE", System.Data.DbType.String).Value = DateTime.Now.ToString("MM.dd.yyyy");
               sql.ExecuteNonQuery();

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }
          }

          /*
               NAME

                         Database_Interface::Delete_Note - Deletes a selected note from the table.

               SYNOPSIS

                         void Delete_Note(int id);

                              id             --> the id of the note.

               DESCRIPTION

                         This function connects to the database and executes the SQL query to update
                         a note to the notes table.
          */
          public static void Delete_Note(int id)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               SQLiteCommand sql = m_dbConnection.CreateCommand();
               sql.CommandText = "DELETE FROM notes WHERE id = @ID";
               sql.Parameters.Add("@ID", System.Data.DbType.Int32).Value = id;
               sql.ExecuteNonQuery();

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }
          }
          public static void Delete_Notes(int student_id)
          {
               int note_count = Query_Num_Notes(student_id); //Get number of notes before deleting them

               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               string sql = "DELETE FROM notes WHERE student_id = " + student_id;
               SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
               command.ExecuteNonQuery();

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

          } //Deletes all notes associated with a student id

          /*
               NAME

                         Database_Interface::Query_Num_Notes - Gets a count of the notes in the table.

               SYNOPSIS

                         int Query_Num_Notes(int id);

                              id             --> the id of the note.

                         int Query_Num_Notes();


               DESCRIPTION

                         This function connects to the database and executes the SQL query to get the count for
                         the number of notes in the table, both in general or the ones associated with one student.

               RETURNS
                    
                         An integer count of all notes.
          */
          public static int Query_Num_Notes()
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               //Use SQL to query by reading level
               string sql = "SELECT COUNT(id) FROM notes";
               SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
               SQLiteDataReader reader = command.ExecuteReader();

               //Get returned count from reader
               int count = Convert.ToInt32(reader[0]);

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               return count;
          }
          public static int Query_Num_Notes(int id)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               //Use SQL to query by reading level
               string sql = "SELECT COUNT(id) FROM notes WHERE student_id=" + id;
               SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
               SQLiteDataReader reader = command.ExecuteReader();

               //Get returned count from reader
               int count = Convert.ToInt32(reader[0]);

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               return count;
          }

          /*
               NAME

                         Database_Interface::Query_Note - Returns all notes related to a student id.

               SYNOPSIS

                         List<Note> Query_Note(int id);

                              id             --> the id of the student.

               DESCRIPTION

                         This function connects to the database and executes the SQL query to get all the 
                         fields for all notes associated with the given student id.
               
               RETURN

                         A list of Note objects containing all the note data for that one student.
          */
          public static List<Note> Query_Note(int id)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               //Use SQL to query by reading level
               string sql = "SELECT * FROM notes WHERE student_id =" + id;
               SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
               SQLiteDataReader reader = command.ExecuteReader();

               //Get notes from reader
               List<Note> notes = new List<Note>();
               while (reader.Read())
               {
                    Note temp = new Note();
                    temp.id = Convert.ToInt32(reader[0]);
                    temp.student_id = Convert.ToInt32(reader[1]);
                    temp.date = Convert.ToString(reader[2]);
                    temp.note = Convert.ToString(reader[3]);
                    temp.category = Convert.ToString(reader[4]);
                    notes.Add(temp);
               }

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               return notes;
          }


          /*-----------------*/
          /*History Functions*/
          /*-----------------*/

          /*
               NAME

                         Database_Interface::Query_Num_History_Entries - Returns the total number of history entries.

               DESCRIPTION

                         This function connects to the database and executes the SQL query to get all the 
                         fields for all notes associated with the given student id.

               RETURN
                         
                         An integer count of the number of history entries in the table.
          */
          public static int Query_Num_History_Entries()
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               //Use SQL to query by reading level
               string sql = "SELECT COUNT(id) FROM history";
               SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
               SQLiteDataReader reader = command.ExecuteReader();

               //Get returned count from reader
               int count = Convert.ToInt32(reader[0]);

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               return count;
          }

          /*
               NAME

                         Database_Interface::Query_History_Entries - Returns all the history entries.

               SYNOPSIS
                         
                         List<History_Entry> Query_History_Entries(int student_id);
                                   
                                   student_id          --> the id of the student.

                         List<History_Entry> Query_History_Entries();

               DESCRIPTION

                         This function connects to the database and executes the SQL query to get all the 
                         history entries, either for one student or in general.

               RETURN
                         
                         A list of the history entries and their data.
          */
          public static List<History_Entry> Query_History_Entries()
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               //Use SQL to query by reading level
               string sql = "SELECT * FROM history";
               SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
               SQLiteDataReader reader = command.ExecuteReader();

               //Get notes from reader
               List<History_Entry> entries = new List<History_Entry>();
               while (reader.Read())
               {
                    History_Entry temp = new History_Entry();
                    temp.id = Convert.ToInt32(reader[0]);
                    temp.student_id = Convert.ToInt32(reader[1]);
                    temp.date = Convert.ToString(reader[2]);
                    temp.current_lvl = Convert.ToChar(reader[3]);
                    entries.Add(temp);
               }

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               return entries;
          } //ALL entries for ALL students
          public static List<History_Entry> Query_History_Entries(int student_id) //ALL entries for student with matching id
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               //Use SQL to query by reading level
               string sql = "SELECT * FROM history WHERE student_id =" + student_id;
               SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
               SQLiteDataReader reader = command.ExecuteReader();

               //Get notes from reader
               List<History_Entry> entries = new List<History_Entry>();
               while (reader.Read())
               {
                    History_Entry temp = new History_Entry();
                    temp.id = Convert.ToInt32(reader[0]);
                    temp.student_id = Convert.ToInt32(reader[1]);
                    temp.date = Convert.ToString(reader[2]);
                    temp.current_lvl = Convert.ToChar(reader[3]);
                    entries.Add(temp);
               }

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               return entries;
          }

          /*
               NAME

                         Database_Interface::Add_History - Adds history entry data to the table.

               SYNOPSIS
                         
                         void Add_History(int student_id, char current_lvl);
                                   
                                   student_id          --> the id of the student.
                                   current_lvl         --> the current reading level of the student.

                         void Add_History(int entry_id, int student_id, char current_lvl);

                                   entry_id            --> the id of the history entry to add.
                                   student_id          --> the id of the student.
                                   current_lvl         --> the current reading level of the student.

                         void Add_History(int entry_id, int student_id, string date, char current_lvl);
                              
                                   entry_id            --> the id of the history entry to add.
                                   student_id          --> the id of the student.
                                   date                --> the date and time of the entry.
                                   current_lvl         --> the current reading level of the student.
                         
                         void Add_History(History_Entry import_entry);

                                   import_entry        --> the history entry data encapsulated in an object.


               DESCRIPTION

                         This function connects to the database and executes the SQL query to add a history entry 
                         to the database. The entry is used to display the student's progress in the analytics tab.
          */
          public static void Add_History(int student_id, char current_lvl)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               try
               {
                    SQLiteCommand sql = m_dbConnection.CreateCommand();
                    sql.CommandText = "INSERT INTO history (id, student_id, date, level) VALUES (@ID, @STUDENT_ID, @DATE, @LVL);";
                    sql.Parameters.Add("@ID", System.Data.DbType.Int32).Value = History_Entry.Generate_Entry_ID();
                    sql.Parameters.Add("@STUDENT_ID", System.Data.DbType.Int32).Value = student_id;
                    sql.Parameters.Add("@DATE", System.Data.DbType.String).Value = DateTime.Now.ToString("MM.dd.yyyy");
                    sql.Parameters.Add("@LVL", System.Data.DbType.String).Value = current_lvl;
                    sql.ExecuteNonQuery();
               }
               catch(Exception e)
               {
                    new Log(e, "DB_Interface.cs: Add History", "Could not insert history");
               }
               

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }
          }
          private static void Add_History(int entry_id, int student_id, char current_lvl)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               SQLiteCommand sql = m_dbConnection.CreateCommand();
               sql.CommandText = "INSERT INTO history (id, student_id, date, level) VALUES (@ID, @STUDENT_ID, @DATE, @LVL);";
               sql.Parameters.Add("@ID", System.Data.DbType.Int32).Value = entry_id;
               sql.Parameters.Add("@STUDENT_ID", System.Data.DbType.Int32).Value = student_id;
               sql.Parameters.Add("@DATE", System.Data.DbType.String).Value = DateTime.Now.ToString("MM.dd.yyyy");
               sql.Parameters.Add("@LVL", System.Data.DbType.String).Value = current_lvl;
               sql.ExecuteNonQuery();

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }
          }
          private static void Add_History(int entry_id, int student_id, string date, char current_lvl)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               SQLiteCommand sql = m_dbConnection.CreateCommand();
               sql.CommandText = "INSERT INTO history (id, student_id, date, level) VALUES (@ID, @STUDENT_ID, @DATE, @LVL);";
               sql.Parameters.Add("@ID", System.Data.DbType.Int32).Value = entry_id;
               sql.Parameters.Add("@STUDENT_ID", System.Data.DbType.Int32).Value = student_id;
               sql.Parameters.Add("@DATE", System.Data.DbType.String).Value = date;
               sql.Parameters.Add("@LVL", System.Data.DbType.String).Value = current_lvl;
               sql.ExecuteNonQuery();

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }
          }
          public static void Add_History(History_Entry import_entry)
          {
               Add_History(import_entry.id, import_entry.student_id, import_entry.date, import_entry.current_lvl);
          }

          /*--------------*/
          /*Misc Functions*/
          /*--------------*/

          /*
               NAME

                         Database_Interface::Query_Max_Level - Returns the maximum reading level.

               DESCRIPTION

                         This function connects to the database and executes the SQL query to find the maximum
                         reading level of all students. This is then displayed on the dashboard to help the teacher gauge 
                         their class.

               RETURN
                         
                         The character representing the highest reading level of the students.
          */
          public static char Query_Max_Level()
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               char max_lvl = 'A';

               try
               {
                    //Use SQL to query by reading level
                    string sql = "SELECT MAX(currentLvl) FROM students";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    SQLiteDataReader reader = command.ExecuteReader(); //Returns all students info

                    //Parse data and create temp student models
                    max_lvl = reader[0].ToString()[0];
               }
               catch (Exception e)
               {
                    new Log(e, "DB_Interface.cs: Query_Max_Level", "No table for students");
               }


               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               //Return student array
               return max_lvl;
          }

          /*
               NAME

                         Database_Interface::Update_Reading_Lvl - Updates a student's current reading level.

               SYNOPSIS
                    
                         void Update_Reading_Lvl(string student_id, char current_lvl);
                              
                                   student_id          --> the id of the student.
                                   current_lvl         --> the current reading level of the student.
                         
               DESCRIPTION

                         This function connects to the database and executes the SQL query to update a student's
                         reading level.
          */
          public static void Update_Reading_Lvl(string student_id, char current_lvl)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               try
               {
                    SQLiteCommand sql = m_dbConnection.CreateCommand();
                    sql.CommandText = "UPDATE students SET currentLvl = @CLVL WHERE id = @ID";
                    sql.Parameters.Add("@ID", System.Data.DbType.Int32).Value = student_id;
                    sql.Parameters.Add("@CLVL", System.Data.DbType.String).Value = current_lvl;
                    sql.ExecuteNonQuery();

                    Add_History(Convert.ToInt32(student_id), current_lvl);
               }
               catch(Exception e)
               {
                    new Log(e, "DB_Interface.cs: Update_Reading_Level", "Could not update student reading level");
               }

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }
               
          }

          /*
               NAME

                         Database_Interface::Query_Reading_Level - Gets the students at a reading level.

               SYNOPSIS

                         List<Student> Query_Reading_Level(char readingLevel);
                              
                                   readingLevel        --> the reading level to query.

               DESCRIPTION

                         This function connects to the database and executes the SQL query to find the students
                         whose current level match the given reading level.

               RETURN
                         
                         A list of students who are at the current reading level.
          */
          public static List<Student> Query_Reading_Level(char readingLevel)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               //Use SQL to query by reading level
               string sql = "SELECT id, fname, lname FROM students WHERE currentLvl = " + readingLevel;
               SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
           
               SQLiteDataReader reader = command.ExecuteReader(); //Returns all students of that reading level

               //Parse data and create temp student models
               List<Student> students_arr = new List<Student>();
               while (reader.Read())
               {
                    Student temp = new Student((int)reader["id"], reader["fname"].ToString(), reader["lname"].ToString(), readingLevel);
                    students_arr.Add(temp);
               }

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               //Return student array
               return students_arr;
          }

          /*
               NAME

                         Database_Interface::Query_Reading_Level - Gets the reading level of the given student.

               SYNOPSIS

                         char Query_Reading_Level(int id);
                              
                                   id        --> the student id.

               DESCRIPTION

                         This function connects to the database and executes the SQL query to find the current reading 
                         level of the given student. 

               RETURN
                         
                         The reading level of the student in character format.
          */
          public static char Query_Reading_Level(int id)
          {
               bool wasOpen = false;

               if (m_dbConnection.State == System.Data.ConnectionState.Closed)
               {
                    m_dbConnection.Open();
                    wasOpen = true;
               }

               char currentLvl = 'A';
               try
               {

                    //Use SQL to query by reading level
                    string sql = "SELECT currentLvl FROM students WHERE id = " + id;
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

                    SQLiteDataReader reader = command.ExecuteReader(); //Returns all students of that reading level
                    currentLvl = Convert.ToChar(reader[0].ToString()[0]);

               }
               catch(Exception e)
               {
                    new Log(e, "DB_Interface.cs: Query_Reading_Level", "Could not retrieve currentLvl");
               }

               if (wasOpen == false)
               {
                    m_dbConnection.Close();
               }

               return currentLvl;
          }
     }
}
