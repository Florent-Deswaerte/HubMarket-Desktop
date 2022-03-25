namespace HubMarket_Desktop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.debugLabel = new MaterialSkin.Controls.MaterialLabel();
            this.connectButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.usernameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Depth = 0;
            this.debugLabel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.debugLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.debugLabel.Location = new System.Drawing.Point(346, 327);
            this.debugLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(0, 24);
            this.debugLabel.TabIndex = 4;
            // 
            // connectButton
            // 
            this.connectButton.AutoSize = true;
            this.connectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectButton.Depth = 0;
            this.connectButton.Icon = null;
            this.connectButton.Location = new System.Drawing.Point(346, 263);
            this.connectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectButton.Name = "connectButton";
            this.connectButton.Primary = true;
            this.connectButton.Size = new System.Drawing.Size(146, 36);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Se Connecter";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.Connexion);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Depth = 0;
            this.usernameTextBox.Hint = "Email";
            this.usernameTextBox.Location = new System.Drawing.Point(347, 139);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.SelectionLength = 0;
            this.usernameTextBox.SelectionStart = 0;
            this.usernameTextBox.Size = new System.Drawing.Size(145, 28);
            this.usernameTextBox.TabIndex = 7;
            this.usernameTextBox.TabStop = false;
            this.usernameTextBox.UseSystemPasswordChar = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Hint = "Mot de passe";
            this.passwordTextBox.Location = new System.Drawing.Point(347, 196);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.Size = new System.Drawing.Size(145, 28);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.UseSystemPasswordChar = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.debugLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel debugLabel;
        private MaterialSkin.Controls.MaterialRaisedButton connectButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField usernameTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextBox;
    }
}

