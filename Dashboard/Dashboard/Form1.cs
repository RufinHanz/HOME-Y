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
        public dashboard()
        {
            InitializeComponent();
        }

        //Main Page
        private void dashboard_Load(object sender, EventArgs e)
        {
         
        }

        //Buttons (Functionality)
        private void loadButton_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {

        }

        //Buttons (Mouse Click)
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
            //Changes Coloor
            loadButton.BackColor = Color.FromArgb(255, 184, 76);
            createButton.BackColor = Color.FromArgb(255, 184, 76);
            deleteButton.BackColor = Color.FromArgb(255, 184, 76);
            saveChangesButton.BackColor = Color.FromArgb(83, 113, 136);
        }
    }
}
