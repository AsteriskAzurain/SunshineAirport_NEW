﻿namespace Application0701.ouser
{
    partial class ouserMenu
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.searchFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchFlightsToolStripMenuItem,
            this.foodServicesToolStripMenuItem,
            this.flightStatusToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1355, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // searchFlightsToolStripMenuItem
            // 
            this.searchFlightsToolStripMenuItem.Name = "searchFlightsToolStripMenuItem";
            this.searchFlightsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.searchFlightsToolStripMenuItem.Text = "Search Flights";
            this.searchFlightsToolStripMenuItem.Click += new System.EventHandler(this.searchFlightsToolStripMenuItem_Click);
            // 
            // foodServicesToolStripMenuItem
            // 
            this.foodServicesToolStripMenuItem.Name = "foodServicesToolStripMenuItem";
            this.foodServicesToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.foodServicesToolStripMenuItem.Text = "Food Services";
            this.foodServicesToolStripMenuItem.Click += new System.EventHandler(this.foodServicesToolStripMenuItem_Click);
            // 
            // flightStatusToolStripMenuItem
            // 
            this.flightStatusToolStripMenuItem.Name = "flightStatusToolStripMenuItem";
            this.flightStatusToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.flightStatusToolStripMenuItem.Text = "Flight Status";
            this.flightStatusToolStripMenuItem.Click += new System.EventHandler(this.flightStatusToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ouserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 918);
            this.Controls.Add(this.menuStrip2);
            this.Name = "ouserMenu";
            this.Text = "Office User Menu";
            this.Load += new System.EventHandler(this.ouserMenu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem searchFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}