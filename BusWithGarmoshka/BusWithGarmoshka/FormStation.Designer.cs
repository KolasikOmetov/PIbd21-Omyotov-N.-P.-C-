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
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxStation)).BeginInit();
			this.groupBoxTakeBus.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxStation
			// 
			this.pictureBoxStation.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxStation.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxStation.Name = "pictureBoxStation";
			this.pictureBoxStation.Size = new System.Drawing.Size(713, 421);
			this.pictureBoxStation.TabIndex = 0;
			this.pictureBoxStation.TabStop = false;
			// 
			// buttonAddBus
			// 
			this.buttonAddBus.Location = new System.Drawing.Point(717, 239);
			this.buttonAddBus.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAddBus.Name = "buttonAddBus";
			this.buttonAddBus.Size = new System.Drawing.Size(127, 41);
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
			this.groupBoxTakeBus.Location = new System.Drawing.Point(717, 324);
			this.groupBoxTakeBus.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxTakeBus.Name = "groupBoxTakeBus";
			this.groupBoxTakeBus.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxTakeBus.Size = new System.Drawing.Size(126, 79);
			this.groupBoxTakeBus.TabIndex = 2;
			this.groupBoxTakeBus.TabStop = false;
			this.groupBoxTakeBus.Text = "Забрать автобус";
			// 
			// buttonTake
			// 
			this.buttonTake.Location = new System.Drawing.Point(24, 42);
			this.buttonTake.Margin = new System.Windows.Forms.Padding(2);
			this.buttonTake.Name = "buttonTake";
			this.buttonTake.Size = new System.Drawing.Size(75, 23);
			this.buttonTake.TabIndex = 3;
			this.buttonTake.Text = "Забрать";
			this.buttonTake.UseVisualStyleBackColor = true;
			this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
			// 
			// maskedTextBoxForBus
			// 
			this.maskedTextBoxForBus.Location = new System.Drawing.Point(54, 21);
			this.maskedTextBoxForBus.Margin = new System.Windows.Forms.Padding(2);
			this.maskedTextBoxForBus.Name = "maskedTextBoxForBus";
			this.maskedTextBoxForBus.Size = new System.Drawing.Size(47, 20);
			this.maskedTextBoxForBus.TabIndex = 1;
			// 
			// labelPlace
			// 
			this.labelPlace.AutoSize = true;
			this.labelPlace.Location = new System.Drawing.Point(12, 23);
			this.labelPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPlace.Name = "labelPlace";
			this.labelPlace.Size = new System.Drawing.Size(39, 13);
			this.labelPlace.TabIndex = 0;
			this.labelPlace.Text = "Место";
			// 
			// labelStations
			// 
			this.labelStations.AutoSize = true;
			this.labelStations.Location = new System.Drawing.Point(741, 13);
			this.labelStations.Name = "labelStations";
			this.labelStations.Size = new System.Drawing.Size(78, 13);
			this.labelStations.TabIndex = 3;
			this.labelStations.Text = "Автовокзалы:";
			// 
			// textBoxNameOfStation
			// 
			this.textBoxNameOfStation.Location = new System.Drawing.Point(728, 36);
			this.textBoxNameOfStation.Name = "textBoxNameOfStation";
			this.textBoxNameOfStation.Size = new System.Drawing.Size(114, 20);
			this.textBoxNameOfStation.TabIndex = 4;
			// 
			// listBoxOfStations
			// 
			this.listBoxOfStations.FormattingEnabled = true;
			this.listBoxOfStations.Location = new System.Drawing.Point(730, 102);
			this.listBoxOfStations.Name = "listBoxOfStations";
			this.listBoxOfStations.Size = new System.Drawing.Size(112, 56);
			this.listBoxOfStations.TabIndex = 5;
			this.listBoxOfStations.SelectedIndexChanged += new System.EventHandler(this.listBoxOfStations_SelectedIndexChanged);
			// 
			// buttonAddStation
			// 
			this.buttonAddStation.Location = new System.Drawing.Point(727, 62);
			this.buttonAddStation.Name = "buttonAddStation";
			this.buttonAddStation.Size = new System.Drawing.Size(116, 34);
			this.buttonAddStation.TabIndex = 6;
			this.buttonAddStation.Text = "Добавить автовокзал";
			this.buttonAddStation.UseVisualStyleBackColor = true;
			this.buttonAddStation.Click += new System.EventHandler(this.buttonAddStation_Click);
			// 
			// buttonRemoveStation
			// 
			this.buttonRemoveStation.Location = new System.Drawing.Point(726, 164);
			this.buttonRemoveStation.Name = "buttonRemoveStation";
			this.buttonRemoveStation.Size = new System.Drawing.Size(116, 34);
			this.buttonRemoveStation.TabIndex = 6;
			this.buttonRemoveStation.Text = "Удалить автовокзал";
			this.buttonRemoveStation.UseVisualStyleBackColor = true;
			this.buttonRemoveStation.Click += new System.EventHandler(this.buttonDelStation_Click);
			// 
			// FormStation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(851, 421);
			this.Controls.Add(this.buttonRemoveStation);
			this.Controls.Add(this.buttonAddStation);
			this.Controls.Add(this.listBoxOfStations);
			this.Controls.Add(this.textBoxNameOfStation);
			this.Controls.Add(this.labelStations);
			this.Controls.Add(this.groupBoxTakeBus);
			this.Controls.Add(this.buttonAddBus);
			this.Controls.Add(this.pictureBoxStation);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormStation";
			this.Text = "Автовокзал";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxStation)).EndInit();
			this.groupBoxTakeBus.ResumeLayout(false);
			this.groupBoxTakeBus.PerformLayout();
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
	}
}