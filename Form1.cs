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

namespace CURDform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AKC9V7I;Initial Catalog=FurqanTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Student values(@Id , @Name , @Age)",con);
            cmd.Parameters.AddWithValue("@Id" , int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name" , textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
          

            cleardata();

            
            con.Close();
            MessageBox.Show("successfully inserted");



        }
        private void cleardata()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
           
        }


        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AKC9V7I;Initial Catalog=FurqanTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Student set Name = @Name , Age=@Age where Id=@Id",con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            cleardata();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Student");
            dataGridView1.DataSource = ds;
            con.Close();
            MessageBox.Show("successfully updated");


        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AKC9V7I;Initial Catalog=FurqanTestDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Student where Id=@Id",con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully Deleted");


        }

        private void button4_Click(object sender, EventArgs e)
        {

              SqlConnection con = new SqlConnection("Data Source=DESKTOP-AKC9V7I;Initial Catalog=FurqanTestDB;Integrated Security=True");
              con.Open();
              SqlCommand cmd = new SqlCommand("select * from Student where Id=@Id",con);
              cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
           // object result = cmd.ExecuteScalar();
             cmd.ExecuteNonQuery();
            //  Int32 count = (Int32)cmd.ExecuteScalar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
              da.Fill(ds, "Student");
              dataGridView1.DataSource = ds.Tables["Student"].DefaultView;
            cleardata();
            con.Close();

            /*  SqlConnection con = new SqlConnection("Data Source=DESKTOP-AKC9V7I;Initial Catalog=FurqanTestDB;Integrated Security=True");
              con.Open();

              SqlCommand cmd = new SqlCommand("select * from Student where Id=@Id", con);
              cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));

              cmd.ExecuteNonQuery();
              DataTable dt = new DataTable();
              SqlDataAdapter da = new SqlDataAdapter(cmd);
              da.Fill(dt);

              dataGridView1.DataSource = dt;
              con.Close();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            res.ShowDialog();
        }

        
    }
}
