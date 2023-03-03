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

namespace School_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Олег\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CountStudent()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from StudentTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountTeachers()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from TeacherTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountEvents()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from EventsTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ELbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void SumFees()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(Amt) from FeesTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            FeesLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountStudent();
            CountTeachers();
            CountEvents();
            SumFees();
        }
    }
}
