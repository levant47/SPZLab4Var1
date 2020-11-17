namespace SPZLab4Var1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputFilePathTextbox = new System.Windows.Forms.TextBox();
            this.chooseInputFileButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный файл";
            // 
            // inputFilePathTextbox
            // 
            this.inputFilePathTextbox.Enabled = false;
            this.inputFilePathTextbox.Location = new System.Drawing.Point(114, 6);
            this.inputFilePathTextbox.Name = "inputFilePathTextbox";
            this.inputFilePathTextbox.Size = new System.Drawing.Size(266, 23);
            this.inputFilePathTextbox.TabIndex = 1;
            // 
            // chooseInputFileButton
            // 
            this.chooseInputFileButton.Location = new System.Drawing.Point(224, 70);
            this.chooseInputFileButton.Name = "chooseInputFileButton";
            this.chooseInputFileButton.Size = new System.Drawing.Size(156, 23);
            this.chooseInputFileButton.TabIndex = 2;
            this.chooseInputFileButton.Text = "Выбрать исходный файл";
            this.chooseInputFileButton.UseVisualStyleBackColor = true;
            this.chooseInputFileButton.Click += new System.EventHandler(this.chooseInputFileButton_Click);
            // 
            // runButton
            // 
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(12, 70);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Запустить";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 105);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.chooseInputFileButton);
            this.Controls.Add(this.inputFilePathTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputFilePathTextbox;
        private System.Windows.Forms.Button chooseInputFileButton;
        private System.Windows.Forms.Button runButton;
    }
}

