using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001form2dogru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kitap k = new Kitap();
            k.KitapAdi = txtKitapAdi.Text;
            k.Yazar = txtYazar.Text;
            k.ISBN = txtISBN.Text;
            k.Turu = txtTuru.Text;
            k.YayinEvi = txtYayinEvi.Text;
            k.YayinTarihi = dateTimePicker1.Value;
            //k.SayfaSayisi = (int)numericUpDown1.Value;
            k.SayfaSayisi = Convert.ToInt32(numericUpDown1.Value); // küçüktipten büyük bite dönüştürürken cast kullanma
            listBox1.Items.Add(k);
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
                else if (item is DateTimePicker )
                {
                    DateTimePicker dtp = (DateTimePicker)item;
                    dtp.ResetText();
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nu = (NumericUpDown)item;
                    nu.ResetText();
                }
            }
           
        }

        Kitap secili; // kitap türünde seçili nesnesi
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            secili = (Kitap)listBox1.SelectedItem;
            txtKitapAdi.Text = secili.KitapAdi;
            txtYazar.Text = secili.Yazar;
            txtISBN.Text = secili.ISBN;
            txtTuru.Text = secili.Turu;
            txtYayinEvi.Text = secili.YayinEvi;
            dateTimePicker1.Value = secili.YayinTarihi;
            numericUpDown1.Value = secili.SayfaSayisi;
        }
    }
}
