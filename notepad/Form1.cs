namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            // Varsayýlan dosya adý ve uzantýsý ayarlanýyor
            saveDialog.Filter = "Metin Dosyalarý (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            saveDialog.Title = "Metin Dosyasýný Kaydet";

            // Kullanýcý "Kaydet" butonuna týkladýysa
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Dosyaya yazma iþlemi
                    System.IO.File.WriteAllText(saveDialog.FileName, txtMetinAlani.Text);
                    MessageBox.Show("Dosya baþarýyla kaydedildi.", "Kaydetme Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya kaydedilirken bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {


            // OpenFileDialog nesnesi oluþturuluyor
            OpenFileDialog openDialog = new OpenFileDialog();

            // Sadece metin dosyalarýný filtrele
            openDialog.Filter = "Metin Dosyalarý (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            openDialog.Title = "Metin Dosyasý Aç";

            // Kullanýcý bir dosya seçip "Aç" butonuna týkladýysa
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Dosyadan tüm metni oku ve TextBox'a yerleþtir
                    txtMetinAlani.Text = System.IO.File.ReadAllText(openDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya açýlýrken bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMetinAlani.Text = string.Empty;
        }
    }
}


