namespace GrammarAnalysers
{
    partial class AnaForm
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.woanabutton = new System.Windows.Forms.Button();
            this.grabutton = new System.Windows.Forms.Button();
            this.polbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(47, 48);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(205, 197);
            this.Input.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(313, 48);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(194, 197);
            this.Output.TabIndex = 1;
            // 
            // woanabutton
            // 
            this.woanabutton.Location = new System.Drawing.Point(80, 285);
            this.woanabutton.Name = "woanabutton";
            this.woanabutton.Size = new System.Drawing.Size(118, 41);
            this.woanabutton.TabIndex = 2;
            this.woanabutton.Text = "Word Analyse";
            this.woanabutton.UseVisualStyleBackColor = true;
            this.woanabutton.Click += new System.EventHandler(this.woanabutton_Click);
            // 
            // grabutton
            // 
            this.grabutton.Location = new System.Drawing.Point(226, 285);
            this.grabutton.Name = "grabutton";
            this.grabutton.Size = new System.Drawing.Size(112, 41);
            this.grabutton.TabIndex = 3;
            this.grabutton.Text = "Grammar Analyse";
            this.grabutton.UseVisualStyleBackColor = true;
            this.grabutton.Click += new System.EventHandler(this.grabutton_Click);
            // 
            // polbutton
            // 
            this.polbutton.Location = new System.Drawing.Point(368, 285);
            this.polbutton.Name = "polbutton";
            this.polbutton.Size = new System.Drawing.Size(119, 41);
            this.polbutton.TabIndex = 4;
            this.polbutton.Text = "Poland";
            this.polbutton.UseVisualStyleBackColor = true;
            this.polbutton.Click += new System.EventHandler(this.polbutton_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 359);
            this.Controls.Add(this.polbutton);
            this.Controls.Add(this.grabutton);
            this.Controls.Add(this.woanabutton);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Name = "AnaForm";
            this.Text = "GrammarAnalysers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button woanabutton;
        private System.Windows.Forms.Button grabutton;
        private System.Windows.Forms.Button polbutton;
    }
}

