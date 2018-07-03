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
            usertxt.Text = "";
            pswrdtxt.Text = "";
            Label4.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((usertxt.Text != "") && (pswrdtxt.Text != ""))
            {
                string check = "select count(*) from [Table] where Name = '" + usertxt.Text + "' and Password = '" + pswrdtxt.Text
                    + "'";
                SqlCommand com = new SqlCommand(check, con);
                con.Open();
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                con.Close();
                if (temp == 1)
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Label4.ForeColor = System.Drawing.Color.Red;
                    Label4.Text = "Your email or password is invalid";
                }

            }
            else
            {
                Label4.ForeColor = System.Drawing.Color.Red;
                Label4.Text = "Please enter your email and password";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}