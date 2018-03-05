using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.IO;

namespace TanksProject
{
    public partial class LogIn : Form 
    {
        /// <summary>
        /// Konstruktor formularza
        /// </summary>
        public LogIn()
        {
            InitializeComponent();
            PictureBox logo = new PictureBox();
            imageBox_logo.ImageLocation= "https://static-ptl-eu.gcdn.co/dcont/fb/image/wot_artwork_9.18_carousel_684x243.jpg";
            imageBox_logo.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Controls.Add(logo);
            richTextBox_console.ReadOnly = true;
        }
        /// <summary>
        /// Metoda służąca do logowania się jako administrator bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_login_Click(object sender, EventArgs e)
        {
            try
            { 
                if (text_login.Text.Equals("tanksadmin") && textBox_password.Text.Equals("tankspass1") ) {
                    button_connect.Visible = true;
                    button_login.Visible = false;
                    richTextBox_console.AppendText("\n");
                    richTextBox_console.AppendText("Pomyślnie zalogowano jako administrator bazy.");
                    richTextBox_console.AppendText("\n");                
                }
                else
                {
                    throw new ArgumentException();
                }   
            } catch (ArgumentException ae)
            {
                richTextBox_console.AppendText("\n");
                richTextBox_console.AppendText("Nieprawidłowy login lub hasło.");
                richTextBox_console.AppendText("\n");
            }    
        }
        /// <summary>
        /// Metoda do nawiązywania połączenia z bazą i wywołania formularza okna głównego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {  
                TanksMainWindow window = new TanksMainWindow();
                window.Show();
                this.Enabled = false;
                this.Hide();              
            }
            catch (Exception ex)
            {
                richTextBox_console.AppendText("\n");
                richTextBox_console.AppendText(ex.Message);
                richTextBox_console.AppendText("\n");
            }
        }      
    }
}
