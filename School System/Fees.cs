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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
            DisplayFees();
            FillStudId();
            GetStudName();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Олег\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayFees()
        {
            Con.Open();
            string Query = "Select * from FeesTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FeesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FillStudId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select StId from StudentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StId", typeof(int));
            dt.Load(rdr);
            StIdCb.ValueMember = "StId";
            StIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetStudName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentTbl where StId=@StKey", Con);
            cmd.Parameters.AddWithValue("StKey", StIdCb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StNameTb.Text = dr["StName"].ToString();

            }
            Con.Close();
        }
        private void Reset()
        {
            AmountTb.Text = "";
            StNameTb.Text = "";
            StIdCb.SelectedIndex = -1;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Недостающая информация!");
            }
            else
            {
                string paymentperiode;
                paymentperiode = PeriodDate.Value.Month.ToString() + "/" + PeriodDate.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from FeesTbl where StId = '" + StIdCb.SelectedValue.ToString() + "' and Month = '" + paymentperiode.ToString() + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("В этом месяце нет никакой задолженности!");
                }
                else
                {
                    //Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into FeesTbl(StId,StName,Month,Amt) values (@SKey,@SName,@Month,@Amt)", Con);
                    cmd.Parameters.AddWithValue("@SKey", StIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@Month", paymentperiode);
                    cmd.Parameters.AddWithValue("@Amt", AmountTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Оплата прошла успешно!");
                }
                Con.Close();
                DisplayFees();
                Reset();
            }
        }

        private void StIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }
    }
}
