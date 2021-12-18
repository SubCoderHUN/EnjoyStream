using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace EnjoyPlayer
{

    public partial class Form1 : MetroForm
    {
        #region MAIN
        /*--------------------------------------------
         
         Deklarációk stb...    
             
        --------------------------------------------*/
        bool stp = false;
        public Form1()
        {
            InitializeComponent();
            coreplayer.settings.volume = volumeControll.Value = 5;
            timer1.Start();
            bunifuCircleProgressbar1.animated = false;
        }
        #region Player Core
        void PlayerCore()
        {
            try
            {

                /*--------------------------------------------
                 
                 Rádióállomások, hozzá tartozó képek beállítása
                 
                 --------------------------------------------*/
                if (!stp)
                {
                    switch (metroComboBox1.SelectedIndex)
                    {
                        case 0:
                            {
                                coreplayer.URL = "https://radioplayer.myonlineradio.hu/ldblncr/radio-1/mid.mp3";
                                radiopicture.Image = Properties.Resources.radio1;
                                customstation.Hide();
                                break;
                            }
                        case 1:
                            {
                                coreplayer.URL = "https://icast.connectmedia.hu/5002/live.mp3";
                                radiopicture.Image = Properties.Resources.retroradio;
                                customstation.Hide();
                                break;
                            }
                        case 2:
                            {
                                coreplayer.URL = "https://slagerfm.netregator.hu:7813/slagerfm128.mp3";
                                radiopicture.Image = Properties.Resources.slagerfm;
                                customstation.Hide();
                                break;
                            }
                        case 3:
                            {
                                coreplayer.URL = "https://icast.connectmedia.hu/4736/mr1.mp3";
                                radiopicture.Image = Properties.Resources.kossuth;
                                customstation.Hide();
                                break;
                            }
                        case 4:
                            {
                                coreplayer.URL = "http://hu-stream05.klubradio.hu:8080/bpstream";
                                radiopicture.Image = Properties.Resources.klubradio;
                                customstation.Hide();
                                break;
                            }
                        case 5:
                            {
                                coreplayer.URL = "https://karcfm.42netmedia.com:8443/karcfm-low";
                                radiopicture.Image = Properties.Resources.karcfm;
                                customstation.Hide();
                                break;
                            }
                        case 6:
                            {
                                coreplayer.URL = "http://adas.adasszerver.hu/live";
                                radiopicture.Image = Properties.Resources.mixradio;
                                customstation.Hide();
                                break;
                            }
                        case 7:
                            {
                                coreplayer.URL = "https://icast.connectmedia.hu/5102/live.mp3";
                                radiopicture.Image = Properties.Resources.bestfm;
                                customstation.Hide();
                                break;
                            }
                        case 8:
                            {
                                coreplayer.URL = "https://www.internet-radio.com/servers/tools/playlistgenerator/?u=http://uk5.internet-radio.com:8270/listen.pls&t=.m3u";
                                radiopicture.Image = Properties.Resources.hardstyle;
                                customstation.Hide();
                                break;
                            }
                        case 9:
                            {
                                coreplayer.URL = "http://uk7.internet-radio.com:8000/listen.pls&t=.m3u";
                                radiopicture.Image = Properties.Resources.techno;
                                customstation.Hide();
                                break;
                            }
                        case 10:
                            {
                                coreplayer.URL = "https://stream.diazol.hu:31032/mulatos.mp3";
                                radiopicture.Image = Properties.Resources.mulatos;
                                customstation.Hide();
                                break;
                            }
                        case 11:
                            {
                                coreplayer.URL = "https://radiostat.info/streamtracking/https/radio.ch3.hu:8030/dtr_128k.mp3";
                                radiopicture.Image = Properties.Resources.dunatisza;
                                customstation.Hide();
                                break;
                            }
                        case 12:
                            {
                                coreplayer.URL = "http://stream.tilos.hu/tilos_128.mp3";
                                radiopicture.Image = Properties.Resources.tilosradio;
                                customstation.Hide();
                                break;
                            }
                        case 13:
                            {
                                coreplayer.URL = "https://icast.connectmedia.hu/4780/live.mp3";
                                radiopicture.Image = Properties.Resources.mannafm;
                                customstation.Hide();
                                break;
                            }
                        case 14:
                            {
                                coreplayer.URL = customstation.Text;
                                radiopicture.Image = Properties.Resources.questionmark;
                                customstation.Show();
                                break;
                            }
                    }
                    if (customstation.Text != null)
                        coreplayer.Ctlcontrols.play();
                    else
                        MessageBox.Show("Station link coud not be empty!", "EnjoyStream", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    coreplayer.Ctlcontrols.pause();
            }
            catch
            {
                MessageBox.Show("HIBA! Kérjük, lépjen kapcsolatba a fejlesztővel", "EnjoyStream", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Volume,Pause,Station
        /*--------------------------------------------

        Lejátszási hangerő, Start/stop, Station

        --------------------------------------------*/

        private void volumeControll_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = 100000;
            coreplayer.settings.volume = volumeControll.Value;
            elipsedtime.Text = coreplayer.settings.volume.ToString();
        }

        private void volumeControll_ValueChangeComplete(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }
        /*--------------------------------------------*/

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stp = false;
            PlayerCore();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            stp = !stp;
            PlayerCore();
        }
        private void customstation_Click(object sender, EventArgs e)
        {
            customstation.Clear();
        }
        private void customstation_TextChanged(object sender, EventArgs e)
        {
            coreplayer.Ctlcontrols.stop();
            coreplayer.URL = customstation.Text;
            coreplayer.Ctlcontrols.play();
        }

        #endregion
        #region Traicon

        /*--------------------------------------------
         
        Minimalizált tálca ikon, értesítés
             
        --------------------------------------------*/
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
            ShowIcon = true;
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowIcon = false;
            notifyIcon1.Icon = new Icon(Icon, 40, 40);
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "EnjoyStream";
            notifyIcon1.ShowBalloonTip(1000, "EnjoyStream", "Az alkalmazás minimalizálva", ToolTipIcon.Info);
        }
        #endregion
        #region Info
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
        #endregion
        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {

            elipsedtime.Text = coreplayer.Ctlcontrols.currentPositionString;

            if (coreplayer.Ctlcontrols.currentPosition != 0)
                bunifuCircleProgressbar1.animationIterval = 1;
            else
                bunifuCircleProgressbar1.animationIterval = 20;

            if (!stp)
            {
                bunifuCircleProgressbar1.Value = 25;
                bunifuCircleProgressbar1.animated = true;
            }
            else
            {
                bunifuCircleProgressbar1.Value = 100;
                bunifuCircleProgressbar1.animated = false;
            }

        }
        #endregion

        #endregion
    }
}
