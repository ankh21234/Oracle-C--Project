namespace TanksProject
{
    partial class AddArmy
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
            this.textName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.textVehicleAmount = new System.Windows.Forms.TextBox();
            this.textArmyID = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textInfantryAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCommander = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textLoss = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(15, 71);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(155, 20);
            this.textName.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Nazwa armii:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Konsola błędów:";
            // 
            // consoleBox
            // 
            this.consoleBox.Location = new System.Drawing.Point(188, 31);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.Size = new System.Drawing.Size(224, 258);
            this.consoleBox.TabIndex = 54;
            this.consoleBox.Text = "";
            // 
            // textVehicleAmount
            // 
            this.textVehicleAmount.Location = new System.Drawing.Point(15, 112);
            this.textVehicleAmount.Name = "textVehicleAmount";
            this.textVehicleAmount.Size = new System.Drawing.Size(155, 20);
            this.textVehicleAmount.TabIndex = 53;
            // 
            // textArmyID
            // 
            this.textArmyID.Location = new System.Drawing.Point(15, 31);
            this.textArmyID.Name = "textArmyID";
            this.textArmyID.Size = new System.Drawing.Size(155, 20);
            this.textArmyID.TabIndex = 52;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(95, 266);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 51;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 266);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 50;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Liczebność pojazdów:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Id armii:";
            // 
            // textInfantryAmount
            // 
            this.textInfantryAmount.Location = new System.Drawing.Point(15, 156);
            this.textInfantryAmount.Name = "textInfantryAmount";
            this.textInfantryAmount.Size = new System.Drawing.Size(155, 20);
            this.textInfantryAmount.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Liczebność piechoty:";
            // 
            // textCommander
            // 
            this.textCommander.Location = new System.Drawing.Point(15, 199);
            this.textCommander.Name = "textCommander";
            this.textCommander.Size = new System.Drawing.Size(155, 20);
            this.textCommander.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Dowódca:";
            // 
            // textLoss
            // 
            this.textLoss.Location = new System.Drawing.Point(15, 240);
            this.textLoss.Name = "textLoss";
            this.textLoss.Size = new System.Drawing.Size(155, 20);
            this.textLoss.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Straty:";
            // 
            // AddArmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 301);
            this.Controls.Add(this.textLoss);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCommander);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textInfantryAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.textVehicleAmount);
            this.Controls.Add(this.textArmyID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddArmy";
            this.Text = "Dodawanie armii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.TextBox textVehicleAmount;
        private System.Windows.Forms.TextBox textArmyID;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textInfantryAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCommander;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLoss;
        private System.Windows.Forms.Label label5;
    }
}