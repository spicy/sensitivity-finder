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
        Collection collection = new Collection();
        PointList targetPoints = new PointList(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, Settings.NumPoints);
       
        public FormTraining(Game gameType, double fov, double sensitivity, int numPoints)
        {
            InitializeComponent();
            MouseDownFilter mouseFilter = new MouseDownFilter(this);
            mouseFilter.FormClicked += MouseFilter_FormClicked;
            Application.AddMessageFilter(mouseFilter);

            Application.AddMessageFilter(new MouseMessageFilter());
            MouseMessageFilter.MouseMove += new MouseEventHandler(OnGlobalMouseMove);
        }

        private void FormTraining_Load(object sender, EventArgs e)
        {
            Settings.PointWidth = targetBtn.Size.Width;
            this.Size = Screen.PrimaryScreen.Bounds.Size;
            ToNextPoint();

            Cursor.Hide();
            mousePanel.BringToFront();
            Point Center = new Point(this.Width / 2, this.Height / 2);
            System.Windows.Forms.Cursor.Position = Center;
        }

        private void FormTraining_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
            if (e.KeyCode == Keys.Space)
            {
                //leftDiffLbl.Text = Convert.ToString(collection.GetAvgDiff(ScreenSide.LEFT));
                //deviationLbl.Text = Convert.ToString(collection.GetStandardDeviation());
                //collection.GetAvgDiff(point);
                //targetPoints.GetPoint()
            }
        }

        private void ToNextPoint()
        {
            targetPoints.NextOrRandomizeList();
            Point newLocation = targetPoints.GetCurrentPoint();
            targetBtn.Location = newLocation;
        }

        void MouseFilter_FormClicked(object sender, EventArgs e)
        {
            ClickData curData = new ClickData(targetPoints.GetCurrentPoint(), System.Windows.Forms.Cursor.Position);
            collection.clickDataList.Add(curData);

            missTypeLbl.Text = curData.missType.ToString();
            countLbl.Text = collection.clickDataList.Count.ToString();

            // Move to the next point, or randomize the list for an endless cycle
            targetPoints.NextOrRandomizeList();

            Point Center = new Point(this.Width / 2, this.Height / 2);
            System.Windows.Forms.Cursor.Position = Center;
            ToNextPoint();
        }

        void OnGlobalMouseMove(object sender, MouseEventArgs e)
        {
            mousePanel.Location = e.Location;
        }

        private class MouseMessageFilter : IMessageFilter
        {
            public static event MouseEventHandler MouseMove = delegate { };
            const int WM_MOUSEMOVE = 0x0200;

            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg == WM_MOUSEMOVE)
                { 
                    Point mousePosition = Control.MousePosition;
                    MouseMove(null, new MouseEventArgs(MouseButtons.None, 0, mousePosition.X, mousePosition.Y, 0));
                }
                return false;
            }
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
