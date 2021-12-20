
namespace veriTabaniProje
{
    partial class mac
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
            this.dgwmacListe = new System.Windows.Forms.DataGridView();
            this.btnmacListele = new System.Windows.Forms.Button();
            this.dtpmacTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbmacStadyumId = new System.Windows.Forms.ComboBox();
            this.cmbmacTakim2Id = new System.Windows.Forms.ComboBox();
            this.btnmacGuncelle = new System.Windows.Forms.Button();
            this.btnmacEkle = new System.Windows.Forms.Button();
            this.btnmacSil = new System.Windows.Forms.Button();
            this.txtmacId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbmacTakim1Id = new System.Windows.Forms.ComboBox();
            this.txtmacSonuc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbmacHakemId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwmacListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwmacListe
            // 
            this.dgwmacListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwmacListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwmacListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwmacListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwmacListe.Location = new System.Drawing.Point(353, 14);
            this.dgwmacListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwmacListe.Name = "dgwmacListe";
            this.dgwmacListe.ReadOnly = true;
            this.dgwmacListe.Size = new System.Drawing.Size(443, 224);
            this.dgwmacListe.TabIndex = 39;
            // 
            // btnmacListele
            // 
            this.btnmacListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmacListele.Location = new System.Drawing.Point(186, 216);
            this.btnmacListele.Name = "btnmacListele";
            this.btnmacListele.Size = new System.Drawing.Size(163, 22);
            this.btnmacListele.TabIndex = 38;
            this.btnmacListele.Text = "Listele";
            this.btnmacListele.UseVisualStyleBackColor = true;
            this.btnmacListele.Click += new System.EventHandler(this.btnmacListele_Click);
            // 
            // dtpmacTarih
            // 
            this.dtpmacTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpmacTarih.Location = new System.Drawing.Point(204, 86);
            this.dtpmacTarih.Name = "dtpmacTarih";
            this.dtpmacTarih.Size = new System.Drawing.Size(145, 20);
            this.dtpmacTarih.TabIndex = 37;
            // 
            // cmbmacStadyumId
            // 
            this.cmbmacStadyumId.FormattingEnabled = true;
            this.cmbmacStadyumId.Location = new System.Drawing.Point(204, 109);
            this.cmbmacStadyumId.Name = "cmbmacStadyumId";
            this.cmbmacStadyumId.Size = new System.Drawing.Size(145, 21);
            this.cmbmacStadyumId.TabIndex = 35;
            // 
            // cmbmacTakim2Id
            // 
            this.cmbmacTakim2Id.FormattingEnabled = true;
            this.cmbmacTakim2Id.Location = new System.Drawing.Point(204, 61);
            this.cmbmacTakim2Id.Name = "cmbmacTakim2Id";
            this.cmbmacTakim2Id.Size = new System.Drawing.Size(145, 21);
            this.cmbmacTakim2Id.TabIndex = 36;
            // 
            // btnmacGuncelle
            // 
            this.btnmacGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmacGuncelle.Location = new System.Drawing.Point(186, 191);
            this.btnmacGuncelle.Name = "btnmacGuncelle";
            this.btnmacGuncelle.Size = new System.Drawing.Size(163, 22);
            this.btnmacGuncelle.TabIndex = 32;
            this.btnmacGuncelle.Text = "Güncelle";
            this.btnmacGuncelle.UseVisualStyleBackColor = true;
            this.btnmacGuncelle.Click += new System.EventHandler(this.btnmacGuncelle_Click);
            // 
            // btnmacEkle
            // 
            this.btnmacEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmacEkle.Location = new System.Drawing.Point(16, 191);
            this.btnmacEkle.Name = "btnmacEkle";
            this.btnmacEkle.Size = new System.Drawing.Size(163, 22);
            this.btnmacEkle.TabIndex = 33;
            this.btnmacEkle.Text = "Ekle";
            this.btnmacEkle.UseVisualStyleBackColor = true;
            this.btnmacEkle.Click += new System.EventHandler(this.btnmacEkle_Click);
            // 
            // btnmacSil
            // 
            this.btnmacSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmacSil.Location = new System.Drawing.Point(16, 216);
            this.btnmacSil.Name = "btnmacSil";
            this.btnmacSil.Size = new System.Drawing.Size(163, 22);
            this.btnmacSil.TabIndex = 34;
            this.btnmacSil.Text = "Sil";
            this.btnmacSil.UseVisualStyleBackColor = true;
            this.btnmacSil.Click += new System.EventHandler(this.btnmacSil_Click);
            // 
            // txtmacId
            // 
            this.txtmacId.Location = new System.Drawing.Point(204, 14);
            this.txtmacId.Name = "txtmacId";
            this.txtmacId.Size = new System.Drawing.Size(145, 20);
            this.txtmacId.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Stadyum : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tarih : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Takım 2 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Takım 1 :";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sonuç :";
            // 
            // cmbmacTakim1Id
            // 
            this.cmbmacTakim1Id.FormattingEnabled = true;
            this.cmbmacTakim1Id.Location = new System.Drawing.Point(204, 38);
            this.cmbmacTakim1Id.Name = "cmbmacTakim1Id";
            this.cmbmacTakim1Id.Size = new System.Drawing.Size(145, 21);
            this.cmbmacTakim1Id.TabIndex = 36;
            // 
            // txtmacSonuc
            // 
            this.txtmacSonuc.Location = new System.Drawing.Point(204, 134);
            this.txtmacSonuc.Name = "txtmacSonuc";
            this.txtmacSonuc.Size = new System.Drawing.Size(145, 20);
            this.txtmacSonuc.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 155);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Hakem :";
            // 
            // cmbmacHakemId
            // 
            this.cmbmacHakemId.FormattingEnabled = true;
            this.cmbmacHakemId.Location = new System.Drawing.Point(204, 157);
            this.cmbmacHakemId.Name = "cmbmacHakemId";
            this.cmbmacHakemId.Size = new System.Drawing.Size(145, 21);
            this.cmbmacHakemId.TabIndex = 35;
            // 
            // mac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 246);
            this.Controls.Add(this.dgwmacListe);
            this.Controls.Add(this.btnmacListele);
            this.Controls.Add(this.dtpmacTarih);
            this.Controls.Add(this.cmbmacHakemId);
            this.Controls.Add(this.cmbmacStadyumId);
            this.Controls.Add(this.cmbmacTakim1Id);
            this.Controls.Add(this.cmbmacTakim2Id);
            this.Controls.Add(this.btnmacGuncelle);
            this.Controls.Add(this.btnmacEkle);
            this.Controls.Add(this.btnmacSil);
            this.Controls.Add(this.txtmacSonuc);
            this.Controls.Add(this.txtmacId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mac";
            this.Load += new System.EventHandler(this.mac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwmacListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwmacListe;
        private System.Windows.Forms.Button btnmacListele;
        private System.Windows.Forms.DateTimePicker dtpmacTarih;
        private System.Windows.Forms.ComboBox cmbmacStadyumId;
        private System.Windows.Forms.ComboBox cmbmacTakim2Id;
        private System.Windows.Forms.Button btnmacGuncelle;
        private System.Windows.Forms.Button btnmacEkle;
        private System.Windows.Forms.Button btnmacSil;
        private System.Windows.Forms.TextBox txtmacId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbmacTakim1Id;
        private System.Windows.Forms.TextBox txtmacSonuc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbmacHakemId;
    }
}