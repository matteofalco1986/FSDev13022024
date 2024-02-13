using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week15_Lezione2_Esercitazione
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["LoginCookie"] == null)
            {
                Response.Redirect("Logout.aspx");
            }
            else
            {
                Label1.Text = Request.Cookies["LoginCookie"]["username"];
                Label2.Text = Request.Cookies["LoginCookie"]["password"];
            }
        }
        protected void Logout_Btn_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["LoginCookie"] != null)
            {
                HttpCookie myCookie = new HttpCookie("LoginCookie");
                myCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(myCookie);
                Response.Redirect("Login.aspx");
            }
        }
    }
}