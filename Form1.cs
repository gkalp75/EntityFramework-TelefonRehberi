using System.Text.RegularExpressions;
using WinFormsApp1.Context;
//using WinFormsApp1.Migrations;
using WinFormsApp1.Models;
using WinFormsApp1.Repository;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kisiRepository = new();
        }

        Kisi Kisi;
        KisiRepository kisiRepository;
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Kisi> kisiler = kisiRepository.GetAll();
            dataGridView1.DataSource = kisiler;
            ButtonSettings(true);
        }

        private void btnRehberEkle_Click(object sender, EventArgs e)
        {
            Kisi = new Kisi();
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || !mtbTelefon.MaskCompleted)
            {
                MessageBox.Show("Tüm bilgileri eksiksiz doldurun");
            }
            else
            {
                Kisi.Ad = txtAd.Text;
                Kisi.Soyad = txtSoyad.Text;
                Kisi.Telefon = mtbTelefon.Text;
                bool isAdded = kisiRepository.Add(Kisi);

                if (isAdded)
                {
                    MessageBox.Show("Kiþi eklendi");
                    ClearTexts();
                    dataGridView1.DataSource = kisiRepository.GetAll();
                }
                else
                {
                    MessageBox.Show("Bir þeyler ters gitti");
                }

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (Kisi is not null)
            {

                Kisi.Ad = txtAd.Text;
                Kisi.Soyad = txtSoyad.Text;
                Kisi.Telefon = mtbTelefon.Text;


                bool isUpdated = kisiRepository.Update(Kisi);

                if (isUpdated)
                {
                    MessageBox.Show("Kiþi güncellendi");
                    ClearTexts();
                    ButtonSettings(true);
                    dataGridView1.DataSource = kisiRepository.GetAll();
                }

                else
                {
                    MessageBox.Show("Güncelleme baþarýsýz. Bir þeyler ters gitti");
                }


            }


        }

        private void btnKisiAra_Click(object sender, EventArgs e)
        {
            List<Kisi> list = kisiRepository.GetKisilerByWord(txtArama.Text);
            dataGridView1.DataSource = list;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex != -1)
            {
                int id = (int)dataGridView1[0, rowIndex].Value;
                Kisi = kisiRepository.GetByID(id);

                txtAd.Text = Kisi.Ad;
                txtSoyad.Text = Kisi.Soyad;
                mtbTelefon.Text = Kisi.Telefon;
                ButtonSettings(false);
            }

            else
            {
                ButtonSettings(true);
                ClearTexts();
            }

        }

        /// <summary>
        /// Form üzerindeki TextBox ve MaskedTextBox'larýn temizlenmesini saðlar.
        /// </summary>
        private void ClearTexts()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }
            }
        }

        private void ButtonSettings(bool set)
        {
            if (set)
            {
                btnRehberEkle.Enabled = true;
                btnGuncelle.Enabled = false;
            }
            else
            {
                btnRehberEkle.Enabled = false;
                btnGuncelle.Enabled = true;
            }
        }

    }
}