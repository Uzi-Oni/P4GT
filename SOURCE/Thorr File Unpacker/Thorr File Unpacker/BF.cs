using System;

namespace Thorr_File_Unpacker
{
    public partial class BF : MetroFramework.Forms.MetroForm
    {
        public BF()
        {
            InitializeComponent();
        }

        private void metrobutton(object sender, EventArgs e)
        {
            PM1 W1 = new PM1();
            W1.TopMost = true;
            W1.Show();

        }

        private void ExportBF(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"FILEEXPORTBF.bat");
        }

        private void ImportBF(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"FILEIMPORTBF.bat");
        }
    }
}
