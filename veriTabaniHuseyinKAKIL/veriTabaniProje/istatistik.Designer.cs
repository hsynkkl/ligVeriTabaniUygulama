
namespace veriTabaniProje
{
    partial class istatistik
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwistatistikListe = new System.Windows.Forms.DataGridView();
            this.btnistatistikSariKartSayisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbistatistikFutbolcuId = new System.Windows.Forms.ComboBox();
            this.btnistatistikGolSayisi = new System.Windows.Forms.Button();
            this.btnistatistikToplamGoleKatki = new System.Windows.Forms.Button();
            this.btnistatistikKirmiziKartSayisi = new System.Windows.Forms.Button();
            this.btnistatistikAsistSayisi = new System.Windows.Forms.Button();
            this.btnistatistikFutbolcuSayisi = new System.Windows.Forms.Button();
            this.btnistatistikTakimSayisi = new System.Windows.Forms.Button();
            this.btnistatistikHakemSayisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwistatistikListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwistatistikListe
            // 
            this.dgwistatistikListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwistatistikListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwistatistikListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwistatistikListe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwistatistikListe.Location = new System.Drawing.Point(353, 14);
            this.dgwistatistikListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwistatistikListe.Name = "dgwistatistikListe";
            this.dgwistatistikListe.ReadOnly = true;
            this.dgwistatistikListe.Size = new System.Drawing.Size(391, 174);
            this.dgwistatistikListe.TabIndex = 39;
            // 
            // btnistatistikSariKartSayisi
            // 
            this.btnistatistikSariKartSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnistatistikSariKartSayisi.Location = new System.Drawing.Point(16, 136);
            this.btnistatistikSariKartSayisi.Name = "btnistatistikSariKartSayisi";
            this.btnistatistikSariKartSayisi.Size = new System.Drawing.Size(163, 22);
            this.btnistatistikSariKartSayisi.TabIndex = 33;
            this.btnistatistikSariKartSayisi.Text = "Sarı Kart Sayısı";
            this.btnistatistikSariKartSayisi.UseVisualStyleBackColor = true;
            this.btnistatistikSariKartSayisi.Click += new System.EventHandler(this.btnistatistikSariKartSayisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Futbolcu :";
            // 
            // cmbistatistikFutbolcuId
            // 
            this.cmbistatistikFutbolcuId.FormattingEnabled = true;
            this.cmbistatistikFutbolcuId.Location = new System.Drawing.Point(204, 14);
            this.cmbistatistikFutbolcuId.Name = "cmbistatistikFutbolcuId";
            this.cmbistatistikFutbolcuId.Size = new System.Drawing.Size(145, 21);
            this.cmbistatistikFutbolcuId.TabIndex = 40;
            // 
            // btnistatistikGolSayisi
            // 
            this.btnistatistikGolSayisi.Location = new System.Drawing.Point(16, 80);
            this.btnistatistikGolSayisi.Name = "btnistatistikGolSayisi";
            this.btnistatistikGolSayisi.Size = new System.Drawing.Size(163, 22);
            this.btnistatistikGolSayisi.TabIndex = 41;
            this.btnistatistikGolSayisi.Text = "Gol Sayısı";
            this.btnistatistikGolSayisi.UseVisualStyleBackColor = true;
            this.btnistatistikGolSayisi.Click += new System.EventHandler(this.btnistatistikGolSayisi_Click);
            // 
            // btnistatistikToplamGoleKatki
            // 
            this.btnistatistikToplamGoleKatki.Location = new System.Drawing.Point(16, 108);
            this.btnistatistikToplamGoleKatki.Name = "btnistatistikToplamGoleKatki";
            this.btnistatistikToplamGoleKatki.Size = new System.Drawing.Size(163, 22);
            this.btnistatistikToplamGoleKatki.TabIndex = 41;
            this.btnistatistikToplamGoleKatki.Text = "Toplam Gole Katkısı";
            this.btnistatistikToplamGoleKatki.UseVisualStyleBackColor = true;
            this.btnistatistikToplamGoleKatki.Click += new System.EventHandler(this.btnistatistikToplamGoleKatki_Click);
            // 
            // btnistatistikKirmiziKartSayisi
            // 
            this.btnistatistikKirmiziKartSayisi.Location = new System.Drawing.Point(186, 108);
            this.btnistatistikKirmiziKartSayisi.Name = "btnistatistikKirmiziKartSayisi";
            this.btnistatistikKirmiziKartSayisi.Size = new System.Drawing.Size(163, 22);
            this.btnistatistikKirmiziKartSayisi.TabIndex = 42;
            this.btnistatistikKirmiziKartSayisi.Text = "Kırmızı Kart Sayısı";
            this.btnistatistikKirmiziKartSayisi.UseVisualStyleBackColor = true;
            this.btnistatistikKirmiziKartSayisi.Click += new System.EventHandler(this.btnistatistikKirmiziKartSayisi_Click);
            // 
            // btnistatistikAsistSayisi
            // 
            this.btnistatistikAsistSayisi.Location = new System.Drawing.Point(186, 80);
            this.btnistatistikAsistSayisi.Name = "btnistatistikAsistSayisi";
            this.btnistatistikAsistSayisi.Size = new System.Drawing.Size(163, 22);
            this.btnistatistikAsistSayisi.TabIndex = 43;
            this.btnistatistikAsistSayisi.Text = "Asist Sayısı";
            this.btnistatistikAsistSayisi.UseVisualStyleBackColor = true;
            this.btnistatistikAsistSayisi.Click += new System.EventHandler(this.btnistatistikAsistSayisi_Click);
            // 
            // btnistatistikFutbolcuSayisi
            // 
            this.btnistatistikFutbolcuSayisi.Location = new System.Drawing.Point(186, 136);
            this.btnistatistikFutbolcuSayisi.Name = "btnistatistikFutbolcuSayisi";
            this.btnistatistikFutbolcuSayisi.Size = new System.Drawing.Size(163, 22);
            this.btnistatistikFutbolcuSayisi.TabIndex = 44;
            this.btnistatistikFutbolcuSayisi.Text = "Ligteki Futbolcu Sayisi";
            this.btnistatistikFutbolcuSayisi.UseVisualStyleBackColor = true;
            this.btnistatistikFutbolcuSayisi.Click += new System.EventHandler(this.btnistatistikFutbolcuSayisi_Click);
            // 
            // btnistatistikTakimSayisi
            // 
            this.btnistatistikTakimSayisi.Location = new System.Drawing.Point(16, 165);
            this.btnistatistikTakimSayisi.Name = "btnistatistikTakimSayisi";
            this.btnistatistikTakimSayisi.Size = new System.Drawing.Size(163, 22);
            this.btnistatistikTakimSayisi.TabIndex = 45;
            this.btnistatistikTakimSayisi.Text = "Ligteki Takım Sayısı";
            this.btnistatistikTakimSayisi.UseVisualStyleBackColor = true;
            this.btnistatistikTakimSayisi.Click += new System.EventHandler(this.btnistatistikTakimSayisi_Click);
            // 
            // btnistatistikHakemSayisi
            // 
            this.btnistatistikHakemSayisi.Location = new System.Drawing.Point(186, 165);
            this.btnistatistikHakemSayisi.Name = "btnistatistikHakemSayisi";
            this.btnistatistikHakemSayisi.Size = new System.Drawing.Size(163, 22);
            this.btnistatistikHakemSayisi.TabIndex = 46;
            this.btnistatistikHakemSayisi.Text = "Ligteki Hakem Sayısı";
            this.btnistatistikHakemSayisi.UseVisualStyleBackColor = true;
            this.btnistatistikHakemSayisi.Click += new System.EventHandler(this.btnistatistikHakemSayisi_Click);
            // 
            // istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 199);
            this.Controls.Add(this.btnistatistikHakemSayisi);
            this.Controls.Add(this.btnistatistikTakimSayisi);
            this.Controls.Add(this.btnistatistikFutbolcuSayisi);
            this.Controls.Add(this.btnistatistikKirmiziKartSayisi);
            this.Controls.Add(this.btnistatistikAsistSayisi);
            this.Controls.Add(this.btnistatistikToplamGoleKatki);
            this.Controls.Add(this.btnistatistikGolSayisi);
            this.Controls.Add(this.cmbistatistikFutbolcuId);
            this.Controls.Add(this.dgwistatistikListe);
            this.Controls.Add(this.btnistatistikSariKartSayisi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "istatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "istatistik";
            this.Load += new System.EventHandler(this.istatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwistatistikListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwistatistikListe;
        private System.Windows.Forms.Button btnistatistikSariKartSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbistatistikFutbolcuId;
        private System.Windows.Forms.Button btnistatistikGolSayisi;
        private System.Windows.Forms.Button btnistatistikToplamGoleKatki;
        private System.Windows.Forms.Button btnistatistikKirmiziKartSayisi;
        private System.Windows.Forms.Button btnistatistikAsistSayisi;
        private System.Windows.Forms.Button btnistatistikFutbolcuSayisi;
        private System.Windows.Forms.Button btnistatistikTakimSayisi;
        private System.Windows.Forms.Button btnistatistikHakemSayisi;
    }
}