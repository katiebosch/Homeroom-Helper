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
     public partial class Help_Reader_Form : Form
     {
          /// <summary>
          /// The supporting class for the Help a Reader form.
          /// </summary>
          List<Student> students;

          /*
               NAME

                    Help_Reader_Form::Help_Reader_Form - constructor for this form.

               DESCRIPTION

                    This function loads the form in a stable state. It also loads the combobox with student names
                    that the user can select.

          */
          public Help_Reader_Form()
          {
               InitializeComponent();
               Populate_Combobox();
          }

          /*
               NAME

                    Help_Reader_Form::Home_Button_Click - event that closes this form.

               SYNOPSIS

                    void Help_Reader_Form::Home_Button_Click(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the Home button is clicked. It closes this form 
                    and returns the user to the previous menu.

          */
          private void Home_Button_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          /*
               NAME

                    Help_Reader_Form::Student_List_SelectedIndexChanged - event that changes the reading level
                    based on the student.

               SYNOPSIS

                    void Help_Reader_Form::Student_List_SelectedIndexChanged(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the selected student has changed. It loads their current 
                    reading level from the database into a textbox to be viewed.

          */
          private void Student_List_SelectedIndexChanged(object sender, EventArgs e)
          {
               //Save id in hidden textbox
               int id = students.ElementAt(Student_List.SelectedIndex).ID;
               Student_ID_Box.Text = id.ToString();

               //Load current reading lvl
               char lvl = Database_Interface.Query_Student(id).CurrentLevel;
               Reading_Lvl_Txtbox.Text = lvl.ToString();
          }

          /*
               NAME

                    Help_Reader_Form::Populate_Combobox - event that populates the combobox with student names.

               DESCRIPTION

                    This function loads all student names from the database into the combobox in a "First Last" format.

          */
          private void Populate_Combobox()
          {
               students = Database_Interface.Query_All_Students(); //Query db for all students
               foreach (Student s in students)
               {
                    Student_List.Items.Add(s.FirstName + " " + s.LastName); //Add names to combobox
               }

               for(char c = 'A'; c <= 'Z'; c++)
               {
                    Level.Items.Add(c);
               }
          }

          /*
               NAME

                    Help_Reader_Form::Level_Up_Button_Click - event that increases the reading level
                    of that student by 1.

               SYNOPSIS

                    void Help_Reader_Form::Level_Up_Button_Click(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the user clicks the "Level Up!" button. It increases the student 
                    level by 1, or does nothing if they've reached the maximum reading level.

          */
          private void Level_Up_Button_Click(object sender, EventArgs e)
          {
               DialogResult result = MessageBox.Show("Are you sure you want to level up this student?", "Are you sure?", MessageBoxButtons.YesNo);
               if (result == DialogResult.Yes)
               {
                    //Increase reading level by 1
                    string student_id = Student_ID_Box.Text;
                    int id = Convert.ToInt32(Student_ID_Box.Text);
                    char current_level = Database_Interface.Query_Reading_Level(id);
                    if (!current_level.Equals('Z')) 
                    {
                         char new_level = (char)(Convert.ToUInt16(current_level) + 1);
                         Database_Interface.Update_Reading_Lvl(student_id, new_level);

                         //Refresh current level
                         char lvl = Database_Interface.Query_Student(id).CurrentLevel;
                         Reading_Lvl_Txtbox.Text = lvl.ToString();
                    }
               }
          }

          /*
               NAME

                    Help_Reader_Form::Level_SelectedIndexChanged - event that changes the display
                    based on the selected reading level.

               SYNOPSIS

                    void Help_Reader_Form::Level_SelectedIndexChanged(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the user changes the reading level selection. It changes
                    the display so that the information shown is related to the selected reading level.

          */
          private void Level_SelectedIndexChanged(object sender, EventArgs e)
          {
               Reading_Level_Panel.Rows.Clear();

               //Load labels
               char lvl = Level.SelectedItem.ToString()[0];
               List<string[]> list = new Reading_Levels(lvl).Suggestions;
               foreach (string[] s in list) //https://stackoverflow.com/questions/22420503/add-row-dynamically-in-tablelayoutpanel
               {
                    Reading_Level_Panel.Rows.Add(s);
               }
          }

          /*
               NAME

                    Help_Reader_Form::Assess_Flag - gets the initial flag level
                    according to the user's initial assessment.

               DESCRIPTION

                    When the user starts the flag evaluation process, they first select 
                    their initial observation of the situation. This function generates that form
                    and records the response to pass back to the rest of this code.

               RETURNS

                    An integer that indicates what the user's response was.

          */
          private int Assess_Flag()
          {
               //Start chain of forms
               this.Hide();
               int response = 100;
               using (Flag_Initial_Form ff = new Flag_Initial_Form())
               {
                    if (ff.ShowDialog() == DialogResult.OK) //https://www.codeproject.com/Questions/650309/Csharp-Windows-Forms-Creating-Checkboxes
                    {
                         response = ff.Response;
                    }
               }

               this.Show();
               return response;
          }

          /*
               NAME

                    Help_Reader_Form::Engagement_and_Independence_Button_Click - event that generates the flag form
                    for the Engagement and Independence category.

               SYNOPSIS

                    void Help_Reader_Form::Engagement_and_Independence_Button_Click(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the user clicks the Engagement and Independence button. It calls
                    another function to generate a flag form for the "EI" category.

          */
          private void Engagement_and_Independence_Button_Click(object sender, EventArgs e) 
          {
               Generate_Form("EI");               
          }

          /*
               NAME

                    Help_Reader_Form::Generate_Form - creates the form and the objects
                    on the form so the flag can be evaluated.

               SYNOPSIS

                    void Generate_Form(string button);

                         button    --> the button that the user selected from the main form. (EI, VS, PW, PI)

               DESCRIPTION

                    When the user starts the flag evaluation process, they first select 
                    their initial observation of the situation. This function accepts that response, and generates the
                    next form based off of it.  It then evaluates the data and provides information on how
                    to handle that flag situation in the classroom.

          */
          private void Generate_Form(string button)
          {
               Flag_Assess_Form fa;
               do
               {
                    //Inital assessment
                    int response = Assess_Flag(); //1 = positive, 0 = neutral, -1 = negative, 100 = cancel

                    //Generate form
                    fa = new Flag_Assess_Form(response, button);

                    fa.ShowDialog();

               } while (fa.Result == "N/A");


               List<string> list = new List<string>();
               if(fa.Result != "N/A" && fa.Result != "Cancel")
               {
                    list = new Flag_Category(fa.Result, button).Responses;
                    string summary = "";
                    foreach (string s in list)
                    {
                         summary += s + Environment.NewLine;
                    }
                    MessageBox.Show(summary, fa.Result.ToUpper() + " FLAG");
               }

          }

          /*
               NAME

                    Help_Reader_Form::Volume_and_Stamina_Button_Click - event that generates the flag form
                    for the Volume and Stamina category.

               SYNOPSIS

                    void Help_Reader_Form::Volume_and_Stamina_Button_Click(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the user clicks the Volume and Stamina button. It calls
                    another function to generate a flag form for the "VS" category.

          */
          private void Volume_and_Stamina_Button_Click(object sender, EventArgs e)
          {
               Generate_Form("VS");
          }

          /*
               NAME

                    Help_Reader_Form::Partner_Work_Button_Click - event that generates the flag form
                    for the Partner Work category.

               SYNOPSIS

                    void Help_Reader_Form::Partner_Work_Button_Click(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the user clicks the Partner Work button. It calls
                    another function to generate a flag form for the "PW" category.

          */
          private void Partner_Work_Button_Click(object sender, EventArgs e)
          {
               Generate_Form("PW");
          }

          /*
               NAME

                    Help_Reader_Form::Post_it_Button_Click - event that generates the flag form
                    for the Post-its category.

               SYNOPSIS

                    void Help_Reader_Form::Post_it_Button_Click(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the user clicks the Post-its button. It calls
                    another function to generate a flag form for the "PI" category.

          */
          private void Post_it_Button_Click(object sender, EventArgs e)
          {
               Generate_Form("PI");
          }

     }
}
