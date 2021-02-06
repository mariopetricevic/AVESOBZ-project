
namespace AVESOBZ.PresentationLayer
{
    partial class frmMainWindow
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
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDefaultModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.ticketsToolStripMenuItem});

            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(839, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDefaultModelToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // loadDefaultModelToolStripMenuItem
            // 
            this.loadDefaultModelToolStripMenuItem.Name = "loadDefaultModelToolStripMenuItem";
            this.loadDefaultModelToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.loadDefaultModelToolStripMenuItem.Text = "Load default model";
            this.loadDefaultModelToolStripMenuItem.Click += new System.EventHandler(this.loadDefaultModelToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAccountsToolStripMenuItem,
            this.addAccountToolStripMenuItem2});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.accountsToolStripMenuItem.Text = "Profili";
            // 
            // viewAccountsToolStripMenuItem
            // 
            this.viewAccountsToolStripMenuItem.Name = "viewAccountsToolStripMenuItem";
            this.viewAccountsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewAccountsToolStripMenuItem.Text = "Popis profila";
            this.viewAccountsToolStripMenuItem.Click += new System.EventHandler(this.viewAccountsToolStripMenuItem_Click);
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem2.Name = "addAccountToolStripMenuItem2";
            this.addAccountToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.addAccountToolStripMenuItem2.Text = "Izradi profil";
            this.addAccountToolStripMenuItem2.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);

            // 
            // transactionsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTicketsToolStripMenuItem,
            this.createTicketsToolStripMenuItem});

            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.ticketsToolStripMenuItem.Text = "Karte";
            // 
            // viewTransactionsToolStripMenuItem
            // 
            this.createTicketsToolStripMenuItem.Name = "createTicketsToolStripMenuItem";
            this.createTicketsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createTicketsToolStripMenuItem.Text = "Izdaj kartu";
            this.createTicketsToolStripMenuItem.Click += new System.EventHandler(this.createTicketsToolStripMenuItem_Click);


            this.viewTicketsToolStripMenuItem.Name = "viewTicketsToolStripMenuItem";
            this.viewTicketsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewTicketsToolStripMenuItem.Text = "Popis izdanih karti";
            this.viewTicketsToolStripMenuItem.Click += new System.EventHandler(this.viewTicketsToolStripMenuItem_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 511);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMainWindow";
            this.Text = "AVESOBZ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
    
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDefaultModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTicketsToolStripMenuItem;
     
    }
}

