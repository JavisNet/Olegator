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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
            DisplayEvents();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Олег\Documents\SchoolDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayEvents()
        {
            Con.Open();
            string Query = "Select * from EventsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EventsDGV.DataSource = ds.Tables[0];
            Con.Close();
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
        private void Reset()
        {
            EDurationTb.Text = "";
            EDescTb.Text = "";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == "" || EDurationTb.Text == "")
            {
                MessageBox.Show("Недостающая информация!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EventsTbl(EDesc,EDate,EDuration) values (@EvDesc,@EvDate,@EvDur)", Con);
                    cmd.Parameters.AddWithValue("@EvDesc", EDescTb.Text);
                    cmd.Parameters.AddWithValue("@EvDate", EDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EvDur", EDurationTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Событие добавлено!");
                    Con.Close();
                    DisplayEvents();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        int Key = 0;
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Выберите событие!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from EventsTbl where EId= @EKey", Con);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Событие удалено!");
                    Con.Close();
                    DisplayEvents();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EventsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EDescTb.Text = EventsDGV.SelectedRows[0].Cells[1].Value.ToString();
            EDate.Text = EventsDGV.SelectedRows[0].Cells[2].Value.ToString();
            EDurationTb.Text = EventsDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (EDescTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EventsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == "" || EDurationTb.Text == "")
            {
                MessageBox.Show("Недостающая информация!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EventsTbl set EDesc=@EvDesc,EDate=@EvDate,EDuration=@EvDuration where EId=@EKey", Con);
                    cmd.Parameters.AddWithValue("@EvDesc", EDescTb.Text);
                    cmd.Parameters.AddWithValue("@EvDate", EDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EvDuration", EDurationTb.Text);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Событие обновлено!");
                    Con.Close();
                    DisplayEvents();
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
