namespace Senior_Project
{
     partial class Flag_Assess_Form
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
               this.N_A_Button = new System.Windows.Forms.Button();
               this.Cancel = new System.Windows.Forms.Button();
               this.Group1 = new System.Windows.Forms.FlowLayoutPanel();
               this.label1 = new System.Windows.Forms.Label();
               this.Submit = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // N_A_Button
               // 
               this.N_A_Button.Location = new System.Drawing.Point(231, 583);
               this.N_A_Button.Name = "N_A_Button";
               this.N_A_Button.Size = new System.Drawing.Size(218, 30);
               this.N_A_Button.TabIndex = 3;
               this.N_A_Button.Text = "None";
               this.N_A_Button.UseVisualStyleBackColor = true;
               this.N_A_Button.Click += new System.EventHandler(this.N_A_Button_Click);
               // 
               // Cancel
               // 
               this.Cancel.Location = new System.Drawing.Point(455, 583);
               this.Cancel.Name = "Cancel";
               this.Cancel.Size = new System.Drawing.Size(218, 30);
               this.Cancel.TabIndex = 4;
               this.Cancel.Text = "Cancel";
               this.Cancel.UseVisualStyleBackColor = true;
               this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
               // 
               // Group1
               // 
               this.Group1.AutoScroll = true;
               this.Group1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
               this.Group1.Location = new System.Drawing.Point(12, 58);
               this.Group1.Name = "Group1";
               this.Group1.Size = new System.Drawing.Size(661, 519);
               this.Group1.TabIndex = 5;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(12, 18);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(208, 25);
               this.label1.TabIndex = 6;
               this.label1.Text = "Select all that you see:";
               // 
               // Submit
               // 
               this.Submit.Location = new System.Drawing.Point(12, 583);
               this.Submit.Name = "Submit";
               this.Submit.Size = new System.Drawing.Size(213, 30);
               this.Submit.TabIndex = 7;
               this.Submit.Text = "Submit";
               this.Submit.UseVisualStyleBackColor = true;
               this.Submit.Click += new System.EventHandler(this.Submit_Click);
               // 
               // Flag_Assess_Form
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(687, 656);
               this.Controls.Add(this.Submit);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.Group1);
               this.Controls.Add(this.Cancel);
               this.Controls.Add(this.N_A_Button);
               this.Name = "Flag_Assess_Form";
               this.Text = "Flag_Assess_Form";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.Button N_A_Button;
          private System.Windows.Forms.Button Cancel;
          private System.Windows.Forms.FlowLayoutPanel Group1;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Button Submit;
     }
}