namespace Senior_Project
{
     partial class Flag_Initial_Form
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
               this.Positive_Button = new System.Windows.Forms.Button();
               this.Neutral_Button = new System.Windows.Forms.Button();
               this.Negative_Button = new System.Windows.Forms.Button();
               this.Cancel_Button = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // Positive_Button
               // 
               this.Positive_Button.Location = new System.Drawing.Point(12, 35);
               this.Positive_Button.Name = "Positive_Button";
               this.Positive_Button.Size = new System.Drawing.Size(75, 23);
               this.Positive_Button.TabIndex = 0;
               this.Positive_Button.Text = "Positive";
               this.Positive_Button.UseVisualStyleBackColor = true;
               this.Positive_Button.Click += new System.EventHandler(this.Positive_Button_Click);
               // 
               // Neutral_Button
               // 
               this.Neutral_Button.Location = new System.Drawing.Point(113, 35);
               this.Neutral_Button.Name = "Neutral_Button";
               this.Neutral_Button.Size = new System.Drawing.Size(75, 23);
               this.Neutral_Button.TabIndex = 1;
               this.Neutral_Button.Text = "Neutral";
               this.Neutral_Button.UseVisualStyleBackColor = true;
               this.Neutral_Button.Click += new System.EventHandler(this.Neutral_Button_Click);
               // 
               // Negative_Button
               // 
               this.Negative_Button.Location = new System.Drawing.Point(214, 35);
               this.Negative_Button.Name = "Negative_Button";
               this.Negative_Button.Size = new System.Drawing.Size(75, 23);
               this.Negative_Button.TabIndex = 2;
               this.Negative_Button.Text = "Negative";
               this.Negative_Button.UseVisualStyleBackColor = true;
               this.Negative_Button.Click += new System.EventHandler(this.Negative_Button_Click);
               // 
               // Cancel_Button
               // 
               this.Cancel_Button.Location = new System.Drawing.Point(314, 35);
               this.Cancel_Button.Name = "Cancel_Button";
               this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
               this.Cancel_Button.TabIndex = 3;
               this.Cancel_Button.Text = "Cancel";
               this.Cancel_Button.UseVisualStyleBackColor = true;
               this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(42, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(307, 13);
               this.label1.TabIndex = 4;
               this.label1.Text = "What type of behavior do you see when this student is reading?";
               // 
               // Flag_Initial_Form
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(404, 82);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.Cancel_Button);
               this.Controls.Add(this.Negative_Button);
               this.Controls.Add(this.Neutral_Button);
               this.Controls.Add(this.Positive_Button);
               this.Name = "Flag_Initial_Form";
               this.Text = "What do you see?";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button Positive_Button;
          private System.Windows.Forms.Button Neutral_Button;
          private System.Windows.Forms.Button Negative_Button;
          private System.Windows.Forms.Button Cancel_Button;
          private System.Windows.Forms.Label label1;
     }
}