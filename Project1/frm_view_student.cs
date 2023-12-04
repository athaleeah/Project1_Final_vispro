using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project1
{
    public partial class frm_view_student : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public frm_view_student()
        {
            alamat = "server=localhost; database=db_student; username=root; password=12345;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();

            Form1 form1 = new Form1();
            form1.NilaiDikirimEvent += TerimaNilai;
            form1.Show();
        }

        private void TerimaNilai(string nilaiDiterima)
        {
            TxtNIM.Text = nilaiDiterima;    
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_data where NIM ='{0}'", TxtNIM.Text);
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
                        TxtNama.Text = kolom["Full_Name"].ToString();
                        TxtNoRegist.Text = kolom["Registration_Number"].ToString();
                        TxtProdi.Text = kolom["Major"].ToString();
                        TxtTglLahir.Text = kolom["Birth_of_Date"].ToString();
                        CBJK.Text = kolom["Gender"].ToString();
                        CBAgama.Text = kolom["Religion"].ToString();
                        TxtAlamat.Text = kolom["Address"].ToString();
                        TxtFakultas.Text = kolom["Faculty"].ToString();
                        CBStatus.Text = kolom["Status_Approval"].ToString();
                        CBResidence.Text = kolom["Residence"].ToString();







                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                   frm_view_student_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void frm_view_student_Load(object sender, EventArgs e)
        {
           
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_data where NIM ='{0}'", TxtNIM.Text);
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
                        TxtNama.Text = kolom["Full_Name"].ToString();
                        TxtNoRegist.Text = kolom["Registration_Number"].ToString();
                        TxtTglLahir.Text = kolom["Birth_of_Date"].ToString();
                        TxtAlamat.Text = kolom["Address"].ToString();
                        CBJK.Text = kolom["Gender"].ToString();
                        CBAgama.Text = kolom["Religion"].ToString();
                        TxtFakultas.Text = kolom["Faculty"].ToString();
                        TxtProdi.Text = kolom["Major"].ToString();
                        CBStatus.Text = kolom["Status_Approval"].ToString();
                        CBResidence.Text = kolom["Residence"].ToString();

                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
