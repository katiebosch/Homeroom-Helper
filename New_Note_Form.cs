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
     public partial class New_Note_Form : Form
     {
          /// <summary>
          /// The form for adding and editing notes, and getting conference information.
          /// </summary>
          /*
               NAME
                    
                    New_Note_Form::New_Note_Form - A constructor for the New_Note_Form class.

               DESCRIPTION

                    This function initializes the form in a stable state. It also populates the Table object with conference data.
          */
          public New_Note_Form()
          {
               InitializeComponent();
               Populate_Table();
          }

          public string Note
          {
               set { textbox_note.Text = value; }
               get { return textbox_note.Text; }
          }

          public int Category
          {
               set { Types.SelectedIndex = value; }
               get { return Types.SelectedIndex; }
          }

          /*
               NAME
                    
                    New_Note_Form::Populate_Table - populates the table with conference types and defaults.

               DESCRIPTION

                    This function loads the combobox in the table with the conference types, and sets the 
                    labels in the table to neutral so they are instantiated but not seen.
          */
          private void Populate_Table()
          {
               //Populate combobox
               for(int i = 0; i <= 5; i++)
               {
                    Types.Items.Add(new Conference_Types(i).Type);
               }

               description_label.Text = " ";
               usage_label.Text = " ";
               example_label.Text = " ";
          }

          /*
               NAME
                    
                    New_Note_Form::Cancel_Click - closes the form.

               SYNOPSIS

                    void Cancel_Click(object sender, EventArgs e);

                         sender         --> object sending event.
                         e              --> event arguments.

               DESCRIPTION

                    This function closes this form and goes back to the previous menu without making any changes.
          */
          private void Cancel_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          /*
               NAME
                    
                    New_Note_Form::New_Note_Click - sets the dialog result and closes the form.

               SYNOPSIS

                    void New_Note_Click(object sender, EventArgs e);

                         sender         --> object sending event.
                         e              --> event arguments.

               DESCRIPTION

                    This function sets the dialog result to OK so the calling form knows that it 
                    can retrieve the new data. Then it closes the form and returns to the previous menu.
          */
          private void New_Note_Click(object sender, EventArgs e)
          {
               DialogResult = DialogResult.OK;
          }

          /*
               NAME
                    
                    New_Note_Form::Types_SelectedIndexChanged - changes the data based on the selected conference type.

               SYNOPSIS

                    void Types_SelectedIndexChanged(object sender, EventArgs e);

                         sender         --> object sending event.
                         e              --> event arguments.

               DESCRIPTION

                    This function gets the index of the conference type and sets the labels to the related information from the struct.
          */
          private void Types_SelectedIndexChanged(object sender, EventArgs e) 
          {
               int new_id = Types.SelectedIndex;
               description_label.Text = new Conference_Types(new_id).Blurb;
               usage_label.Text = new Conference_Types(new_id).Usage;
               example_label.Text = new Conference_Types(new_id).Example;
          }

          /*
               NAME
                    
                    New_Note_Form::Back_Button_Click - closes the form.

               SYNOPSIS

                    void Back_Button_Click(object sender, EventArgs e);

                         sender         --> object sending event.
                         e              --> event arguments.

               DESCRIPTION

                    This function closes this form and goes back to the previous menu without making any changes.
          */
          private void Back_Button_Click(object sender, EventArgs e)
          {
               this.Close();
          }
     }
}
