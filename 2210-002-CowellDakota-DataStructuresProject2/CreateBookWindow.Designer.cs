namespace _2210_002_CowellDakota_DataStructuresProject2
{
    partial class CreateBookWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBookWindow));
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.categoryDropDown = new System.Windows.Forms.ComboBox();
            this.typeDropDown = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.coAuthorTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.detailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsPanel
            // 
            this.detailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsPanel.Controls.Add(this.categoryDropDown);
            this.detailsPanel.Controls.Add(this.typeDropDown);
            this.detailsPanel.Controls.Add(this.titleLabel);
            this.detailsPanel.Controls.Add(this.createButton);
            this.detailsPanel.Controls.Add(this.priceTextBox);
            this.detailsPanel.Controls.Add(this.coAuthorTextBox);
            this.detailsPanel.Controls.Add(this.authorTextBox);
            this.detailsPanel.Controls.Add(this.titleTextBox);
            this.detailsPanel.Controls.Add(this.label12);
            this.detailsPanel.Controls.Add(this.label2);
            this.detailsPanel.Controls.Add(this.label8);
            this.detailsPanel.Controls.Add(this.label10);
            this.detailsPanel.Controls.Add(this.label3);
            this.detailsPanel.Controls.Add(this.label5);
            this.detailsPanel.Location = new System.Drawing.Point(3, 3);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(1037, 605);
            this.detailsPanel.TabIndex = 17;
            // 
            // categoryDropDown
            // 
            this.categoryDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDropDown.FormattingEnabled = true;
            this.categoryDropDown.Items.AddRange(new object[] {
            "Biography",
            "Comedy",
            "History",
            "Mystery",
            "ScienceAndTechnology",
            "Textbook",
            "Other"});
            this.categoryDropDown.Location = new System.Drawing.Point(596, 412);
            this.categoryDropDown.Name = "categoryDropDown";
            this.categoryDropDown.Size = new System.Drawing.Size(388, 45);
            this.categoryDropDown.TabIndex = 20;
            // 
            // typeDropDown
            // 
            this.typeDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeDropDown.FormattingEnabled = true;
            this.typeDropDown.Items.AddRange(new object[] {
            "Digital",
            "Print"});
            this.typeDropDown.Location = new System.Drawing.Point(596, 304);
            this.typeDropDown.Name = "typeDropDown";
            this.typeDropDown.Size = new System.Drawing.Size(388, 45);
            this.typeDropDown.TabIndex = 19;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(70, 49);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(447, 55);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Create A New Book";
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(861, 501);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(123, 55);
            this.createButton.TabIndex = 21;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(596, 200);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(388, 44);
            this.priceTextBox.TabIndex = 18;
            // 
            // coAuthorTextBox
            // 
            this.coAuthorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coAuthorTextBox.Location = new System.Drawing.Point(81, 412);
            this.coAuthorTextBox.Name = "coAuthorTextBox";
            this.coAuthorTextBox.Size = new System.Drawing.Size(436, 44);
            this.coAuthorTextBox.TabIndex = 17;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextBox.Location = new System.Drawing.Point(81, 303);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(436, 44);
            this.authorTextBox.TabIndex = 16;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(81, 200);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(436, 44);
            this.titleTextBox.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(589, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 37);
            this.label12.TabIndex = 14;
            this.label12.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(589, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 37);
            this.label8.TabIndex = 10;
            this.label8.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(589, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 37);
            this.label10.TabIndex = 12;
            this.label10.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Co-Author";
            // 
            // CreateBookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 610);
            this.Controls.Add(this.detailsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateBookWindow";
            this.Text = "Create A New Book";
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox coAuthorTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox categoryDropDown;
        private System.Windows.Forms.ComboBox typeDropDown;
    }
}