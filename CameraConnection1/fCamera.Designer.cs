namespace CameraConnection1
{
    partial class fCamera
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
            this.cbbListCamera = new System.Windows.Forms.ComboBox();
            this.ptbCam = new System.Windows.Forms.PictureBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnTakeAPhoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbPhoto = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbListCamera
            // 
            this.cbbListCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbListCamera.FormattingEnabled = true;
            this.cbbListCamera.Location = new System.Drawing.Point(79, 19);
            this.cbbListCamera.Name = "cbbListCamera";
            this.cbbListCamera.Size = new System.Drawing.Size(239, 24);
            this.cbbListCamera.TabIndex = 0;
            // 
            // ptbCam
            // 
            this.ptbCam.Location = new System.Drawing.Point(12, 66);
            this.ptbCam.Name = "ptbCam";
            this.ptbCam.Size = new System.Drawing.Size(401, 297);
            this.ptbCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCam.TabIndex = 1;
            this.ptbCam.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(338, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 41);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnTakeAPhoto
            // 
            this.btnTakeAPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAPhoto.Location = new System.Drawing.Point(146, 380);
            this.btnTakeAPhoto.Name = "btnTakeAPhoto";
            this.btnTakeAPhoto.Size = new System.Drawing.Size(106, 41);
            this.btnTakeAPhoto.TabIndex = 3;
            this.btnTakeAPhoto.Text = "Take a photo";
            this.btnTakeAPhoto.UseVisualStyleBackColor = true;
            this.btnTakeAPhoto.Click += new System.EventHandler(this.btnTakeAPhoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Camera:";
            // 
            // ptbPhoto
            // 
            this.ptbPhoto.Location = new System.Drawing.Point(439, 66);
            this.ptbPhoto.Name = "ptbPhoto";
            this.ptbPhoto.Size = new System.Drawing.Size(401, 297);
            this.ptbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPhoto.TabIndex = 6;
            this.ptbPhoto.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(597, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 41);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // fCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 433);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.ptbPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTakeAPhoto);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.ptbCam);
            this.Controls.Add(this.cbbListCamera);
            this.Name = "fCamera";
            this.Text = "Camera";
            ((System.ComponentModel.ISupportInitialize)(this.ptbCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbListCamera;
        private System.Windows.Forms.PictureBox ptbCam;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnTakeAPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbPhoto;
        private System.Windows.Forms.Button btnClear;
    }
}

