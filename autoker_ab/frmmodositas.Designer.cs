namespace autoker_ab
{
    partial class frmmodositas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmodositas));
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.autoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tulajszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txkeres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btelvet = new System.Windows.Forms.Button();
            this.btmentes = new System.Windows.Forms.Button();
            this.txar = new System.Windows.Forms.TextBox();
            this.txtulajszam = new System.Windows.Forms.TextBox();
            this.txszin = new System.Windows.Forms.TextBox();
            this.txtipus = new System.Windows.Forms.TextBox();
            this.txrendszam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbautoid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.SuspendLayout();
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
            this.dgadatok.Location = new System.Drawing.Point(12, 38);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.Size = new System.Drawing.Size(675, 240);
            this.dgadatok.TabIndex = 10;
            this.dgadatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgadatok_CellClick);
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
            // txkeres
            // 
            this.txkeres.Location = new System.Drawing.Point(71, 6);
            this.txkeres.Name = "txkeres";
            this.txkeres.Size = new System.Drawing.Size(100, 20);
            this.txkeres.TabIndex = 9;
            this.txkeres.TextChanged += new System.EventHandler(this.txkeres_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Keresés:";
            // 
            // btelvet
            // 
            this.btelvet.Image = ((System.Drawing.Image)(resources.GetObject("btelvet.Image")));
            this.btelvet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btelvet.Location = new System.Drawing.Point(825, 216);
            this.btelvet.Name = "btelvet";
            this.btelvet.Size = new System.Drawing.Size(115, 76);
            this.btelvet.TabIndex = 24;
            this.btelvet.Text = "Elvet";
            this.btelvet.UseVisualStyleBackColor = true;
            this.btelvet.Click += new System.EventHandler(this.btelvet_Click);
            // 
            // btmentes
            // 
            this.btmentes.Image = ((System.Drawing.Image)(resources.GetObject("btmentes.Image")));
            this.btmentes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmentes.Location = new System.Drawing.Point(693, 216);
            this.btmentes.Name = "btmentes";
            this.btmentes.Size = new System.Drawing.Size(115, 76);
            this.btmentes.TabIndex = 23;
            this.btmentes.Text = "Mentés";
            this.btmentes.UseVisualStyleBackColor = true;
            this.btmentes.Click += new System.EventHandler(this.btmentes_Click);
            // 
            // txar
            // 
            this.txar.Location = new System.Drawing.Point(722, 183);
            this.txar.Name = "txar";
            this.txar.Size = new System.Drawing.Size(105, 20);
            this.txar.TabIndex = 22;
            this.txar.TextChanged += new System.EventHandler(this.txar_TextChanged);
            // 
            // txtulajszam
            // 
            this.txtulajszam.Location = new System.Drawing.Point(825, 142);
            this.txtulajszam.Name = "txtulajszam";
            this.txtulajszam.Size = new System.Drawing.Size(82, 20);
            this.txtulajszam.TabIndex = 21;
            this.txtulajszam.TextChanged += new System.EventHandler(this.txtulajszam_TextChanged_1);
            // 
            // txszin
            // 
            this.txszin.Location = new System.Drawing.Point(736, 107);
            this.txszin.MaxLength = 10;
            this.txszin.Name = "txszin";
            this.txszin.Size = new System.Drawing.Size(139, 20);
            this.txszin.TabIndex = 20;
            // 
            // txtipus
            // 
            this.txtipus.Location = new System.Drawing.Point(743, 71);
            this.txtipus.MaxLength = 50;
            this.txtipus.Name = "txtipus";
            this.txtipus.Size = new System.Drawing.Size(139, 20);
            this.txtipus.TabIndex = 19;
            // 
            // txrendszam
            // 
            this.txrendszam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txrendszam.Location = new System.Drawing.Point(768, 35);
            this.txrendszam.MaxLength = 6;
            this.txrendszam.Name = "txrendszam";
            this.txrendszam.Size = new System.Drawing.Size(107, 20);
            this.txrendszam.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ár:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tulajdonosok száma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Szín:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Típus:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rendszám:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Azonosító:";
            // 
            // lbautoid
            // 
            this.lbautoid.AutoSize = true;
            this.lbautoid.Location = new System.Drawing.Point(82, 281);
            this.lbautoid.Name = "lbautoid";
            this.lbautoid.Size = new System.Drawing.Size(0, 13);
            this.lbautoid.TabIndex = 26;
            // 
            // frmmodositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 326);
            this.Controls.Add(this.lbautoid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btelvet);
            this.Controls.Add(this.btmentes);
            this.Controls.Add(this.txar);
            this.Controls.Add(this.txtulajszam);
            this.Controls.Add(this.txszin);
            this.Controls.Add(this.txtipus);
            this.Controls.Add(this.txrendszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgadatok);
            this.Controls.Add(this.txkeres);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmmodositas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adat módosítás";
            this.Load += new System.EventHandler(this.frmmodositas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn szin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tulajszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ar;
        private System.Windows.Forms.TextBox txkeres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btelvet;
        private System.Windows.Forms.Button btmentes;
        private System.Windows.Forms.TextBox txar;
        private System.Windows.Forms.TextBox txtulajszam;
        private System.Windows.Forms.TextBox txszin;
        private System.Windows.Forms.TextBox txtipus;
        private System.Windows.Forms.TextBox txrendszam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbautoid;
    }
}