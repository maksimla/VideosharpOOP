namespace RunGame
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.picture = new System.Windows.Forms.PictureBox();
            this.buttonAddCircle = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddGamer = new System.Windows.Forms.Button();
            this.buttonAddBox = new System.Windows.Forms.Button();
            this.radioVirus = new System.Windows.Forms.RadioButton();
            this.radioGolia = new System.Windows.Forms.RadioButton();
            this.checkStopAll = new System.Windows.Forms.CheckBox();
            this.checkStopBed = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(813, 545);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // buttonAddCircle
            // 
            this.buttonAddCircle.Location = new System.Drawing.Point(3, 49);
            this.buttonAddCircle.Name = "buttonAddCircle";
            this.buttonAddCircle.Size = new System.Drawing.Size(91, 23);
            this.buttonAddCircle.TabIndex = 1;
            this.buttonAddCircle.Text = "+5 Кружков";
            this.buttonAddCircle.UseVisualStyleBackColor = true;
            this.buttonAddCircle.Click += new System.EventHandler(this.buttonAddCircle_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.checkStopBed);
            this.panel1.Controls.Add(this.checkStopAll);
            this.panel1.Controls.Add(this.buttonAddGamer);
            this.panel1.Controls.Add(this.buttonAddBox);
            this.panel1.Controls.Add(this.radioVirus);
            this.panel1.Controls.Add(this.radioGolia);
            this.panel1.Controls.Add(this.buttonAddCircle);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(699, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 180);
            this.panel1.TabIndex = 2;
            // 
            // buttonAddGamer
            // 
            this.buttonAddGamer.Location = new System.Drawing.Point(3, 107);
            this.buttonAddGamer.Name = "buttonAddGamer";
            this.buttonAddGamer.Size = new System.Drawing.Size(91, 23);
            this.buttonAddGamer.TabIndex = 5;
            this.buttonAddGamer.Text = "+5 Всех";
            this.buttonAddGamer.UseVisualStyleBackColor = true;
            this.buttonAddGamer.Click += new System.EventHandler(this.buttonAddGamer_Click);
            // 
            // buttonAddBox
            // 
            this.buttonAddBox.Location = new System.Drawing.Point(4, 78);
            this.buttonAddBox.Name = "buttonAddBox";
            this.buttonAddBox.Size = new System.Drawing.Size(91, 23);
            this.buttonAddBox.TabIndex = 4;
            this.buttonAddBox.Text = "+5 Квадратов";
            this.buttonAddBox.UseVisualStyleBackColor = true;
            this.buttonAddBox.Click += new System.EventHandler(this.buttonAddBox_Click);
            // 
            // radioVirus
            // 
            this.radioVirus.AutoSize = true;
            this.radioVirus.Location = new System.Drawing.Point(3, 26);
            this.radioVirus.Name = "radioVirus";
            this.radioVirus.Size = new System.Drawing.Size(55, 17);
            this.radioVirus.TabIndex = 3;
            this.radioVirus.Text = "Вирус";
            this.radioVirus.UseVisualStyleBackColor = true;
            this.radioVirus.CheckedChanged += new System.EventHandler(this.radioVirus_CheckedChanged);
            // 
            // radioGolia
            // 
            this.radioGolia.AutoSize = true;
            this.radioGolia.Checked = true;
            this.radioGolia.Location = new System.Drawing.Point(3, 3);
            this.radioGolia.Name = "radioGolia";
            this.radioGolia.Size = new System.Drawing.Size(49, 17);
            this.radioGolia.TabIndex = 2;
            this.radioGolia.TabStop = true;
            this.radioGolia.Text = "Голя";
            this.radioGolia.UseVisualStyleBackColor = true;
            this.radioGolia.CheckedChanged += new System.EventHandler(this.radioGolia_CheckedChanged);
            // 
            // checkStopAll
            // 
            this.checkStopAll.AutoSize = true;
            this.checkStopAll.Location = new System.Drawing.Point(4, 136);
            this.checkStopAll.Name = "checkStopAll";
            this.checkStopAll.Size = new System.Drawing.Size(71, 17);
            this.checkStopAll.TabIndex = 6;
            this.checkStopAll.Text = "Стоп всё";
            this.checkStopAll.UseVisualStyleBackColor = true;
            this.checkStopAll.CheckedChanged += new System.EventHandler(this.checkStopAll_CheckedChanged);
            // 
            // checkStopBed
            // 
            this.checkStopBed.AutoSize = true;
            this.checkStopBed.Location = new System.Drawing.Point(4, 159);
            this.checkStopBed.Name = "checkStopBed";
            this.checkStopBed.Size = new System.Drawing.Size(77, 17);
            this.checkStopBed.TabIndex = 7;
            this.checkStopBed.Text = "Стоп Голя";
            this.checkStopBed.UseVisualStyleBackColor = true;
            this.checkStopBed.CheckedChanged += new System.EventHandler(this.checkStopBed_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Tag = "1";
            this.button1.Text = "Скрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра с Интерфейсом";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button buttonAddCircle;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddBox;
        private System.Windows.Forms.RadioButton radioVirus;
        private System.Windows.Forms.RadioButton radioGolia;
        private System.Windows.Forms.Button buttonAddGamer;
        private System.Windows.Forms.CheckBox checkStopBed;
        private System.Windows.Forms.CheckBox checkStopAll;
        private System.Windows.Forms.Button button1;
    }
}

