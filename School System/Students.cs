using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_System
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            DisplayStudent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Олег\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayStudent()
        {
            Con.Open();
            string Query = "Select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StudentsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || FeesTb.Text == "" || AddresTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Недостающая информация!");
            }
            else
            {
                try
                {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into StudentTbl(StName,StGen,StDOB,StClass,StFees,StAdd) values (@SName,@SGen,@SDob,@SClass,@SFees,@SAdd)", Con);
                cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@SFees", FeesTb.Text);
                cmd.Parameters.AddWithValue("@SAdd", AddresTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ученик добавлен!");
                Con.Close();
                DisplayStudent();
                Reset();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset()
        {
            Key = 0;
            StNameTb.Text = "";
            FeesTb.Text = "";
            AddresTb.Text = "";
            StGenCb.SelectedIndex = 0;
            ClassCb.SelectedIndex = 0;
        }
        int Key = 0;
        private void StudentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StNameTb.Text = StudentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            StGenCb.SelectedItem = StudentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            DOBPicker.Text = StudentsDGV.SelectedRows[0].Cells[3].Value.ToString();
            ClassCb.SelectedItem = StudentsDGV.SelectedRows[0].Cells[4].Value.ToString();
            FeesTb.Text = StudentsDGV.SelectedRows[0].Cells[5].Value.ToString();
            AddresTb.Text = StudentsDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (StNameTb.Text == "" )
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(StudentsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                 MessageBox.Show("Выберите ученика!");
            }
            else
            {
                try
                {
                Con.Open();
                SqlCommand cmd = new SqlCommand("delete from StudentTbl where StId= @StKey", Con);
                cmd.Parameters.AddWithValue("@StKey", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ученик удален!");
                Con.Close();
                DisplayStudent();
                Reset();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || FeesTb.Text == "" || AddresTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Недостающая информация!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update StudentTbl set StName=@SName,StGen=@SGen,StDOB=@SDob,StClass=@SClass,StFees=@SFees,StAdd=@SAdd where StId=@StKey", Con);
                    cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SFees", FeesTb.Text);
                    cmd.Parameters.AddWithValue("@SAdd", AddresTb.Text);
                    cmd.Parameters.AddWithValue("@StKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ученик обновлен!");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
