
namespace veriTabaniProje
{
    partial class sehir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwsehirListe = new System.Windows.Forms.DataGridView();
            this.btnsehirListele = new System.Windows.Forms.Button();
            this.btnsehirGuncelle = new System.Windows.Forms.Button();
            this.btnsehirEkle = new System.Windows.Forms.Button();
            this.btnsehirSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsehirId = new System.Windows.Forms.TextBox();
            this.txtsehirIsim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwsehirListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwsehirListe
            // 
            this.dgwsehirListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwsehirListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgwsehirListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwsehirListe.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgwsehirListe.Location = new System.Drawing.Point(353, 14);
            this.dgwsehirListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwsehirListe.Name = "dgwsehirListe";
            this.dgwsehirListe.ReadOnly = true;
            this.dgwsehirListe.Size = new System.Drawing.Size(391, 174);
            this.dgwsehirListe.TabIndex = 48;
            // 
            // btnsehirListele
            // 
            this.btnsehirListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsehirListele.Location = new System.Drawing.Point(186, 166);
            this.btnsehirListele.Name = "btnsehirListele";
            this.btnsehirListele.Size = new System.Drawing.Size(163, 22);
            this.btnsehirListele.TabIndex = 47;
            this.btnsehirListele.Text = "Listele";
            this.btnsehirListele.UseVisualStyleBackColor = true;
            this.btnsehirListele.Click += new System.EventHandler(this.btnsehirListele_Click);
            // 
            // btnsehirGuncelle
            // 
            this.btnsehirGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsehirGuncelle.Location = new System.Drawing.Point(186, 141);
            this.btnsehirGuncelle.Name = "btnsehirGuncelle";
            this.btnsehirGuncelle.Size = new System.Drawing.Size(163, 22);
            this.btnsehirGuncelle.TabIndex = 42;
            this.btnsehirGuncelle.Text = "Güncelle";
            this.btnsehirGuncelle.UseVisualStyleBackColor = true;
            this.btnsehirGuncelle.Click += new System.EventHandler(this.btnsehirGuncelle_Click);
            // 
            // btnsehirEkle
            // 
            this.btnsehirEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsehirEkle.Location = new System.Drawing.Point(16, 141);
            this.btnsehirEkle.Name = "btnsehirEkle";
            this.btnsehirEkle.Size = new System.Drawing.Size(163, 22);
            this.btnsehirEkle.TabIndex = 43;
            this.btnsehirEkle.Text = "Ekle";
            this.btnsehirEkle.UseVisualStyleBackColor = true;
            this.btnsehirEkle.Click += new System.EventHandler(this.btnsehirEkle_Click);
            // 
            // btnsehirSil
            // 
            this.btnsehirSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsehirSil.Location = new System.Drawing.Point(16, 166);
            this.btnsehirSil.Name = "btnsehirSil";
            this.btnsehirSil.Size = new System.Drawing.Size(163, 22);
            this.btnsehirSil.TabIndex = 44;
            this.btnsehirSil.Text = "Sil";
            this.btnsehirSil.UseVisualStyleBackColor = true;
            this.btnsehirSil.Click += new System.EventHandler(this.btnsehirSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "İsim : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID";
            // 
            // txtsehirId
            // 
            this.txtsehirId.Location = new System.Drawing.Point(204, 14);
            this.txtsehirId.Name = "txtsehirId";
            this.txtsehirId.Size = new System.Drawing.Size(145, 20);
            this.txtsehirId.TabIndex = 49;
            // 
            // txtsehirIsim
            // 
            this.txtsehirIsim.Location = new System.Drawing.Point(204, 38);
            this.txtsehirIsim.Name = "txtsehirIsim";
            this.txtsehirIsim.Size = new System.Drawing.Size(145, 20);
            this.txtsehirIsim.TabIndex = 49;
            // 
            // sehir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 199);
            this.Controls.Add(this.txtsehirIsim);
            this.Controls.Add(this.txtsehirId);
            this.Controls.Add(this.dgwsehirListe);
            this.Controls.Add(this.btnsehirListele);
            this.Controls.Add(this.btnsehirGuncelle);
            this.Controls.Add(this.btnsehirEkle);
            this.Controls.Add(this.btnsehirSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "sehir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sehir";
            ((System.ComponentModel.ISupportInitialize)(this.dgwsehirListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwsehirListe;
        private System.Windows.Forms.Button btnsehirListele;
        private System.Windows.Forms.Button btnsehirGuncelle;
        private System.Windows.Forms.Button btnsehirEkle;
        private System.Windows.Forms.Button btnsehirSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsehirId;
        private System.Windows.Forms.TextBox txtsehirIsim;
    }
}