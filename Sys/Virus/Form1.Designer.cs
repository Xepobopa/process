namespace Virus
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
            this.components = new System.ComponentModel.Container();
            this.TBInput = new System.Windows.Forms.TextBox();
            this.BSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(98, 50);
            this.TBInput.Name = "TBInput";
            this.TBInput.PasswordChar = '*';
            this.TBInput.PlaceholderText = "Enter activation code";
            this.TBInput.Size = new System.Drawing.Size(195, 23);
            this.TBInput.TabIndex = 0;
            // 
            // BSubmit
            // 
            this.BSubmit.Location = new System.Drawing.Point(151, 112);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(75, 23);
            this.BSubmit.TabIndex = 1;
            this.BSubmit.Text = "Submit";
            this.BSubmit.UseVisualStyleBackColor = true;
            this.BSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BSubmit);
            this.Controls.Add(this.TBInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TBInput;
        private Button BSubmit;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}