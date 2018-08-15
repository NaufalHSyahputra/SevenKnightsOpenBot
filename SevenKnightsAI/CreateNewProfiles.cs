using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace SevenKnightsAI
{
    public partial class CreateNewProfiles : Form
    {
        public static readonly string FILE_EXT = ".json";
        public static readonly string PATH = "\\profiles";
        public static readonly string PARENT_PATH = @Environment.CurrentDirectory.ToString();
        public static readonly string fileName = "Default.json";
        public static readonly string sourcePath = PARENT_PATH +@"\profiles";
        public static readonly string destPath = PARENT_PATH + @"\profiles";
        public CreateNewProfiles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(destPath, textBox1.Text.ToString()+FILE_EXT);
            System.IO.File.Copy(sourceFile, destFile, true);
            MessageBox.Show("Create new Profiles Success, Please Restart Bot to use new profile.");
        }
    }
}
