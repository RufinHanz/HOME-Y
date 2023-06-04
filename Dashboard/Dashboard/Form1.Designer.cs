namespace Dashboard
{
    partial class dashboard
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
            this.panel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.previousNotesPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.previousNotesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel.Controls.Add(this.panel6);
            this.panel.Controls.Add(this.panel4);
            this.panel.Controls.Add(this.panel3);
            this.panel.Controls.Add(this.saveChangesButton);
            this.panel.Controls.Add(this.deleteButton);
            this.panel.Controls.Add(this.createButton);
            this.panel.Controls.Add(this.loadButton);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Location = new System.Drawing.Point(0, 26);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(115, 421);
            this.panel.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 89);
            this.panel6.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(110, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 91);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 5);
            this.panel3.TabIndex = 3;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveChangesButton.FlatAppearance.BorderSize = 0;
            this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.saveChangesButton.ForeColor = System.Drawing.Color.Black;
            this.saveChangesButton.Location = new System.Drawing.Point(0, 270);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(115, 48);
            this.saveChangesButton.TabIndex = 5;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            this.saveChangesButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveChangesButton_MouseClick);
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Image = global::Dashboard.Properties.Resources.Delete;
            this.deleteButton.Location = new System.Drawing.Point(0, 216);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(115, 48);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deleteButton_MouseClick);
            // 
            // createButton
            // 
            this.createButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.createButton.ForeColor = System.Drawing.Color.Black;
            this.createButton.Image = global::Dashboard.Properties.Resources.Create;
            this.createButton.Location = new System.Drawing.Point(0, 162);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(115, 48);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            this.createButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.createButton_MouseClick);
            // 
            // loadButton
            // 
            this.loadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadButton.FlatAppearance.BorderSize = 0;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.loadButton.ForeColor = System.Drawing.Color.Black;
            this.loadButton.Image = global::Dashboard.Properties.Resources.Load;
            this.loadButton.Location = new System.Drawing.Point(0, 108);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(115, 48);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            this.loadButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loadButton_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.HOMEYlogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 30);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel2.Location = new System.Drawing.Point(0, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 5);
            this.panel2.TabIndex = 2;
            // 
            // previousNotesPanel
            // 
            this.previousNotesPanel.BackColor = System.Drawing.Color.White;
            this.previousNotesPanel.Controls.Add(this.panel9);
            this.previousNotesPanel.Controls.Add(this.panel8);
            this.previousNotesPanel.Controls.Add(this.panel5);
            this.previousNotesPanel.Controls.Add(this.panel7);
            this.previousNotesPanel.Location = new System.Drawing.Point(142, 0);
            this.previousNotesPanel.Name = "previousNotesPanel";
            this.previousNotesPanel.Size = new System.Drawing.Size(508, 418);
            this.previousNotesPanel.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel7.Location = new System.Drawing.Point(0, 26);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 388);
            this.panel7.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(508, 30);
            this.panel5.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel8.Location = new System.Drawing.Point(503, 23);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 392);
            this.panel8.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(575, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel9.Location = new System.Drawing.Point(0, 413);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(508, 5);
            this.panel9.TabIndex = 4;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(113)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.previousNotesPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.previousNotesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel previousNotesPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel9;
    }
}

