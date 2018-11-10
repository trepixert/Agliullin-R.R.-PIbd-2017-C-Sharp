namespace WindowsArmorAirCraft
{
    partial class FormAirCraft
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
            this.pictureAirCraft = new System.Windows.Forms.PictureBox();
            this.Down = new System.Windows.Forms.Button();
            this.ToLeft = new System.Windows.Forms.Button();
            this.ToRight = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAirCraft)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureAirCraft
            // 
            this.pictureAirCraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureAirCraft.Location = new System.Drawing.Point(0, 0);
            this.pictureAirCraft.Name = "pictureAirCraft";
            this.pictureAirCraft.Size = new System.Drawing.Size(884, 461);
            this.pictureAirCraft.TabIndex = 5;
            this.pictureAirCraft.TabStop = false;
            this.pictureAirCraft.Click += new System.EventHandler(this.pictureAirCraft_Click);
            // 
            // Down
            // 
            this.Down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Down.Location = new System.Drawing.Point(730, 415);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(75, 23);
            this.Down.TabIndex = 9;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.pictureAirCraft_Click);
            // 
            // ToLeft
            // 
            this.ToLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ToLeft.Location = new System.Drawing.Point(654, 390);
            this.ToLeft.Name = "ToLeft";
            this.ToLeft.Size = new System.Drawing.Size(75, 23);
            this.ToLeft.TabIndex = 8;
            this.ToLeft.Text = "Left";
            this.ToLeft.UseVisualStyleBackColor = true;
            this.ToLeft.Click += new System.EventHandler(this.pictureAirCraft_Click);
            // 
            // ToRight
            // 
            this.ToRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ToRight.Location = new System.Drawing.Point(804, 390);
            this.ToRight.Name = "ToRight";
            this.ToRight.Size = new System.Drawing.Size(75, 23);
            this.ToRight.TabIndex = 7;
            this.ToRight.Text = "Right";
            this.ToRight.UseVisualStyleBackColor = true;
            this.ToRight.Click += new System.EventHandler(this.pictureAirCraft_Click);
            // 
            // Up
            // 
            this.Up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Up.Location = new System.Drawing.Point(730, 368);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(75, 23);
            this.Up.TabIndex = 6;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.pictureAirCraft_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(0, 0);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "CreateBase";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "createCool";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAirCraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.ToLeft);
            this.Controls.Add(this.ToRight);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.pictureAirCraft);
            this.Name = "FormAirCraft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAirCraft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAirCraft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureAirCraft;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button ToLeft;
        private System.Windows.Forms.Button ToRight;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button button1;
    }
}

