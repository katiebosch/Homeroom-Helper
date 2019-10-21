namespace Senior_Project
{
     partial class Class_Form
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
               this.New_Student = new System.Windows.Forms.Button();
               this.Import_Student = new System.Windows.Forms.Button();
               this.Export_One = new System.Windows.Forms.Button();
               this.Export_All = new System.Windows.Forms.Button();
               this.Delete_One = new System.Windows.Forms.Button();
               this.Delete_All = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.cf_fname = new System.Windows.Forms.TextBox();
               this.cf_lname = new System.Windows.Forms.TextBox();
               this.label6 = new System.Windows.Forms.Label();
               this.cf_goal_rdglvl = new System.Windows.Forms.TextBox();
               this.cf_cur_rdglvl = new System.Windows.Forms.TextBox();
               this.cf_o_rdglvl = new System.Windows.Forms.TextBox();
               this.StudentPanel = new System.Windows.Forms.DataGridView();
               this.Home = new System.Windows.Forms.Button();
               this.cf_id = new System.Windows.Forms.TextBox();
               this.Import_Many = new System.Windows.Forms.Button();
               this.Clear_Button = new System.Windows.Forms.Button();
               this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.start_lvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.cur_lvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.goal_lvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
               ((System.ComponentModel.ISupportInitialize)(this.StudentPanel)).BeginInit();
               this.SuspendLayout();
               // 
               // New_Student
               // 
               this.New_Student.Location = new System.Drawing.Point(695, 302);
               this.New_Student.Name = "New_Student";
               this.New_Student.Size = new System.Drawing.Size(132, 35);
               this.New_Student.TabIndex = 1;
               this.New_Student.Text = "Save Student";
               this.New_Student.UseVisualStyleBackColor = true;
               this.New_Student.Click += new System.EventHandler(this.New_Student_Click);
               // 
               // Import_Student
               // 
               this.Import_Student.Location = new System.Drawing.Point(695, 343);
               this.Import_Student.Name = "Import_Student";
               this.Import_Student.Size = new System.Drawing.Size(132, 35);
               this.Import_Student.TabIndex = 2;
               this.Import_Student.Text = "Import Student";
               this.Import_Student.UseVisualStyleBackColor = true;
               this.Import_Student.Click += new System.EventHandler(this.Import_Student_Click);
               // 
               // Export_One
               // 
               this.Export_One.Location = new System.Drawing.Point(695, 384);
               this.Export_One.Name = "Export_One";
               this.Export_One.Size = new System.Drawing.Size(132, 34);
               this.Export_One.TabIndex = 3;
               this.Export_One.Text = "Export Student";
               this.Export_One.UseVisualStyleBackColor = true;
               this.Export_One.Click += new System.EventHandler(this.Export_One_Click);
               // 
               // Export_All
               // 
               this.Export_All.Location = new System.Drawing.Point(833, 384);
               this.Export_All.Name = "Export_All";
               this.Export_All.Size = new System.Drawing.Size(132, 35);
               this.Export_All.TabIndex = 4;
               this.Export_All.Text = "Export All Records";
               this.Export_All.UseVisualStyleBackColor = true;
               this.Export_All.Click += new System.EventHandler(this.Export_All_Click);
               // 
               // Delete_One
               // 
               this.Delete_One.Location = new System.Drawing.Point(695, 424);
               this.Delete_One.Name = "Delete_One";
               this.Delete_One.Size = new System.Drawing.Size(132, 36);
               this.Delete_One.TabIndex = 5;
               this.Delete_One.Text = "Delete Student";
               this.Delete_One.UseVisualStyleBackColor = true;
               this.Delete_One.Click += new System.EventHandler(this.Delete_One_Click);
               // 
               // Delete_All
               // 
               this.Delete_All.Location = new System.Drawing.Point(833, 425);
               this.Delete_All.Name = "Delete_All";
               this.Delete_All.Size = new System.Drawing.Size(132, 36);
               this.Delete_All.TabIndex = 6;
               this.Delete_All.Text = "Delete All Students";
               this.Delete_All.UseVisualStyleBackColor = true;
               this.Delete_All.Click += new System.EventHandler(this.Delete_All_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(692, 133);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(60, 13);
               this.label1.TabIndex = 7;
               this.label1.Text = "First Name:";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(692, 163);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(61, 13);
               this.label2.TabIndex = 8;
               this.label2.Text = "Last Name:";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(692, 193);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(117, 13);
               this.label3.TabIndex = 9;
               this.label3.Text = "Original Reading Level:";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(692, 225);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(116, 13);
               this.label4.TabIndex = 10;
               this.label4.Text = "Current Reading Level:";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(692, 259);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(104, 13);
               this.label5.TabIndex = 11;
               this.label5.Text = "Goal Reading Level:";
               // 
               // cf_fname
               // 
               this.cf_fname.Location = new System.Drawing.Point(821, 129);
               this.cf_fname.Name = "cf_fname";
               this.cf_fname.Size = new System.Drawing.Size(144, 20);
               this.cf_fname.TabIndex = 12;
               // 
               // cf_lname
               // 
               this.cf_lname.Location = new System.Drawing.Point(821, 160);
               this.cf_lname.Name = "cf_lname";
               this.cf_lname.Size = new System.Drawing.Size(144, 20);
               this.cf_lname.TabIndex = 13;
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(774, 63);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(113, 16);
               this.label6.TabIndex = 17;
               this.label6.Text = "Student Details";
               // 
               // cf_goal_rdglvl
               // 
               this.cf_goal_rdglvl.Location = new System.Drawing.Point(821, 256);
               this.cf_goal_rdglvl.MaxLength = 1;
               this.cf_goal_rdglvl.Name = "cf_goal_rdglvl";
               this.cf_goal_rdglvl.Size = new System.Drawing.Size(144, 20);
               this.cf_goal_rdglvl.TabIndex = 16;
               // 
               // cf_cur_rdglvl
               // 
               this.cf_cur_rdglvl.Location = new System.Drawing.Point(821, 222);
               this.cf_cur_rdglvl.MaxLength = 1;
               this.cf_cur_rdglvl.Name = "cf_cur_rdglvl";
               this.cf_cur_rdglvl.Size = new System.Drawing.Size(144, 20);
               this.cf_cur_rdglvl.TabIndex = 15;
               // 
               // cf_o_rdglvl
               // 
               this.cf_o_rdglvl.Location = new System.Drawing.Point(821, 190);
               this.cf_o_rdglvl.MaxLength = 1;
               this.cf_o_rdglvl.Name = "cf_o_rdglvl";
               this.cf_o_rdglvl.Size = new System.Drawing.Size(144, 20);
               this.cf_o_rdglvl.TabIndex = 14;
               // 
               // StudentPanel
               // 
               this.StudentPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.StudentPanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_ID,
            this.fname,
            this.lname,
            this.start_lvl,
            this.cur_lvl,
            this.goal_lvl});
               this.StudentPanel.Location = new System.Drawing.Point(12, 63);
               this.StudentPanel.MultiSelect = false;
               this.StudentPanel.Name = "StudentPanel";
               this.StudentPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.StudentPanel.Size = new System.Drawing.Size(643, 510);
               this.StudentPanel.TabIndex = 18;
               this.StudentPanel.SelectionChanged += new System.EventHandler(this.StudentPanel_SelectionChanged_1);
               // 
               // Home
               // 
               this.Home.Location = new System.Drawing.Point(12, 12);
               this.Home.Name = "Home";
               this.Home.Size = new System.Drawing.Size(115, 38);
               this.Home.TabIndex = 21;
               this.Home.Text = "Home";
               this.Home.UseVisualStyleBackColor = true;
               this.Home.Click += new System.EventHandler(this.Home_Click);
               // 
               // cf_id
               // 
               this.cf_id.Location = new System.Drawing.Point(821, 103);
               this.cf_id.Name = "cf_id";
               this.cf_id.ReadOnly = true;
               this.cf_id.Size = new System.Drawing.Size(41, 20);
               this.cf_id.TabIndex = 22;
               this.cf_id.Visible = false;
               // 
               // Import_Many
               // 
               this.Import_Many.Location = new System.Drawing.Point(833, 343);
               this.Import_Many.Name = "Import_Many";
               this.Import_Many.Size = new System.Drawing.Size(130, 34);
               this.Import_Many.TabIndex = 25;
               this.Import_Many.Text = "Import Multiple";
               this.Import_Many.UseVisualStyleBackColor = true;
               this.Import_Many.Click += new System.EventHandler(this.Import_Many_Click);
               // 
               // Clear_Button
               // 
               this.Clear_Button.Location = new System.Drawing.Point(833, 302);
               this.Clear_Button.Name = "Clear_Button";
               this.Clear_Button.Size = new System.Drawing.Size(130, 35);
               this.Clear_Button.TabIndex = 26;
               this.Clear_Button.Text = "Clear Boxes";
               this.Clear_Button.UseVisualStyleBackColor = true;
               this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
               // 
               // Student_ID
               // 
               this.Student_ID.HeaderText = "Student ID";
               this.Student_ID.Name = "Student_ID";
               this.Student_ID.ReadOnly = true;
               this.Student_ID.Visible = false;
               this.Student_ID.Width = 5;
               // 
               // fname
               // 
               this.fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.fname.HeaderText = "First Name";
               this.fname.Name = "fname";
               this.fname.ReadOnly = true;
               // 
               // lname
               // 
               this.lname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.lname.HeaderText = "Last Name";
               this.lname.Name = "lname";
               this.lname.ReadOnly = true;
               // 
               // start_lvl
               // 
               this.start_lvl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.start_lvl.HeaderText = "Starting Reading Level";
               this.start_lvl.Name = "start_lvl";
               this.start_lvl.ReadOnly = true;
               // 
               // cur_lvl
               // 
               this.cur_lvl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.cur_lvl.HeaderText = "Current Reading Level";
               this.cur_lvl.Name = "cur_lvl";
               this.cur_lvl.ReadOnly = true;
               // 
               // goal_lvl
               // 
               this.goal_lvl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.goal_lvl.HeaderText = "Goal Reading Level";
               this.goal_lvl.Name = "goal_lvl";
               this.goal_lvl.ReadOnly = true;
               // 
               // Class_Form
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(999, 585);
               this.Controls.Add(this.Clear_Button);
               this.Controls.Add(this.Import_Many);
               this.Controls.Add(this.cf_id);
               this.Controls.Add(this.Home);
               this.Controls.Add(this.StudentPanel);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.cf_goal_rdglvl);
               this.Controls.Add(this.cf_cur_rdglvl);
               this.Controls.Add(this.cf_o_rdglvl);
               this.Controls.Add(this.cf_lname);
               this.Controls.Add(this.cf_fname);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.Delete_All);
               this.Controls.Add(this.Delete_One);
               this.Controls.Add(this.Export_All);
               this.Controls.Add(this.Export_One);
               this.Controls.Add(this.Import_Student);
               this.Controls.Add(this.New_Student);
               this.Name = "Class_Form";
               this.Text = "Manage Classroom";
               ((System.ComponentModel.ISupportInitialize)(this.StudentPanel)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          private void StudentPanel_SelectionChanged(object sender, System.EventArgs e)
          {
               throw new System.NotImplementedException();
          }

          #endregion
          private System.Windows.Forms.Button New_Student;
          private System.Windows.Forms.Button Import_Student;
          private System.Windows.Forms.Button Export_One;
          private System.Windows.Forms.Button Export_All;
          private System.Windows.Forms.Button Delete_One;
          private System.Windows.Forms.Button Delete_All;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.TextBox cf_fname;
          private System.Windows.Forms.TextBox cf_lname;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.TextBox cf_goal_rdglvl;
          private System.Windows.Forms.TextBox cf_cur_rdglvl;
          private System.Windows.Forms.TextBox cf_o_rdglvl;
          private System.Windows.Forms.DataGridView StudentPanel;
          private System.Windows.Forms.Button Home;
          private System.Windows.Forms.TextBox cf_id;
          private System.Windows.Forms.Button Import_Many;
          private System.Windows.Forms.Button Clear_Button;
          private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
          private System.Windows.Forms.DataGridViewTextBoxColumn fname;
          private System.Windows.Forms.DataGridViewTextBoxColumn lname;
          private System.Windows.Forms.DataGridViewTextBoxColumn start_lvl;
          private System.Windows.Forms.DataGridViewTextBoxColumn cur_lvl;
          private System.Windows.Forms.DataGridViewTextBoxColumn goal_lvl;
     }
}