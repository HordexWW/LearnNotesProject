using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LearnNotesProject
{
    public partial class MainForm : Form
    {
        public string gametype;
        public string gamemode;
        public bool nextstep;
        public string chosen_note = "";

        public MainForm()
        {
            InitializeComponent();
            Controller.Parent = this;
            Controller.Initialize();
        }

        private void SetAllPanelsUnvisible()
        {
            MainMenuPanel.Visible = false;
            NotesModesPanel.Visible = false;
            ChordsModesPanel.Visible = false;
            PlayPanel.Visible = false;
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
            gametype = "notesgame";
        }

        private void ChordsButton_Click(object sender, EventArgs e)
        {
            SetAllPanelsUnvisible();
            ChordsModesPanel.Visible = true;
            gametype = "chordsgame";
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

        public void KeyPressed(string note_name)
        {
            chosen_note = note_name;
            nextstep = true;
        }

        public void UpdateStats(int score, int tries)
        {
            Invoke((MethodInvoker)delegate {
                this.score_lab.Text = score.ToString();
                this.tries_lab.Text = tries.ToString();
            });
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            KeyPressed("C");
        }

        private void btnDd_Click(object sender, EventArgs e)
        {
            KeyPressed("D#");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            KeyPressed("D");
        }

        private void btnCd_Click(object sender, EventArgs e)
        {
            KeyPressed("C#");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            KeyPressed("E");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            KeyPressed("F");
        }

        private void btnFd_Click(object sender, EventArgs e)
        {
            KeyPressed("F#");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            KeyPressed("G");
        }

        private void btnGd_Click(object sender, EventArgs e)
        {
            KeyPressed("G#");
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            KeyPressed("A");
        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            KeyPressed("A#");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            KeyPressed("B");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChordsPlayModeButton_Click(object sender, EventArgs e)
        {
            SetAllPanelsUnvisible();
            PlayPanel.Visible = true;
            instrument_cb.Visible = true;
            difficulty_cb.Visible = true;
            sc_l.Visible = true;
            tr_l.Visible = true;
            score_lab.Visible = true;
            tries_lab.Visible = true;
            Thread thread;
            thread = new Thread(delegate () { Controller.StartGame("chordsgame", "game"); });
            thread.Start();
        }

        private void ChordsTrainingModeButton_Click(object sender, EventArgs e)
        {
            SetAllPanelsUnvisible();
            PlayPanel.Visible = true;
            instrument_cb.Visible = true;
            difficulty_cb.Visible = true;
            sc_l.Visible = false;
            tr_l.Visible = false;
            score_lab.Visible = false;
            tries_lab.Visible = false;
            Thread thread;
            thread = new Thread(delegate () { Controller.StartGame("chordsgame", "training"); });
            thread.Start();
        }

        private void NotesPlayModeButton_Click(object sender, EventArgs e)
        {
            SetAllPanelsUnvisible();
            PlayPanel.Visible = true;
            instrument_cb.Visible = false;
            difficulty_cb.Visible = true;
            sc_l.Visible = true;
            tr_l.Visible = true;
            score_lab.Visible = true;
            tries_lab.Visible = true;
            Thread thread;
            thread = new Thread(delegate () { Controller.StartGame("notesgame", "game"); });
            thread.Start();
        }

        private void NotesTrainingModeButton_Click(object sender, EventArgs e)
        {
            SetAllPanelsUnvisible();
            PlayPanel.Visible = true;
            instrument_cb.Visible = false;
            difficulty_cb.Visible = true;
            sc_l.Visible = false;
            tr_l.Visible = false;
            score_lab.Visible = false;
            tries_lab.Visible = false;
            Thread thread;
            thread = new Thread(delegate () { Controller.StartGame("notesgame", "training"); });
            thread.Start();
        }

        private void PlayPanelExitBtn_Click(object sender, EventArgs e)
        {
            SetAllPanelsUnvisible();
            MainMenuPanel.Visible = true;
        }

        public void SetMessage(string s)
        {
            string[] str = s.Split('\n');
            Invoke((MethodInvoker)delegate {
                this.infoLab.Text = s;
                this.nextstep = false;
            });
        }

        private void instrument_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (instrument_cb.Text == "Пианино")
                Controller.instrument = "piano";
            else
                Controller.instrument = "guitar";
        }

        private void difficulty_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (difficulty_cb.Checked)
                Controller.difficulty = true;
            else
                Controller.difficulty = false;
        }

        private void playsound_b_Click(object sender, EventArgs e)
        {
            Controller.PlaySound();
        }

        public void ReturnToMenu()
        {
            Invoke((MethodInvoker)delegate {
                this.SetAllPanelsUnvisible();
                this.MainMenuPanel.Visible = true;
            });
        }
    }
}
