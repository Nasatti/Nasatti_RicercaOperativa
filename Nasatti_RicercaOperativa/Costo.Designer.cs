namespace Nasatti_Ricerca_operativa
{
    partial class Costo
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.risultato = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totale = new System.Windows.Forms.Label();
            this.calcolo = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "COSTO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 63);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // risultato
            // 
            this.risultato.AutoSize = true;
            this.risultato.Location = new System.Drawing.Point(94, 85);
            this.risultato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.risultato.Name = "risultato";
            this.risultato.Size = new System.Drawing.Size(0, 13);
            this.risultato.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "totale:";
            // 
            // totale
            // 
            this.totale.AutoSize = true;
            this.totale.Location = new System.Drawing.Point(233, 85);
            this.totale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totale.Name = "totale";
            this.totale.Size = new System.Drawing.Size(0, 13);
            this.totale.TabIndex = 7;
            // 
            // calcolo
            // 
            this.calcolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.calcolo.Location = new System.Drawing.Point(9, 88);
            this.calcolo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calcolo.Name = "calcolo";
            this.calcolo.Size = new System.Drawing.Size(124, 218);
            this.calcolo.TabIndex = 8;
            this.calcolo.Text = "";
            // 
            // Costo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 314);
            this.Controls.Add(this.calcolo);
            this.Controls.Add(this.totale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.risultato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Costo";
            this.Text = "Costo";
            this.Load += new System.EventHandler(this.Costo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label risultato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totale;
        private System.Windows.Forms.RichTextBox calcolo;
    }
}