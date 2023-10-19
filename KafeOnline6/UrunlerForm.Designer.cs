namespace KafeOnline6
{
    partial class UrunlerForm
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
            txtUrunAd = new TextBox();
            label2 = new Label();
            nudBirimFiyat = new NumericUpDown();
            btnEkle = new Button();
            dgvUrunler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı";
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(12, 38);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(213, 31);
            txtUrunAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 10);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 2;
            label2.Text = "Birim Fiyatı (₺)";
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.Location = new Point(231, 39);
            nudBirimFiyat.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(180, 31);
            nudBirimFiyat.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Location = new Point(417, 36);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 34);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dgvUrunler
            // 
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(12, 76);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowHeadersWidth = 62;
            dgvUrunler.RowTemplate.Height = 33;
            dgvUrunler.Size = new Size(786, 551);
            dgvUrunler.TabIndex = 5;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 639);
            Controls.Add(dgvUrunler);
            Controls.Add(btnEkle);
            Controls.Add(nudBirimFiyat);
            Controls.Add(label2);
            Controls.Add(txtUrunAd);
            Controls.Add(label1);
            Name = "UrunlerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUrunAd;
        private Label label2;
        private NumericUpDown nudBirimFiyat;
        private Button btnEkle;
        private DataGridView dgvUrunler;
    }
}