using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.IO;
using System.Drawing.Text;

namespace HOMEy
{
    public partial class mainPage : Form
    {
        string filePath = ""; //store the file location
        public mainPage()
        {
            InitializeComponent();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            this.undoButton.Hide();
            this.redoButton.Hide();
            this.richTextBox1.Hide();

            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("hh:mm");
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }

        //Exit-Maximize-MInimize
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximizeButton_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.maximizeButton.Hide();
            this.normalButton.Show();
        }

        private void normalButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.maximizeButton.Show();
            this.normalButton.Hide();
        }

        private void minimizeButton_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Menu Buttons
        private void createButton_Click(object sender, EventArgs e)
        {
            createButton.BackColor = Color.FromArgb(239, 116, 3);
            createButton.ForeColor = Color.White;
            loadButton.BackColor = Color.FromArgb(51, 50, 49);
            loadButton.ForeColor = Color.FromArgb(239, 116, 3);
            clearButton.BackColor = Color.FromArgb(51, 50, 49);
            clearButton.ForeColor = Color.FromArgb(239, 116, 3);
            saveButton.BackColor = Color.FromArgb(51, 50, 49);
            saveButton.ForeColor = Color.FromArgb(239, 116, 3);
            backButton.BackColor = Color.FromArgb(51, 50, 49);
            backButton.ForeColor = Color.FromArgb(239, 116, 3);

            this.timeAndDatePanel.Hide();
            this.undoButton.Show();
            this.redoButton.Show();
            this.richTextBox1.Show();
            filePath = "";
            richTextBox1.Text = "";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            createButton.BackColor = Color.FromArgb(51, 50, 49);
            createButton.ForeColor = Color.FromArgb(239, 116, 3);
            loadButton.BackColor = Color.FromArgb(239, 116, 3);
            loadButton.ForeColor = Color.White;
            clearButton.BackColor = Color.FromArgb(51, 50, 49);
            clearButton.ForeColor = Color.FromArgb(239, 116, 3);
            saveButton.BackColor = Color.FromArgb(51, 50, 49);
            saveButton.ForeColor = Color.FromArgb(239, 116, 3);
            backButton.BackColor = Color.FromArgb(51, 50, 49);
            backButton.ForeColor = Color.FromArgb(239, 116, 3);

            this.timeAndDatePanel.Hide();
            this.undoButton.Show();
            this.redoButton.Show();
            this.richTextBox1.Show();

            using (OpenFileDialog ofd = new OpenFileDialog() {Filter = "TextDocument | *.txt", ValidateNames=true, Multiselect=false})
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        filePath = ofd.FileName;
                        Task<string> text = sr.ReadToEndAsync();
                        richTextBox1.Text = text.Result;

                    }
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            createButton.BackColor = Color.FromArgb(51, 50, 49);
            createButton.ForeColor = Color.FromArgb(239, 116, 3);
            loadButton.BackColor = Color.FromArgb(51, 50, 49);
            loadButton.ForeColor = Color.FromArgb(239, 116, 3);
            clearButton.BackColor = Color.FromArgb(239, 116, 3);
            clearButton.ForeColor = Color.White;
            saveButton.BackColor = Color.FromArgb(51, 50, 49);
            saveButton.ForeColor = Color.FromArgb(239, 116, 3);
            backButton.BackColor = Color.FromArgb(51, 50, 49);
            backButton.ForeColor = Color.FromArgb(239, 116, 3);
            undoButton.BackColor = Color.FromArgb(51, 50, 49);
            undoButton.ForeColor = Color.FromArgb(239, 116, 3);
            redoButton.BackColor = Color.FromArgb(51, 50, 49);
            redoButton.ForeColor = Color.FromArgb(239, 116, 3);

            richTextBox1.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            createButton.BackColor = Color.FromArgb(51, 50, 49);
            createButton.ForeColor = Color.FromArgb(239, 116, 3);
            loadButton.BackColor = Color.FromArgb(51, 50, 49);
            loadButton.ForeColor = Color.FromArgb(239, 116, 3);
            clearButton.BackColor = Color.FromArgb(51, 50, 49);
            clearButton.ForeColor = Color.FromArgb(239, 116, 3);
            saveButton.BackColor = Color.FromArgb(239, 116, 3);
            saveButton.ForeColor = Color.White;
            backButton.BackColor = Color.FromArgb(51, 50, 49);
            backButton.ForeColor = Color.FromArgb(239, 116, 3);
            undoButton.BackColor = Color.FromArgb(51, 50, 49);
            undoButton.ForeColor = Color.FromArgb(239, 116, 3);
            redoButton.BackColor = Color.FromArgb(51, 50, 49);
            redoButton.ForeColor = Color.FromArgb(239, 116, 3);

            this.timeAndDatePanel.Show();
            this.undoButton.Hide();
            this.redoButton.Hide();
            this.richTextBox1.Hide();

            if (string.IsNullOrEmpty(filePath))
            {
                using (SaveFileDialog sfd = new SaveFileDialog() {Filter = "Textdocument | *.txt", ValidateNames=true})
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using(StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLineAsync(richTextBox1.Text);

                        }
                    }
                }
            }
            else
            {
                using(StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLineAsync(richTextBox1.Text);
                }
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            undoButton.BackColor = Color.FromArgb(239, 116, 3);
            undoButton.ForeColor = Color.White;
            redoButton.BackColor = Color.FromArgb(51, 50, 49);
            redoButton.ForeColor = Color.FromArgb(239, 116, 3);
            clearButton.BackColor = Color.FromArgb(51, 50, 49);
            clearButton.ForeColor = Color.FromArgb(239, 116, 3);
            saveButton.BackColor = Color.FromArgb(51, 50, 49);
            saveButton.ForeColor = Color.FromArgb(239, 116, 3);
            backButton.BackColor = Color.FromArgb(51, 50, 49);
            backButton.ForeColor = Color.FromArgb(239, 116, 3);
            richTextBox1.Undo();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            undoButton.BackColor = Color.FromArgb(51, 50, 49);
            undoButton.ForeColor = Color.FromArgb(239, 116, 3);
            redoButton.BackColor = Color.FromArgb(239, 116, 3);
            redoButton.ForeColor = Color.White;
            clearButton.BackColor = Color.FromArgb(51, 50, 49);
            clearButton.ForeColor = Color.FromArgb(239, 116, 3);
            saveButton.BackColor = Color.FromArgb(51, 50, 49);
            saveButton.ForeColor = Color.FromArgb(239, 116, 3);
            backButton.BackColor = Color.FromArgb(51, 50, 49);
            backButton.ForeColor = Color.FromArgb(239, 116, 3);
            richTextBox1.Redo();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            createButton.BackColor = Color.FromArgb(51, 50, 49);
            createButton.ForeColor = Color.FromArgb(239, 116, 3);
            loadButton.BackColor = Color.FromArgb(51, 50, 49);
            loadButton.ForeColor = Color.FromArgb(239, 116, 3);
            clearButton.BackColor = Color.FromArgb(51, 50, 49);
            clearButton.ForeColor = Color.FromArgb(239, 116, 3);
            saveButton.BackColor = Color.FromArgb(51, 50, 49);
            saveButton.ForeColor = Color.FromArgb(239, 116, 3);
            backButton.BackColor = Color.FromArgb(239, 116, 3);
            backButton.ForeColor = Color.White;

            this.timeAndDatePanel.Show();
            this.undoButton.Hide();
            this.redoButton.Hide();
            this.richTextBox1.Hide();
        }

        //Mouse Hovering in buttons: change color/s
        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.White;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromArgb(239, 116, 3);
        }

        private void minimizeButton_MouseHover(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.White;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.FromArgb(239, 116, 3);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //none
        }

        private void maximizeButton_MouseHover(object sender, EventArgs e)
        {
            maximizeButton.BackColor = Color.White;
        }

        private void maximizeButton_MouseLeave(object sender, EventArgs e)
        {
            maximizeButton.BackColor = Color.FromArgb(239, 116, 3);
        }

        private void normalButton_MouseHover(object sender, EventArgs e)
        {
            normalButton.BackColor = Color.White;
        }

        private void normalButton_MouseLeave(object sender, EventArgs e)
        {
            normalButton.BackColor = Color.FromArgb(239, 116, 3);
        }
    }
}
