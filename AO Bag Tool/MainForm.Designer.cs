namespace AO_Bag_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if(disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LabelBagCoordinates = new System.Windows.Forms.Label();
            this.LabelInventoryCoordinates = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonSetBagCoordinates = new System.Windows.Forms.Button();
            this.ButtonSetInventoryCoordinates = new System.Windows.Forms.Button();
            this.ButtonTransferItems = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumericUpDownItemsInContainer = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownItemsInContainer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelBagCoordinates
            // 
            this.LabelBagCoordinates.AutoSize = true;
            this.LabelBagCoordinates.Location = new System.Drawing.Point(92, 63);
            this.LabelBagCoordinates.Name = "LabelBagCoordinates";
            this.LabelBagCoordinates.Size = new System.Drawing.Size(25, 13);
            this.LabelBagCoordinates.TabIndex = 3;
            this.LabelBagCoordinates.Text = "0, 0";
            // 
            // LabelInventoryCoordinates
            // 
            this.LabelInventoryCoordinates.AutoSize = true;
            this.LabelInventoryCoordinates.Location = new System.Drawing.Point(92, 92);
            this.LabelInventoryCoordinates.Name = "LabelInventoryCoordinates";
            this.LabelInventoryCoordinates.Size = new System.Drawing.Size(25, 13);
            this.LabelInventoryCoordinates.TabIndex = 4;
            this.LabelInventoryCoordinates.Text = "0, 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To Location";
            // 
            // ButtonSetBagCoordinates
            // 
            this.ButtonSetBagCoordinates.Location = new System.Drawing.Point(157, 58);
            this.ButtonSetBagCoordinates.Name = "ButtonSetBagCoordinates";
            this.ButtonSetBagCoordinates.Size = new System.Drawing.Size(75, 23);
            this.ButtonSetBagCoordinates.TabIndex = 7;
            this.ButtonSetBagCoordinates.Text = "Set";
            this.ButtonSetBagCoordinates.UseVisualStyleBackColor = true;
            this.ButtonSetBagCoordinates.Click += new System.EventHandler(this.ButtonSetBagCoordinates_Click);
            // 
            // ButtonSetInventoryCoordinates
            // 
            this.ButtonSetInventoryCoordinates.Location = new System.Drawing.Point(157, 87);
            this.ButtonSetInventoryCoordinates.Name = "ButtonSetInventoryCoordinates";
            this.ButtonSetInventoryCoordinates.Size = new System.Drawing.Size(75, 23);
            this.ButtonSetInventoryCoordinates.TabIndex = 8;
            this.ButtonSetInventoryCoordinates.Text = "Set";
            this.ButtonSetInventoryCoordinates.UseVisualStyleBackColor = true;
            this.ButtonSetInventoryCoordinates.Click += new System.EventHandler(this.ButtonSetInventoryCoordinates_Click);
            // 
            // ButtonTransferItems
            // 
            this.ButtonTransferItems.Location = new System.Drawing.Point(157, 116);
            this.ButtonTransferItems.Name = "ButtonTransferItems";
            this.ButtonTransferItems.Size = new System.Drawing.Size(75, 23);
            this.ButtonTransferItems.TabIndex = 9;
            this.ButtonTransferItems.Text = "Transfer";
            this.ButtonTransferItems.UseVisualStyleBackColor = true;
            this.ButtonTransferItems.Click += new System.EventHandler(this.ButtonTransferItems_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start Transfer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Items in Container";
            // 
            // NumericUpDownItemsInContainer
            // 
            this.NumericUpDownItemsInContainer.Location = new System.Drawing.Point(157, 32);
            this.NumericUpDownItemsInContainer.Name = "NumericUpDownItemsInContainer";
            this.NumericUpDownItemsInContainer.Size = new System.Drawing.Size(75, 20);
            this.NumericUpDownItemsInContainer.TabIndex = 12;
            this.NumericUpDownItemsInContainer.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(253, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.readMeToolStripMenuItem.Text = "How To Use This Program";
            this.readMeToolStripMenuItem.Click += new System.EventHandler(this.ReadMeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 149);
            this.Controls.Add(this.NumericUpDownItemsInContainer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonTransferItems);
            this.Controls.Add(this.ButtonSetInventoryCoordinates);
            this.Controls.Add(this.ButtonSetBagCoordinates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelInventoryCoordinates);
            this.Controls.Add(this.LabelBagCoordinates);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "AO Bag Tool";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownItemsInContainer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelBagCoordinates;
        private System.Windows.Forms.Label LabelInventoryCoordinates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonSetBagCoordinates;
        private System.Windows.Forms.Button ButtonSetInventoryCoordinates;
        private System.Windows.Forms.Button ButtonTransferItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumericUpDownItemsInContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

