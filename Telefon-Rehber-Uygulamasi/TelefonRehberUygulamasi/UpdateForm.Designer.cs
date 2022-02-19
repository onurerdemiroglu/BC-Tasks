
namespace TelefonRehberUygulamasi
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.idLabel = new MaterialSkin.Controls.MaterialLabel();
            this.adSoyadLabel = new MaterialSkin.Controls.MaterialLabel();
            this.emailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.telefonNoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.seciliID = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.seciliAdSoyad = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.seciliEmail = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.seciliTelefon = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.guncelle = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Depth = 0;
            this.idLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idLabel.Location = new System.Drawing.Point(84, 94);
            this.idLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 19);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "ID :";
            // 
            // adSoyadLabel
            // 
            this.adSoyadLabel.AutoSize = true;
            this.adSoyadLabel.Depth = 0;
            this.adSoyadLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.adSoyadLabel.Location = new System.Drawing.Point(31, 137);
            this.adSoyadLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.adSoyadLabel.Name = "adSoyadLabel";
            this.adSoyadLabel.Size = new System.Drawing.Size(77, 19);
            this.adSoyadLabel.TabIndex = 17;
            this.adSoyadLabel.Text = "Ad Soyad :";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Depth = 0;
            this.emailLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailLabel.Location = new System.Drawing.Point(55, 182);
            this.emailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 19);
            this.emailLabel.TabIndex = 18;
            this.emailLabel.Text = "E-Mail :";
            // 
            // telefonNoLabel
            // 
            this.telefonNoLabel.AutoSize = true;
            this.telefonNoLabel.Depth = 0;
            this.telefonNoLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.telefonNoLabel.Location = new System.Drawing.Point(21, 221);
            this.telefonNoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.telefonNoLabel.Name = "telefonNoLabel";
            this.telefonNoLabel.Size = new System.Drawing.Size(87, 19);
            this.telefonNoLabel.TabIndex = 19;
            this.telefonNoLabel.Text = "Telefon No :";
            // 
            // seciliID
            // 
            this.seciliID.AnimateReadOnly = false;
            this.seciliID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seciliID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.seciliID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.seciliID.Depth = 0;
            this.seciliID.Enabled = false;
            this.seciliID.HideSelection = true;
            this.seciliID.Location = new System.Drawing.Point(125, 86);
            this.seciliID.MaxLength = 32767;
            this.seciliID.MouseState = MaterialSkin.MouseState.OUT;
            this.seciliID.Name = "seciliID";
            this.seciliID.PasswordChar = '\0';
            this.seciliID.ReadOnly = false;
            this.seciliID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seciliID.SelectedText = "";
            this.seciliID.SelectionLength = 0;
            this.seciliID.SelectionStart = 0;
            this.seciliID.ShortcutsEnabled = true;
            this.seciliID.Size = new System.Drawing.Size(258, 36);
            this.seciliID.TabIndex = 20;
            this.seciliID.TabStop = false;
            this.seciliID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.seciliID.UseSystemPasswordChar = false;
            // 
            // seciliAdSoyad
            // 
            this.seciliAdSoyad.AnimateReadOnly = false;
            this.seciliAdSoyad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seciliAdSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.seciliAdSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.seciliAdSoyad.Depth = 0;
            this.seciliAdSoyad.HideSelection = true;
            this.seciliAdSoyad.Location = new System.Drawing.Point(125, 128);
            this.seciliAdSoyad.MaxLength = 32767;
            this.seciliAdSoyad.MouseState = MaterialSkin.MouseState.OUT;
            this.seciliAdSoyad.Name = "seciliAdSoyad";
            this.seciliAdSoyad.PasswordChar = '\0';
            this.seciliAdSoyad.ReadOnly = false;
            this.seciliAdSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seciliAdSoyad.SelectedText = "";
            this.seciliAdSoyad.SelectionLength = 0;
            this.seciliAdSoyad.SelectionStart = 0;
            this.seciliAdSoyad.ShortcutsEnabled = true;
            this.seciliAdSoyad.Size = new System.Drawing.Size(258, 36);
            this.seciliAdSoyad.TabIndex = 21;
            this.seciliAdSoyad.TabStop = false;
            this.seciliAdSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.seciliAdSoyad.UseSystemPasswordChar = false;
            this.seciliAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.seciliAdSoyad_KeyPress);
            // 
            // seciliEmail
            // 
            this.seciliEmail.AnimateReadOnly = false;
            this.seciliEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seciliEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.seciliEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.seciliEmail.Depth = 0;
            this.seciliEmail.HideSelection = true;
            this.seciliEmail.Location = new System.Drawing.Point(125, 170);
            this.seciliEmail.MaxLength = 64;
            this.seciliEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.seciliEmail.Name = "seciliEmail";
            this.seciliEmail.PasswordChar = '\0';
            this.seciliEmail.ReadOnly = false;
            this.seciliEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seciliEmail.SelectedText = "";
            this.seciliEmail.SelectionLength = 0;
            this.seciliEmail.SelectionStart = 0;
            this.seciliEmail.ShortcutsEnabled = true;
            this.seciliEmail.Size = new System.Drawing.Size(258, 36);
            this.seciliEmail.TabIndex = 22;
            this.seciliEmail.TabStop = false;
            this.seciliEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.seciliEmail.UseSystemPasswordChar = false;
            // 
            // seciliTelefon
            // 
            this.seciliTelefon.AnimateReadOnly = false;
            this.seciliTelefon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seciliTelefon.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.seciliTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.seciliTelefon.Depth = 0;
            this.seciliTelefon.HideSelection = true;
            this.seciliTelefon.Location = new System.Drawing.Point(125, 212);
            this.seciliTelefon.MaxLength = 11;
            this.seciliTelefon.MouseState = MaterialSkin.MouseState.OUT;
            this.seciliTelefon.Name = "seciliTelefon";
            this.seciliTelefon.PasswordChar = '\0';
            this.seciliTelefon.ReadOnly = false;
            this.seciliTelefon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seciliTelefon.SelectedText = "";
            this.seciliTelefon.SelectionLength = 0;
            this.seciliTelefon.SelectionStart = 0;
            this.seciliTelefon.ShortcutsEnabled = true;
            this.seciliTelefon.Size = new System.Drawing.Size(258, 36);
            this.seciliTelefon.TabIndex = 23;
            this.seciliTelefon.TabStop = false;
            this.seciliTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.seciliTelefon.UseSystemPasswordChar = false;
            this.seciliTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.seciliTelefon_KeyPress);
            // 
            // guncelle
            // 
            this.guncelle.AutoSize = false;
            this.guncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guncelle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.guncelle.Depth = 0;
            this.guncelle.HighEmphasis = true;
            this.guncelle.Icon = null;
            this.guncelle.Location = new System.Drawing.Point(125, 270);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guncelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.guncelle.Name = "guncelle";
            this.guncelle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.guncelle.Size = new System.Drawing.Size(258, 36);
            this.guncelle.TabIndex = 24;
            this.guncelle.Text = "Güncelle";
            this.guncelle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.guncelle.UseAccentColor = false;
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 338);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.seciliTelefon);
            this.Controls.Add(this.seciliEmail);
            this.Controls.Add(this.seciliAdSoyad);
            this.Controls.Add(this.seciliID);
            this.Controls.Add(this.telefonNoLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.adSoyadLabel);
            this.Controls.Add(this.idLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(432, 338);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(432, 338);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kişi Güncelle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel idLabel;
        private MaterialSkin.Controls.MaterialLabel adSoyadLabel;
        private MaterialSkin.Controls.MaterialLabel emailLabel;
        private MaterialSkin.Controls.MaterialLabel telefonNoLabel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 seciliID;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 seciliAdSoyad;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 seciliEmail;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 seciliTelefon;
        private MaterialSkin.Controls.MaterialButton guncelle;
    }
}