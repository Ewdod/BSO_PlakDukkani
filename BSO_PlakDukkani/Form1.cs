using BSO_PlakDukkani.Concrets;

namespace BSO_PlakDukkani
{
    public partial class Form1 : Form
    {
        PlakDukkaniContext _db = new PlakDukkaniContext();
        Hash hash = new Hash();

        public Form1()
        {
            InitializeComponent();



        }

        private void button3_Click(object sender, EventArgs e)
        {

            Modul adminModul = new Modul();

            if (txtPwd.Text != txtRePassword.Text)
            {
                MessageBox.Show("�ifreler Uyu�muyor.");
            }
            else
            {
                if (txtPwd.Text.Length >= 8 &&
                    txtPwd.Text.Any(char.IsUpper) &&
                    txtPwd.Text.Count(char.IsLower) >= 2 &&
                    txtPwd.Text.Any(char.IsDigit) &&
                    txtPwd.Text.Count(c => "!:+*".Contains(c)) >= 2)
                {
                    adminModul.KullaniciAdi = txtUserName.Text;
                    string hashliSifre = hash.sha256_hash(txtPwd.Text);
                    adminModul.Sifre = hashliSifre;
                    _db.Moduls.Add(adminModul);
                    MessageBox.Show("Ba�ar�yla Kay�t oldunuz.");
                    _db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("�ifre kriterlerine uymuyor. L�tfen �ifrenizi kontrol edin.");
                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sifre = hash.sha256_hash(txtLoginPwd.Text);

            var modul = _db.Moduls.FirstOrDefault(x => x.KullaniciAdi == txtLoginUsername.Text && x.Sifre == sifre);
            if (modul != null)
            {
                MessageBox.Show("Ba�ar�yla giri� yapt�n�z.");
                MainMenu m1 = new MainMenu(modul);
                this.Hide();
                m1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullan�c� bulunamad�.");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Info i = new Info();
            i.ShowDialog();
        }
    }
}