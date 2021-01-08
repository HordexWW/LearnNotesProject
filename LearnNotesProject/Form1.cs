using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnNotesProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void SetAllPanelsUnvisible()
        {
            MainMenuPanel.Visible = false;
            NotesModesPanel.Visible = false;
            ChordsModesPanel.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetAllPanelsUnvisible();
            MainMenuPanel.Visible = true;
        }

        private void NotesButton_Click(object sender, EventArgs e)
        {
            SetAllPanelsUnvisible();          
            NotesModesPanel.Visible = true;
        }

        private void ChordsButton_Click(object sender, EventArgs e)
        {
            SetAllPanelsUnvisible();
            ChordsModesPanel.Visible = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChordsBackButton_Click(object sender, EventArgs e)
        {
            SetAllPanelsUnvisible();
            MainMenuPanel.Visible = true;
        }

        private void NotesBackButton_Click(object sender, EventArgs e)
        {
            SetAllPanelsUnvisible();
            MainMenuPanel.Visible = true;
        }
    }
}
