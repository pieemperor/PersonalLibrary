namespace _2210_002_CowellDakota_DataStructuresProject2
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllByAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAuthorFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOwnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarBooksLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarDateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.coAuthorLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ownerPanel = new System.Windows.Forms.Panel();
            this.ownerAddressLabel = new System.Windows.Forms.Label();
            this.ownerInfoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.ownerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1574, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.showAllByAuthorToolStripMenuItem,
            this.clearAuthorFilterToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(319, 38);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(319, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(319, 38);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // showAllByAuthorToolStripMenuItem
            // 
            this.showAllByAuthorToolStripMenuItem.Name = "showAllByAuthorToolStripMenuItem";
            this.showAllByAuthorToolStripMenuItem.Size = new System.Drawing.Size(319, 38);
            this.showAllByAuthorToolStripMenuItem.Text = "Show All By Author";
            this.showAllByAuthorToolStripMenuItem.Click += new System.EventHandler(this.showAllByAuthorToolStripMenuItem_Click);
            // 
            // clearAuthorFilterToolStripMenuItem
            // 
            this.clearAuthorFilterToolStripMenuItem.Name = "clearAuthorFilterToolStripMenuItem";
            this.clearAuthorFilterToolStripMenuItem.Size = new System.Drawing.Size(319, 38);
            this.clearAuthorFilterToolStripMenuItem.Text = "Clear Author Filter";
            this.clearAuthorFilterToolStripMenuItem.Click += new System.EventHandler(this.clearAuthorFilterToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(319, 38);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.editToolStripMenuItem,
            this.updateOwnerToolStripMenuItem});
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // updateOwnerToolStripMenuItem
            // 
            this.updateOwnerToolStripMenuItem.Name = "updateOwnerToolStripMenuItem";
            this.updateOwnerToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.updateOwnerToolStripMenuItem.Text = "Update Owner";
            this.updateOwnerToolStripMenuItem.Click += new System.EventHandler(this.updateOwnerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // booksListBox
            // 
            this.booksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.HorizontalScrollbar = true;
            this.booksListBox.ItemHeight = 25;
            this.booksListBox.Location = new System.Drawing.Point(0, 43);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(380, 504);
            this.booksListBox.TabIndex = 1;
            this.booksListBox.SelectedIndexChanged += new System.EventHandler(this.booksListBox_SelectedIndexChanged);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel,
            this.statusBarBooksLabel,
            this.statusBarDateLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 707);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1574, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusBarBooksLabel
            // 
            this.statusBarBooksLabel.Name = "statusBarBooksLabel";
            this.statusBarBooksLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusBarDateLabel
            // 
            this.statusBarDateLabel.Name = "statusBarDateLabel";
            this.statusBarDateLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(68, 263);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(102, 37);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Co-Author";
            // 
            // coAuthorLabel
            // 
            this.coAuthorLabel.AutoSize = true;
            this.coAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coAuthorLabel.Location = new System.Drawing.Point(68, 377);
            this.coAuthorLabel.Name = "coAuthorLabel";
            this.coAuthorLabel.Size = new System.Drawing.Size(102, 37);
            this.coAuthorLabel.TabIndex = 8;
            this.coAuthorLabel.Text = "label6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(669, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 37);
            this.label8.TabIndex = 10;
            this.label8.Text = "Type";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(669, 263);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(102, 37);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "label9";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(669, 377);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(102, 37);
            this.categoryLabel.TabIndex = 13;
            this.categoryLabel.Text = "label7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(669, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 37);
            this.label10.TabIndex = 12;
            this.label10.Text = "Category";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(669, 156);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(116, 37);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(669, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 37);
            this.label12.TabIndex = 14;
            this.label12.Text = "Price";
            // 
            // detailsPanel
            // 
            this.detailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Controls.Add(this.priceLabel);
            this.detailsPanel.Controls.Add(this.titleLabel);
            this.detailsPanel.Controls.Add(this.label12);
            this.detailsPanel.Controls.Add(this.label2);
            this.detailsPanel.Controls.Add(this.categoryLabel);
            this.detailsPanel.Controls.Add(this.label8);
            this.detailsPanel.Controls.Add(this.label10);
            this.detailsPanel.Controls.Add(this.label3);
            this.detailsPanel.Controls.Add(this.typeLabel);
            this.detailsPanel.Controls.Add(this.authorLabel);
            this.detailsPanel.Controls.Add(this.label5);
            this.detailsPanel.Controls.Add(this.coAuthorLabel);
            this.detailsPanel.Location = new System.Drawing.Point(379, 43);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(1195, 504);
            this.detailsPanel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 51);
            this.label1.TabIndex = 16;
            this.label1.Text = "Book Details";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(68, 156);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(102, 37);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // ownerPanel
            // 
            this.ownerPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ownerPanel.Controls.Add(this.ownerAddressLabel);
            this.ownerPanel.Controls.Add(this.ownerInfoLabel);
            this.ownerPanel.Controls.Add(this.label4);
            this.ownerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ownerPanel.Location = new System.Drawing.Point(0, 580);
            this.ownerPanel.Name = "ownerPanel";
            this.ownerPanel.Size = new System.Drawing.Size(1574, 127);
            this.ownerPanel.TabIndex = 17;
            // 
            // ownerAddressLabel
            // 
            this.ownerAddressLabel.AutoSize = true;
            this.ownerAddressLabel.Location = new System.Drawing.Point(13, 78);
            this.ownerAddressLabel.Name = "ownerAddressLabel";
            this.ownerAddressLabel.Size = new System.Drawing.Size(0, 25);
            this.ownerAddressLabel.TabIndex = 2;
            // 
            // ownerInfoLabel
            // 
            this.ownerInfoLabel.AutoSize = true;
            this.ownerInfoLabel.Location = new System.Drawing.Point(13, 46);
            this.ownerInfoLabel.Name = "ownerInfoLabel";
            this.ownerInfoLabel.Size = new System.Drawing.Size(0, 25);
            this.ownerInfoLabel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Owner Info:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 729);
            this.Controls.Add(this.ownerPanel);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.detailsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Data Structures Personal Library Tracker";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.ownerPanel.ResumeLayout(false);
            this.ownerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllByAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateOwnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label coAuthorLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ownerPanel;
        private System.Windows.Forms.Label ownerInfoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ownerAddressLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusBarDateLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel statusBarBooksLabel;
        private System.Windows.Forms.ToolStripMenuItem clearAuthorFilterToolStripMenuItem;
    }
}