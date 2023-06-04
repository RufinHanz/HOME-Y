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
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.createEditNotePanel = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.deleteButton2 = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exitButton2 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.previousNotesPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.createEditNotePanel.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel6.Location = new System.Drawing.Point(0, -4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 99);
            this.panel6.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(110, -5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 102);
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
            this.previousNotesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(113)))), ((int)(((byte)(136)))));
            this.previousNotesPanel.Controls.Add(this.exitButton2);
            this.previousNotesPanel.Controls.Add(this.dataGridView1);
            this.previousNotesPanel.Controls.Add(this.editButton);
            this.previousNotesPanel.Controls.Add(this.deleteButton2);
            this.previousNotesPanel.Controls.Add(this.panel9);
            this.previousNotesPanel.Controls.Add(this.panel8);
            this.previousNotesPanel.Controls.Add(this.panel5);
            this.previousNotesPanel.Controls.Add(this.panel7);
            this.previousNotesPanel.Location = new System.Drawing.Point(142, 0);
            this.previousNotesPanel.Name = "previousNotesPanel";
            this.previousNotesPanel.Size = new System.Drawing.Size(508, 447);
            this.previousNotesPanel.TabIndex = 3;
            this.previousNotesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.previousNotesPanel_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel9.Location = new System.Drawing.Point(0, 413);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(508, 5);
            this.panel9.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel8.Location = new System.Drawing.Point(503, 23);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 392);
            this.panel8.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(508, 30);
            this.panel5.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel7.Location = new System.Drawing.Point(0, 26);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 388);
            this.panel7.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitButton.Location = new System.Drawing.Point(433, 416);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 31);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 17);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "List of Notes:";
            // 
            // createEditNotePanel
            // 
            this.createEditNotePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(113)))), ((int)(((byte)(136)))));
            this.createEditNotePanel.Controls.Add(this.exitButton);
            this.createEditNotePanel.Controls.Add(this.saveButton);
            this.createEditNotePanel.Controls.Add(this.clearButton);
            this.createEditNotePanel.Controls.Add(this.noteBox);
            this.createEditNotePanel.Controls.Add(this.titleBox);
            this.createEditNotePanel.Controls.Add(this.panel11);
            this.createEditNotePanel.Controls.Add(this.panel12);
            this.createEditNotePanel.Controls.Add(this.panel13);
            this.createEditNotePanel.Controls.Add(this.panel14);
            this.createEditNotePanel.Location = new System.Drawing.Point(142, 0);
            this.createEditNotePanel.Name = "createEditNotePanel";
            this.createEditNotePanel.Size = new System.Drawing.Size(508, 447);
            this.createEditNotePanel.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel11.Location = new System.Drawing.Point(0, 413);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(508, 5);
            this.panel11.TabIndex = 4;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel12.Location = new System.Drawing.Point(503, 23);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(5, 392);
            this.panel12.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel13.Controls.Add(this.textBox2);
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(508, 30);
            this.panel13.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(5, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 17);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Create / Edit Note:";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.panel14.Location = new System.Drawing.Point(0, 26);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(5, 388);
            this.panel14.TabIndex = 1;
            // 
            // deleteButton2
            // 
            this.deleteButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.deleteButton2.FlatAppearance.BorderSize = 0;
            this.deleteButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.deleteButton2.Location = new System.Drawing.Point(352, 418);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(75, 27);
            this.deleteButton2.TabIndex = 6;
            this.deleteButton2.Text = "Delete";
            this.deleteButton2.UseVisualStyleBackColor = false;
            this.deleteButton2.Click += new System.EventHandler(this.deleteButton2_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.editButton.Location = new System.Drawing.Point(352, 416);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 31);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.White;
            this.titleBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.titleBox.Location = new System.Drawing.Point(11, 36);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(486, 24);
            this.titleBox.TabIndex = 5;
            // 
            // noteBox
            // 
            this.noteBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.noteBox.Location = new System.Drawing.Point(11, 66);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(486, 341);
            this.noteBox.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.clearButton.Location = new System.Drawing.Point(271, 416);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 31);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(352, 416);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 31);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 371);
            this.dataGridView1.TabIndex = 8;
            // 
            // exitButton2
            // 
            this.exitButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(76)))));
            this.exitButton2.FlatAppearance.BorderSize = 0;
            this.exitButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitButton2.Location = new System.Drawing.Point(433, 416);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(75, 31);
            this.exitButton2.TabIndex = 9;
            this.exitButton2.Text = "Exit";
            this.exitButton2.UseVisualStyleBackColor = false;
            this.exitButton2.Click += new System.EventHandler(this.exitButton2_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(113)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.createEditNotePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.previousNotesPanel);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.previousNotesPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.createEditNotePanel.ResumeLayout(false);
            this.createEditNotePanel.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel previousNotesPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel createEditNotePanel;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button deleteButton2;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exitButton2;
    }
}

