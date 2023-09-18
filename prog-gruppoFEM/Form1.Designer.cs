namespace prog_gruppoFEM
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
            this.textBoxRecMessaggio = new System.Windows.Forms.TextBox();
            this.textBoxMessaggio = new System.Windows.Forms.TextBox();
            this.buttonInvia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRecMessaggio
            // 
            this.textBoxRecMessaggio.AcceptsReturn = true;
            this.textBoxRecMessaggio.Location = new System.Drawing.Point(12, 93);
            this.textBoxRecMessaggio.Multiline = true;
            this.textBoxRecMessaggio.Name = "textBoxRecMessaggio";
            this.textBoxRecMessaggio.ReadOnly = true;
            this.textBoxRecMessaggio.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRecMessaggio.Size = new System.Drawing.Size(221, 224);
            this.textBoxRecMessaggio.TabIndex = 0;
            this.textBoxRecMessaggio.TextChanged += new System.EventHandler(this.textBoxRecMessaggio_TextChanged);
            // 
            // textBoxMessaggio
            // 
            this.textBoxMessaggio.Location = new System.Drawing.Point(12, 39);
            this.textBoxMessaggio.Name = "textBoxMessaggio";
            this.textBoxMessaggio.Size = new System.Drawing.Size(159, 23);
            this.textBoxMessaggio.TabIndex = 1;
            // 
            // buttonInvia
            // 
            this.buttonInvia.Location = new System.Drawing.Point(219, 39);
            this.buttonInvia.Name = "buttonInvia";
            this.buttonInvia.Size = new System.Drawing.Size(75, 23);
            this.buttonInvia.TabIndex = 2;
            this.buttonInvia.Text = "Invia";
            this.buttonInvia.UseVisualStyleBackColor = true;
            this.buttonInvia.Click += new System.EventHandler(this.buttonInvia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 382);
            this.Controls.Add(this.buttonInvia);
            this.Controls.Add(this.textBoxMessaggio);
            this.Controls.Add(this.textBoxRecMessaggio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxRecMessaggio;
        private TextBox textBoxMessaggio;
        private Button buttonInvia;
    }
}