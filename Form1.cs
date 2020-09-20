using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace birislem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random Rastgele = new Random();
        int sayisayaci = 0;
        void SayıUret()
        {
            sayisayaci++;
            string deger1, deger2, deger3, deger4, deger5, deger6;
            string[] dizi2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] dizi3 = { "50", "60", "75" };
            int sayilar;
            int deger7;

            if (sayisayaci == 1)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                deger1 = (dizi2[sayilar]);
                txtSayi1.Text = deger1.ToString();
                txtSayi1.Visible = true;
            }
            if (sayisayaci == 2)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                deger2 = (dizi2[sayilar]);
                txtSayi2.Text = deger2.ToString();
                txtSayi2.Visible = true;
            }
            if (sayisayaci == 3)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                deger3 = (dizi2[sayilar]);
                txtSayi3.Text = deger3.ToString();
                txtSayi3.Visible = true;
            }
            if (sayisayaci == 4)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                deger4 = (dizi2[sayilar]);
                txtSayi4.Text = deger4.ToString();
                txtSayi4.Visible = true;
            }
            if (sayisayaci == 5)
            {
                sayilar = Rastgele.Next(0, dizi2.Length);
                deger5 = (dizi2[sayilar]);
                txtSayi5.Text = deger5.ToString();
                txtSayi5.Visible = true;
            }
            if (sayisayaci == 6)
            {
                sayilar = Rastgele.Next(0, dizi3.Length);
                deger6 = (dizi3[sayilar]);
                txtSayi6.Text = deger6.ToString();
                txtSayi6.Visible = true;
            }
            if (sayisayaci == 7)
            {
                deger7 = Rastgele.Next(100, 500);
                txtSoru.Text = deger7.ToString();
                txtSoru.Visible = true;
                label2.Visible = true;
            }
        }//SAYI URETEN METOD
        void YenidenBasla()
        {
           
            sayisayaci = 0;

            txtSayi1.Clear();
            txtSayi2.Clear();
            txtSayi3.Clear();
            txtSayi4.Clear();
            txtSayi5.Clear();
            txtSayi6.Clear();
            txtSoru.Clear();
        }//YENIDEN BASLA METODU
        void SonucBul(out int istenensayi, out int enbuyuksayi, out int istenensayi2, out int istenensayi3, out int kalan1, out int kalan2, out int kalan3)
        {
            istenensayi = Convert.ToInt32(txtSoru.Text);
            enbuyuksayi = Convert.ToInt32(txtSayi6.Text);
            int deger1, deger2, deger3, deger4, deger5;


            deger1 = Math.Abs(istenensayi - (Convert.ToInt32(txtSayi1.Text) * enbuyuksayi));
            deger2 = Math.Abs(istenensayi - (Convert.ToInt32(txtSayi2.Text) * enbuyuksayi));
            deger3 = Math.Abs(istenensayi - (Convert.ToInt32(txtSayi3.Text) * enbuyuksayi));
            deger4 = Math.Abs(istenensayi - (Convert.ToInt32(txtSayi4.Text) * enbuyuksayi));
            deger5 = Math.Abs(istenensayi - (Convert.ToInt32(txtSayi5.Text) * enbuyuksayi));

            int[] sayilar = new int[5] { deger1, deger2, deger3, deger4, deger5 };

            Array.Sort(sayilar);

            istenensayi2 = sayilar[0];
            istenensayi3 = 0;
            if (sayilar[0] == deger1)
            {

                istenensayi3 = Convert.ToInt32(txtSayi1.Text);
                txtSayi1.Text = "X";
                txtSayi6.Text = "X";
            }
            // ATANAN SAYI YERİNE X KOYMA
            else if (sayilar[0] == deger2)
            {
                istenensayi3 = Convert.ToInt32(txtSayi2.Text);
                txtSayi2.Text = "X";
                txtSayi6.Text = "X";
            }
            else if (sayilar[0] == deger3)
            {
                istenensayi3 = Convert.ToInt32(txtSayi3.Text);
                txtSayi3.Text = "X";
                txtSayi6.Text = "X";
            }
            else if (sayilar[0] == deger4)
            {
                istenensayi3 = Convert.ToInt32(txtSayi4.Text);
                txtSayi4.Text = "X";
                txtSayi6.Text = "X";
            }
            else if (sayilar[0] == deger5)
            {
                istenensayi3 = Convert.ToInt32(txtSayi5.Text);
                txtSayi5.Text = "X";
                txtSayi6.Text = "X";
            }


            int deger11, deger22, deger33, deger44, deger55;
            kalan1 = Math.Abs(istenensayi - (istenensayi3 * enbuyuksayi));
            kalan2 = 0;
            kalan3 = 0;
            int[] kalandansonrakisayilar = new int[5];

            if (txtSayi1.Text != "X")
            {
                deger11 = Convert.ToInt32(txtSayi1.Text);
                kalandansonrakisayilar[0] = deger11;
            }
            if (txtSayi2.Text != "X")
            {
                deger22 = Convert.ToInt32(txtSayi2.Text);
                kalandansonrakisayilar[1] = deger22;
            }
            if (txtSayi3.Text != "X")
            {
                deger33 = Convert.ToInt32(txtSayi3.Text);
                kalandansonrakisayilar[2] = deger33;
            }
            if (txtSayi4.Text != "X")
            {
                deger44 = Convert.ToInt32(txtSayi4.Text);
                kalandansonrakisayilar[3] = deger44;
            }
            if (txtSayi5.Text != "X")
            {
                deger55 = Convert.ToInt32(txtSayi5.Text);
                kalandansonrakisayilar[4] = deger55;
            }

            Array.Sort(kalandansonrakisayilar);

            if (kalan1 == 0)
            {
                kalan3 = 10;
            }
            else if (kalan1 != 0 && kalan1 <= 5)
            {
                if (Math.Abs(kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[1] - kalan1);

                }
                else if (Math.Abs(kalandansonrakisayilar[2] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[2] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[3] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[3] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] - kalan1);
                }
            }
            else if (kalan1 > 5 && kalan1 <= 18 && kalan1 != 0)
            {
                if (Math.Abs(kalandansonrakisayilar[4] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] - kalan1);

                }
                else if (Math.Abs(kalandansonrakisayilar[3] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[3] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[2] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[2] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[3] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[3] - kalan1);

                }
                else if (Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[2] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[2] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[3] + kalandansonrakisayilar[2] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[3] + kalandansonrakisayilar[2] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[3] + kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[3] + kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[2] + kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[2] + kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[3] + kalandansonrakisayilar[2] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[3] + kalandansonrakisayilar[2] - kalan1);

                }
                else if (Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[3] + kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[3] + kalandansonrakisayilar[1] - kalan1);

                }
                else if (Math.Abs(kalandansonrakisayilar[3] + kalandansonrakisayilar[2] + kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[1] + kalandansonrakisayilar[3] + kalandansonrakisayilar[2] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[2] + kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[2] + kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[3] + kalandansonrakisayilar[2] + kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] + kalandansonrakisayilar[3] + kalandansonrakisayilar[2] + kalandansonrakisayilar[1] - kalan1);
                }

            }
            else if (kalan1 > 18 && kalan1 <= 27 && kalan1 != 0)
            {
                if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] - kalan1);

                }
                else if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[2] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[2] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[3] * kalandansonrakisayilar[2] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[3] * kalandansonrakisayilar[2] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[3] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[3] * kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] * kalandansonrakisayilar[2] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] * kalandansonrakisayilar[2] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] * kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[3] * kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[1] * kalandansonrakisayilar[3] * kalandansonrakisayilar[2] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] * kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] * kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1);
                }
            }           
            else if (kalan1 > 81)
            {
                if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] - kalan1);

                }
                else if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[2] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[2] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[3] * kalandansonrakisayilar[2] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[3] * kalandansonrakisayilar[2] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[3] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[3] * kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] * kalandansonrakisayilar[2] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] * kalandansonrakisayilar[2] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] * kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[3] * kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[1] * kalandansonrakisayilar[3] * kalandansonrakisayilar[2] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1);
                }
                else if (Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] * kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1) <= 9)
                {
                    kalan2 = Math.Abs(kalandansonrakisayilar[4] * kalandansonrakisayilar[3] * kalandansonrakisayilar[2] * kalandansonrakisayilar[1] - kalan1);
                }
            }


            if (kalan2 != 0)
            {
                kalan3 = 10 - kalan2;
            }
            else if (kalan2 == 0)
            {
                kalan3 = 10;
            }
            else
            {
                kalan3 = 0;
            }
        }//SONUCU BULAN ALGORITMA
        static void SonucuYazdır(int istenensayi, int enbuyuksayi, int istenensayi2, int istenensayi3, int kalan1, int kalan2, int kalan3)
        {
            MessageBox.Show("Kalan : " + istenensayi2.ToString(), "Kullanılan : " + istenensayi3.ToString());
            MessageBox.Show("İşlem 1 : " + istenensayi.ToString() + " / " + enbuyuksayi.ToString() + " = " +
                (istenensayi / enbuyuksayi).ToString() + "\n" +
                "(Cıkan sonuca en yakın deger kullanılır)" + "\n" +
                istenensayi3.ToString() + " * " + enbuyuksayi.ToString() + " = " + (istenensayi3 * enbuyuksayi).ToString() + "\n" +
                "Kalan = " + (kalan1).ToString() + "\n" + "Kalan2 = " + (kalan2).ToString() + "\n" + "Puanınız = " + kalan3.ToString()



                );
        }//MESSAGEBOX'A SONUCU YAZDIRAN METOD

        private void btnSayiVer_Click(object sender, EventArgs e)
        {
            SayıUret();

        }
        private void btnYenidenBasla_Click(object sender, EventArgs e)
        {
            YenidenBasla();
        }
        private void btnSonucBul_Click(object sender, EventArgs e)
        {
            int istenensayi, enbuyuksayi, istenensayi2, istenensayi3, kalan1, kalan2, kalan3;

            SonucBul(out istenensayi, out enbuyuksayi, out istenensayi2, out istenensayi3, out kalan1, out kalan2, out kalan3);
            SonucuYazdır(istenensayi, enbuyuksayi, istenensayi2, istenensayi3, kalan1, kalan2, kalan3);
        }
            
        


        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
