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
     public partial class Flag_Assess_Form : Form
     {
          /// <summary>
          /// The class that supports the Flag Assess form. This class can be used for any flag type or color.
          /// </summary>

          private string category;
          private Flag_Category flag_category;
          private int red_checked_counter;
          private int orange_checked_counter;
          private int yellow_checked_counter;
          private int green_checked_counter;
          private int blue_checked_counter;
          private bool hasWinner;
          private string result;

          public string Result
          {
               get
               {
                    if(hasWinner == true)
                    {
                         return Assess_Winner();
                    }
                    else
                    {
                         return result;
                    }

               }
          }

          /*
          NAME

                  Flag_Assess_Form::Flag_Assess_Form - the constructor for the form.

          SYNOPSIS

                  Flag_Assess_Form(int response, string n_category);
                                                                               
                      response             --> the trading object to be opened.
                      n_category           --> the amount of capital to apply.

          DESCRIPTION

                  This function initializes the form to a stable state. It also assigns 
                  key information to identify what kind of data needs to be pulled from the Flag Category class.
                  Finally, it populates the form with the questions needed to assess the flag color.
          */
          public Flag_Assess_Form(int response, string n_category)
          {
               InitializeComponent();
               category = n_category;
               flag_category = new Flag_Category(category);
               Populate_Form(response, flag_category);
          }

          /*
               NAME

                       Flag_Assess_Form::Assess_Winner - a function to determine which color identifes
                       the situation best.

               DESCRIPTION

                       This function evaluates which color has the most points in it. The points are 
                       determined when the user clicks on a checkbox that best fits their situation. It returns
                       a string with the color that had the most points.

               RETURNS

                       A string with the color that collected the most points.
          */
          private string Assess_Winner()
          {
               int max = 0;
               string winner = "";

               if(red_checked_counter > max)
               {
                    max = red_checked_counter;
                    winner = "red";
               }
               if(orange_checked_counter > max)
               {
                    max = orange_checked_counter;
                    winner = "orange";
               }
               if(yellow_checked_counter > max)
               {
                    max = yellow_checked_counter;
                    winner = "yellow";
               }
               if(green_checked_counter > max)
               {
                    max = green_checked_counter;
                    winner = "green";
               }
               if(blue_checked_counter > max)
               {
                    max = blue_checked_counter;
                    winner = "blue";
               }

               return winner;
          }

          /*
               NAME

                    Flag_Assess_Form::Cancel_Click - event that closes this form.

               SYNOPSIS

                    void Flag_Assess_Form::Cancel_Click(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the home button is clicked. It sets the result to "cancel", 
                    to indicate to the calling form that the action was canceled. It then closes this form 
                    and returns to the previous menu.

          */
          private void Cancel_Click(object sender, EventArgs e)
          {
               result = "Cancel";
               this.Close();
          }

          /*
               NAME

                    Flag_Assess_Form::Populate_Form - populates the form with checkboxes.

               SYNOPSIS

                    void Populate_Form(int response, Flag_Category category);

                              response         --> whether the observations are positive, neutral, or negative.
                              category         --> the button category (EI, VS, PW, PI).

               DESCRIPTION

                    This function populates the form based on the user's inital evaluation of the situation
                    in front of them.  Then, depending on the response, it calls functions to populate with 
                    blue, green, yellow, orange, or red checkboxes. 

          */
          private void Populate_Form(int response, Flag_Category category)
          {
               if (response == 1)
               {
                    Populate_Blue();
                    Populate_Green();
                    Populate_Yellow();
               }
               else if (response == 0)
               {
                    Populate_Green();
                    Populate_Yellow();
                    Populate_Orange();
               }
               else if (response == -1)
               {
                    Populate_Yellow();
                    Populate_Orange();
                    Populate_Red();
               }
          }

          /*
               NAME

                    Flag_Assess_Form::Blue_CheckedChanged - event that adds to the blue count.

               SYNOPSIS

                    void Blue_CheckedChanged(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when a blue checkbox has been checked. The checkbox
                    increments the total blue count to help determine the flag color later.

          */
          private void Blue_CheckedChanged(object sender, EventArgs e)
          {
               blue_checked_counter++;
          }

          /*
                NAME

                     Flag_Assess_Form::Green_CheckedChanged - event that adds to the green count.

                SYNOPSIS

                     void Green_CheckedChanged(object sender, EventArgs e);

                     sender           --> object sending the event.
                     e                --> the event arguments.

                DESCRIPTION

                     This function triggers when a green checkbox has been checked. The checkbox
                     increments the total green count to help determine the flag color later.

           */
          private void Green_CheckedChanged(object sender, EventArgs e)
          {
               green_checked_counter++;
          }

          /*
                NAME

                     Flag_Assess_Form::Yellow_CheckedChanged - event that adds to the yellow count.

                SYNOPSIS

                     void Yellow_CheckedChanged(object sender, EventArgs e);

                     sender           --> object sending the event.
                     e                --> the event arguments.

                DESCRIPTION

                     This function triggers when a yellow checkbox has been checked. The checkbox
                     increments the total yellow count to help determine the flag color later.

           */
          private void Yellow_CheckedChanged(object sender, EventArgs e)
          {
               yellow_checked_counter++;
          }

          /*
                 NAME

                      Flag_Assess_Form::Orange_CheckedChanged - event that adds to the orange count.

                 SYNOPSIS

                      void Orange_CheckedChanged(object sender, EventArgs e);

                      sender           --> object sending the event.
                      e                --> the event arguments.

                 DESCRIPTION

                      This function triggers when a orange checkbox has been checked. The checkbox
                      increments the total orange count to help determine the flag color later.

            */
          private void Orange_CheckedChanged(object sender, EventArgs e)
          {
               orange_checked_counter++;
          }

          /*
                 NAME

                      Flag_Assess_Form::Red_CheckedChanged - event that adds to the red count.

                 SYNOPSIS

                      void Red_CheckedChanged(object sender, EventArgs e);

                      sender           --> object sending the event.
                      e                --> the event arguments.

                 DESCRIPTION

                      This function triggers when a red checkbox has been checked. The checkbox
                      increments the total red count to help determine the flag color later.

            */
          private void Red_CheckedChanged(object sender, EventArgs e)
          {
               red_checked_counter++;
          }

          /*
               NAME

                       Flag_Assess_Form::Populate_Blue - a function to load the form with blue-related checkboxes.

               DESCRIPTION

                       This function sets the flag category in use to blue.  Then, it loads the observations from 
                       the flag category object to a list object. Then, it loops through that list object, making
                       a new checkbox for each string. It links each checkbox to an event and adds it to the form.
          */
          private void Populate_Blue()
          {
               flag_category.Color = "blue";

               List<string> blue_observations = new List<string>();
               blue_observations = flag_category.Observations;

               blue_checked_counter = 0;
               int cb_count = 0;

               foreach (string y in blue_observations)
               {
                    CheckBox cb = new CheckBox();
                    cb.Name = "blue" + cb_count;
                    cb_count++;
                    cb.Text = y;
                    cb.AutoSize = true;
                    cb.CheckedChanged += new EventHandler(Blue_CheckedChanged);
                    Group1.Controls.Add(cb);
               }
          }

          /*
               NAME

                       Flag_Assess_Form::Populate_Green - a function to load the form with green-related checkboxes.

               DESCRIPTION

                       This function sets the flag category in use to green.  Then, it loads the observations from 
                       the flag category object to a list object. Then, it loops through that list object, making
                       a new checkbox for each string. It links each checkbox to an event and adds it to the form.
          */
          private void Populate_Green()
          {
               flag_category.Color = "green";

               List<string> green_observations = new List<string>();
               green_observations = flag_category.Observations;

               green_checked_counter = 0;
               int cb_count = 0;

               foreach (string y in green_observations)
               {
                    CheckBox cb = new CheckBox();
                    cb.Name = "green" + cb_count;
                    cb_count++;
                    cb.Text = y;
                    cb.AutoSize = true;
                    cb.CheckedChanged += new EventHandler(Green_CheckedChanged);
                    Group1.Controls.Add(cb);
               }
          }

          /*
               NAME

                       Flag_Assess_Form::Populate_Yellow - a function to load the form with yellow-related checkboxes.

               DESCRIPTION

                       This function sets the flag category in use to yellow.  Then, it loads the observations from 
                       the flag category object to a list object. Then, it loops through that list object, making
                       a new checkbox for each string. It links each checkbox to an event and adds it to the form.
          */
          private void Populate_Yellow()
          {
               flag_category.Color = "yellow";

               List<string> yellow_observations = new List<string>();
               yellow_observations = flag_category.Observations;

               yellow_checked_counter = 0;
               int cb_count = 0;

               foreach (string y in yellow_observations)
               {
                    CheckBox cb = new CheckBox();
                    cb.Name = "yellow" + cb_count;
                    cb_count++;
                    cb.Text = y;
                    cb.AutoSize = true;
                    cb.CheckedChanged += new EventHandler(Yellow_CheckedChanged);
                    Group1.Controls.Add(cb);
               }
          }

          /*
              NAME

                      Flag_Assess_Form::Populate_Orange - a function to load the form with orange-related checkboxes.

              DESCRIPTION

                      This function sets the flag category in use to yellow.  Then, it loads the observations from 
                      the flag category object to a list object. Then, it loops through that list object, making
                      a new checkbox for each string. It links each checkbox to an event and adds it to the form.
         */
          private void Populate_Orange()
          {
               flag_category.Color = "orange";

               List<string> orange_observations = new List<string>();
               orange_observations = flag_category.Observations;

               orange_checked_counter = 0;
               int cb_count = 0;

               foreach (string y in orange_observations)
               {
                    CheckBox cb = new CheckBox();
                    cb.Name = "orange" + cb_count;
                    cb_count++;
                    cb.Text = y;
                    cb.AutoSize = true;
                    cb.CheckedChanged += new EventHandler(Orange_CheckedChanged);
                    Group1.Controls.Add(cb);
               }
          }

          /*
              NAME

                      Flag_Assess_Form::Populate_Red - a function to load the form with red-related checkboxes.

              DESCRIPTION

                      This function sets the flag category in use to red.  Then, it loads the observations from 
                      the flag category object to a list object. Then, it loops through that list object, making
                      a new checkbox for each string. It links each checkbox to an event and adds it to the form.
         */
          private void Populate_Red()
          {
               flag_category.Color = "red";

               List<string> red_observations = new List<string>();
               red_observations = flag_category.Observations;

               red_checked_counter = 0;
               int cb_count = 0;

               foreach (string y in red_observations)
               {
                    CheckBox cb = new CheckBox();
                    cb.Name = "red" + cb_count;
                    cb_count++;
                    cb.Text = y;
                    cb.AutoSize = true;
                    cb.CheckedChanged += new EventHandler(Red_CheckedChanged);
                    Group1.Controls.Add(cb);
               }
          }

          /*
               NAME

                    Flag_Assess_Form::Submit_Click - event that saves the data and closes this form.

               SYNOPSIS

                    void Submit_Click(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the submit button is clicked. It sets the hasWinner 
                    variable to true and closes the form. The calling form can then use the properties 
                    to access this information, even when the form is closed.

          */
          private void Submit_Click(object sender, EventArgs e)
          {
               hasWinner = true;
               this.Close();
          }

          /*
               NAME

                    Flag_Assess_Form::N_A_Button_Click - event that sets the result to N/A and closes this form.

               SYNOPSIS

                    void Flag_Assess_Form::Cancel_Click(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the None button is clicked. If the user determines that none of the 
                    checkboxes apply, they can choose "None" and the function will indicate to the program to try again
                    using this tag. Then, the form is closed.

          */
          private void N_A_Button_Click(object sender, EventArgs e)
          {
               result = "N/A";
               this.Close();
          }
     }
}
