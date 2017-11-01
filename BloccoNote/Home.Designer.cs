namespace BloccoNote
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiaImpostazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elencoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elencoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Lista = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiudiToolStripMenuItem,
            this.nuovaNotaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(178, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiaImpostazioniToolStripMenuItem});
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.chiudiToolStripMenuItem.Text = "Menu";
            // 
            // cambiaImpostazioniToolStripMenuItem
            // 
            this.cambiaImpostazioniToolStripMenuItem.Name = "cambiaImpostazioniToolStripMenuItem";
            this.cambiaImpostazioniToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cambiaImpostazioniToolStripMenuItem.Text = "Impostazioni";
            this.cambiaImpostazioniToolStripMenuItem.Click += new System.EventHandler(this.cambiaImpostazioniToolStripMenuItem_Click);
            // 
            // nuovaNotaToolStripMenuItem
            // 
            this.nuovaNotaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elencoToolStripMenuItem,
            this.elencoToolStripMenuItem1});
            this.nuovaNotaToolStripMenuItem.Name = "nuovaNotaToolStripMenuItem";
            this.nuovaNotaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.nuovaNotaToolStripMenuItem.Text = "Nuova Nota";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 48);
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.test1ToolStripMenuItem.Text = "Test 1";
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.test2ToolStripMenuItem.Text = "Test 2";
            // 
            // elencoToolStripMenuItem
            // 
            this.elencoToolStripMenuItem.Name = "elencoToolStripMenuItem";
            this.elencoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.elencoToolStripMenuItem.Text = "Nuova";
            this.elencoToolStripMenuItem.Click += new System.EventHandler(this.elencoToolStripMenuItem_Click);
            // 
            // elencoToolStripMenuItem1
            // 
            this.elencoToolStripMenuItem1.Name = "elencoToolStripMenuItem1";
            this.elencoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.elencoToolStripMenuItem1.Text = "Elenco";
            this.elencoToolStripMenuItem1.Click += new System.EventHandler(this.elencoToolStripMenuItem1_Click);
            // 
            // Lista
            // 
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(153, 26);
            this.Lista.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Lista_ItemClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 40);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem cambiaImpostazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaNotaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elencoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elencoToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip Lista;
    }
}

