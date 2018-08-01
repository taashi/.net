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
	public partial class WebForm2 : System.Web.UI.Page
	{
		SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\StudentData.mdf;Integrated Security=True");
		
		protected void Page_Load(object sender, EventArgs e)
		{
			Idofuser.Text = Session["id"].ToString();
			//SqlDataAdapter da;
			//DataTable ds = new DataTable();
			//con.Open();
			//string checkuser = "SELECT distinct Major,CourseID,RegisteredCourses FROM [Courses] WHERE  StudName != '" + Label3.Text + "'";
			//SqlCommand com1 = new SqlCommand(checkuser, con);
			//da = new SqlDataAdapter(com1);
			//da.Fill(ds);
			//GridView1.DataSource = ds;
			//GridView1.DataBind();
		}

		protected void Button1_Click(object sender, EventArgs e)
		{

			foreach(GridViewRow gvrow in GridView1.Rows)
				{
				CheckBox status = (gvrow.Cells[3].FindControl("CheckBox1") as CheckBox);
				string rid = Convert.ToString(gvrow.Cells[2].Text);
				string cid = Convert.ToString(gvrow.Cells[1].Text);
				string maj = Convert.ToString(gvrow.Cells[0].Text);
				Label4.Text = rid;
				Label5.Text = cid;
				Label6.Text = maj;
				if (status.Checked && status!=null)
				{

					string ins = "Insert into [CoursesReg](StudName,CourseID,RegisteredCourses,Major) values ('" + Idofuser.Text + "','" + cid + "','" + rid + "','" + maj + "')";

					SqlCommand com = new SqlCommand(ins, con);


					con.Open();
					com.ExecuteNonQuery();
					con.Close();
					//String updatedata = "Update Courses set StudName='" + Idofuser.Text + "' where RegisteredCourses=' " + rid + "'";
					////+ "' and CourseID = '" + cid + "' and Major = '" + maj + "'";
					////SqlConnection con = new SqlConnection(mycon);
					//SqlCommand com = new SqlCommand(updatedata, con);
					////SqlCommand cmd = new SqlCommand();

					//con.Open();
					//com.ExecuteNonQuery();
					//con.Close();
					Label1.Text = "Data Has Been Saved Successfully";
					//Label1.Text = "chalo";
				}
				
			}
		}
	}
}