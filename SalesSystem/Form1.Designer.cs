namespace SalesSystem
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockLedgeUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricReceiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistualQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLogUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.itemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.resourcesToolStripMenuItem,
            this.operationToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.userToolStripMenuItem,
            this.dBConfigToolStripMenuItem,
            this.stockLedgeUpdateToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userListToolStripMenuItem,
            this.userProfileToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // userListToolStripMenuItem
            // 
            this.userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            this.userListToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.userListToolStripMenuItem.Text = "User List";
            this.userListToolStripMenuItem.Click += new System.EventHandler(this.userListToolStripMenuItem_Click);
            // 
            // userProfileToolStripMenuItem
            // 
            this.userProfileToolStripMenuItem.Name = "userProfileToolStripMenuItem";
            this.userProfileToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.userProfileToolStripMenuItem.Text = "User Profile";
            this.userProfileToolStripMenuItem.Click += new System.EventHandler(this.userProfileToolStripMenuItem_Click);
            // 
            // dBConfigToolStripMenuItem
            // 
            this.dBConfigToolStripMenuItem.Name = "dBConfigToolStripMenuItem";
            this.dBConfigToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.dBConfigToolStripMenuItem.Text = "DB Config";
            // 
            // stockLedgeUpdateToolStripMenuItem
            // 
            this.stockLedgeUpdateToolStripMenuItem.Name = "stockLedgeUpdateToolStripMenuItem";
            this.stockLedgeUpdateToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.stockLedgeUpdateToolStripMenuItem.Text = "Stock Ledge Update";
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryListToolStripMenuItem,
            this.brandListToolStripMenuItem,
            this.itemListToolStripMenuItem});
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.resourcesToolStripMenuItem.Text = "Resource";
            // 
            // categoryListToolStripMenuItem
            // 
            this.categoryListToolStripMenuItem.Name = "categoryListToolStripMenuItem";
            this.categoryListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoryListToolStripMenuItem.Text = "Category List";
            this.categoryListToolStripMenuItem.Click += new System.EventHandler(this.categoryListToolStripMenuItem_Click);
            // 
            // brandListToolStripMenuItem
            // 
            this.brandListToolStripMenuItem.Name = "brandListToolStripMenuItem";
            this.brandListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.brandListToolStripMenuItem.Text = "Brand List";
            this.brandListToolStripMenuItem.Click += new System.EventHandler(this.brandListToolStripMenuItem_Click);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseOrderToolStripMenuItem,
            this.salesOrderToolStripMenuItem,
            this.adjustmentToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.orderSimulationToolStripMenuItem,
            this.vistualQuantityToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.fabricReceiveToolStripMenuItem,
            this.shipmentToolStripMenuItem});
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // fabricReceiveToolStripMenuItem
            // 
            this.fabricReceiveToolStripMenuItem.Name = "fabricReceiveToolStripMenuItem";
            this.fabricReceiveToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.fabricReceiveToolStripMenuItem.Text = "Fabric Receive";
            // 
            // shipmentToolStripMenuItem
            // 
            this.shipmentToolStripMenuItem.Name = "shipmentToolStripMenuItem";
            this.shipmentToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.shipmentToolStripMenuItem.Text = "Shipment";
            // 
            // salesOrderToolStripMenuItem
            // 
            this.salesOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingToolStripMenuItem,
            this.fabricIssueToolStripMenuItem});
            this.salesOrderToolStripMenuItem.Name = "salesOrderToolStripMenuItem";
            this.salesOrderToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.salesOrderToolStripMenuItem.Text = "Sales Order";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // fabricIssueToolStripMenuItem
            // 
            this.fabricIssueToolStripMenuItem.Name = "fabricIssueToolStripMenuItem";
            this.fabricIssueToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.fabricIssueToolStripMenuItem.Text = "Fabric Issue";
            // 
            // adjustmentToolStripMenuItem
            // 
            this.adjustmentToolStripMenuItem.Name = "adjustmentToolStripMenuItem";
            this.adjustmentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.adjustmentToolStripMenuItem.Text = "Adjustment";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // orderSimulationToolStripMenuItem
            // 
            this.orderSimulationToolStripMenuItem.Name = "orderSimulationToolStripMenuItem";
            this.orderSimulationToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.orderSimulationToolStripMenuItem.Text = "Order Simulation";
            // 
            // vistualQuantityToolStripMenuItem
            // 
            this.vistualQuantityToolStripMenuItem.Name = "vistualQuantityToolStripMenuItem";
            this.vistualQuantityToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.vistualQuantityToolStripMenuItem.Text = "Virtual Quantity";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblLogUser,
            this.toolStripStatusLabel2,
            this.lblServer,
            this.toolStripStatusLabel3,
            this.lblDatabase});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "User:";
            // 
            // lblLogUser
            // 
            this.lblLogUser.Name = "lblLogUser";
            this.lblLogUser.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel2.Text = "Server:";
            // 
            // lblServer
            // 
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(22, 17);
            this.lblServer.Text = "     ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel3.Text = "Database:";
            // 
            // lblDatabase
            // 
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(19, 17);
            this.lblDatabase.Text = "    ";
            // 
            // itemListToolStripMenuItem
            // 
            this.itemListToolStripMenuItem.Name = "itemListToolStripMenuItem";
            this.itemListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.itemListToolStripMenuItem.Text = "Item List";
            this.itemListToolStripMenuItem.Click += new System.EventHandler(this.itemListToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockLedgeUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricReceiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistualQuantityToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblLogUser;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel lblServer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel lblDatabase;
        private System.Windows.Forms.ToolStripMenuItem categoryListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemListToolStripMenuItem;
    }
}

