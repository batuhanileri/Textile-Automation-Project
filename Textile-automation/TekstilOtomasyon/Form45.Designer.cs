namespace TekstilOtomasyon
{
    partial class Form45
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kumasBilgisiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tEKSTİL_OTOMASYONUDataSet = new TekstilOtomasyon.TEKSTİL_OTOMASYONUDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.kumasMuhasebeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kumasBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kumas_MuhasebeTableAdapter = new TekstilOtomasyon.TEKSTİL_OTOMASYONUDataSetTableAdapters.Kumas_MuhasebeTableAdapter();
            this.kumas_BilgisiTableAdapter = new TekstilOtomasyon.TEKSTİL_OTOMASYONUDataSetTableAdapters.Kumas_BilgisiTableAdapter();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.fKKumasBilgisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kumasBilgisiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEKSTİL_OTOMASYONUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kumasMuhasebeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kumasBilgisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKumasBilgisiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 175);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kumasBilgisiBindingSource1
            // 
            this.kumasBilgisiBindingSource1.DataMember = "Kumas_Bilgisi";
            this.kumasBilgisiBindingSource1.DataSource = this.tEKSTİL_OTOMASYONUDataSet;
            this.kumasBilgisiBindingSource1.CurrentChanged += new System.EventHandler(this.kumasBilgisiBindingSource1_CurrentChanged);
            // 
            // tEKSTİL_OTOMASYONUDataSet
            // 
            this.tEKSTİL_OTOMASYONUDataSet.DataSetName = "TEKSTİL_OTOMASYONUDataSet";
            this.tEKSTİL_OTOMASYONUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "KUMAŞ EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 80);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "KUMAŞ SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "PASTAL EKLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 128);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "KUMAS BİLGİLERİ GÖR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(200, 23);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 26);
            this.button5.TabIndex = 5;
            this.button5.Text = "SİPARİŞ EKLE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(200, 80);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 27);
            this.button6.TabIndex = 6;
            this.button6.Text = "SİPARİŞ SİL";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(200, 128);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 27);
            this.button7.TabIndex = 7;
            this.button7.Text = "SİPARİŞ GÖR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(547, 128);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(163, 27);
            this.button8.TabIndex = 8;
            this.button8.Text = "PASTAL BİLGİLERİ GÖR";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // kumasMuhasebeBindingSource
            // 
            this.kumasMuhasebeBindingSource.DataMember = "Kumas_Muhasebe";
            this.kumasMuhasebeBindingSource.DataSource = this.tEKSTİL_OTOMASYONUDataSet;
            // 
            // kumasBilgisiBindingSource
            // 
            this.kumasBilgisiBindingSource.DataMember = "Kumas_Bilgisi";
            this.kumasBilgisiBindingSource.DataSource = this.tEKSTİL_OTOMASYONUDataSet;
            // 
            // kumas_MuhasebeTableAdapter
            // 
            this.kumas_MuhasebeTableAdapter.ClearBeforeFill = true;
            // 
            // kumas_BilgisiTableAdapter
            // 
            this.kumas_BilgisiTableAdapter.ClearBeforeFill = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(360, 23);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(153, 26);
            this.button9.TabIndex = 9;
            this.button9.Text = "MUHASEBE EKLE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(360, 128);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(153, 26);
            this.button10.TabIndex = 10;
            this.button10.Text = "MUHASEBE GÖR";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(360, 80);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(153, 25);
            this.button11.TabIndex = 11;
            this.button11.Text = "MUHASEBE SİL";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(547, 80);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(163, 27);
            this.button12.TabIndex = 12;
            this.button12.Text = "PASTAL SİL";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // fKKumasBilgisiBindingSource
            // 
            this.fKKumasBilgisiBindingSource.DataMember = "FK_Kumas_Bilgisi";
            this.fKKumasBilgisiBindingSource.DataSource = this.kumasMuhasebeBindingSource;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(241, 464);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(210, 47);
            this.button13.TabIndex = 13;
            this.button13.Text = "GÜNCELLE";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // Form45
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 536);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form45";
            this.Text = "KUMAŞ";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kumasBilgisiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEKSTİL_OTOMASYONUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kumasMuhasebeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kumasBilgisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKumasBilgisiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.BindingSource kumasBilgisiBindingSource;
        private TEKSTİL_OTOMASYONUDataSet tEKSTİL_OTOMASYONUDataSet;
        private System.Windows.Forms.BindingSource kumasMuhasebeBindingSource;
        private TEKSTİL_OTOMASYONUDataSetTableAdapters.Kumas_MuhasebeTableAdapter kumas_MuhasebeTableAdapter;
        private System.Windows.Forms.BindingSource fKKumasBilgisiBindingSource;
        private TEKSTİL_OTOMASYONUDataSetTableAdapters.Kumas_BilgisiTableAdapter kumas_BilgisiTableAdapter;
        private System.Windows.Forms.BindingSource kumasBilgisiBindingSource1;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}