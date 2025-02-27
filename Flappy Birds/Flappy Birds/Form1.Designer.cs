namespace Flappy_Birds
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbBulut = new System.Windows.Forms.PictureBox();
            this.pbKus = new System.Windows.Forms.PictureBox();
            this.pbUstBoru = new System.Windows.Forms.PictureBox();
            this.pbAltBoru = new System.Windows.Forms.PictureBox();
            this.pbZemin = new System.Windows.Forms.PictureBox();
            this.lblSkor = new System.Windows.Forms.Label();
            this.tmrOyun = new System.Windows.Forms.Timer(this.components);
            this.tmrBaslat = new System.Windows.Forms.Timer(this.components);
            this.pbSayac = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBulut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUstBoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAltBoru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSayac)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBulut
            // 
            this.pbBulut.BackColor = System.Drawing.Color.Lavender;
            this.pbBulut.Location = new System.Drawing.Point(-12, -8);
            this.pbBulut.Name = "pbBulut";
            this.pbBulut.Size = new System.Drawing.Size(736, 37);
            this.pbBulut.TabIndex = 0;
            this.pbBulut.TabStop = false;
            // 
            // pbKus
            // 
            this.pbKus.Image = global::Flappy_Birds.Properties.Resources.bird;
            this.pbKus.Location = new System.Drawing.Point(39, 272);
            this.pbKus.Name = "pbKus";
            this.pbKus.Size = new System.Drawing.Size(54, 54);
            this.pbKus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKus.TabIndex = 1;
            this.pbKus.TabStop = false;
            // 
            // pbUstBoru
            // 
            this.pbUstBoru.BackColor = System.Drawing.Color.Transparent;
            this.pbUstBoru.Image = global::Flappy_Birds.Properties.Resources.pipedown;
            this.pbUstBoru.Location = new System.Drawing.Point(524, 0);
            this.pbUstBoru.Name = "pbUstBoru";
            this.pbUstBoru.Size = new System.Drawing.Size(100, 187);
            this.pbUstBoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUstBoru.TabIndex = 2;
            this.pbUstBoru.TabStop = false;
            // 
            // pbAltBoru
            // 
            this.pbAltBoru.Image = global::Flappy_Birds.Properties.Resources.pipe;
            this.pbAltBoru.Location = new System.Drawing.Point(405, 463);
            this.pbAltBoru.Name = "pbAltBoru";
            this.pbAltBoru.Size = new System.Drawing.Size(100, 465);
            this.pbAltBoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAltBoru.TabIndex = 3;
            this.pbAltBoru.TabStop = false;
            // 
            // pbZemin
            // 
            this.pbZemin.Image = global::Flappy_Birds.Properties.Resources.ground;
            this.pbZemin.Location = new System.Drawing.Point(-12, 666);
            this.pbZemin.Name = "pbZemin";
            this.pbZemin.Size = new System.Drawing.Size(704, 63);
            this.pbZemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZemin.TabIndex = 4;
            this.pbZemin.TabStop = false;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSkor.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkor.Location = new System.Drawing.Point(-4, 687);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(89, 22);
            this.lblSkor.TabIndex = 5;
            this.lblSkor.Text = "Skor: 0";
            // 
            // tmrOyun
            // 
            this.tmrOyun.Tick += new System.EventHandler(this.tmrOyun_Tick);
            // 
            // tmrBaslat
            // 
            this.tmrBaslat.Enabled = true;
            this.tmrBaslat.Interval = 1000;
            this.tmrBaslat.Tick += new System.EventHandler(this.tmrBaslat_Tick);
            // 
            // pbSayac
            // 
            this.pbSayac.Location = new System.Drawing.Point(265, 108);
            this.pbSayac.Name = "pbSayac";
            this.pbSayac.Size = new System.Drawing.Size(95, 88);
            this.pbSayac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSayac.TabIndex = 6;
            this.pbSayac.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(653, 718);
            this.Controls.Add(this.pbSayac);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.pbBulut);
            this.Controls.Add(this.pbZemin);
            this.Controls.Add(this.pbAltBoru);
            this.Controls.Add(this.pbUstBoru);
            this.Controls.Add(this.pbKus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Birds - erhanbaran.com";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbBulut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUstBoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAltBoru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSayac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBulut;
        private System.Windows.Forms.PictureBox pbKus;
        private System.Windows.Forms.PictureBox pbUstBoru;
        private System.Windows.Forms.PictureBox pbAltBoru;
        private System.Windows.Forms.PictureBox pbZemin;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Timer tmrOyun;
        private System.Windows.Forms.Timer tmrBaslat;
        private System.Windows.Forms.PictureBox pbSayac;
    }
}

