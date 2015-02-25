namespace WordUtils
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
            this.bProtect = new System.Windows.Forms.Button();
            this.bWatermark = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label = new System.Windows.Forms.Label();
            this.tbWatermarkText = new System.Windows.Forms.TextBox();
            this.tbProtectPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bProtect
            // 
            this.bProtect.Location = new System.Drawing.Point(12, 62);
            this.bProtect.Name = "bProtect";
            this.bProtect.Size = new System.Drawing.Size(114, 23);
            this.bProtect.TabIndex = 0;
            this.bProtect.Text = "Add Protection";
            this.bProtect.UseVisualStyleBackColor = true;
            this.bProtect.Click += new System.EventHandler(this.bProtect_Click);
            // 
            // bWatermark
            // 
            this.bWatermark.Location = new System.Drawing.Point(11, 19);
            this.bWatermark.Name = "bWatermark";
            this.bWatermark.Size = new System.Drawing.Size(115, 23);
            this.bWatermark.TabIndex = 1;
            this.bWatermark.Text = "Add Watermark";
            this.bWatermark.UseVisualStyleBackColor = true;
            this.bWatermark.Click += new System.EventHandler(this.bWatermark_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "docx";
            this.openFileDialog.Filter = "Word files|*.docx|All Files|*.*";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 94);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 2;
            // 
            // tbWatermarkText
            // 
            this.tbWatermarkText.Location = new System.Drawing.Point(146, 21);
            this.tbWatermarkText.Name = "tbWatermarkText";
            this.tbWatermarkText.Size = new System.Drawing.Size(121, 20);
            this.tbWatermarkText.TabIndex = 5;
            this.tbWatermarkText.Text = "watermark";
            // 
            // tbProtectPassword
            // 
            this.tbProtectPassword.Location = new System.Drawing.Point(146, 64);
            this.tbProtectPassword.Name = "tbProtectPassword";
            this.tbProtectPassword.Size = new System.Drawing.Size(121, 20);
            this.tbProtectPassword.TabIndex = 6;
            this.tbProtectPassword.Text = "123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter watermark text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 116);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProtectPassword);
            this.Controls.Add(this.tbWatermarkText);
            this.Controls.Add(this.label);
            this.Controls.Add(this.bWatermark);
            this.Controls.Add(this.bProtect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add watermark and protection to word document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bProtect;
        private System.Windows.Forms.Button bWatermark;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbWatermarkText;
        private System.Windows.Forms.TextBox tbProtectPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

