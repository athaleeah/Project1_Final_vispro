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
    public partial class frm_view_staff : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public frm_view_staff()
        {
            alamat = "server=localhost; database=db_student; username=root; password=12345;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                query = string.Format("insert into tbl_data (`NIM`, `Full_Name`, `Registration_Number`, `Birth_of_Date`, `Address`, `Residence`, `Gender`, `Religion`, `Faculty`, `Major`, `Status_Approval`) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", TxtNIM.Text, TxtNama.Text, TxtNoRegist.Text, TxtTglLahir.Text, TxtAlamat.Text, CBResidence.Text, CBJK.Text, CBAgama.Text, TxtFakultas.Text, TxtProdi.Text, CBStatus.Text);
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data berhasil");
                    frm_view_staff_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Insert data gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void BtnCari_Click(object sender, EventArgs e)
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
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                    frm_view_staff_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("update tbl_data set Status_Approval = '{0}' where NIM ='{1}'", CBStatus.Text, TxtNIM.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                frm_view_staff_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtNIM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_view_staff_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from tbl_data");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[0].HeaderText = "Full Name";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "NIM";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Registration Number";
                dataGridView1.Columns[3].Width = 50;
                dataGridView1.Columns[3].HeaderText = "Birth of Date";
                dataGridView1.Columns[4].Width = 50;
                dataGridView1.Columns[4].HeaderText = "Gender";
                dataGridView1.Columns[5].Width = 50;
                dataGridView1.Columns[5].HeaderText = "Religion";
                dataGridView1.Columns[6].Width = 30;
                dataGridView1.Columns[6].HeaderText = "Address";
                dataGridView1.Columns[7].Width = 100;
                dataGridView1.Columns[7].HeaderText = "Faculty";
                dataGridView1.Columns[8].Width = 100;
                dataGridView1.Columns[8].HeaderText = "Major";
                dataGridView1.Columns[9].Width = 50;
                dataGridView1.Columns[9].HeaderText = "Status Approval";
                dataGridView1.Columns[10].Width = 50;
                dataGridView1.Columns[10].HeaderText = "Residence";

                TxtNIM.Clear();
                TxtNama.Clear();
                TxtAlamat.Clear();
                TxtFakultas.Clear();    
                TxtNoRegist.Clear();
                TxtProdi.Clear();
                TxtTglLahir.Clear();
                CBAgama.Text = string.Empty;
                CBJK.Text = string.Empty;
                CBStatus.Text = string.Empty;
                CBResidence.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
