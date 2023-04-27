namespace WinFormsApp1
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
            btnRehberEkle = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            mtbTelefon = new MaskedTextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtArama = new TextBox();
            label5 = new Label();
            btnKisiAra = new Button();
            btnGuncelle = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnRehberEkle
            // 
            btnRehberEkle.Location = new Point(98, 186);
            btnRehberEkle.Name = "btnRehberEkle";
            btnRehberEkle.Size = new Size(124, 33);
            btnRehberEkle.TabIndex = 1;
            btnRehberEkle.Text = "Rehbere Ekle";
            btnRehberEkle.UseVisualStyleBackColor = true;
            btnRehberEkle.Click += btnRehberEkle_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 246);
            label1.Name = "label1";
            label1.Size = new Size(67, 24);
            label1.TabIndex = 2;
            label1.Text = "REHBER";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(mtbTelefon);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(btnRehberEkle);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 225);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Ekleme Paneli";
            // 
            // label4
            // 
            label4.Location = new Point(6, 136);
            label4.Name = "label4";
            label4.Size = new Size(70, 27);
            label4.TabIndex = 7;
            label4.Text = "Telefon";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(6, 87);
            label3.Name = "label3";
            label3.Size = new Size(70, 29);
            label3.TabIndex = 6;
            label3.Text = "Soyad";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 4;
            label2.Text = "Ad";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mtbTelefon
            // 
            mtbTelefon.Location = new Point(82, 134);
            mtbTelefon.Mask = "(999) 000-00-00";
            mtbTelefon.Name = "mtbTelefon";
            mtbTelefon.Size = new Size(140, 29);
            mtbTelefon.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(82, 87);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(140, 29);
            txtSoyad.TabIndex = 4;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(82, 43);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(140, 29);
            txtAd.TabIndex = 2;
            // 
            // txtArama
            // 
            txtArama.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtArama.Location = new Point(331, 78);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(155, 27);
            txtArama.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(331, 29);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 4;
            label5.Text = "Aranacak Ad ve Soyad";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnKisiAra
            // 
            btnKisiAra.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnKisiAra.Location = new Point(354, 133);
            btnKisiAra.Name = "btnKisiAra";
            btnKisiAra.Size = new Size(101, 27);
            btnKisiAra.TabIndex = 5;
            btnKisiAra.Text = "Kişi Ara";
            btnKisiAra.UseVisualStyleBackColor = true;
            btnKisiAra.Click += btnKisiAra_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(331, 204);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(155, 33);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 273);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 100;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(517, 154);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 448);
            Controls.Add(dataGridView1);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKisiAra);
            Controls.Add(label5);
            Controls.Add(txtArama);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRehberEkle;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox mtbTelefon;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtArama;
        private Label label5;
        private Button btnKisiAra;
        private Button btnGuncelle;
        private DataGridView dataGridView1;
    }
}