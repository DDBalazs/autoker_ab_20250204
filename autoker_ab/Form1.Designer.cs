namespace autoker_ab
{
    partial class frmfo
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
            this.btload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txkeres = new System.Windows.Forms.TextBox();
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.autoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tulajszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btfelv = new System.Windows.Forms.Button();
            this.lberedmeny = new System.Windows.Forms.Label();
            this.btmodosit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.SuspendLayout();
            // 
            // btload
            // 
            this.btload.Location = new System.Drawing.Point(31, 12);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(420, 93);
            this.btload.TabIndex = 0;
            this.btload.Text = "Adatok betöltése";
            this.btload.UseVisualStyleBackColor = true;
            this.btload.Click += new System.EventHandler(this.btload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keresés:";
            // 
            // txkeres
            // 
            this.txkeres.Location = new System.Drawing.Point(130, 132);
            this.txkeres.Name = "txkeres";
            this.txkeres.Size = new System.Drawing.Size(100, 20);
            this.txkeres.TabIndex = 2;
            this.txkeres.TextChanged += new System.EventHandler(this.txkeres_TextChanged);
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoid,
            this.rendszam,
            this.tipus,
            this.szin,
            this.tulajszam,
            this.ar});
            this.dgadatok.Location = new System.Drawing.Point(12, 177);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.Size = new System.Drawing.Size(675, 240);
            this.dgadatok.TabIndex = 3;
            // 
            // autoid
            // 
            this.autoid.HeaderText = "Azonosító";
            this.autoid.Name = "autoid";
            this.autoid.ReadOnly = true;
            // 
            // rendszam
            // 
            this.rendszam.HeaderText = "Rendszám";
            this.rendszam.Name = "rendszam";
            this.rendszam.ReadOnly = true;
            // 
            // tipus
            // 
            this.tipus.HeaderText = "Típus";
            this.tipus.Name = "tipus";
            this.tipus.ReadOnly = true;
            // 
            // szin
            // 
            this.szin.HeaderText = "Szín";
            this.szin.Name = "szin";
            this.szin.ReadOnly = true;
            // 
            // tulajszam
            // 
            this.tulajszam.HeaderText = "Tulajdonosok száma";
            this.tulajszam.Name = "tulajszam";
            this.tulajszam.ReadOnly = true;
            // 
            // ar
            // 
            this.ar.HeaderText = "Ár";
            this.ar.Name = "ar";
            this.ar.ReadOnly = true;
            // 
            // btfelv
            // 
            this.btfelv.Location = new System.Drawing.Point(457, 12);
            this.btfelv.Name = "btfelv";
            this.btfelv.Size = new System.Drawing.Size(172, 159);
            this.btfelv.TabIndex = 4;
            this.btfelv.Text = "Új felvétele";
            this.btfelv.UseVisualStyleBackColor = true;
            this.btfelv.Click += new System.EventHandler(this.btfelv_Click);
            // 
            // lberedmeny
            // 
            this.lberedmeny.AutoSize = true;
            this.lberedmeny.Location = new System.Drawing.Point(12, 428);
            this.lberedmeny.Name = "lberedmeny";
            this.lberedmeny.Size = new System.Drawing.Size(27, 13);
            this.lberedmeny.TabIndex = 5;
            this.lberedmeny.Text = "asd";
            this.lberedmeny.Visible = false;
            // 
            // btmodosit
            // 
            this.btmodosit.Location = new System.Drawing.Point(635, 12);
            this.btmodosit.Name = "btmodosit";
            this.btmodosit.Size = new System.Drawing.Size(172, 159);
            this.btmodosit.TabIndex = 6;
            this.btmodosit.Text = "Módosítás";
            this.btmodosit.UseVisualStyleBackColor = true;
            this.btmodosit.Click += new System.EventHandler(this.btmodosit_Click);
            // 
            // frmfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btmodosit);
            this.Controls.Add(this.lberedmeny);
            this.Controls.Add(this.btfelv);
            this.Controls.Add(this.dgadatok);
            this.Controls.Add(this.txkeres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btload);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gépjármű nyílvántartása";
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txkeres;
        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn szin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tulajszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ar;
        private System.Windows.Forms.Button btfelv;
        private System.Windows.Forms.Label lberedmeny;
        private System.Windows.Forms.Button btmodosit;
    }
}

