using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            buttonbProcessImages.Enabled = false;
            cbLogoLocation.SelectedIndex = 1;
        }

        private void buttonbProcessImages_Click(object sender, EventArgs e)
        {
            string[] files = null;


            string sSelectedFolderLocationRestoreOriginal = folderBrowserDialog1.SelectedPath + @"\_OriginalBackup";

            MoveAllFiles(folderBrowserDialog1.SelectedPath, sSelectedFolderLocationRestoreOriginal, false);



            files = System.IO.Directory.GetFiles(sSelectedFolderLocationRestoreOriginal);

            

            foreach (string file in files)
            {
                Bitmap tempBmp = new Bitmap(file);
                ExifRotate(tempBmp);
                Bitmap bmp = new Bitmap(tempBmp, 700, 1057);
                ExifRotate(bmp);


                Bitmap src = Image.FromFile(@"C:\imgResizeProj\logo\logo1.jpg") as Bitmap;

                using (Graphics g = Graphics.FromImage(bmp))
                 {

                    int x = 0;
                    int y = 0;

                    if ( cbLogoLocation.SelectedIndex == 1)
                    { x = 550;y = 1000; }
                    if (cbLogoLocation.SelectedIndex == 2)
                    { x = 50; y = 1000; }
                    if (cbLogoLocation.SelectedIndex == 3)
                    { x = 550; y = 50; }
                    if (cbLogoLocation.SelectedIndex == 4)
                    { x = 50; y = 1000; }
                    g.DrawImage(src,
                     new Point(x, y));
                     src.Dispose();
                     g.Dispose();
                 }
                 


                bmp.Save(folderBrowserDialog1.SelectedPath + @"/" + Path.GetFileName(file) + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            }
        }
        public void ExifRotate( Image img)
        {
            int exifOrientationID = 0x112; //274
            if (!img.PropertyIdList.Contains(exifOrientationID))
                return;

            var prop = img.GetPropertyItem(exifOrientationID);
            int val = BitConverter.ToUInt16(prop.Value, 0);
            var rot = RotateFlipType.RotateNoneFlipNone;

            if (val == 3 || val == 4)
                rot = RotateFlipType.Rotate180FlipNone;
            else if (val == 5 || val == 6)
                rot = RotateFlipType.Rotate90FlipNone;
            else if (val == 7 || val == 8)
                rot = RotateFlipType.Rotate270FlipNone;

            if (val == 2 || val == 4 || val == 5 || val == 7)
                rot |= RotateFlipType.RotateNoneFlipX;

            if (rot != RotateFlipType.RotateNoneFlipNone)
                img.RotateFlip(rot);
        }

        private void bChooseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolderLoc.Text = folderBrowserDialog1.SelectedPath;
                if ( txtFolderLoc.Text.ToString().Length > 0)
                {
                    buttonbProcessImages.Enabled = true;
                }
                else
                {
                    buttonbProcessImages.Enabled = false;

                }
            }
        }
        private static void MoveAllFiles(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            //var localPath = (new Uri(sourceDirName)).AbsolutePath;


            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.MoveTo(temppath);
            }


        }
    }
}
