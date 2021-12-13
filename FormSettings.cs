using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensitivityFinder
{
    public partial class FormSettings : Form
    {
        #region MoveForm
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private List<Game> gameList = new List<Game>()
        {
            new Game("Other", 0),
            new Game("Valorant", 103.0f),
            new Game("CSGO", 100.0f),
        };

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            gameDropdown.DataSource = gameList;
            gameDropdown.DisplayMember = "Name";
            gameDropdown.ValueMember = "Fov";
        }

        #region Buttons
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (Settings.Sensitivity > 0 && Settings.Sensitivity < 100)
            {
                if (Settings.Fov > 0 && Settings.Fov < 200)
                {
                    FormTraining newForm = new FormTraining(Settings.Game, Settings.Fov, Settings.Sensitivity, Settings.NumPoints, Settings.NumPerPoint);
                    this.Hide();
                    newForm.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Make sure the FOV is valid!");
            }
            else MessageBox.Show("Make sure the Sensitivity is valid!");
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        #region DropDowns
        private void gameDropdown_DropDownClosed(object sender, EventArgs e)
        {
            foreach (Game game in gameList)
            {
                if (gameDropdown.SelectedItem.Equals(game))
                {
                    Settings.Game = game;
                    Settings.Fov = game.fov;

                    fovTxt.Text = Settings.Fov.ToString();
                }
            }
        }
        #endregion

        #region Sliders
        private void numPointsSlider_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            numPointsLbl.Text = numPointsSlider.Value.ToString();
        }

        private void numPerPointSlider_ValueChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            numPerPointLbl.Text = numPerPointSlider.Value.ToString();
        }

        private void numPointsSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            Settings.NumPoints = numPointsSlider.Value;
        }
        private void numPointsSlider_Load(object sender, EventArgs e)
        {
            numPointsLbl.Text = numPointsSlider.Value.ToString();
            Settings.NumPoints = numPointsSlider.Value;
        }

        private void numPerPointSlider_Load(object sender, EventArgs e)
        {
            numPerPointLbl.Text = numPerPointSlider.Value.ToString();
            Settings.NumPerPoint = numPerPointSlider.Value;
        }

        private void numPerPointSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            Settings.NumPerPoint = numPerPointSlider.Value;
        }
        #endregion

        #region Textboxes
        private void fovTxt_TextChange(object sender, EventArgs e)
        {
            if (!Double.TryParse(fovTxt.Text, out Settings.Fov))
            {
                MessageBox.Show("Numbers only!");
                fovTxt.Text = "";
            }
        }

        private void sensitivityTxt_TextChange(object sender, EventArgs e)
        {
            if (!Double.TryParse(sensitivityTxt.Text, out Settings.Sensitivity))
            {
                MessageBox.Show("Numbers only!");
                sensitivityTxt.Text = "";
            }
        }
        #endregion

        private void FormSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
