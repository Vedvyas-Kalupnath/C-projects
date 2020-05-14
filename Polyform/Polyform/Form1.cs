using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Polyform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection cnn = new SqlConnection(Connectionstring);
            SqlCommand cmd = new SqlCommand(" insert dbo.StudentDetail (StudentID,FirstName,LastName,Address,City) values(@StudentID,@firstname,@lastname,@address,@city)", cnn);
            cnn.Open();
            SqlParameter param = new SqlParameter();
            cmd.Parameters.AddWithValue("@firstname", textBox2.Text);
            cmd.Parameters.AddWithValue("@lastname", textBox3.Text);
            cmd.Parameters.AddWithValue("@address", textBox4.Text);
            cmd.Parameters.AddWithValue("@city", textBox5.Text);
            cmd.Parameters.AddWithValue("@StudentID", textBox1.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();


            if ((string.IsNullOrEmpty(textBox1.Text)) && (string.IsNullOrEmpty(textBox2.Text)) && (string.IsNullOrEmpty(textBox3.Text)) && (string.IsNullOrEmpty(textBox4.Text)) && (string.IsNullOrEmpty(textBox5.Text)))
            {

                MessageBox.Show("Fields are missing");

            }

            else

            if (string.IsNullOrEmpty(textBox1.Text))

            {
                MessageBox.Show("StudentID must be filled");

            }

            else
            if (string.IsNullOrEmpty(textBox2.Text))

            {
                MessageBox.Show("FirstName must be filled");
            }

            else
            if (string.IsNullOrEmpty(textBox3.Text))

            {
                MessageBox.Show("LastName must be filled");
            }

            else
            if (string.IsNullOrEmpty(textBox4.Text))

            {
                MessageBox.Show("Address must be filled");
            }

            else
            if (string.IsNullOrEmpty(textBox5.Text))

            {
                MessageBox.Show("City must be filled");
            }


            else
            {

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StudentDetail", cnn);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;


                MessageBox.Show("Record Inserted Successfully");

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection cnn = new SqlConnection(Connectionstring);
            SqlCommand cmd = new SqlCommand("UPDATE dbo.StudentDetail SET firstname = @firstname, lastname = @lastname, address = @address, city = @city  WHERE StudentID = @StudentID", cnn);
            cnn.Open();
            SqlParameter param = new SqlParameter();
            cmd.Parameters.AddWithValue("@StudentID", textBox1.Text);
            cmd.Parameters.AddWithValue("@firstname", textBox2.Text);
            cmd.Parameters.AddWithValue("@lastname", textBox3.Text);
            cmd.Parameters.AddWithValue("@address", textBox4.Text);
            cmd.Parameters.AddWithValue("@city", textBox5.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();


            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StudentDetail", cnn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;

            MessageBox.Show("Record Updated Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection cnn = new SqlConnection(Connectionstring);

            SqlCommand cmd = new SqlCommand("Delete from dbo.StudentDetail Where StudentID = @StudentID", cnn);
            cnn.Open();
            SqlParameter param = new SqlParameter();
            cmd.Parameters.AddWithValue("@StudentID", textBox1.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();


            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StudentDetail", cnn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;


            MessageBox.Show("Record deleted Successfully");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection cnn = new SqlConnection(Connectionstring);
            cnn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StudentDetail", cnn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            cnn.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
