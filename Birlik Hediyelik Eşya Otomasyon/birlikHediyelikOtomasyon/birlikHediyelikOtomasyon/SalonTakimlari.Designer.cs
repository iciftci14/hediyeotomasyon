namespace birlikHediyelikOtomasyon
{
    partial class SalonTakimlari
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
            this.dgv_stListe = new System.Windows.Forms.DataGridView();
            this.tx_urunKodu = new System.Windows.Forms.TextBox();
            this.tx_urunAdi = new System.Windows.Forms.TextBox();
            this.tx_urunKategori = new System.Windows.Forms.TextBox();
            this.tx_urunFiyati = new System.Windows.Forms.TextBox();
            this.tx_urunIcerikler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_stok = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_stListe
            // 
            this.dgv_stListe.AllowUserToAddRows = false;
            this.dgv_stListe.AllowUserToDeleteRows = false;
            this.dgv_stListe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_stListe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_stListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stListe.Location = new System.Drawing.Point(2, 2);
            this.dgv_stListe.MultiSelect = false;
            this.dgv_stListe.Name = "dgv_stListe";
            this.dgv_stListe.ReadOnly = true;
            this.dgv_stListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stListe.Size = new System.Drawing.Size(899, 291);
            this.dgv_stListe.TabIndex = 0;
            this.dgv_stListe.SelectionChanged += new System.EventHandler(this.dgv_stListe_SelectionChanged);
            // 
            // tx_urunKodu
            // 
            this.tx_urunKodu.BackColor = System.Drawing.Color.DarkOrange;
            this.tx_urunKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_urunKodu.ForeColor = System.Drawing.Color.White;
            this.tx_urunKodu.Location = new System.Drawing.Point(178, 328);
            this.tx_urunKodu.Multiline = true;
            this.tx_urunKodu.Name = "tx_urunKodu";
            this.tx_urunKodu.Size = new System.Drawing.Size(161, 37);
            this.tx_urunKodu.TabIndex = 1;
            this.tx_urunKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_urunKodu_KeyPress);
            // 
            // tx_urunAdi
            // 
            this.tx_urunAdi.BackColor = System.Drawing.Color.DarkOrange;
            this.tx_urunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_urunAdi.ForeColor = System.Drawing.Color.White;
            this.tx_urunAdi.Location = new System.Drawing.Point(178, 373);
            this.tx_urunAdi.Multiline = true;
            this.tx_urunAdi.Name = "tx_urunAdi";
            this.tx_urunAdi.Size = new System.Drawing.Size(161, 39);
            this.tx_urunAdi.TabIndex = 1;
            this.tx_urunAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_urunAdi_KeyPress);
            // 
            // tx_urunKategori
            // 
            this.tx_urunKategori.BackColor = System.Drawing.Color.DarkOrange;
            this.tx_urunKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_urunKategori.ForeColor = System.Drawing.Color.White;
            this.tx_urunKategori.Location = new System.Drawing.Point(178, 419);
            this.tx_urunKategori.Multiline = true;
            this.tx_urunKategori.Name = "tx_urunKategori";
            this.tx_urunKategori.Size = new System.Drawing.Size(161, 40);
            this.tx_urunKategori.TabIndex = 1;
            this.tx_urunKategori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_urunKategori_KeyPress);
            // 
            // tx_urunFiyati
            // 
            this.tx_urunFiyati.BackColor = System.Drawing.Color.DarkOrange;
            this.tx_urunFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_urunFiyati.ForeColor = System.Drawing.Color.White;
            this.tx_urunFiyati.Location = new System.Drawing.Point(178, 466);
            this.tx_urunFiyati.Multiline = true;
            this.tx_urunFiyati.Name = "tx_urunFiyati";
            this.tx_urunFiyati.Size = new System.Drawing.Size(161, 29);
            this.tx_urunFiyati.TabIndex = 1;
            this.tx_urunFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_urunFiyati_KeyPress);
            // 
            // tx_urunIcerikler
            // 
            this.tx_urunIcerikler.Enabled = false;
            this.tx_urunIcerikler.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_urunIcerikler.Location = new System.Drawing.Point(516, 325);
            this.tx_urunIcerikler.Multiline = true;
            this.tx_urunIcerikler.Name = "tx_urunIcerikler";
            this.tx_urunIcerikler.Size = new System.Drawing.Size(336, 112);
            this.tx_urunIcerikler.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Kodu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(82, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Kategorisi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(58, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ürün Fiyatı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(364, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ürün İçerikleri :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(385, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Stok Sayısı :";
            // 
            // tx_stok
            // 
            this.tx_stok.BackColor = System.Drawing.Color.DarkOrange;
            this.tx_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_stok.ForeColor = System.Drawing.Color.White;
            this.tx_stok.Location = new System.Drawing.Point(516, 445);
            this.tx_stok.Multiline = true;
            this.tx_stok.Name = "tx_stok";
            this.tx_stok.Size = new System.Drawing.Size(114, 70);
            this.tx_stok.TabIndex = 3;
            this.tx_stok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tx_stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_stok_KeyPress);
            // 
            // SalonTakimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 577);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_stok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_urunIcerikler);
            this.Controls.Add(this.tx_urunFiyati);
            this.Controls.Add(this.tx_urunKategori);
            this.Controls.Add(this.tx_urunAdi);
            this.Controls.Add(this.tx_urunKodu);
            this.Controls.Add(this.dgv_stListe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SalonTakimlari";
            this.Text = "SalonTakimlari";
            this.Load += new System.EventHandler(this.SalonTakimlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_stListe;
        private System.Windows.Forms.TextBox tx_urunKodu;
        private System.Windows.Forms.TextBox tx_urunAdi;
        private System.Windows.Forms.TextBox tx_urunKategori;
        private System.Windows.Forms.TextBox tx_urunFiyati;
        private System.Windows.Forms.TextBox tx_urunIcerikler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_stok;
    }
}