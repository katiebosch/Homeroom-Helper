namespace Senior_Project
{
     partial class Conference_Form
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.Home_Button = new System.Windows.Forms.Button();
               this.notes = new System.Windows.Forms.ListView();
               this.note_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.student_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
               this.label1 = new System.Windows.Forms.Label();
               this.add_note = new System.Windows.Forms.Button();
               this.edit_note = new System.Windows.Forms.Button();
               this.delete_note = new System.Windows.Forms.Button();
               this.Student_Select = new System.Windows.Forms.ComboBox();
               this.SuspendLayout();
               // 
               // Home_Button
               // 
               this.Home_Button.Location = new System.Drawing.Point(13, 13);
               this.Home_Button.Name = "Home_Button";
               this.Home_Button.Size = new System.Drawing.Size(88, 31);
               this.Home_Button.TabIndex = 0;
               this.Home_Button.Text = "Home";
               this.Home_Button.UseVisualStyleBackColor = true;
               this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
               // 
               // notes
               // 
               this.notes.Activation = System.Windows.Forms.ItemActivation.OneClick;
               this.notes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.note_id,
            this.student_id,
            this.date,
            this.note,
            this.type});
               this.notes.FullRowSelect = true;
               this.notes.HoverSelection = true;
               this.notes.Location = new System.Drawing.Point(12, 90);
               this.notes.Name = "notes";
               this.notes.ShowItemToolTips = true;
               this.notes.Size = new System.Drawing.Size(451, 348);
               this.notes.TabIndex = 1;
               this.notes.UseCompatibleStateImageBehavior = false;
               this.notes.View = System.Windows.Forms.View.Details;
               // 
               // note_id
               // 
               this.note_id.Text = "Note ID";
               this.note_id.Width = 1;
               // 
               // student_id
               // 
               this.student_id.Text = "Student ID";
               this.student_id.Width = 1;
               // 
               // date
               // 
               this.date.Text = "Date";
               this.date.Width = 78;
               // 
               // note
               // 
               this.note.Text = "Note";
               this.note.Width = 292;
               // 
               // type
               // 
               this.type.Text = "Type";
               this.type.Width = 74;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(14, 66);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(87, 13);
               this.label1.TabIndex = 3;
               this.label1.Text = "Select a student:";
               // 
               // add_note
               // 
               this.add_note.Location = new System.Drawing.Point(107, 12);
               this.add_note.Name = "add_note";
               this.add_note.Size = new System.Drawing.Size(94, 32);
               this.add_note.TabIndex = 4;
               this.add_note.Text = "Add New Note";
               this.add_note.UseVisualStyleBackColor = true;
               this.add_note.Click += new System.EventHandler(this.Add_Note_Click);
               // 
               // edit_note
               // 
               this.edit_note.Location = new System.Drawing.Point(207, 12);
               this.edit_note.Name = "edit_note";
               this.edit_note.Size = new System.Drawing.Size(120, 31);
               this.edit_note.TabIndex = 5;
               this.edit_note.Text = "Edit Selected Note";
               this.edit_note.UseVisualStyleBackColor = true;
               this.edit_note.Click += new System.EventHandler(this.Edit_Note_Click);
               // 
               // delete_note
               // 
               this.delete_note.Location = new System.Drawing.Point(333, 12);
               this.delete_note.Name = "delete_note";
               this.delete_note.Size = new System.Drawing.Size(130, 31);
               this.delete_note.TabIndex = 6;
               this.delete_note.Text = "Delete Selected Note";
               this.delete_note.UseVisualStyleBackColor = true;
               this.delete_note.Click += new System.EventHandler(this.Delete_Note_Click);
               // 
               // Student_Select
               // 
               this.Student_Select.FormattingEnabled = true;
               this.Student_Select.Location = new System.Drawing.Point(107, 63);
               this.Student_Select.Name = "Student_Select";
               this.Student_Select.Size = new System.Drawing.Size(192, 21);
               this.Student_Select.TabIndex = 7;
               this.Student_Select.SelectedIndexChanged += new System.EventHandler(this.Student_Select_SelectedIndexChanged);
               // 
               // Conference_Form
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(476, 450);
               this.Controls.Add(this.Student_Select);
               this.Controls.Add(this.delete_note);
               this.Controls.Add(this.edit_note);
               this.Controls.Add(this.add_note);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.notes);
               this.Controls.Add(this.Home_Button);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.MaximizeBox = false;
               this.Name = "Conference_Form";
               this.Text = "Student Conferences";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button Home_Button;
          private System.Windows.Forms.ListView notes;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Button add_note;
          private System.Windows.Forms.Button edit_note;
          private System.Windows.Forms.Button delete_note;
          private System.Windows.Forms.ColumnHeader note_id;
          private System.Windows.Forms.ColumnHeader student_id;
          private System.Windows.Forms.ColumnHeader date;
          private System.Windows.Forms.ColumnHeader note;
          private System.Windows.Forms.ColumnHeader type;
          private System.Windows.Forms.ComboBox Student_Select;
     }
}