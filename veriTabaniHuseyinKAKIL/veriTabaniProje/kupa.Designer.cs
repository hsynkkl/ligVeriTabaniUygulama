
namespace veriTabaniProje
{
    partial class kupa
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
            this.dgwkupaListe = new System.Windows.Forms.DataGridView();
            this.btnkupaListele = new System.Windows.Forms.Button();
            this.btnkupaEkle = new System.Windows.Forms.Button();
            this.btnkupaSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbkupaTur = new System.Windows.Forms.ComboBox();
            this.dtpkupaTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbkupaKazananTakimId = new System.Windows.Forms.ComboBox();
            this.txtkupaId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwkupaListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwkupaListe
            // 
            this.dgwkupaListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwkupaListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwkupaListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwkupaListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwkupaListe.Location = new System.Drawing.Point(353, 14);
            this.dgwkupaListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwkupaListe.Name = "dgwkupaListe";
            this.dgwkupaListe.ReadOnly = true;
            this.dgwkupaListe.Size = new System.Drawing.Size(391, 174);
            this.dgwkupaListe.TabIndex = 39;
            // 
            // btnkupaListele
            // 
            this.btnkupaListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkupaListele.Location = new System.Drawing.Point(186, 141);
            this.btnkupaListele.Name = "btnkupaListele";
            this.btnkupaListele.Size = new System.Drawing.Size(163, 22);
            this.btnkupaListele.TabIndex = 38;
            this.btnkupaListele.Text = "Listele";
            this.btnkupaListele.UseVisualStyleBackColor = true;
            this.btnkupaListele.Click += new System.EventHandler(this.btnkupaListele_Click);
            // 
            // btnkupaEkle
            // 
            this.btnkupaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkupaEkle.Location = new System.Drawing.Point(16, 141);
            this.btnkupaEkle.Name = "btnkupaEkle";
            this.btnkupaEkle.Size = new System.Drawing.Size(163, 22);
            this.btnkupaEkle.TabIndex = 33;
            this.btnkupaEkle.Text = "Ekle";
            this.btnkupaEkle.UseVisualStyleBackColor = true;
            this.btnkupaEkle.Click += new System.EventHandler(this.btnkupaEkle_Click);
            // 
            // btnkupaSil
            // 
            this.btnkupaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkupaSil.Location = new System.Drawing.Point(16, 166);
            this.btnkupaSil.Name = "btnkupaSil";
            this.btnkupaSil.Size = new System.Drawing.Size(163, 22);
            this.btnkupaSil.TabIndex = 34;
            this.btnkupaSil.Text = "Sil";
            this.btnkupaSil.UseVisualStyleBackColor = true;
            this.btnkupaSil.Click += new System.EventHandler(this.btnkupaSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kupa Türü :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Kupa ID :";
            // 
            // cmbkupaTur
            // 
            this.cmbkupaTur.FormattingEnabled = true;
            this.cmbkupaTur.Location = new System.Drawing.Point(204, 38);
            this.cmbkupaTur.Name = "cmbkupaTur";
            this.cmbkupaTur.Size = new System.Drawing.Size(145, 21);
            this.cmbkupaTur.TabIndex = 36;
            // 
            // dtpkupaTarih
            // 
            this.dtpkupaTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpkupaTarih.Location = new System.Drawing.Point(204, 88);
            this.dtpkupaTarih.Name = "dtpkupaTarih";
            this.dtpkupaTarih.Size = new System.Drawing.Size(145, 20);
            this.dtpkupaTarih.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Takım : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tarih : ";
            // 
            // cmbkupaKazananTakimId
            // 
            this.cmbkupaKazananTakimId.FormattingEnabled = true;
            this.cmbkupaKazananTakimId.Location = new System.Drawing.Point(204, 63);
            this.cmbkupaKazananTakimId.Name = "cmbkupaKazananTakimId";
            this.cmbkupaKazananTakimId.Size = new System.Drawing.Size(145, 21);
            this.cmbkupaKazananTakimId.TabIndex = 36;
            // 
            // txtkupaId
            // 
            this.txtkupaId.Location = new System.Drawing.Point(204, 14);
            this.txtkupaId.Name = "txtkupaId";
            this.txtkupaId.Size = new System.Drawing.Size(145, 20);
            this.txtkupaId.TabIndex = 41;
            // 
            // kupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 199);
            this.Controls.Add(this.txtkupaId);
            this.Controls.Add(this.dtpkupaTarih);
            this.Controls.Add(this.dgwkupaListe);
            this.Controls.Add(this.btnkupaListele);
            this.Controls.Add(this.cmbkupaKazananTakimId);
            this.Controls.Add(this.cmbkupaTur);
            this.Controls.Add(this.btnkupaEkle);
            this.Controls.Add(this.btnkupaSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kupa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kupa";
            this.Load += new System.EventHandler(this.kupa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwkupaListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwkupaListe;
        private System.Windows.Forms.Button btnkupaListele;
        private System.Windows.Forms.Button btnkupaEkle;
        private System.Windows.Forms.Button btnkupaSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbkupaTur;
        private System.Windows.Forms.DateTimePicker dtpkupaTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbkupaKazananTakimId;
        private System.Windows.Forms.TextBox txtkupaId;
    }
}