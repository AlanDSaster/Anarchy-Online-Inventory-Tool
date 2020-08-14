using System;
using System.Drawing;
using System.Windows.Forms;

namespace AO_Bag_Tool
{
    public partial class FormOverlay : Form {

        Label label_to_report_location;
        Point point_to_report_location;
        MainForm mainform;

        public FormOverlay( MainForm parent_form, Label output_label, Point point_clicked ) {

            InitializeComponent();
            mainform = parent_form;
            label_to_report_location = output_label;
            point_to_report_location = point_clicked;
            WindowState = FormWindowState.Maximized;

            GroupBoxMessage.Left = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 2) - (GroupBoxMessage.Width/2);
            GroupBoxMessage.Top = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height / 2) - (GroupBoxMessage.Height/2);
            LabelMessage.Left = (GroupBoxMessage.Width/2) - (LabelMessage.Width/2);            
            ButtonCancel.Left = ( GroupBoxMessage.Width / 2 ) - ( ButtonCancel.Width / 2 );
            
            this.Click += new System.EventHandler( this.Overlay_Click );

            this.ShowDialog();

        }
        
        private void Overlay_Click( object sender, EventArgs e ) {

            Point LocationClicked = new Point( MousePosition.X, MousePosition.Y );            
            label_to_report_location.Text = LocationClicked.X + ", " + LocationClicked.Y;

            this.Dispose();

        }

        private void FormOverlay_Load( object sender, EventArgs e ) {

        }

        private void ButtonCancel_Click( object sender, EventArgs e ) {
            this.Dispose();
        }
    }

}
