using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Senior_Project
{
    public partial class Welcome_Form : Form
    {

          /// <summary>
          /// The supporting code for the Welcome form.
          /// </summary>
          /// 
          /*
               NAME
                    
                    Welcome_Form::Welcome_Form - Constructor for the welcome form

               DESCRIPTION

                    Initializes the welcome form in a stable state.
          */
          public Welcome_Form()
          {
               InitializeComponent();
          }

          /*
               NAME
                    
                    Welcome_Form::Textboxes_To_Teacher - Converts data in textboxes to teacher object

               DESCRIPTION

                    Gets the data in the textboxes on the form and encapsulates them in a teacher object.

               RETURNS

                    Teacher object containing the data.
          */
          private Teacher Textboxes_To_Teacher()
          {
               Teacher teach = new Teacher();
               teach.First_Name = First_Name_Box.Text.Trim();
               teach.Last_Name = Last_Name_Box.Text.Trim();
               teach.Grade = Grade_Box.Text;
               return teach;
          }

          /*
               NAME
                    
                    Welcome_Form::Create_Button_Click - event invoked when user clicks "Create classroom from scratch"

               SYNOPSIS

                    void Create_Button_Click(object sender, EventArgs e);

                         sender    --> object sending event
                         e         --> event arguments

               DESCRIPTION

                    This function verifies that the user has entered valid teacher data, and if so, opens the Manage
                    Classroom form.
          */
          private void Create_Button_Click(object sender, EventArgs e) //go to manage class room form
          {
               //Save teacher data
               if(Verify_Teacher_Data() == false)
               {
                    return;
               }
               else
               {
                    IO.Teacher_To_File(Textboxes_To_Teacher());
               }
               this.Hide();

               App app = new App();
               Class_Form new_class = new Class_Form();
               new_class.ShowDialog();
               app.ShowDialog();

               this.Close();
          }

          /*
               NAME
                    
                    Welcome_Form::Verify_Teacher_Data - a function that verifies that the teacher data has been entered

               DESCRIPTION

                    This function verifies that the user has entered valid teacher data, and returns a boolean value
                    indicating so.

               RETURNS
                    
                    True if user entered data, else false.
          */
          private bool Verify_Teacher_Data()
          {
               if(First_Name_Box.Text == string.Empty || Last_Name_Box.Text == string.Empty || Grade_Box.SelectedIndex == -1)
               {
                    MessageBox.Show("Please input your information before selecting an option");
                    return false;
               }
               else
               {
                    return true;
               }
          }

          /*
               NAME
                    
                    Welcome_Form::Import_Button_Click - event invoked when user clicks "Import students"

               SYNOPSIS

                    void Import_Button_Click(object sender, EventArgs e);

                         sender    --> object sending event
                         e         --> event arguments

               DESCRIPTION

                    This function verifies that the user has entered valid teacher data, and if so, begins the importing process.
                    If import is canceled, it returns to the welcome form and does nothing.
          */
          private void Import_Button_Click(object sender, EventArgs e)
          {
               //Save teacher data
               if (Verify_Teacher_Data() == false)
               {
                    return;
               }
               else
               {
                    IO.Teacher_To_File(Textboxes_To_Teacher());
               }

               //Attempt to import
               if(IO.Import_Many() == true)
               {
                    this.Hide();
                    App app = new App();
                    Class_Form new_class = new Class_Form();
                    new_class.ShowDialog();
                    app.ShowDialog();
                    this.Close();
               }

          }


     }
}
