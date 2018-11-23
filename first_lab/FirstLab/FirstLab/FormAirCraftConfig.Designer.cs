namespace WindowsArmorAirCraft
{
    partial class FormAirCraftConfig
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
            this.pictureBoxAirCraft = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAirCraft = new System.Windows.Forms.Label();
            this.labelBaseAirCraft = new System.Windows.Forms.Label();
            this.panelAirCraft = new System.Windows.Forms.Panel();
            this.DopColor = new System.Windows.Forms.Label();
            this.MainColor = new System.Windows.Forms.Label();
            this.panel_Black = new System.Windows.Forms.Panel();
            this.panel_White = new System.Windows.Forms.Panel();
            this.panel_Green = new System.Windows.Forms.Panel();
            this.panel_Blue = new System.Windows.Forms.Panel();
            this.panel_Red = new System.Windows.Forms.Panel();
            this.panel_Yellow = new System.Windows.Forms.Panel();
            this.panel_Gray = new System.Windows.Forms.Panel();
            this.panel_Orange = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirCraft)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelAirCraft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAirCraft
            // 
            this.pictureBoxAirCraft.Location = new System.Drawing.Point(22, 26);
            this.pictureBoxAirCraft.Name = "pictureBoxAirCraft";
            this.pictureBoxAirCraft.Size = new System.Drawing.Size(381, 237);
            this.pictureBoxAirCraft.TabIndex = 0;
            this.pictureBoxAirCraft.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAirCraft);
            this.groupBox1.Controls.Add(this.labelBaseAirCraft);
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип самолета";
            // 
            // labelAirCraft
            // 
            this.labelAirCraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAirCraft.Location = new System.Drawing.Point(6, 73);
            this.labelAirCraft.Name = "labelAirCraft";
            this.labelAirCraft.Size = new System.Drawing.Size(155, 35);
            this.labelAirCraft.TabIndex = 1;
            this.labelAirCraft.Text = "Модернизированный самолет";
            this.labelAirCraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAirCraft_MouseDown);
            // 
            // labelBaseAirCraft
            // 
            this.labelBaseAirCraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseAirCraft.Location = new System.Drawing.Point(6, 26);
            this.labelBaseAirCraft.Name = "labelBaseAirCraft";
            this.labelBaseAirCraft.Size = new System.Drawing.Size(155, 35);
            this.labelBaseAirCraft.TabIndex = 0;
            this.labelBaseAirCraft.Text = "Обычный самолет";
            this.labelBaseAirCraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBaseAirCraft_MouseDown);
            // 
            // panelAirCraft
            // 
            this.panelAirCraft.AllowDrop = true;
            this.panelAirCraft.Controls.Add(this.DopColor);
            this.panelAirCraft.Controls.Add(this.MainColor);
            this.panelAirCraft.Controls.Add(this.pictureBoxAirCraft);
            this.panelAirCraft.Location = new System.Drawing.Point(198, 41);
            this.panelAirCraft.Name = "panelAirCraft";
            this.panelAirCraft.Size = new System.Drawing.Size(406, 358);
            this.panelAirCraft.TabIndex = 2;
            this.panelAirCraft.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAirCraft_DragDrop);
            this.panelAirCraft.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAirCraft_DragEnter);
            // 
            // DopColor
            // 
            this.DopColor.AllowDrop = true;
            this.DopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DopColor.Location = new System.Drawing.Point(176, 313);
            this.DopColor.Name = "DopColor";
            this.DopColor.Size = new System.Drawing.Size(103, 34);
            this.DopColor.TabIndex = 2;
            this.DopColor.Text = "Дополнительный цвет";
            this.DopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.DopColor_DragDrop);
            this.DopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainColor_DragEnter);
            // 
            // MainColor
            // 
            this.MainColor.AllowDrop = true;
            this.MainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainColor.Location = new System.Drawing.Point(176, 266);
            this.MainColor.Name = "MainColor";
            this.MainColor.Size = new System.Drawing.Size(103, 34);
            this.MainColor.TabIndex = 1;
            this.MainColor.Text = "Основной цвет";
            this.MainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainColor_DragDrop);
            this.MainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainColor_DragEnter);
            // 
            // panel_Black
            // 
            this.panel_Black.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel_Black.Location = new System.Drawing.Point(621, 41);
            this.panel_Black.Name = "panel_Black";
            this.panel_Black.Size = new System.Drawing.Size(46, 51);
            this.panel_Black.TabIndex = 3;
            this.panel_Black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel_White
            // 
            this.panel_White.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_White.Location = new System.Drawing.Point(702, 41);
            this.panel_White.Name = "panel_White";
            this.panel_White.Size = new System.Drawing.Size(46, 51);
            this.panel_White.TabIndex = 4;
            this.panel_White.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel_Green
            // 
            this.panel_Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_Green.Location = new System.Drawing.Point(621, 114);
            this.panel_Green.Name = "panel_Green";
            this.panel_Green.Size = new System.Drawing.Size(46, 51);
            this.panel_Green.TabIndex = 5;
            this.panel_Green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel_Blue
            // 
            this.panel_Blue.BackColor = System.Drawing.Color.Blue;
            this.panel_Blue.Location = new System.Drawing.Point(702, 114);
            this.panel_Blue.Name = "panel_Blue";
            this.panel_Blue.Size = new System.Drawing.Size(46, 51);
            this.panel_Blue.TabIndex = 6;
            this.panel_Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel_Red
            // 
            this.panel_Red.BackColor = System.Drawing.Color.Red;
            this.panel_Red.Location = new System.Drawing.Point(621, 188);
            this.panel_Red.Name = "panel_Red";
            this.panel_Red.Size = new System.Drawing.Size(46, 51);
            this.panel_Red.TabIndex = 7;
            this.panel_Red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel_Yellow
            // 
            this.panel_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.panel_Yellow.Location = new System.Drawing.Point(702, 188);
            this.panel_Yellow.Name = "panel_Yellow";
            this.panel_Yellow.Size = new System.Drawing.Size(46, 51);
            this.panel_Yellow.TabIndex = 8;
            this.panel_Yellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel_Gray
            // 
            this.panel_Gray.BackColor = System.Drawing.Color.Gray;
            this.panel_Gray.Location = new System.Drawing.Point(621, 271);
            this.panel_Gray.Name = "panel_Gray";
            this.panel_Gray.Size = new System.Drawing.Size(46, 51);
            this.panel_Gray.TabIndex = 9;
            this.panel_Gray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel_Orange
            // 
            this.panel_Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_Orange.Location = new System.Drawing.Point(702, 271);
            this.panel_Orange.Name = "panel_Orange";
            this.panel_Orange.Size = new System.Drawing.Size(46, 51);
            this.panel_Orange.TabIndex = 10;
            this.panel_Orange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(13, 229);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(105, 271);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 12;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // FormAirCraftConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 411);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel_Orange);
            this.Controls.Add(this.panel_Gray);
            this.Controls.Add(this.panel_Yellow);
            this.Controls.Add(this.panel_Red);
            this.Controls.Add(this.panel_Blue);
            this.Controls.Add(this.panel_Green);
            this.Controls.Add(this.panel_White);
            this.Controls.Add(this.panel_Black);
            this.Controls.Add(this.panelAirCraft);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAirCraftConfig";
            this.Text = "FormAirCraftConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAirCraft)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelAirCraft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAirCraft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAirCraft;
        private System.Windows.Forms.Label labelBaseAirCraft;
        private System.Windows.Forms.Panel panelAirCraft;
        private System.Windows.Forms.Label DopColor;
        private System.Windows.Forms.Label MainColor;
        private System.Windows.Forms.Panel panel_Black;
        private System.Windows.Forms.Panel panel_White;
        private System.Windows.Forms.Panel panel_Green;
        private System.Windows.Forms.Panel panel_Blue;
        private System.Windows.Forms.Panel panel_Red;
        private System.Windows.Forms.Panel panel_Yellow;
        private System.Windows.Forms.Panel panel_Gray;
        private System.Windows.Forms.Panel panel_Orange;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_cancel;
    }
}