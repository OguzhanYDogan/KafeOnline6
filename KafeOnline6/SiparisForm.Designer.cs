namespace KafeOnline6
{
    partial class SiparisForm
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
            label1 = new Label();
            cboUrun = new ComboBox();
            label2 = new Label();
            nudAdet = new NumericUpDown();
            btnDetayEkle = new Button();
            dgvDetaylar = new DataGridView();
            cboMasaNo = new ComboBox();
            label3 = new Label();
            btnMasaTasi = new Button();
            label4 = new Label();
            btnSiparisIptal = new Button();
            btnOdemeAl = new Button();
            btnAnasayfayaDon = new Button();
            lblMasaNo = new Label();
            lblOdemeTutari = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // cboUrun
            // 
            cboUrun.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUrun.FormattingEnabled = true;
            cboUrun.Location = new Point(12, 47);
            cboUrun.Name = "cboUrun";
            cboUrun.Size = new Size(280, 33);
            cboUrun.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 17);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 1;
            label2.Text = "Adet";
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(298, 47);
            nudAdet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(82, 31);
            nudAdet.TabIndex = 3;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDetayEkle
            // 
            btnDetayEkle.Location = new Point(386, 47);
            btnDetayEkle.Name = "btnDetayEkle";
            btnDetayEkle.Size = new Size(135, 31);
            btnDetayEkle.TabIndex = 4;
            btnDetayEkle.Text = "EKLE";
            btnDetayEkle.UseVisualStyleBackColor = true;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Location = new Point(12, 113);
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.RowHeadersWidth = 62;
            dgvDetaylar.RowTemplate.Height = 33;
            dgvDetaylar.Size = new Size(592, 536);
            dgvDetaylar.TabIndex = 8;
            // 
            // cboMasaNo
            // 
            cboMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboMasaNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMasaNo.FormattingEnabled = true;
            cboMasaNo.Location = new Point(639, 45);
            cboMasaNo.Name = "cboMasaNo";
            cboMasaNo.Size = new Size(182, 33);
            cboMasaNo.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(639, 17);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 5;
            label3.Text = "Masa No:";
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Location = new Point(831, 43);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(112, 34);
            btnMasaTasi.TabIndex = 7;
            btnMasaTasi.Text = "TAŞI";
            btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(662, 408);
            label4.Name = "label4";
            label4.Size = new Size(182, 38);
            label4.TabIndex = 10;
            label4.Text = "Ödeme Tutarı: ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSiparisIptal
            // 
            btnSiparisIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiparisIptal.BackColor = Color.Maroon;
            btnSiparisIptal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisIptal.ForeColor = Color.White;
            btnSiparisIptal.Location = new Point(639, 499);
            btnSiparisIptal.Name = "btnSiparisIptal";
            btnSiparisIptal.Size = new Size(145, 67);
            btnSiparisIptal.TabIndex = 12;
            btnSiparisIptal.Text = "SİPARİŞ İPTAL";
            btnSiparisIptal.UseVisualStyleBackColor = false;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.BackColor = Color.Green;
            btnOdemeAl.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnOdemeAl.ForeColor = Color.White;
            btnOdemeAl.Location = new Point(798, 499);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(145, 67);
            btnOdemeAl.TabIndex = 13;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnAnasayfayaDon
            // 
            btnAnasayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnasayfayaDon.BackColor = Color.Gold;
            btnAnasayfayaDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnasayfayaDon.ForeColor = Color.SaddleBrown;
            btnAnasayfayaDon.Location = new Point(639, 572);
            btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            btnAnasayfayaDon.Size = new Size(304, 74);
            btnAnasayfayaDon.TabIndex = 14;
            btnAnasayfayaDon.Text = "ANASAYFAYA DÖN";
            btnAnasayfayaDon.UseVisualStyleBackColor = false;
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.Tomato;
            lblMasaNo.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaNo.ForeColor = Color.WhiteSmoke;
            lblMasaNo.Location = new Point(639, 113);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(304, 231);
            lblMasaNo.TabIndex = 9;
            lblMasaNo.Text = "00";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.AutoSize = true;
            lblOdemeTutari.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblOdemeTutari.Location = new Point(831, 412);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(66, 30);
            lblOdemeTutari.TabIndex = 11;
            lblOdemeTutari.Text = "₺0,00";
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 663);
            Controls.Add(lblOdemeTutari);
            Controls.Add(lblMasaNo);
            Controls.Add(btnAnasayfayaDon);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnSiparisIptal);
            Controls.Add(label4);
            Controls.Add(btnMasaTasi);
            Controls.Add(label3);
            Controls.Add(cboMasaNo);
            Controls.Add(dgvDetaylar);
            Controls.Add(btnDetayEkle);
            Controls.Add(nudAdet);
            Controls.Add(label2);
            Controls.Add(cboUrun);
            Controls.Add(label1);
            MinimumSize = new Size(900, 680);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Masa 3";
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboUrun;
        private Label label2;
        private NumericUpDown nudAdet;
        private Button btnDetayEkle;
        private DataGridView dgvDetaylar;
        private ComboBox cboMasaNo;
        private Label label3;
        private Button btnMasaTasi;
        private Label label4;
        private Button btnSiparisIptal;
        private Button btnOdemeAl;
        private Button btnAnasayfayaDon;
        private Label lblMasaNo;
        private Label lblOdemeTutari;
    }
}