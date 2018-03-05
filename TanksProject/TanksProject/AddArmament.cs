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
    public partial class AddArmament : Form
    {
        private OracleConnection localOracleConnection;
        static string Zapytanie;
        /// <summary>
        /// Konstruktor formularza
        /// </summary>
        /// <param name="or">Połączenie z bazą przekazywane z okna głównego</param>
        public AddArmament(OracleConnection or)
        {
            InitializeComponent();
            this.localOracleConnection = or;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            consoleBox.ReadOnly = true;
        }
        /// <summary>
        /// Metoda dodająca rekord do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textArmamentID.Text.Equals(null) || textReloadTime.Text.Equals(null) || textStartOfProduction.Text.Equals(null) || textCaliber.Text.Equals(null) || textPenetration.Text.Equals(null))
                {
                    throw new ArgumentNullException();
                }
                int n1, n2, n3, n4, n5;
                Boolean isNumeric1 = int.TryParse(textArmamentID.Text, out n1);
                Boolean isNumeric2 = int.TryParse(textReloadTime.Text, out n2);
                Boolean isNumeric3 = int.TryParse(textStartOfProduction.Text, out n3);
                Boolean isNumeric4 = int.TryParse(textCaliber.Text, out n4);
                Boolean isNumeric5 = int.TryParse(textPenetration.Text, out n5);

                String zapytanieSprawdzajace = "SELECT * FROM UZBROJENIE WHERE ID_UZBROJENIA LIKE " + textArmamentID.Text;
                OracleCommand test = new OracleCommand(zapytanieSprawdzajace, localOracleConnection);
                int sqlRezultat = test.ExecuteNonQuery();
                if (isNumeric1 || isNumeric2 || n1 > 0 || n2 > 0 || n3 > 0 || n4 > 0 || n5 > 0 || sqlRezultat < 0)
                {
                    Zapytanie = "INSERT INTO UZBROJENIE VALUES(" + textArmamentID.Text + ", " + textReloadTime.Text + ", " + textCaliber.Text + ", " + textStartOfProduction.Text + "," + textPenetration.Text + ")";
                    OracleCommand insert = new OracleCommand(Zapytanie, localOracleConnection);
                    insert.ExecuteNonQuery();
                    consoleBox.AppendText("\n");
                    consoleBox.AppendText(Zapytanie + " zostało wykonane pomyślnie.");
                    consoleBox.AppendText("\n");
                }
            }
            catch (ArgumentNullException ane)
            {
                consoleBox.AppendText("\n");
                consoleBox.AppendText("Któryś z argumentów jest pusty. Sprawdź dane wejściowe.");
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
