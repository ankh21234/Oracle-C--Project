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

namespace TanksProject
{
    public partial class TanksMainWindow : Form
    {
        static OracleConnection oracleConnection;
        static Boolean test=true;
        /// <summary>
        /// Konstruktor formularza okna głównego, dodatkowo nawiązuje automatycznie połączenie z bazą
        /// </summary>
        public TanksMainWindow()
        {
           
            InitializeComponent();
            textBox_console.ReadOnly = true;
            string strCon = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                             (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=Tanks)));
                             User Id = tanksadmin; Password = tankspass1; ";
            string text;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            try
            {
                oracleConnection = new OracleConnection(strCon);
               oracleConnection.Open();
                text = "Nawiązano połączenie z bazą danych.";
                textBox_console.AppendText("\n");
                textBox_console.AppendText(text);
                textBox_console.AppendText("\n");
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }


        }
        /// <summary>
        /// Metoda służąca do wyświetlania rekordów z bazy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_showTanks_Click(object sender, EventArgs e)
        {
            try {
                dataSet1.Reset();
                OracleCommand cmd = new OracleCommand("select * from czolgi order by id_czolgu", oracleConnection);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter dataAdapter = new OracleDataAdapter();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet1);
                dataGridView1.DataSource = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
        }
        /// <summary>
        /// Metoda służąca do wywoływania formularza dodawania nowego rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_addTank_Click(object sender, EventArgs e)
        { try {
                AddTank dodajCzolg = new AddTank(oracleConnection);
                dodajCzolg.ShowDialog();
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
            
        }
        /// <summary>
        /// Metoda aktualizująca bazę danych na podstawie edycji wybranego w tabeli rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_updateTank_Click(object sender, EventArgs e)
        {
            try
            {
                int indexRow = dataGridView1.CurrentCell.RowIndex;
                int indexColumn = 0;
                String IndeksTabeli = dataGridView1.CurrentCell.RowIndex.ToString();
                String daneZTabeli = dataGridView1.Rows[indexRow].Cells[indexColumn].Value.ToString();
                OracleCommand cmd = new OracleCommand("update czolgi set id_silnika=" + dataGridView1.Rows[indexRow].Cells[1].Value.ToString() + ", id_uzbrojenia=" + dataGridView1.Rows[indexRow].Cells[2].Value.ToString() + ",typ='" + dataGridView1.Rows[indexRow].Cells[3].Value.ToString() + "',liczba_zalogantow=" + dataGridView1.Rows[indexRow].Cells[4].Value.ToString() + ", nacja='" + dataGridView1.Rows[indexRow].Cells[5].Value.ToString() + "', pancerz_przod=" + dataGridView1.Rows[indexRow].Cells[6].Value.ToString() + ", pancerz_tyl=" + dataGridView1.Rows[indexRow].Cells[7].Value.ToString() + ", pancerz_bok=" + dataGridView1.Rows[indexRow].Cells[8].Value.ToString() + ", nazwa='" + dataGridView1.Rows[indexRow].Cells[9].Value.ToString() + "' where id_czolgu like " + dataGridView1.Rows[indexRow].Cells[indexColumn].Value.ToString(), oracleConnection);
                cmd.ExecuteNonQuery();
                textBox_console.AppendText("\n");
                textBox_console.AppendText("Zapytanie wykonane pomyślnie.");
                textBox_console.AppendText("\n");
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
        }
        /// <summary>
        /// Metoda służąca do wyświetlania rekordów z bazy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_showBattles_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet1.Reset();
                OracleCommand cmd = new OracleCommand("select * from bitwy order by id_bitwy", oracleConnection);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter dataAdapter = new OracleDataAdapter();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet1);
                dataGridView1.DataSource = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
        }
        /// <summary>
        /// Metoda służąca do wywoływania formularza dodawania nowego rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_addBattle_Click(object sender, EventArgs e)
        {
            AddBattle dodajBitwe = new AddBattle(oracleConnection);
            dodajBitwe.ShowDialog();
        }
        /// <summary>
        /// Metoda aktualizująca bazę danych na podstawie edycji wybranego w tabeli rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_updateBattle_Click(object sender, EventArgs e)
        {
            try
            {
                int indexRow = dataGridView1.CurrentCell.RowIndex;
                int indexColumn = 0;
                String IndeksTabeli = dataGridView1.CurrentCell.RowIndex.ToString();
                String daneZTabeli = dataGridView1.Rows[indexRow].Cells[indexColumn].Value.ToString();
                OracleCommand cmd = new OracleCommand("update bitwy set rok=" + dataGridView1.Rows[indexRow].Cells[1].Value.ToString() + ", zwyciezca='" + dataGridView1.Rows[indexRow].Cells[2].Value.ToString() + "' where id_bitwy like " + dataGridView1.Rows[indexRow].Cells[indexColumn].Value.ToString(), oracleConnection);
                cmd.ExecuteNonQuery();
                textBox_console.AppendText("\n");
                textBox_console.AppendText("Zapytanie wykonane pomyślnie.");
                textBox_console.AppendText("\n");
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
        }
        /// <summary>
        /// Metoda służąca do wyświetlania rekordów z bazy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_showEngines_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet1.Reset();
                OracleCommand cmd = new OracleCommand("select * from silniki order by id_silnika", oracleConnection);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter dataAdapter = new OracleDataAdapter();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet1);
                dataGridView1.DataSource = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
        }
        /// <summary>
        /// Metoda służąca do wywoływania formularza dodawania nowego rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_addEngine_Click(object sender, EventArgs e)
        {
            AddEngine dodajSilnik = new AddEngine(oracleConnection);
            dodajSilnik.ShowDialog();
        }

        /// <summary>
        /// Metoda aktualizująca bazę danych na podstawie edycji wybranego w tabeli rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_updateEngine_Click(object sender, EventArgs e)
        {
            try
            {
                int indexRow = dataGridView1.CurrentCell.RowIndex;
                int indexColumn = 0;
                String IndeksTabeli = dataGridView1.CurrentCell.RowIndex.ToString();
                String daneZTabeli = dataGridView1.Rows[indexRow].Cells[indexColumn].Value.ToString();
                OracleCommand cmd = new OracleCommand("update silniki set moc=" + dataGridView1.Rows[indexRow].Cells[1].Value.ToString() + ", typ='" + dataGridView1.Rows[indexRow].Cells[2].Value.ToString() + "',producent='" + dataGridView1.Rows[indexRow].Cells[3].Value.ToString() + "' where id_silnika like " + dataGridView1.Rows[indexRow].Cells[indexColumn].Value.ToString(), oracleConnection);
                cmd.ExecuteNonQuery();
                textBox_console.AppendText("\n");
                textBox_console.AppendText("Zapytanie wykonane pomyślnie.");
                textBox_console.AppendText("\n");
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }

        }
        /// <summary>
        /// Metoda służąca do wyświetlania rekordów z bazy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_showArmaments_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet1.Reset();
                OracleCommand cmd = new OracleCommand("select * from uzbrojenie order by id_uzbrojenia", oracleConnection);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter dataAdapter = new OracleDataAdapter();
                dataAdapter.SelectCommand = cmd;       
                dataAdapter.Fill(dataSet1);
                dataGridView1.DataSource = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
        }

        /// <summary>
        /// Metoda służąca do wywoływania formularza dodawania nowego rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_addArmament_Click(object sender, EventArgs e)
        {
            AddArmament dodajUzbrojenie = new AddArmament(oracleConnection);
            dodajUzbrojenie.ShowDialog();
        }
        /// <summary>
        /// Metoda aktualizująca bazę danych na podstawie edycji wybranego w tabeli rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_updateArmament_Click(object sender, EventArgs e)
        {
            try
            {
                int indexRow = dataGridView1.CurrentCell.RowIndex;
                int indexColumn = 0;
                String IndeksTabeli = dataGridView1.CurrentCell.RowIndex.ToString();
                String daneZTabeli = dataGridView1.Rows[indexRow].Cells[indexColumn].Value.ToString();
                OracleCommand cmd = new OracleCommand("update uzbrojenie set czas_przeladowania=" + dataGridView1.Rows[indexRow].Cells[1].Value.ToString() + ", kaliber=" + dataGridView1.Rows[indexRow].Cells[2].Value.ToString() + ", poczatek_produkcji="+ dataGridView1.Rows[indexRow].Cells[3].Value.ToString() + ", penetracja="+ dataGridView1.Rows[indexRow].Cells[4].Value.ToString() + " where id_uzbrojenia like " + dataGridView1.Rows[indexRow].Cells[indexColumn].Value.ToString(), oracleConnection);
                cmd.ExecuteNonQuery();
                textBox_console.AppendText("\n");
                textBox_console.AppendText("Zapytanie wykonane pomyślnie.");
                textBox_console.AppendText("\n");
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
        }
        /// <summary>
        /// Metoda służąca do wyświetlania rekordów z bazy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_showArmies_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet1.Reset();
                OracleCommand cmd = new OracleCommand("select * from nacje_bitwy order by id_nacji", oracleConnection);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter dataAdapter = new OracleDataAdapter();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet1);
                dataGridView1.DataSource = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
        }

        /// <summary>
        /// Metoda służąca do wywoływania formularza dodawania nowego rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_addArmy_Click(object sender, EventArgs e)
        {
            AddArmy dodajArmie = new AddArmy(oracleConnection);
            dodajArmie.ShowDialog();
        }
        /// <summary>
        /// Metoda aktualizująca bazę danych na podstawie edycji wybranego w tabeli rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_updateArmy_Click(object sender, EventArgs e)
        {
            try
            {
                int indexRow = dataGridView1.CurrentCell.RowIndex;
                int indexColumn = 0;
                String IndeksTabeli = dataGridView1.CurrentCell.RowIndex.ToString();
                String daneZTabeli = dataGridView1.Rows[indexRow].Cells[indexColumn].Value.ToString();
                OracleCommand cmd = new OracleCommand("update nacje_bitwy set nazwa='" + dataGridView1.Rows[indexRow].Cells[1].Value.ToString() + "', liczebnosc_pojazdow=" + dataGridView1.Rows[indexRow].Cells[2].Value.ToString() + "', liczebnosc_piechoty="+ dataGridView1.Rows[indexRow].Cells[3].Value.ToString() + ", dowodca='"+ dataGridView1.Rows[indexRow].Cells[4].Value.ToString()+"', straty="+ dataGridView1.Rows[indexRow].Cells[5].Value.ToString() + " where id_nacji like " + dataGridView1.Rows[indexRow].Cells[indexColumn].Value.ToString(), oracleConnection);
                cmd.ExecuteNonQuery();
                textBox_console.AppendText("\n");
                textBox_console.AppendText("Zapytanie wykonane pomyślnie.");
                textBox_console.AppendText("\n");
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
        }

        /// <summary>
        /// Metoda służąca do wyświetlania rekordów z bazy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowTanksNations_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet1.Reset();
                OracleCommand cmd = new OracleCommand("select * from czolgi_w_bitwach order by id_czolgu", oracleConnection);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter dataAdapter = new OracleDataAdapter();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet1);
                dataGridView1.DataSource = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
        }

        /// <summary>
        /// Metoda służąca do wywoływania formularza dodawania nowego rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonAddTankNation_Click(object sender, EventArgs e)
        {
            AddTankToNation dodajCzolgDoNacji = new AddTankToNation(oracleConnection);
            dodajCzolgDoNacji.ShowDialog();
        }

        /// <summary>
        /// Metoda aktualizująca bazę danych na podstawie edycji wybranego w tabeli rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteTankNation_Click(object sender, EventArgs e)
        {
            try
            {
                int indexRow = dataGridView1.CurrentCell.RowIndex;
                int indexColumn = 0;
                String IndeksTabeli = dataGridView1.CurrentCell.RowIndex.ToString();
                String daneZTabeli = dataGridView1.Rows[indexRow].Cells[indexColumn].Value.ToString();
                OracleCommand cmd = new OracleCommand("delete czolgi_w_bitwach where ID_czolgu=" + dataGridView1.Rows[indexRow].Cells[0].Value.ToString() + " and id_nacji=" + dataGridView1.Rows[indexRow].Cells[1].Value.ToString(), oracleConnection);
                cmd.ExecuteNonQuery();
                textBox_console.AppendText("\n");
                textBox_console.AppendText("Zapytanie wykonane pomyślnie.");
                textBox_console.AppendText("\n");
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
        }
        /// <summary>
        /// Metoda służąca do wyświetlania rekordów z bazy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowNationsBattles_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet1.Reset();
                OracleCommand cmd = new OracleCommand("select * from nacje_w_bitwach order by id_nacji", oracleConnection);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter dataAdapter = new OracleDataAdapter();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet1);
                dataGridView1.DataSource = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
        }
        /// <summary>
        /// Metoda służąca do wywoływania formularza dodawania nowego rekordu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNationBattle_Click(object sender, EventArgs e)
        {
            AddArmyToBattle dodajArmieDoBitwy = new AddArmyToBattle(oracleConnection, buttonAddNationBattle);
            dodajArmieDoBitwy.ShowDialog();
        }

        /// <summary>
        /// Metoda usuwająca wybrany rekord z bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteNationBattle_Click(object sender, EventArgs e)
        {
            try
            {
                int indexRow = dataGridView1.CurrentCell.RowIndex;
                int indexColumn = 0;
                String IndeksTabeli = dataGridView1.CurrentCell.RowIndex.ToString();
                String daneZTabeli = dataGridView1.Rows[indexRow].Cells[indexColumn].Value.ToString();
                OracleCommand cmd = new OracleCommand("delete nacje_w_bitwach where id_bitwy=" + dataGridView1.Rows[indexRow].Cells[0].Value.ToString() + " and id_nacji=" + dataGridView1.Rows[indexRow].Cells[1].Value.ToString(), oracleConnection);
                cmd.ExecuteNonQuery();
                textBox_console.AppendText("\n");
                textBox_console.AppendText("Zapytanie wykonane pomyślnie.");
                textBox_console.AppendText("\n");
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }
        }
        /// <summary>
        /// Metoda wywołująca formularz informacyjny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_about_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        /// <summary>
        /// Metoda wywołująca dokumentację
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_documentation_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metoda służąca do rozłączenia się z bazą
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_disconnect_Click(object sender, EventArgs e)
        {
            oracleConnection.Dispose();
            textBox_console.AppendText("\n");
            textBox_console.AppendText("Rozłączono z bazą danych. Użyj przycisku POŁĄCZ aby ponownie nawiązać połączenie.");
            textBox_console.AppendText("\n");
            buttonAddNationBattle.Enabled = false;
            buttonAddTankNation.Enabled = false;
            buttonDeleteNationBattle.Enabled = false;
            buttonDeleteTankNation.Enabled = false;
            buttonShowNationsBattles.Enabled = false;
            buttonShowTanksNations.Enabled = false;
            button_addArmament.Enabled = false;
            button_addArmy.Enabled = false;
            button_addBattle.Enabled = false;
            button_addEngine.Enabled = false;
            button_addTank.Enabled = false;
            button_showArmaments.Enabled = false;
            button_showArmies.Enabled = false;
            button_showBattles.Enabled = false;
            button_showEngines.Enabled = false;
            button_showTanks.Enabled = false;
            button_updateArmament.Enabled = false;
            button_updateArmy.Enabled = false;
            button_updateBattle.Enabled = false;
            button_updateEngine.Enabled = false;
            button_updateTank.Enabled = false;
        }

        private void menu_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void połączZBaząToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strCon = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                             (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=Tanks)));
                             User Id = tanksadmin; Password = tankspass1; ";
            try
            {
                oracleConnection = new OracleConnection(strCon);
                oracleConnection.Open();
                String text = "Nawiązano połączenie z bazą danych.";
                textBox_console.AppendText("\n");
                textBox_console.AppendText(text);
                textBox_console.AppendText("\n");
                buttonAddNationBattle.Enabled = true;
                buttonAddTankNation.Enabled = true;
                buttonDeleteNationBattle.Enabled = true;
                buttonDeleteTankNation.Enabled = true;
                buttonShowNationsBattles.Enabled = true;
                buttonShowTanksNations.Enabled = true;
                button_addArmament.Enabled = true;
                button_addArmy.Enabled = true;
                button_addBattle.Enabled = true;
                button_addEngine.Enabled = true;
                button_addTank.Enabled = true;
                button_showArmaments.Enabled = true;
                button_showArmies.Enabled = true;
                button_showBattles.Enabled = true;
                button_showEngines.Enabled = true;
                button_showTanks.Enabled = true;
                button_updateArmament.Enabled = true;
                button_updateArmy.Enabled = true;
                button_updateBattle.Enabled = true;
                button_updateEngine.Enabled = true;
                button_updateTank.Enabled = true;
            }
            catch (Exception ex)
            {
                textBox_console.AppendText("\n");
                textBox_console.AppendText(ex.Message);
                textBox_console.AppendText("\n");
            }

        }
    }
}

