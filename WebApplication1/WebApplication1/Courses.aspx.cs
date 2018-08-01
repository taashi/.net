using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
	public partial class Courses : System.Web.UI.Page
	{
		SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\StudentData.mdf;Integrated Security=True");
		protected void Page_Load(object sender, EventArgs e)
		{
			
			Label3.Text = Session["id"].ToString();
			SqlDataAdapter da;
			DataTable ds = new DataTable();
			con.Open();
			string checkuser = "SELECT distinct Major,CourseID,RegisteredCourses FROM [Courses] WHERE Studname is NULL OR StudName != '" + Label3.Text + "'";
			SqlCommand com1 = new SqlCommand(checkuser, con);
			da = new SqlDataAdapter(com1);
			da.Fill(ds);
			GridView1.DataSource = ds;
			GridView1.DataBind();
			con.Close();

		}



		protected void OnSelectedIndexChanged(object sender, EventArgs e)
		{

			//Accessing BoundField Column
			string name = GridView1.SelectedRow.Cells[0].Text;

			//Accessing TemplateField Column controls
			string country = (GridView1.SelectedRow.FindControl("Checkbox1") as Label).Text;

			Label4.Text = "<b>Name:</b> " + name + " <b>Country:</b> " + country;
		}



		protected void Button1_Click(object sender, EventArgs e)
		{

			
				foreach (GridViewRow gvrow in GridView1.Rows)
				{
					CheckBox cb = (gvrow.Cells[3].FindControl("CheckBox1") as CheckBox);
					if (cb != null & cb.Checked)
					{

					Label4.Text = "fgfg";
					}
				
					}
			}
		}
	}

			
				
			