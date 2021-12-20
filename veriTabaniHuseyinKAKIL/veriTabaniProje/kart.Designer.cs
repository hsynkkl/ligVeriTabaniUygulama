
namespace veriTabaniProje
{
    partial class kart
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
            this.dgwkartListe = new System.Windows.Forms.DataGridView();
            this.btnkartListele = new System.Windows.Forms.Button();
            this.cmbkartMacId = new System.Windows.Forms.ComboBox();
            this.cmbkartHakemId = new System.Windows.Forms.ComboBox();
            this.btnkartEkle = new System.Windows.Forms.Button();
            this.btnkartSil = new System.Windows.Forms.Button();
            this.txtkartId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbkartFutbolcuId = new System.Windows.Forms.ComboBox();
            this.cmbkartTur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwkartListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwkartListe
            // 
            this.dgwkartListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwkartListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwkartListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwkartListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwkartListe.Location = new System.Drawing.Point(353, 14);
            this.dgwkartListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwkartListe.Name = "dgwkartListe";
            this.dgwkartListe.ReadOnly = true;
            this.dgwkartListe.Size = new System.Drawing.Size(391, 174);
            this.dgwkartListe.TabIndex = 39;
            // 
            // btnkartListele
            // 
            this.btnkartListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkartListele.Location = new System.Drawing.Point(186, 141);
            this.btnkartListele.Name = "btnkartListele";
            this.btnkartListele.Size = new System.Drawing.Size(163, 22);
            this.btnkartListele.TabIndex = 38;
            this.btnkartListele.Text = "Listele";
            this.btnkartListele.UseVisualStyleBackColor = true;
            this.btnkartListele.Click += new System.EventHandler(this.btnkartListele_Click);
            // 
            // cmbkartMacId
            // 
            this.cmbkartMacId.FormattingEnabled = true;
            this.cmbkartMacId.Location = new System.Drawing.Point(204, 109);
            this.cmbkartMacId.Name = "cmbkartMacId";
            this.cmbkartMacId.Size = new System.Drawing.Size(145, 21);
            this.cmbkartMacId.TabIndex = 35;
            // 
            // cmbkartHakemId
            // 
            this.cmbkartHakemId.FormattingEnabled = true;
            this.cmbkartHakemId.Location = new System.Drawing.Point(204, 61);
            this.cmbkartHakemId.Name = "cmbkartHakemId";
            this.cmbkartHakemId.Size = new System.Drawing.Size(145, 21);
            this.cmbkartHakemId.TabIndex = 36;
            // 
            // btnkartEkle
            // 
            this.btnkartEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkartEkle.Location = new System.Drawing.Point(16, 141);
            this.btnkartEkle.Name = "btnkartEkle";
            this.btnkartEkle.Size = new System.Drawing.Size(163, 22);
            this.btnkartEkle.TabIndex = 33;
            this.btnkartEkle.Text = "Ekle";
            this.btnkartEkle.UseVisualStyleBackColor = true;
            this.btnkartEkle.Click += new System.EventHandler(this.btnkartEkle_Click);
            // 
            // btnkartSil
            // 
            this.btnkartSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkartSil.Location = new System.Drawing.Point(16, 166);
            this.btnkartSil.Name = "btnkartSil";
            this.btnkartSil.Size = new System.Drawing.Size(163, 22);
            this.btnkartSil.TabIndex = 34;
            this.btnkartSil.Text = "Sil";
            this.btnkartSil.UseVisualStyleBackColor = true;
            this.btnkartSil.Click += new System.EventHandler(this.btnkartSil_Click);
            // 
            // txtkartId
            // 
            this.txtkartId.Location = new System.Drawing.Point(204, 14);
            this.txtkartId.Name = "txtkartId";
            this.txtkartId.Size = new System.Drawing.Size(145, 20);
            this.txtkartId.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Maç : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Futbolcu : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hakem :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tür :";
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
            // cmbkartFutbolcuId
            // 
            this.cmbkartFutbolcuId.FormattingEnabled = true;
            this.cmbkartFutbolcuId.Location = new System.Drawing.Point(204, 86);
            this.cmbkartFutbolcuId.Name = "cmbkartFutbolcuId";
            this.cmbkartFutbolcuId.Size = new System.Drawing.Size(145, 21);
            this.cmbkartFutbolcuId.TabIndex = 36;
            // 
            // cmbkartTur
            // 
            this.cmbkartTur.FormattingEnabled = true;
            this.cmbkartTur.Location = new System.Drawing.Point(204, 38);
            this.cmbkartTur.Name = "cmbkartTur";
            this.cmbkartTur.Size = new System.Drawing.Size(145, 21);
            this.cmbkartTur.TabIndex = 36;
            // 
            // kart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 199);
            this.Controls.Add(this.dgwkartListe);
            this.Controls.Add(this.btnkartListele);
            this.Controls.Add(this.cmbkartMacId);
            this.Controls.Add(this.cmbkartFutbolcuId);
            this.Controls.Add(this.cmbkartTur);
            this.Controls.Add(this.cmbkartHakemId);
            this.Controls.Add(this.btnkartEkle);
            this.Controls.Add(this.btnkartSil);
            this.Controls.Add(this.txtkartId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kart";
            this.Load += new System.EventHandler(this.kart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwkartListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwkartListe;
        private System.Windows.Forms.Button btnkartListele;
        private System.Windows.Forms.ComboBox cmbkartMacId;
        private System.Windows.Forms.ComboBox cmbkartHakemId;
        private System.Windows.Forms.Button btnkartEkle;
        private System.Windows.Forms.Button btnkartSil;
        private System.Windows.Forms.TextBox txtkartId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbkartFutbolcuId;
        private System.Windows.Forms.ComboBox cmbkartTur;
    }
}