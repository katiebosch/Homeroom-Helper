namespace Senior_Project
{
     partial class Analytics_Form
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
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
               System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
               System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
               System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
               this.Lvl_Counts_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
               this.Home_Button = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.Avg_Lvl_Txtbox = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.Student_Names = new System.Windows.Forms.ComboBox();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.Lvl_History_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
               this.Student_ID_Box = new System.Windows.Forms.TextBox();
               ((System.ComponentModel.ISupportInitialize)(this.Lvl_Counts_Chart)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Lvl_History_Chart)).BeginInit();
               this.SuspendLayout();
               // 
               // Lvl_Counts_Chart
               // 
               chartArea1.Name = "ChartArea1";
               this.Lvl_Counts_Chart.ChartAreas.Add(chartArea1);
               legend1.Name = "Legend1";
               this.Lvl_Counts_Chart.Legends.Add(legend1);
               this.Lvl_Counts_Chart.Location = new System.Drawing.Point(16, 144);
               this.Lvl_Counts_Chart.Name = "Lvl_Counts_Chart";
               series1.ChartArea = "ChartArea1";
               series1.Legend = "Legend1";
               series1.Name = "Number of Students";
               this.Lvl_Counts_Chart.Series.Add(series1);
               this.Lvl_Counts_Chart.Size = new System.Drawing.Size(480, 350);
               this.Lvl_Counts_Chart.TabIndex = 0;
               this.Lvl_Counts_Chart.Text = "chart1";
               // 
               // Home_Button
               // 
               this.Home_Button.Location = new System.Drawing.Point(12, 12);
               this.Home_Button.Name = "Home_Button";
               this.Home_Button.Size = new System.Drawing.Size(94, 36);
               this.Home_Button.TabIndex = 1;
               this.Home_Button.Text = "Home";
               this.Home_Button.UseVisualStyleBackColor = true;
               this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(12, 65);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(238, 20);
               this.label1.TabIndex = 2;
               this.label1.Text = "Average Reading Level of Class:";
               // 
               // Avg_Lvl_Txtbox
               // 
               this.Avg_Lvl_Txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Avg_Lvl_Txtbox.Location = new System.Drawing.Point(256, 59);
               this.Avg_Lvl_Txtbox.Name = "Avg_Lvl_Txtbox";
               this.Avg_Lvl_Txtbox.ReadOnly = true;
               this.Avg_Lvl_Txtbox.Size = new System.Drawing.Size(46, 26);
               this.Avg_Lvl_Txtbox.TabIndex = 3;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(12, 121);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(318, 20);
               this.label2.TabIndex = 4;
               this.label2.Text = "Number of Students at each Reading Level:";
               // 
               // Student_Names
               // 
               this.Student_Names.FormattingEnabled = true;
               this.Student_Names.Location = new System.Drawing.Point(557, 91);
               this.Student_Names.Name = "Student_Names";
               this.Student_Names.Size = new System.Drawing.Size(146, 21);
               this.Student_Names.TabIndex = 5;
               this.Student_Names.SelectedIndexChanged += new System.EventHandler(this.Student_Names_SelectedIndexChanged);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(542, 24);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(228, 20);
               this.label3.TabIndex = 6;
               this.label3.Text = "Student Reading Level History:";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(554, 65);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(80, 13);
               this.label4.TabIndex = 7;
               this.label4.Text = "Select Student:";
               // 
               // Lvl_History_Chart
               // 
               chartArea2.Name = "ChartArea1";
               this.Lvl_History_Chart.ChartAreas.Add(chartArea2);
               legend2.Name = "Legend1";
               this.Lvl_History_Chart.Legends.Add(legend2);
               this.Lvl_History_Chart.Location = new System.Drawing.Point(557, 144);
               this.Lvl_History_Chart.Name = "Lvl_History_Chart";
               series2.ChartArea = "ChartArea1";
               series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
               series2.Legend = "Legend1";
               series2.Name = "Reading Levels";
               this.Lvl_History_Chart.Series.Add(series2);
               this.Lvl_History_Chart.Size = new System.Drawing.Size(775, 350);
               this.Lvl_History_Chart.TabIndex = 8;
               this.Lvl_History_Chart.Text = "chart1";
               // 
               // Student_ID_Box
               // 
               this.Student_ID_Box.Location = new System.Drawing.Point(709, 92);
               this.Student_ID_Box.Name = "Student_ID_Box";
               this.Student_ID_Box.ReadOnly = true;
               this.Student_ID_Box.Size = new System.Drawing.Size(35, 20);
               this.Student_ID_Box.TabIndex = 9;
               this.Student_ID_Box.Visible = false;
               // 
               // Analytics_Form
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1344, 510);
               this.Controls.Add(this.Student_ID_Box);
               this.Controls.Add(this.Lvl_History_Chart);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.Student_Names);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.Avg_Lvl_Txtbox);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.Home_Button);
               this.Controls.Add(this.Lvl_Counts_Chart);
               this.Name = "Analytics_Form";
               this.Text = "Analytics_Form";
               ((System.ComponentModel.ISupportInitialize)(this.Lvl_Counts_Chart)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Lvl_History_Chart)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataVisualization.Charting.Chart Lvl_Counts_Chart;
          private System.Windows.Forms.Button Home_Button;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox Avg_Lvl_Txtbox;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.ComboBox Student_Names;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.DataVisualization.Charting.Chart Lvl_History_Chart;
          private System.Windows.Forms.TextBox Student_ID_Box;
     }
}