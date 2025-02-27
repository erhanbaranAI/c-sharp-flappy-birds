namespace Flappy_Birds
{
    partial class giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHighScoreValue = new System.Windows.Forms.Label();
            this.pbCikis = new System.Windows.Forms.PictureBox();
            this.pbBaslat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaslat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flappy Birds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "High Score:";
            // 
            // lblHighScoreValue
            // 
            this.lblHighScoreValue.AutoSize = true;
            this.lblHighScoreValue.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreValue.Location = new System.Drawing.Point(139, 424);
            this.lblHighScoreValue.Name = "lblHighScoreValue";
            this.lblHighScoreValue.Size = new System.Drawing.Size(23, 26);
            this.lblHighScoreValue.TabIndex = 4;
            this.lblHighScoreValue.Text = "0";
            // 
            // pbCikis
            // 
            this.pbCikis.Image = global::Flappy_Birds.Properties.Resources.exit;
            this.pbCikis.Location = new System.Drawing.Point(121, 236);
            this.pbCikis.Name = "pbCikis";
            this.pbCikis.Size = new System.Drawing.Size(143, 109);
            this.pbCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCikis.TabIndex = 5;
            this.pbCikis.TabStop = false;
            this.pbCikis.Click += new System.EventHandler(this.pbCikis_Click);
            // 
            // pbBaslat
            // 
            this.pbBaslat.Image = global::Flappy_Birds.Properties.Resources.start;
            this.pbBaslat.Location = new System.Drawing.Point(121, 121);
            this.pbBaslat.Name = "pbBaslat";
            this.pbBaslat.Size = new System.Drawing.Size(143, 109);
            this.pbBaslat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBaslat.TabIndex = 6;
            this.pbBaslat.TabStop = false;
            this.pbBaslat.Click += new System.EventHandler(this.pbBaslat_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.ControlBox = false;
            this.Controls.Add(this.pbBaslat);
            this.Controls.Add(this.pbCikis);
            this.Controls.Add(this.lblHighScoreValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "giris";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaslat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHighScoreValue;
        private System.Windows.Forms.PictureBox pbCikis;
        private System.Windows.Forms.PictureBox pbBaslat;
    }
}