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
     public partial class Conference_Form : Form
     {
          /// <summary>
          /// The class supporting the Student Conferences form.
          /// </summary>

          /*
          NAME

             Conference_Form::Conference_Form - The constructor for the class

          DESCRIPTION

             This function will instantiate the form. It also loads the student 
             names into the combobox on the form.
          */
          public Conference_Form()
          {
               InitializeComponent();

               //Load ComboBox
               List<string[]> names = Database_Interface.Query_Student_Names();
               foreach (string[] name in names)
               {
                    Student_Select.Items.Add(name[0] + " " + name[1]);
                    students.Add(name);
               }

          }

          //Class variables
          private int current_student_id; //Changes when selection changes
          private List<string[]> students = new List<string[]>();

          /*
          NAME

                   Conference_Form::Home_Button_Click - Returns the student to the main menu.

          SYNOPSIS

                    void Home_Button_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function closes the current form and redirects the user to the main menu.
          */
          private void Home_Button_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          /*
          NAME

                   Conference_Form::Student_Select_SelectedIndexChanged - event that triggers when the user selects a new student.

          SYNOPSIS

                    void Student_Select_SelectedIndexChanged(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function triggers when the user selects a new student from the combobox.
          */
          private void Student_Select_SelectedIndexChanged(object sender, EventArgs e)
          {
               int combobox_id = Student_Select.SelectedIndex;
               string[] fullname = new string[2];
               fullname[0] = students[combobox_id][0];
               fullname[1] = students[combobox_id][1];

               //MessageBox.Show(fullname[0] + " " + fullname[1]);
               current_student_id = Database_Interface.Query_ID(fullname[0], fullname[1]);
               Refresh_Notes();
          }

          /*
          NAME

                   Conference_Form::Add_Note_Click - event that triggers when the user clicks the Add Note button.

          SYNOPSIS

                    void Add_Note_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function triggers when the user clicks the Add Note button. 
                  The function first verifies that a student has been selected.
                  Then, the function creates a new note and sends it to the database.
          */
          private void Add_Note_Click(object sender, EventArgs e)
          {
               if(!(Student_Select.SelectedIndex > -1))
               {
                    MessageBox.Show("Please select a student.", "Error");
                    return;
               }

               using(New_Note_Form new_note = new New_Note_Form())
               {
                    if(new_note.ShowDialog() == DialogResult.OK)
                    {
                         string category = new Conference_Types(new_note.Category).Type;
                         Database_Interface.Add_Note(current_student_id, new_note.Note, category);
                    }
               }
               Refresh_Notes();
          }

          /*
          NAME

                   Conference_Form::Refresh_Notes - refreshes the notes window.

          DESCRIPTION

                  This function refreshes the notes window by clearing it, and then reloading from the database.
          */
          private void Refresh_Notes()
          {
               notes.Items.Clear();
               List<Note> student_notes = Database_Interface.Query_Note(current_student_id);

               //Display in listview
               foreach (Note n in student_notes)
               {
                    ListViewItem item = new ListViewItem(new string[] { Convert.ToString(n.id), Convert.ToString(n.student_id), n.date, n.note, n.category});
                    notes.Items.Add(item);
               }
          }

          /*
          NAME

                   Conference_Form::Edit_Note_Click - event that triggers when the user clicks the Edit Note button.

          SYNOPSIS

                    void Edit_Note_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function triggers when the user clicks the Edit Note button. 
                  First, it verifies that the user has selected a note from the view.
                  It creates a note object and sends it to a form to edit the note.
          */
          private void Edit_Note_Click(object sender, EventArgs e)
          {
               //If nothing selected, pop-up message
              if(notes.SelectedItems.Count == 0)
               {
                    MessageBox.Show("Please select a note to edit");
                    return;
               }
               Note edit_note = new Note();
               ListViewItem item = notes.SelectedItems[0];
               edit_note.id = Convert.ToInt32(item.SubItems[0].Text);
               edit_note.student_id = Convert.ToInt32(item.SubItems[1].Text);
               edit_note.date = item.SubItems[2].Text;
               edit_note.note = item.SubItems[3].Text;
               edit_note.category = item.SubItems[4].Text;

               using (New_Note_Form edit = new New_Note_Form())
               {
                    edit.Note = edit_note.note;
                    if (edit.ShowDialog() == DialogResult.OK)
                    {
                         Database_Interface.Update_Note(edit_note.id, edit.Note, new Conference_Types(edit.Category).Type);
                    }

               }
               Refresh_Notes();
                    
          }

          /*
          NAME

                   Conference_Form::Delete_Note_Click - event that triggers when the user 
                   clicks the Delete Note button.

          SYNOPSIS

                    void Delete_Note_Click(object sender, EventArgs e);

                      sender           --> the object sending the event.
                      e                --> the event arguments.

          DESCRIPTION

                  This function triggers when the user clicks the Delete Note button. 
                  First, the function verifies that a note has been selected. Then, it 
                  gets the note id and sends it to the database to be deleted. 
                  Finally, it refreshes the view.
          */
          private void Delete_Note_Click(object sender, EventArgs e)
          {
               //If nothing selected, pop-up message
               if (notes.SelectedItems.Count == 0)
               {
                    MessageBox.Show("Please select a note to delete");
                    return;
               }

               int note;
               ListViewItem item = notes.SelectedItems[0];
               note = Convert.ToInt32(item.SubItems[0].Text);

               Database_Interface.Delete_Note(note);

               Refresh_Notes();
          }
     }
}
