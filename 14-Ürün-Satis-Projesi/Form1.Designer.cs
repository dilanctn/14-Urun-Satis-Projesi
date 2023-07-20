
namespace Proje_EntıtyProje_Uygulama
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKategorııd = new System.Windows.Forms.TextBox();
            this.TxtKategorıAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSıl = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori ID :";
            // 
            // TxtKategorııd
            // 
            this.TxtKategorııd.Location = new System.Drawing.Point(138, 45);
            this.TxtKategorııd.Name = "TxtKategorııd";
            this.TxtKategorııd.Size = new System.Drawing.Size(151, 29);
            this.TxtKategorııd.TabIndex = 1;
            // 
            // TxtKategorıAd
            // 
            this.TxtKategorıAd.Location = new System.Drawing.Point(138, 80);
            this.TxtKategorıAd.Name = "TxtKategorıAd";
            this.TxtKategorıAd.Size = new System.Drawing.Size(151, 29);
            this.TxtKategorıAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori Ad :";
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(42, 146);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(107, 34);
            this.BtnListele.TabIndex = 4;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(42, 186);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(107, 34);
            this.BtnEkle.TabIndex = 5;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSıl
            // 
            this.BtnSıl.Location = new System.Drawing.Point(170, 146);
            this.BtnSıl.Name = "BtnSıl";
            this.BtnSıl.Size = new System.Drawing.Size(107, 34);
            this.BtnSıl.TabIndex = 6;
            this.BtnSıl.Text = "Sil";
            this.BtnSıl.UseVisualStyleBackColor = true;
            this.BtnSıl.Click += new System.EventHandler(this.BtnSıl_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(170, 186);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(107, 34);
            this.BtnGuncelle.TabIndex = 7;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 203);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(876, 303);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSıl);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtKategorıAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKategorııd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKategorııd;
        private System.Windows.Forms.TextBox TxtKategorıAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSıl;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

