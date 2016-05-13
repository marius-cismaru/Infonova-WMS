using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sirius.SiriusOnline
{
    public partial class AdminChangePassword : System.Web.UI.Page
    {
        public new SiteMaster Master
        {
            get { return ((SiteMaster)(base.Master)); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {

            if (TextBoxOldPassword.Text == Master.LoggedClientUser.Password)
            {
                if (TextBoxNewPassword1.Text == TextBoxNewPassword2.Text)
                {
                    if (TextBoxNewPassword1.Text.Length >= 6)
                    {
                        Master.LoggedClientUser.Password = TextBoxNewPassword1.Text;
                        Master.Model.SaveChanges();
                        LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.SUCCESS, "Password changed");
                    }
                    else
                    {
                        LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "New password must be at least 6 characters long");
                    }
                }
                else
                {
                    LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "New passwords do not match");
                }
            }
            else
            {
                LiteralMessage.Text = ToolMessage.Render(ToolMessage.Kinds.ERROR, "Incorrect old password");
            }
        }
    }
}