using System; 
using System.Text.RegularExpressions; 

namespace TelefonRehberUygulamasi
{
    class Helper
    {
        public string numaraFormat(string numara)
        {
            return String.Format("{0:0 (###) ### ## ##}", Convert.ToInt64(numara));
        }

        public bool telefonFormatKontrol(string Telefon)
        {
            string RegexDesen = @"^(05(\d{9}))$";
            Match Eslesme = Regex.Match(Telefon, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success;
        }

        public bool emailFormatKontrol(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
