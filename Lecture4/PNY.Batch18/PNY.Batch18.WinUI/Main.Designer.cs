namespace PNY.Batch18.WinUI
{
    partial class frmMain
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.listingToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "MainMenu";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCountryToolStripMenuItem,
            this.addCityToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // addCountryToolStripMenuItem
            // 
            this.addCountryToolStripMenuItem.Name = "addCountryToolStripMenuItem";
            this.addCountryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCountryToolStripMenuItem.Text = "Add Country";
            this.addCountryToolStripMenuItem.Click += new System.EventHandler(this.AddCountryToolStripMenuItem_Click);
            // 
            // addCityToolStripMenuItem
            // 
            this.addCityToolStripMenuItem.Name = "addCityToolStripMenuItem";
            this.addCityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCityToolStripMenuItem.Text = "Add City";
            this.addCityToolStripMenuItem.Click += new System.EventHandler(this.AddCityToolStripMenuItem_Click);
            // 
            // listingToolStripMenuItem
            // 
            this.listingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countriesToolStripMenuItem,
            this.citiesToolStripMenuItem});
            this.listingToolStripMenuItem.Name = "listingToolStripMenuItem";
            this.listingToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.listingToolStripMenuItem.Text = "Listing";
            // 
            // countriesToolStripMenuItem
            // 
            this.countriesToolStripMenuItem.Name = "countriesToolStripMenuItem";
            this.countriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.countriesToolStripMenuItem.Text = "Countries";
            // 
            // citiesToolStripMenuItem
            // 
            this.citiesToolStripMenuItem.Name = "citiesToolStripMenuItem";
            this.citiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.citiesToolStripMenuItem.Text = "Cities";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Main";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citiesToolStripMenuItem;
    }
}