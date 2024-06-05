using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CURDform
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
       
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           SqlConnection con = new SqlConnection("Data Source=DESKTOP-AKC9V7I;Initial Catalog=FurqanTestDB;Integrated Security=True");

            con.Open();
            string query = "select Marks , SubjectName from Result inner join Subject on Result.SubjectId = Subject.Id where StudentId=@Id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id",int.Parse(comboBox1.SelectedValue.ToString()));

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
           

            dataGridView2.DataSource = dt.DefaultView;

            con.Close();


            

        }

        private void Result_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furqanTestDBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.furqanTestDBDataSet.Student);

        }
    }
}
