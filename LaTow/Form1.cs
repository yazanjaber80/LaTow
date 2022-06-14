using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaTow
{
    public partial class Form1 : Form
    {
        static SqlConnection Connection = new SqlConnection("data source = DESKTOP-DELL\\SQLEXPRESS; initial catalog=IM; persist security info=True; Integrated Security = SSPI;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand comd = new SqlCommand("insert into [user] values @user,@password,@conpassword", Connection);
 
            comd.Parameters.AddWithValue("@user", txtusernae.Text);
            comd.Parameters.AddWithValue("@password", txtpassword.Text);
            comd.Parameters.AddWithValue("@conpassword", txtconpass.Text);
            comd.ExecuteNonQuery();
            Connection.Close();
            MessageBox.Show("add the rec has been sussfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand comd = new SqlCommand("Delete [user] where ID=@ID", Connection);
            comd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            comd.ExecuteNonQuery();
            Connection.Close();
            MessageBox.Show("Delete the rec has been sussfully");
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand comd = new SqlCommand("update [user] set User=@user,password=@password where ID=@ID", Connection);
            comd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            comd.Parameters.AddWithValue("@User", txtusernae.Text);
            comd.Parameters.AddWithValue("@password", txtpassword.Text);
            comd.Parameters.AddWithValue("@conpassword", txtconpass.Text);
            comd.ExecuteNonQuery();
            Connection.Close();
            MessageBox.Show("update the rec has been sussfully");
        }

        private void txtusernae_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
