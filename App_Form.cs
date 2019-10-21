using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senior_Project
{
    public partial class App : Form
    {
          /// <summary>
          /// The class supporting the main menu form.
          /// </summary>

          /*
          NAME

             App_Form::App - The constructor for the class

          DESCRIPTION

             This function will instantiate the form. It also initializes the sentences on the dashboard.
          */
          public App()
        {
            InitializeComponent();
               string greeting = "Teacher";
               {
                    Teacher teacher = IO.Load_Teacher();
                    try
                    {
                         if (teacher.First_Name != string.Empty)
                         {
                              greeting = teacher.First_Name;
                         }
                    }
                    catch (Exception e)
                    {
                         new Log(e, "App_Form.cs: Constructor", "Teacher not assigned at start");
                    }
               }

               welcome_label.Text = "Welcome, " + greeting + "!";
               num_students_label.Text = "You have " + Database_Interface.Query_Num_Students() + " students in your class.";
               high_score.Text = "The highest reading level in your class is " + Database_Interface.Query_Max_Level() + ".";
        }

          /*
          NAME

                  App_Form::Manage_Classroom_Button_Click - event for the Manage Classroom button.

          SYNOPSIS

                    void Manage_Classroom_Button_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function triggers when the button is clicked.  It opens the Manage Classroom form.
          */
          private void Manage_Classroom_Button_Click(object sender, EventArgs e)
          {
               this.Hide();
               Class_Form cf = new Class_Form();
               cf.ShowDialog();
               this.Show();
          }

          /*
          NAME

                  App_Form::Conference_Button_Click - event for the Student Conferences button.

          SYNOPSIS

                    void Conference_Button_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function triggers when the button is clicked.  It opens the Student Conferences form.
          */
          private void Conference_Button_Click(object sender, EventArgs e)
          {
               this.Hide();
               Conference_Form cf = new Conference_Form();
               cf.ShowDialog();
               this.Show();
          }

          /*
          NAME

                  App_Form::Help_Reader_Button_Click - event for the Help a Reader button.

          SYNOPSIS

                    void Help_Reader_Button_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function triggers when the button is clicked.  It opens the Help a Reader form.
          */
          private void Help_Reader_Button_Click(object sender, EventArgs e)
          {
               this.Hide();
               Help_Reader_Form hrf = new Help_Reader_Form();
               hrf.ShowDialog();
               this.Show();
          }

          /*
          NAME

                  App_Form::Analysis_Class_Button_Click - event for the Analytics button.

          SYNOPSIS

                    void Analysis_Class_Button_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function triggers when the button is clicked.  It opens the Analytics form.
          */
          private void Analysis_Class_Button_Click(object sender, EventArgs e)
          {
               this.Hide();
               Analytics_Form af = new Analytics_Form();
               af.ShowDialog();
               this.Show();
          }
     }
}
