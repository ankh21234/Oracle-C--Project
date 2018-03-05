using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanksProject
{
    public partial class AddTankToNation : Form
    {
        private OracleConnection localOracleConnection;
        static string Zapytanie;
        /// <summary>
        /// Konstruktor formularza
        /// </summary>
        /// <param name="or">Połączenie z bazą przekazywane z okna głównego</param>
        public AddTankToNation(OracleConnection or)
        {
            InitializeComponent();
            this.localOracleConnection = or;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            consoleBox.ReadOnly = true;
        }
        /// <summary>
        /// Metoda dodająca rekord do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Zapytanie = "INSERT INTO CZOLGI_W_BITWACH VALUES(" + textTankID.Text + ", " + textArmyID.Text + ")";
                OracleCommand insert = new OracleCommand(Zapytanie, localOracleConnection);
                insert.ExecuteNonQuery();
                consoleBox.AppendText("\n");
                consoleBox.AppendText(Zapytanie + " zostało wykonane pomyślnie.");
                consoleBox.AppendText("\n");
            }

            catch (Exception ex)
            {
                consoleBox.AppendText("\n");
                consoleBox.AppendText(ex.Message);
                consoleBox.AppendText("\n");
            }
        }
        /// <summary>
        /// Metoda zamykająca okno formularza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
