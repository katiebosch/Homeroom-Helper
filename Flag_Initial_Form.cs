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
     public partial class Flag_Initial_Form : Form
     {
          /// <summary>
          /// The supporting class for the initial flag form.
          /// </summary>

          /*
               NAME

                    Flag_Initial_Form::Flag_Initial_Form - The constructor to initialize the form.

               DESCRIPTION

                    Initializes the form in a stable state.
                
          */
          public Flag_Initial_Form()
          {
               InitializeComponent();
          }

          private int response;

          public int Response
          {
               get { return response; }
          }

          /*
               NAME

                    Flag_Initial_Form::Positive_Button_Click - event that returns a positive response and closes this form.

               SYNOPSIS

                    void Flag_Initial_Form::Positive_Button_Click(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the Positive button is clicked. It sets the response to 1, and then closes this form 
                    and returns to the previous menu.

          */
          private void Positive_Button_Click(object sender, EventArgs e)
          {
               response = 1;
               DialogResult = DialogResult.OK;
          }

          /*
               NAME

                    Flag_Initial_Form::Neutral_Button_Click - event that returns a neutral response and closes this form.

               SYNOPSIS

                    void Flag_Initial_Form::Neutral_Button_Click(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the Neutral button is clicked. It sets the response to 0, and then closes this form 
                    and returns to the previous menu.

          */
          private void Neutral_Button_Click(object sender, EventArgs e)
          {
               response = 0;
               DialogResult = DialogResult.OK;
          }

          /*
               NAME

                    Flag_Initial_Form::Negative_Button_Click - event that returns a negative response and closes this form.

               SYNOPSIS

                    void Flag_Initial_Form::Negative_Button_Click(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the Negative button is clicked. It sets the response to -1, and then closes this form 
                    and returns to the previous menu.

          */
          private void Negative_Button_Click(object sender, EventArgs e)
          {
               response = -1;
               DialogResult = DialogResult.OK;
          }

          /*
               NAME

                    Flag_Initial_Form::Cancel_Button_Click - event that returns a canceled flag and closes this form.

               SYNOPSIS

                    void Flag_Initial_Form::Cancel_Button_Click(object sender, EventArgs e);

                    sender           --> object sending the event.
                    e                --> the event arguments.

               DESCRIPTION

                    This function triggers when the Cancel button is clicked. It sets the response to 100, which lets 
                    the calling form know that the user has canceled, and then closes this form and returns to the previous menu.

          */
          private void Cancel_Button_Click(object sender, EventArgs e)
          {
               response = 100;
               DialogResult = DialogResult.OK;
          }
     }
}
