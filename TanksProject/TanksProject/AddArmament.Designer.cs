namespace TanksProject
{
    partial class AddArmament
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
            this.textReloadTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.textPenetration = new System.Windows.Forms.TextBox();
            this.textStartOfProduction = new System.Windows.Forms.TextBox();
            this.textCaliber = new System.Windows.Forms.TextBox();
            this.textArmamentID = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textReloadTime
            // 
            this.textReloadTime.Location = new System.Drawing.Point(28, 63);
            this.textReloadTime.Name = "textReloadTime";
            this.textReloadTime.Size = new System.Drawing.Size(155, 20);
            this.textReloadTime.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Czas przeładowania:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Konsola błędów:";
            // 
            // consoleBox
            // 
            this.consoleBox.Location = new System.Drawing.Point(201, 23);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.Size = new System.Drawing.Size(271, 208);
            this.consoleBox.TabIndex = 44;
            this.consoleBox.Text = "";
            // 
            // textPenetration
            // 
            this.textPenetration.Location = new System.Drawing.Point(28, 182);
            this.textPenetration.Name = "textPenetration";
            this.textPenetration.Size = new System.Drawing.Size(155, 20);
            this.textPenetration.TabIndex = 38;
            // 
            // textStartOfProduction
            // 
            this.textStartOfProduction.Location = new System.Drawing.Point(28, 143);
            this.textStartOfProduction.Name = "textStartOfProduction";
            this.textStartOfProduction.Size = new System.Drawing.Size(155, 20);
            this.textStartOfProduction.TabIndex = 37;
            // 
            // textCaliber
            // 
            this.textCaliber.Location = new System.Drawing.Point(28, 104);
            this.textCaliber.Name = "textCaliber";
            this.textCaliber.Size = new System.Drawing.Size(155, 20);
            this.textCaliber.TabIndex = 36;
            // 
            // textArmamentID
            // 
            this.textArmamentID.Location = new System.Drawing.Point(28, 23);
            this.textArmamentID.Name = "textArmamentID";
            this.textArmamentID.Size = new System.Drawing.Size(155, 20);
            this.textArmamentID.TabIndex = 35;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(108, 208);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 34;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(28, 208);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 33;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Penetracja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Początek produkcji:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kaliber:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id uzbrojenia:";
            // 
            // AddArmament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 244);
            this.Controls.Add(this.textReloadTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.textPenetration);
            this.Controls.Add(this.textStartOfProduction);
            this.Controls.Add(this.textCaliber);
            this.Controls.Add(this.textArmamentID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddArmament";
            this.Text = "Dodawanie uzbrojenia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textReloadTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.TextBox textPenetration;
        private System.Windows.Forms.TextBox textStartOfProduction;
        private System.Windows.Forms.TextBox textCaliber;
        private System.Windows.Forms.TextBox textArmamentID;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}