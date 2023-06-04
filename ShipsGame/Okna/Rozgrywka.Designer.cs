
namespace ShipsGame.Okna
{
    partial class Rozgrywka
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
            this.planszaKomputera = new System.Windows.Forms.PictureBox();
            this.planszaGracza = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerRuchKomputera = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.planszaKomputera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).BeginInit();
            this.SuspendLayout();
            // 
            // planszaKomputera
            // 
            this.planszaKomputera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planszaKomputera.Image = global::ShipsGame.Properties.Resources.board;
            this.planszaKomputera.Location = new System.Drawing.Point(35, 65);
            this.planszaKomputera.Name = "planszaKomputera";
            this.planszaKomputera.Size = new System.Drawing.Size(400, 400);
            this.planszaKomputera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planszaKomputera.TabIndex = 0;
            this.planszaKomputera.TabStop = false;
            this.planszaKomputera.Click += new System.EventHandler(this.planszaKomputera_Click);
            this.planszaKomputera.Paint += new System.Windows.Forms.PaintEventHandler(this.planszaKomputera_Paint);
            this.planszaKomputera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.planszaKomputera_MouseMove);
            // 
            // planszaGracza
            // 
            this.planszaGracza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planszaGracza.Image = global::ShipsGame.Properties.Resources.board;
            this.planszaGracza.Location = new System.Drawing.Point(536, 65);
            this.planszaGracza.Name = "planszaGracza";
            this.planszaGracza.Size = new System.Drawing.Size(400, 400);
            this.planszaGracza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planszaGracza.TabIndex = 1;
            this.planszaGracza.TabStop = false;
            this.planszaGracza.Paint += new System.Windows.Forms.PaintEventHandler(this.planszaGracza_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(134, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plansza Komputera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(653, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plansza Gracza";
            // 
            // timerRuchKomputera
            // 
            this.timerRuchKomputera.Interval = 1000;
            this.timerRuchKomputera.Tick += new System.EventHandler(this.timerRuchKomputera_Tick);
            // 
            // Rozgrywka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planszaGracza);
            this.Controls.Add(this.planszaKomputera);
            this.Name = "Rozgrywka";
            this.Text = "Rozgrywka";
            ((System.ComponentModel.ISupportInitialize)(this.planszaKomputera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox planszaKomputera;
        private System.Windows.Forms.PictureBox planszaGracza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerRuchKomputera;
    }
}