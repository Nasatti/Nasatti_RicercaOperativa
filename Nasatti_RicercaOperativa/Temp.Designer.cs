namespace Nasatti_RicercaOperativa
{
    partial class Temp
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
            this.tabella = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).BeginInit();
            this.SuspendLayout();
            // 
            // tabella
            // 
            this.tabella.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabella.BackgroundColor = System.Drawing.Color.White;
            this.tabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabella.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabella.Location = new System.Drawing.Point(12, 25);
            this.tabella.Name = "tabella";
            this.tabella.RowHeadersWidth = 51;
            this.tabella.Size = new System.Drawing.Size(765, 265);
            this.tabella.TabIndex = 1;
            this.tabella.Visible = false;
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 329);
            this.Controls.Add(this.tabella);
            this.Name = "Temp";
            this.Text = "Temp";
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView tabella;
    }
}