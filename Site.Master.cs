using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Car_Insurance_Services
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public Label labusername
        {
            get
            {
                return this.labusername;
            }
        }
        public LinkButton linklogin
        {
            get
            {
                return this.linklogin;
            }
        }
        public LinkButton linkreg
        {
            get
            {
                return this.linkreg;
            }
        }
        public LinkButton linklogout
        {
            get
            {
                return this.linklogout;
            }
        }
        public Image imguser
        {
            get
            {
                return this.imguser;
            }
        }
    }
}