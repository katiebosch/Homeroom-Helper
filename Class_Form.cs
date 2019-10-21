using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Senior_Project 
{
     public partial class Class_Form : Form
     {
          /// <summary>
          /// The class supporting the classroom manager form.
          /// </summary>

          /*
          NAME

             Class_Form::Class_Form - The constructor for the class

          DESCRIPTION

             This function will instantiate the form. It also refreshes the view to load the data.
          */
          public Class_Form()
          {
               InitializeComponent();
               Refresh_Data_Grid_View();
          }

          /*
          NAME

                  Class_Form::Populate_Data_Grid_View - loads data into the data grid view.

          DESCRIPTION

                  This function gets the student data from the database and loads it into the data grid view object.
          */
          private void Populate_Data_Grid_View()
          {
               //Get list of all students
               List<Student> all_students = Database_Interface.Query_All_Students();
               int num_students = Database_Interface.Query_Num_Students();

               //Add each student to student panel
               for (int i = 0; i < num_students; i++)
               {
                    string[] student = all_students.ElementAt(i).ToArray();
                    StudentPanel.Rows.Add(student);
               }

          }

          /*
          NAME

                  Class_Form::Refresh_Data_Grid_View - reloads data into the data grid view when data has been added.

          DESCRIPTION

                  This function clears the view and loads the updated information.
          */
          private void Refresh_Data_Grid_View()
          {
               StudentPanel.Rows.Clear();
               Populate_Data_Grid_View();
          }

          /*
          NAME

                   Class_Form::New_Student_Click - Verifies a student and sends him or her to the database.

          SYNOPSIS

                    void New_Student_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  Pulls the student data from the textboxes and verifies that the student is valid. 
                  Alerts user if student already exists, and asks for further action. If the student passes the checks,
                  the function sends the student to the database.
          */
          private void New_Student_Click(object sender, EventArgs e)  //https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
          {
               //Get all values from textbox
               Student new_student = Textboxes_To_Student();

               //if part of student is incorrect, do nothing! Let user edit and try again.
               if(new_student.FirstName == "" || new_student.LastName == "" || !Regex.IsMatch(new_student.StartLevel.ToString(), @"^[A-Z]+$") || !Regex.IsMatch(new_student.CurrentLevel.ToString(), @"^[A-Z]+$") || !Regex.IsMatch(new_student.GoalLevel.ToString(), @"^[A-Z]+$"))
               {
                    return;
               }

               if(Database_Interface.Query_Student_Exist(new_student.FirstName, new_student.LastName)) //if student already exists...
               {
                    DialogResult dialog = MessageBox.Show("Student already exists. Would you like to update their records?", "Student already exists", MessageBoxButtons.YesNo);
                    if(dialog == DialogResult.Yes)
                    {
                         Database_Interface.Update_Student(new_student);
                    }
                    else if(dialog == DialogResult.No)
                    {
                         return; //close dialog and do nothing
                    }
               }
               else if (cf_id.Text != "")
               {
                    Database_Interface.Update_Student(new_student);
               }
               else 
               {
                    Database_Interface.Add_Student(new_student);
               }
              
               Clear_TextBoxes();
               Refresh_Data_Grid_View();
          }

          /*
          NAME

                   Class_Form::Import_Student_Click - selects an import file and sends it to the database.

          SYNOPSIS

                    void Import_Student_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  Calls the import function from the IO class, and refreshes the view 
          */
          private void Import_Student_Click(object sender, EventArgs e)
          {
               if(IO.Import_One())
               {
                    Refresh_Data_Grid_View();
               }
          }

          /*
          NAME

                   Class_Form::Import_Many_Click - selects import files and sends it to the database.

          SYNOPSIS

                    void Import_Many_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  Calls the import many function from the IO class, and refreshes the view 
          */
          private void Import_Many_Click(object sender, EventArgs e)
          {
               if (IO.Import_Many())
               {
                    Refresh_Data_Grid_View();
               }
          }

          /*
          NAME

                   Class_Form::Export_One_Click - gets the selected student and sends to IO class to be exported.

          SYNOPSIS

                    void Export_One_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function gets the student data and sends it to the IO class. It also informs the user where the file will be saved.
          */
          private void Export_One_Click(object sender, EventArgs e)
          {
               List<Student> student = new List<Student>(); //create temporary list
               
               //Get student obj via textboxes
               Populate_Textboxes();
               Student export = Textboxes_To_Student();
               Clear_TextBoxes();

               student.Add(export); //Add student obj to list (only once since we are exporting one student, but this way we can reuse code)

               IO.Students_To_File(student);
               MessageBox.Show("Exports saved in HomeroomHelper directory");
          }

          /*
          NAME

                   Class_Form::Export_All_Click - sends all students to IO class to be exported.

          SYNOPSIS

                    void Export_All_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function takes all the student data and sends it to the IO class 
                  to be exported separately. It also informs the user where the files will be saved.
          */
          private void Export_All_Click(object sender, EventArgs e)
          {
               IO.Students_To_File(Database_Interface.Query_All_Students());
               MessageBox.Show("Exports saved in HomeroomHelper directory");
          }

          /*
          NAME

                   Class_Form::Delete_One_Click - deletes one selected student.

          SYNOPSIS

                    void Delete_One_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function gets the selected student and 
                  sends their details to the database interface 
                  to be deleted.
          */
          private void Delete_One_Click(object sender, EventArgs e)  
          {
               DialogResult result = MessageBox.Show("Are you sure you want to delete this student? (This will also delete all notes associated with the student.)", "Delete Student", MessageBoxButtons.YesNo);
               if(result == DialogResult.Yes)
               {
                    //Populate_Textboxes();
                    //Student to_delete = Textboxes_To_Student();

                    //Get row
                    DataGridViewRow row = StudentPanel.SelectedRows[0];

                    //Get id
                    int to_delete = Convert.ToInt32(row.Cells[0].Value); //Cannot cast properly

                    //Delete notes and student info
                    Database_Interface.Delete_Notes(to_delete);
                    Database_Interface.Delete_Student(to_delete);

                    //Refresh view
                    Clear_TextBoxes();
                    Refresh_Data_Grid_View();
               }
               else { return; }

          }

          /*
          NAME

                   Class_Form::Delete_All_Click - deletes all students.

          SYNOPSIS

                    void Delete_All_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function verifies that the user wants to pursue 
                  this action. If yes, the database interface drops all 
                  tables and recreates them.
          */
          private void Delete_All_Click(object sender, EventArgs e)
          {
               DialogResult result = MessageBox.Show("Are you sure you want to delete all students? (This will also delete all notes.)", "Delete Student", MessageBoxButtons.YesNo);
               if (result == DialogResult.Yes)
               {
                    Database_Interface.Delete_All_Students();
                    Clear_TextBoxes();
                    Refresh_Data_Grid_View();
               }
               else { return; }
          }

          /*
          NAME

                   Class_Form::Home_Click - returns to the main menu.

          SYNOPSIS

                    void Home_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function closes this form and returns the user to the main menu.
          */
          private void Home_Click(object sender, EventArgs e)  //home is open in background, just hidden, so close this form and show the other
          {
               this.Close();
          }

          /*
          NAME

                   Class_Form::Textboxes_To_Student - turns the information in 
                   the textboxes into a student object.

          DESCRIPTION

                  This function gets the information from the textboxes, verifies that it is valid and saves it to a student object.
                  This is so that the information can stay together as it is used by other functions.

          RETURNS
                    
                  Returns Student object containing the information from the textboxes on the form. 
          */
          private Student Textboxes_To_Student()
          {
               Student temp = new Student();
               if(cf_id.Text != "")
               {
                    temp.ID = Convert.ToInt32(cf_id.Text);
               }

               if(cf_fname.Text != "" && Regex.IsMatch(cf_fname.Text.ToUpper(), @"^[A-Z]+$"))
               {
                    temp.FirstName = cf_fname.Text.Trim();
               }
               else { MessageBox.Show("Please enter a first name."); }

               if (cf_lname.Text != "" && Regex.IsMatch(cf_lname.Text.ToUpper(), @"^[A-Z]+$"))
               {
                    temp.LastName = cf_lname.Text.Trim();
               }
               else { MessageBox.Show("Please enter a last name."); }

               if(cf_o_rdglvl.Text != "" && Regex.IsMatch(cf_o_rdglvl.Text.ToUpper(), @"^[A-Z]+$")) //https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=netframework-4.8
               {
                    temp.StartLevel = cf_o_rdglvl.Text.ToUpper()[0]; 
               }
               else { MessageBox.Show("Please enter an original reading level."); }

               if(cf_cur_rdglvl.Text != "" && Regex.IsMatch(cf_cur_rdglvl.Text.ToUpper(), @"^[A-Z]+$"))
               {
                    temp.CurrentLevel = cf_cur_rdglvl.Text.ToUpper()[0];
               }
               else { MessageBox.Show("Please enter a current reading level."); }

               if(cf_goal_rdglvl.Text != "" && Regex.IsMatch(cf_goal_rdglvl.Text.ToUpper(), @"^[A-Z]+$"))
               {
                    temp.GoalLevel = cf_goal_rdglvl.Text.ToUpper()[0];
               }
               else { MessageBox.Show("Please enter a goal reading level."); }

               return temp;
          }

          /*
          NAME

                   Class_Form::Clear_TextBoxes - Clears the data in the textboxes.

          DESCRIPTION

                  This function clears the textboxes so the user can enter new information.

          */
          private void Clear_TextBoxes()
          {
               cf_id.Clear();
               cf_fname.Clear();
               cf_lname.Clear();
               cf_o_rdglvl.Clear();
               cf_cur_rdglvl.Clear();
               cf_goal_rdglvl.Clear();
          }

          /*
          NAME

                  Class_Form::Populate_Textboxes - Populates the textboxes with student information.

          DESCRIPTION

                  This function populates the textboxes with the information in the data grid view.
                  The textboxes are the only way the user can add or edit information, and it is verified
                  before entering the database.

          */
          private void Populate_Textboxes()
          {
               try
               {
                    int row = StudentPanel.CurrentCell.RowIndex;
                    if (StudentPanel.Rows[row].Cells[1].Value != null)
                    {
                         cf_id.Text = StudentPanel.Rows[row].Cells[0].Value.ToString();
                         cf_fname.Text = StudentPanel.Rows[row].Cells[1].Value.ToString();
                         cf_lname.Text = StudentPanel.Rows[row].Cells[2].Value.ToString();
                         cf_o_rdglvl.Text = StudentPanel.Rows[row].Cells[3].Value.ToString();
                         cf_cur_rdglvl.Text = StudentPanel.Rows[row].Cells[4].Value.ToString();
                         cf_goal_rdglvl.Text = StudentPanel.Rows[row].Cells[5].Value.ToString();
                    }
               }
               catch (Exception)
               {
                    //write to log
                    MessageBox.Show("Error loading student data");
                    return;
               }
          }

          /*
          NAME

                   Class_Form::StudentPanel_SelectionChanged_1 - event for when the user selects a student from the view.

          SYNOPSIS

                    void StudentPanel_SelectionChanged_1(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function triggers when the user selects a new student from the view.  It calls the 
                  Populate Textboxes function so the user can edit the information.
          */
          private void StudentPanel_SelectionChanged_1(object sender, EventArgs e)
          {
               Populate_Textboxes();
          }

          /*
           NAME

                    Class_Form::Clear_Button_Click - event for calling the function to clear the textboxes.

           SYNOPSIS

                     void Clear_Button_Click(object sender, EventArgs e);

                       sender           --> the object sending the event.
                       e                --> the event arguments.

           DESCRIPTION

                   This function triggers when the user clicks on the Clear Textboxes button. It calls the 
                   Clear Textboxes function.
           */
          private void Clear_Button_Click(object sender, EventArgs e)
          {
               Clear_TextBoxes();
          }
     }
}
