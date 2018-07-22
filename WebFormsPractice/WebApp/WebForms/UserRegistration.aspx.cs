using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.WebForms
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        public static List<Registration> registrationinfo = new List<Registration>();

        protected void Page_Load(object sender, EventArgs e)
        {
            MessageUserInfo.Text = "";
        }

        protected void SubmitRegistration_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                string firstname = FirstName.Text;
                string lastname = LastName.Text;
                string username = UserName.Text;
                string emailaddress = EmailAddress.Text;
                string confirmemail = ConfirmEmail.Text;
                string password = Password.Text;
                string confirmpassword = ConfirmPassword.Text;
                bool terms = Terms.Checked;

                if (terms)
                {
                    Registration registerUser = new Registration(firstname, lastname, username, emailaddress, confirmemail, password, confirmpassword);
                    
                    if (registrationinfo.Exists(x => x.LastName == lastname))
                    {
                        MessageUserInfo.Text = "This user already exists and will not be added.";
                    }
                    else
                    {
                        registrationinfo.Add(registerUser);
                        UserInfoGridView.DataSource = registrationinfo;
                        UserInfoGridView.DataBind();
                    }
                }
                else
                {
                    MessageUserInfo.Text = "You need to agree to the terms.";
                }
            }
        }
    }
}