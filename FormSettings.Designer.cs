
namespace SensitivityFinder
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.topPanel = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.authorLbl = new System.Windows.Forms.Label();
            this.playerSettingsLbl = new System.Windows.Forms.Label();
            this.sensitivityLbl = new System.Windows.Forms.Label();
            this.gameSettingsPanel = new System.Windows.Forms.Panel();
            this.gameLbl = new System.Windows.Forms.Label();
            this.fovTxt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.gameDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.fovLbl = new System.Windows.Forms.Label();
            this.gameSettingsLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numPerPointTextLbl = new System.Windows.Forms.Label();
            this.numPointsTextLbl = new System.Windows.Forms.Label();
            this.numPerPointSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.numPerPointLbl = new System.Windows.Forms.Label();
            this.numPointsSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.numPointsLbl = new System.Windows.Forms.Label();
            this.trainingSettings = new System.Windows.Forms.Label();
            this.startBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.sensitivityTxt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.playerSettingsPanel = new System.Windows.Forms.Panel();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topPanel.SuspendLayout();
            this.panel11.SuspendLayout();
            this.gameSettingsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.playerSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.topPanel.Controls.Add(this.titleLbl);
            this.topPanel.Controls.Add(this.lblExit);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(860, 30);
            this.topPanel.TabIndex = 92;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Corbel", 14F);
            this.titleLbl.ForeColor = System.Drawing.Color.Silver;
            this.titleLbl.Location = new System.Drawing.Point(11, 4);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(193, 23);
            this.titleLbl.TabIndex = 50;
            this.titleLbl.Text = "spicy\'s sensitivity finder";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(105)))), ((int)(((byte)(120)))));
            this.lblExit.Location = new System.Drawing.Point(836, 3);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(20, 22);
            this.lblExit.TabIndex = 58;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.panel11.Controls.Add(this.authorLbl);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 590);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(860, 30);
            this.panel11.TabIndex = 93;
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorLbl.Font = new System.Drawing.Font("Corbel", 10.25F);
            this.authorLbl.ForeColor = System.Drawing.Color.Silver;
            this.authorLbl.Location = new System.Drawing.Point(716, 5);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(140, 17);
            this.authorLbl.TabIndex = 89;
            this.authorLbl.Text = "Made by Daniel Currey";
            // 
            // playerSettingsLbl
            // 
            this.playerSettingsLbl.AutoSize = true;
            this.playerSettingsLbl.Font = new System.Drawing.Font("Corbel", 15F);
            this.playerSettingsLbl.ForeColor = System.Drawing.Color.Silver;
            this.playerSettingsLbl.Location = new System.Drawing.Point(15, 14);
            this.playerSettingsLbl.Name = "playerSettingsLbl";
            this.playerSettingsLbl.Size = new System.Drawing.Size(137, 24);
            this.playerSettingsLbl.TabIndex = 94;
            this.playerSettingsLbl.Text = "Player Settings";
            // 
            // sensitivityLbl
            // 
            this.sensitivityLbl.AutoSize = true;
            this.sensitivityLbl.Font = new System.Drawing.Font("Corbel", 10.25F);
            this.sensitivityLbl.ForeColor = System.Drawing.Color.Silver;
            this.sensitivityLbl.Location = new System.Drawing.Point(16, 45);
            this.sensitivityLbl.Name = "sensitivityLbl";
            this.sensitivityLbl.Size = new System.Drawing.Size(68, 17);
            this.sensitivityLbl.TabIndex = 96;
            this.sensitivityLbl.Text = "Sensitivity";
            // 
            // gameSettingsPanel
            // 
            this.gameSettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.gameSettingsPanel.Controls.Add(this.gameLbl);
            this.gameSettingsPanel.Controls.Add(this.fovTxt);
            this.gameSettingsPanel.Controls.Add(this.gameDropdown);
            this.gameSettingsPanel.Controls.Add(this.fovLbl);
            this.gameSettingsPanel.Controls.Add(this.gameSettingsLbl);
            this.gameSettingsPanel.Location = new System.Drawing.Point(18, 49);
            this.gameSettingsPanel.Name = "gameSettingsPanel";
            this.gameSettingsPanel.Size = new System.Drawing.Size(264, 470);
            this.gameSettingsPanel.TabIndex = 97;
            // 
            // gameLbl
            // 
            this.gameLbl.AutoSize = true;
            this.gameLbl.Font = new System.Drawing.Font("Corbel", 10.25F);
            this.gameLbl.ForeColor = System.Drawing.Color.Silver;
            this.gameLbl.Location = new System.Drawing.Point(16, 45);
            this.gameLbl.Name = "gameLbl";
            this.gameLbl.Size = new System.Drawing.Size(43, 17);
            this.gameLbl.TabIndex = 100;
            this.gameLbl.Text = "Game";
            // 
            // fovTxt
            // 
            this.fovTxt.AcceptsReturn = false;
            this.fovTxt.AcceptsTab = false;
            this.fovTxt.AnimationSpeed = 200;
            this.fovTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.fovTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.fovTxt.AutoSizeHeight = true;
            this.fovTxt.BackColor = System.Drawing.Color.Transparent;
            this.fovTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fovTxt.BackgroundImage")));
            this.fovTxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.fovTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.fovTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.fovTxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.fovTxt.BorderRadius = 1;
            this.fovTxt.BorderThickness = 1;
            this.fovTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fovTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fovTxt.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.fovTxt.DefaultText = "";
            this.fovTxt.FillColor = System.Drawing.Color.White;
            this.fovTxt.HideSelection = true;
            this.fovTxt.IconLeft = null;
            this.fovTxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.fovTxt.IconPadding = 10;
            this.fovTxt.IconRight = null;
            this.fovTxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.fovTxt.Lines = new string[0];
            this.fovTxt.Location = new System.Drawing.Point(19, 127);
            this.fovTxt.MaxLength = 32767;
            this.fovTxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.fovTxt.Modified = false;
            this.fovTxt.Multiline = false;
            this.fovTxt.Name = "fovTxt";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.fovTxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.fovTxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.fovTxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.fovTxt.OnIdleState = stateProperties4;
            this.fovTxt.Padding = new System.Windows.Forms.Padding(3);
            this.fovTxt.PasswordChar = '\0';
            this.fovTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.fovTxt.PlaceholderText = "Enter text";
            this.fovTxt.ReadOnly = false;
            this.fovTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fovTxt.SelectedText = "";
            this.fovTxt.SelectionLength = 0;
            this.fovTxt.SelectionStart = 0;
            this.fovTxt.ShortcutsEnabled = true;
            this.fovTxt.Size = new System.Drawing.Size(225, 39);
            this.fovTxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.fovTxt.TabIndex = 98;
            this.fovTxt.Tag = "";
            this.fovTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fovTxt.TextMarginBottom = 0;
            this.fovTxt.TextMarginLeft = 3;
            this.fovTxt.TextMarginTop = 1;
            this.fovTxt.TextPlaceholder = "Enter text";
            this.fovTxt.UseSystemPasswordChar = false;
            this.fovTxt.WordWrap = true;
            this.fovTxt.TextChange += new System.EventHandler(this.fovTxt_TextChange);
            // 
            // gameDropdown
            // 
            this.gameDropdown.BackColor = System.Drawing.Color.Transparent;
            this.gameDropdown.BackgroundColor = System.Drawing.Color.White;
            this.gameDropdown.BorderColor = System.Drawing.Color.Silver;
            this.gameDropdown.BorderRadius = 1;
            this.gameDropdown.Color = System.Drawing.Color.Silver;
            this.gameDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.gameDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gameDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.gameDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gameDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gameDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.gameDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gameDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.gameDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.gameDropdown.FillDropDown = true;
            this.gameDropdown.FillIndicator = false;
            this.gameDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameDropdown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gameDropdown.ForeColor = System.Drawing.Color.Black;
            this.gameDropdown.FormattingEnabled = true;
            this.gameDropdown.Icon = null;
            this.gameDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.gameDropdown.IndicatorColor = System.Drawing.Color.DarkGray;
            this.gameDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.gameDropdown.IndicatorThickness = 2;
            this.gameDropdown.IsDropdownOpened = false;
            this.gameDropdown.ItemBackColor = System.Drawing.Color.White;
            this.gameDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.gameDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.gameDropdown.ItemHeight = 26;
            this.gameDropdown.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.gameDropdown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.gameDropdown.ItemTopMargin = 3;
            this.gameDropdown.Location = new System.Drawing.Point(19, 65);
            this.gameDropdown.Name = "gameDropdown";
            this.gameDropdown.Size = new System.Drawing.Size(225, 32);
            this.gameDropdown.TabIndex = 99;
            this.gameDropdown.Text = null;
            this.gameDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.gameDropdown.TextLeftMargin = 5;
            this.gameDropdown.DropDownClosed += new System.EventHandler(this.gameDropdown_DropDownClosed);
            // 
            // fovLbl
            // 
            this.fovLbl.AutoSize = true;
            this.fovLbl.Font = new System.Drawing.Font("Corbel", 10.25F);
            this.fovLbl.ForeColor = System.Drawing.Color.Silver;
            this.fovLbl.Location = new System.Drawing.Point(16, 107);
            this.fovLbl.Name = "fovLbl";
            this.fovLbl.Size = new System.Drawing.Size(79, 17);
            this.fovLbl.TabIndex = 97;
            this.fovLbl.Text = "Field of view";
            // 
            // gameSettingsLbl
            // 
            this.gameSettingsLbl.AutoSize = true;
            this.gameSettingsLbl.Font = new System.Drawing.Font("Corbel", 15F);
            this.gameSettingsLbl.ForeColor = System.Drawing.Color.Silver;
            this.gameSettingsLbl.Location = new System.Drawing.Point(15, 14);
            this.gameSettingsLbl.Name = "gameSettingsLbl";
            this.gameSettingsLbl.Size = new System.Drawing.Size(134, 24);
            this.gameSettingsLbl.TabIndex = 94;
            this.gameSettingsLbl.Text = "Game Settings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.panel2.Controls.Add(this.numPerPointTextLbl);
            this.panel2.Controls.Add(this.numPointsTextLbl);
            this.panel2.Controls.Add(this.numPerPointSlider);
            this.panel2.Controls.Add(this.numPerPointLbl);
            this.panel2.Controls.Add(this.numPointsSlider);
            this.panel2.Controls.Add(this.numPointsLbl);
            this.panel2.Controls.Add(this.trainingSettings);
            this.panel2.Location = new System.Drawing.Point(577, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 470);
            this.panel2.TabIndex = 98;
            // 
            // numPerPointTextLbl
            // 
            this.numPerPointTextLbl.AutoSize = true;
            this.numPerPointTextLbl.Font = new System.Drawing.Font("Corbel", 10.25F);
            this.numPerPointTextLbl.ForeColor = System.Drawing.Color.Silver;
            this.numPerPointTextLbl.Location = new System.Drawing.Point(16, 107);
            this.numPerPointTextLbl.Name = "numPerPointTextLbl";
            this.numPerPointTextLbl.Size = new System.Drawing.Size(113, 17);
            this.numPerPointTextLbl.TabIndex = 102;
            this.numPerPointTextLbl.Text = "Amount per point:";
            // 
            // numPointsTextLbl
            // 
            this.numPointsTextLbl.AutoSize = true;
            this.numPointsTextLbl.Font = new System.Drawing.Font("Corbel", 10.25F);
            this.numPointsTextLbl.ForeColor = System.Drawing.Color.Silver;
            this.numPointsTextLbl.Location = new System.Drawing.Point(16, 45);
            this.numPointsTextLbl.Name = "numPointsTextLbl";
            this.numPointsTextLbl.Size = new System.Drawing.Size(113, 17);
            this.numPointsTextLbl.TabIndex = 101;
            this.numPointsTextLbl.Text = "Number of points:";
            // 
            // numPerPointSlider
            // 
            this.numPerPointSlider.AllowCursorChanges = true;
            this.numPerPointSlider.AllowHomeEndKeysDetection = false;
            this.numPerPointSlider.AllowIncrementalClickMoves = true;
            this.numPerPointSlider.AllowMouseDownEffects = false;
            this.numPerPointSlider.AllowMouseHoverEffects = false;
            this.numPerPointSlider.AllowScrollingAnimations = true;
            this.numPerPointSlider.AllowScrollKeysDetection = true;
            this.numPerPointSlider.AllowScrollOptionsMenu = true;
            this.numPerPointSlider.AllowShrinkingOnFocusLost = false;
            this.numPerPointSlider.BackColor = System.Drawing.Color.Transparent;
            this.numPerPointSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("numPerPointSlider.BackgroundImage")));
            this.numPerPointSlider.BindingContainer = null;
            this.numPerPointSlider.BorderRadius = 2;
            this.numPerPointSlider.BorderThickness = 1;
            this.numPerPointSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numPerPointSlider.DrawThickBorder = false;
            this.numPerPointSlider.DurationBeforeShrink = 2000;
            this.numPerPointSlider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.numPerPointSlider.LargeChange = 5;
            this.numPerPointSlider.Location = new System.Drawing.Point(19, 127);
            this.numPerPointSlider.Maximum = 20;
            this.numPerPointSlider.Minimum = 0;
            this.numPerPointSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.numPerPointSlider.MinimumThumbLength = 18;
            this.numPerPointSlider.Name = "numPerPointSlider";
            this.numPerPointSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.numPerPointSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.numPerPointSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.numPerPointSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.numPerPointSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.numPerPointSlider.ShrinkSizeLimit = 3;
            this.numPerPointSlider.Size = new System.Drawing.Size(225, 31);
            this.numPerPointSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.numPerPointSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.numPerPointSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.numPerPointSlider.SmallChange = 1;
            this.numPerPointSlider.TabIndex = 100;
            this.numPerPointSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.numPerPointSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.numPerPointSlider.ThumbLength = 53;
            this.numPerPointSlider.ThumbMargin = 1;
            this.numPerPointSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.numPerPointSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.numPerPointSlider.Value = 3;
            this.numPerPointSlider.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs>(this.numPerPointSlider_ValueChanged);
            this.numPerPointSlider.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.numPerPointSlider_Scroll);
            this.numPerPointSlider.Load += new System.EventHandler(this.numPerPointSlider_Load);
            // 
            // numPerPointLbl
            // 
            this.numPerPointLbl.AutoSize = true;
            this.numPerPointLbl.Font = new System.Drawing.Font("Corbel", 10.25F);
            this.numPerPointLbl.ForeColor = System.Drawing.Color.Silver;
            this.numPerPointLbl.Location = new System.Drawing.Point(131, 107);
            this.numPerPointLbl.Name = "numPerPointLbl";
            this.numPerPointLbl.Size = new System.Drawing.Size(15, 17);
            this.numPerPointLbl.TabIndex = 99;
            this.numPerPointLbl.Text = "0";
            // 
            // numPointsSlider
            // 
            this.numPointsSlider.AllowCursorChanges = true;
            this.numPointsSlider.AllowHomeEndKeysDetection = false;
            this.numPointsSlider.AllowIncrementalClickMoves = true;
            this.numPointsSlider.AllowMouseDownEffects = false;
            this.numPointsSlider.AllowMouseHoverEffects = false;
            this.numPointsSlider.AllowScrollingAnimations = true;
            this.numPointsSlider.AllowScrollKeysDetection = true;
            this.numPointsSlider.AllowScrollOptionsMenu = true;
            this.numPointsSlider.AllowShrinkingOnFocusLost = false;
            this.numPointsSlider.BackColor = System.Drawing.Color.Transparent;
            this.numPointsSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("numPointsSlider.BackgroundImage")));
            this.numPointsSlider.BindingContainer = null;
            this.numPointsSlider.BorderRadius = 2;
            this.numPointsSlider.BorderThickness = 1;
            this.numPointsSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numPointsSlider.DrawThickBorder = false;
            this.numPointsSlider.DurationBeforeShrink = 2000;
            this.numPointsSlider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.numPointsSlider.LargeChange = 5;
            this.numPointsSlider.Location = new System.Drawing.Point(19, 65);
            this.numPointsSlider.Maximum = 20;
            this.numPointsSlider.Minimum = 0;
            this.numPointsSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.numPointsSlider.MinimumThumbLength = 18;
            this.numPointsSlider.Name = "numPointsSlider";
            this.numPointsSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.numPointsSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.numPointsSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.numPointsSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.numPointsSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.numPointsSlider.ShrinkSizeLimit = 3;
            this.numPointsSlider.Size = new System.Drawing.Size(225, 31);
            this.numPointsSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.numPointsSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.numPointsSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.numPointsSlider.SmallChange = 1;
            this.numPointsSlider.TabIndex = 98;
            this.numPointsSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.numPointsSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.numPointsSlider.ThumbLength = 53;
            this.numPointsSlider.ThumbMargin = 1;
            this.numPointsSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.numPointsSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.numPointsSlider.Value = 6;
            this.numPointsSlider.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs>(this.numPointsSlider_ValueChanged);
            this.numPointsSlider.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.numPointsSlider_Scroll);
            this.numPointsSlider.Load += new System.EventHandler(this.numPointsSlider_Load);
            // 
            // numPointsLbl
            // 
            this.numPointsLbl.AutoSize = true;
            this.numPointsLbl.Font = new System.Drawing.Font("Corbel", 10.25F);
            this.numPointsLbl.ForeColor = System.Drawing.Color.Silver;
            this.numPointsLbl.Location = new System.Drawing.Point(131, 45);
            this.numPointsLbl.Name = "numPointsLbl";
            this.numPointsLbl.Size = new System.Drawing.Size(15, 17);
            this.numPointsLbl.TabIndex = 96;
            this.numPointsLbl.Text = "0";
            // 
            // trainingSettings
            // 
            this.trainingSettings.AutoSize = true;
            this.trainingSettings.Font = new System.Drawing.Font("Corbel", 15F);
            this.trainingSettings.ForeColor = System.Drawing.Color.Silver;
            this.trainingSettings.Location = new System.Drawing.Point(15, 14);
            this.trainingSettings.Name = "trainingSettings";
            this.trainingSettings.Size = new System.Drawing.Size(154, 24);
            this.trainingSettings.TabIndex = 94;
            this.trainingSettings.Text = "Training Settings";
            // 
            // startBtn
            // 
            this.startBtn.AllowAnimations = true;
            this.startBtn.AllowMouseEffects = true;
            this.startBtn.AllowToggling = false;
            this.startBtn.AnimationSpeed = 200;
            this.startBtn.AutoGenerateColors = false;
            this.startBtn.AutoRoundBorders = false;
            this.startBtn.AutoSizeLeftIcon = true;
            this.startBtn.AutoSizeRightIcon = true;
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.startBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startBtn.BackgroundImage")));
            this.startBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startBtn.ButtonText = "Start";
            this.startBtn.ButtonTextMarginLeft = 0;
            this.startBtn.ColorContrastOnClick = 45;
            this.startBtn.ColorContrastOnHover = 45;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.startBtn.CustomizableEdges = borderEdges1;
            this.startBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.startBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.startBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.startBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.IconLeft = null;
            this.startBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.startBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.startBtn.IconMarginLeft = 11;
            this.startBtn.IconPadding = 10;
            this.startBtn.IconRight = null;
            this.startBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.startBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.startBtn.IconSize = 25;
            this.startBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.startBtn.IdleBorderRadius = 0;
            this.startBtn.IdleBorderThickness = 0;
            this.startBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.startBtn.IdleIconLeftImage = null;
            this.startBtn.IdleIconRightImage = null;
            this.startBtn.IndicateFocus = false;
            this.startBtn.Location = new System.Drawing.Point(18, 534);
            this.startBtn.Name = "startBtn";
            this.startBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.startBtn.OnDisabledState.BorderRadius = 1;
            this.startBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startBtn.OnDisabledState.BorderThickness = 1;
            this.startBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.startBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.startBtn.OnDisabledState.IconLeftImage = null;
            this.startBtn.OnDisabledState.IconRightImage = null;
            this.startBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.startBtn.onHoverState.BorderRadius = 1;
            this.startBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startBtn.onHoverState.BorderThickness = 1;
            this.startBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.startBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.startBtn.onHoverState.IconLeftImage = null;
            this.startBtn.onHoverState.IconRightImage = null;
            this.startBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.startBtn.OnIdleState.BorderRadius = 1;
            this.startBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startBtn.OnIdleState.BorderThickness = 1;
            this.startBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.startBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.startBtn.OnIdleState.IconLeftImage = null;
            this.startBtn.OnIdleState.IconRightImage = null;
            this.startBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.startBtn.OnPressedState.BorderRadius = 1;
            this.startBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startBtn.OnPressedState.BorderThickness = 1;
            this.startBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.startBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.startBtn.OnPressedState.IconLeftImage = null;
            this.startBtn.OnPressedState.IconRightImage = null;
            this.startBtn.Size = new System.Drawing.Size(186, 39);
            this.startBtn.TabIndex = 99;
            this.startBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.startBtn.TextMarginLeft = 0;
            this.startBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.startBtn.UseDefaultRadiusAndThickness = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // sensitivityTxt
            // 
            this.sensitivityTxt.AcceptsReturn = false;
            this.sensitivityTxt.AcceptsTab = false;
            this.sensitivityTxt.AnimationSpeed = 200;
            this.sensitivityTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.sensitivityTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.sensitivityTxt.AutoSizeHeight = true;
            this.sensitivityTxt.BackColor = System.Drawing.Color.Transparent;
            this.sensitivityTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sensitivityTxt.BackgroundImage")));
            this.sensitivityTxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.sensitivityTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sensitivityTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.sensitivityTxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.sensitivityTxt.BorderRadius = 1;
            this.sensitivityTxt.BorderThickness = 1;
            this.sensitivityTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.sensitivityTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sensitivityTxt.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.sensitivityTxt.DefaultText = "";
            this.sensitivityTxt.FillColor = System.Drawing.Color.White;
            this.sensitivityTxt.HideSelection = true;
            this.sensitivityTxt.IconLeft = null;
            this.sensitivityTxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.sensitivityTxt.IconPadding = 10;
            this.sensitivityTxt.IconRight = null;
            this.sensitivityTxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.sensitivityTxt.Lines = new string[0];
            this.sensitivityTxt.Location = new System.Drawing.Point(19, 65);
            this.sensitivityTxt.MaxLength = 32767;
            this.sensitivityTxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.sensitivityTxt.Modified = false;
            this.sensitivityTxt.Multiline = false;
            this.sensitivityTxt.Name = "sensitivityTxt";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sensitivityTxt.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.sensitivityTxt.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sensitivityTxt.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sensitivityTxt.OnIdleState = stateProperties8;
            this.sensitivityTxt.Padding = new System.Windows.Forms.Padding(3);
            this.sensitivityTxt.PasswordChar = '\0';
            this.sensitivityTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.sensitivityTxt.PlaceholderText = "Enter text";
            this.sensitivityTxt.ReadOnly = false;
            this.sensitivityTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sensitivityTxt.SelectedText = "";
            this.sensitivityTxt.SelectionLength = 0;
            this.sensitivityTxt.SelectionStart = 0;
            this.sensitivityTxt.ShortcutsEnabled = true;
            this.sensitivityTxt.Size = new System.Drawing.Size(225, 39);
            this.sensitivityTxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.sensitivityTxt.TabIndex = 99;
            this.sensitivityTxt.Tag = "";
            this.sensitivityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sensitivityTxt.TextMarginBottom = 0;
            this.sensitivityTxt.TextMarginLeft = 3;
            this.sensitivityTxt.TextMarginTop = 1;
            this.sensitivityTxt.TextPlaceholder = "Enter text";
            this.sensitivityTxt.UseSystemPasswordChar = false;
            this.sensitivityTxt.WordWrap = true;
            this.sensitivityTxt.TextChange += new System.EventHandler(this.sensitivityTxt_TextChange);
            // 
            // playerSettingsPanel
            // 
            this.playerSettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(13)))));
            this.playerSettingsPanel.Controls.Add(this.sensitivityTxt);
            this.playerSettingsPanel.Controls.Add(this.sensitivityLbl);
            this.playerSettingsPanel.Controls.Add(this.playerSettingsLbl);
            this.playerSettingsPanel.Location = new System.Drawing.Point(297, 49);
            this.playerSettingsPanel.Name = "playerSettingsPanel";
            this.playerSettingsPanel.Size = new System.Drawing.Size(264, 470);
            this.playerSettingsPanel.TabIndex = 96;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataSource = typeof(SensitivityFinder.Game);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(860, 620);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gameSettingsPanel);
            this.Controls.Add(this.playerSettingsPanel);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSettings_KeyDown);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.gameSettingsPanel.ResumeLayout(false);
            this.gameSettingsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.playerSettingsPanel.ResumeLayout(false);
            this.playerSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label playerSettingsLbl;
        private System.Windows.Forms.Label sensitivityLbl;
        private System.Windows.Forms.Panel gameSettingsPanel;
        private System.Windows.Forms.Label gameLbl;
        private Bunifu.UI.WinForms.BunifuTextBox fovTxt;
        private Bunifu.UI.WinForms.BunifuDropdown gameDropdown;
        private System.Windows.Forms.Label fovLbl;
        private System.Windows.Forms.Label gameSettingsLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label numPointsLbl;
        private System.Windows.Forms.Label trainingSettings;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton startBtn;
        private Bunifu.UI.WinForms.BunifuHSlider numPerPointSlider;
        private System.Windows.Forms.Label numPerPointLbl;
        private Bunifu.UI.WinForms.BunifuHSlider numPointsSlider;
        private Bunifu.UI.WinForms.BunifuTextBox sensitivityTxt;
        private System.Windows.Forms.Panel playerSettingsPanel;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private System.Windows.Forms.Label numPerPointTextLbl;
        private System.Windows.Forms.Label numPointsTextLbl;
    }
}

