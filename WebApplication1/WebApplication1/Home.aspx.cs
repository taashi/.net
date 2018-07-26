using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
		SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\StudentData.mdf;Integrated Security=True");
		protected void Page_Load(object sender, EventArgs e)
        {
			Label3.Text = Session["id"].ToString();

			SqlDataAdapter da;
			DataTable ds = new DataTable();
			con.Open();
			string checkuser = "SELECT Major,CourseID,RegisteredCourses FROM [Courses] inner join StudentSignUpDetails on Courses.StudName = StudentSignUpDetails.Name ";
			SqlCommand com1 = new SqlCommand(checkuser, con);
			da = new SqlDataAdapter(com1);
			da.Fill(ds);
			GridView1.DataSource = ds;
			GridView1.DataBind();

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			Session.RemoveAll();
			Response.Redirect("Login.aspx");
		}


		
	}
}