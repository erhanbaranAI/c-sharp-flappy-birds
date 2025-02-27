using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Birds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //yerçekimi kuşun sürekli aşağıda düşmesi için yapıldı
        //skor level ve en yüksek skor değişkenleri için oluşturuldu
        //boru hızı üst ve alttaki boruların sola doğru gitmesi için yapıldı
        //boyut değişkeni boruların birbirleri arasında boyutunu oranlamak için oluşturuldu
        //sayac oyun başlarken 3 2 1 şeklinde pictureBoxları göstermek için yapıldı
        //yuksel değişkeni boşluk tuşuna basılıp basılmadığını öğrenmemiz için oluşturuldu
        // Size ustBoru; şeklinde oluşturduğumuz değişken sayesinde borunun size'ını değiştirebiliyoruz

        int yerCekimi = -20, skor = 0, boruHizi = 30,boyut,sayac = 3;
        bool yuksel = false;
        Size ustBoru;
        Random Rnd = new Random();

        private void tmrBaslat_Tick(object sender, EventArgs e)
        {
            switch (sayac)
            {
                case 3:
                    pbSayac.Image = Properties.Resources.three;
                    sayac--;
                    break;
                case 2:
                    pbSayac.Image = Properties.Resources.two;
                    sayac--;
                    break;
                case 1:
                    pbSayac.Image = Properties.Resources.one;
                    sayac--;
                    break;
                case 0:
                    pbSayac.Image = Properties.Resources.start;
                    tmrBaslat.Stop();
                    tmrOyun.Start();
                    break;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                yuksel = true; 
            }
        }

        private void tmrOyun_Tick(object sender, EventArgs e)
        {
            //ilk başta gözüken pictureBox'ı saklamak için kullandık.
            pbSayac.Hide();

            //borunun boyutlarını rastgele oluşturmak için bu değişken tutuldu. (150,310) olmasının sebebi deneme yanılma yoluyla bulundu
            boyut = Rnd.Next(150,310);

            //bu sayede yer çekimi değişkeni kadar aşağı düştü
            pbKus.Top -= yerCekimi;

            //boşluk tuşuna basılmadığı sürece sürekli aşağı düşen kuş simgesi gözüküyor.
            pbKus.Image = Properties.Resources.birdDown;

            //eğer boşluk tuşuna basıldıysa olacaklar 
            if (yuksel == true)
            {
                //yukselen kuş resmi var ve zıplama miktarı 150 en son çıkmadan yuksel değerini tekrar false yapıyoruz ki sürekli yükselmesin
                pbKus.Image = Properties.Resources.birdUp;
                pbKus.Top -= 150;
                yuksel = false;
            }
            //borularımızı sola doğru götürüyoruz.
            pbUstBoru.Left -= boruHizi;
            pbAltBoru.Left -= boruHizi;

            //borular yok olunca ileriye bidaha yerleştiriyoruz.
            if(pbUstBoru.Left < -20)
            {
                //her bir boru geçince skor değerini 1 arttırıyoruz.
                skor++;
                pbUstBoru.Left = 760;
                //height ve width değerlerini oluşturduğumuz ustboru değişkenini üstborunun size özelliğine atadık.
                ustBoru.Height = boyut;
                ustBoru.Width = 100;
                pbUstBoru.Size = ustBoru;
            }
            
            if (pbAltBoru.Left < -10)
            {
                skor++;
                pbAltBoru.Left = 860;
                //height kadar eksiltip eğer üst boru uzunsa alt boruyu kısaltıyoruz ki geçiş kolay olsun
                pbAltBoru.Top = 777 - boyut;
            }

            //sol altta bulunan skor değişkenini değiştiriyoruz.
            lblSkor.Text = "Skor: " + skor.ToString();

            //level sistemi
            if(skor != 0 && skor % 10 == 0)
            {
                boruHizi++;
                //buradaki kontrol doğruysa borular hızlandıkça yer çekimini de arttırıp oyunda dengeyi sağlamaya çalışıyoruz.
                if (skor != 0 && skor % 20 == 0)
                {
                    yerCekimi--;
                }
                lblSkor.Text = "Skor: " + skor.ToString()+" Level UP!!!";
            }

            //oyunu bitirme
            if(pbKus.Bounds.IntersectsWith(pbAltBoru.Bounds) ||
                pbKus.Bounds.IntersectsWith(pbUstBoru.Bounds) ||
                pbKus.Bounds.IntersectsWith(pbZemin.Bounds) ||
                pbKus.Bounds.IntersectsWith(pbBulut.Bounds))
            {
              OyunuBitir();
            }
           
        }
        //oyun bitirme fonksiyonu tek ekstrası eklediğimiz Settings sayesinde en yüksek skoru kaydediyoruz.
        private void OyunuBitir()
        {
            tmrOyun.Stop();
            MessageBox.Show("Oyun Bitti Skorunuz: " + skor.ToString(),"Oyun Bitti", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            if(skor > Settings1.Default.HighScore)
            {
              MessageBox.Show("!!!Tebrikler En Yüksek Skora Ulaştınız!!! ", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Settings1.Default.HighScore = skor;
                Settings1.Default.Save();
            }
            DialogResult dr = MessageBox.Show("Yeni oyuna başlamak istermisiniz? ", "Yeni Oyun?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dr == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Çıkış Yapılıyor..", "Çıkış", MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
