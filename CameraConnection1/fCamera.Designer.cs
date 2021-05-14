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
            this.btnDisconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbListCamera
            // 
            this.cbbListCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbListCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbListCamera.FormattingEnabled = true;
            this.cbbListCamera.Location = new System.Drawing.Point(105, 23);
            this.cbbListCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbListCamera.Name = "cbbListCamera";
            this.cbbListCamera.Size = new System.Drawing.Size(317, 28);
            this.cbbListCamera.TabIndex = 0;
            // 
            // ptbCam
            // 
            this.ptbCam.Location = new System.Drawing.Point(16, 81);
            this.ptbCam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbCam.Name = "ptbCam";
            this.ptbCam.Size = new System.Drawing.Size(535, 366);
            this.ptbCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCam.TabIndex = 1;
            this.ptbCam.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConnect.Location = new System.Drawing.Point(451, 11);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(110, 50);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnTakeAPhoto
            // 
            this.btnTakeAPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAPhoto.Location = new System.Drawing.Point(195, 468);
            this.btnTakeAPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTakeAPhoto.Name = "btnTakeAPhoto";
            this.btnTakeAPhoto.Size = new System.Drawing.Size(141, 50);
            this.btnTakeAPhoto.TabIndex = 3;
            this.btnTakeAPhoto.Text = "Take a photo";
            this.btnTakeAPhoto.UseVisualStyleBackColor = true;
            this.btnTakeAPhoto.Click += new System.EventHandler(this.btnTakeAPhoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Camera:";
            // 
            // ptbPhoto
            // 
            this.ptbPhoto.Location = new System.Drawing.Point(568, 81);
            this.ptbPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbPhoto.Name = "ptbPhoto";
            this.ptbPhoto.Size = new System.Drawing.Size(535, 366);
            this.ptbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPhoto.TabIndex = 6;
            this.ptbPhoto.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(770, 468);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 50);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(578, 11);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(125, 50);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // fCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 565);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.ptbPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTakeAPhoto);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.ptbCam);
            this.Controls.Add(this.cbbListCamera);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnDisconnect;
    }
}

