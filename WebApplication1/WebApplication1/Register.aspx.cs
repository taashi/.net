using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace WebApplication1
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\StudentData.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
			
		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			if ((nametxt.Text.Equals("")) || (passwordtxt.Text.Equals("")))
			{
				Label4.ForeColor = System.Drawing.Color.Red;
				Label4.Text = "Please enter the mandatory fields - username/password";
			}
			else
			{
				string checkuser = "SELECT TOP 1 Name FROM [StudentSignUpDetails] WHERE Name='" + nametxt.Text + "'";
				SqlCommand com1 = new SqlCommand(checkuser, con);
				con.Open();
				string temp = com1.ExecuteScalar() as string;
				con.Close();
				if (temp != null)
				{
					Response.Write("User already exists");
				}
				
				else
				{
					string ins = "Insert into [StudentSignUpDetails](Name,Password,FirstName,LastName,Course) values ('" + nametxt.Text + "','"+ passwordtxt.Text + "','" + fname.Text + "','" + lname.Text + "','"+ course.Text +"')";

					SqlCommand com = new SqlCommand(ins, con);


					con.Open();
					com.ExecuteNonQuery();
					con.Close();
					Response.Write("<script language='javascript'>window.alert('You will be redirected to the login page. Please click ok');window.location='Login.aspx';</script>");
					
					
					
				}
			}
        }

		protected void passwordtxt_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}