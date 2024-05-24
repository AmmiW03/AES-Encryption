namespace Encriptacion_AES
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSentence = new TextBox();
            lbl1 = new Label();
            lblTittle = new Label();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            lblEncrypted = new Label();
            txtEncryptedM = new TextBox();
            txtDecryptedM = new TextBox();
            lblDecrypted = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtSentence
            // 
            txtSentence.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSentence.Location = new Point(46, 146);
            txtSentence.Name = "txtSentence";
            txtSentence.Size = new Size(224, 21);
            txtSentence.TabIndex = 0;
            txtSentence.KeyPress += OnTextChanged;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(46, 106);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(224, 18);
            lbl1.TabIndex = 1;
            lbl1.Text = "Ingrese el mensaje a cifrar";
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTittle.Location = new Point(32, 32);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(254, 32);
            lblTittle.TabIndex = 2;
            lblTittle.Text = "ENCRIPTACIÓN AES";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(46, 188);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(75, 23);
            btnEncrypt.TabIndex = 3;
            btnEncrypt.Text = "Encriptar";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(185, 188);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(85, 23);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.Text = "Desencriptar";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // lblEncrypted
            // 
            lblEncrypted.AutoSize = true;
            lblEncrypted.Location = new Point(114, 248);
            lblEncrypted.Name = "lblEncrypted";
            lblEncrypted.Size = new Size(91, 15);
            lblEncrypted.TabIndex = 5;
            lblEncrypted.Text = "Mensaje cifrado";
            // 
            // txtEncryptedM
            // 
            txtEncryptedM.Enabled = false;
            txtEncryptedM.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEncryptedM.Location = new Point(46, 266);
            txtEncryptedM.Name = "txtEncryptedM";
            txtEncryptedM.Size = new Size(224, 21);
            txtEncryptedM.TabIndex = 6;
            // 
            // txtDecryptedM
            // 
            txtDecryptedM.Enabled = false;
            txtDecryptedM.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDecryptedM.Location = new Point(46, 331);
            txtDecryptedM.Name = "txtDecryptedM";
            txtDecryptedM.Size = new Size(224, 21);
            txtDecryptedM.TabIndex = 8;
            // 
            // lblDecrypted
            // 
            lblDecrypted.AutoSize = true;
            lblDecrypted.Location = new Point(105, 313);
            lblDecrypted.Name = "lblDecrypted";
            lblDecrypted.Size = new Size(109, 15);
            lblDecrypted.TabIndex = 7;
            lblDecrypted.Text = "Mensaje descifrado";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(105, 385);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Borrar mensajes";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 436);
            Controls.Add(btnDelete);
            Controls.Add(txtDecryptedM);
            Controls.Add(lblDecrypted);
            Controls.Add(txtEncryptedM);
            Controls.Add(lblEncrypted);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(lblTittle);
            Controls.Add(lbl1);
            Controls.Add(txtSentence);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Seguridad de la información";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSentence;
        private Label lbl1;
        private Label lblTittle;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Label lblEncrypted;
        private TextBox txtEncryptedM;
        private TextBox txtDecryptedM;
        private Label lblDecrypted;
        private Button btnDelete;
    }
}
