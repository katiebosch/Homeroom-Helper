namespace Senior_Project
{
     partial class New_Note_Form
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
               this.new_note = new System.Windows.Forms.Button();
               this.cancel = new System.Windows.Forms.Button();
               this.textbox_note = new System.Windows.Forms.RichTextBox();
               this.Note_Panel = new System.Windows.Forms.TableLayoutPanel();
               this.Types = new System.Windows.Forms.ComboBox();
               this.usage_label = new System.Windows.Forms.Label();
               this.description_label = new System.Windows.Forms.Label();
               this.example_label = new System.Windows.Forms.Label();
               this.type_title = new System.Windows.Forms.Label();
               this.description_title = new System.Windows.Forms.Label();
               this.usage_title = new System.Windows.Forms.Label();
               this.example_title = new System.Windows.Forms.Label();
               this.Back_Button = new System.Windows.Forms.Button();
               this.Note_Panel.SuspendLayout();
               this.SuspendLayout();
               // 
               // new_note
               // 
               this.new_note.Location = new System.Drawing.Point(12, 306);
               this.new_note.Name = "new_note";
               this.new_note.Size = new System.Drawing.Size(127, 38);
               this.new_note.TabIndex = 1;
               this.new_note.Text = "Add Note";
               this.new_note.UseVisualStyleBackColor = true;
               this.new_note.Click += new System.EventHandler(this.New_Note_Click);
               // 
               // cancel
               // 
               this.cancel.Location = new System.Drawing.Point(145, 306);
               this.cancel.Name = "cancel";
               this.cancel.Size = new System.Drawing.Size(121, 38);
               this.cancel.TabIndex = 2;
               this.cancel.Text = "Cancel";
               this.cancel.UseVisualStyleBackColor = true;
               this.cancel.Click += new System.EventHandler(this.Cancel_Click);
               // 
               // textbox_note
               // 
               this.textbox_note.Location = new System.Drawing.Point(12, 63);
               this.textbox_note.Name = "textbox_note";
               this.textbox_note.Size = new System.Drawing.Size(254, 237);
               this.textbox_note.TabIndex = 3;
               this.textbox_note.Text = "";
               // 
               // Note_Panel
               // 
               this.Note_Panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
               this.Note_Panel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
               this.Note_Panel.ColumnCount = 4;
               this.Note_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
               this.Note_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
               this.Note_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
               this.Note_Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
               this.Note_Panel.Controls.Add(this.Types, 0, 1);
               this.Note_Panel.Controls.Add(this.usage_label, 2, 1);
               this.Note_Panel.Controls.Add(this.description_label, 1, 1);
               this.Note_Panel.Controls.Add(this.example_label, 3, 1);
               this.Note_Panel.Controls.Add(this.type_title, 0, 0);
               this.Note_Panel.Controls.Add(this.description_title, 1, 0);
               this.Note_Panel.Controls.Add(this.usage_title, 2, 0);
               this.Note_Panel.Controls.Add(this.example_title, 3, 0);
               this.Note_Panel.Location = new System.Drawing.Point(274, 63);
               this.Note_Panel.Name = "Note_Panel";
               this.Note_Panel.RowCount = 2;
               this.Note_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
               this.Note_Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
               this.Note_Panel.Size = new System.Drawing.Size(525, 291);
               this.Note_Panel.TabIndex = 4;
               // 
               // Types
               // 
               this.Types.FormattingEnabled = true;
               this.Types.Location = new System.Drawing.Point(4, 62);
               this.Types.Name = "Types";
               this.Types.Size = new System.Drawing.Size(119, 21);
               this.Types.TabIndex = 0;
               this.Types.SelectedIndexChanged += new System.EventHandler(this.Types_SelectedIndexChanged);
               // 
               // usage_label
               // 
               this.usage_label.AutoSize = true;
               this.usage_label.Location = new System.Drawing.Point(266, 59);
               this.usage_label.Name = "usage_label";
               this.usage_label.Size = new System.Drawing.Size(35, 13);
               this.usage_label.TabIndex = 1;
               this.usage_label.Text = "label2";
               // 
               // description_label
               // 
               this.description_label.AutoSize = true;
               this.description_label.Location = new System.Drawing.Point(135, 59);
               this.description_label.Name = "description_label";
               this.description_label.Size = new System.Drawing.Size(35, 13);
               this.description_label.TabIndex = 0;
               this.description_label.Text = "label1";
               // 
               // example_label
               // 
               this.example_label.AutoSize = true;
               this.example_label.Location = new System.Drawing.Point(397, 59);
               this.example_label.Name = "example_label";
               this.example_label.Size = new System.Drawing.Size(35, 13);
               this.example_label.TabIndex = 2;
               this.example_label.Text = "label1";
               // 
               // type_title
               // 
               this.type_title.AutoSize = true;
               this.type_title.Location = new System.Drawing.Point(4, 1);
               this.type_title.Name = "type_title";
               this.type_title.Size = new System.Drawing.Size(101, 13);
               this.type_title.TabIndex = 3;
               this.type_title.Text = "Type of Conference";
               // 
               // description_title
               // 
               this.description_title.AutoSize = true;
               this.description_title.Location = new System.Drawing.Point(135, 1);
               this.description_title.Name = "description_title";
               this.description_title.Size = new System.Drawing.Size(60, 13);
               this.description_title.TabIndex = 4;
               this.description_title.Text = "Description";
               // 
               // usage_title
               // 
               this.usage_title.AutoSize = true;
               this.usage_title.Location = new System.Drawing.Point(266, 1);
               this.usage_title.Name = "usage_title";
               this.usage_title.Size = new System.Drawing.Size(70, 13);
               this.usage_title.TabIndex = 5;
               this.usage_title.Text = "When to Use";
               // 
               // example_title
               // 
               this.example_title.AutoSize = true;
               this.example_title.Location = new System.Drawing.Point(397, 1);
               this.example_title.Name = "example_title";
               this.example_title.Size = new System.Drawing.Size(52, 13);
               this.example_title.TabIndex = 6;
               this.example_title.Text = "Examples";
               // 
               // Back_Button
               // 
               this.Back_Button.Location = new System.Drawing.Point(12, 12);
               this.Back_Button.Name = "Back_Button";
               this.Back_Button.Size = new System.Drawing.Size(105, 36);
               this.Back_Button.TabIndex = 5;
               this.Back_Button.Text = "Back";
               this.Back_Button.UseVisualStyleBackColor = true;
               this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
               // 
               // New_Note_Form
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(811, 367);
               this.Controls.Add(this.Back_Button);
               this.Controls.Add(this.Note_Panel);
               this.Controls.Add(this.textbox_note);
               this.Controls.Add(this.cancel);
               this.Controls.Add(this.new_note);
               this.Name = "New_Note_Form";
               this.Text = "New Note";
               this.Note_Panel.ResumeLayout(false);
               this.Note_Panel.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion
          private System.Windows.Forms.Button new_note;
          private System.Windows.Forms.Button cancel;
          private System.Windows.Forms.RichTextBox textbox_note;
          private System.Windows.Forms.TableLayoutPanel Note_Panel;
          private System.Windows.Forms.ComboBox Types;
          private System.Windows.Forms.Label description_label;
          private System.Windows.Forms.Label usage_label;
          private System.Windows.Forms.Label example_label;
          private System.Windows.Forms.Label type_title;
          private System.Windows.Forms.Label description_title;
          private System.Windows.Forms.Label usage_title;
          private System.Windows.Forms.Label example_title;
          private System.Windows.Forms.Button Back_Button;
     }
}