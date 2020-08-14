namespace AO_Bag_Tool
{
    partial class FormOverlay
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
            this.GroupBoxMessage = new System.Windows.Forms.GroupBox();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.GroupBoxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxMessage
            // 
            this.GroupBoxMessage.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBoxMessage.Controls.Add(this.ButtonCancel);
            this.GroupBoxMessage.Controls.Add(this.LabelMessage);
            this.GroupBoxMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBoxMessage.Location = new System.Drawing.Point(247, 141);
            this.GroupBoxMessage.Name = "GroupBoxMessage";
            this.GroupBoxMessage.Size = new System.Drawing.Size(213, 96);
            this.GroupBoxMessage.TabIndex = 0;
            this.GroupBoxMessage.TabStop = false;
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Location = new System.Drawing.Point(58, 42);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(105, 13);
            this.LabelMessage.TabIndex = 0;
            this.LabelMessage.Text = "Click to Set Location";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(76, 67);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOverlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Navy;
            this.Load += new System.EventHandler(this.FormOverlay_Load);
            this.GroupBoxMessage.ResumeLayout(false);
            this.GroupBoxMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxMessage;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Button ButtonCancel;
    }
}