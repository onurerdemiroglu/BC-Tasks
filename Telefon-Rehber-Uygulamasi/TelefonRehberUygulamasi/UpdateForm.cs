using MaterialSkin;
using System;
using System.Windows.Forms;

namespace TelefonRehberUygulamasi
{
    public partial class UpdateForm : MaterialSkin.Controls.MaterialForm
    {
        private Main _mainForm;
        Helper _helper = new Helper();
        public UpdateForm(Main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.EnforceBackcolorOnAllComponents = true;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public string ID;
        public string adSoyad;
        public string email;
        public string telefonNo;
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            seciliID.Text = Convert.ToString(ID);
            seciliAdSoyad.Text = adSoyad;
            seciliEmail.Text = email;
            seciliTelefon.Text = telefonNo.Replace(" ", "").Replace("(", "").Replace(")", "");
        }
        private void UpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void seciliTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void seciliAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        } 

        private void Guncelle_Click(object sender, EventArgs e)
        {
            if (seciliAdSoyad.Text != "" && _helper.emailFormatKontrol(seciliEmail.Text) && _helper.telefonFormatKontrol(seciliTelefon.Text))
            {
                _mainForm.kisiGuncelle(seciliID.Text, seciliAdSoyad.Text, seciliEmail.Text, seciliTelefon.Text);
                this.Hide();
            }
            else
            {
                if (!_helper.emailFormatKontrol(seciliEmail.Text))
                {
                    MessageBox.Show("Email hatalı. Lütfen kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!_helper.telefonFormatKontrol(seciliTelefon.Text))
                {
                    MessageBox.Show("Telefon numarası hatalı. Lütfen kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Eksik veriler var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 
    }
}
