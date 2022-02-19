using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using MaterialSkin;

namespace TelefonRehberUygulamasi
{
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        public Main()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.EnforceBackcolorOnAllComponents = true;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        } 

        Helper _helper = new Helper();

        static sqlConnection m_Connect = new sqlConnection();
        public SqlCommand sqlCommand;
        public SqlDataReader sqlDataReader;

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            rehberListele();
        }
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            CreateForm kullaniciekle = new CreateForm(this);
            kullaniciekle.ShowDialog();
        }
        private void silBtn_Click(object sender, EventArgs e)
        {
            kisiSil();
        }
        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(this);

            if (dataGridRehber.SelectedCells.Count == 1 || dataGridRehber.SelectedRows.Count == 1)
            {
                int currentRowIndex = dataGridRehber.CurrentRow.Index;
                DataGridViewRow selectedRow = dataGridRehber.Rows[currentRowIndex];


                updateForm.ID = selectedRow.Cells[0].Value.ToString();
                updateForm.adSoyad = selectedRow.Cells[1].Value.ToString();
                updateForm.email = selectedRow.Cells[2].Value.ToString();
                updateForm.telefonNo = selectedRow.Cells[3].Value.ToString();

                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kişi seçilmedi.");
            }
        }

        public void rehberListele()
        {
            try
            {
                sqlCommand = new SqlCommand("Select [Id], [AdSoyad], [Email], [TelefonNo] From Kisiler", m_Connect.DBConnection);
                sqlDataReader = sqlCommand.ExecuteReader();

                dataGridRehber.Rows.Clear();
                arama.Text = "";
                while (sqlDataReader.Read())
                {
                    dataGridRehber.Rows.Add(sqlDataReader.GetInt32(0),
                                            sqlDataReader.GetString(1),
                                            sqlDataReader.GetString(2),
                                            _helper.numaraFormat(sqlDataReader.GetString(3)));
                }
                sqlDataReader.Close();
            }
            catch
            {
                MessageBox.Show("Numaralar alınamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void kisiEkle(string adSoyad, string email, string telefonNo)
        {
            try
            {
                sqlCommand = new SqlCommand("insert into Kisiler(AdSoyad, Email, TelefonNo) values (@AdSoyad,@Email,@TelefonNo)", m_Connect.DBConnection);
                sqlCommand.Parameters.AddWithValue("@AdSoyad", adSoyad.Trim());
                sqlCommand.Parameters.AddWithValue("@Email", email.Trim());
                sqlCommand.Parameters.AddWithValue("@TelefonNo", telefonNo.Trim());
                sqlCommand.ExecuteNonQuery();
                rehberListele();
            }
            catch
            {
                MessageBox.Show("Kişi eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void kisiGuncelle(string ID, string adSoyad, string email, string telefonNo)
        {
            try
            {
                sqlCommand = new SqlCommand("update Kisiler set AdSoyad=@AdSoyad,Email=@Email,TelefonNo=@TelefonNo where ID=@id", m_Connect.DBConnection);
                sqlCommand.Parameters.AddWithValue("@id", ID);
                sqlCommand.Parameters.AddWithValue("@AdSoyad", adSoyad.Trim());
                sqlCommand.Parameters.AddWithValue("@Email", email.Trim());
                sqlCommand.Parameters.AddWithValue("@TelefonNo", telefonNo.Trim());
                sqlCommand.ExecuteNonQuery();
                rehberListele();
            }
            catch
            {
                MessageBox.Show("Kişi güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void kisiSil()
        {
            if (dataGridRehber.SelectedCells.Count == 1 || dataGridRehber.SelectedRows.Count == 1)
            {
                try
                {
                    DialogResult Secim = new DialogResult(); 
                    Secim = MessageBox.Show("Kişiyi silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (Secim == DialogResult.Yes)
                    {
                        int currentRowIndex = dataGridRehber.CurrentRow.Index;
                        sqlCommand = new SqlCommand("delete Kisiler where ID=@id", m_Connect.DBConnection);
                        sqlCommand.Parameters.AddWithValue("@id", dataGridRehber.Rows[currentRowIndex].Cells[0].Value.ToString());
                        sqlCommand.ExecuteNonQuery();
                        rehberListele();
                    } 
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString() + "Kişi silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kişi seçilmedi.");
            }
        }

        private void arama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Kisiler WHERE (AdSoyad like '%" + arama.Text + "%') or (Email like '%" + arama.Text + "%') or (TelefonNo like '%" + arama.Text + "%')", m_Connect.DBConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridRehber.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridRehber.Rows.Add();
                    dataGridRehber.Rows[n].Cells[0].Value = item["ID"].ToString();
                    dataGridRehber.Rows[n].Cells[1].Value = item["AdSoyad"].ToString();
                    dataGridRehber.Rows[n].Cells[2].Value = item["Email"].ToString();
                    dataGridRehber.Rows[n].Cells[3].Value = _helper.numaraFormat(item["TelefonNo"].ToString());
                }
            }
            catch (Exception)
            {
            }

        } 
    }
}
