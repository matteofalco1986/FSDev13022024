using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week15_Lezione2_Esercitazione
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["LoginCookie"] != null)
            {
                Response.Redirect("Logout.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie myCookie = new HttpCookie("LoginCookie");
            myCookie.Values["username"] = TxtName.Text;
            myCookie.Values["password"] = TxtPassword.Text;
            Response.Cookies.Add(myCookie);
            Response.Redirect("Logout.aspx");
        }
    }
}