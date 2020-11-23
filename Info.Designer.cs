namespace EnjoyPlayer
{
    partial class Info
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
            this.LocalVersion = new System.Windows.Forms.Label();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contactus = new MetroFramework.Controls.MetroLink();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // LocalVersion
            // 
            this.LocalVersion.AutoSize = true;
            this.LocalVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LocalVersion.ForeColor = System.Drawing.Color.White;
            this.LocalVersion.Location = new System.Drawing.Point(213, 52);
            this.LocalVersion.Name = "LocalVersion";
            this.LocalVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LocalVersion.Size = new System.Drawing.Size(35, 24);
            this.LocalVersion.TabIndex = 26;
            this.LocalVersion.Text = "2.1";
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(68, 171);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(191, 23);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroLink1.TabIndex = 25;
            this.metroLink1.Text = "WebSite";
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "© EnjoyStream by U3ViQ29kZXI=#4911";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "EnjoyStream V";
            // 
            // contactus
            // 
            this.contactus.Location = new System.Drawing.Point(68, 229);
            this.contactus.Name = "contactus";
            this.contactus.Size = new System.Drawing.Size(191, 23);
            this.contactus.Style = MetroFramework.MetroColorStyle.Brown;
            this.contactus.TabIndex = 22;
            this.contactus.Text = "Contact with the developer";
            this.contactus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.contactus.UseSelectable = true;
            this.contactus.Click += new System.EventHandler(this.contactus_Click);
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
            this.bunifuProgressBar1.TabIndex = 29;
            this.bunifuProgressBar1.Value = 100;
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(68, 200);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(191, 23);
            this.metroLink2.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroLink2.TabIndex = 30;
            this.metroLink2.Text = "Buy me a coffe ☕";
            this.metroLink2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 310);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.LocalVersion);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contactus);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Info";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LocalVersion;
        public MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public MetroFramework.Controls.MetroLink contactus;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        public MetroFramework.Controls.MetroLink metroLink2;
    }
}