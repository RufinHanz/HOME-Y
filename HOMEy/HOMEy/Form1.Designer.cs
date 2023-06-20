namespace HOMEy
{
    partial class mainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.normalButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timeAndDatePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.timeAndDatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.menuPanel.Controls.Add(this.maximizeButton);
            this.menuPanel.Controls.Add(this.backButton);
            this.menuPanel.Controls.Add(this.redoButton);
            this.menuPanel.Controls.Add(this.undoButton);
            this.menuPanel.Controls.Add(this.clearButton);
            this.menuPanel.Controls.Add(this.minimizeButton);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.saveButton);
            this.menuPanel.Controls.Add(this.loadButton);
            this.menuPanel.Controls.Add(this.createButton);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Controls.Add(this.normalButton);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(137, 504);
            this.menuPanel.TabIndex = 0;
            // 
            // maximizeButton
            // 
            this.maximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Image = global::HOMEy.Properties.Resources.maximize1;
            this.maximizeButton.Location = new System.Drawing.Point(34, 5);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(25, 25);
            this.maximizeButton.TabIndex = 18;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click_1);
            this.maximizeButton.MouseLeave += new System.EventHandler(this.maximizeButton_MouseLeave);
            this.maximizeButton.MouseHover += new System.EventHandler(this.maximizeButton_MouseHover);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.backButton.Image = global::HOMEy.Properties.Resources.bxs_exit_icon3;
            this.backButton.Location = new System.Drawing.Point(12, 452);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 39);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "  Back";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.FlatAppearance.BorderSize = 0;
            this.redoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redoButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.redoButton.Image = global::HOMEy.Properties.Resources.redo_PNG_HD;
            this.redoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.redoButton.Location = new System.Drawing.Point(12, 227);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(125, 39);
            this.redoButton.TabIndex = 15;
            this.redoButton.Text = "   Redo";
            this.redoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.FlatAppearance.BorderSize = 0;
            this.undoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.undoButton.Image = global::HOMEy.Properties.Resources.Undo_PNG_HD;
            this.undoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.undoButton.Location = new System.Drawing.Point(12, 182);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(125, 39);
            this.undoButton.TabIndex = 14;
            this.undoButton.Text = "   Undo";
            this.undoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.clearButton.Image = global::HOMEy.Properties.Resources.Clear;
            this.clearButton.Location = new System.Drawing.Point(12, 272);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 39);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "   Clear";
            this.clearButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = global::HOMEy.Properties.Resources.minimize1;
            this.minimizeButton.Location = new System.Drawing.Point(65, 5);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(25, 25);
            this.minimizeButton.TabIndex = 11;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click_1);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.minimizeButton_MouseLeave);
            this.minimizeButton.MouseHover += new System.EventHandler(this.minimizeButton_MouseHover);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::HOMEy.Properties.Resources.vecteezy_x_1200172;
            this.exitButton.Location = new System.Drawing.Point(3, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.TabIndex = 1;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            this.exitButton.MouseHover += new System.EventHandler(this.exitButton_MouseHover);
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.saveButton.Image = global::HOMEy.Properties.Resources.pngfind1;
            this.saveButton.Location = new System.Drawing.Point(12, 317);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 39);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "  Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.FlatAppearance.BorderSize = 0;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.loadButton.Image = global::HOMEy.Properties.Resources.Load;
            this.loadButton.Location = new System.Drawing.Point(12, 227);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(125, 39);
            this.loadButton.TabIndex = 8;
            this.loadButton.Text = "   Load";
            this.loadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // createButton
            // 
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.createButton.Image = global::HOMEy.Properties.Resources.Create;
            this.createButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createButton.Location = new System.Drawing.Point(12, 182);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(125, 39);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HOMEy.Properties.Resources.HOMEy_LOGO;
            this.pictureBox1.Image = global::HOMEy.Properties.Resources.HOMEy_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(3, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // normalButton
            // 
            this.normalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.normalButton.FlatAppearance.BorderSize = 0;
            this.normalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalButton.Image = global::HOMEy.Properties.Resources.Programming_Minimize_Window_icon;
            this.normalButton.Location = new System.Drawing.Point(34, 5);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(25, 25);
            this.normalButton.TabIndex = 19;
            this.normalButton.UseVisualStyleBackColor = false;
            this.normalButton.Click += new System.EventHandler(this.normalButton_Click);
            this.normalButton.MouseLeave += new System.EventHandler(this.normalButton_MouseLeave);
            this.normalButton.MouseHover += new System.EventHandler(this.normalButton_MouseHover);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(153, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(585, 473);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timeAndDatePanel
            // 
            this.timeAndDatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeAndDatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(49)))));
            this.timeAndDatePanel.Controls.Add(this.panel3);
            this.timeAndDatePanel.Controls.Add(this.panel2);
            this.timeAndDatePanel.Controls.Add(this.pictureBox2);
            this.timeAndDatePanel.Controls.Add(this.dateLabel);
            this.timeAndDatePanel.Controls.Add(this.timeLabel);
            this.timeAndDatePanel.Location = new System.Drawing.Point(208, 67);
            this.timeAndDatePanel.Name = "timeAndDatePanel";
            this.timeAndDatePanel.Size = new System.Drawing.Size(543, 226);
            this.timeAndDatePanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(473, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 31);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.panel2.Location = new System.Drawing.Point(351, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 74);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HOMEy.Properties.Resources.clock_png_25789;
            this.pictureBox2.Location = new System.Drawing.Point(53, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.dateLabel.Location = new System.Drawing.Point(164, 136);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(170, 31);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Current Date";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(157, 60);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(199, 76);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(116)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.timeAndDatePanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.timeAndDatePanel.ResumeLayout(false);
            this.timeAndDatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Panel timeAndDatePanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button normalButton;
    }
}

