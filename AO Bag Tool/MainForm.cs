using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AO_Bag_Tool {

    public partial class MainForm : Form {

        public Point BagFirstSquare;
        public Point InventoryFirstSquare;
        public int NumberOfItemsInBag;

        public MainForm() {

            InitializeComponent();

        }

        //Functions and Subroutines
        //This is a replacement for Cursor.Position in WinForms
        //this section taken from https://stackoverflow.com/questions/8272681/how-can-i-simulate-a-mouse-click-at-a-certain-position-on-the-screen

        [System.Runtime.InteropServices.DllImport( "user32.dll" )]
        static extern bool SetCursorPos( int x, int y );

        [System.Runtime.InteropServices.DllImport( "user32.dll" )]
        public static extern void mouse_event( int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo );

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        public static void LeftMouseClick( int xpos, int ypos ) {
            SetCursorPos( xpos, ypos );
            mouse_event( MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0 );
            mouse_event( MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0 );
        }


        //ELEMENT HANDLERS

        private void ButtonSetBagCoordinates_Click( object sender, EventArgs e ) {
            //set bag location

            FormOverlay overlay = new FormOverlay( this, LabelBagCoordinates, BagFirstSquare );
            
        }

        private void ButtonSetInventoryCoordinates_Click( object sender, EventArgs e ) {
            //set inventory location

            FormOverlay overlay = new FormOverlay( this, LabelInventoryCoordinates, InventoryFirstSquare );

        }

        private void ButtonTransferItems_Click( object sender, EventArgs e ) {

            int NumberOfItemsInBag = (int) NumericUpDownItemsInContainer.Value;

            BagFirstSquare = StringToPoint( LabelBagCoordinates.Text );
            InventoryFirstSquare = StringToPoint( LabelInventoryCoordinates.Text );

            for(int i = 0; i < NumberOfItemsInBag; i++) {

                System.Threading.Thread.Sleep( 250 );

                ClickOnLocation( BagFirstSquare );
                Console.WriteLine( "Clicking on location: " + BagFirstSquare.ToString() );
                System.Threading.Thread.Sleep( 250 );

                ClickOnLocation( InventoryFirstSquare );
                Console.WriteLine( "Clicking on location: " + InventoryFirstSquare.ToString() );
                System.Threading.Thread.Sleep( 250 );

            }

        }

        private Point StringToPoint( string coordinates ) {

            int x;
            int y;

            string s;
            int index_of_comma;


            index_of_comma = coordinates.IndexOf( "," );
            s = coordinates.Substring( 0, index_of_comma );
            x = Convert.ToInt32(s);

            s = coordinates.Substring( index_of_comma + 2 );
            y = Convert.ToInt32( s );

            return new Point( x, y );

        }

        private void ClickOnLocation(Point LocationToClick) {

            LeftMouseClick( LocationToClick.X, LocationToClick.Y );

        }

        private void AboutToolStripMenuItem_Click( object sender, EventArgs e ) {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void CloseToolStripMenuItem_Click( object sender, EventArgs e ) {
            this.Dispose();
        }

        private void ReadMeToolStripMenuItem_Click( object sender, EventArgs e ) {

            Form1 help_howto = new Form1();
            help_howto.ShowDialog();

        }

        private void MainForm_Load( object sender, EventArgs e ) {
            
        }
    }

}
