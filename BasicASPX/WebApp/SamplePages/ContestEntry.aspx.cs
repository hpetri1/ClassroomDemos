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
        //since we are not currently using a database, we will collect the contest entries into a List<T> collection
        //<T> will be the class Entry
        //The List<T> will be static to hang around during our testing
        public static List<Entry> contestentries = new List<Entry>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //on the server side, you can rerun the validation controls
            if(Page.IsValid)
            {
                string firstname = FirstName.Text;
                string lastname = LastName.Text;
                string streetaddress1 = StreetAddress1.Text;
                string streetaddress2 = StreetAddress2.Text;
                string city = City.Text;
                string email = EmailAddress.Text;
                string pc = PostalCode.Text;
                string province = Province.SelectedValue;
                bool terms = Terms.Checked;
                string answer = CheckAnswer.Text;

                //there may be validation that cannot be done using the basic validation controls
                //or
                //there may be a need for logic control validation
                if (terms) //was the checkbox checked?
                {
                    //Message.Text = firstname + " " + lastname;

                    //Create an instance of the Entry using the greedy constructor
                    Entry theEntry = new Entry(firstname, lastname, streetaddress1, streetaddress2, province, city, pc, email);

                    //add to the collection of entries
                    contestentries.Add(theEntry);

                    //attach the collection of entries to the GridView control
                    ContestEntries.DataSource = contestentries;
                    ContestEntries.DataBind();
                }
                else
                {
                    Message.Text = "You did not agree to the terms of the contest. Entry denied.";
                }
                
            }
            

            //if(Terms.Checked == false)
            //{
            //    Message.Text = "You need to agree to Terms and Conditions!";
            //}
            //else
            //{
            //    if(string.IsNullOrEmpty(CheckAnswer.Text))
            //    {
            //        Message.Text = "You need to provide the calculation answer!";
            //    }
            //    else
            //    {
            //        if(CheckAnswer.Text == "45")
            //        {
            //             Message.Text = "You have entered the following data: " + FirstName.Text + LastName.Text + ", "
            //                + StreetAddress1.Text + StreetAddress2.Text + ", " + City.Text + ", " + Province.SelectedValue.ToString()
            //                + ", " + PostalCode.Text + ", " + EmailAddress.Text;
            //        }
            //        else
            //        {
            //            Message.Text = "Sorry, but the answer " + CheckAnswer.Text + " is not correct! Please, try again!";
            //        }
            //    }

            //}
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            Province.SelectedIndex = 0;
            PostalCode.Text = "";
            EmailAddress.Text = "";
            Terms.Checked = false;
            CheckAnswer.Text = "";


            //I did this instead of Province.SelectedIndex = 0;
            //string submitchoice = "AB";
            //Province.SelectedValue = submitchoice;
        }
    }
}