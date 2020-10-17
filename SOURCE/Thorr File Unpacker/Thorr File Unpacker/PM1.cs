using System;

namespace Thorr_File_Unpacker
{
    public partial class PM1 : MetroFramework.Forms.MetroForm
    {
        public PM1()
        {
            InitializeComponent();
        }

        private void ExportPM1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"FILEEXPORTPM1.bat");
        }

        private void ImportPM1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"FILEIMPORTPM1.bat");
        }
    }
}
