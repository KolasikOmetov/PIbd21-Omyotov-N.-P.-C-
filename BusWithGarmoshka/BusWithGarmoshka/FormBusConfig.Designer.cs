namespace BusWithGarmoshka
{
	partial class FormBusConfig
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
			this.groupBoxTypeCusov = new System.Windows.Forms.GroupBox();
			this.labelBusWithGarmoshka = new System.Windows.Forms.Label();
			this.labelNormalBus = new System.Windows.Forms.Label();
			this.groupBoxOptions = new System.Windows.Forms.GroupBox();
			this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
			this.checkBoxGarmoshka = new System.Windows.Forms.CheckBox();
			this.checkBoxBackDoors = new System.Windows.Forms.CheckBox();
			this.labelWeight = new System.Windows.Forms.Label();
			this.labelMaxSpeed = new System.Windows.Forms.Label();
			this.pictureBoxFutureBus = new System.Windows.Forms.PictureBox();
			this.panelDrop = new System.Windows.Forms.Panel();
			this.groupBoxColors = new System.Windows.Forms.GroupBox();
			this.panelVioletColor = new System.Windows.Forms.Panel();
			this.panelGoldColor = new System.Windows.Forms.Panel();
			this.panelOrangeRedColor = new System.Windows.Forms.Panel();
			this.panelSpringGreenColor = new System.Windows.Forms.Panel();
			this.panelSeaGreenColor = new System.Windows.Forms.Panel();
			this.panelSlateBlueColor = new System.Windows.Forms.Panel();
			this.panelRoyalBlueColor = new System.Windows.Forms.Panel();
			this.panelRedColor = new System.Windows.Forms.Panel();
			this.labelDopColor = new System.Windows.Forms.Label();
			this.labelMainColor = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBoxTypeCusov.SuspendLayout();
			this.groupBoxOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFutureBus)).BeginInit();
			this.panelDrop.SuspendLayout();
			this.groupBoxColors.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxTypeCusov
			// 
			this.groupBoxTypeCusov.Controls.Add(this.labelBusWithGarmoshka);
			this.groupBoxTypeCusov.Controls.Add(this.labelNormalBus);
			this.groupBoxTypeCusov.Location = new System.Drawing.Point(12, 12);
			this.groupBoxTypeCusov.Name = "groupBoxTypeCusov";
			this.groupBoxTypeCusov.Size = new System.Drawing.Size(198, 114);
			this.groupBoxTypeCusov.TabIndex = 0;
			this.groupBoxTypeCusov.TabStop = false;
			this.groupBoxTypeCusov.Text = "Тип кузова";
			// 
			// labelBusWithGarmoshka
			// 
			this.labelBusWithGarmoshka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelBusWithGarmoshka.Location = new System.Drawing.Point(9, 60);
			this.labelBusWithGarmoshka.Name = "labelBusWithGarmoshka";
			this.labelBusWithGarmoshka.Size = new System.Drawing.Size(174, 27);
			this.labelBusWithGarmoshka.TabIndex = 0;
			this.labelBusWithGarmoshka.Text = "Автобус с гармошкой";
			this.labelBusWithGarmoshka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelBusWithGarmoshka.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBusWithGarmoshka_MouseDown);
			// 
			// labelNormalBus
			// 
			this.labelNormalBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelNormalBus.Location = new System.Drawing.Point(9, 20);
			this.labelNormalBus.Name = "labelNormalBus";
			this.labelNormalBus.Size = new System.Drawing.Size(174, 27);
			this.labelNormalBus.TabIndex = 0;
			this.labelNormalBus.Text = "Обычный автобус";
			this.labelNormalBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelNormalBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelNormalBus_MouseDown);
			// 
			// groupBoxOptions
			// 
			this.groupBoxOptions.Controls.Add(this.numericUpDownWeight);
			this.groupBoxOptions.Controls.Add(this.numericUpDownMaxSpeed);
			this.groupBoxOptions.Controls.Add(this.checkBoxGarmoshka);
			this.groupBoxOptions.Controls.Add(this.checkBoxBackDoors);
			this.groupBoxOptions.Controls.Add(this.labelWeight);
			this.groupBoxOptions.Controls.Add(this.labelMaxSpeed);
			this.groupBoxOptions.Location = new System.Drawing.Point(12, 182);
			this.groupBoxOptions.Name = "groupBoxOptions";
			this.groupBoxOptions.Size = new System.Drawing.Size(319, 214);
			this.groupBoxOptions.TabIndex = 1;
			this.groupBoxOptions.TabStop = false;
			this.groupBoxOptions.Text = "Параметры";
			// 
			// numericUpDownWeight
			// 
			this.numericUpDownWeight.Location = new System.Drawing.Point(21, 149);
			this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownWeight.Name = "numericUpDownWeight";
			this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownWeight.TabIndex = 2;
			this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numericUpDownMaxSpeed
			// 
			this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(21, 52);
			this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
			this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownMaxSpeed.TabIndex = 2;
			this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// checkBoxGarmoshka
			// 
			this.checkBoxGarmoshka.AutoSize = true;
			this.checkBoxGarmoshka.Location = new System.Drawing.Point(161, 43);
			this.checkBoxGarmoshka.Name = "checkBoxGarmoshka";
			this.checkBoxGarmoshka.Size = new System.Drawing.Size(78, 17);
			this.checkBoxGarmoshka.TabIndex = 1;
			this.checkBoxGarmoshka.Text = "Гармошка";
			this.checkBoxGarmoshka.UseVisualStyleBackColor = true;
			this.checkBoxGarmoshka.CheckedChanged += new System.EventHandler(this.checkBoxGarmoshka_CheckedChanged);
			// 
			// checkBoxBackDoors
			// 
			this.checkBoxBackDoors.AutoSize = true;
			this.checkBoxBackDoors.Location = new System.Drawing.Point(161, 20);
			this.checkBoxBackDoors.Name = "checkBoxBackDoors";
			this.checkBoxBackDoors.Size = new System.Drawing.Size(96, 17);
			this.checkBoxBackDoors.TabIndex = 1;
			this.checkBoxBackDoors.Text = "Задние двери";
			this.checkBoxBackDoors.UseVisualStyleBackColor = true;
			this.checkBoxBackDoors.CheckedChanged += new System.EventHandler(this.checkBoxBackDoors_CheckedChanged);
			// 
			// labelWeight
			// 
			this.labelWeight.AutoSize = true;
			this.labelWeight.Location = new System.Drawing.Point(6, 105);
			this.labelWeight.Name = "labelWeight";
			this.labelWeight.Size = new System.Drawing.Size(75, 13);
			this.labelWeight.TabIndex = 0;
			this.labelWeight.Text = "Вес автобуса";
			// 
			// labelMaxSpeed
			// 
			this.labelMaxSpeed.AutoSize = true;
			this.labelMaxSpeed.Location = new System.Drawing.Point(7, 20);
			this.labelMaxSpeed.Name = "labelMaxSpeed";
			this.labelMaxSpeed.Size = new System.Drawing.Size(134, 13);
			this.labelMaxSpeed.TabIndex = 0;
			this.labelMaxSpeed.Text = "Максимальная скорость";
			// 
			// pictureBoxFutureBus
			// 
			this.pictureBoxFutureBus.Location = new System.Drawing.Point(5, 3);
			this.pictureBoxFutureBus.Name = "pictureBoxFutureBus";
			this.pictureBoxFutureBus.Size = new System.Drawing.Size(336, 112);
			this.pictureBoxFutureBus.TabIndex = 2;
			this.pictureBoxFutureBus.TabStop = false;
			// 
			// panelDrop
			// 
			this.panelDrop.AllowDrop = true;
			this.panelDrop.Controls.Add(this.pictureBoxFutureBus);
			this.panelDrop.Location = new System.Drawing.Point(231, 13);
			this.panelDrop.Name = "panelDrop";
			this.panelDrop.Size = new System.Drawing.Size(344, 143);
			this.panelDrop.TabIndex = 3;
			this.panelDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDrop_DragDrop);
			this.panelDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrop_DragEnter);
			// 
			// groupBoxColors
			// 
			this.groupBoxColors.Controls.Add(this.panelVioletColor);
			this.groupBoxColors.Controls.Add(this.panelGoldColor);
			this.groupBoxColors.Controls.Add(this.panelOrangeRedColor);
			this.groupBoxColors.Controls.Add(this.panelSpringGreenColor);
			this.groupBoxColors.Controls.Add(this.panelSeaGreenColor);
			this.groupBoxColors.Controls.Add(this.panelSlateBlueColor);
			this.groupBoxColors.Controls.Add(this.panelRoyalBlueColor);
			this.groupBoxColors.Controls.Add(this.panelRedColor);
			this.groupBoxColors.Controls.Add(this.labelDopColor);
			this.groupBoxColors.Controls.Add(this.labelMainColor);
			this.groupBoxColors.Location = new System.Drawing.Point(375, 182);
			this.groupBoxColors.Name = "groupBoxColors";
			this.groupBoxColors.Size = new System.Drawing.Size(367, 214);
			this.groupBoxColors.TabIndex = 4;
			this.groupBoxColors.TabStop = false;
			this.groupBoxColors.Text = "Цвета";
			// 
			// panelVioletColor
			// 
			this.panelVioletColor.BackColor = System.Drawing.Color.Violet;
			this.panelVioletColor.Location = new System.Drawing.Point(307, 130);
			this.panelVioletColor.Name = "panelVioletColor";
			this.panelVioletColor.Size = new System.Drawing.Size(40, 39);
			this.panelVioletColor.TabIndex = 1;
			// 
			// panelGoldColor
			// 
			this.panelGoldColor.BackColor = System.Drawing.Color.Gold;
			this.panelGoldColor.Location = new System.Drawing.Point(227, 130);
			this.panelGoldColor.Name = "panelGoldColor";
			this.panelGoldColor.Size = new System.Drawing.Size(40, 39);
			this.panelGoldColor.TabIndex = 1;
			// 
			// panelOrangeRedColor
			// 
			this.panelOrangeRedColor.BackColor = System.Drawing.Color.OrangeRed;
			this.panelOrangeRedColor.Location = new System.Drawing.Point(267, 69);
			this.panelOrangeRedColor.Name = "panelOrangeRedColor";
			this.panelOrangeRedColor.Size = new System.Drawing.Size(40, 39);
			this.panelOrangeRedColor.TabIndex = 1;
			// 
			// panelSpringGreenColor
			// 
			this.panelSpringGreenColor.BackColor = System.Drawing.Color.SpringGreen;
			this.panelSpringGreenColor.Location = new System.Drawing.Point(142, 130);
			this.panelSpringGreenColor.Name = "panelSpringGreenColor";
			this.panelSpringGreenColor.Size = new System.Drawing.Size(40, 39);
			this.panelSpringGreenColor.TabIndex = 1;
			// 
			// panelSeaGreenColor
			// 
			this.panelSeaGreenColor.BackColor = System.Drawing.Color.SeaGreen;
			this.panelSeaGreenColor.Location = new System.Drawing.Point(187, 69);
			this.panelSeaGreenColor.Name = "panelSeaGreenColor";
			this.panelSeaGreenColor.Size = new System.Drawing.Size(40, 39);
			this.panelSeaGreenColor.TabIndex = 1;
			// 
			// panelSlateBlueColor
			// 
			this.panelSlateBlueColor.BackColor = System.Drawing.Color.SlateBlue;
			this.panelSlateBlueColor.Location = new System.Drawing.Point(62, 130);
			this.panelSlateBlueColor.Name = "panelSlateBlueColor";
			this.panelSlateBlueColor.Size = new System.Drawing.Size(40, 39);
			this.panelSlateBlueColor.TabIndex = 1;
			// 
			// panelRoyalBlueColor
			// 
			this.panelRoyalBlueColor.BackColor = System.Drawing.Color.RoyalBlue;
			this.panelRoyalBlueColor.Location = new System.Drawing.Point(102, 69);
			this.panelRoyalBlueColor.Name = "panelRoyalBlueColor";
			this.panelRoyalBlueColor.Size = new System.Drawing.Size(40, 39);
			this.panelRoyalBlueColor.TabIndex = 1;
			// 
			// panelRedColor
			// 
			this.panelRedColor.BackColor = System.Drawing.Color.Red;
			this.panelRedColor.Location = new System.Drawing.Point(22, 69);
			this.panelRedColor.Name = "panelRedColor";
			this.panelRedColor.Size = new System.Drawing.Size(40, 39);
			this.panelRedColor.TabIndex = 1;
			// 
			// labelDopColor
			// 
			this.labelDopColor.AllowDrop = true;
			this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopColor.Location = new System.Drawing.Point(187, 20);
			this.labelDopColor.Name = "labelDopColor";
			this.labelDopColor.Size = new System.Drawing.Size(174, 27);
			this.labelDopColor.TabIndex = 0;
			this.labelDopColor.Text = "Дополнительный цвет";
			this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
			// 
			// labelMainColor
			// 
			this.labelMainColor.AllowDrop = true;
			this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelMainColor.Location = new System.Drawing.Point(6, 20);
			this.labelMainColor.Name = "labelMainColor";
			this.labelMainColor.Size = new System.Drawing.Size(174, 27);
			this.labelMainColor.TabIndex = 0;
			this.labelMainColor.Text = "Основной цвет";
			this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
			this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
			this.labelMainColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelNormalBus_MouseDown);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(642, 36);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(642, 103);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отменить";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FormBusConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 450);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.groupBoxColors);
			this.Controls.Add(this.panelDrop);
			this.Controls.Add(this.groupBoxOptions);
			this.Controls.Add(this.groupBoxTypeCusov);
			this.Name = "FormBusConfig";
			this.Text = "Выбрать автобус";
			this.groupBoxTypeCusov.ResumeLayout(false);
			this.groupBoxOptions.ResumeLayout(false);
			this.groupBoxOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFutureBus)).EndInit();
			this.panelDrop.ResumeLayout(false);
			this.groupBoxColors.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxTypeCusov;
		private System.Windows.Forms.GroupBox groupBoxOptions;
		private System.Windows.Forms.Label labelMaxSpeed;
		private System.Windows.Forms.Label labelBusWithGarmoshka;
		private System.Windows.Forms.Label labelNormalBus;
		private System.Windows.Forms.NumericUpDown numericUpDownWeight;
		private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
		private System.Windows.Forms.CheckBox checkBoxGarmoshka;
		private System.Windows.Forms.CheckBox checkBoxBackDoors;
		private System.Windows.Forms.Label labelWeight;
		private System.Windows.Forms.PictureBox pictureBoxFutureBus;
		private System.Windows.Forms.Panel panelDrop;
		private System.Windows.Forms.GroupBox groupBoxColors;
		private System.Windows.Forms.Label labelDopColor;
		private System.Windows.Forms.Label labelMainColor;
		private System.Windows.Forms.Panel panelVioletColor;
		private System.Windows.Forms.Panel panelGoldColor;
		private System.Windows.Forms.Panel panelOrangeRedColor;
		private System.Windows.Forms.Panel panelSpringGreenColor;
		private System.Windows.Forms.Panel panelSeaGreenColor;
		private System.Windows.Forms.Panel panelSlateBlueColor;
		private System.Windows.Forms.Panel panelRoyalBlueColor;
		private System.Windows.Forms.Panel panelRedColor;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonCancel;
	}
}