namespace cesare
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.pct_1 = new System.Windows.Forms.PictureBox();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_6 = new System.Windows.Forms.Label();
            this.txt_4 = new System.Windows.Forms.TextBox();
            this.lbl_7 = new System.Windows.Forms.Label();
            this.txt_5 = new System.Windows.Forms.TextBox();
            this.btn_2 = new System.Windows.Forms.Button();
            this.lbl_8 = new System.Windows.Forms.Label();
            this.txt_6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(267, 20);
            this.lbl_1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(259, 39);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Cifrario di cesare";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(14, 113);
            this.lbl_2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(119, 17);
            this.lbl_2.TabIndex = 1;
            this.lbl_2.Text = "Testo da cifrare";
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(166, 113);
            this.txt_1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(164, 24);
            this.txt_1.TabIndex = 2;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.Location = new System.Drawing.Point(14, 169);
            this.lbl_3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(142, 17);
            this.lbl_3.TabIndex = 3;
            this.lbl_3.Text = "Chiave di cifratura";
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(166, 163);
            this.txt_2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(164, 24);
            this.txt_2.TabIndex = 4;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(14, 403);
            this.btn_1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(106, 48);
            this.btn_1.TabIndex = 5;
            this.btn_1.Text = "CRIPTA\r\nORA";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // pct_1
            // 
            this.pct_1.Image = ((System.Drawing.Image)(resources.GetObject("pct_1.Image")));
            this.pct_1.Location = new System.Drawing.Point(14, 263);
            this.pct_1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pct_1.Name = "pct_1";
            this.pct_1.Size = new System.Drawing.Size(319, 119);
            this.pct_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_1.TabIndex = 6;
            this.pct_1.TabStop = false;
            this.pct_1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4.Location = new System.Drawing.Point(14, 221);
            this.lbl_4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(134, 17);
            this.lbl_4.TabIndex = 7;
            this.lbl_4.Text = "Risultato cifrario";
            // 
            // txt_3
            // 
            this.txt_3.Location = new System.Drawing.Point(166, 221);
            this.txt_3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(164, 24);
            this.txt_3.TabIndex = 8;
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Location = new System.Drawing.Point(387, 116);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(14, 324);
            this.lbl_5.TabIndex = 9;
            this.lbl_5.Text = "|\r\n|\r\n|\r\n|\r\n\r\n|\r\n|\r\n|\r\n|\r\n\r\n|\r\n|\r\n|\r\n\r\n|\r\n|\r\n|\r\n|";
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_6.Location = new System.Drawing.Point(438, 116);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(141, 34);
            this.lbl_6.TabIndex = 10;
            this.lbl_6.Text = "Testo crittografato\r\n(inserisci qui)";
            // 
            // txt_4
            // 
            this.txt_4.Location = new System.Drawing.Point(622, 116);
            this.txt_4.Name = "txt_4";
            this.txt_4.Size = new System.Drawing.Size(133, 24);
            this.txt_4.TabIndex = 11;
            this.txt_4.TextChanged += new System.EventHandler(this.txt_4_TextChanged);
            // 
            // lbl_7
            // 
            this.lbl_7.AutoSize = true;
            this.lbl_7.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_7.Location = new System.Drawing.Point(437, 177);
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Size = new System.Drawing.Size(142, 17);
            this.lbl_7.TabIndex = 12;
            this.lbl_7.Text = "Chiave di cifratura";
            // 
            // txt_5
            // 
            this.txt_5.Location = new System.Drawing.Point(622, 169);
            this.txt_5.Name = "txt_5";
            this.txt_5.Size = new System.Drawing.Size(133, 24);
            this.txt_5.TabIndex = 13;
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(431, 384);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(127, 67);
            this.btn_2.TabIndex = 14;
            this.btn_2.Text = "DESCRIPTA \r\nORA";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // lbl_8
            // 
            this.lbl_8.AutoSize = true;
            this.lbl_8.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_8.Location = new System.Drawing.Point(428, 228);
            this.lbl_8.Name = "lbl_8";
            this.lbl_8.Size = new System.Drawing.Size(169, 17);
            this.lbl_8.TabIndex = 15;
            this.lbl_8.Text = "Risultato da descifrare";
            // 
            // txt_6
            // 
            this.txt_6.Location = new System.Drawing.Point(622, 221);
            this.txt_6.Name = "txt_6";
            this.txt_6.Size = new System.Drawing.Size(133, 24);
            this.txt_6.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 623);
            this.Controls.Add(this.txt_6);
            this.Controls.Add(this.lbl_8);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.txt_5);
            this.Controls.Add(this.lbl_7);
            this.Controls.Add(this.txt_4);
            this.Controls.Add(this.lbl_6);
            this.Controls.Add(this.lbl_5);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.pct_1);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.PictureBox pct_1;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.Label lbl_6;
        private System.Windows.Forms.TextBox txt_4;
        private System.Windows.Forms.Label lbl_7;
        private System.Windows.Forms.TextBox txt_5;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Label lbl_8;
        private System.Windows.Forms.TextBox txt_6;
    }
}

