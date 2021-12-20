
namespace veriTabaniProje
{
    partial class stadyum
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
            this.dgwstadyumListe = new System.Windows.Forms.DataGridView();
            this.btnstadyumListele = new System.Windows.Forms.Button();
            this.dtpstadyumYapimYili = new System.Windows.Forms.DateTimePicker();
            this.cmbstadyumTakim = new System.Windows.Forms.ComboBox();
            this.cmbstadyumSehir = new System.Windows.Forms.ComboBox();
            this.btnstadyumGuncelle = new System.Windows.Forms.Button();
            this.btnstadyumEkle = new System.Windows.Forms.Button();
            this.btnstadyumSil = new System.Windows.Forms.Button();
            this.txtstadyumIsim = new System.Windows.Forms.TextBox();
            this.txtstadyumId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwstadyumListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwstadyumListe
            // 
            this.dgwstadyumListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwstadyumListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwstadyumListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwstadyumListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwstadyumListe.Location = new System.Drawing.Point(353, 14);
            this.dgwstadyumListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwstadyumListe.Name = "dgwstadyumListe";
            this.dgwstadyumListe.ReadOnly = true;
            this.dgwstadyumListe.Size = new System.Drawing.Size(391, 174);
            this.dgwstadyumListe.TabIndex = 39;
            // 
            // btnstadyumListele
            // 
            this.btnstadyumListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstadyumListele.Location = new System.Drawing.Point(186, 166);
            this.btnstadyumListele.Name = "btnstadyumListele";
            this.btnstadyumListele.Size = new System.Drawing.Size(163, 22);
            this.btnstadyumListele.TabIndex = 38;
            this.btnstadyumListele.Text = "Listele";
            this.btnstadyumListele.UseVisualStyleBackColor = true;
            this.btnstadyumListele.Click += new System.EventHandler(this.btnstadyumListele_Click);
            // 
            // dtpstadyumYapimYili
            // 
            this.dtpstadyumYapimYili.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpstadyumYapimYili.Location = new System.Drawing.Point(204, 86);
            this.dtpstadyumYapimYili.Name = "dtpstadyumYapimYili";
            this.dtpstadyumYapimYili.Size = new System.Drawing.Size(145, 20);
            this.dtpstadyumYapimYili.TabIndex = 37;
            // 
            // cmbstadyumTakim
            // 
            this.cmbstadyumTakim.FormattingEnabled = true;
            this.cmbstadyumTakim.Location = new System.Drawing.Point(204, 109);
            this.cmbstadyumTakim.Name = "cmbstadyumTakim";
            this.cmbstadyumTakim.Size = new System.Drawing.Size(145, 21);
            this.cmbstadyumTakim.TabIndex = 35;
            // 
            // cmbstadyumSehir
            // 
            this.cmbstadyumSehir.FormattingEnabled = true;
            this.cmbstadyumSehir.Location = new System.Drawing.Point(204, 61);
            this.cmbstadyumSehir.Name = "cmbstadyumSehir";
            this.cmbstadyumSehir.Size = new System.Drawing.Size(145, 21);
            this.cmbstadyumSehir.TabIndex = 36;
            // 
            // btnstadyumGuncelle
            // 
            this.btnstadyumGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstadyumGuncelle.Location = new System.Drawing.Point(186, 141);
            this.btnstadyumGuncelle.Name = "btnstadyumGuncelle";
            this.btnstadyumGuncelle.Size = new System.Drawing.Size(163, 22);
            this.btnstadyumGuncelle.TabIndex = 32;
            this.btnstadyumGuncelle.Text = "Güncelle";
            this.btnstadyumGuncelle.UseVisualStyleBackColor = true;
            this.btnstadyumGuncelle.Click += new System.EventHandler(this.btnstadyumGuncelle_Click);
            // 
            // btnstadyumEkle
            // 
            this.btnstadyumEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstadyumEkle.Location = new System.Drawing.Point(16, 141);
            this.btnstadyumEkle.Name = "btnstadyumEkle";
            this.btnstadyumEkle.Size = new System.Drawing.Size(163, 22);
            this.btnstadyumEkle.TabIndex = 33;
            this.btnstadyumEkle.Text = "Ekle";
            this.btnstadyumEkle.UseVisualStyleBackColor = true;
            this.btnstadyumEkle.Click += new System.EventHandler(this.btnstadyumEkle_Click);
            // 
            // btnstadyumSil
            // 
            this.btnstadyumSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstadyumSil.Location = new System.Drawing.Point(16, 166);
            this.btnstadyumSil.Name = "btnstadyumSil";
            this.btnstadyumSil.Size = new System.Drawing.Size(163, 22);
            this.btnstadyumSil.TabIndex = 34;
            this.btnstadyumSil.Text = "Sil";
            this.btnstadyumSil.UseVisualStyleBackColor = true;
            this.btnstadyumSil.Click += new System.EventHandler(this.btnstadyumSil_Click);
            // 
            // txtstadyumIsim
            // 
            this.txtstadyumIsim.Location = new System.Drawing.Point(204, 38);
            this.txtstadyumIsim.Name = "txtstadyumIsim";
            this.txtstadyumIsim.Size = new System.Drawing.Size(145, 20);
            this.txtstadyumIsim.TabIndex = 30;
            // 
            // txtstadyumId
            // 
            this.txtstadyumId.Location = new System.Drawing.Point(204, 14);
            this.txtstadyumId.Name = "txtstadyumId";
            this.txtstadyumId.Size = new System.Drawing.Size(145, 20);
            this.txtstadyumId.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Takım :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Yapılış Tarihi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Şehir : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "İsim :";
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
            // stadyum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 199);
            this.Controls.Add(this.dgwstadyumListe);
            this.Controls.Add(this.btnstadyumListele);
            this.Controls.Add(this.dtpstadyumYapimYili);
            this.Controls.Add(this.cmbstadyumTakim);
            this.Controls.Add(this.cmbstadyumSehir);
            this.Controls.Add(this.btnstadyumGuncelle);
            this.Controls.Add(this.btnstadyumEkle);
            this.Controls.Add(this.btnstadyumSil);
            this.Controls.Add(this.txtstadyumIsim);
            this.Controls.Add(this.txtstadyumId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "stadyum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stadyum";
            this.Load += new System.EventHandler(this.stadyum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwstadyumListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwstadyumListe;
        private System.Windows.Forms.Button btnstadyumListele;
        private System.Windows.Forms.DateTimePicker dtpstadyumYapimYili;
        private System.Windows.Forms.ComboBox cmbstadyumTakim;
        private System.Windows.Forms.ComboBox cmbstadyumSehir;
        private System.Windows.Forms.Button btnstadyumGuncelle;
        private System.Windows.Forms.Button btnstadyumEkle;
        private System.Windows.Forms.Button btnstadyumSil;
        private System.Windows.Forms.TextBox txtstadyumIsim;
        private System.Windows.Forms.TextBox txtstadyumId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}