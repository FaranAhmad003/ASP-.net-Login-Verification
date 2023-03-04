using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_ZFH
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        // SqlConnection SQLConn = new SqlConnection("Data Source = gulzaib; initial Catalog=POKEDEX;Integrated security=True");
      //  Data Source = GULZAIB\SQLEXPRESS;Initial Catalog = POKEDEX; Integrated Security = True
        SqlConnection SQLConn = new SqlConnection("Data Source = GULZAIB\\SQLEXPRESS; Initial Catalog = POKEDEX; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter();
                try
                {
                    label.Text="";
                    //SqlDataAdapter SQLAdapter = new SqlDataAdapter("SELECT * FROM useraccount WHERE UserName ='"+txtusername.Text+"'AND Password='" +txtpassword.Text+"'", SQLConn);
                    //// DataTable DT = new DataTable();
                    //dt = new DataTable();
                    //SqlDataAdapter adp = new SqlDataAdapter();
                    //// SQLAdapter.Fill(DT);//debugging


                    //if (DT.Rows.Count > 0)
                    //{
                    //    label.Text = "You Have Successfully Logged in";
                    //    label.ForeColor=System.Drawing.Color.Green;
                    //}
                    //else
                    //{
                    //    label.Text="incorrect Password or Username";
                    //    label.ForeColor=System.Drawing.Color.Red;
                    //}

                  // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
                    SqlCommand cmd = new SqlCommand("SELECT * FROM useraccount WHERE UserName ='"+txtusername.Text+"'AND Pwd='" +txtpassword.Text+"'", SQLConn);
                    cmd.CommandType = CommandType.Text;
                    adp.SelectCommand = cmd;
                    adp.Fill(dt);
                    cmd.Dispose();
                    if (dt.Rows.Count > 0)
                    {
                        label.Text = "Login Successfull";
                        label.ForeColor=System.Drawing.Color.Green;
                        //Or in show messagebox using  ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Login Successfull');", true);
                        //Or write using Response.Write("Login Successfull");

                        //Or redirect using Response.Redirect("Mypanel.aspx");
                    }
                    else
                    {
                        label.Text = "Wrong Username/Password";
                        label.ForeColor=System.Drawing.Color.Red;
                        //Or show in messagebox usingScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Wrong Username/Password');", true);
                        //Or write using Response.Write("Wrong Username/Password");
                    }
                }
                catch (Exception ex)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Oops!! following error occured : " + ex.Message.ToString() + "');", true);
                    // Response.Write("Oops!! following error occured: " +ex.Message.ToString());           
                }
                finally
                {
                    dt.Clear();
                    dt.Dispose();
                    adp.Dispose();
                }




            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}