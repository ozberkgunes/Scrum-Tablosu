using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrumTableProje
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        List<HikayeDetay> hdList = new List<HikayeDetay>();
        List<TaskDetay> tdList = new List<TaskDetay>();
        TaskDetay td = new TaskDetay();
        int i = 0;
        int k = 0;
        bool isDragged = false;
        Point ptOffset;
        bool hata = false;

        public Form1()
        {
            InitializeComponent();


        }
        
        private void Form1_Load(object sender, EventArgs e){}

        private void storyBttn_MouseClick(object sender, MouseEventArgs e)
        {
            HikayeDetay sd = new HikayeDetay();
            
            if (isimTxt.Text == "")
            {
                MessageBox.Show("İsim alanı boş bırakılmaz!");
                hata = true;
            }
            
           else if (gorevTxt.Text == "")
            {
                MessageBox.Show("Başlık-Konu Alanı boş bırakılamaz!");
                hata = true;
            }
            
           else if (aciklamaTxt.Text == "")
            { 
                MessageBox.Show("Açıklama alanı boş bırakılamaz!");
                hata = true;
            }
            
            else
                hata = false;
            if (!hata)
            {
                sd.isim = isimTxt.Text;
                sd.baslik = gorevTxt.Text;
                sd.aciklama = aciklamaTxt.Text;
                sd.tarih = storyTarih.Value;

                hdList.Add(sd);

                butonYarat();

                storyCmb.Items.Add(sd.baslik);
            }
        }
        private void butonYarat()
        {
            Button btn = new Button
            {
                Top = 61 + (i),
                Left = 275,
                Width = 100,
                Text = hdList.Last().baslik,
                Height = 100
            };

            i += 100;
            btn.MouseDown += btn_MouseDown;
            btn.MouseMove += btn_MouseMove;
            btn.MouseUp += btn_MouseUp;
            btn.MouseClick += btn_MouseClick;
            
            Controls.Add(btn);

        }
        private void btn_MouseClick(object sender, MouseEventArgs e)
        {
            int j = 0;
            int ind = 0;
            Button dinamikButon = (sender as Button);
            foreach (HikayeDetay hd in hdList)
            {
                if (hd.baslik == dinamikButon.Text)
                    ind = j;
                j++;
            }
            MessageBox.Show(" Yapımcı Adı:  " + hdList[ind].isim + "\n Yapılan Proje Adı:    " + hdList[ind].baslik + "\n Proje Açıklaması:   " + hdList[ind].aciklama + "\n Story Giriş Tarihi:   " + hdList[ind].tarih.ToString());
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button dinamikButon = (sender as Button);
            if (isDragged)
            {
                Point newPoint = dinamikButon.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                dinamikButon.Location = newPoint;
            }
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button dinamikButon = (sender as Button);
            if (e.Button == MouseButtons.Left)
            {
                isDragged = true;
                Point ptStartPosition = dinamikButon.PointToScreen(new Point(e.X, e.Y));

                ptOffset = new Point();
                ptOffset.X = dinamikButon.Location.X - ptStartPosition.X;
                ptOffset.Y = dinamikButon.Location.Y - ptStartPosition.Y;

            }
            else
            {
                isDragged = false;
            }

        }

        private void taskBttn_Click(object sender, EventArgs e)
        {
            TaskDetay td = new TaskDetay();
            
          
            if (taskAciklama.Text == "")
            {
                MessageBox.Show("Açıklama alanı boş bırakılamaz!");
                hata = true;
            }
            
           else if (taskBaslikTxt.Text == "")
            {
                MessageBox.Show("Başlık alanı boş bırakılamaz!");
                hata = true;
            }
           
            
          else  if (taskYapimciTxt.Text == "")
            {
                MessageBox.Show("Yapımcı adı boş bırakılamaz!");
                hata = true;
            }

            else
                hata = false;
           
            

            if (!hata)
            {
                td.aciklama = taskAciklama.Text;
                td.baslik = taskBaslikTxt.Text;
                td.kim = taskYapimciTxt.Text;
                td.deadline = taskDateTime.Value;

                tdList.Add(td);

                taskButonYarat();

            }
            
        }

        private void taskButonYarat()
        {   
            
            Button taskB = new Button
            {
                Top = 61 + (k),
                Left = 320,
                Width = 70,
                Text = storyCmb.SelectedItem.ToString(),
                Height = 50
            };

            k+=10;
            taskB.MouseDown += TaskB_MouseDown;
            taskB.MouseMove += TaskB_MouseMove;
            taskB.MouseUp += TaskB_MouseUp;
            taskB.MouseEnter += TaskB_MouseEnter;
            taskB.MouseLeave += TaskB_MouseLeave;
            taskB.MouseClick += TaskB_MouseClick;
            Controls.Add(taskB);
        }

        private void TaskB_MouseLeave(object sender, EventArgs e)
        {
            Button dinamikTaskButon = (sender as Button);
            dinamikTaskButon.Left -= 50;
        }

        private void TaskB_MouseEnter(object sender, EventArgs e)
        {
            Button dinamikTaskButon = (sender as Button);
            dinamikTaskButon.Left += 50;
        }

        private void TaskB_MouseClick(object sender, MouseEventArgs e)
        {
            int j = 0;
            int indis = 0;
            Button dinamikTaskButon = (sender as Button);
            foreach (TaskDetay td in tdList)
            {
                if (td.baslik  == dinamikTaskButon.Text)
                    indis = j;
                j++;
            }
            MessageBox.Show(" Yapımcı Adı:  " + tdList[indis].kim + "\n Yapılan Proje Adı:    " + tdList[indis].baslik + "\n Proje Açıklaması:   " 
                + tdList[indis].aciklama + "\n Story Giriş Tarihi:   " + tdList[indis].deadline.ToString());

        }

        private void TaskB_MouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
        }

        private void TaskB_MouseMove(object sender, MouseEventArgs e)
        {
            Button dinamikButon = (sender as Button);
            if (isDragged)
            {
                Point newPoint = dinamikButon.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                dinamikButon.Location = newPoint;
            }
        }

        private void TaskB_MouseDown(object sender, MouseEventArgs e)
        {
            Button dinamikTaskButon = (sender as Button);
            if (e.Button == MouseButtons.Left)
            {
                isDragged = true;
                Point ptStartPosition = dinamikTaskButon.PointToScreen(new Point(e.X, e.Y));

                ptOffset = new Point();
                ptOffset.X = dinamikTaskButon.Location.X - ptStartPosition.X;
                ptOffset.Y = dinamikTaskButon.Location.Y - ptStartPosition.Y;

            }
            else
            {
                isDragged = false;
            }
        }
    }
}
