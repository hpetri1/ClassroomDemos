using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if(Terms.Checked == false)
            {
                Message.Text = "You need to agree to Terms and Conditions!";
            }
            else
            {
                if(string.IsNullOrEmpty(CheckAnswer.Text))
                {
                    Message.Text = "You need to provide the calculation answer!";
                }
                else
                {
                    if(CheckAnswer.Text == "45")
                    {
                         Message.Text = "You have entered the following data: " + FirstName.Text + LastName.Text + ", "
                            + StreetAddress1.Text + StreetAddress2.Text + ", " + City.Text + ", " + Province.SelectedValue.ToString()
                            + ", " + PostalCode.Text + ", " + EmailAddress.Text;
                    }
                    else
                    {
                        Message.Text = "Sorry, but the answer " + CheckAnswer.Text + " is not correct! Please, try again!";
                    }
                }
                
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            string submitchoice = "AB";

            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            Province.SelectedValue = submitchoice;
            PostalCode.Text = "";
            EmailAddress.Text = "";
            Terms.Checked = false;
            CheckAnswer.Text = "";
        }
    }
}