namespace Juego_en_grupo
{
    partial class XO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XO));
            this.inicio = new System.Windows.Forms.Button();
            this.Dificultad = new System.Windows.Forms.Label();
            this.pPlayer1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.pPlayer2 = new System.Windows.Forms.ProgressBar();
            this.tablax_o = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // inicio
            // 
            this.inicio.BackColor = System.Drawing.Color.Blue;
            this.inicio.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inicio.Location = new System.Drawing.Point(46, 46);
            this.inicio.Margin = new System.Windows.Forms.Padding(4);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(189, 87);
            this.inicio.TabIndex = 12;
            this.inicio.Text = "Iniciar partida";
            this.inicio.UseVisualStyleBackColor = false;
            this.inicio.Click += new System.EventHandler(this.binicio_Click);
            // 
            // Dificultad
            // 
            this.Dificultad.AutoSize = true;
            this.Dificultad.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dificultad.Location = new System.Drawing.Point(64, 46);
            this.Dificultad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dificultad.Name = "Dificultad";
            this.Dificultad.Size = new System.Drawing.Size(0, 17);
            this.Dificultad.TabIndex = 9;
            // 
            // pPlayer1
            // 
            this.pPlayer1.Location = new System.Drawing.Point(67, 278);
            this.pPlayer1.Maximum = 10;
            this.pPlayer1.Name = "pPlayer1";
            this.pPlayer1.Size = new System.Drawing.Size(189, 39);
            this.pPlayer1.Step = 1;
            this.pPlayer1.TabIndex = 15;
            this.pPlayer1.Click += new System.EventHandler(this.pPlayer1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chartreuse;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(66, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 49);
            this.button2.TabIndex = 16;
            this.button2.Text = "Inicio";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pPlayer2
            // 
            this.pPlayer2.Location = new System.Drawing.Point(67, 363);
            this.pPlayer2.Maximum = 10;
            this.pPlayer2.Name = "pPlayer2";
            this.pPlayer2.Size = new System.Drawing.Size(189, 39);
            this.pPlayer2.Step = 1;
            this.pPlayer2.TabIndex = 17;
            this.pPlayer2.Click += new System.EventHandler(this.pPlayer2_Click);
            // 
            // tablax_o
            // 
            this.tablax_o.BackColor = System.Drawing.Color.White;
            this.tablax_o.ColumnCount = 3;
            this.tablax_o.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablax_o.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablax_o.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tablax_o.Location = new System.Drawing.Point(368, 23);
            this.tablax_o.Name = "tablax_o";
            this.tablax_o.RowCount = 3;
            this.tablax_o.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablax_o.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablax_o.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tablax_o.Size = new System.Drawing.Size(422, 364);
            this.tablax_o.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Juego_en_grupo.Properties.Resources.f_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Juego_en_grupo.Properties.Resources.f_2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 363);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox3.Image = global::Juego_en_grupo.Properties.Resources.f_0;
            this.pictureBox3.Location = new System.Drawing.Point(12, 278);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // XO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tablax_o);
            this.Controls.Add(this.pPlayer2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pPlayer1);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.Dificultad);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pal rato";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XO_FormClosing);
            this.Load += new System.EventHandler(this.XO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.Label Dificultad;
        private System.Windows.Forms.ProgressBar pPlayer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar pPlayer2;
        private System.Windows.Forms.TableLayoutPanel tablax_o;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}