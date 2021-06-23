
namespace Cleaning
{
    partial class Cleaning
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cleaning));
            this.Temp_label = new System.Windows.Forms.Label();
            this.Volume_label = new System.Windows.Forms.Label();
            this.Cycles_label = new System.Windows.Forms.Label();
            this.Temp_input = new System.Windows.Forms.TextBox();
            this.Cycles_input = new System.Windows.Forms.TextBox();
            this.Start_button = new System.Windows.Forms.Button();
            this.Drop_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Volume_input = new System.Windows.Forms.TextBox();
            this.Time_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Temp_label
            // 
            this.Temp_label.AutoSize = true;
            this.Temp_label.Location = new System.Drawing.Point(12, 24);
            this.Temp_label.Name = "Temp_label";
            this.Temp_label.Size = new System.Drawing.Size(169, 15);
            this.Temp_label.TabIndex = 12;
            this.Temp_label.Text = "Температура °C (не более 80)";
            // 
            // Volume_label
            // 
            this.Volume_label.AutoSize = true;
            this.Volume_label.Location = new System.Drawing.Point(11, 46);
            this.Volume_label.Name = "Volume_label";
            this.Volume_label.Size = new System.Drawing.Size(184, 30);
            this.Volume_label.TabIndex = 123;
            this.Volume_label.Text = "Объём промываемой жидкости\nмл(не менее 10 и не более 180)";
            // 
            // Cycles_label
            // 
            this.Cycles_label.AutoSize = true;
            this.Cycles_label.Location = new System.Drawing.Point(11, 81);
            this.Cycles_label.Name = "Cycles_label";
            this.Cycles_label.Size = new System.Drawing.Size(176, 15);
            this.Cycles_label.TabIndex = 2123;
            this.Cycles_label.Text = "Количество циклов промывки";
            // 
            // Temp_input
            // 
            this.Temp_input.Location = new System.Drawing.Point(201, 21);
            this.Temp_input.Name = "Temp_input";
            this.Temp_input.Size = new System.Drawing.Size(39, 23);
            this.Temp_input.TabIndex = 0;
            // 
            // Cycles_input
            // 
            this.Cycles_input.Location = new System.Drawing.Point(201, 78);
            this.Cycles_input.Name = "Cycles_input";
            this.Cycles_input.Size = new System.Drawing.Size(39, 23);
            this.Cycles_input.TabIndex = 2;
            this.Cycles_input.TextChanged += new System.EventHandler(this.Cycles_input_TextChanged);
            // 
            // Start_button
            // 
            this.Start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_button.Location = new System.Drawing.Point(173, 157);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(75, 23);
            this.Start_button.TabIndex = 3;
            this.Start_button.Text = "Начать";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Drop_button
            // 
            this.Drop_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Drop_button.Location = new System.Drawing.Point(92, 157);
            this.Drop_button.Name = "Drop_button";
            this.Drop_button.Size = new System.Drawing.Size(75, 23);
            this.Drop_button.TabIndex = 4;
            this.Drop_button.Text = "Сброс";
            this.Drop_button.UseVisualStyleBackColor = true;
            this.Drop_button.Click += new System.EventHandler(this.Drop_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_button.Location = new System.Drawing.Point(11, 157);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 5;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Volume_input
            // 
            this.Volume_input.Location = new System.Drawing.Point(201, 50);
            this.Volume_input.Name = "Volume_input";
            this.Volume_input.Size = new System.Drawing.Size(39, 23);
            this.Volume_input.TabIndex = 1;
            this.Volume_input.TextChanged += new System.EventHandler(this.Volume_input_TextChanged);
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Location = new System.Drawing.Point(30, 123);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(103, 15);
            this.Time_label.TabIndex = 2124;
            this.Time_label.Text = "Время промывки";
            // 
            // Cleaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 192);
            this.Controls.Add(this.Time_label);
            this.Controls.Add(this.Volume_input);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Drop_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Cycles_input);
            this.Controls.Add(this.Temp_input);
            this.Controls.Add(this.Cycles_label);
            this.Controls.Add(this.Volume_label);
            this.Controls.Add(this.Temp_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cleaning";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Промывка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Temp_label;
        private System.Windows.Forms.Label Volume_label;
        private System.Windows.Forms.Label Cycles_label;
        private System.Windows.Forms.TextBox Temp_input;
        private System.Windows.Forms.TextBox Cycles_input;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Drop_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.TextBox Volume_input;
        private System.Windows.Forms.Label Time_label;
    }
}

