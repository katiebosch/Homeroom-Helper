namespace Senior_Project
{
     partial class Help_Reader_Form
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
               System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
               this.Student_List = new System.Windows.Forms.ComboBox();
               this.Reading_Lvl_Txtbox = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.Home_Button = new System.Windows.Forms.Button();
               this.Student_ID_Box = new System.Windows.Forms.TextBox();
               this.Level_Up_Button = new System.Windows.Forms.Button();
               this.Level = new System.Windows.Forms.ComboBox();
               this.label5 = new System.Windows.Forms.Label();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.Reading_Level_Panel = new System.Windows.Forms.DataGridView();
               this.Observations = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.groupBox2 = new System.Windows.Forms.GroupBox();
               this.groupBox3 = new System.Windows.Forms.GroupBox();
               this.Post_it_Button = new System.Windows.Forms.Button();
               this.Partner_Work_Button = new System.Windows.Forms.Button();
               this.Volume_and_Stamina_Button = new System.Windows.Forms.Button();
               this.Engagement_and_Independence_Button = new System.Windows.Forms.Button();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.Reading_Level_Panel)).BeginInit();
               this.groupBox2.SuspendLayout();
               this.groupBox3.SuspendLayout();
               this.SuspendLayout();
               // 
               // Student_List
               // 
               this.Student_List.FormattingEnabled = true;
               this.Student_List.Location = new System.Drawing.Point(19, 45);
               this.Student_List.Name = "Student_List";
               this.Student_List.Size = new System.Drawing.Size(160, 21);
               this.Student_List.TabIndex = 0;
               this.Student_List.SelectedIndexChanged += new System.EventHandler(this.Student_List_SelectedIndexChanged);
               // 
               // Reading_Lvl_Txtbox
               // 
               this.Reading_Lvl_Txtbox.Location = new System.Drawing.Point(141, 105);
               this.Reading_Lvl_Txtbox.Name = "Reading_Lvl_Txtbox";
               this.Reading_Lvl_Txtbox.ReadOnly = true;
               this.Reading_Lvl_Txtbox.Size = new System.Drawing.Size(36, 20);
               this.Reading_Lvl_Txtbox.TabIndex = 1;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(16, 108);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(119, 13);
               this.label1.TabIndex = 2;
               this.label1.Text = "Student Reading Level:";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(6, 16);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(114, 17);
               this.label2.TabIndex = 3;
               this.label2.Text = "Select Student";
               // 
               // Home_Button
               // 
               this.Home_Button.Location = new System.Drawing.Point(12, 12);
               this.Home_Button.Name = "Home_Button";
               this.Home_Button.Size = new System.Drawing.Size(98, 35);
               this.Home_Button.TabIndex = 5;
               this.Home_Button.Text = "Home";
               this.Home_Button.UseVisualStyleBackColor = true;
               this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
               // 
               // Student_ID_Box
               // 
               this.Student_ID_Box.Location = new System.Drawing.Point(141, 85);
               this.Student_ID_Box.Name = "Student_ID_Box";
               this.Student_ID_Box.Size = new System.Drawing.Size(36, 20);
               this.Student_ID_Box.TabIndex = 10;
               this.Student_ID_Box.Visible = false;
               // 
               // Level_Up_Button
               // 
               this.Level_Up_Button.Location = new System.Drawing.Point(43, 139);
               this.Level_Up_Button.Name = "Level_Up_Button";
               this.Level_Up_Button.Size = new System.Drawing.Size(106, 26);
               this.Level_Up_Button.TabIndex = 12;
               this.Level_Up_Button.Text = "Level Up!";
               this.Level_Up_Button.UseVisualStyleBackColor = true;
               this.Level_Up_Button.Click += new System.EventHandler(this.Level_Up_Button_Click);
               // 
               // Level
               // 
               this.Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Level.FormattingEnabled = true;
               this.Level.Location = new System.Drawing.Point(23, 78);
               this.Level.Name = "Level";
               this.Level.Size = new System.Drawing.Size(159, 21);
               this.Level.TabIndex = 0;
               this.Level.SelectedIndexChanged += new System.EventHandler(this.Level_SelectedIndexChanged);
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.Location = new System.Drawing.Point(20, 49);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(162, 17);
               this.label5.TabIndex = 16;
               this.label5.Text = "Select Reading Level";
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.Reading_Level_Panel);
               this.groupBox1.Controls.Add(this.label5);
               this.groupBox1.Controls.Add(this.Level);
               this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.Location = new System.Drawing.Point(278, 12);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(770, 585);
               this.groupBox1.TabIndex = 17;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Learn more about reading levels:";
               // 
               // Reading_Level_Panel
               // 
               this.Reading_Level_Panel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
               this.Reading_Level_Panel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
               this.Reading_Level_Panel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.Reading_Level_Panel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Observations,
            this.Actions});
               dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
               dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
               dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
               dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
               dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
               dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
               this.Reading_Level_Panel.DefaultCellStyle = dataGridViewCellStyle5;
               this.Reading_Level_Panel.Location = new System.Drawing.Point(247, 28);
               this.Reading_Level_Panel.Name = "Reading_Level_Panel";
               this.Reading_Level_Panel.Size = new System.Drawing.Size(517, 551);
               this.Reading_Level_Panel.TabIndex = 19;
               // 
               // Observations
               // 
               this.Observations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.Observations.HeaderText = "Observations";
               this.Observations.Name = "Observations";
               // 
               // Actions
               // 
               this.Actions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.Actions.HeaderText = "Actions";
               this.Actions.Name = "Actions";
               // 
               // groupBox2
               // 
               this.groupBox2.Controls.Add(this.label2);
               this.groupBox2.Controls.Add(this.Student_List);
               this.groupBox2.Controls.Add(this.Level_Up_Button);
               this.groupBox2.Controls.Add(this.Reading_Lvl_Txtbox);
               this.groupBox2.Controls.Add(this.Student_ID_Box);
               this.groupBox2.Controls.Add(this.label1);
               this.groupBox2.Location = new System.Drawing.Point(13, 61);
               this.groupBox2.Name = "groupBox2";
               this.groupBox2.Size = new System.Drawing.Size(223, 188);
               this.groupBox2.TabIndex = 19;
               this.groupBox2.TabStop = false;
               // 
               // groupBox3
               // 
               this.groupBox3.Controls.Add(this.Post_it_Button);
               this.groupBox3.Controls.Add(this.Partner_Work_Button);
               this.groupBox3.Controls.Add(this.Volume_and_Stamina_Button);
               this.groupBox3.Controls.Add(this.Engagement_and_Independence_Button);
               this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox3.Location = new System.Drawing.Point(12, 255);
               this.groupBox3.Name = "groupBox3";
               this.groupBox3.Size = new System.Drawing.Size(224, 212);
               this.groupBox3.TabIndex = 20;
               this.groupBox3.TabStop = false;
               this.groupBox3.Text = "Reading Flags";
               // 
               // Post_it_Button
               // 
               this.Post_it_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Post_it_Button.Location = new System.Drawing.Point(6, 170);
               this.Post_it_Button.Name = "Post_it_Button";
               this.Post_it_Button.Size = new System.Drawing.Size(208, 33);
               this.Post_it_Button.TabIndex = 24;
               this.Post_it_Button.Text = "Post-it Notes";
               this.Post_it_Button.UseVisualStyleBackColor = true;
               this.Post_it_Button.Click += new System.EventHandler(this.Post_it_Button_Click);
               // 
               // Partner_Work_Button
               // 
               this.Partner_Work_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Partner_Work_Button.Location = new System.Drawing.Point(6, 131);
               this.Partner_Work_Button.Name = "Partner_Work_Button";
               this.Partner_Work_Button.Size = new System.Drawing.Size(208, 33);
               this.Partner_Work_Button.TabIndex = 23;
               this.Partner_Work_Button.Text = "Partner Work";
               this.Partner_Work_Button.UseVisualStyleBackColor = true;
               this.Partner_Work_Button.Click += new System.EventHandler(this.Partner_Work_Button_Click);
               // 
               // Volume_and_Stamina_Button
               // 
               this.Volume_and_Stamina_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Volume_and_Stamina_Button.Location = new System.Drawing.Point(6, 92);
               this.Volume_and_Stamina_Button.Name = "Volume_and_Stamina_Button";
               this.Volume_and_Stamina_Button.Size = new System.Drawing.Size(208, 33);
               this.Volume_and_Stamina_Button.TabIndex = 22;
               this.Volume_and_Stamina_Button.Text = "Volume and Stamina (Reading Logs)";
               this.Volume_and_Stamina_Button.UseVisualStyleBackColor = true;
               this.Volume_and_Stamina_Button.Click += new System.EventHandler(this.Volume_and_Stamina_Button_Click);
               // 
               // Engagement_and_Independence_Button
               // 
               this.Engagement_and_Independence_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Engagement_and_Independence_Button.Location = new System.Drawing.Point(6, 53);
               this.Engagement_and_Independence_Button.Name = "Engagement_and_Independence_Button";
               this.Engagement_and_Independence_Button.Size = new System.Drawing.Size(208, 33);
               this.Engagement_and_Independence_Button.TabIndex = 21;
               this.Engagement_and_Independence_Button.Text = "Engagement and Independence";
               this.Engagement_and_Independence_Button.UseVisualStyleBackColor = true;
               this.Engagement_and_Independence_Button.Click += new System.EventHandler(this.Engagement_and_Independence_Button_Click);
               // 
               // Help_Reader_Form
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1060, 609);
               this.Controls.Add(this.groupBox3);
               this.Controls.Add(this.groupBox2);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.Home_Button);
               this.Name = "Help_Reader_Form";
               this.Text = "Help A Reader";
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.Reading_Level_Panel)).EndInit();
               this.groupBox2.ResumeLayout(false);
               this.groupBox2.PerformLayout();
               this.groupBox3.ResumeLayout(false);
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.ComboBox Student_List;
          private System.Windows.Forms.TextBox Reading_Lvl_Txtbox;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Button Home_Button;
          private System.Windows.Forms.TextBox Student_ID_Box;
          private System.Windows.Forms.Button Level_Up_Button;
          private System.Windows.Forms.ComboBox Level;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.GroupBox groupBox2;
          private System.Windows.Forms.GroupBox groupBox3;
          private System.Windows.Forms.Button Post_it_Button;
          private System.Windows.Forms.Button Partner_Work_Button;
          private System.Windows.Forms.Button Volume_and_Stamina_Button;
          private System.Windows.Forms.Button Engagement_and_Independence_Button;
          private System.Windows.Forms.DataGridView Reading_Level_Panel;
          private System.Windows.Forms.DataGridViewTextBoxColumn Observations;
          private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
     }
}