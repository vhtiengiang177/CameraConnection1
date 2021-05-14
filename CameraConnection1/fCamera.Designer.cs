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
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbListCamera
            // 
            this.cbbListCamera.FormattingEnabled = true;
            this.cbbListCamera.Location = new System.Drawing.Point(59, 22);
            this.cbbListCamera.Name = "cbbListCamera";
            this.cbbListCamera.Size = new System.Drawing.Size(239, 21);
            this.cbbListCamera.TabIndex = 0;
            // 
            // ptbCam
            // 
            this.ptbCam.Location = new System.Drawing.Point(12, 66);
            this.ptbCam.Name = "ptbCam";
            this.ptbCam.Size = new System.Drawing.Size(401, 297);
            this.ptbCam.TabIndex = 1;
            this.ptbCam.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(304, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnTakeAPhoto
            // 
            this.btnTakeAPhoto.Location = new System.Drawing.Point(153, 380);
            this.btnTakeAPhoto.Name = "btnTakeAPhoto";
            this.btnTakeAPhoto.Size = new System.Drawing.Size(87, 23);
            this.btnTakeAPhoto.TabIndex = 3;
            this.btnTakeAPhoto.Text = "Take a photo";
            this.btnTakeAPhoto.UseVisualStyleBackColor = true;
            this.btnTakeAPhoto.Click += new System.EventHandler(this.btnTakeAPhoto_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(385, 20);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Camera";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(439, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 297);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnTakeAPhoto);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.ptbCam);
            this.Controls.Add(this.cbbListCamera);
            this.Name = "fCamera";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbListCamera;
        private System.Windows.Forms.PictureBox ptbCam;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnTakeAPhoto;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

