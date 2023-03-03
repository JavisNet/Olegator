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
using System.Windows.Input;

namespace School_System
{
    public partial class Attendances : Form
    {
        public Attendances()
        {
            InitializeComponent();
            DisplayAttendance();
            FillStudId();
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
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Олег\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayAttendance()
        {
            Con.Open();
            string Query = "Select * from AttendanceTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendancesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            AttStatusCb.SelectedIndex = -1;
            StNameTb.Text = "";
            StIdCb.SelectedIndex = -1;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || AttStatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Недостающая информация!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AttendanceTbl(AttStId,AttStName,AttDate,AttStatus) values (@StId,@StName,@AttDate,@Status)", Con);
                    cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@AttDate", AttDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", AttStatusCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Сведения об успеваемости внесены!");
                    Con.Close();
                    DisplayAttendance();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void StIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите учителя!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AttendanceTbl where AttNum= @ANum", Con);
                    cmd.Parameters.AddWithValue("@ANum", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Свденения удалены!");
                    Con.Close();
                    DisplayAttendance();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void AttendancesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StIdCb.SelectedValue = AttendancesDGV.SelectedRows[0].Cells[1].Value.ToString();
            StNameTb.Text = AttendancesDGV.SelectedRows[0].Cells[2].Value.ToString();
            AttDate.Text = AttendancesDGV.SelectedRows[0].Cells[3].Value.ToString();
            AttStatusCb.SelectedItem = AttendancesDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (StNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AttendancesDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if  (StNameTb.Text == "" || AttStatusCb.SelectedIndex == -1)
            {
                MessageBox.Show("Недостающая информация!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AttendanceTbl set AttStId=@StId,AttStName=@StName,AttDate=@ADate,AttStatus=@AStatus where AttNum=@ANum", Con);
                    cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@ADate", AttDate.Value.Date);
                    cmd.Parameters.AddWithValue("@AStatus", AttStatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ANum", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Сведения обновлены!");
                    Con.Close();
                    DisplayAttendance();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
