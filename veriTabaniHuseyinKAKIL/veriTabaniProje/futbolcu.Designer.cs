
namespace veriTabaniProje
{
    partial class futbolcu
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
            this.dtpfutbolcuDtarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbfutbolcuDyeri = new System.Windows.Forms.ComboBox();
            this.btnfutbolcuSil = new System.Windows.Forms.Button();
            this.txtfutbolcuAdSoyad = new System.Windows.Forms.TextBox();
            this.txtfutbolcuId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfutbolcuEkle = new System.Windows.Forms.Button();
            this.btnfutbolcuGuncelle = new System.Windows.Forms.Button();
            this.cmbfutbolcuTakim = new System.Windows.Forms.ComboBox();
            this.btnfutbolcuListele = new System.Windows.Forms.Button();
            this.dgwfutbolcuListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwfutbolcuListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpfutbolcuDtarihi
            // 
            this.dtpfutbolcuDtarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpfutbolcuDtarihi.Location = new System.Drawing.Point(207, 85);
            this.dtpfutbolcuDtarihi.Name = "dtpfutbolcuDtarihi";
            this.dtpfutbolcuDtarihi.Size = new System.Drawing.Size(145, 20);
            this.dtpfutbolcuDtarihi.TabIndex = 16;
            // 
            // cmbfutbolcuDyeri
            // 
            this.cmbfutbolcuDyeri.FormattingEnabled = true;
            this.cmbfutbolcuDyeri.Location = new System.Drawing.Point(207, 60);
            this.cmbfutbolcuDyeri.Name = "cmbfutbolcuDyeri";
            this.cmbfutbolcuDyeri.Size = new System.Drawing.Size(145, 21);
            this.cmbfutbolcuDyeri.TabIndex = 15;
            // 
            // btnfutbolcuSil
            // 
            this.btnfutbolcuSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfutbolcuSil.Location = new System.Drawing.Point(19, 165);
            this.btnfutbolcuSil.Name = "btnfutbolcuSil";
            this.btnfutbolcuSil.Size = new System.Drawing.Size(163, 22);
            this.btnfutbolcuSil.TabIndex = 14;
            this.btnfutbolcuSil.Text = "Sil";
            this.btnfutbolcuSil.UseVisualStyleBackColor = true;
            this.btnfutbolcuSil.Click += new System.EventHandler(this.btnfutbolcuSil_Click);
            // 
            // txtfutbolcuAdSoyad
            // 
            this.txtfutbolcuAdSoyad.Location = new System.Drawing.Point(207, 37);
            this.txtfutbolcuAdSoyad.Name = "txtfutbolcuAdSoyad";
            this.txtfutbolcuAdSoyad.Size = new System.Drawing.Size(145, 20);
            this.txtfutbolcuAdSoyad.TabIndex = 11;
            // 
            // txtfutbolcuId
            // 
            this.txtfutbolcuId.Location = new System.Drawing.Point(207, 13);
            this.txtfutbolcuId.Name = "txtfutbolcuId";
            this.txtfutbolcuId.Size = new System.Drawing.Size(145, 20);
            this.txtfutbolcuId.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Görev Yaptığı Takım :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Tarihi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doğum Yeri : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID : ";
            // 
            // btnfutbolcuEkle
            // 
            this.btnfutbolcuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfutbolcuEkle.Location = new System.Drawing.Point(19, 140);
            this.btnfutbolcuEkle.Name = "btnfutbolcuEkle";
            this.btnfutbolcuEkle.Size = new System.Drawing.Size(163, 22);
            this.btnfutbolcuEkle.TabIndex = 14;
            this.btnfutbolcuEkle.Text = "Ekle";
            this.btnfutbolcuEkle.UseVisualStyleBackColor = true;
            this.btnfutbolcuEkle.Click += new System.EventHandler(this.btnfutbolcuEkle_Click);
            // 
            // btnfutbolcuGuncelle
            // 
            this.btnfutbolcuGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfutbolcuGuncelle.Location = new System.Drawing.Point(189, 140);
            this.btnfutbolcuGuncelle.Name = "btnfutbolcuGuncelle";
            this.btnfutbolcuGuncelle.Size = new System.Drawing.Size(163, 22);
            this.btnfutbolcuGuncelle.TabIndex = 13;
            this.btnfutbolcuGuncelle.Text = "Güncelle";
            this.btnfutbolcuGuncelle.UseVisualStyleBackColor = true;
            this.btnfutbolcuGuncelle.Click += new System.EventHandler(this.btnfutbolcuGuncelle_Click);
            // 
            // cmbfutbolcuTakim
            // 
            this.cmbfutbolcuTakim.FormattingEnabled = true;
            this.cmbfutbolcuTakim.Location = new System.Drawing.Point(207, 108);
            this.cmbfutbolcuTakim.Name = "cmbfutbolcuTakim";
            this.cmbfutbolcuTakim.Size = new System.Drawing.Size(145, 21);
            this.cmbfutbolcuTakim.TabIndex = 15;
            // 
            // btnfutbolcuListele
            // 
            this.btnfutbolcuListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfutbolcuListele.Location = new System.Drawing.Point(189, 165);
            this.btnfutbolcuListele.Name = "btnfutbolcuListele";
            this.btnfutbolcuListele.Size = new System.Drawing.Size(163, 22);
            this.btnfutbolcuListele.TabIndex = 17;
            this.btnfutbolcuListele.Text = "Listele";
            this.btnfutbolcuListele.UseVisualStyleBackColor = true;
            this.btnfutbolcuListele.Click += new System.EventHandler(this.btnfutbolcuListele_Click);
            // 
            // dgwfutbolcuListe
            // 
            this.dgwfutbolcuListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwfutbolcuListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwfutbolcuListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwfutbolcuListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwfutbolcuListe.Location = new System.Drawing.Point(356, 13);
            this.dgwfutbolcuListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwfutbolcuListe.Name = "dgwfutbolcuListe";
            this.dgwfutbolcuListe.ReadOnly = true;
            this.dgwfutbolcuListe.Size = new System.Drawing.Size(391, 174);
            this.dgwfutbolcuListe.TabIndex = 24;
            // 
            // futbolcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 199);
            this.Controls.Add(this.dgwfutbolcuListe);
            this.Controls.Add(this.btnfutbolcuListele);
            this.Controls.Add(this.dtpfutbolcuDtarihi);
            this.Controls.Add(this.cmbfutbolcuTakim);
            this.Controls.Add(this.cmbfutbolcuDyeri);
            this.Controls.Add(this.btnfutbolcuGuncelle);
            this.Controls.Add(this.btnfutbolcuEkle);
            this.Controls.Add(this.btnfutbolcuSil);
            this.Controls.Add(this.txtfutbolcuAdSoyad);
            this.Controls.Add(this.txtfutbolcuId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "futbolcu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "futbolcu";
            this.Load += new System.EventHandler(this.futbolcu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwfutbolcuListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpfutbolcuDtarihi;
        private System.Windows.Forms.ComboBox cmbfutbolcuDyeri;
        private System.Windows.Forms.Button btnfutbolcuSil;
        private System.Windows.Forms.TextBox txtfutbolcuAdSoyad;
        private System.Windows.Forms.TextBox txtfutbolcuId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfutbolcuEkle;
        private System.Windows.Forms.Button btnfutbolcuGuncelle;
        private System.Windows.Forms.ComboBox cmbfutbolcuTakim;
        private System.Windows.Forms.Button btnfutbolcuListele;
        private System.Windows.Forms.DataGridView dgwfutbolcuListe;
    }
}