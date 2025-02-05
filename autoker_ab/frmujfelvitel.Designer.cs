namespace autoker_ab
{
    partial class frmujfelvitel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmujfelvitel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txrendszam = new System.Windows.Forms.TextBox();
            this.txtipus = new System.Windows.Forms.TextBox();
            this.txszin = new System.Windows.Forms.TextBox();
            this.txtulajszam = new System.Windows.Forms.TextBox();
            this.txar = new System.Windows.Forms.TextBox();
            this.btmentes = new System.Windows.Forms.Button();
            this.btelvet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Típus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Szín:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tulajdonosok száma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ár:";
            // 
            // txrendszam
            // 
            this.txrendszam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txrendszam.Location = new System.Drawing.Point(87, 6);
            this.txrendszam.MaxLength = 6;
            this.txrendszam.Name = "txrendszam";
            this.txrendszam.Size = new System.Drawing.Size(107, 20);
            this.txrendszam.TabIndex = 5;
            this.txrendszam.TextChanged += new System.EventHandler(this.txrendszam_TextChanged);
            // 
            // txtipus
            // 
            this.txtipus.Location = new System.Drawing.Point(62, 42);
            this.txtipus.MaxLength = 50;
            this.txtipus.Name = "txtipus";
            this.txtipus.Size = new System.Drawing.Size(139, 20);
            this.txtipus.TabIndex = 6;
            // 
            // txszin
            // 
            this.txszin.Location = new System.Drawing.Point(55, 78);
            this.txszin.MaxLength = 10;
            this.txszin.Name = "txszin";
            this.txszin.Size = new System.Drawing.Size(139, 20);
            this.txszin.TabIndex = 7;
            // 
            // txtulajszam
            // 
            this.txtulajszam.Location = new System.Drawing.Point(144, 113);
            this.txtulajszam.Name = "txtulajszam";
            this.txtulajszam.Size = new System.Drawing.Size(82, 20);
            this.txtulajszam.TabIndex = 8;
            this.txtulajszam.TextChanged += new System.EventHandler(this.txtulajszam_TextChanged);
            // 
            // txar
            // 
            this.txar.Location = new System.Drawing.Point(41, 154);
            this.txar.Name = "txar";
            this.txar.Size = new System.Drawing.Size(105, 20);
            this.txar.TabIndex = 9;
            this.txar.TextChanged += new System.EventHandler(this.txar_TextChanged);
            // 
            // btmentes
            // 
            this.btmentes.Image = ((System.Drawing.Image)(resources.GetObject("btmentes.Image")));
            this.btmentes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmentes.Location = new System.Drawing.Point(12, 187);
            this.btmentes.Name = "btmentes";
            this.btmentes.Size = new System.Drawing.Size(115, 76);
            this.btmentes.TabIndex = 10;
            this.btmentes.Text = "Mentés";
            this.btmentes.UseVisualStyleBackColor = true;
            this.btmentes.Click += new System.EventHandler(this.btmentes_Click);
            // 
            // btelvet
            // 
            this.btelvet.Image = ((System.Drawing.Image)(resources.GetObject("btelvet.Image")));
            this.btelvet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btelvet.Location = new System.Drawing.Point(144, 187);
            this.btelvet.Name = "btelvet";
            this.btelvet.Size = new System.Drawing.Size(115, 76);
            this.btelvet.TabIndex = 12;
            this.btelvet.Text = "Elvet";
            this.btelvet.UseVisualStyleBackColor = true;
            this.btelvet.Click += new System.EventHandler(this.btelvet_Click);
            // 
            // frmujfelvitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 307);
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
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmujfelvitel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új gépjármű felvitele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txrendszam;
        private System.Windows.Forms.TextBox txtipus;
        private System.Windows.Forms.TextBox txszin;
        private System.Windows.Forms.TextBox txtulajszam;
        private System.Windows.Forms.TextBox txar;
        private System.Windows.Forms.Button btmentes;
        private System.Windows.Forms.Button btelvet;
    }
}