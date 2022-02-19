
namespace TelefonRehberUygulamasi
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.adSoyad = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.adSoyadLabel = new System.Windows.Forms.Label();
            this.kaydetBtn = new MaterialSkin.Controls.MaterialButton();
            this.email = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telefonNo = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.telefonNoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adSoyad
            // 
            this.adSoyad.AnimateReadOnly = false;
            this.adSoyad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adSoyad.Depth = 0;
            this.adSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyad.HideSelection = true;
            this.adSoyad.Location = new System.Drawing.Point(116, 84);
            this.adSoyad.MaxLength = 32767;
            this.adSoyad.MouseState = MaterialSkin.MouseState.OUT;
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.PasswordChar = '\0';
            this.adSoyad.ReadOnly = false;
            this.adSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adSoyad.SelectedText = "";
            this.adSoyad.SelectionLength = 0;
            this.adSoyad.SelectionStart = 0;
            this.adSoyad.ShortcutsEnabled = false;
            this.adSoyad.Size = new System.Drawing.Size(255, 39);
            this.adSoyad.TabIndex = 13;
            this.adSoyad.TabStop = false;
            this.adSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adSoyad.UseSystemPasswordChar = false;
            this.adSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adSoyad_KeyPress);
            // 
            // adSoyadLabel
            // 
            this.adSoyadLabel.AutoSize = true;
            this.adSoyadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyadLabel.Location = new System.Drawing.Point(28, 95);
            this.adSoyadLabel.Name = "adSoyadLabel";
            this.adSoyadLabel.Size = new System.Drawing.Size(79, 18);
            this.adSoyadLabel.TabIndex = 12;
            this.adSoyadLabel.Text = "Ad Soyad :";
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.AutoSize = false;
            this.kaydetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kaydetBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.kaydetBtn.Depth = 0;
            this.kaydetBtn.HighEmphasis = true;
            this.kaydetBtn.Icon = global::TelefonRehberUygulamasi.Properties.Resources.kullaniciekle;
            this.kaydetBtn.Location = new System.Drawing.Point(116, 250);
            this.kaydetBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.kaydetBtn.MinimumSize = new System.Drawing.Size(255, 36);
            this.kaydetBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.kaydetBtn.Size = new System.Drawing.Size(255, 36);
            this.kaydetBtn.TabIndex = 14;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.kaydetBtn.UseAccentColor = false;
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // email
            // 
            this.email.AnimateReadOnly = false;
            this.email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.email.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Depth = 0;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.HideSelection = true;
            this.email.Location = new System.Drawing.Point(116, 138);
            this.email.MaxLength = 64;
            this.email.MouseState = MaterialSkin.MouseState.OUT;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.ReadOnly = false;
            this.email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.ShortcutsEnabled = false;
            this.email.Size = new System.Drawing.Size(255, 39);
            this.email.TabIndex = 16;
            this.email.TabStop = false;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email.UseSystemPasswordChar = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailLabel.Location = new System.Drawing.Point(49, 150);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(58, 18);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "E-Mail :";
            // 
            // telefonNo
            // 
            this.telefonNo.AnimateReadOnly = false;
            this.telefonNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.telefonNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.telefonNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telefonNo.Depth = 0;
            this.telefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefonNo.HideSelection = true;
            this.telefonNo.Location = new System.Drawing.Point(116, 192);
            this.telefonNo.MaxLength = 11;
            this.telefonNo.MouseState = MaterialSkin.MouseState.OUT;
            this.telefonNo.Name = "telefonNo";
            this.telefonNo.PasswordChar = '\0';
            this.telefonNo.ReadOnly = false;
            this.telefonNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.telefonNo.SelectedText = "";
            this.telefonNo.SelectionLength = 0;
            this.telefonNo.SelectionStart = 0;
            this.telefonNo.ShortcutsEnabled = false;
            this.telefonNo.Size = new System.Drawing.Size(255, 39);
            this.telefonNo.TabIndex = 18;
            this.telefonNo.TabStop = false;
            this.telefonNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.telefonNo.UseSystemPasswordChar = false;
            this.telefonNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonNo_KeyPress);
            // 
            // telefonNoLabel
            // 
            this.telefonNoLabel.AutoSize = true;
            this.telefonNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefonNoLabel.Location = new System.Drawing.Point(18, 203);
            this.telefonNoLabel.Name = "telefonNoLabel";
            this.telefonNoLabel.Size = new System.Drawing.Size(89, 18);
            this.telefonNoLabel.TabIndex = 17;
            this.telefonNoLabel.Text = "Telefon No :";
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 311);
            this.Controls.Add(this.telefonNo);
            this.Controls.Add(this.telefonNoLabel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.adSoyad);
            this.Controls.Add(this.adSoyadLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 311);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(410, 311);
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kişi Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 adSoyad;
        private System.Windows.Forms.Label adSoyadLabel;
        private MaterialSkin.Controls.MaterialButton kaydetBtn;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 email;
        private System.Windows.Forms.Label emailLabel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 telefonNo;
        private System.Windows.Forms.Label telefonNoLabel;
    }
}