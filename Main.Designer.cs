namespace QrCode_Generator
{
    partial class QRCode
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
            this.UxTxtMercName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UxButtonQrCodeGenerator = new System.Windows.Forms.Button();
            this.UxPictureBoxQrCode = new System.Windows.Forms.PictureBox();
            this.showText = new System.Windows.Forms.Label();
            this.UxTxtNotification = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UxPictureBoxQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // UxTxtMercName
            // 
            this.UxTxtMercName.Location = new System.Drawing.Point(16, 52);
            this.UxTxtMercName.Name = "UxTxtMercName";
            this.UxTxtMercName.Size = new System.Drawing.Size(267, 20);
            this.UxTxtMercName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 14;
            // 
            // UxButtonQrCodeGenerator
            // 
            this.UxButtonQrCodeGenerator.Location = new System.Drawing.Point(166, 396);
            this.UxButtonQrCodeGenerator.Name = "UxButtonQrCodeGenerator";
            this.UxButtonQrCodeGenerator.Size = new System.Drawing.Size(117, 23);
            this.UxButtonQrCodeGenerator.TabIndex = 5;
            this.UxButtonQrCodeGenerator.Text = "Gera QrCode";
            this.UxButtonQrCodeGenerator.UseVisualStyleBackColor = true;
            this.UxButtonQrCodeGenerator.Click += new System.EventHandler(this.generatorStringInConsole);
            // 
            // UxPictureBoxQrCode
            // 
            this.UxPictureBoxQrCode.Location = new System.Drawing.Point(16, 88);
            this.UxPictureBoxQrCode.Name = "UxPictureBoxQrCode";
            this.UxPictureBoxQrCode.Size = new System.Drawing.Size(267, 267);
            this.UxPictureBoxQrCode.TabIndex = 7;
            this.UxPictureBoxQrCode.TabStop = false;
            this.UxPictureBoxQrCode.Click += new System.EventHandler(this.UxPictureBoxQrCode_Click);
            // 
            // showText
            // 
            this.showText.AutoSize = true;
            this.showText.Location = new System.Drawing.Point(13, 240);
            this.showText.Name = "showText";
            this.showText.Size = new System.Drawing.Size(0, 13);
            this.showText.TabIndex = 12;
            // 
            // UxTxtNotification
            // 
            this.UxTxtNotification.AutoSize = true;
            this.UxTxtNotification.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxTxtNotification.ForeColor = System.Drawing.Color.Red;
            this.UxTxtNotification.Location = new System.Drawing.Point(293, 9);
            this.UxTxtNotification.Name = "UxTxtNotification";
            this.UxTxtNotification.Size = new System.Drawing.Size(0, 22);
            this.UxTxtNotification.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Texto:";
            // 
            // QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UxTxtNotification);
            this.Controls.Add(this.showText);
            this.Controls.Add(this.UxPictureBoxQrCode);
            this.Controls.Add(this.UxButtonQrCodeGenerator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UxTxtMercName);
            this.Name = "QRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stone QR Code v1.0.0";
            this.Load += new System.EventHandler(this.QRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UxPictureBoxQrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UxTxtMercName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UxButtonQrCodeGenerator;
        private System.Windows.Forms.PictureBox UxPictureBoxQrCode;
        private System.Windows.Forms.Label showText;
        private System.Windows.Forms.Label UxTxtNotification;
        private System.Windows.Forms.Label label2;
    }
}

