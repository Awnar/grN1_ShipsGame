
namespace ShipsGame.Okna
{
    partial class UstawienieStatkow
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
            this.btnObrot = new System.Windows.Forms.Button();
            this.btnDalej = new System.Windows.Forms.Button();
            this.txtNazwaGracza = new System.Windows.Forms.TextBox();
            this.planszaGracza = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNazwaGracza = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrot
            // 
            this.btnObrot.Location = new System.Drawing.Point(517, 222);
            this.btnObrot.Name = "btnObrot";
            this.btnObrot.Size = new System.Drawing.Size(75, 20);
            this.btnObrot.TabIndex = 0;
            this.btnObrot.Text = "Obróć";
            this.btnObrot.UseVisualStyleBackColor = true;
            // 
            // btnDalej
            // 
            this.btnDalej.Location = new System.Drawing.Point(517, 262);
            this.btnDalej.Name = "btnDalej";
            this.btnDalej.Size = new System.Drawing.Size(75, 20);
            this.btnDalej.TabIndex = 1;
            this.btnDalej.Text = "Dalej";
            this.btnDalej.UseVisualStyleBackColor = true;
            // 
            // txtNazwaGracza
            // 
            this.txtNazwaGracza.Location = new System.Drawing.Point(498, 132);
            this.txtNazwaGracza.Name = "txtNazwaGracza";
            this.txtNazwaGracza.Size = new System.Drawing.Size(112, 20);
            this.txtNazwaGracza.TabIndex = 2;
            // 
            // planszaGracza
            // 
            this.planszaGracza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planszaGracza.Image = global::ShipsGame.Properties.Resources.board;
            this.planszaGracza.Location = new System.Drawing.Point(40, 27);
            this.planszaGracza.Name = "planszaGracza";
            this.planszaGracza.Size = new System.Drawing.Size(400, 400);
            this.planszaGracza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planszaGracza.TabIndex = 3;
            this.planszaGracza.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(523, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gracz:";
            // 
            // lblNazwaGracza
            // 
            this.lblNazwaGracza.AutoSize = true;
            this.lblNazwaGracza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaGracza.ForeColor = System.Drawing.Color.Red;
            this.lblNazwaGracza.Location = new System.Drawing.Point(496, 167);
            this.lblNazwaGracza.Name = "lblNazwaGracza";
            this.lblNazwaGracza.Size = new System.Drawing.Size(116, 20);
            this.lblNazwaGracza.TabIndex = 5;
            this.lblNazwaGracza.Text = "Podaj swoj nick";
            // 
            // UstawienieStatkow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.lblNazwaGracza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planszaGracza);
            this.Controls.Add(this.txtNazwaGracza);
            this.Controls.Add(this.btnDalej);
            this.Controls.Add(this.btnObrot);
            this.Name = "UstawienieStatkow";
            this.Text = "UstawienieStatkow";
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrot;
        private System.Windows.Forms.Button btnDalej;
        private System.Windows.Forms.TextBox txtNazwaGracza;
        private System.Windows.Forms.PictureBox planszaGracza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNazwaGracza;
    }
}