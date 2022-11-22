namespace Nasatti_RicercaOperativa
{
    partial class RicercaOperativa
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabella = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.produttori = new System.Windows.Forms.NumericUpDown();
            this.destinatari = new System.Windows.Forms.NumericUpDown();
            this.NordOvest_btn = new System.Windows.Forms.Button();
            this.minCosti_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.random_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produttori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinatari)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabella
            // 
            this.tabella.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabella.BackgroundColor = System.Drawing.Color.White;
            this.tabella.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabella.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabella.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabella.Location = new System.Drawing.Point(43, 208);
            this.tabella.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabella.Name = "tabella";
            this.tabella.RowHeadersWidth = 51;
            this.tabella.Size = new System.Drawing.Size(1013, 343);
            this.tabella.TabIndex = 0;
            this.tabella.Visible = false;
            this.tabella.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.tabella_EditingControlShowing);
            this.tabella.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabella_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "produttori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "destinatari";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(401, 113);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crea";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // produttori
            // 
            this.produttori.Location = new System.Drawing.Point(220, 113);
            this.produttori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.produttori.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.produttori.Name = "produttori";
            this.produttori.Size = new System.Drawing.Size(160, 22);
            this.produttori.TabIndex = 6;
            this.produttori.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // destinatari
            // 
            this.destinatari.Location = new System.Drawing.Point(220, 159);
            this.destinatari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.destinatari.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.destinatari.Name = "destinatari";
            this.destinatari.Size = new System.Drawing.Size(160, 22);
            this.destinatari.TabIndex = 7;
            this.destinatari.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // NordOvest_btn
            // 
            this.NordOvest_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NordOvest_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NordOvest_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NordOvest_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NordOvest_btn.ForeColor = System.Drawing.Color.White;
            this.NordOvest_btn.Location = new System.Drawing.Point(830, 113);
            this.NordOvest_btn.Margin = new System.Windows.Forms.Padding(0);
            this.NordOvest_btn.Name = "NordOvest_btn";
            this.NordOvest_btn.Size = new System.Drawing.Size(108, 64);
            this.NordOvest_btn.TabIndex = 8;
            this.NordOvest_btn.Text = "Nord-Ovest";
            this.NordOvest_btn.UseVisualStyleBackColor = false;
            this.NordOvest_btn.Visible = false;
            this.NordOvest_btn.Click += new System.EventHandler(this.NordOvest_btn_Click);
            // 
            // minCosti_btn
            // 
            this.minCosti_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minCosti_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.minCosti_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minCosti_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minCosti_btn.ForeColor = System.Drawing.Color.White;
            this.minCosti_btn.Location = new System.Drawing.Point(948, 113);
            this.minCosti_btn.Margin = new System.Windows.Forms.Padding(0);
            this.minCosti_btn.Name = "minCosti_btn";
            this.minCosti_btn.Size = new System.Drawing.Size(108, 64);
            this.minCosti_btn.TabIndex = 9;
            this.minCosti_btn.Text = "Mini costi";
            this.minCosti_btn.UseVisualStyleBackColor = false;
            this.minCosti_btn.Visible = false;
            this.minCosti_btn.Click += new System.EventHandler(this.minCosti_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-9, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 89);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(437, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "RICERCA OPERATIVA";
            // 
            // random_btn
            // 
            this.random_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.random_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.random_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.random_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_btn.ForeColor = System.Drawing.Color.White;
            this.random_btn.Location = new System.Drawing.Point(712, 113);
            this.random_btn.Margin = new System.Windows.Forms.Padding(0);
            this.random_btn.Name = "random_btn";
            this.random_btn.Size = new System.Drawing.Size(108, 64);
            this.random_btn.TabIndex = 11;
            this.random_btn.Text = "Carica";
            this.random_btn.UseVisualStyleBackColor = false;
            this.random_btn.Visible = false;
            this.random_btn.Click += new System.EventHandler(this.random_btn_Click);
            // 
            // RicercaOperativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 587);
            this.Controls.Add(this.random_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minCosti_btn);
            this.Controls.Add(this.NordOvest_btn);
            this.Controls.Add(this.destinatari);
            this.Controls.Add(this.produttori);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabella);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(938, 515);
            this.Name = "RicercaOperativa";
            this.Text = "Ricerca Operativa";
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produttori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinatari)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabella;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown produttori;
        private System.Windows.Forms.NumericUpDown destinatari;
        private System.Windows.Forms.Button NordOvest_btn;
        private System.Windows.Forms.Button minCosti_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button random_btn;
    }
}

