using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokedex_ZFH
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection SQLConn = new SqlConnection("Data Source = GULZAIB\\SQLEXPRESS; Initial Catalog = POKEDEX; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SQLConn.Open();
            SqlCommand cmd = new SqlCommand("insert into tbllogin values(@name,@Pass,@city,@gender,@mail)");
            cmd.Parameters.AddWithValue("name", TextBox1.Text);
            cmd.Parameters.AddWithValue("Pass", TextBox2.Text);
            cmd.Parameters.AddWithValue("city", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("gender", RadioButtonList1.SelectedValue);
            cmd.Parameters.AddWithValue("mail", TextBox4.Text);

            TextBox1.Text="";
            TextBox2.Text="";
            DropDownList1.SelectedValue="";
            RadioButtonList1.SelectedValue="";
            TextBox4.Text="";
            TextBox1.Focus();
        }
    }
}