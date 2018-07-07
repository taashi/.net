using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\StudentData.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
			if ((usertxt.Text.Equals("")) || (pswrdtxt.Text.Equals("")))
			{
				Label4.ForeColor = System.Drawing.Color.Red;
				Label4.Text = "Please enter your email and password";
			}
			else
			{
				string check = "select count(*) from [StudentSignUpDetails] where Name = '" + usertxt.Text + "' and Password = '" + pswrdtxt.Text
					+ "'";
				SqlCommand com = new SqlCommand(check, con);
				con.Open();
				int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
				con.Close();
				if (temp == 1)
				{
					
						Session["id"] = usertxt.Text;
						Response.Redirect("Home.aspx");
						Session.RemoveAll();
						
				}
				if (temp == 0)
				{
					Label4.ForeColor = System.Drawing.Color.Red;
					Label4.Text = "Your email or password is invalid. Please enter the correct details or sign up";
				}

			}
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}