using System;

namespace Thorr_File_Unpacker
{
    public partial class BMD : MetroFramework.Forms.MetroForm
    {
        public BMD()
        {
            InitializeComponent();
        }

        private void BMDTOPTP(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"C:\FILEBMDTOPTP.bat");
            System.Diagnostics.Process.Start(@"FILEBMDTOPTP.bat");
        }

        private void PTPTOBMD(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"C:\FILEPTPTOBMD.bat");
            System.Diagnostics.Process.Start(@"FILEPTPTOBMD.bat");
        }
    }
}
