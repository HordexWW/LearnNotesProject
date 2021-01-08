
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.NotesButton = new System.Windows.Forms.Button();
            this.ChordsButton = new System.Windows.Forms.Button();
            this.ApplicationNameText = new System.Windows.Forms.Label();
            this.NotesModesPanel = new System.Windows.Forms.Panel();
            this.NotesBackButton = new System.Windows.Forms.Button();
            this.NotesPlayModeButton = new System.Windows.Forms.Button();
            this.NotesTrainingModeButton = new System.Windows.Forms.Button();
            this.NotesModesText = new System.Windows.Forms.Label();
            this.ChordsModesPanel = new System.Windows.Forms.Panel();
            this.ChordsModesText = new System.Windows.Forms.Label();
            this.ChordsBackButton = new System.Windows.Forms.Button();
            this.ChordsPlayModeButton = new System.Windows.Forms.Button();
            this.ChordsTrainingModeButton = new System.Windows.Forms.Button();
            this.MainMenuPanel.SuspendLayout();
            this.NotesModesPanel.SuspendLayout();
            this.ChordsModesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.ApplicationNameText);
            this.MainMenuPanel.Controls.Add(this.ExitButton);
            this.MainMenuPanel.Controls.Add(this.NotesButton);
            this.MainMenuPanel.Controls.Add(this.ChordsButton);
            this.MainMenuPanel.Location = new System.Drawing.Point(10, 13);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(386, 365);
            this.MainMenuPanel.TabIndex = 0;
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
            // ChordsModesPanel
            // 
            this.ChordsModesPanel.Controls.Add(this.ChordsModesText);
            this.ChordsModesPanel.Controls.Add(this.ChordsBackButton);
            this.ChordsModesPanel.Controls.Add(this.ChordsPlayModeButton);
            this.ChordsModesPanel.Controls.Add(this.ChordsTrainingModeButton);
            this.ChordsModesPanel.Location = new System.Drawing.Point(10, 13);
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 390);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.ChordsModesPanel);
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
    }
}

