
namespace _220816Win_AtYarisi
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
            this.atRuzgarGrubu = new System.Windows.Forms.PictureBox();
            this.atYagız = new System.Windows.Forms.PictureBox();
            this.atPoyraz = new System.Windows.Forms.PictureBox();
            this.atGolgeYele = new System.Windows.Forms.PictureBox();
            this.atAlver = new System.Windows.Forms.PictureBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.atRuzgarGrubu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atYagız)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atPoyraz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atGolgeYele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atAlver)).BeginInit();
            this.SuspendLayout();
            // 
            // atRuzgarGrubu
            // 
            this.atRuzgarGrubu.Image = ((System.Drawing.Image)(resources.GetObject("atRuzgarGrubu.Image")));
            this.atRuzgarGrubu.Location = new System.Drawing.Point(12, 53);
            this.atRuzgarGrubu.Name = "atRuzgarGrubu";
            this.atRuzgarGrubu.Size = new System.Drawing.Size(132, 88);
            this.atRuzgarGrubu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atRuzgarGrubu.TabIndex = 0;
            this.atRuzgarGrubu.TabStop = false;
            // 
            // atYagız
            // 
            this.atYagız.Image = ((System.Drawing.Image)(resources.GetObject("atYagız.Image")));
            this.atYagız.Location = new System.Drawing.Point(12, 173);
            this.atYagız.Name = "atYagız";
            this.atYagız.Size = new System.Drawing.Size(132, 88);
            this.atYagız.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atYagız.TabIndex = 0;
            this.atYagız.TabStop = false;
            // 
            // atPoyraz
            // 
            this.atPoyraz.Image = ((System.Drawing.Image)(resources.GetObject("atPoyraz.Image")));
            this.atPoyraz.Location = new System.Drawing.Point(12, 287);
            this.atPoyraz.Name = "atPoyraz";
            this.atPoyraz.Size = new System.Drawing.Size(132, 88);
            this.atPoyraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atPoyraz.TabIndex = 0;
            this.atPoyraz.TabStop = false;
            // 
            // atGolgeYele
            // 
            this.atGolgeYele.Image = ((System.Drawing.Image)(resources.GetObject("atGolgeYele.Image")));
            this.atGolgeYele.Location = new System.Drawing.Point(12, 408);
            this.atGolgeYele.Name = "atGolgeYele";
            this.atGolgeYele.Size = new System.Drawing.Size(132, 88);
            this.atGolgeYele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atGolgeYele.TabIndex = 0;
            this.atGolgeYele.TabStop = false;
            // 
            // atAlver
            // 
            this.atAlver.Image = ((System.Drawing.Image)(resources.GetObject("atAlver.Image")));
            this.atAlver.Location = new System.Drawing.Point(12, 523);
            this.atAlver.Name = "atAlver";
            this.atAlver.Size = new System.Drawing.Size(132, 88);
            this.atAlver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atAlver.TabIndex = 0;
            this.atAlver.TabStop = false;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(12, 12);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(132, 35);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(900, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 599);
            this.label1.TabIndex = 2;
            this.label1.Text = "FINISH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(929, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.atAlver);
            this.Controls.Add(this.atGolgeYele);
            this.Controls.Add(this.atPoyraz);
            this.Controls.Add(this.atYagız);
            this.Controls.Add(this.atRuzgarGrubu);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atRuzgarGrubu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atYagız)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atPoyraz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atGolgeYele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atAlver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox atRuzgarGrubu;
        private System.Windows.Forms.PictureBox atYagız;
        private System.Windows.Forms.PictureBox atPoyraz;
        private System.Windows.Forms.PictureBox atGolgeYele;
        private System.Windows.Forms.PictureBox atAlver;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

