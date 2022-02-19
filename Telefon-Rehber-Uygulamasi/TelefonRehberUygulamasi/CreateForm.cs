using MaterialSkin;
using System;
using System.Windows.Forms;

namespace TelefonRehberUygulamasi
{
    public partial class CreateForm : MaterialSkin.Controls.MaterialForm
    {
        private Main _mainForm;
        Helper _helper = new Helper();
        public CreateForm(Main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.EnforceBackcolorOnAllComponents = true;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
         
        private void CreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        } 
        private void telefonNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        } 
        private void adSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        } 

        private void Kaydet_Click(object sender, EventArgs e)
        {
            if (adSoyad.Text != "" && _helper.emailFormatKontrol(email.Text) && _helper.telefonFormatKontrol(telefonNo.Text))
            {
                _mainForm.kisiEkle(adSoyad.Text, email.Text, telefonNo.Text);
                this.Hide(); 
            }
            else
            {
                if (!_helper.emailFormatKontrol(email.Text))
                {
                    MessageBox.Show("Email hatalı. Lütfen kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!_helper.telefonFormatKontrol(telefonNo.Text))
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
