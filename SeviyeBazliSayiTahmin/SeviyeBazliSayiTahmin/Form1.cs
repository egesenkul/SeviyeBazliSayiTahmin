using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeviyeBazliSayiTahmin
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int seviye = 1;
        int can = 5;
        int gercekSayi;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Oyun()
        {
            btnOnayla.Visible = true;
            btnYeniOyun.Visible = false;
            lblRobot.Text = "Bir sayı tuttum tahmin et ";
            CanSeviyeGuncelle();
            if (CanKontrol())
            {
                //Oyun başlasın
                gercekSayi = rnd.Next(1, 10 * seviye);
                int tahminSonDeger = 10 * seviye;
                lblRobot.Text += "1-" + tahminSonDeger;
            }

        }

        private bool CanKontrol()
        {
            if (can != 0)
            {
                return true;
            }
            else {
                btnYeniOyun.Visible = true;
                gercekSayi = 0;
                lblRobot.Text = "Oyun bitti";
                btnOnayla.Visible = false;
                txtInput.Text = "";
                MessageBox.Show("Canınız kalmadı");
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Oyun();
        }

        private void CanSeviyeGuncelle()
        {
            lblCan.Text = "Kalan Can: " + can;
            lblSeviye.Text = "Seviye: " + seviye;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtInput.Text) >= 1 && Convert.ToInt32(txtInput.Text) < 10 * seviye)
                {
                    if (Convert.ToInt32(txtInput.Text) == gercekSayi)
                    {
                        seviye++;
                        can++;
                        MessageBox.Show("Tahmininiz doğru. Tuttuğum sayı=" + gercekSayi);
                        txtInput.Text = "";
                        Oyun();
                    }
                    else if (Convert.ToInt32(txtInput.Text) < gercekSayi)
                    {
                        lblRobot.Text = "Tuttuğum sayı büyük!";
                        can--;
                        CanKontrol();
                        CanSeviyeGuncelle();
                    }
                    else if (Convert.ToInt32(txtInput.Text) > gercekSayi)
                    {
                        lblRobot.Text = "Tuttuğum sayı küçük!";
                        can--;
                        CanKontrol();
                        CanSeviyeGuncelle();
                    }
                }
                else
                {
                    MessageBox.Show("Aralıkta bir sayı giriniz.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen rakam giriniz");
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnOnayla.PerformClick();
            }
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            seviye = 1;
            can = 5;
            Oyun();
        }
    }
}
