namespace WindowsFormsApplication1
{
    partial class LoginForm
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelLoginText = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.linkLabelForgotUsername = new System.Windows.Forms.LinkLabel();
            this.linkLabelSignUpText = new System.Windows.Forms.LinkLabel();
            this.buttonSignUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)), true);
            this.textBoxUsername.Location = new System.Drawing.Point(60, 294);
            this.textBoxUsername.MaximumSize = new System.Drawing.Size(0, 100);
            this.textBoxUsername.MinimumSize = new System.Drawing.Size(0, 50);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxUsername.Size = new System.Drawing.Size(630, 50);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.Text = "998998190018";
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(56, 267);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(277, 24);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Адрес эл. почты или телефон";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(60, 392);
            this.textBoxPassword.MaximumSize = new System.Drawing.Size(0, 100);
            this.textBoxPassword.MinimumSize = new System.Drawing.Size(0, 50);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(630, 50);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(56, 365);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 24);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Пароль";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.ImageLocation = "C:\\Users\\Fathulla\\OneDrive\\Faktura\\newlogo.png";
            this.pictureBoxLogo.InitialImage = global::WindowsFormsApplication1.Properties.Resources.newlogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(11, 11);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(731, 150);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMain.Controls.Add(this.pictureBoxLogo);
            this.panelMain.Location = new System.Drawing.Point(1, 1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(754, 179);
            this.panelMain.TabIndex = 0;
            // 
            // labelLoginText
            // 
            this.labelLoginText.AutoSize = true;
            this.labelLoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(155)))), ((int)(((byte)(19)))));
            this.labelLoginText.Location = new System.Drawing.Point(212, 183);
            this.labelLoginText.Name = "labelLoginText";
            this.labelLoginText.Size = new System.Drawing.Size(329, 46);
            this.labelLoginText.TabIndex = 6;
            this.labelLoginText.Text = "Войти в систему";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonSignIn.Location = new System.Drawing.Point(60, 583);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(630, 50);
            this.buttonSignIn.TabIndex = 7;
            this.buttonSignIn.Text = "Войти";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.AutoSize = true;
            this.checkBoxSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSave.Location = new System.Drawing.Point(60, 459);
            this.checkBoxSave.MaximumSize = new System.Drawing.Size(0, 100);
            this.checkBoxSave.MinimumSize = new System.Drawing.Size(0, 50);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(143, 50);
            this.checkBoxSave.TabIndex = 8;
            this.checkBoxSave.Text = "Запомнить меня";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgotPassword.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(57, 512);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(125, 18);
            this.linkLabelForgotPassword.TabIndex = 9;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Забыли пароль?";
            // 
            // linkLabelForgotUsername
            // 
            this.linkLabelForgotUsername.AutoSize = true;
            this.linkLabelForgotUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgotUsername.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelForgotUsername.Location = new System.Drawing.Point(57, 539);
            this.linkLabelForgotUsername.Name = "linkLabelForgotUsername";
            this.linkLabelForgotUsername.Size = new System.Drawing.Size(205, 18);
            this.linkLabelForgotUsername.TabIndex = 10;
            this.linkLabelForgotUsername.TabStop = true;
            this.linkLabelForgotUsername.Text = "Забыли имя пользователя?";
            // 
            // linkLabelSignUpText
            // 
            this.linkLabelSignUpText.AutoSize = true;
            this.linkLabelSignUpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSignUpText.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelSignUpText.Location = new System.Drawing.Point(277, 662);
            this.linkLabelSignUpText.Name = "linkLabelSignUpText";
            this.linkLabelSignUpText.Size = new System.Drawing.Size(221, 18);
            this.linkLabelSignUpText.TabIndex = 11;
            this.linkLabelSignUpText.TabStop = true;
            this.linkLabelSignUpText.Text = "Вы еще не зарегистрированы?";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.White;
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.ForeColor = System.Drawing.Color.Black;
            this.buttonSignUp.Location = new System.Drawing.Point(60, 692);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(630, 50);
            this.buttonSignUp.TabIndex = 12;
            this.buttonSignUp.Text = "Зарегистрироваться";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(755, 790);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.linkLabelSignUpText);
            this.Controls.Add(this.linkLabelForgotUsername);
            this.Controls.Add(this.linkLabelForgotPassword);
            this.Controls.Add(this.checkBoxSave);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelLoginText);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.panelMain);
            this.Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelLoginText;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.CheckBox checkBoxSave;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private System.Windows.Forms.LinkLabel linkLabelForgotUsername;
        private System.Windows.Forms.LinkLabel linkLabelSignUpText;
        private System.Windows.Forms.Button buttonSignUp;
    }
}

