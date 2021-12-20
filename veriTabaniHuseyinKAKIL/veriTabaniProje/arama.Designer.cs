
namespace veriTabaniProje
{
    partial class arama
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
            this.btnaramaListele = new System.Windows.Forms.Button();
            this.cmbaramaAranacakGrup = new System.Windows.Forms.ComboBox();
            this.dgwaramaListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaramaId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwaramaListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaramaListele
            // 
            this.btnaramaListele.Location = new System.Drawing.Point(15, 78);
            this.btnaramaListele.Name = "btnaramaListele";
            this.btnaramaListele.Size = new System.Drawing.Size(163, 22);
            this.btnaramaListele.TabIndex = 52;
            this.btnaramaListele.Text = "Listele";
            this.btnaramaListele.UseVisualStyleBackColor = true;
            this.btnaramaListele.Click += new System.EventHandler(this.btnaramaListele_Click);
            // 
            // cmbaramaAranacakGrup
            // 
            this.cmbaramaAranacakGrup.FormattingEnabled = true;
            this.cmbaramaAranacakGrup.Location = new System.Drawing.Point(203, 12);
            this.cmbaramaAranacakGrup.Name = "cmbaramaAranacakGrup";
            this.cmbaramaAranacakGrup.Size = new System.Drawing.Size(145, 21);
            this.cmbaramaAranacakGrup.TabIndex = 50;
            // 
            // dgwaramaListe
            // 
            this.dgwaramaListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwaramaListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwaramaListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwaramaListe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwaramaListe.Location = new System.Drawing.Point(352, 12);
            this.dgwaramaListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwaramaListe.Name = "dgwaramaListe";
            this.dgwaramaListe.ReadOnly = true;
            this.dgwaramaListe.Size = new System.Drawing.Size(391, 174);
            this.dgwaramaListe.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Aranacak Grup :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "ID :";
            // 
            // txtaramaId
            // 
            this.txtaramaId.Location = new System.Drawing.Point(203, 41);
            this.txtaramaId.Name = "txtaramaId";
            this.txtaramaId.Size = new System.Drawing.Size(145, 20);
            this.txtaramaId.TabIndex = 54;
            // 
            // arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 199);
            this.Controls.Add(this.txtaramaId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaramaListele);
            this.Controls.Add(this.cmbaramaAranacakGrup);
            this.Controls.Add(this.dgwaramaListe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "arama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "arama";
            this.Load += new System.EventHandler(this.arama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwaramaListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaramaListele;
        private System.Windows.Forms.ComboBox cmbaramaAranacakGrup;
        private System.Windows.Forms.DataGridView dgwaramaListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaramaId;
    }
}