
namespace EnjoyPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.coreplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.volumeControll = new Bunifu.Framework.UI.BunifuSlider();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.elipsedtime = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.customstation = new MetroFramework.Controls.MetroTextBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radiopicture = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            ((System.ComponentModel.ISupportInitialize)(this.coreplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiopicture)).BeginInit();
            this.SuspendLayout();
            // 
            // coreplayer
            // 
            this.coreplayer.Enabled = true;
            this.coreplayer.Location = new System.Drawing.Point(23, 57);
            this.coreplayer.Name = "coreplayer";
            this.coreplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("coreplayer.OcxState")));
            this.coreplayer.Size = new System.Drawing.Size(282, 214);
            this.coreplayer.TabIndex = 0;
            this.coreplayer.Visible = false;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Radio 1",
            "Retro Rádio",
            "Sláger FM",
            "Kossuth Rádió",
            "Klubrádió",
            "Karc FM",
            "Mix Rádió",
            "Best FM",
            "HardStyle",
            "MoveDaHouse",
            "Mulatós Rádió",
            "Duna Tisza Rádió",
            "Tilos Rádió",
            "Manna FM3",
            "Custom"});
            this.metroComboBox1.Location = new System.Drawing.Point(23, 233);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(281, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroComboBox1.TabIndex = 8;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroComboBox1.UseCustomForeColor = true;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.UseStyleColors = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // volumeControll
            // 
            this.volumeControll.BackColor = System.Drawing.Color.Transparent;
            this.volumeControll.BackgroudColor = System.Drawing.Color.DimGray;
            this.volumeControll.BorderRadius = 5;
            this.volumeControll.IndicatorColor = System.Drawing.Color.Gainsboro;
            this.volumeControll.Location = new System.Drawing.Point(17, 268);
            this.volumeControll.MaximumValue = 100;
            this.volumeControll.Name = "volumeControll";
            this.volumeControll.Size = new System.Drawing.Size(287, 30);
            this.volumeControll.TabIndex = 23;
            this.volumeControll.Value = 5;
            this.volumeControll.ValueChanged += new System.EventHandler(this.volumeControll_ValueChanged);
            this.volumeControll.ValueChangeComplete += new System.EventHandler(this.volumeControll_ValueChangeComplete);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Gainsboro;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(331, 8);
            this.bunifuProgressBar1.TabIndex = 28;
            this.bunifuProgressBar1.Value = 100;
            // 
            // elipsedtime
            // 
            this.elipsedtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.elipsedtime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.elipsedtime.Enabled = false;
            this.elipsedtime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.elipsedtime.ForeColor = System.Drawing.Color.White;
            this.elipsedtime.HintForeColor = System.Drawing.Color.Empty;
            this.elipsedtime.HintText = "";
            this.elipsedtime.isPassword = false;
            this.elipsedtime.LineFocusedColor = System.Drawing.Color.Transparent;
            this.elipsedtime.LineIdleColor = System.Drawing.Color.Transparent;
            this.elipsedtime.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.elipsedtime.LineThickness = 5;
            this.elipsedtime.Location = new System.Drawing.Point(132, 37);
            this.elipsedtime.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.elipsedtime.Name = "elipsedtime";
            this.elipsedtime.Size = new System.Drawing.Size(63, 22);
            this.elipsedtime.TabIndex = 39;
            this.elipsedtime.Text = "00:00:00";
            this.elipsedtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customstation
            // 
            // 
            // 
            // 
            this.customstation.CustomButton.Image = null;
            this.customstation.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.customstation.CustomButton.Name = "";
            this.customstation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.customstation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.customstation.CustomButton.TabIndex = 1;
            this.customstation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customstation.CustomButton.UseSelectable = true;
            this.customstation.CustomButton.Visible = false;
            this.customstation.Lines = new string[] {
        "http://streamradiox.hu:8100/live2.mp3"};
            this.customstation.Location = new System.Drawing.Point(23, 291);
            this.customstation.MaxLength = 32767;
            this.customstation.Name = "customstation";
            this.customstation.PasswordChar = '\0';
            this.customstation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customstation.SelectedText = "";
            this.customstation.SelectionLength = 0;
            this.customstation.SelectionStart = 0;
            this.customstation.ShortcutsEnabled = true;
            this.customstation.Size = new System.Drawing.Size(281, 23);
            this.customstation.Style = MetroFramework.MetroColorStyle.Silver;
            this.customstation.TabIndex = 41;
            this.customstation.Text = "http://streamradiox.hu:8100/live2.mp3";
            this.customstation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.customstation.UseCustomForeColor = true;
            this.customstation.UseSelectable = true;
            this.customstation.UseStyleColors = true;
            this.customstation.Visible = false;
            this.customstation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.customstation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.customstation.TextChanged += new System.EventHandler(this.customstation_TextChanged);
            this.customstation.Click += new System.EventHandler(this.customstation_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(30, 14);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(22, 20);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 40;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(7, 14);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(22, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 36;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 48);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // radiopicture
            // 
            this.radiopicture.BackColor = System.Drawing.Color.Transparent;
            this.radiopicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radiopicture.ErrorImage = null;
            this.radiopicture.Image = ((System.Drawing.Image)(resources.GetObject("radiopicture.Image")));
            this.radiopicture.ImageActive = null;
            this.radiopicture.InitialImage = null;
            this.radiopicture.Location = new System.Drawing.Point(103, 65);
            this.radiopicture.Name = "radiopicture";
            this.radiopicture.Size = new System.Drawing.Size(122, 111);
            this.radiopicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.radiopicture.TabIndex = 34;
            this.radiopicture.TabStop = false;
            this.radiopicture.Zoom = 10;
            this.radiopicture.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 1;
            this.bunifuCircleProgressbar1.animationSpeed = 1;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(59, 16);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(209, 209);
            this.bunifuCircleProgressbar1.TabIndex = 27;
            this.bunifuCircleProgressbar1.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 310);
            this.Controls.Add(this.customstation);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.elipsedtime);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radiopicture);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.volumeControll);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.coreplayer);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "EnjoyStream V2.3";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.coreplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiopicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public AxWMPLib.AxWindowsMediaPlayer coreplayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Bunifu.Framework.UI.BunifuSlider volumeControll;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuImageButton radiopicture;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox elipsedtime;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private MetroFramework.Controls.MetroTextBox customstation;
    }
}

