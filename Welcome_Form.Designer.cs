using System;

namespace Senior_Project
{
    partial class Welcome_Form
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
               this.import_button = new System.Windows.Forms.Button();
               this.create_button = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.First_Name_Box = new System.Windows.Forms.TextBox();
               this.Last_Name_Box = new System.Windows.Forms.TextBox();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.Grade_Box = new System.Windows.Forms.ComboBox();
               this.SuspendLayout();
               // 
               // import_button
               // 
               this.import_button.Location = new System.Drawing.Point(35, 247);
               this.import_button.Name = "import_button";
               this.import_button.Size = new System.Drawing.Size(337, 86);
               this.import_button.TabIndex = 0;
               this.import_button.Text = "Import spreadsheet (.xl, .csv)";
               this.import_button.UseVisualStyleBackColor = true;
               this.import_button.Click += new System.EventHandler(this.Import_Button_Click);
               // 
               // create_button
               // 
               this.create_button.Location = new System.Drawing.Point(463, 247);
               this.create_button.Name = "create_button";
               this.create_button.Size = new System.Drawing.Size(337, 86);
               this.create_button.TabIndex = 1;
               this.create_button.Text = "Create from scratch";
               this.create_button.UseVisualStyleBackColor = true;
               this.create_button.Click += new System.EventHandler(this.Create_Button_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(182, 37);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(428, 34);
               this.label1.TabIndex = 2;
               this.label1.Text = "Welcome to Homeroom Helper!";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(204, 179);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(406, 25);
               this.label2.TabIndex = 3;
               this.label2.Text = "How would you like to create your classroom?";
               // 
               // First_Name_Box
               // 
               this.First_Name_Box.Location = new System.Drawing.Point(282, 92);
               this.First_Name_Box.Name = "First_Name_Box";
               this.First_Name_Box.Size = new System.Drawing.Size(100, 20);
               this.First_Name_Box.TabIndex = 4;
               // 
               // Last_Name_Box
               // 
               this.Last_Name_Box.Location = new System.Drawing.Point(455, 92);
               this.Last_Name_Box.Name = "Last_Name_Box";
               this.Last_Name_Box.Size = new System.Drawing.Size(100, 20);
               this.Last_Name_Box.TabIndex = 5;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(216, 95);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(60, 13);
               this.label3.TabIndex = 6;
               this.label3.Text = "First Name:";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(389, 95);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(61, 13);
               this.label4.TabIndex = 7;
               this.label4.Text = "Last Name:";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(343, 130);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(39, 13);
               this.label5.TabIndex = 9;
               this.label5.Text = "Grade:";
               // 
               // Grade_Box
               // 
               this.Grade_Box.FormattingEnabled = true;
               this.Grade_Box.Items.AddRange(new object[] {
            "K",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
               this.Grade_Box.Location = new System.Drawing.Point(388, 122);
               this.Grade_Box.Name = "Grade_Box";
               this.Grade_Box.Size = new System.Drawing.Size(46, 21);
               this.Grade_Box.TabIndex = 10;
               // 
               // Welcome_Form
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(835, 434);
               this.Controls.Add(this.Grade_Box);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.Last_Name_Box);
               this.Controls.Add(this.First_Name_Box);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.create_button);
               this.Controls.Add(this.import_button);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.MaximizeBox = false;
               this.Name = "Welcome_Form";
               this.Text = "Homeroom Helper";
               this.ResumeLayout(false);
               this.PerformLayout();

        }

          #endregion

          private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
          private System.Windows.Forms.TextBox First_Name_Box;
          private System.Windows.Forms.TextBox Last_Name_Box;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.ComboBox Grade_Box;
     }
}

