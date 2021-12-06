using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensitivityFinder
{
    public partial class FormTraining : Form
    {
        PointList targetPoints = new PointList(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, Settings.NumPoints, Settings.NumPerPoint);
        public FormTraining(Game gameType, double fov, double sensitivity, int numPoints, int numPerPoint)
        {
            InitializeComponent();
            MouseDownFilter mouseFilter = new MouseDownFilter(this);
            mouseFilter.FormClicked += mouseFilter_FormClicked;
            Application.AddMessageFilter(mouseFilter);
        }

        private void FormTraining_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.Bounds.Size;
        }

        private void FormTraining_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
        }

        void mouseFilter_FormClicked(object sender, EventArgs e)
        {
            Point Center = new Point(this.Width / 2, this.Height / 2);
            System.Windows.Forms.Cursor.Position = Center;

            targetPoints.NextOrRandomizeList();
            Point newLocation = targetPoints.GetCurrentPoint();
            targetBtn.Location = newLocation;
        }






        private class MouseDownFilter : IMessageFilter
        {
            public event EventHandler FormClicked;
            private int WM_LBUTTONDOWN = 0x201;
            private Form form = null;

            [DllImport("user32.dll")]
            public static extern bool IsChild(IntPtr hWndParent, IntPtr hWnd);

            public MouseDownFilter(Form f)
            {
                form = f;
            }

            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg == WM_LBUTTONDOWN)
                {
                    if (Form.ActiveForm != null && Form.ActiveForm.Equals(form))
                    {
                        OnFormClicked();
                    }
                }
                return false;
            }

            protected void OnFormClicked()
            {
                if (FormClicked != null)
                {
                    FormClicked(form, EventArgs.Empty);
                }
            }
        }
    }
}
