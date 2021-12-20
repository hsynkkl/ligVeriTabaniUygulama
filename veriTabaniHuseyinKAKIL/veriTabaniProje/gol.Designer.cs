
namespace veriTabaniProje
{
    partial class gol
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
            this.dgwgolListe = new System.Windows.Forms.DataGridView();
            this.btngolListele = new System.Windows.Forms.Button();
            this.cmbgolMacId = new System.Windows.Forms.ComboBox();
            this.btngolGuncelle = new System.Windows.Forms.Button();
            this.btngolEkle = new System.Windows.Forms.Button();
            this.btngolSil = new System.Windows.Forms.Button();
            this.txtgolId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbgolGolcuId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwgolListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwgolListe
            // 
            this.dgwgolListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwgolListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwgolListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwgolListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwgolListe.Location = new System.Drawing.Point(353, 14);
            this.dgwgolListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwgolListe.Name = "dgwgolListe";
            this.dgwgolListe.ReadOnly = true;
            this.dgwgolListe.Size = new System.Drawing.Size(391, 174);
            this.dgwgolListe.TabIndex = 39;
            // 
            // btngolListele
            // 
            this.btngolListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngolListele.Location = new System.Drawing.Point(186, 166);
            this.btngolListele.Name = "btngolListele";
            this.btngolListele.Size = new System.Drawing.Size(163, 22);
            this.btngolListele.TabIndex = 38;
            this.btngolListele.Text = "Listele";
            this.btngolListele.UseVisualStyleBackColor = true;
            this.btngolListele.Click += new System.EventHandler(this.btngolListele_Click);
            // 
            // cmbgolMacId
            // 
            this.cmbgolMacId.FormattingEnabled = true;
            this.cmbgolMacId.Location = new System.Drawing.Point(204, 61);
            this.cmbgolMacId.Name = "cmbgolMacId";
            this.cmbgolMacId.Size = new System.Drawing.Size(145, 21);
            this.cmbgolMacId.TabIndex = 36;
            // 
            // btngolGuncelle
            // 
            this.btngolGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngolGuncelle.Location = new System.Drawing.Point(186, 141);
            this.btngolGuncelle.Name = "btngolGuncelle";
            this.btngolGuncelle.Size = new System.Drawing.Size(163, 22);
            this.btngolGuncelle.TabIndex = 32;
            this.btngolGuncelle.Text = "Güncelle";
            this.btngolGuncelle.UseVisualStyleBackColor = true;
            this.btngolGuncelle.Click += new System.EventHandler(this.btngolGuncelle_Click);
            // 
            // btngolEkle
            // 
            this.btngolEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngolEkle.Location = new System.Drawing.Point(16, 141);
            this.btngolEkle.Name = "btngolEkle";
            this.btngolEkle.Size = new System.Drawing.Size(163, 22);
            this.btngolEkle.TabIndex = 33;
            this.btngolEkle.Text = "Ekle";
            this.btngolEkle.UseVisualStyleBackColor = true;
            this.btngolEkle.Click += new System.EventHandler(this.btngolEkle_Click);
            // 
            // btngolSil
            // 
            this.btngolSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngolSil.Location = new System.Drawing.Point(16, 166);
            this.btngolSil.Name = "btngolSil";
            this.btngolSil.Size = new System.Drawing.Size(163, 22);
            this.btngolSil.TabIndex = 34;
            this.btngolSil.Text = "Sil";
            this.btngolSil.UseVisualStyleBackColor = true;
            this.btngolSil.Click += new System.EventHandler(this.btngolSil_Click);
            // 
            // txtgolId
            // 
            this.txtgolId.Location = new System.Drawing.Point(204, 14);
            this.txtgolId.Name = "txtgolId";
            this.txtgolId.Size = new System.Drawing.Size(145, 20);
            this.txtgolId.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Maç ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Golcü ID : ";
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
            // cmbgolGolcuId
            // 
            this.cmbgolGolcuId.FormattingEnabled = true;
            this.cmbgolGolcuId.Location = new System.Drawing.Point(204, 38);
            this.cmbgolGolcuId.Name = "cmbgolGolcuId";
            this.cmbgolGolcuId.Size = new System.Drawing.Size(145, 21);
            this.cmbgolGolcuId.TabIndex = 36;
            // 
            // gol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 199);
            this.Controls.Add(this.dgwgolListe);
            this.Controls.Add(this.btngolListele);
            this.Controls.Add(this.cmbgolGolcuId);
            this.Controls.Add(this.cmbgolMacId);
            this.Controls.Add(this.btngolGuncelle);
            this.Controls.Add(this.btngolEkle);
            this.Controls.Add(this.btngolSil);
            this.Controls.Add(this.txtgolId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "gol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gol";
            this.Load += new System.EventHandler(this.gol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwgolListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwgolListe;
        private System.Windows.Forms.Button btngolListele;
        private System.Windows.Forms.ComboBox cmbgolMacId;
        private System.Windows.Forms.Button btngolGuncelle;
        private System.Windows.Forms.Button btngolEkle;
        private System.Windows.Forms.Button btngolSil;
        private System.Windows.Forms.TextBox txtgolId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbgolGolcuId;
    }
}