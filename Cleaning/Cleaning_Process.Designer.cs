
namespace Cleaning
{
    partial class Cleaning_Process
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Test_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(35, 142);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(215, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // Test_label
            // 
            this.Test_label.AutoSize = true;
            this.Test_label.Location = new System.Drawing.Point(136, 69);
            this.Test_label.Name = "Test_label";
            this.Test_label.Size = new System.Drawing.Size(38, 15);
            this.Test_label.TabIndex = 1;
            this.Test_label.Text = "label1";
            // 
            // Cleaning_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 212);
            this.ControlBox = false;
            this.Controls.Add(this.Test_label);
            this.Controls.Add(this.progressBar1);
            this.Name = "Cleaning_Process";
            this.Text = "Промывка";
            this.Load += new System.EventHandler(this.Cleaning_Process_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Test_label;
    }
}