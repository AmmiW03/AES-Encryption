using System.Collections.Generic;
using System.Text;

namespace Encriptacion_AES
{
    public partial class Form1 : Form
    {
        private readonly byte[] Key = { 2,5,3,5 };
        List<byte> sentence = new List<byte>();
        List<byte> encrypted = new List<byte>();
        List<byte> decrypted = new List<byte>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            encrypted.Clear();
            txtEncryptedM.Text = String.Empty;
            try
            {
                string encryptedText = EncryptDecrypt(sentence, Key, true);
                txtEncryptedM.Text = encryptedText;
                txtSentence.Text = String.Empty;
                sentence.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cifrar: " + ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            decrypted.Clear();
            txtDecryptedM.Text = String.Empty;
            try
            {
                string decryptedText = EncryptDecrypt(encrypted, Key, false);
                txtDecryptedM.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descifrar: " + ex.Message);
            }
        }

        private string EncryptDecrypt(List<byte> input, byte[] key, bool flag)
        {
            if(flag)
            {
                var outputBytes = new byte[input.Count];

                for (int i = 0; i < input.Count; i++)
                {
                    outputBytes[i] = (byte)(input[i] ^ key[i % key.Length]);
                }
                for (int i = 0; i < outputBytes.Length; i++)
                {
                    encrypted.Add(outputBytes[i]);
                }
                return Encoding.ASCII.GetString(outputBytes);
            }
            else
            {
                decrypted.Clear();   
                txtDecryptedM.Text= String.Empty;
                var outputBytes = new byte[input.Count];

                for (int i = 0; i < input.Count; i++)
                {
                    outputBytes[i] = (byte)(input[i] ^ key[i % key.Length]);
                }
                for(int i = 0; i < outputBytes.Length; i++)
                {
                    decrypted.Add(outputBytes[i]);
                }
                return Encoding.ASCII.GetString(outputBytes);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtSentence.Text = String.Empty;
            txtEncryptedM.Text = String.Empty;
            txtDecryptedM.Text = String.Empty;
            sentence.Clear();
            encrypted.Clear();
            decrypted.Clear();

        }

        private void OnTextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right || e.KeyChar == (char)Keys.Up || e.KeyChar == (char)Keys.Down)
            {
                e.Handled = true;
            }
            if(e.KeyChar == (char)Keys.Back)
            {
                if(sentence.Count > 0)
                {
                    sentence.RemoveAt(sentence.Count - 1);
                }
            }
            else
            {
                String aux = e.KeyChar.ToString();
                sentence.Add(Encoding.ASCII.GetBytes(aux)[0]);
            }
            
        }
    }
}
