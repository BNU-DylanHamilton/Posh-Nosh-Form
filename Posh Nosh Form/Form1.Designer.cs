namespace Posh_Nosh_Form
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
            this.starterGroupBox = new System.Windows.Forms.GroupBox();
            this.starterListBox = new System.Windows.Forms.ListBox();
            this.totalGroupBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.mainListBox = new System.Windows.Forms.ListBox();
            this.dessertGroupBox = new System.Windows.Forms.GroupBox();
            this.dessertComboBox = new System.Windows.Forms.ComboBox();
            this.starterGroupBox.SuspendLayout();
            this.totalGroupBox.SuspendLayout();
            this.mainGroupBox.SuspendLayout();
            this.dessertGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // starterGroupBox
            // 
            this.starterGroupBox.Controls.Add(this.starterListBox);
            this.starterGroupBox.Location = new System.Drawing.Point(29, 27);
            this.starterGroupBox.Name = "starterGroupBox";
            this.starterGroupBox.Size = new System.Drawing.Size(245, 109);
            this.starterGroupBox.TabIndex = 0;
            this.starterGroupBox.TabStop = false;
            this.starterGroupBox.Text = "Starter";
            // 
            // starterListBox
            // 
            this.starterListBox.FormattingEnabled = true;
            this.starterListBox.ItemHeight = 16;
            this.starterListBox.Items.AddRange(new object[] {
            "Chilli Fish Cakes",
            "Fish Cakes",
            "Salad",
            "Soup of the Day"});
            this.starterListBox.Location = new System.Drawing.Point(15, 39);
            this.starterListBox.Name = "starterListBox";
            this.starterListBox.Size = new System.Drawing.Size(217, 36);
            this.starterListBox.Sorted = true;
            this.starterListBox.TabIndex = 0;
            this.starterListBox.SelectedIndexChanged += new System.EventHandler(this.starterSelection);
            // 
            // totalGroupBox
            // 
            this.totalGroupBox.Controls.Add(this.totalLabel);
            this.totalGroupBox.Location = new System.Drawing.Point(398, 338);
            this.totalGroupBox.Name = "totalGroupBox";
            this.totalGroupBox.Size = new System.Drawing.Size(245, 75);
            this.totalGroupBox.TabIndex = 1;
            this.totalGroupBox.TabStop = false;
            this.totalGroupBox.Text = "Total Cost";
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(28, 31);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(93, 17);
            this.totalLabel.TabIndex = 0;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(660, 358);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(126, 42);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.closeApplication);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.mainListBox);
            this.mainGroupBox.Location = new System.Drawing.Point(29, 159);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(245, 109);
            this.mainGroupBox.TabIndex = 1;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Main";
            // 
            // mainListBox
            // 
            this.mainListBox.FormattingEnabled = true;
            this.mainListBox.ItemHeight = 16;
            this.mainListBox.Items.AddRange(new object[] {
            "Chicken Lasagne",
            "Fish and Chips",
            "Steak and Chips",
            "Vegetable Curry"});
            this.mainListBox.Location = new System.Drawing.Point(15, 39);
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(217, 36);
            this.mainListBox.Sorted = true;
            this.mainListBox.TabIndex = 0;
            this.mainListBox.SelectedIndexChanged += new System.EventHandler(this.mainSelection);
            // 
            // dessertGroupBox
            // 
            this.dessertGroupBox.Controls.Add(this.dessertComboBox);
            this.dessertGroupBox.Location = new System.Drawing.Point(29, 291);
            this.dessertGroupBox.Name = "dessertGroupBox";
            this.dessertGroupBox.Size = new System.Drawing.Size(245, 109);
            this.dessertGroupBox.TabIndex = 2;
            this.dessertGroupBox.TabStop = false;
            this.dessertGroupBox.Text = "Dessert";
            // 
            // dessertComboBox
            // 
            this.dessertComboBox.FormattingEnabled = true;
            this.dessertComboBox.Items.AddRange(new object[] {
            "Gulab Jamun",
            "Ice Cream",
            "Jam Roly Poly",
            "Treacle Tart"});
            this.dessertComboBox.Location = new System.Drawing.Point(15, 47);
            this.dessertComboBox.Name = "dessertComboBox";
            this.dessertComboBox.Size = new System.Drawing.Size(217, 24);
            this.dessertComboBox.TabIndex = 0;
            this.dessertComboBox.SelectedIndexChanged += new System.EventHandler(this.dessertSelection);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dessertGroupBox);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.totalGroupBox);
            this.Controls.Add(this.starterGroupBox);
            this.Name = "Form1";
            this.Text = "Posh Noshers Menu Selection";
            this.starterGroupBox.ResumeLayout(false);
            this.totalGroupBox.ResumeLayout(false);
            this.mainGroupBox.ResumeLayout(false);
            this.dessertGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox starterGroupBox;
        private System.Windows.Forms.ListBox starterListBox;
        private System.Windows.Forms.GroupBox totalGroupBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.ListBox mainListBox;
        private System.Windows.Forms.GroupBox dessertGroupBox;
        private System.Windows.Forms.ComboBox dessertComboBox;
    }
}

