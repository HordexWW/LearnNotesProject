
namespace LearnNotesProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.ApplicationNameText = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NotesButton = new System.Windows.Forms.Button();
            this.ChordsButton = new System.Windows.Forms.Button();
            this.NotesModesPanel = new System.Windows.Forms.Panel();
            this.NotesModesText = new System.Windows.Forms.Label();
            this.NotesBackButton = new System.Windows.Forms.Button();
            this.NotesPlayModeButton = new System.Windows.Forms.Button();
            this.NotesTrainingModeButton = new System.Windows.Forms.Button();
            this.ChordsModesPanel = new System.Windows.Forms.Panel();
            this.ChordsModesText = new System.Windows.Forms.Label();
            this.ChordsBackButton = new System.Windows.Forms.Button();
            this.ChordsPlayModeButton = new System.Windows.Forms.Button();
            this.ChordsTrainingModeButton = new System.Windows.Forms.Button();
            this.PlayPanel = new System.Windows.Forms.Panel();
            this.infoLab = new System.Windows.Forms.Label();
            this.PlayPanelExitBtn = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCd = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnDd = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnFd = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnGd = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnAd = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.difficulty_cb = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.instrument_cb = new System.Windows.Forms.ComboBox();
            this.sc_l = new System.Windows.Forms.Label();
            this.tr_l = new System.Windows.Forms.Label();
            this.score_lab = new System.Windows.Forms.Label();
            this.tries_lab = new System.Windows.Forms.Label();
            this.playsound_b = new System.Windows.Forms.Button();
            this.MainMenuPanel.SuspendLayout();
            this.NotesModesPanel.SuspendLayout();
            this.ChordsModesPanel.SuspendLayout();
            this.PlayPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.ApplicationNameText);
            this.MainMenuPanel.Controls.Add(this.ExitButton);
            this.MainMenuPanel.Controls.Add(this.NotesButton);
            this.MainMenuPanel.Controls.Add(this.ChordsButton);
            this.MainMenuPanel.Location = new System.Drawing.Point(10, 12);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(382, 365);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // ApplicationNameText
            // 
            this.ApplicationNameText.AutoSize = true;
            this.ApplicationNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationNameText.Location = new System.Drawing.Point(108, 31);
            this.ApplicationNameText.Name = "ApplicationNameText";
            this.ApplicationNameText.Size = new System.Drawing.Size(155, 31);
            this.ApplicationNameText.TabIndex = 3;
            this.ApplicationNameText.Text = "LearnNotes";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(26, 284);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(319, 52);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NotesButton
            // 
            this.NotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotesButton.Location = new System.Drawing.Point(26, 114);
            this.NotesButton.Name = "NotesButton";
            this.NotesButton.Size = new System.Drawing.Size(319, 52);
            this.NotesButton.TabIndex = 1;
            this.NotesButton.Text = "Ноты";
            this.NotesButton.UseVisualStyleBackColor = true;
            this.NotesButton.Click += new System.EventHandler(this.NotesButton_Click);
            // 
            // ChordsButton
            // 
            this.ChordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChordsButton.Location = new System.Drawing.Point(26, 172);
            this.ChordsButton.Name = "ChordsButton";
            this.ChordsButton.Size = new System.Drawing.Size(319, 52);
            this.ChordsButton.TabIndex = 0;
            this.ChordsButton.Text = "Аккорды";
            this.ChordsButton.UseVisualStyleBackColor = true;
            this.ChordsButton.Click += new System.EventHandler(this.ChordsButton_Click);
            // 
            // NotesModesPanel
            // 
            this.NotesModesPanel.Controls.Add(this.NotesModesText);
            this.NotesModesPanel.Controls.Add(this.NotesBackButton);
            this.NotesModesPanel.Controls.Add(this.NotesPlayModeButton);
            this.NotesModesPanel.Controls.Add(this.NotesTrainingModeButton);
            this.NotesModesPanel.Location = new System.Drawing.Point(9, 12);
            this.NotesModesPanel.Name = "NotesModesPanel";
            this.NotesModesPanel.Size = new System.Drawing.Size(386, 365);
            this.NotesModesPanel.TabIndex = 4;
            // 
            // NotesModesText
            // 
            this.NotesModesText.AutoSize = true;
            this.NotesModesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotesModesText.Location = new System.Drawing.Point(94, 31);
            this.NotesModesText.Name = "NotesModesText";
            this.NotesModesText.Size = new System.Drawing.Size(190, 31);
            this.NotesModesText.TabIndex = 6;
            this.NotesModesText.Text = "\"Угадай ноты\"";
            // 
            // NotesBackButton
            // 
            this.NotesBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotesBackButton.Location = new System.Drawing.Point(26, 284);
            this.NotesBackButton.Name = "NotesBackButton";
            this.NotesBackButton.Size = new System.Drawing.Size(319, 52);
            this.NotesBackButton.TabIndex = 2;
            this.NotesBackButton.Text = "Назад";
            this.NotesBackButton.UseVisualStyleBackColor = true;
            this.NotesBackButton.Click += new System.EventHandler(this.NotesBackButton_Click);
            // 
            // NotesPlayModeButton
            // 
            this.NotesPlayModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotesPlayModeButton.Location = new System.Drawing.Point(26, 114);
            this.NotesPlayModeButton.Name = "NotesPlayModeButton";
            this.NotesPlayModeButton.Size = new System.Drawing.Size(319, 52);
            this.NotesPlayModeButton.TabIndex = 1;
            this.NotesPlayModeButton.Text = "Режим игры";
            this.NotesPlayModeButton.UseVisualStyleBackColor = true;
            this.NotesPlayModeButton.Click += new System.EventHandler(this.NotesPlayModeButton_Click);
            // 
            // NotesTrainingModeButton
            // 
            this.NotesTrainingModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotesTrainingModeButton.Location = new System.Drawing.Point(26, 172);
            this.NotesTrainingModeButton.Name = "NotesTrainingModeButton";
            this.NotesTrainingModeButton.Size = new System.Drawing.Size(319, 52);
            this.NotesTrainingModeButton.TabIndex = 0;
            this.NotesTrainingModeButton.Text = "Режим тренировки";
            this.NotesTrainingModeButton.UseVisualStyleBackColor = true;
            this.NotesTrainingModeButton.Click += new System.EventHandler(this.NotesTrainingModeButton_Click);
            // 
            // ChordsModesPanel
            // 
            this.ChordsModesPanel.Controls.Add(this.ChordsModesText);
            this.ChordsModesPanel.Controls.Add(this.ChordsBackButton);
            this.ChordsModesPanel.Controls.Add(this.ChordsPlayModeButton);
            this.ChordsModesPanel.Controls.Add(this.ChordsTrainingModeButton);
            this.ChordsModesPanel.Location = new System.Drawing.Point(9, 12);
            this.ChordsModesPanel.Name = "ChordsModesPanel";
            this.ChordsModesPanel.Size = new System.Drawing.Size(386, 365);
            this.ChordsModesPanel.TabIndex = 7;
            // 
            // ChordsModesText
            // 
            this.ChordsModesText.AutoSize = true;
            this.ChordsModesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChordsModesText.Location = new System.Drawing.Point(67, 31);
            this.ChordsModesText.Name = "ChordsModesText";
            this.ChordsModesText.Size = new System.Drawing.Size(237, 31);
            this.ChordsModesText.TabIndex = 6;
            this.ChordsModesText.Text = "\"Угадай аккорды\"";
            // 
            // ChordsBackButton
            // 
            this.ChordsBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChordsBackButton.Location = new System.Drawing.Point(24, 284);
            this.ChordsBackButton.Name = "ChordsBackButton";
            this.ChordsBackButton.Size = new System.Drawing.Size(319, 52);
            this.ChordsBackButton.TabIndex = 2;
            this.ChordsBackButton.Text = "Назад";
            this.ChordsBackButton.UseVisualStyleBackColor = true;
            this.ChordsBackButton.Click += new System.EventHandler(this.ChordsBackButton_Click);
            // 
            // ChordsPlayModeButton
            // 
            this.ChordsPlayModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChordsPlayModeButton.Location = new System.Drawing.Point(24, 114);
            this.ChordsPlayModeButton.Name = "ChordsPlayModeButton";
            this.ChordsPlayModeButton.Size = new System.Drawing.Size(319, 52);
            this.ChordsPlayModeButton.TabIndex = 1;
            this.ChordsPlayModeButton.Text = "Режим игры";
            this.ChordsPlayModeButton.UseVisualStyleBackColor = true;
            this.ChordsPlayModeButton.Click += new System.EventHandler(this.ChordsPlayModeButton_Click);
            // 
            // ChordsTrainingModeButton
            // 
            this.ChordsTrainingModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChordsTrainingModeButton.Location = new System.Drawing.Point(24, 172);
            this.ChordsTrainingModeButton.Name = "ChordsTrainingModeButton";
            this.ChordsTrainingModeButton.Size = new System.Drawing.Size(319, 52);
            this.ChordsTrainingModeButton.TabIndex = 0;
            this.ChordsTrainingModeButton.Text = "Режим тренировки";
            this.ChordsTrainingModeButton.UseVisualStyleBackColor = true;
            this.ChordsTrainingModeButton.Click += new System.EventHandler(this.ChordsTrainingModeButton_Click);
            // 
            // PlayPanel
            // 
            this.PlayPanel.Controls.Add(this.playsound_b);
            this.PlayPanel.Controls.Add(this.tries_lab);
            this.PlayPanel.Controls.Add(this.score_lab);
            this.PlayPanel.Controls.Add(this.tr_l);
            this.PlayPanel.Controls.Add(this.groupBox2);
            this.PlayPanel.Controls.Add(this.sc_l);
            this.PlayPanel.Controls.Add(this.groupBox1);
            this.PlayPanel.Controls.Add(this.infoLab);
            this.PlayPanel.Location = new System.Drawing.Point(6, 12);
            this.PlayPanel.Name = "PlayPanel";
            this.PlayPanel.Size = new System.Drawing.Size(389, 365);
            this.PlayPanel.TabIndex = 8;
            // 
            // infoLab
            // 
            this.infoLab.AutoSize = true;
            this.infoLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLab.Location = new System.Drawing.Point(123, 62);
            this.infoLab.Name = "infoLab";
            this.infoLab.Size = new System.Drawing.Size(123, 16);
            this.infoLab.TabIndex = 6;
            this.infoLab.Text = "\"Угадай аккорды\"";
            this.infoLab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayPanelExitBtn
            // 
            this.PlayPanelExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayPanelExitBtn.Location = new System.Drawing.Point(285, 14);
            this.PlayPanelExitBtn.Name = "PlayPanelExitBtn";
            this.PlayPanelExitBtn.Size = new System.Drawing.Size(84, 25);
            this.PlayPanelExitBtn.TabIndex = 2;
            this.PlayPanelExitBtn.Text = "Выйти";
            this.PlayPanelExitBtn.UseVisualStyleBackColor = true;
            this.PlayPanelExitBtn.Click += new System.EventHandler(this.PlayPanelExitBtn_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnC.Location = new System.Drawing.Point(40, 14);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(40, 133);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCd
            // 
            this.btnCd.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCd.Location = new System.Drawing.Point(68, 15);
            this.btnCd.Name = "btnCd";
            this.btnCd.Size = new System.Drawing.Size(25, 92);
            this.btnCd.TabIndex = 8;
            this.btnCd.Text = "C#";
            this.btnCd.UseVisualStyleBackColor = false;
            this.btnCd.Click += new System.EventHandler(this.btnCd_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnD.Location = new System.Drawing.Point(81, 14);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(40, 133);
            this.btnD.TabIndex = 9;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnDd
            // 
            this.btnDd.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDd.Location = new System.Drawing.Point(109, 15);
            this.btnDd.Name = "btnDd";
            this.btnDd.Size = new System.Drawing.Size(25, 93);
            this.btnDd.TabIndex = 10;
            this.btnDd.Text = "D#";
            this.btnDd.UseVisualStyleBackColor = false;
            this.btnDd.Click += new System.EventHandler(this.btnDd_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnE.Location = new System.Drawing.Point(121, 14);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(40, 133);
            this.btnE.TabIndex = 11;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnF
            // 
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnF.Location = new System.Drawing.Point(162, 14);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(40, 133);
            this.btnF.TabIndex = 12;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnFd
            // 
            this.btnFd.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnFd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFd.Location = new System.Drawing.Point(191, 14);
            this.btnFd.Name = "btnFd";
            this.btnFd.Size = new System.Drawing.Size(25, 93);
            this.btnFd.TabIndex = 13;
            this.btnFd.Text = "F#";
            this.btnFd.UseVisualStyleBackColor = false;
            this.btnFd.Click += new System.EventHandler(this.btnFd_Click);
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnG.Location = new System.Drawing.Point(203, 14);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(40, 133);
            this.btnG.TabIndex = 14;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnGd
            // 
            this.btnGd.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGd.Location = new System.Drawing.Point(231, 14);
            this.btnGd.Name = "btnGd";
            this.btnGd.Size = new System.Drawing.Size(25, 93);
            this.btnGd.TabIndex = 15;
            this.btnGd.Text = "G#";
            this.btnGd.UseVisualStyleBackColor = false;
            this.btnGd.Click += new System.EventHandler(this.btnGd_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnA.Location = new System.Drawing.Point(244, 14);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(40, 133);
            this.btnA.TabIndex = 16;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnAd
            // 
            this.btnAd.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAd.Location = new System.Drawing.Point(273, 14);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(25, 93);
            this.btnAd.TabIndex = 17;
            this.btnAd.Text = "A#";
            this.btnAd.UseVisualStyleBackColor = false;
            this.btnAd.Click += new System.EventHandler(this.btnAd_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnB.Location = new System.Drawing.Point(285, 14);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(40, 133);
            this.btnB.TabIndex = 18;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnGd);
            this.groupBox1.Controls.Add(this.btnFd);
            this.groupBox1.Controls.Add(this.btnCd);
            this.groupBox1.Controls.Add(this.btnDd);
            this.groupBox1.Controls.Add(this.btnAd);
            this.groupBox1.Controls.Add(this.btnC);
            this.groupBox1.Controls.Add(this.btnB);
            this.groupBox1.Controls.Add(this.btnD);
            this.groupBox1.Controls.Add(this.btnA);
            this.groupBox1.Controls.Add(this.btnF);
            this.groupBox1.Controls.Add(this.btnE);
            this.groupBox1.Controls.Add(this.btnG);
            this.groupBox1.Location = new System.Drawing.Point(3, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 158);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // difficulty_cb
            // 
            this.difficulty_cb.AutoSize = true;
            this.difficulty_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.difficulty_cb.Location = new System.Drawing.Point(104, 17);
            this.difficulty_cb.Name = "difficulty_cb";
            this.difficulty_cb.Size = new System.Drawing.Size(182, 20);
            this.difficulty_cb.TabIndex = 21;
            this.difficulty_cb.Text = "Повышенная сложность";
            this.difficulty_cb.UseVisualStyleBackColor = true;
            this.difficulty_cb.CheckedChanged += new System.EventHandler(this.difficulty_cb_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.instrument_cb);
            this.groupBox2.Controls.Add(this.difficulty_cb);
            this.groupBox2.Controls.Add(this.PlayPanelExitBtn);
            this.groupBox2.Location = new System.Drawing.Point(7, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 43);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // instrument_cb
            // 
            this.instrument_cb.FormattingEnabled = true;
            this.instrument_cb.Items.AddRange(new object[] {
            "Пианино",
            "Гитара"});
            this.instrument_cb.Location = new System.Drawing.Point(0, 17);
            this.instrument_cb.Name = "instrument_cb";
            this.instrument_cb.Size = new System.Drawing.Size(92, 21);
            this.instrument_cb.TabIndex = 22;
            this.instrument_cb.Text = "Пианино";
            this.instrument_cb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.instrument_cb.SelectedValueChanged += new System.EventHandler(this.instrument_cb_SelectedValueChanged);
            // 
            // sc_l
            // 
            this.sc_l.AutoSize = true;
            this.sc_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sc_l.Location = new System.Drawing.Point(10, 162);
            this.sc_l.Name = "sc_l";
            this.sc_l.Size = new System.Drawing.Size(38, 13);
            this.sc_l.TabIndex = 23;
            this.sc_l.Text = "Счет:";
            // 
            // tr_l
            // 
            this.tr_l.AutoSize = true;
            this.tr_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tr_l.Location = new System.Drawing.Point(10, 184);
            this.tr_l.Name = "tr_l";
            this.tr_l.Size = new System.Drawing.Size(102, 13);
            this.tr_l.TabIndex = 24;
            this.tr_l.Text = "Число попыток:";
            // 
            // score_lab
            // 
            this.score_lab.AutoSize = true;
            this.score_lab.Location = new System.Drawing.Point(48, 162);
            this.score_lab.Name = "score_lab";
            this.score_lab.Size = new System.Drawing.Size(0, 13);
            this.score_lab.TabIndex = 25;
            // 
            // tries_lab
            // 
            this.tries_lab.AutoSize = true;
            this.tries_lab.Location = new System.Drawing.Point(111, 184);
            this.tries_lab.Name = "tries_lab";
            this.tries_lab.Size = new System.Drawing.Size(0, 13);
            this.tries_lab.TabIndex = 26;
            // 
            // playsound_b
            // 
            this.playsound_b.Location = new System.Drawing.Point(144, 113);
            this.playsound_b.Name = "playsound_b";
            this.playsound_b.Size = new System.Drawing.Size(90, 40);
            this.playsound_b.TabIndex = 27;
            this.playsound_b.Text = "Проиграть звук";
            this.playsound_b.UseVisualStyleBackColor = true;
            this.playsound_b.Click += new System.EventHandler(this.playsound_b_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 390);
            this.Controls.Add(this.PlayPanel);
            this.Controls.Add(this.ChordsModesPanel);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.NotesModesPanel);
            this.Name = "MainForm";
            this.Text = "LearnNotes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.NotesModesPanel.ResumeLayout(false);
            this.NotesModesPanel.PerformLayout();
            this.ChordsModesPanel.ResumeLayout(false);
            this.ChordsModesPanel.PerformLayout();
            this.PlayPanel.ResumeLayout(false);
            this.PlayPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuPanel;
        
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button NotesButton;
        private System.Windows.Forms.Button ChordsButton;
        private System.Windows.Forms.Label ApplicationNameText;
        private System.Windows.Forms.Panel NotesModesPanel;
        private System.Windows.Forms.Panel ChordsModesPanel;
        private System.Windows.Forms.Label ChordsModesText;
        private System.Windows.Forms.Button ChordsBackButton;
        private System.Windows.Forms.Button ChordsPlayModeButton;
        private System.Windows.Forms.Button ChordsTrainingModeButton;
        private System.Windows.Forms.Label NotesModesText;
        private System.Windows.Forms.Button NotesBackButton;
        private System.Windows.Forms.Button NotesPlayModeButton;
        private System.Windows.Forms.Button NotesTrainingModeButton;
        private System.Windows.Forms.Panel PlayPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGd;
        private System.Windows.Forms.Button btnFd;
        private System.Windows.Forms.Button btnCd;
        private System.Windows.Forms.Button btnAd;
        private System.Windows.Forms.Button btnDd;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Label infoLab;
        private System.Windows.Forms.Button PlayPanelExitBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox instrument_cb;
        private System.Windows.Forms.CheckBox difficulty_cb;
        private System.Windows.Forms.Button playsound_b;
        private System.Windows.Forms.Label tries_lab;
        private System.Windows.Forms.Label score_lab;
        private System.Windows.Forms.Label tr_l;
        private System.Windows.Forms.Label sc_l;
    }
}

