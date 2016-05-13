using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Sirius.SiriusOnline
{
    public partial class Login : System.Web.UI.Page
    {
        private int ValidateUser(string username, string password)
        {
            int result = 0;
            using (EntityModels.EntityModelSirius model = new EntityModels.EntityModelSirius(Global.SQLConnectionString))
            {
                var user = model.ClientUsers.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    if (user.IsActive)
                    {
                        result = user.Id;
                    }
                    else
                    {
                        result = -1;
                    }
                }
            }
            return result;
        }

        protected void buttonLogin_Click(object sender, EventArgs e)
        {
            int userid = ValidateUser(textBoxUserName.Text, textBoxPassword.Text);
            if (userid > 0)
            {
                FormsAuthenticationTicket tkt;
                string cookiestr;
                HttpCookie ck;
                tkt = new FormsAuthenticationTicket(1, textBoxUserName.Text, DateTime.Now,
          DateTime.Now.AddMinutes(480), checkBoxPersistent.Checked, userid.ToString());
                cookiestr = FormsAuthentication.Encrypt(tkt);
                ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);
                if (checkBoxPersistent.Checked)
                    ck.Expires = tkt.Expiration;
                ck.Path = FormsAuthentication.FormsCookiePath;
                Response.Cookies.Add(ck);

                string strRedirect;
                strRedirect = Request["ReturnUrl"];
                if (strRedirect == null)
                    strRedirect = "Default.aspx";
                Response.Redirect(strRedirect, true);
            }
            else
            {
                if (userid == 0)
                {
                    LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Wrong username or password");
                }
                else
                {
                    LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.WARNING, "User disabled - Please contact Radan");
                }
                //Response.Redirect("Logon.aspx", true);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}
