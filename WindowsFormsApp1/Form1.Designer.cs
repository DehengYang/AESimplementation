namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.encryption = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.InputTextLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.OutputTextLabel = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encryption
            // 
            this.encryption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.encryption.Location = new System.Drawing.Point(481, 218);
            this.encryption.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.encryption.Name = "encryption";
            this.encryption.Size = new System.Drawing.Size(138, 47);
            this.encryption.TabIndex = 0;
            this.encryption.Text = "encrypt";
            this.encryption.UseVisualStyleBackColor = false;
            this.encryption.Click += new System.EventHandler(this.encryption_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(115, 218);
            this.inputText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(136, 34);
            this.inputText.TabIndex = 1;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(851, 224);
            this.outputText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(226, 34);
            this.outputText.TabIndex = 2;
            // 
            // InputTextLabel
            // 
            this.InputTextLabel.AutoSize = true;
            this.InputTextLabel.Location = new System.Drawing.Point(14, 221);
            this.InputTextLabel.Name = "InputTextLabel";
            this.InputTextLabel.Size = new System.Drawing.Size(94, 28);
            this.InputTextLabel.TabIndex = 3;
            this.InputTextLabel.Text = "InputText";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(115, 260);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(136, 34);
            this.passwordText.TabIndex = 1;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(14, 263);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(94, 28);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // OutputTextLabel
            // 
            this.OutputTextLabel.AutoSize = true;
            this.OutputTextLabel.Location = new System.Drawing.Point(733, 221);
            this.OutputTextLabel.Name = "OutputTextLabel";
            this.OutputTextLabel.Size = new System.Drawing.Size(111, 28);
            this.OutputTextLabel.TabIndex = 3;
            this.OutputTextLabel.Text = "OutputText";
            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.decryptButton.Location = new System.Drawing.Point(481, 277);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(138, 47);
            this.decryptButton.TabIndex = 0;
            this.decryptButton.Text = "decrypt";
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.decryption_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 507);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.OutputTextLabel);
            this.Controls.Add(this.InputTextLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryption);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "encryption_decryption_app";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryption;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label InputTextLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label OutputTextLabel;
        private System.Windows.Forms.Button decryptButton;
    }
}

