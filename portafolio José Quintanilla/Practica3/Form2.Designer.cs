namespace Practica3
{
    partial class Form2
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
            this.btnMostrae = new System.Windows.Forms.Button();
            this.lstLetras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrae
            // 
            this.btnMostrae.Location = new System.Drawing.Point(90, 324);
            this.btnMostrae.Name = "btnMostrae";
            this.btnMostrae.Size = new System.Drawing.Size(92, 32);
            this.btnMostrae.TabIndex = 3;
            this.btnMostrae.Text = "Mostrar";
            this.btnMostrae.UseVisualStyleBackColor = true;
            this.btnMostrae.Click += new System.EventHandler(this.btnMostrae_Click);
            // 
            // lstLetras
            // 
            this.lstLetras.FormattingEnabled = true;
            this.lstLetras.Location = new System.Drawing.Point(72, 94);
            this.lstLetras.Name = "lstLetras";
            this.lstLetras.Size = new System.Drawing.Size(129, 212);
            this.lstLetras.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Abecedario";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrae);
            this.Controls.Add(this.lstLetras);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrae;
        private System.Windows.Forms.ListBox lstLetras;
        private System.Windows.Forms.Label label1;
    }
}