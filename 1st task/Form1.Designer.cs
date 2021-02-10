namespace expences_manager
{
    partial class Form1
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
            this.readButton = new System.Windows.Forms.Button();
            this.task1 = new System.Windows.Forms.Button();
            this.task3 = new System.Windows.Forms.Button();
            this.task2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.readTextBox = new System.Windows.Forms.TextBox();
            this.showTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(12, 58);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(95, 32);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "read the file";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // task1
            // 
            this.task1.Location = new System.Drawing.Point(113, 58);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(75, 32);
            this.task1.TabIndex = 1;
            this.task1.Text = "1 task";
            this.task1.UseVisualStyleBackColor = true;
            this.task1.Click += new System.EventHandler(this.task1_Click);
            // 
            // task3
            // 
            this.task3.Location = new System.Drawing.Point(281, 58);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(75, 32);
            this.task3.TabIndex = 2;
            this.task3.Text = "3 task";
            this.task3.UseVisualStyleBackColor = true;
            this.task3.Click += new System.EventHandler(this.task3_Click);
            // 
            // task2
            // 
            this.task2.Location = new System.Drawing.Point(194, 58);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(75, 32);
            this.task2.TabIndex = 3;
            this.task2.Text = "2 task";
            this.task2.UseVisualStyleBackColor = true;
            this.task2.Click += new System.EventHandler(this.task2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Provide the path";
            // 
            // readTextBox
            // 
            this.readTextBox.Location = new System.Drawing.Point(12, 29);
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.Size = new System.Drawing.Size(776, 22);
            this.readTextBox.TabIndex = 5;
            // 
            // showTextBox
            // 
            this.showTextBox.Location = new System.Drawing.Point(12, 96);
            this.showTextBox.Multiline = true;
            this.showTextBox.Name = "showTextBox";
            this.showTextBox.Size = new System.Drawing.Size(776, 342);
            this.showTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showTextBox);
            this.Controls.Add(this.readTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.task1);
            this.Controls.Add(this.readButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button task1;
        private System.Windows.Forms.Button task3;
        private System.Windows.Forms.Button task2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox readTextBox;
        private System.Windows.Forms.TextBox showTextBox;
    }
}

