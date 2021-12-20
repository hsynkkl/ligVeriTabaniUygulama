
namespace veriTabaniProje
{
    partial class teknikDirektor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwteknikDirektorListe = new System.Windows.Forms.DataGridView();
            this.btnteknikDirektorListele = new System.Windows.Forms.Button();
            this.dtpteknikDirektorDtarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbteknikDirektorTakim = new System.Windows.Forms.ComboBox();
            this.cmbteknikDirektorDyeri = new System.Windows.Forms.ComboBox();
            this.btnteknikDirektorGuncelle = new System.Windows.Forms.Button();
            this.btnteknikDirektorEkle = new System.Windows.Forms.Button();
            this.btnteknikDirektorSil = new System.Windows.Forms.Button();
            this.txtteknikDirektorAdSoyad = new System.Windows.Forms.TextBox();
            this.txtteknikDirektorId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwteknikDirektorListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwteknikDirektorListe
            // 
            this.dgwteknikDirektorListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwteknikDirektorListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwteknikDirektorListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwteknikDirektorListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwteknikDirektorListe.Location = new System.Drawing.Point(353, 14);
            this.dgwteknikDirektorListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwteknikDirektorListe.Name = "dgwteknikDirektorListe";
            this.dgwteknikDirektorListe.ReadOnly = true;
            this.dgwteknikDirektorListe.Size = new System.Drawing.Size(391, 174);
            this.dgwteknikDirektorListe.TabIndex = 39;
            // 
            // btnteknikDirektorListele
            // 
            this.btnteknikDirektorListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnteknikDirektorListele.Location = new System.Drawing.Point(186, 166);
            this.btnteknikDirektorListele.Name = "btnteknikDirektorListele";
            this.btnteknikDirektorListele.Size = new System.Drawing.Size(163, 22);
            this.btnteknikDirektorListele.TabIndex = 38;
            this.btnteknikDirektorListele.Text = "Listele";
            this.btnteknikDirektorListele.UseVisualStyleBackColor = true;
            this.btnteknikDirektorListele.Click += new System.EventHandler(this.btnteknikDirektorListele_Click);
            // 
            // dtpteknikDirektorDtarihi
            // 
            this.dtpteknikDirektorDtarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpteknikDirektorDtarihi.Location = new System.Drawing.Point(204, 86);
            this.dtpteknikDirektorDtarihi.Name = "dtpteknikDirektorDtarihi";
            this.dtpteknikDirektorDtarihi.Size = new System.Drawing.Size(145, 20);
            this.dtpteknikDirektorDtarihi.TabIndex = 37;
            // 
            // cmbteknikDirektorTakim
            // 
            this.cmbteknikDirektorTakim.FormattingEnabled = true;
            this.cmbteknikDirektorTakim.Location = new System.Drawing.Point(204, 109);
            this.cmbteknikDirektorTakim.Name = "cmbteknikDirektorTakim";
            this.cmbteknikDirektorTakim.Size = new System.Drawing.Size(145, 21);
            this.cmbteknikDirektorTakim.TabIndex = 35;
            // 
            // cmbteknikDirektorDyeri
            // 
            this.cmbteknikDirektorDyeri.FormattingEnabled = true;
            this.cmbteknikDirektorDyeri.Location = new System.Drawing.Point(204, 61);
            this.cmbteknikDirektorDyeri.Name = "cmbteknikDirektorDyeri";
            this.cmbteknikDirektorDyeri.Size = new System.Drawing.Size(145, 21);
            this.cmbteknikDirektorDyeri.TabIndex = 36;
            // 
            // btnteknikDirektorGuncelle
            // 
            this.btnteknikDirektorGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnteknikDirektorGuncelle.Location = new System.Drawing.Point(186, 141);
            this.btnteknikDirektorGuncelle.Name = "btnteknikDirektorGuncelle";
            this.btnteknikDirektorGuncelle.Size = new System.Drawing.Size(163, 22);
            this.btnteknikDirektorGuncelle.TabIndex = 32;
            this.btnteknikDirektorGuncelle.Text = "Güncelle";
            this.btnteknikDirektorGuncelle.UseVisualStyleBackColor = true;
            this.btnteknikDirektorGuncelle.Click += new System.EventHandler(this.btnteknikDirektorGuncelle_Click);
            // 
            // btnteknikDirektorEkle
            // 
            this.btnteknikDirektorEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnteknikDirektorEkle.Location = new System.Drawing.Point(16, 141);
            this.btnteknikDirektorEkle.Name = "btnteknikDirektorEkle";
            this.btnteknikDirektorEkle.Size = new System.Drawing.Size(163, 22);
            this.btnteknikDirektorEkle.TabIndex = 33;
            this.btnteknikDirektorEkle.Text = "Ekle";
            this.btnteknikDirektorEkle.UseVisualStyleBackColor = true;
            this.btnteknikDirektorEkle.Click += new System.EventHandler(this.btnteknikDirektorEkle_Click);
            // 
            // btnteknikDirektorSil
            // 
            this.btnteknikDirektorSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnteknikDirektorSil.Location = new System.Drawing.Point(16, 166);
            this.btnteknikDirektorSil.Name = "btnteknikDirektorSil";
            this.btnteknikDirektorSil.Size = new System.Drawing.Size(163, 22);
            this.btnteknikDirektorSil.TabIndex = 34;
            this.btnteknikDirektorSil.Text = "Sil";
            this.btnteknikDirektorSil.UseVisualStyleBackColor = true;
            this.btnteknikDirektorSil.Click += new System.EventHandler(this.btnteknikDirektorSil_Click);
            // 
            // txtteknikDirektorAdSoyad
            // 
            this.txtteknikDirektorAdSoyad.Location = new System.Drawing.Point(204, 38);
            this.txtteknikDirektorAdSoyad.Name = "txtteknikDirektorAdSoyad";
            this.txtteknikDirektorAdSoyad.Size = new System.Drawing.Size(145, 20);
            this.txtteknikDirektorAdSoyad.TabIndex = 30;
            // 
            // txtteknikDirektorId
            // 
            this.txtteknikDirektorId.Location = new System.Drawing.Point(204, 14);
            this.txtteknikDirektorId.Name = "txtteknikDirektorId";
            this.txtteknikDirektorId.Size = new System.Drawing.Size(145, 20);
            this.txtteknikDirektorId.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Görev Yaptığı Takım :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Doğum Tarihi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Doğum Yeri : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID : ";
            // 
            // teknikDirektor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 199);
            this.Controls.Add(this.dgwteknikDirektorListe);
            this.Controls.Add(this.btnteknikDirektorListele);
            this.Controls.Add(this.dtpteknikDirektorDtarihi);
            this.Controls.Add(this.cmbteknikDirektorTakim);
            this.Controls.Add(this.cmbteknikDirektorDyeri);
            this.Controls.Add(this.btnteknikDirektorGuncelle);
            this.Controls.Add(this.btnteknikDirektorEkle);
            this.Controls.Add(this.btnteknikDirektorSil);
            this.Controls.Add(this.txtteknikDirektorAdSoyad);
            this.Controls.Add(this.txtteknikDirektorId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "teknikDirektor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeknikDirektor Ekranı";
            this.Load += new System.EventHandler(this.teknikDirektor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwteknikDirektorListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwteknikDirektorListe;
        private System.Windows.Forms.Button btnteknikDirektorListele;
        private System.Windows.Forms.DateTimePicker dtpteknikDirektorDtarihi;
        private System.Windows.Forms.ComboBox cmbteknikDirektorTakim;
        private System.Windows.Forms.ComboBox cmbteknikDirektorDyeri;
        private System.Windows.Forms.Button btnteknikDirektorGuncelle;
        private System.Windows.Forms.Button btnteknikDirektorEkle;
        private System.Windows.Forms.Button btnteknikDirektorSil;
        private System.Windows.Forms.TextBox txtteknikDirektorAdSoyad;
        private System.Windows.Forms.TextBox txtteknikDirektorId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}