namespace QRScanner
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
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.CaptureBox = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.capturedImage = new System.Windows.Forms.PictureBox();
            this.txtCodeText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capturedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(407, 245);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(121, 37);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "&Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(37, 288);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(250, 36);
            this.btnDecode.TabIndex = 1;
            this.btnDecode.Text = "&Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // CaptureBox
            // 
            this.CaptureBox.Location = new System.Drawing.Point(37, 27);
            this.CaptureBox.Name = "CaptureBox";
            this.CaptureBox.Size = new System.Drawing.Size(250, 212);
            this.CaptureBox.TabIndex = 2;
            this.CaptureBox.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(37, 245);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 37);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(172, 245);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(115, 37);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(293, 245);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(108, 37);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // capturedImage
            // 
            this.capturedImage.Location = new System.Drawing.Point(293, 27);
            this.capturedImage.Name = "capturedImage";
            this.capturedImage.Size = new System.Drawing.Size(235, 212);
            this.capturedImage.TabIndex = 6;
            this.capturedImage.TabStop = false;
            // 
            // txtCodeText
            // 
            this.txtCodeText.Location = new System.Drawing.Point(293, 288);
            this.txtCodeText.Name = "txtCodeText";
            this.txtCodeText.Size = new System.Drawing.Size(235, 20);
            this.txtCodeText.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 336);
            this.Controls.Add(this.txtCodeText);
            this.Controls.Add(this.capturedImage);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.CaptureBox);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnCapture);
            this.Name = "Form1";
            this.Text = "QRXcan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capturedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.PictureBox CaptureBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.PictureBox capturedImage;
        private System.Windows.Forms.TextBox txtCodeText;
    }
}

