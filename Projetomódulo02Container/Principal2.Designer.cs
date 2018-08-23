namespace Projetomódulo02Container
{
    partial class frmPrincipal2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.containersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // containersToolStripMenuItem
            // 
            this.containersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flowLayoutPanelToolStripMenuItem,
            this.groupBoxToolStripMenuItem,
            this.panelToolStripMenuItem,
            this.splitContainerToolStripMenuItem,
            this.tabControlToolStripMenuItem,
            this.FrmPrincipal});
            this.containersToolStripMenuItem.Name = "containersToolStripMenuItem";
            this.containersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.containersToolStripMenuItem.Text = "Containers";
            // 
            // flowLayoutPanelToolStripMenuItem
            // 
            this.flowLayoutPanelToolStripMenuItem.Name = "flowLayoutPanelToolStripMenuItem";
            this.flowLayoutPanelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.flowLayoutPanelToolStripMenuItem.Text = "FlowLayoutPanel";
            this.flowLayoutPanelToolStripMenuItem.Click += new System.EventHandler(this.flowLayoutPanelToolStripMenuItem_Click);
            // 
            // groupBoxToolStripMenuItem
            // 
            this.groupBoxToolStripMenuItem.Name = "groupBoxToolStripMenuItem";
            this.groupBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupBoxToolStripMenuItem.Text = "GroupBox";
            this.groupBoxToolStripMenuItem.Click += new System.EventHandler(this.groupBoxToolStripMenuItem_Click);
            // 
            // panelToolStripMenuItem
            // 
            this.panelToolStripMenuItem.Name = "panelToolStripMenuItem";
            this.panelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.panelToolStripMenuItem.Text = "Panel";
            this.panelToolStripMenuItem.Click += new System.EventHandler(this.panelToolStripMenuItem_Click);
            // 
            // splitContainerToolStripMenuItem
            // 
            this.splitContainerToolStripMenuItem.Name = "splitContainerToolStripMenuItem";
            this.splitContainerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.splitContainerToolStripMenuItem.Text = "SplitContainer";
            this.splitContainerToolStripMenuItem.Click += new System.EventHandler(this.splitContainerToolStripMenuItem_Click);
            // 
            // tabControlToolStripMenuItem
            // 
            this.tabControlToolStripMenuItem.Name = "tabControlToolStripMenuItem";
            this.tabControlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabControlToolStripMenuItem.Text = "TabControl";
            this.tabControlToolStripMenuItem.Click += new System.EventHandler(this.tabControlToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.FrmPrincipal.Name = "FrmPrincipal";
            this.FrmPrincipal.Size = new System.Drawing.Size(180, 22);
            this.FrmPrincipal.Text = "TableLayoutControl";
            this.FrmPrincipal.Click += new System.EventHandler(this.tableLayoutControlToolStripMenuItem_Click);
            // 
            // frmPrincipal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal2";
            this.Text = "Principal2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem containersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flowLayoutPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FrmPrincipal;
    }
}