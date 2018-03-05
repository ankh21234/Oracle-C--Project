namespace TanksProject
{
    partial class TanksMainWindow
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.połączZBaząToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_close = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_documentation = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_showTanks = new System.Windows.Forms.Button();
            this.button_addTank = new System.Windows.Forms.Button();
            this.button_updateTank = new System.Windows.Forms.Button();
            this.button_showBattles = new System.Windows.Forms.Button();
            this.button_addBattle = new System.Windows.Forms.Button();
            this.button_updateBattle = new System.Windows.Forms.Button();
            this.button_showEngines = new System.Windows.Forms.Button();
            this.button_addEngine = new System.Windows.Forms.Button();
            this.button_updateEngine = new System.Windows.Forms.Button();
            this.button_showArmaments = new System.Windows.Forms.Button();
            this.button_addArmament = new System.Windows.Forms.Button();
            this.button_updateArmament = new System.Windows.Forms.Button();
            this.textBox_console = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_updateArmy = new System.Windows.Forms.Button();
            this.button_addArmy = new System.Windows.Forms.Button();
            this.button_showArmies = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDeleteTankNation = new System.Windows.Forms.Button();
            this.buttonAddTankNation = new System.Windows.Forms.Button();
            this.buttonShowTanksNations = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonDeleteNationBattle = new System.Windows.Forms.Button();
            this.buttonAddNationBattle = new System.Windows.Forms.Button();
            this.buttonShowNationsBattles = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.opcjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1259, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_disconnect,
            this.połączZBaząToolStripMenuItem,
            this.menu_close});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // menu_disconnect
            // 
            this.menu_disconnect.Name = "menu_disconnect";
            this.menu_disconnect.Size = new System.Drawing.Size(148, 22);
            this.menu_disconnect.Text = "Rozłącz z bazą";
            this.menu_disconnect.Click += new System.EventHandler(this.menu_disconnect_Click);
            // 
            // połączZBaząToolStripMenuItem
            // 
            this.połączZBaząToolStripMenuItem.Name = "połączZBaząToolStripMenuItem";
            this.połączZBaząToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.połączZBaząToolStripMenuItem.Text = "Połącz z bazą";
            this.połączZBaząToolStripMenuItem.Click += new System.EventHandler(this.połączZBaząToolStripMenuItem_Click);
            // 
            // menu_close
            // 
            this.menu_close.Name = "menu_close";
            this.menu_close.Size = new System.Drawing.Size(148, 22);
            this.menu_close.Text = "Zamknij";
            this.menu_close.Click += new System.EventHandler(this.menu_close_Click);
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_about,
            this.menu_documentation});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // menu_about
            // 
            this.menu_about.Name = "menu_about";
            this.menu_about.Size = new System.Drawing.Size(201, 22);
            this.menu_about.Text = "O programie";
            this.menu_about.Click += new System.EventHandler(this.menu_about_Click);
            // 
            // menu_documentation
            // 
            this.menu_documentation.Name = "menu_documentation";
            this.menu_documentation.Size = new System.Drawing.Size(201, 22);
            this.menu_documentation.Text = "Podręcznik użytkownika";
            this.menu_documentation.Click += new System.EventHandler(this.menu_documentation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zarządzanie czołgami";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zarządzanie bitwami  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Zarządzanie silnikami";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zarządzanie uzbrojeniem";
            // 
            // button_showTanks
            // 
            this.button_showTanks.Location = new System.Drawing.Point(21, 313);
            this.button_showTanks.Name = "button_showTanks";
            this.button_showTanks.Size = new System.Drawing.Size(121, 23);
            this.button_showTanks.TabIndex = 7;
            this.button_showTanks.Text = "Wyświetl czołgi";
            this.button_showTanks.UseVisualStyleBackColor = true;
            this.button_showTanks.Click += new System.EventHandler(this.button_showTanks_Click);
            // 
            // button_addTank
            // 
            this.button_addTank.Location = new System.Drawing.Point(21, 349);
            this.button_addTank.Name = "button_addTank";
            this.button_addTank.Size = new System.Drawing.Size(121, 23);
            this.button_addTank.TabIndex = 8;
            this.button_addTank.Text = "Dodaj czołg";
            this.button_addTank.UseVisualStyleBackColor = true;
            this.button_addTank.Click += new System.EventHandler(this.button_addTank_Click);
            // 
            // button_updateTank
            // 
            this.button_updateTank.Location = new System.Drawing.Point(21, 389);
            this.button_updateTank.Name = "button_updateTank";
            this.button_updateTank.Size = new System.Drawing.Size(121, 23);
            this.button_updateTank.TabIndex = 9;
            this.button_updateTank.Text = "Aktualizuj czołg";
            this.button_updateTank.UseVisualStyleBackColor = true;
            this.button_updateTank.Click += new System.EventHandler(this.button_updateTank_Click);
            // 
            // button_showBattles
            // 
            this.button_showBattles.Location = new System.Drawing.Point(148, 313);
            this.button_showBattles.Name = "button_showBattles";
            this.button_showBattles.Size = new System.Drawing.Size(121, 23);
            this.button_showBattles.TabIndex = 10;
            this.button_showBattles.Text = "Wyświetl bitwy";
            this.button_showBattles.UseVisualStyleBackColor = true;
            this.button_showBattles.Click += new System.EventHandler(this.button_showBattles_Click);
            // 
            // button_addBattle
            // 
            this.button_addBattle.Location = new System.Drawing.Point(148, 349);
            this.button_addBattle.Name = "button_addBattle";
            this.button_addBattle.Size = new System.Drawing.Size(121, 23);
            this.button_addBattle.TabIndex = 11;
            this.button_addBattle.Text = "Dodaj bitwę";
            this.button_addBattle.UseVisualStyleBackColor = true;
            this.button_addBattle.Click += new System.EventHandler(this.button_addBattle_Click);
            // 
            // button_updateBattle
            // 
            this.button_updateBattle.Location = new System.Drawing.Point(148, 389);
            this.button_updateBattle.Name = "button_updateBattle";
            this.button_updateBattle.Size = new System.Drawing.Size(121, 23);
            this.button_updateBattle.TabIndex = 12;
            this.button_updateBattle.Text = "Aktualizuj bitwę";
            this.button_updateBattle.UseVisualStyleBackColor = true;
            this.button_updateBattle.Click += new System.EventHandler(this.button_updateBattle_Click);
            // 
            // button_showEngines
            // 
            this.button_showEngines.Location = new System.Drawing.Point(275, 313);
            this.button_showEngines.Name = "button_showEngines";
            this.button_showEngines.Size = new System.Drawing.Size(121, 23);
            this.button_showEngines.TabIndex = 13;
            this.button_showEngines.Text = "Wyświetl silniki";
            this.button_showEngines.UseVisualStyleBackColor = true;
            this.button_showEngines.Click += new System.EventHandler(this.button_showEngines_Click);
            // 
            // button_addEngine
            // 
            this.button_addEngine.Location = new System.Drawing.Point(275, 349);
            this.button_addEngine.Name = "button_addEngine";
            this.button_addEngine.Size = new System.Drawing.Size(121, 23);
            this.button_addEngine.TabIndex = 14;
            this.button_addEngine.Text = "Dodaj silnik";
            this.button_addEngine.UseVisualStyleBackColor = true;
            this.button_addEngine.Click += new System.EventHandler(this.button_addEngine_Click);
            // 
            // button_updateEngine
            // 
            this.button_updateEngine.Location = new System.Drawing.Point(275, 389);
            this.button_updateEngine.Name = "button_updateEngine";
            this.button_updateEngine.Size = new System.Drawing.Size(121, 23);
            this.button_updateEngine.TabIndex = 15;
            this.button_updateEngine.Text = "Aktualizuj silnik";
            this.button_updateEngine.UseVisualStyleBackColor = true;
            this.button_updateEngine.Click += new System.EventHandler(this.button_updateEngine_Click);
            // 
            // button_showArmaments
            // 
            this.button_showArmaments.Location = new System.Drawing.Point(402, 313);
            this.button_showArmaments.Name = "button_showArmaments";
            this.button_showArmaments.Size = new System.Drawing.Size(121, 23);
            this.button_showArmaments.TabIndex = 16;
            this.button_showArmaments.Text = "Wyświetl uzbrojenie";
            this.button_showArmaments.UseVisualStyleBackColor = true;
            this.button_showArmaments.Click += new System.EventHandler(this.button_showArmaments_Click);
            // 
            // button_addArmament
            // 
            this.button_addArmament.Location = new System.Drawing.Point(402, 349);
            this.button_addArmament.Name = "button_addArmament";
            this.button_addArmament.Size = new System.Drawing.Size(121, 23);
            this.button_addArmament.TabIndex = 17;
            this.button_addArmament.Text = "Dodaj uzbrojenie";
            this.button_addArmament.UseVisualStyleBackColor = true;
            this.button_addArmament.Click += new System.EventHandler(this.button_addArmament_Click);
            // 
            // button_updateArmament
            // 
            this.button_updateArmament.Location = new System.Drawing.Point(402, 389);
            this.button_updateArmament.Name = "button_updateArmament";
            this.button_updateArmament.Size = new System.Drawing.Size(121, 23);
            this.button_updateArmament.TabIndex = 18;
            this.button_updateArmament.Text = "Aktualizuj uzbrojenie";
            this.button_updateArmament.UseVisualStyleBackColor = true;
            this.button_updateArmament.Click += new System.EventHandler(this.button_updateArmament_Click);
            // 
            // textBox_console
            // 
            this.textBox_console.Location = new System.Drawing.Point(930, 27);
            this.textBox_console.Name = "textBox_console";
            this.textBox_console.Size = new System.Drawing.Size(312, 385);
            this.textBox_console.TabIndex = 23;
            this.textBox_console.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(927, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Konsola systemowa";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "dataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(912, 256);
            this.dataGridView1.TabIndex = 25;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button_updateArmy
            // 
            this.button_updateArmy.Location = new System.Drawing.Point(529, 389);
            this.button_updateArmy.Name = "button_updateArmy";
            this.button_updateArmy.Size = new System.Drawing.Size(121, 23);
            this.button_updateArmy.TabIndex = 29;
            this.button_updateArmy.Text = "Aktualizuj armię";
            this.button_updateArmy.UseVisualStyleBackColor = true;
            this.button_updateArmy.Click += new System.EventHandler(this.button_updateArmy_Click);
            // 
            // button_addArmy
            // 
            this.button_addArmy.Location = new System.Drawing.Point(529, 349);
            this.button_addArmy.Name = "button_addArmy";
            this.button_addArmy.Size = new System.Drawing.Size(121, 23);
            this.button_addArmy.TabIndex = 28;
            this.button_addArmy.Text = "Dodaj armię";
            this.button_addArmy.UseVisualStyleBackColor = true;
            this.button_addArmy.Click += new System.EventHandler(this.button_addArmy_Click);
            // 
            // button_showArmies
            // 
            this.button_showArmies.Location = new System.Drawing.Point(529, 313);
            this.button_showArmies.Name = "button_showArmies";
            this.button_showArmies.Size = new System.Drawing.Size(121, 23);
            this.button_showArmies.TabIndex = 27;
            this.button_showArmies.Text = "Wyświetl armie";
            this.button_showArmies.UseVisualStyleBackColor = true;
            this.button_showArmies.Click += new System.EventHandler(this.button_showArmies_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Zarządzanie armiami";
            // 
            // buttonDeleteTankNation
            // 
            this.buttonDeleteTankNation.Location = new System.Drawing.Point(656, 389);
            this.buttonDeleteTankNation.Name = "buttonDeleteTankNation";
            this.buttonDeleteTankNation.Size = new System.Drawing.Size(131, 23);
            this.buttonDeleteTankNation.TabIndex = 33;
            this.buttonDeleteTankNation.Text = "Usuń przynależność";
            this.buttonDeleteTankNation.UseVisualStyleBackColor = true;
            this.buttonDeleteTankNation.Click += new System.EventHandler(this.buttonDeleteTankNation_Click);
            // 
            // buttonAddTankNation
            // 
            this.buttonAddTankNation.Location = new System.Drawing.Point(656, 349);
            this.buttonAddTankNation.Name = "buttonAddTankNation";
            this.buttonAddTankNation.Size = new System.Drawing.Size(131, 23);
            this.buttonAddTankNation.TabIndex = 32;
            this.buttonAddTankNation.Text = "Dodaj przynależność";
            this.buttonAddTankNation.UseVisualStyleBackColor = true;
            this.buttonAddTankNation.Click += new System.EventHandler(this.buttonAddTankNation_Click);
            // 
            // buttonShowTanksNations
            // 
            this.buttonShowTanksNations.Location = new System.Drawing.Point(656, 313);
            this.buttonShowTanksNations.Name = "buttonShowTanksNations";
            this.buttonShowTanksNations.Size = new System.Drawing.Size(131, 23);
            this.buttonShowTanksNations.TabIndex = 31;
            this.buttonShowTanksNations.Text = "Wyświetl przynależności";
            this.buttonShowTanksNations.UseVisualStyleBackColor = true;
            this.buttonShowTanksNations.Click += new System.EventHandler(this.buttonShowTanksNations_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Przynależność czołgów";
            // 
            // buttonDeleteNationBattle
            // 
            this.buttonDeleteNationBattle.Location = new System.Drawing.Point(793, 389);
            this.buttonDeleteNationBattle.Name = "buttonDeleteNationBattle";
            this.buttonDeleteNationBattle.Size = new System.Drawing.Size(131, 23);
            this.buttonDeleteNationBattle.TabIndex = 37;
            this.buttonDeleteNationBattle.Text = "Usuń potyczkę";
            this.buttonDeleteNationBattle.UseVisualStyleBackColor = true;
            this.buttonDeleteNationBattle.Click += new System.EventHandler(this.buttonDeleteNationBattle_Click);
            // 
            // buttonAddNationBattle
            // 
            this.buttonAddNationBattle.Location = new System.Drawing.Point(793, 349);
            this.buttonAddNationBattle.Name = "buttonAddNationBattle";
            this.buttonAddNationBattle.Size = new System.Drawing.Size(131, 23);
            this.buttonAddNationBattle.TabIndex = 36;
            this.buttonAddNationBattle.Text = "Dodaj potyczkę";
            this.buttonAddNationBattle.UseVisualStyleBackColor = true;
            this.buttonAddNationBattle.Click += new System.EventHandler(this.buttonAddNationBattle_Click);
            // 
            // buttonShowNationsBattles
            // 
            this.buttonShowNationsBattles.Location = new System.Drawing.Point(793, 313);
            this.buttonShowNationsBattles.Name = "buttonShowNationsBattles";
            this.buttonShowNationsBattles.Size = new System.Drawing.Size(131, 23);
            this.buttonShowNationsBattles.TabIndex = 35;
            this.buttonShowNationsBattles.Text = "Wyświetl potyczki";
            this.buttonShowNationsBattles.UseVisualStyleBackColor = true;
            this.buttonShowNationsBattles.Click += new System.EventHandler(this.buttonShowNationsBattles_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(790, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Potyczki armii";
            // 
            // TanksMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 437);
            this.Controls.Add(this.buttonDeleteNationBattle);
            this.Controls.Add(this.buttonAddNationBattle);
            this.Controls.Add(this.buttonShowNationsBattles);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonDeleteTankNation);
            this.Controls.Add(this.buttonAddTankNation);
            this.Controls.Add(this.buttonShowTanksNations);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_updateArmy);
            this.Controls.Add(this.button_addArmy);
            this.Controls.Add(this.button_showArmies);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_console);
            this.Controls.Add(this.button_updateArmament);
            this.Controls.Add(this.button_addArmament);
            this.Controls.Add(this.button_showArmaments);
            this.Controls.Add(this.button_updateEngine);
            this.Controls.Add(this.button_addEngine);
            this.Controls.Add(this.button_showEngines);
            this.Controls.Add(this.button_updateBattle);
            this.Controls.Add(this.button_addBattle);
            this.Controls.Add(this.button_showBattles);
            this.Controls.Add(this.button_updateTank);
            this.Controls.Add(this.button_addTank);
            this.Controls.Add(this.button_showTanks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TanksMainWindow";
            this.Text = "Baza danych czołgów Oracle";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_disconnect;
        private System.Windows.Forms.ToolStripMenuItem menu_close;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_about;
        private System.Windows.Forms.ToolStripMenuItem menu_documentation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_showTanks;
        private System.Windows.Forms.Button button_addTank;
        private System.Windows.Forms.Button button_updateTank;
        private System.Windows.Forms.Button button_showBattles;
        private System.Windows.Forms.Button button_addBattle;
        private System.Windows.Forms.Button button_updateBattle;
        private System.Windows.Forms.Button button_showEngines;
        private System.Windows.Forms.Button button_addEngine;
        private System.Windows.Forms.Button button_updateEngine;
        private System.Windows.Forms.Button button_showArmaments;
        private System.Windows.Forms.Button button_addArmament;
        private System.Windows.Forms.Button button_updateArmament;
        private System.Windows.Forms.RichTextBox textBox_console;
        private System.Windows.Forms.Label label7;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button_updateArmy;
        private System.Windows.Forms.Button button_addArmy;
        private System.Windows.Forms.Button button_showArmies;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDeleteTankNation;
        private System.Windows.Forms.Button buttonAddTankNation;
        private System.Windows.Forms.Button buttonShowTanksNations;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonDeleteNationBattle;
        private System.Windows.Forms.Button buttonAddNationBattle;
        private System.Windows.Forms.Button buttonShowNationsBattles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem połączZBaząToolStripMenuItem;
    }
}