namespace TemplateAssessment1
{
    partial class MainForm
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.GunShootBt = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.PictureBox();
            this.ShootAwayBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // GunShootBt
            // 
            this.GunShootBt.Location = new System.Drawing.Point(39, 42);
            this.GunShootBt.Name = "GunShootBt";
            this.GunShootBt.Size = new System.Drawing.Size(76, 33);
            this.GunShootBt.TabIndex = 1;
            this.GunShootBt.Text = "b                           ";
            this.GunShootBt.UseVisualStyleBackColor = true;
            this.GunShootBt.Click += new System.EventHandler(this.GunShoot_Click);
            // 
            // background
            // 
            this.background.Image = global::TemplateAssessment1.Properties.Resources.angerpic;
            this.background.Location = new System.Drawing.Point(39, 42);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(209, 188);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // ShootAwayBt
            // 
            this.ShootAwayBt.Location = new System.Drawing.Point(172, 197);
            this.ShootAwayBt.Name = "ShootAwayBt";
            this.ShootAwayBt.Size = new System.Drawing.Size(76, 33);
            this.ShootAwayBt.TabIndex = 2;
            this.ShootAwayBt.Text = "GunShoot";
            this.ShootAwayBt.UseVisualStyleBackColor = true;
            this.ShootAwayBt.Click += new System.EventHandler(this.ShootAwayBt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.ShootAwayBt);
            this.Controls.Add(this.GunShootBt);
            this.Controls.Add(this.background);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Button GunShootBt;
        private System.Windows.Forms.Button ShootAwayBt;
    }
}

