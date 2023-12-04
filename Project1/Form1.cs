using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project1
{
   
    public partial class Form1 : Form
    {
        public event Action<string> NilaiDikirimEvent;
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Form1()
        {
            alamat = "server=localhost; database=db_student; username=root; password=12345;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_data where `Registration_Number` ='{0}' AND `password` = '{1}'", TxtUsername.Text, TxtPassword.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        LblLevel.Text = kolom["level"].ToString();
                        LblNIM.Text = kolom["Registration_Number"].ToString();
                        if (LblLevel.Text == "1")
                        {
                            frm_view_staff frm_Staff = new frm_view_staff();
                            frm_Staff.Show();
                            this.Hide();
                        }
                        else
                        {
                            string nilaiDikirim = kolom["NIM"].ToString();
                            
                            NilaiDikirimEvent?.Invoke(nilaiDikirim);                        
                            frm_view_student frm_Student = new frm_view_student();
                            
                            frm_Student.Show();
                           // this.Hide();
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                    Form1_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
