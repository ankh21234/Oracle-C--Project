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
    public partial class AddBattle : Form
    {
        private OracleConnection localOracleConnection;
        static string Zapytanie;
        /// <summary>
        /// Konstruktor formularza
        /// </summary>
        /// <param name="or">Połączenie z bazą przekazywane z okna głównego</param>
        public AddBattle(OracleConnection or)
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
                if (textBattleID.Text.Equals(null) || textYear.Text.Equals(null) || textWinner.Text.Equals(null))
                {
                    throw new ArgumentNullException();
                }
                int n1, n2;
                Boolean isNumeric1 = int.TryParse(textBattleID.Text, out n1);
                Boolean isNumeric2 = int.TryParse(textYear.Text, out n2);
               
                String zapytanieSprawdzajace = "SELECT * FROM BITWY WHERE ID_BITWY LIKE " + textBattleID.Text;
                OracleCommand test = new OracleCommand(zapytanieSprawdzajace, localOracleConnection);
                int sqlRezultat = test.ExecuteNonQuery();
                if (isNumeric1 || isNumeric2 || n1 > 0 || n2 > 0 || sqlRezultat < 0)
                {
                    Zapytanie = "INSERT INTO BITWY VALUES(" + textBattleID.Text + ", " + textYear.Text + ", '" + textWinner.Text + "')";
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
