namespace OOP_SPRING_2019
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
            this.mycontainer1 = new OOP_SPRING_2019.Mycontainer();
            this.SuspendLayout();
            // 
            // mycontainer1
            // 
            this.mycontainer1.Location = new System.Drawing.Point(-1, 3);
            this.mycontainer1.Name = "mycontainer1";
            this.mycontainer1.Size = new System.Drawing.Size(830, 735);
            this.mycontainer1.TabIndex = 0;
            this.mycontainer1.Paint += new System.Windows.Forms.PaintEventHandler(this.mycontainer1_Paint_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 741);
            this.Controls.Add(this.mycontainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Mycontainer mycontainer1;
    }
}

