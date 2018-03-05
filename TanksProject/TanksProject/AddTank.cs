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
    public partial class AddTank : Form
    {
        private OracleConnection localOracleConnection;
        static string Zapytanie;
        /// <summary>
        /// Konstruktor formularza
        /// </summary>
        /// <param name="or">Połączenie z bazą przekazywane z okna głównego</param>
        public AddTank(OracleConnection or)
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
                if (textArmamentID.Text.Equals(null) || textArmorFrontal.Text.Equals(null) || textArmorRear.Text.Equals(null) || textArmorSide.Text.Equals(null) || textCrew.Text.Equals(null) || textEngineID.Text.Equals(null) || textName.Text.Equals(null) || textNation.Text.Equals(null) || textTankID.Text.Equals(null) || textTankType.Text.Equals(null) || textArmamentID.Text.Equals(" ") || textArmorFrontal.Text.Equals(" ") || textArmorRear.Text.Equals(" ") || textArmorSide.Text.Equals(" ") || textCrew.Text.Equals(" ") || textEngineID.Text.Equals(" ") || textName.Text.Equals(" ") || textNation.Text.Equals(" ") || textTankID.Text.Equals(" ") || textTankType.Text.Equals(" "))
                {
                    throw new ArgumentNullException();
                } 
                int n1, n2, n3, n4, n5, n6, n7;
                Boolean isNumeric1 = int.TryParse(textTankID.Text,out n1);
                Boolean isNumeric2 = int.TryParse(textEngineID.Text,out n2);
                Boolean isNumeric3 = int.TryParse(textArmamentID.Text, out n3);
                Boolean isNumeric4 = int.TryParse(textCrew.Text, out n4);
                Boolean isNumeric5 = int.TryParse(textArmorFrontal.Text, out n5);
                Boolean isNumeric6 = int.TryParse(textArmorRear.Text, out n6);
                Boolean isNumeric7 = int.TryParse(textArmorSide.Text, out n7);
                String zapytanieSprawdzajace = "SELECT * FROM CZOLGI WHERE ID_CZOLGU LIKE " + textTankID.Text;
                OracleCommand test = new OracleCommand(zapytanieSprawdzajace, localOracleConnection);
                int sqlRezultat = test.ExecuteNonQuery();
                if (isNumeric1 || isNumeric2 || isNumeric3 || isNumeric4 || isNumeric5 || isNumeric6 || isNumeric7 || n1 >0 || n2 >0 || n3 >0 || n4 >0 || n5 >0 || n6 >0 || n7 >0 || sqlRezultat <0) 
                {
                    Zapytanie = "INSERT INTO CZOLGI VALUES(" + textTankID.Text + ", " + textEngineID.Text + ", " + textArmamentID.Text + ", '" + textTankType.Text + "', " + textCrew.Text + ", '" + textNation.Text + "', " + textArmorFrontal.Text + ", " + textArmorRear.Text + ", " + textArmorSide.Text + ", '" + textName.Text + "')";
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
