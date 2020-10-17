using System;

namespace Thorr_File_Unpacker
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void metroTile1_Click(object sender, EventArgs e)
        {
            PM1 W1 = new PM1();
            W1.TopMost = true;
            W1.Show();

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            BF W2 = new BF();
            W2.TopMost = true;
            W2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BMD3(object sender, EventArgs e)
        {
            
                BMD W3 = new BMD();
                W3.TopMost = true;
                W3.Show();
            
        }
    }
}
