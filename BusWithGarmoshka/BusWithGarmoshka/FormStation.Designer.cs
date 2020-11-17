namespace BusWithGarmoshka
{
    partial class FormStation
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
            this.pictureBoxStation = new System.Windows.Forms.PictureBox();
            this.buttonAddBus = new System.Windows.Forms.Button();
            this.groupBoxTakeBus = new System.Windows.Forms.GroupBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBoxForBus = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelStations = new System.Windows.Forms.Label();
            this.textBoxNameOfStation = new System.Windows.Forms.TextBox();
            this.listBoxOfStations = new System.Windows.Forms.ListBox();
            this.buttonAddStation = new System.Windows.Forms.Button();
            this.buttonRemoveStation = new System.Windows.Forms.Button();
            this.menuBusOfGarmoshka = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogBus = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogBus = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStation)).BeginInit();
            this.groupBoxTakeBus.SuspendLayout();
            this.menuBusOfGarmoshka.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxStation
            // 
            this.pictureBoxStation.Location = new System.Drawing.Point(0, 39);
            this.pictureBoxStation.Name = "pictureBoxStation";
            this.pictureBoxStation.Size = new System.Drawing.Size(1070, 609);
            this.pictureBoxStation.TabIndex = 0;
            this.pictureBoxStation.TabStop = false;
            // 
            // buttonAddBus
            // 
            this.buttonAddBus.Location = new System.Drawing.Point(1076, 399);
            this.buttonAddBus.Name = "buttonAddBus";
            this.buttonAddBus.Size = new System.Drawing.Size(190, 63);
            this.buttonAddBus.TabIndex = 1;
            this.buttonAddBus.Text = "Добавить автобус";
            this.buttonAddBus.UseVisualStyleBackColor = true;
            this.buttonAddBus.Click += new System.EventHandler(this.buttonAddBus_Click);
            // 
            // groupBoxTakeBus
            // 
            this.groupBoxTakeBus.Controls.Add(this.buttonTake);
            this.groupBoxTakeBus.Controls.Add(this.maskedTextBoxForBus);
            this.groupBoxTakeBus.Controls.Add(this.labelPlace);
            this.groupBoxTakeBus.Location = new System.Drawing.Point(1077, 499);
            this.groupBoxTakeBus.Name = "groupBoxTakeBus";
            this.groupBoxTakeBus.Size = new System.Drawing.Size(189, 122);
            this.groupBoxTakeBus.TabIndex = 2;
            this.groupBoxTakeBus.TabStop = false;
            this.groupBoxTakeBus.Text = "Забрать автобус";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(36, 65);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(112, 35);
            this.buttonTake.TabIndex = 3;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // maskedTextBoxForBus
            // 
            this.maskedTextBoxForBus.Location = new System.Drawing.Point(81, 32);
            this.maskedTextBoxForBus.Name = "maskedTextBoxForBus";
            this.maskedTextBoxForBus.Size = new System.Drawing.Size(68, 26);
            this.maskedTextBoxForBus.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(18, 35);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(57, 20);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место";
            // 
            // labelStations
            // 
            this.labelStations.AutoSize = true;
            this.labelStations.Location = new System.Drawing.Point(1112, 51);
            this.labelStations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStations.Name = "labelStations";
            this.labelStations.Size = new System.Drawing.Size(115, 20);
            this.labelStations.TabIndex = 3;
            this.labelStations.Text = "Автовокзалы:";
            // 
            // textBoxNameOfStation
            // 
            this.textBoxNameOfStation.Location = new System.Drawing.Point(1092, 86);
            this.textBoxNameOfStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNameOfStation.Name = "textBoxNameOfStation";
            this.textBoxNameOfStation.Size = new System.Drawing.Size(169, 26);
            this.textBoxNameOfStation.TabIndex = 4;
            // 
            // listBoxOfStations
            // 
            this.listBoxOfStations.FormattingEnabled = true;
            this.listBoxOfStations.ItemHeight = 20;
            this.listBoxOfStations.Location = new System.Drawing.Point(1095, 188);
            this.listBoxOfStations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxOfStations.Name = "listBoxOfStations";
            this.listBoxOfStations.Size = new System.Drawing.Size(166, 84);
            this.listBoxOfStations.TabIndex = 5;
            this.listBoxOfStations.SelectedIndexChanged += new System.EventHandler(this.listBoxOfStations_SelectedIndexChanged);
            // 
            // buttonAddStation
            // 
            this.buttonAddStation.Location = new System.Drawing.Point(1090, 126);
            this.buttonAddStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddStation.Name = "buttonAddStation";
            this.buttonAddStation.Size = new System.Drawing.Size(174, 52);
            this.buttonAddStation.TabIndex = 6;
            this.buttonAddStation.Text = "Добавить автовокзал";
            this.buttonAddStation.UseVisualStyleBackColor = true;
            this.buttonAddStation.Click += new System.EventHandler(this.buttonAddStation_Click);
            // 
            // buttonRemoveStation
            // 
            this.buttonRemoveStation.Location = new System.Drawing.Point(1089, 283);
            this.buttonRemoveStation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemoveStation.Name = "buttonRemoveStation";
            this.buttonRemoveStation.Size = new System.Drawing.Size(174, 52);
            this.buttonRemoveStation.TabIndex = 6;
            this.buttonRemoveStation.Text = "Удалить автовокзал";
            this.buttonRemoveStation.UseVisualStyleBackColor = true;
            this.buttonRemoveStation.Click += new System.EventHandler(this.buttonDelStation_Click);
            // 
            // menuBusOfGarmoshka
            // 
            this.menuBusOfGarmoshka.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBusOfGarmoshka.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuBusOfGarmoshka.Location = new System.Drawing.Point(0, 0);
            this.menuBusOfGarmoshka.Name = "menuBusOfGarmoshka";
            this.menuBusOfGarmoshka.Size = new System.Drawing.Size(1276, 33);
            this.menuBusOfGarmoshka.TabIndex = 7;
            this.menuBusOfGarmoshka.Text = "menuBusOfGarmoshka";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialogBus
            // 
            this.saveFileDialogBus.Filter = "txt file | *.txt";
            // 
            // openFileDialogBus
            // 
            this.openFileDialogBus.FileName = "openFileDialogBus";
            this.openFileDialogBus.Filter = "txt file | *.txt";
            // 
            // FormStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 648);
            this.Controls.Add(this.buttonRemoveStation);
            this.Controls.Add(this.buttonAddStation);
            this.Controls.Add(this.listBoxOfStations);
            this.Controls.Add(this.textBoxNameOfStation);
            this.Controls.Add(this.labelStations);
            this.Controls.Add(this.groupBoxTakeBus);
            this.Controls.Add(this.buttonAddBus);
            this.Controls.Add(this.pictureBoxStation);
            this.Controls.Add(this.menuBusOfGarmoshka);
            this.MainMenuStrip = this.menuBusOfGarmoshka;
            this.Name = "FormStation";
            this.Text = "Автовокзал";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStation)).EndInit();
            this.groupBoxTakeBus.ResumeLayout(false);
            this.groupBoxTakeBus.PerformLayout();
            this.menuBusOfGarmoshka.ResumeLayout(false);
            this.menuBusOfGarmoshka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStation;
        private System.Windows.Forms.Button buttonAddBus;
        private System.Windows.Forms.GroupBox groupBoxTakeBus;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxForBus;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Label labelStations;
		private System.Windows.Forms.TextBox textBoxNameOfStation;
		private System.Windows.Forms.ListBox listBoxOfStations;
		private System.Windows.Forms.Button buttonAddStation;
		private System.Windows.Forms.Button buttonRemoveStation;
        private System.Windows.Forms.MenuStrip menuBusOfGarmoshka;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBus;
        private System.Windows.Forms.OpenFileDialog openFileDialogBus;
    }
}