namespace WindowsArmorAirCraft
{
    partial class FormHangar
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
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.buttonSetAirCraft = new System.Windows.Forms.Button();
            this.buttonSetCoolAirCraft = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getAirCraftLabel = new System.Windows.Forms.Label();
            this.place = new System.Windows.Forms.Label();
            this.maskedTextToGetIndex = new System.Windows.Forms.MaskedTextBox();
            this.buttonGetCar = new System.Windows.Forms.Button();
            this.pictureBoxRemoved = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.button_addAirCraft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoved)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 1);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(626, 461);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // buttonSetAirCraft
            // 
            this.buttonSetAirCraft.Location = new System.Drawing.Point(760, 12);
            this.buttonSetAirCraft.Name = "buttonSetAirCraft";
            this.buttonSetAirCraft.Size = new System.Drawing.Size(93, 41);
            this.buttonSetAirCraft.TabIndex = 1;
            this.buttonSetAirCraft.Text = "Припарковать самолет";
            this.buttonSetAirCraft.UseVisualStyleBackColor = true;
            this.buttonSetAirCraft.Click += new System.EventHandler(this.buttonSetAirCraft_Click);
            // 
            // buttonSetCoolAirCraft
            // 
            this.buttonSetCoolAirCraft.Location = new System.Drawing.Point(761, 59);
            this.buttonSetCoolAirCraft.Name = "buttonSetCoolAirCraft";
            this.buttonSetCoolAirCraft.Size = new System.Drawing.Size(93, 47);
            this.buttonSetCoolAirCraft.TabIndex = 2;
            this.buttonSetCoolAirCraft.Text = "Припарковать крутой самолет";
            this.buttonSetCoolAirCraft.UseVisualStyleBackColor = true;
            this.buttonSetCoolAirCraft.Click += new System.EventHandler(this.buttonSetCoolAirCraft_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxRemoved);
            this.groupBox1.Controls.Add(this.buttonGetCar);
            this.groupBox1.Controls.Add(this.maskedTextToGetIndex);
            this.groupBox1.Controls.Add(this.place);
            this.groupBox1.Controls.Add(this.getAirCraftLabel);
            this.groupBox1.Location = new System.Drawing.Point(608, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 332);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // getAirCraftLabel
            // 
            this.getAirCraftLabel.AutoSize = true;
            this.getAirCraftLabel.Location = new System.Drawing.Point(18, 0);
            this.getAirCraftLabel.Name = "getAirCraftLabel";
            this.getAirCraftLabel.Size = new System.Drawing.Size(95, 13);
            this.getAirCraftLabel.TabIndex = 0;
            this.getAirCraftLabel.Text = "Забрать самолет";
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Location = new System.Drawing.Point(81, 22);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(42, 13);
            this.place.TabIndex = 1;
            this.place.Text = "Место:";

            // 
            // maskedTextToGetIndex
            // 
            this.maskedTextToGetIndex.Location = new System.Drawing.Point(129, 19);
            this.maskedTextToGetIndex.Name = "maskedTextToGetIndex";
            this.maskedTextToGetIndex.Size = new System.Drawing.Size(46, 20);
            this.maskedTextToGetIndex.TabIndex = 2;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(629, 12);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(120, 95);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged_1);
            //
            // buttonGetCar
            // 
            this.buttonGetCar.Location = new System.Drawing.Point(181, 19);
            this.buttonGetCar.Name = "buttonGetCar";
            this.buttonGetCar.Size = new System.Drawing.Size(58, 24);
            this.buttonGetCar.TabIndex = 3;
            this.buttonGetCar.Text = "Забрать";
            this.buttonGetCar.UseVisualStyleBackColor = true;
            this.buttonGetCar.Click += new System.EventHandler(this.buttonGetCar_Click);
            // 
            // pictureBoxRemoved
            // 
            this.pictureBoxRemoved.Location = new System.Drawing.Point(-109, 49);
            this.pictureBoxRemoved.Name = "pictureBoxRemoved";
            this.pictureBoxRemoved.Size = new System.Drawing.Size(381, 270);
            this.pictureBoxRemoved.TabIndex = 4;
            this.pictureBoxRemoved.TabStop = false;
            // 
            // button_addAirCraft
            // 
            this.button_addAirCraft.Location = new System.Drawing.Point(772, 42);
            this.button_addAirCraft.Name = "button_addAirCraft";
            this.button_addAirCraft.Size = new System.Drawing.Size(83, 34);
            this.button_addAirCraft.TabIndex = 5;
            this.button_addAirCraft.Text = "Добавить самолет";
            this.button_addAirCraft.UseVisualStyleBackColor = true;
            this.button_addAirCraft.Click += new System.EventHandler(this.button_addAirCraft_Click);
            // 
            // FormHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.button_addAirCraft);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetCoolAirCraft);
            this.Controls.Add(this.buttonSetAirCraft);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "FormHangar";
            this.Text = "FormHangar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoved)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button buttonSetAirCraft;
        private System.Windows.Forms.Button buttonSetCoolAirCraft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button button_addAirCraft;
        private System.Windows.Forms.PictureBox pictureBoxRemoved;
        private System.Windows.Forms.Button buttonGetCar;
        private System.Windows.Forms.MaskedTextBox maskedTextToGetIndex;
        private System.Windows.Forms.Label place;
        private System.Windows.Forms.Label getAirCraftLabel;
    }
}
