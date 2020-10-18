namespace BusWithGarmoshka
{
	partial class FormBusWithGarmoshka
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBusWithGarmoshka));
            this.pictureBoxBuses = new System.Windows.Forms.PictureBox();
            this.buttonCreateBus = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonCreateBusWithGarmoshka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuses)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBuses
            // 
            this.pictureBoxBuses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBuses.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBuses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxBuses.Name = "pictureBoxBuses";
            this.pictureBoxBuses.Size = new System.Drawing.Size(957, 544);
            this.pictureBoxBuses.TabIndex = 0;
            this.pictureBoxBuses.TabStop = false;
            this.pictureBoxBuses.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateBus
            // 
            this.buttonCreateBus.Location = new System.Drawing.Point(38, 20);
            this.buttonCreateBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateBus.Name = "buttonCreateBus";
            this.buttonCreateBus.Size = new System.Drawing.Size(112, 35);
            this.buttonCreateBus.TabIndex = 1;
            this.buttonCreateBus.Text = "Create Bus";
            this.buttonCreateBus.UseVisualStyleBackColor = true;
            this.buttonCreateBus.Click += new System.EventHandler(this.buttonCreateBus_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(698, 480);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(45, 46);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(752, 480);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(45, 46);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(806, 480);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(45, 46);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(752, 424);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(45, 46);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateBusWithGarmoshka
            // 
            this.buttonCreateBusWithGarmoshka.Location = new System.Drawing.Point(200, 18);
            this.buttonCreateBusWithGarmoshka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateBusWithGarmoshka.Name = "buttonCreateBusWithGarmoshka";
            this.buttonCreateBusWithGarmoshka.Size = new System.Drawing.Size(262, 37);
            this.buttonCreateBusWithGarmoshka.TabIndex = 3;
            this.buttonCreateBusWithGarmoshka.Text = "Create Bus With Garmoshka";
            this.buttonCreateBusWithGarmoshka.UseVisualStyleBackColor = true;
            this.buttonCreateBusWithGarmoshka.Click += new System.EventHandler(this.buttonCreateBusWithGarmoshka_Click);
            // 
            // FormBusWithGarmoshka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 544);
            this.Controls.Add(this.buttonCreateBusWithGarmoshka);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonCreateBus);
            this.Controls.Add(this.pictureBoxBuses);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBusWithGarmoshka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuses)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxBuses;
		private System.Windows.Forms.Button buttonCreateBus;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonCreateBusWithGarmoshka;
	}
}

