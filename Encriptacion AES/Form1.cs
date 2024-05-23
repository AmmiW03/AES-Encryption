using System.Text;

namespace Encriptacion_AES
{
    public partial class Form1 : Form
    {
        private static readonly string Key = "llaveSuperSegura";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = txtSentence.Text;
            if (string.IsNullOrWhiteSpace(plainText))
            {
                MessageBox.Show("Ingrese un mensaje para cifrar.");
                return;
            }

            try
            {
                string encryptedText = EncryptDecrypt(plainText, Key);
                txtEncryptedM.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(encryptedText));
                txtSentence.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cifrar: " + ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedText = txtEncryptedM.Text;
            if (string.IsNullOrWhiteSpace(encryptedText))
            {
                MessageBox.Show("Ingrese un mensaje cifrado para descifrar.");
                return;
            }

            try
            {
                encryptedText = Encoding.UTF8.GetString(Convert.FromBase64String(encryptedText)); // Convertir de Base64 a cadena
                string decryptedText = EncryptDecrypt(encryptedText, Key);
                txtDecryptedM.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descifrar: " + ex.Message);
            }
        }

        private string EncryptDecrypt(string input, string key)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var keyBytes = Encoding.UTF8.GetBytes(key);
            var outputBytes = new byte[inputBytes.Length];

            for (int i = 0; i < inputBytes.Length; i++)
            {
                outputBytes[i] = (byte)(inputBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            return Encoding.UTF8.GetString(outputBytes);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtEncryptedM.Text = String.Empty;
            txtDecryptedM.Text = String.Empty;
        }
    }
}
