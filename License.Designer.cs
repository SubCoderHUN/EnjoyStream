namespace EnjoyPlayer
{
    partial class License
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
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.keyinput = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
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
            this.bunifuProgressBar1.TabIndex = 30;
            this.bunifuProgressBar1.Value = 100;
            // 
            // keyinput
            // 
            this.keyinput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.keyinput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyinput.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keyinput.ForeColor = System.Drawing.Color.White;
            this.keyinput.HintForeColor = System.Drawing.Color.Empty;
            this.keyinput.HintText = "";
            this.keyinput.isPassword = false;
            this.keyinput.LineFocusedColor = System.Drawing.Color.Transparent;
            this.keyinput.LineIdleColor = System.Drawing.Color.Transparent;
            this.keyinput.LineMouseHoverColor = System.Drawing.Color.Transparent;
            this.keyinput.LineThickness = 3;
            this.keyinput.Location = new System.Drawing.Point(27, 163);
            this.keyinput.Margin = new System.Windows.Forms.Padding(4);
            this.keyinput.Name = "keyinput";
            this.keyinput.Size = new System.Drawing.Size(282, 44);
            this.keyinput.TabIndex = 32;
            this.keyinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(94, 241);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(131, 38);
            this.metroButton1.TabIndex = 33;
            this.metroButton1.Text = "Submit";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(32, 140);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(272, 20);
            this.bunifuCustomLabel3.TabIndex = 35;
            this.bunifuCustomLabel3.Text = "First, we need you product key below:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(23, 19);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(122, 25);
            this.bunifuCustomLabel2.TabIndex = 36;
            this.bunifuCustomLabel2.Text = "Thank you";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(82, 44);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(225, 24);
            this.bunifuCustomLabel4.TabIndex = 37;
            this.bunifuCustomLabel4.Text = "for installing EnjoyStream!";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 310);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.keyinput);
            this.Controls.Add(this.bunifuProgressBar1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "License";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "-";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Shown += new System.EventHandler(this.License_Shown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox keyinput;
        private MetroFramework.Controls.MetroButton metroButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}