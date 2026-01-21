using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ABCsystem
{
    public partial class MainForm : Form
    {
        private static DockPanel _dockPanel;

        public MainForm()
        {
            InitializeComponent();

            _dockPanel = new DockPanel()
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(_dockPanel);

            _dockPanel.Location = new System.Drawing.Point(0, mainMenu.Height);
            _dockPanel.Size = new System.Drawing.Size(ClientSize.Width, ClientSize.Height - mainMenu.Height);
            _dockPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            mainMenu.BringToFront();

            _dockPanel.Theme = new VS2015BlueTheme();

            LoadDockingWindows();
        }

        private void LoadDockingWindows()
        {
            _dockPanel.AllowEndUserDocking = false;

            var cameraForm = new CameraForm();
            cameraForm.Show(_dockPanel, DockState.Document);

            var runForm = new RunForm();
            runForm.Show(cameraForm.Pane, DockAlignment.Bottom, 0.3);

            var resusltForm = new ResultForm();
            resusltForm.Show(runForm.Pane, DockAlignment.Right, 0.5);

            var propForm = new PropertiesForm();
            propForm.Show(_dockPanel, DockState.DockRight);

            var logForm = new LogForm();
            logForm.Show(propForm.Pane, DockAlignment.Bottom, 0.5);
        }

        public static T GetDockForm<T>() where T : DockContent
        {
            var findForm = _dockPanel.Contents.OfType<T>().FirstOrDefault();
            return findForm;
        }

        private void imageOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CameraForm cameraForm = GetDockForm<CameraForm>();

            if (cameraForm == null) return;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "이미지 파일 선택";
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    cameraForm.LoadImage(filePath);
                }
            }
        }
    }
}
