using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace homework2
{
    public partial class _default : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DEVELOPER;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            Response.Write("connect");
            showdata();
        }
        protected void showdata()
        {
            SqlCommand cmd = conn.CreateCommand();
            SqlDataReader dr;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tb_student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            conn.Close();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id.Text = GridView1.SelectedRow.Cells[1].Text;
            name.Text = GridView1.SelectedRow.Cells[2].Text;
            surname.Text = GridView1.SelectedRow.Cells[3].Text;
            email.Text = GridView1.SelectedRow.Cells[4].Text;
            major.Text = GridView1.SelectedRow.Cells[5].Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            conn.Open();
            if (id.Text == "" || name.Text == "" || surname.Text == "" || email.Text == "" || idcountry.Text == "")
            {
                this.show_error.Text = "ກະລຸນາເລືອກປ້ອນຂໍ້ມູນກ່ອນ";
            }
            else
            {
                if (female.Checked == true)
                {
                    if (java.Checked == true && php.Checked == true && vb.Checked == true)
                    {
                        cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','F','" + email.Text + "','" + idcountry.Text + "','" + major.Text + "','" + java.Text + ", " + php.Text + ", " + vb.Text + "')";
                        cmd.ExecuteNonQuery();
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        if (java.Checked == true && php.Checked == true)
                        {
                            cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','F','" + email.Text + "','" + idcountry.Text + "''" + major.Text + "','" + java.Text + ", " + php.Text + "')";
                            cmd.ExecuteNonQuery();
                            Response.Redirect("Default.aspx");
                        }
                        else
                        {
                            if (java.Checked == true && vb.Checked == true)
                            {
                                cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','F','" + email.Text + "','" + idcountry.Text + "''" + major.Text + "','" + java.Text + ", " + vb.Text + "')";
                                cmd.ExecuteNonQuery();
                                Response.Redirect("Default.aspx");
                            }
                            else
                            {
                                if (php.Checked == true && vb.Checked == true)
                                {
                                    cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','F','" + email.Text + "','" + idcountry.Text + "','" + major.Text + "','" + php.Text + ", " + vb.Text + "')";
                                    cmd.ExecuteNonQuery();
                                    Response.Redirect("Default.aspx");
                                }
                                else
                                {
                                    if (java.Checked == true)
                                    {
                                        cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','F','" + email.Text + "','" + idcountry.Text + "','" + major.Text + "','" + java.Text + "')";
                                        cmd.ExecuteNonQuery();
                                        Response.Redirect("Default.aspx");
                                    }
                                    else
                                    {
                                        if (php.Checked == true)
                                        {
                                            cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','F','" + email.Text + "','" + idcountry.Text + "','" + major.Text + "','" + php.Text + "')";
                                            cmd.ExecuteNonQuery();
                                            Response.Redirect("Default.aspx");
                                        }
                                        else
                                        {
                                            if (vb.Checked == true)
                                            {
                                                cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','F','" + email.Text + "','" + idcountry.Text + "','" + major.Text + "','" + vb.Text + "')";
                                                cmd.ExecuteNonQuery();
                                                Response.Redirect("Default.aspx");
                                            }
                                            else
                                            {
                                                this.show_error.Text = " ກະລຸນາເລືອກພາສາໂປຣແກຣມທີ່ເຈົ້າມັກກ່ອນ";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (male.Checked == true)
                {
                    if (java.Checked == true && php.Checked == true && vb.Checked == true)
                    {
                        cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','M','" + email.Text + "','" + idcountry.Text + "','" + major.Text + "','" + java.Text + ", " + php.Text + ", " + vb.Text + "')";
                        cmd.ExecuteNonQuery();
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        if (java.Checked == true && php.Checked == true)
                        {
                            cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','M','" + email.Text + "','" + idcountry.Text + "','" + major.Text + "','" + java.Text + ", " + php.Text + "')";
                            cmd.ExecuteNonQuery();
                            Response.Redirect("Default.aspx");
                        }
                        else
                        {
                            if (java.Checked == true && vb.Checked == true)
                            {
                                cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','M','" + email.Text + "','" + idcountry.Text + "','" + major.Text + "','" + java.Text + ", " + vb.Text + "')";
                                cmd.ExecuteNonQuery();
                                Response.Redirect("Default.aspx");
                            }
                            else
                            {
                                if (php.Checked == true && vb.Checked == true)
                                {
                                    cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','M','" + email.Text + "','" + idcountry.Text + "','" + major.Text + "','" + php.Text + "," + vb.Text + "')";
                                    cmd.ExecuteNonQuery();
                                    Response.Redirect("Default.aspx");
                                }
                                else
                                {
                                    if (java.Checked == true)
                                    {
                                        cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','M','" + email.Text + "','" + idcountry.Text + "','" + major.Text + "','" + java.Text + "')";
                                        cmd.ExecuteNonQuery();
                                        Response.Redirect("Default.aspx");
                                    }
                                    else
                                    {
                                        if (php.Checked == true)
                                        {
                                            cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','M','" + email.Text + "','" + idcountry.Text + "','" + major.Text + "','" + php.Text + "')";
                                            cmd.ExecuteNonQuery();
                                            Response.Redirect("Default.aspx");
                                        }
                                        else
                                        {
                                            if (vb.Checked == true)
                                            {
                                                cmd.CommandText = "INSERT INTO tb_student VALUES('" + id.Text + "','" + name.Text + "','" + surname.Text + "','M','" + email.Text + "','" + idcountry.Text + "','" + major.Text + "','" + vb.Text + "')";
                                                cmd.ExecuteNonQuery();
                                                Response.Redirect("Default.aspx");
                                            }
                                            else
                                            {
                                                this.show_error.Text = " ກະລຸນາເລືອກພາສາໂປຣແກຣມທີ່ເຈົ້າມັກກ່ອນ";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    this.show_error.Text = " ກະລຸນາເລືອກເພດກ່ອນ";
                }
            }



        }
    }
}