using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class dashboard : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;

        public dashboard()
        {
            InitializeComponent();
        }

        //Main Page
        private void dashboard_Load(object sender, EventArgs e)
        {
            this.createEditNotePanel.Hide();
            this.previousNotesPanel.Hide();

            notes.Columns.Add("Title");
            notes.Columns.Add("Note");
            previousNotes.DataSource = notes;
        }
        private void previousNotesPanel_Paint(object sender, PaintEventArgs e)
        {
            //None
        }

        //Buttons (Functionality 1)
        private void loadButton_Click(object sender, EventArgs e)
        {
            this.previousNotesPanel.Show();
            this.createEditNotePanel.Hide();
            this.editButton.Show();
            this.deleteButton2.Hide();

            if (previousNotes == null)
            {
                this.previousNotesPanel.Hide();
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.createEditNotePanel.Show();
            this.previousNotesPanel.Hide();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.previousNotesPanel.Show();
            this.createEditNotePanel.Hide();
            this.deleteButton2.Show();
            this.editButton.Hide();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            this.exitButton.Show();
        }

        //Buttons (Functionality 2)
        private void loadButton_MouseClick(object sender, MouseEventArgs e)
        {
            //Changes Color
            loadButton.BackColor = Color.FromArgb(83, 113, 136);
            createButton.BackColor = Color.FromArgb(255, 184, 76);
            deleteButton.BackColor = Color.FromArgb(255, 184, 76);
            saveChangesButton.BackColor = Color.FromArgb(255, 184, 76);
        }

        private void createButton_MouseClick(object sender, MouseEventArgs e)
        {
            //Changes Color
            loadButton.BackColor = Color.FromArgb(255, 184, 76);
            createButton.BackColor = Color.FromArgb(83, 113, 136);
            deleteButton.BackColor = Color.FromArgb(255, 184, 76);
            saveChangesButton.BackColor = Color.FromArgb(255, 184, 76);
        }

        private void deleteButton_MouseClick(object sender, MouseEventArgs e)
        {
            //Changes Color
            loadButton.BackColor = Color.FromArgb(255, 184, 76);
            createButton.BackColor = Color.FromArgb(255, 184, 76);
            deleteButton.BackColor = Color.FromArgb(83, 113, 136);
            saveChangesButton.BackColor = Color.FromArgb(255, 184, 76);
        }

        private void saveChangesButton_MouseClick(object sender, MouseEventArgs e)
        {
            //Changes Color
            loadButton.BackColor = Color.FromArgb(255, 184, 76);
            createButton.BackColor = Color.FromArgb(255, 184, 76);
            deleteButton.BackColor = Color.FromArgb(255, 184, 76);
            saveChangesButton.BackColor = Color.FromArgb(83, 113, 136);
        }

        //Buttons (Functionality 3)
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.titleBox.Text = string.Empty;
            this.noteBox.Text = string.Empty;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = titleBox.Text;
            }
            else
            {
                notes.Rows.Add(titleBox.Text, noteBox.Text);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.previousNotesPanel.Hide();
            this.createEditNotePanel.Hide();

            //Remove color in menu button
            loadButton.BackColor = Color.FromArgb(255, 184, 76);
            createButton.BackColor = Color.FromArgb(255, 184, 76);
            deleteButton.BackColor = Color.FromArgb(255, 184, 76);
            saveChangesButton.BackColor = Color.FromArgb(255, 184, 76);
        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            this.previousNotesPanel.Hide();
            this.createEditNotePanel.Hide();

            //Remove color in menu button
            loadButton.BackColor = Color.FromArgb(255, 184, 76);
            createButton.BackColor = Color.FromArgb(255, 184, 76);
            deleteButton.BackColor = Color.FromArgb(255, 184, 76);
            saveChangesButton.BackColor = Color.FromArgb(255, 184, 76);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();

            createEditNotePanel.Show();
            previousNotesPanel.Hide();
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch
            {
                Console.WriteLine("Invalid Note");
            }

            createEditNotePanel.Hide();
            previousNotesPanel.Show();
        }


        //Data grid view
        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void previousNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void previousNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //None
        }
    }
}
