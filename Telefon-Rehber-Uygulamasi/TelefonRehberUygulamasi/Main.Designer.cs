
namespace TelefonRehberUygulamasi
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridRehber = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.arama = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.listeleBtn = new MaterialSkin.Controls.MaterialButton();
            this.ekleBtn = new MaterialSkin.Controls.MaterialButton();
            this.guncelleBtn = new MaterialSkin.Controls.MaterialButton();
            this.silBtn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRehber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRehber
            // 
            this.dataGridRehber.AllowUserToAddRows = false;
            this.dataGridRehber.AllowUserToDeleteRows = false;
            this.dataGridRehber.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRehber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRehber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRehber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AdSoyad,
            this.Email,
            this.TelefonNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRehber.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRehber.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridRehber.Location = new System.Drawing.Point(19, 133);
            this.dataGridRehber.MultiSelect = false;
            this.dataGridRehber.Name = "dataGridRehber";
            this.dataGridRehber.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridRehber.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridRehber.Size = new System.Drawing.Size(774, 328);
            this.dataGridRehber.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 50;
            // 
            // AdSoyad
            // 
            this.AdSoyad.HeaderText = "Ad Soyad";
            this.AdSoyad.Name = "AdSoyad";
            this.AdSoyad.ReadOnly = true;
            this.AdSoyad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AdSoyad.Width = 230;
            // 
            // Email
            // 
            this.Email.HeaderText = "EMail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Width = 250;
            // 
            // TelefonNo
            // 
            this.TelefonNo.HeaderText = "Telefon No";
            this.TelefonNo.Name = "TelefonNo";
            this.TelefonNo.ReadOnly = true;
            this.TelefonNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TelefonNo.Width = 199;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(577, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arama :";
            // 
            // arama
            // 
            this.arama.AnimateReadOnly = false;
            this.arama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.arama.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.arama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.arama.Depth = 0;
            this.arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama.HideSelection = true;
            this.arama.Location = new System.Drawing.Point(642, 80);
            this.arama.MaxLength = 32767;
            this.arama.MouseState = MaterialSkin.MouseState.OUT;
            this.arama.Name = "arama";
            this.arama.PasswordChar = '\0';
            this.arama.ReadOnly = false;
            this.arama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.arama.SelectedText = "";
            this.arama.SelectionLength = 0;
            this.arama.SelectionStart = 0;
            this.arama.ShortcutsEnabled = true;
            this.arama.Size = new System.Drawing.Size(151, 39);
            this.arama.TabIndex = 11;
            this.arama.TabStop = false;
            this.arama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.arama.UseSystemPasswordChar = false;
            this.arama.TextChanged += new System.EventHandler(this.arama_TextChanged);
            // 
            // listeleBtn
            // 
            this.listeleBtn.AutoSize = false;
            this.listeleBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listeleBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.listeleBtn.Depth = 0;
            this.listeleBtn.HighEmphasis = true;
            this.listeleBtn.Icon = global::TelefonRehberUygulamasi.Properties.Resources.list;
            this.listeleBtn.Location = new System.Drawing.Point(19, 83);
            this.listeleBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.listeleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.listeleBtn.Size = new System.Drawing.Size(122, 36);
            this.listeleBtn.TabIndex = 12;
            this.listeleBtn.Text = "Listele";
            this.listeleBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.listeleBtn.UseAccentColor = false;
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
            // 
            // ekleBtn
            // 
            this.ekleBtn.AutoSize = false;
            this.ekleBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ekleBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ekleBtn.Depth = 0;
            this.ekleBtn.HighEmphasis = true;
            this.ekleBtn.Icon = global::TelefonRehberUygulamasi.Properties.Resources.kullaniciekle;
            this.ekleBtn.Location = new System.Drawing.Point(149, 83);
            this.ekleBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ekleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ekleBtn.Size = new System.Drawing.Size(122, 36);
            this.ekleBtn.TabIndex = 13;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ekleBtn.UseAccentColor = false;
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.AutoSize = false;
            this.guncelleBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guncelleBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.guncelleBtn.Depth = 0;
            this.guncelleBtn.HighEmphasis = true;
            this.guncelleBtn.Icon = global::TelefonRehberUygulamasi.Properties.Resources.kullaniciguncelle;
            this.guncelleBtn.Location = new System.Drawing.Point(279, 83);
            this.guncelleBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guncelleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.guncelleBtn.Size = new System.Drawing.Size(122, 36);
            this.guncelleBtn.TabIndex = 14;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.guncelleBtn.UseAccentColor = false;
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.AutoSize = false;
            this.silBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.silBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.silBtn.Depth = 0;
            this.silBtn.HighEmphasis = true;
            this.silBtn.Icon = global::TelefonRehberUygulamasi.Properties.Resources.kullanicisil;
            this.silBtn.Location = new System.Drawing.Point(409, 83);
            this.silBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.silBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.silBtn.Name = "silBtn";
            this.silBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.silBtn.Size = new System.Drawing.Size(122, 36);
            this.silBtn.TabIndex = 15;
            this.silBtn.Text = "Sil";
            this.silBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.silBtn.UseAccentColor = false;
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 476);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.arama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridRehber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 476);
            this.MinimumSize = new System.Drawing.Size(815, 476);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Rehber Uygulaması";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRehber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRehber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonNo;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 arama;
        private MaterialSkin.Controls.MaterialButton listeleBtn;
        private MaterialSkin.Controls.MaterialButton ekleBtn;
        private MaterialSkin.Controls.MaterialButton guncelleBtn;
        private MaterialSkin.Controls.MaterialButton silBtn;
    }
}

