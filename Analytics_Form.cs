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
     public partial class Analytics_Form : Form
     {
          /// <summary>
          /// This class is to support the functionality of the Analytics Form.
          /// </summary>

          private List<Student> students;

          /*
          NAME

                  Analytics_Form::Analytics_Form - Form Constructor

          DESCRIPTION

                  This function initializes the Analytics_Form.  
                  It also instantiates the elements of the form - the 
                  bar graph, line graph, and level average.
          */
          public Analytics_Form()
          {
               InitializeComponent();
               students = Database_Interface.Query_All_Students();
               Instantiate_Bar_Graph();
               Instantiate_Avg_Textbox();
               Instantiate_Names_Combobox();
          }

          /*
          NAME

                  Analytics_Form::Instantiate_Bar_Graph - initializes the bar graph on this form

          DESCRIPTION

                  This function collects the data needed for the bar graph and displays it 
                  through a chart object on the form. The data is gathered from the database 
                  in a dictionary, and then shown on the graph using a key-value pair.

          */
          private void Instantiate_Bar_Graph()
          //https://www.c-sharpcorner.com/UploadFile/1e050f/chart-control-in-windows-form-application/
          {
               Dictionary<char, int> tally = new Dictionary<char, int>(); //char -> reading level, int -> count of how many
               foreach (Student s in students)
               {
                    char cur_lvl = s.CurrentLevel;  //https://stackoverflow.com/questions/10830228/count-the-characters-individually-in-a-string-using-c-sharp 
                    if (tally.ContainsKey(cur_lvl))
                    {
                         tally[cur_lvl]++;
                    }
                    else
                    {
                         tally.Add(cur_lvl, 1);
                    }
               }//each char has a count of how many students are at that level

               foreach(KeyValuePair<char, int> c in tally)
               {
                    char key = (char)c.Key;
                    Lvl_Counts_Chart.Series["Number of Students"].Points.AddXY(key.ToString(), c.Value);
               }

          }

          /*
          NAME

                  Analytics_Form::Instantiate_Avg_Textbox - displays reading level average

          DESCRIPTION

                  This function calculates the average reading level and displays it in a textbox.
          */
          private void Instantiate_Avg_Textbox()
          {
               List<char> lvls = new List<char>(); 
               foreach(Student s in students) 
               {
                    lvls.Add(s.CurrentLevel);
               }
               double avg = lvls.Average(x=>x); //Get average character
               Avg_Lvl_Txtbox.Text = ((char)avg).ToString();
          }

          /*
          NAME

                  Analytics_Form::Instantiate_Names_Combobox - load names from the 
                  database into the combobox on the form.

          DESCRIPTION

                  This function retrieves a list of students from the database and 
                  adds them to the combobox.  This will allow the user to easily 
                  select a student from their class.
          */
          private void Instantiate_Names_Combobox()
          {
               foreach (Student s in students)
               {
                    Student_Names.Items.Add(s.FirstName + " " + s.LastName); //Add names to combobox
               }
          }

          /*
          NAME

               Analytics_Form::Home_Button_Click - event that closes this form.

          SYNOPSIS

               void Analytics_Form::Home_Button_Click(object sender, EventArgs e);

               sender           --> object sending the event.
               e                --> the event arguments.

          DESCRIPTION

               This function triggers when the home button is clicked. It closes this form 
               and returns to the main menu.

          */
          private void Home_Button_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          /*
          NAME

               Analytics_Form::Student_Names_SelectedIndexChanged - event for changing the name in the combobox.


          SYNOPSIS

               void Analytics_Form::Student_Names_SelectedIndexChanged(object sender, EventArgs e);

               sender           --> object sending the event.
               e                --> the event arguments.

          DESCRIPTION

               This function will trigger when the selected index in the combobox changes. In other words, when
               the user selects a new student, the line graph will change to reflect that student.
          */
          private void Student_Names_SelectedIndexChanged(object sender, EventArgs e)
          {
               //Save id in hidden textbox
               int id = students.ElementAt(Student_Names.SelectedIndex).ID;
               Student_ID_Box.Text = id.ToString();

               //Display line graph based on student id
               Instantiate_Line_Graph(id);

          }

          /*
          NAME

                  Analytics_Form::Instantiate_Line_Graph - instantiates the line graph for a student.

          SYNOPSIS

                 void Analytics_Form::Instantiate_Line_Graph(int id);

                      id             --> the id of the selected student.

          DESCRIPTION

                  This function retrieves the historical data using the student's id, 
                  and displays it in a line graph using a chart object.
          */
          private void Instantiate_Line_Graph(int id)
          {
               Lvl_History_Chart.Series.Clear();
               Lvl_History_Chart.Series.Add("Reading Levels");
               Lvl_History_Chart.Series["Reading Levels"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
               //Lvl_History_Chart.ChartAreas.Add("Reading Levels");

               List<History_Entry> entries = new List<History_Entry>();
               entries = Database_Interface.Query_History_Entries(id); //all entries for that student



               foreach (History_Entry he in entries)
               {
                    Lvl_History_Chart.Series["Reading Levels"].Points.AddXY(he.date, (int)he.current_lvl);
               }

               Lvl_History_Chart.DataBind();

          }

     }
}
