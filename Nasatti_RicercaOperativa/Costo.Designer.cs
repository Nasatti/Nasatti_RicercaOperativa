namespace Nasatti_RicercaOperativa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.risultato = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totale = new System.Windows.Forms.Label();
            this.calcolo = new System.Windows.Forms.RichTextBox();
            this.tab = new System.Windows.Forms.DataGridView();
            this.risolvi_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(527, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "COSTO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 78);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // risultato
            // 
            this.risultato.AutoSize = true;
            this.risultato.Location = new System.Drawing.Point(125, 105);
            this.risultato.Name = "risultato";
            this.risultato.Size = new System.Drawing.Size(0, 16);
            this.risultato.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "totale:";
            // 
            // totale
            // 
            this.totale.AutoSize = true;
            this.totale.Location = new System.Drawing.Point(232, 108);
            this.totale.Name = "totale";
            this.totale.Size = new System.Drawing.Size(0, 16);
            this.totale.TabIndex = 7;
            // 
            // calcolo
            // 
            this.calcolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.calcolo.Location = new System.Drawing.Point(12, 108);
            this.calcolo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calcolo.Name = "calcolo";
            this.calcolo.Size = new System.Drawing.Size(164, 498);
            this.calcolo.TabIndex = 8;
            this.calcolo.Text = "";
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.BackgroundColor = System.Drawing.Color.White;
            this.tab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab.Location = new System.Drawing.Point(400, 108);
            this.tab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab.Name = "tab";
            this.tab.RowHeadersWidth = 51;
            this.tab.Size = new System.Drawing.Size(727, 494);
            this.tab.TabIndex = 9;
            // 
            // risolvi_btn
            // 
            this.risolvi_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.risolvi_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.risolvi_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.risolvi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risolvi_btn.ForeColor = System.Drawing.Color.White;
            this.risolvi_btn.Location = new System.Drawing.Point(261, 316);
            this.risolvi_btn.Margin = new System.Windows.Forms.Padding(0);
            this.risolvi_btn.Name = "risolvi_btn";
            this.risolvi_btn.Size = new System.Drawing.Size(108, 64);
            this.risolvi_btn.TabIndex = 10;
            this.risolvi_btn.Text = "RISOLVI";
            this.risolvi_btn.UseVisualStyleBackColor = false;
            this.risolvi_btn.Click += new System.EventHandler(this.risolvi_btn_Click);
            // 
            // Costo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 617);
            this.Controls.Add(this.risolvi_btn);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.calcolo);
            this.Controls.Add(this.totale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.risultato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(865, 447);
            this.Name = "Costo";
            this.Text = "Costo";
            this.Load += new System.EventHandler(this.Costo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab)).EndInit();
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
        private System.Windows.Forms.DataGridView tab;
        private System.Windows.Forms.Button risolvi_btn;
    }
}