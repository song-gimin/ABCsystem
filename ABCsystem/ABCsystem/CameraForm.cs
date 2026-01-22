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
using ABCsystem.Util;
using WeifenLuo.WinFormsUI.Docking;

namespace ABCsystem
{
    public partial class CameraForm : DockContent
    {
        public CameraForm()
        {
            InitializeComponent();
        }

        public void LoadImage(string filePath)  //이미지 불러오기
        {
            if (File.Exists(filePath) == false) return;

            Image bitmap = Image.FromFile(filePath);
            imageViewer.LoadBitmap((Bitmap)bitmap);

            SLogger.Write($"이미지를 불러옴 {filePath}");
        }
    }
}
