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
            this.buttonParkBus = new System.Windows.Forms.Button();
            this.buttonParkBusWithGarmoshka = new System.Windows.Forms.Button();
            this.groupBoxTakeBus = new System.Windows.Forms.GroupBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBoxForBus = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStation)).BeginInit();
            this.groupBoxTakeBus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxStation
            // 
            this.pictureBoxStation.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxStation.Name = "pictureBoxStation";
            this.pictureBoxStation.Size = new System.Drawing.Size(1069, 647);
            this.pictureBoxStation.TabIndex = 0;
            this.pictureBoxStation.TabStop = false;
            // 
            // buttonParkBus
            // 
            this.buttonParkBus.Location = new System.Drawing.Point(1075, 27);
            this.buttonParkBus.Name = "buttonParkBus";
            this.buttonParkBus.Size = new System.Drawing.Size(190, 63);
            this.buttonParkBus.TabIndex = 1;
            this.buttonParkBus.Text = "Припарковать автобус";
            this.buttonParkBus.UseVisualStyleBackColor = true;
            this.buttonParkBus.Click += new System.EventHandler(this.buttonParkBus_Click);
            // 
            // buttonParkBusWithGarmoshka
            // 
            this.buttonParkBusWithGarmoshka.Location = new System.Drawing.Point(1075, 106);
            this.buttonParkBusWithGarmoshka.Name = "buttonParkBusWithGarmoshka";
            this.buttonParkBusWithGarmoshka.Size = new System.Drawing.Size(190, 63);
            this.buttonParkBusWithGarmoshka.TabIndex = 1;
            this.buttonParkBusWithGarmoshka.Text = "Припарковать автобус с гармошкой";
            this.buttonParkBusWithGarmoshka.UseVisualStyleBackColor = true;
            this.buttonParkBusWithGarmoshka.Click += new System.EventHandler(this.buttonParkBusWithGarmoshka_Click);
            // 
            // groupBoxTakeBus
            // 
            this.groupBoxTakeBus.Controls.Add(this.buttonTake);
            this.groupBoxTakeBus.Controls.Add(this.maskedTextBoxForBus);
            this.groupBoxTakeBus.Controls.Add(this.labelPlace);
            this.groupBoxTakeBus.Location = new System.Drawing.Point(1075, 186);
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
            this.buttonTake.Size = new System.Drawing.Size(113, 36);
            this.buttonTake.TabIndex = 3;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // maskedTextBoxForBus
            // 
            this.maskedTextBoxForBus.Location = new System.Drawing.Point(81, 33);
            this.maskedTextBoxForBus.Name = "maskedTextBoxForBus";
            this.maskedTextBoxForBus.Size = new System.Drawing.Size(68, 26);
            this.maskedTextBoxForBus.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(18, 36);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(57, 20);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место";
            // 
            // FormStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 647);
            this.Controls.Add(this.groupBoxTakeBus);
            this.Controls.Add(this.buttonParkBusWithGarmoshka);
            this.Controls.Add(this.buttonParkBus);
            this.Controls.Add(this.pictureBoxStation);
            this.Name = "FormStation";
            this.Text = "Автовокзал";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStation)).EndInit();
            this.groupBoxTakeBus.ResumeLayout(false);
            this.groupBoxTakeBus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStation;
        private System.Windows.Forms.Button buttonParkBus;
        private System.Windows.Forms.Button buttonParkBusWithGarmoshka;
        private System.Windows.Forms.GroupBox groupBoxTakeBus;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxForBus;
        private System.Windows.Forms.Button buttonTake;
    }
}