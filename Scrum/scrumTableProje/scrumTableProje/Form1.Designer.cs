namespace scrumTableProje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.storyTarih = new System.Windows.Forms.DateTimePicker();
            this.aciklamaLbl = new System.Windows.Forms.Label();
            this.tarihLbl = new System.Windows.Forms.Label();
            this.baslikLbl = new System.Windows.Forms.Label();
            this.isimLbl = new System.Windows.Forms.Label();
            this.aciklamaTxt = new System.Windows.Forms.TextBox();
            this.gorevTxt = new System.Windows.Forms.TextBox();
            this.isimTxt = new System.Windows.Forms.TextBox();
            this.storyBttn = new System.Windows.Forms.Button();
            this.taskDateTime = new System.Windows.Forms.DateTimePicker();
            this.taskAciklamaLbl = new System.Windows.Forms.Label();
            this.taskTarihLbl = new System.Windows.Forms.Label();
            this.tsBaslikLbl = new System.Windows.Forms.Label();
            this.yapimciLbl = new System.Windows.Forms.Label();
            this.taskAciklama = new System.Windows.Forms.TextBox();
            this.taskBaslikTxt = new System.Windows.Forms.TextBox();
            this.taskYapimciTxt = new System.Windows.Forms.TextBox();
            this.taskBttn = new System.Windows.Forms.Button();
            this.storyLbl = new System.Windows.Forms.Label();
            this.taskLbl = new System.Windows.Forms.Label();
            this.storyCmb = new System.Windows.Forms.ComboBox();
            this.secimLbl = new System.Windows.Forms.Label();
            this.pbox2 = new System.Windows.Forms.PictureBox();
            this.pbox1 = new System.Windows.Forms.PictureBox();
            this.pbox3 = new System.Windows.Forms.PictureBox();
            this.stLbl = new System.Windows.Forms.Label();
            this.notStartedLbl = new System.Windows.Forms.Label();
            this.progressLbl = new System.Windows.Forms.Label();
            this.doneLbl = new System.Windows.Forms.Label();
            this.pboxUst = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUst)).BeginInit();
            this.SuspendLayout();
            // 
            // storyTarih
            // 
            this.storyTarih.Location = new System.Drawing.Point(13, 124);
            this.storyTarih.Name = "storyTarih";
            this.storyTarih.Size = new System.Drawing.Size(135, 22);
            this.storyTarih.TabIndex = 19;
            // 
            // aciklamaLbl
            // 
            this.aciklamaLbl.AutoSize = true;
            this.aciklamaLbl.Location = new System.Drawing.Point(181, 169);
            this.aciklamaLbl.Name = "aciklamaLbl";
            this.aciklamaLbl.Size = new System.Drawing.Size(64, 17);
            this.aciklamaLbl.TabIndex = 18;
            this.aciklamaLbl.Text = "Açıklama";
            // 
            // tarihLbl
            // 
            this.tarihLbl.AutoSize = true;
            this.tarihLbl.Location = new System.Drawing.Point(181, 129);
            this.tarihLbl.Name = "tarihLbl";
            this.tarihLbl.Size = new System.Drawing.Size(139, 17);
            this.tarihLbl.TabIndex = 17;
            this.tarihLbl.Text = "Story Eklenme Tarihi";
            // 
            // baslikLbl
            // 
            this.baslikLbl.AutoSize = true;
            this.baslikLbl.Location = new System.Drawing.Point(181, 89);
            this.baslikLbl.Name = "baslikLbl";
            this.baslikLbl.Size = new System.Drawing.Size(83, 17);
            this.baslikLbl.TabIndex = 16;
            this.baslikLbl.Text = "Başlık-Konu";
            // 
            // isimLbl
            // 
            this.isimLbl.AutoSize = true;
            this.isimLbl.Location = new System.Drawing.Point(181, 45);
            this.isimLbl.Name = "isimLbl";
            this.isimLbl.Size = new System.Drawing.Size(32, 17);
            this.isimLbl.TabIndex = 15;
            this.isimLbl.Text = "Isim";
            // 
            // aciklamaTxt
            // 
            this.aciklamaTxt.Location = new System.Drawing.Point(15, 162);
            this.aciklamaTxt.Multiline = true;
            this.aciklamaTxt.Name = "aciklamaTxt";
            this.aciklamaTxt.Size = new System.Drawing.Size(133, 73);
            this.aciklamaTxt.TabIndex = 14;
            // 
            // gorevTxt
            // 
            this.gorevTxt.Location = new System.Drawing.Point(15, 84);
            this.gorevTxt.Name = "gorevTxt";
            this.gorevTxt.Size = new System.Drawing.Size(133, 22);
            this.gorevTxt.TabIndex = 13;
            // 
            // isimTxt
            // 
            this.isimTxt.Location = new System.Drawing.Point(17, 45);
            this.isimTxt.Name = "isimTxt";
            this.isimTxt.Size = new System.Drawing.Size(133, 22);
            this.isimTxt.TabIndex = 12;
            // 
            // storyBttn
            // 
            this.storyBttn.Location = new System.Drawing.Point(184, 207);
            this.storyBttn.Margin = new System.Windows.Forms.Padding(4);
            this.storyBttn.Name = "storyBttn";
            this.storyBttn.Size = new System.Drawing.Size(100, 28);
            this.storyBttn.TabIndex = 11;
            this.storyBttn.Text = "Story Ekle";
            this.storyBttn.UseVisualStyleBackColor = true;
            this.storyBttn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.storyBttn_MouseClick);
            // 
            // taskDateTime
            // 
            this.taskDateTime.Location = new System.Drawing.Point(13, 444);
            this.taskDateTime.Name = "taskDateTime";
            this.taskDateTime.Size = new System.Drawing.Size(135, 22);
            this.taskDateTime.TabIndex = 28;
            // 
            // taskAciklamaLbl
            // 
            this.taskAciklamaLbl.AutoSize = true;
            this.taskAciklamaLbl.Location = new System.Drawing.Point(181, 485);
            this.taskAciklamaLbl.Name = "taskAciklamaLbl";
            this.taskAciklamaLbl.Size = new System.Drawing.Size(64, 17);
            this.taskAciklamaLbl.TabIndex = 27;
            this.taskAciklamaLbl.Text = "Açıklama";
            // 
            // taskTarihLbl
            // 
            this.taskTarihLbl.AutoSize = true;
            this.taskTarihLbl.Location = new System.Drawing.Point(181, 449);
            this.taskTarihLbl.Name = "taskTarihLbl";
            this.taskTarihLbl.Size = new System.Drawing.Size(139, 17);
            this.taskTarihLbl.TabIndex = 26;
            this.taskTarihLbl.Text = "Story Eklenme Tarihi";
            // 
            // tsBaslikLbl
            // 
            this.tsBaslikLbl.AutoSize = true;
            this.tsBaslikLbl.Location = new System.Drawing.Point(181, 371);
            this.tsBaslikLbl.Name = "tsBaslikLbl";
            this.tsBaslikLbl.Size = new System.Drawing.Size(83, 17);
            this.tsBaslikLbl.TabIndex = 25;
            this.tsBaslikLbl.Text = "Başlık-Konu";
            // 
            // yapimciLbl
            // 
            this.yapimciLbl.AutoSize = true;
            this.yapimciLbl.Location = new System.Drawing.Point(181, 332);
            this.yapimciLbl.Name = "yapimciLbl";
            this.yapimciLbl.Size = new System.Drawing.Size(88, 17);
            this.yapimciLbl.TabIndex = 24;
            this.yapimciLbl.Text = "Yapımcı Isimi";
            // 
            // taskAciklama
            // 
            this.taskAciklama.Location = new System.Drawing.Point(15, 482);
            this.taskAciklama.Multiline = true;
            this.taskAciklama.Name = "taskAciklama";
            this.taskAciklama.Size = new System.Drawing.Size(133, 73);
            this.taskAciklama.TabIndex = 23;
            // 
            // taskBaslikTxt
            // 
            this.taskBaslikTxt.Location = new System.Drawing.Point(15, 366);
            this.taskBaslikTxt.Name = "taskBaslikTxt";
            this.taskBaslikTxt.Size = new System.Drawing.Size(133, 22);
            this.taskBaslikTxt.TabIndex = 22;
            // 
            // taskYapimciTxt
            // 
            this.taskYapimciTxt.Location = new System.Drawing.Point(15, 332);
            this.taskYapimciTxt.Name = "taskYapimciTxt";
            this.taskYapimciTxt.Size = new System.Drawing.Size(133, 22);
            this.taskYapimciTxt.TabIndex = 21;
            // 
            // taskBttn
            // 
            this.taskBttn.Location = new System.Drawing.Point(189, 527);
            this.taskBttn.Margin = new System.Windows.Forms.Padding(4);
            this.taskBttn.Name = "taskBttn";
            this.taskBttn.Size = new System.Drawing.Size(100, 28);
            this.taskBttn.TabIndex = 20;
            this.taskBttn.Text = "Task Ekle";
            this.taskBttn.UseVisualStyleBackColor = true;
            this.taskBttn.Click += new System.EventHandler(this.taskBttn_Click);
            // 
            // storyLbl
            // 
            this.storyLbl.AutoSize = true;
            this.storyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.storyLbl.Location = new System.Drawing.Point(12, 8);
            this.storyLbl.Name = "storyLbl";
            this.storyLbl.Size = new System.Drawing.Size(129, 29);
            this.storyLbl.TabIndex = 29;
            this.storyLbl.Text = "Story Ekle";
            // 
            // taskLbl
            // 
            this.taskLbl.AutoSize = true;
            this.taskLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.taskLbl.Location = new System.Drawing.Point(12, 291);
            this.taskLbl.Name = "taskLbl";
            this.taskLbl.Size = new System.Drawing.Size(125, 29);
            this.taskLbl.TabIndex = 30;
            this.taskLbl.Text = "Task Ekle";
            // 
            // storyCmb
            // 
            this.storyCmb.FormattingEnabled = true;
            this.storyCmb.Location = new System.Drawing.Point(16, 403);
            this.storyCmb.Name = "storyCmb";
            this.storyCmb.Size = new System.Drawing.Size(132, 24);
            this.storyCmb.TabIndex = 31;
            // 
            // secimLbl
            // 
            this.secimLbl.AutoSize = true;
            this.secimLbl.Location = new System.Drawing.Point(181, 410);
            this.secimLbl.Name = "secimLbl";
            this.secimLbl.Size = new System.Drawing.Size(86, 17);
            this.secimLbl.TabIndex = 32;
            this.secimLbl.Text = "Story Seçimi";
            // 
            // pbox2
            // 
            this.pbox2.Image = ((System.Drawing.Image)(resources.GetObject("pbox2.Image")));
            this.pbox2.Location = new System.Drawing.Point(855, 6);
            this.pbox2.Name = "pbox2";
            this.pbox2.Size = new System.Drawing.Size(10, 547);
            this.pbox2.TabIndex = 33;
            this.pbox2.TabStop = false;
            // 
            // pbox1
            // 
            this.pbox1.Image = ((System.Drawing.Image)(resources.GetObject("pbox1.Image")));
            this.pbox1.Location = new System.Drawing.Point(607, 6);
            this.pbox1.Name = "pbox1";
            this.pbox1.Size = new System.Drawing.Size(10, 547);
            this.pbox1.TabIndex = 34;
            this.pbox1.TabStop = false;
            // 
            // pbox3
            // 
            this.pbox3.Image = ((System.Drawing.Image)(resources.GetObject("pbox3.Image")));
            this.pbox3.Location = new System.Drawing.Point(1098, 5);
            this.pbox3.Name = "pbox3";
            this.pbox3.Size = new System.Drawing.Size(10, 547);
            this.pbox3.TabIndex = 35;
            this.pbox3.TabStop = false;
            // 
            // stLbl
            // 
            this.stLbl.AutoSize = true;
            this.stLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stLbl.Location = new System.Drawing.Point(440, 8);
            this.stLbl.Name = "stLbl";
            this.stLbl.Size = new System.Drawing.Size(126, 38);
            this.stLbl.TabIndex = 36;
            this.stLbl.Text = "Stories";
            // 
            // notStartedLbl
            // 
            this.notStartedLbl.AutoSize = true;
            this.notStartedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notStartedLbl.Location = new System.Drawing.Point(623, 8);
            this.notStartedLbl.Name = "notStartedLbl";
            this.notStartedLbl.Size = new System.Drawing.Size(193, 38);
            this.notStartedLbl.TabIndex = 37;
            this.notStartedLbl.Text = "Not Started";
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.progressLbl.Location = new System.Drawing.Point(880, 8);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(195, 38);
            this.progressLbl.TabIndex = 38;
            this.progressLbl.Text = "In Progress";
            // 
            // doneLbl
            // 
            this.doneLbl.AutoSize = true;
            this.doneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doneLbl.Location = new System.Drawing.Point(1157, 8);
            this.doneLbl.Name = "doneLbl";
            this.doneLbl.Size = new System.Drawing.Size(99, 38);
            this.doneLbl.TabIndex = 39;
            this.doneLbl.Text = "Done";
            // 
            // pboxUst
            // 
            this.pboxUst.Image = ((System.Drawing.Image)(resources.GetObject("pboxUst.Image")));
            this.pboxUst.Location = new System.Drawing.Point(324, 50);
            this.pboxUst.Name = "pboxUst";
            this.pboxUst.Size = new System.Drawing.Size(979, 12);
            this.pboxUst.TabIndex = 40;
            this.pboxUst.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1338, 575);
            this.Controls.Add(this.pboxUst);
            this.Controls.Add(this.doneLbl);
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.notStartedLbl);
            this.Controls.Add(this.stLbl);
            this.Controls.Add(this.pbox3);
            this.Controls.Add(this.pbox1);
            this.Controls.Add(this.pbox2);
            this.Controls.Add(this.secimLbl);
            this.Controls.Add(this.storyCmb);
            this.Controls.Add(this.taskLbl);
            this.Controls.Add(this.storyLbl);
            this.Controls.Add(this.taskDateTime);
            this.Controls.Add(this.taskAciklamaLbl);
            this.Controls.Add(this.taskTarihLbl);
            this.Controls.Add(this.tsBaslikLbl);
            this.Controls.Add(this.yapimciLbl);
            this.Controls.Add(this.taskAciklama);
            this.Controls.Add(this.taskBaslikTxt);
            this.Controls.Add(this.taskYapimciTxt);
            this.Controls.Add(this.taskBttn);
            this.Controls.Add(this.storyTarih);
            this.Controls.Add(this.aciklamaLbl);
            this.Controls.Add(this.tarihLbl);
            this.Controls.Add(this.baslikLbl);
            this.Controls.Add(this.isimLbl);
            this.Controls.Add(this.aciklamaTxt);
            this.Controls.Add(this.gorevTxt);
            this.Controls.Add(this.isimTxt);
            this.Controls.Add(this.storyBttn);
            this.Name = "Form1";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker storyTarih;
        private System.Windows.Forms.Label aciklamaLbl;
        private System.Windows.Forms.Label tarihLbl;
        private System.Windows.Forms.Label baslikLbl;
        private System.Windows.Forms.Label isimLbl;
        private System.Windows.Forms.TextBox aciklamaTxt;
        private System.Windows.Forms.TextBox gorevTxt;
        private System.Windows.Forms.TextBox isimTxt;
        private System.Windows.Forms.Button storyBttn;
        private System.Windows.Forms.DateTimePicker taskDateTime;
        private System.Windows.Forms.Label taskAciklamaLbl;
        private System.Windows.Forms.Label taskTarihLbl;
        private System.Windows.Forms.Label tsBaslikLbl;
        private System.Windows.Forms.Label yapimciLbl;
        private System.Windows.Forms.TextBox taskAciklama;
        private System.Windows.Forms.TextBox taskBaslikTxt;
        private System.Windows.Forms.TextBox taskYapimciTxt;
        private System.Windows.Forms.Button taskBttn;
        private System.Windows.Forms.Label storyLbl;
        private System.Windows.Forms.Label taskLbl;
        private System.Windows.Forms.ComboBox storyCmb;
        private System.Windows.Forms.Label secimLbl;
        private System.Windows.Forms.PictureBox pbox2;
        private System.Windows.Forms.PictureBox pbox1;
        private System.Windows.Forms.PictureBox pbox3;
        private System.Windows.Forms.Label stLbl;
        private System.Windows.Forms.Label notStartedLbl;
        private System.Windows.Forms.Label progressLbl;
        private System.Windows.Forms.Label doneLbl;
        private System.Windows.Forms.PictureBox pboxUst;
    }
}

