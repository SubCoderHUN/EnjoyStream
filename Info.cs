using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MetroFramework.Forms;

namespace EnjoyPlayer
{
    public partial class Info : MetroForm
    {
        public Info()
        {
            InitializeComponent();
        }

        #region Website
        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SubCoderHUN/EnjoyStream");
        }
        #endregion
        #region E-Mail
        /*--------------------------------------------
         
         Program oldalának megnyitása   
             
        --------------------------------------------*/
        private void contactus_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:subcoder02@gmail.com");
        }
        #endregion
        #region BuyMeACoffe
        private void metroLink2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/paypalme/subcoder");
        }
        #endregion
    }
}
