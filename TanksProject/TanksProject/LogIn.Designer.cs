namespace TanksProject
{
    partial class LogIn
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
            this.imageBox_logo = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_line1 = new System.Windows.Forms.Label();
            this.label_line2 = new System.Windows.Forms.Label();
            this.label_line5 = new System.Windows.Forms.Label();
            this.label_line6 = new System.Windows.Forms.Label();
            this.label_line7 = new System.Windows.Forms.Label();
            this.label_line8 = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.text_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.richTextBox_console = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox_logo
            // 
            this.imageBox_logo.Location = new System.Drawing.Point(12, 12);
            this.imageBox_logo.Name = "imageBox_logo";
            this.imageBox_logo.Size = new System.Drawing.Size(697, 175);
            this.imageBox_logo.TabIndex = 0;
            this.imageBox_logo.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.Location = new System.Drawing.Point(715, 12);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(229, 55);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "TanksDB";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(722, 85);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(451, 13);
            this.label_description.TabIndex = 2;
            this.label_description.Text = "Aplikacja służąca do zarządzania bazą danych utworzoną za pomocą oprogramowania O" +
    "racle";
            // 
            // label_line1
            // 
            this.label_line1.AutoSize = true;
            this.label_line1.Location = new System.Drawing.Point(722, 102);
            this.label_line1.Name = "label_line1";
            this.label_line1.Size = new System.Drawing.Size(89, 13);
            this.label_line1.TabIndex = 3;
            this.label_line1.Text = "Funkcje aplikacji:";
            // 
            // label_line2
            // 
            this.label_line2.AutoSize = true;
            this.label_line2.Location = new System.Drawing.Point(722, 115);
            this.label_line2.Name = "label_line2";
            this.label_line2.Size = new System.Drawing.Size(136, 13);
            this.label_line2.TabIndex = 4;
            this.label_line2.Text = "- zarządzanie bazą danych,";
            // 
            // label_line5
            // 
            this.label_line5.AutoSize = true;
            this.label_line5.Location = new System.Drawing.Point(722, 128);
            this.label_line5.Name = "label_line5";
            this.label_line5.Size = new System.Drawing.Size(191, 13);
            this.label_line5.TabIndex = 7;
            this.label_line5.Text = "- zaliczenie przedmiotu Bazy Danych II.";
            // 
            // label_line6
            // 
            this.label_line6.AutoSize = true;
            this.label_line6.Location = new System.Drawing.Point(722, 232);
            this.label_line6.Name = "label_line6";
            this.label_line6.Size = new System.Drawing.Size(40, 13);
            this.label_line6.TabIndex = 8;
            this.label_line6.Text = "Uwagi:";
            // 
            // label_line7
            // 
            this.label_line7.AutoSize = true;
            this.label_line7.Location = new System.Drawing.Point(722, 251);
            this.label_line7.Name = "label_line7";
            this.label_line7.Size = new System.Drawing.Size(394, 13);
            this.label_line7.TabIndex = 9;
            this.label_line7.Text = "- po zalogowaniu i połączeniu się z bazą, program przejdzie w tryb administracyjn" +
    "y.";
            // 
            // label_line8
            // 
            this.label_line8.AutoSize = true;
            this.label_line8.Location = new System.Drawing.Point(722, 264);
            this.label_line8.Name = "label_line8";
            this.label_line8.Size = new System.Drawing.Size(335, 13);
            this.label_line8.TabIndex = 10;
            this.label_line8.Text = "- dane logowania znajdują się w dokumentacji użytkownika programu.";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(9, 289);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(36, 13);
            this.label_login.TabIndex = 11;
            this.label_login.Text = "Login:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(9, 323);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(39, 13);
            this.label_password.TabIndex = 12;
            this.label_password.Text = "Hasło:";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(55, 361);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(100, 23);
            this.button_login.TabIndex = 13;
            this.button_login.Text = "Zaloguj";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(54, 361);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(100, 23);
            this.button_connect.TabIndex = 14;
            this.button_connect.Text = "Połącz z bazą";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Visible = false;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // text_login
            // 
            this.text_login.Location = new System.Drawing.Point(55, 286);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(100, 20);
            this.text_login.TabIndex = 16;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(54, 320);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 18;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // richTextBox_console
            // 
            this.richTextBox_console.Location = new System.Drawing.Point(725, 289);
            this.richTextBox_console.Name = "richTextBox_console";
            this.richTextBox_console.Size = new System.Drawing.Size(447, 155);
            this.richTextBox_console.TabIndex = 19;
            this.richTextBox_console.Text = "";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 456);
            this.Controls.Add(this.richTextBox_console);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_line8);
            this.Controls.Add(this.label_line7);
            this.Controls.Add(this.label_line6);
            this.Controls.Add(this.label_line5);
            this.Controls.Add(this.label_line2);
            this.Controls.Add(this.label_line1);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.imageBox_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.Text = "Okno logowania programu TanksDB";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox_logo;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_line1;
        private System.Windows.Forms.Label label_line2;
        private System.Windows.Forms.Label label_line5;
        private System.Windows.Forms.Label label_line6;
        private System.Windows.Forms.Label label_line7;
        private System.Windows.Forms.Label label_line8;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.RichTextBox richTextBox_console;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}