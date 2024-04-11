namespace ShapeCalculatorr
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
            this.pnlRec = new System.Windows.Forms.Panel();
            this.pnlRecLbl = new System.Windows.Forms.Panel();
            this.lblperi = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.nmrRec = new System.Windows.Forms.NumericUpDown();
            this.btnAreaPeri = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNotes = new System.Windows.Forms.Button();
            this.pnlCyl = new System.Windows.Forms.Panel();
            this.pnlCylLbl = new System.Windows.Forms.Panel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.nmrCyl = new System.Windows.Forms.NumericUpDown();
            this.btn_CylVol = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlPar = new System.Windows.Forms.Panel();
            this.pnlParLbl = new System.Windows.Forms.Panel();
            this.lblPar_peri = new System.Windows.Forms.Label();
            this.lblPar_area = new System.Windows.Forms.Label();
            this.nmrPar = new System.Windows.Forms.NumericUpDown();
            this.btnPar_AreaPeri = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtParHeight = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlRec.SuspendLayout();
            this.pnlRecLbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCyl.SuspendLayout();
            this.pnlCylLbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCyl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlPar.SuspendLayout();
            this.pnlParLbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRec
            // 
            this.pnlRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.pnlRec.Controls.Add(this.pnlRecLbl);
            this.pnlRec.Controls.Add(this.nmrRec);
            this.pnlRec.Controls.Add(this.btnAreaPeri);
            this.pnlRec.Controls.Add(this.txtWidth);
            this.pnlRec.Controls.Add(this.txtLength);
            this.pnlRec.Controls.Add(this.pictureBox1);
            this.pnlRec.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRec.Location = new System.Drawing.Point(12, 72);
            this.pnlRec.Name = "pnlRec";
            this.pnlRec.Size = new System.Drawing.Size(668, 366);
            this.pnlRec.TabIndex = 0;
            // 
            // pnlRecLbl
            // 
            this.pnlRecLbl.Controls.Add(this.lblperi);
            this.pnlRecLbl.Controls.Add(this.lblArea);
            this.pnlRecLbl.Location = new System.Drawing.Point(432, 199);
            this.pnlRecLbl.Name = "pnlRecLbl";
            this.pnlRecLbl.Size = new System.Drawing.Size(200, 100);
            this.pnlRecLbl.TabIndex = 6;
            this.pnlRecLbl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlRecLbl_MouseDoubleClick);
            this.pnlRecLbl.MouseHover += new System.EventHandler(this.pnlRecLbl_MouseHover);
            // 
            // lblperi
            // 
            this.lblperi.AutoSize = true;
            this.lblperi.ForeColor = System.Drawing.Color.White;
            this.lblperi.Location = new System.Drawing.Point(28, 60);
            this.lblperi.Name = "lblperi";
            this.lblperi.Size = new System.Drawing.Size(0, 18);
            this.lblperi.TabIndex = 1;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(28, 27);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 18);
            this.lblArea.TabIndex = 0;
            // 
            // nmrRec
            // 
            this.nmrRec.Location = new System.Drawing.Point(463, 150);
            this.nmrRec.Name = "nmrRec";
            this.nmrRec.Size = new System.Drawing.Size(153, 26);
            this.nmrRec.TabIndex = 5;
            this.nmrRec.ValueChanged += new System.EventHandler(this.btnAreaPeri_Click);
            // 
            // btnAreaPeri
            // 
            this.btnAreaPeri.BackColor = System.Drawing.Color.White;
            this.btnAreaPeri.Location = new System.Drawing.Point(463, 88);
            this.btnAreaPeri.Name = "btnAreaPeri";
            this.btnAreaPeri.Size = new System.Drawing.Size(153, 39);
            this.btnAreaPeri.TabIndex = 4;
            this.btnAreaPeri.Text = "Area/Perimeter";
            this.btnAreaPeri.UseVisualStyleBackColor = false;
            this.btnAreaPeri.Click += new System.EventHandler(this.btnAreaPeri_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(137, 256);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 26);
            this.txtWidth.TabIndex = 3;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(279, 150);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 26);
            this.txtLength.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShapeCalculatorr.Properties.Resources.rectangle_with_braces;
            this.pictureBox1.Location = new System.Drawing.Point(48, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 171);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnNotes
            // 
            this.btnNotes.BackColor = System.Drawing.Color.Honeydew;
            this.btnNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotes.Location = new System.Drawing.Point(12, 26);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(131, 37);
            this.btnNotes.TabIndex = 7;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = false;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // pnlCyl
            // 
            this.pnlCyl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(133)))), ((int)(((byte)(112)))));
            this.pnlCyl.Controls.Add(this.pnlCylLbl);
            this.pnlCyl.Controls.Add(this.nmrCyl);
            this.pnlCyl.Controls.Add(this.btn_CylVol);
            this.pnlCyl.Controls.Add(this.txtRadius);
            this.pnlCyl.Controls.Add(this.txtHeight);
            this.pnlCyl.Controls.Add(this.pictureBox2);
            this.pnlCyl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCyl.Location = new System.Drawing.Point(12, 69);
            this.pnlCyl.Name = "pnlCyl";
            this.pnlCyl.Size = new System.Drawing.Size(668, 366);
            this.pnlCyl.TabIndex = 8;
            // 
            // pnlCylLbl
            // 
            this.pnlCylLbl.Controls.Add(this.lblVolume);
            this.pnlCylLbl.Location = new System.Drawing.Point(432, 199);
            this.pnlCylLbl.Name = "pnlCylLbl";
            this.pnlCylLbl.Size = new System.Drawing.Size(200, 100);
            this.pnlCylLbl.TabIndex = 6;
            this.pnlCylLbl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlCylLbl_MouseDoubleClick);
            this.pnlCylLbl.MouseHover += new System.EventHandler(this.pnlCylLbl_MouseHover);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(28, 60);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(0, 18);
            this.lblVolume.TabIndex = 1;
            // 
            // nmrCyl
            // 
            this.nmrCyl.Location = new System.Drawing.Point(463, 150);
            this.nmrCyl.Name = "nmrCyl";
            this.nmrCyl.Size = new System.Drawing.Size(153, 26);
            this.nmrCyl.TabIndex = 5;
            this.nmrCyl.ValueChanged += new System.EventHandler(this.btn_CylVol_Click_1);
            // 
            // btn_CylVol
            // 
            this.btn_CylVol.BackColor = System.Drawing.Color.White;
            this.btn_CylVol.Location = new System.Drawing.Point(463, 88);
            this.btn_CylVol.Name = "btn_CylVol";
            this.btn_CylVol.Size = new System.Drawing.Size(153, 39);
            this.btn_CylVol.TabIndex = 4;
            this.btn_CylVol.Text = "Volume";
            this.btn_CylVol.UseVisualStyleBackColor = false;
            this.btn_CylVol.Click += new System.EventHandler(this.btn_CylVol_Click_1);
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(262, 56);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 26);
            this.txtRadius.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(262, 199);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 26);
            this.txtHeight.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShapeCalculatorr.Properties.Resources.cylinder;
            this.pictureBox2.Location = new System.Drawing.Point(48, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pnlPar
            // 
            this.pnlPar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pnlPar.Controls.Add(this.pnlParLbl);
            this.pnlPar.Controls.Add(this.nmrPar);
            this.pnlPar.Controls.Add(this.btnPar_AreaPeri);
            this.pnlPar.Controls.Add(this.txtBase);
            this.pnlPar.Controls.Add(this.txtParHeight);
            this.pnlPar.Controls.Add(this.pictureBox3);
            this.pnlPar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPar.Location = new System.Drawing.Point(9, 72);
            this.pnlPar.Name = "pnlPar";
            this.pnlPar.Size = new System.Drawing.Size(668, 366);
            this.pnlPar.TabIndex = 9;
            // 
            // pnlParLbl
            // 
            this.pnlParLbl.Controls.Add(this.lblPar_peri);
            this.pnlParLbl.Controls.Add(this.lblPar_area);
            this.pnlParLbl.Location = new System.Drawing.Point(432, 199);
            this.pnlParLbl.Name = "pnlParLbl";
            this.pnlParLbl.Size = new System.Drawing.Size(200, 100);
            this.pnlParLbl.TabIndex = 6;
            this.pnlParLbl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlParLbl_MouseDoubleClick);
            this.pnlParLbl.MouseHover += new System.EventHandler(this.pnlParLbl_MouseHover);
            // 
            // lblPar_peri
            // 
            this.lblPar_peri.AutoSize = true;
            this.lblPar_peri.Location = new System.Drawing.Point(28, 60);
            this.lblPar_peri.Name = "lblPar_peri";
            this.lblPar_peri.Size = new System.Drawing.Size(0, 18);
            this.lblPar_peri.TabIndex = 1;
            // 
            // lblPar_area
            // 
            this.lblPar_area.AutoSize = true;
            this.lblPar_area.Location = new System.Drawing.Point(28, 27);
            this.lblPar_area.Name = "lblPar_area";
            this.lblPar_area.Size = new System.Drawing.Size(0, 18);
            this.lblPar_area.TabIndex = 0;
            // 
            // nmrPar
            // 
            this.nmrPar.Location = new System.Drawing.Point(463, 150);
            this.nmrPar.Name = "nmrPar";
            this.nmrPar.Size = new System.Drawing.Size(153, 26);
            this.nmrPar.TabIndex = 5;
            this.nmrPar.ValueChanged += new System.EventHandler(this.btnPar_AreaPeri_Click);
            // 
            // btnPar_AreaPeri
            // 
            this.btnPar_AreaPeri.BackColor = System.Drawing.Color.White;
            this.btnPar_AreaPeri.Location = new System.Drawing.Point(463, 88);
            this.btnPar_AreaPeri.Name = "btnPar_AreaPeri";
            this.btnPar_AreaPeri.Size = new System.Drawing.Size(153, 39);
            this.btnPar_AreaPeri.TabIndex = 4;
            this.btnPar_AreaPeri.Text = "Area/Perimeter";
            this.btnPar_AreaPeri.UseVisualStyleBackColor = false;
            this.btnPar_AreaPeri.Click += new System.EventHandler(this.btnPar_AreaPeri_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(124, 262);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 26);
            this.txtBase.TabIndex = 3;
            // 
            // txtParHeight
            // 
            this.txtParHeight.Location = new System.Drawing.Point(299, 134);
            this.txtParHeight.Name = "txtParHeight";
            this.txtParHeight.Size = new System.Drawing.Size(100, 26);
            this.txtParHeight.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ShapeCalculatorr.Properties.Resources.Screenshot__105__removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(18, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(347, 254);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.comboBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rectangle",
            "Cylinder",
            "Parallelogram"});
            this.comboBox1.Location = new System.Drawing.Point(491, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 32);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(85)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(690, 447);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnlPar);
            this.Controls.Add(this.pnlCyl);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.pnlRec);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlRec.ResumeLayout(false);
            this.pnlRec.PerformLayout();
            this.pnlRecLbl.ResumeLayout(false);
            this.pnlRecLbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCyl.ResumeLayout(false);
            this.pnlCyl.PerformLayout();
            this.pnlCylLbl.ResumeLayout(false);
            this.pnlCylLbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCyl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlPar.ResumeLayout(false);
            this.pnlPar.PerformLayout();
            this.pnlParLbl.ResumeLayout(false);
            this.pnlParLbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAreaPeri;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Panel pnlRecLbl;
        private System.Windows.Forms.Label lblperi;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.NumericUpDown nmrRec;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Panel pnlCyl;
        private System.Windows.Forms.Panel pnlCylLbl;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.NumericUpDown nmrCyl;
        private System.Windows.Forms.Button btn_CylVol;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlPar;
        private System.Windows.Forms.Panel pnlParLbl;
        private System.Windows.Forms.Label lblPar_peri;
        private System.Windows.Forms.Label lblPar_area;
        private System.Windows.Forms.NumericUpDown nmrPar;
        private System.Windows.Forms.Button btnPar_AreaPeri;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtParHeight;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

