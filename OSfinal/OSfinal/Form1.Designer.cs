namespace OSfinal
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
            this.components = new System.ComponentModel.Container();
            this.Proseslstbx = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kullandığıBellekMiktarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullandığıİşlemciYüzdesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prosesiÖldürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Proseslstbx
            // 
            this.Proseslstbx.ContextMenuStrip = this.contextMenuStrip1;
            this.Proseslstbx.FormattingEnabled = true;
            this.Proseslstbx.Location = new System.Drawing.Point(12, 12);
            this.Proseslstbx.Name = "Proseslstbx";
            this.Proseslstbx.Size = new System.Drawing.Size(422, 407);
            this.Proseslstbx.TabIndex = 0;
            this.Proseslstbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Proseslstbx_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.kullandığıBellekMiktarıToolStripMenuItem,
            this.kullandığıİşlemciYüzdesiToolStripMenuItem,
            this.prosesiÖldürToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.toolStripMenuItem1.Text = "Prosesin thread sayısı";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // kullandığıBellekMiktarıToolStripMenuItem
            // 
            this.kullandığıBellekMiktarıToolStripMenuItem.Name = "kullandığıBellekMiktarıToolStripMenuItem";
            this.kullandığıBellekMiktarıToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.kullandığıBellekMiktarıToolStripMenuItem.Text = "Kullandığı bellek miktarı";
            this.kullandığıBellekMiktarıToolStripMenuItem.Click += new System.EventHandler(this.kullandığıBellekMiktarıToolStripMenuItem_Click);
            // 
            // kullandığıİşlemciYüzdesiToolStripMenuItem
            // 
            this.kullandığıİşlemciYüzdesiToolStripMenuItem.Name = "kullandığıİşlemciYüzdesiToolStripMenuItem";
            this.kullandığıİşlemciYüzdesiToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.kullandığıİşlemciYüzdesiToolStripMenuItem.Text = "Kullandığı işlemci yüzdesi";
            this.kullandığıİşlemciYüzdesiToolStripMenuItem.Click += new System.EventHandler(this.kullandığıİşlemciYüzdesiToolStripMenuItem_Click);
            // 
            // prosesiÖldürToolStripMenuItem
            // 
            this.prosesiÖldürToolStripMenuItem.Name = "prosesiÖldürToolStripMenuItem";
            this.prosesiÖldürToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.prosesiÖldürToolStripMenuItem.Text = "Prosesi öldür";
            this.prosesiÖldürToolStripMenuItem.Click += new System.EventHandler(this.prosesiÖldürToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(448, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Proseslstbx);
            this.Name = "Form1";
            this.Text = "Görev Yöneticisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Proseslstbx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kullandığıBellekMiktarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullandığıİşlemciYüzdesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prosesiÖldürToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

