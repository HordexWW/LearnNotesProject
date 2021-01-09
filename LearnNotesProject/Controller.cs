using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Media;

namespace LearnNotesProject
{
    public static class Controller
    {
        public static List<Note> notes_list = new List<Note>();
        public static List<Chord> chord_list = new List<Chord>();
        public static string exepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        public static string abspath = System.IO.Path.GetDirectoryName(exepath);
        public static string soundpath;
        public static MainForm form;
        public static int score = 0;
        public static int tries_left = 0;
        public static string instrument = "piano";
        public static bool difficulty;

        public static void Initialize()
        {
            notes_list.Add(new Note("C"));
            notes_list.Add(new Note("C#"));
            notes_list.Add(new Note("D"));
            notes_list.Add(new Note("D#"));
            notes_list.Add(new Note("E"));
            notes_list.Add(new Note("F"));
            notes_list.Add(new Note("F#"));
            notes_list.Add(new Note("G"));
            notes_list.Add(new Note("G#"));
            notes_list.Add(new Note("A"));
            notes_list.Add(new Note("A#"));
            notes_list.Add(new Note("B"));

            using (StreamReader sr = new StreamReader(abspath + "/Resources/Chords.txt"))
            {
                string [] s;
                try
                {
                    while (!sr.EndOfStream)
                    {
                        s = sr.ReadLine().Split(':');
                        string chord = s[0];
                        string[] notes = s[1].Split(',');

                        List<Note> list = new List<Note>();

                        foreach (string str in notes)
                        {
                            list.Add(notes_list.Single(x => x.Name == str));
                        }

                        chord_list.Add(new Chord(chord, list));

                    }
                }
                catch
                {
                    return;
                }
                
            }
        }

        public static void StartGame(string gametype, string mode)
        {
            if (gametype == "notesgame" && mode == "training")
                NotesTraining();
            else if (gametype == "notesgame" && mode == "game")
            {
                tries_left = 12;
                NotesGame();
            }
            else if (gametype == "chordsgame" && mode == "training")
                ChordsTraining();
            else
            {
                tries_left = 20;
                ChordsGame();
            }
        }

        public static void NotesTraining()
        {
            List<Note> used = new List<Note>();
            form.SetMessage("Начало тренировки");
            Thread.Sleep(2000);
            while(used.Count != 12)
            {
                form.SetMessage("");
                int index = SetIndex(true);
                while (used.Contains(notes_list[index]))
                {
                    index = SetIndex(true);
                }

                used.Add(notes_list[index]);
                PlaySound();
                while(form.chosen_note != notes_list[index].Name)
                {
                    while (!form.nextstep)
                    {
                        continue;
                    }

                    if (form.chosen_note != notes_list[index].Name)
                    {
                        form.SetMessage("Неверный ответ.");
                    }
                    else 
                    {
                        form.SetMessage("Правильный ответ.");
                    }
                }

                Thread.Sleep(2000);
                form.SetMessage("");
            }

            form.SetMessage("Тренировка окончена.");
            Thread.Sleep(2000);
            form.ReturnToMenu();
        }

        public static void NotesGame()
        {
            List<Note> used = new List<Note>();
            form.SetMessage("Начало игры"); 
            Thread.Sleep(2000);
            while (used.Count != 12)
            {
                form.SetMessage("");
                int index = SetIndex(true); ;

                while (used.Contains(notes_list[index]) || index == -1)
                {
                    index = SetIndex(true);
                }

                used.Add(notes_list[index]);
                PlaySound();
                form.UpdateStats(score, tries_left);
                while (form.chosen_note != notes_list[index].Name)
                {
                    if (tries_left == 0)
                        break;
                    while (!form.nextstep)
                    {
                        continue;
                    }

                    if (form.chosen_note != notes_list[index].Name)
                    {
                        form.SetMessage("Неверный ответ.\nПопробуйте еще.");
                        tries_left--;
                        form.UpdateStats(score, tries_left);
                        Thread.Sleep(2000);
                        form.SetMessage("");
                    }
                    else
                    {
                        form.SetMessage("Правильный ответ.");
                        score += 10;
                    }
                }
                form.UpdateStats(score,tries_left);

                if (tries_left == 0)
                    break;

            }

            form.SetMessage("Игра окончена.\nРезультат: " + score + " очков.\nНеправильных ответов: " + (12 - tries_left));
            score = 0;
            form.UpdateStats(score, tries_left);
            Thread.Sleep(5000);
            form.ReturnToMenu();
        }

        public static void ChordsTraining() 
        {
            List<Chord> used = new List<Chord>();
            form.SetMessage("Начало тренировки");
            Thread.Sleep(2000);
            while (used.Count != 10)
            {
                form.SetMessage("");
                int index = SetIndex(false);

                while (used.Contains(chord_list[index]) || index == -1)
                {
                    index = SetIndex(false);
                }

                used.Add(chord_list[index]);
                List<Note> right_notes = new List<Note>();
                int cntr = 0;
                PlaySound();
                while (cntr != chord_list[index].Notes.Count)
                {
                    while (!form.nextstep)
                    {
                        continue;
                    }

                    if (instrument == "piano") //если инструмент меняется во время игры
                        soundpath = abspath + "/Resources/Piano/Chords/" + chord_list[index].Name + ".wav";
                    else
                        soundpath = abspath + "/Resources/Guitar/Chords/" + chord_list[index].Name + ".wav";

                    Note chosen = notes_list.Single(x => x.Name == form.chosen_note);
                    if (right_notes.Contains(chosen))
                        continue;

                    if (!chord_list[index].Notes.Contains(chosen))
                    {
                        form.SetMessage("Неверная нота");
                    }
                    else
                    {
                        form.SetMessage("Верная нота");
                        right_notes.Add(chosen);
                        cntr++;
                    }
                    Thread.Sleep(2000);
                    form.SetMessage("");
                }
                form.SetMessage("Правильный ответ");

                Thread.Sleep(2000);
            }

            form.SetMessage("Тренировка окончена");
            Thread.Sleep(2000);
            form.ReturnToMenu();
        }

        public static void ChordsGame()
        {
            List<Chord> used = new List<Chord>();
            form.SetMessage("Начало игры");
            Thread.Sleep(2000);
            while (used.Count != 20)
            {
                form.SetMessage("");
                int index = SetIndex(false);

                while (used.Contains(chord_list[index]) || index == -1)
                {
                    index = SetIndex(false);
                }

                used.Add(chord_list[index]);
                List<Note> right_notes = new List<Note>();
                int cntr = 0;
                PlaySound();
                while (cntr != chord_list[index].Notes.Count)
                {
                    while (!form.nextstep)
                    {
                        continue;
                    }

                    if (instrument == "piano") //если инструмент меняется во время игры
                        soundpath = abspath + "/Resources/Piano/Chords/" + chord_list[index].Name + ".wav";
                    else
                        soundpath = abspath + "/Resources/Guitar/Chords/" + chord_list[index].Name + ".wav";

                    if (tries_left == 0)
                        break;

                    Note chosen = notes_list.Single(x => x.Name == form.chosen_note);
                    if (right_notes.Contains(chosen))
                        continue;

                    if (!chord_list[index].Notes.Contains(chosen))
                    {
                        form.SetMessage("Неверная нота");
                        tries_left--;
                    }
                    else
                    {
                        form.SetMessage("Верная нота");
                        right_notes.Add(chosen);
                        cntr++;
                        score += 10;
                    }
                    form.UpdateStats(score, tries_left);
                    Thread.Sleep(2000);
                    form.SetMessage("");
                }
                if (tries_left == 0)
                {
                    break;
                }
                else
                {
                    score += 20;
                    form.SetMessage("Правильный ответ");
                    form.UpdateStats(score, tries_left);
                }

                Thread.Sleep(2000);
            }

            form.SetMessage("Игра окончена.\nРезультат: " + score + " очков.\nНеправильных ответов: " + (12 - tries_left));
            score = 0;
            form.UpdateStats(score, tries_left);
            Thread.Sleep(5000);
            form.ReturnToMenu();
        }

        public static void PlaySound()
        {
            SoundPlayer player = new SoundPlayer(soundpath);
            player.Play();
        }

        public static MainForm Parent
        {
            set => form = value;
            get => form;
        }

        public static int SetIndex(bool notesgame)
        {
            int index;
            if (notesgame)
            {
                if (!difficulty) //проверка что выбран простой режим
                {
                    index = RandGen.Generate(0, 12);
                    soundpath = abspath + "/Resources/Piano/SmallOctave/" + notes_list[index].Name + ".wav";
                }
                else //если выбран усложненный режим, то берется нота одна из трех октав
                {
                    index = RandGen.Generate(0, 12);
                    int folder_choice = RandGen.Generate(0, 3);
                    if (folder_choice == 0)
                    {
                        soundpath = abspath + "/Resources/Piano/SmallOctave/" + notes_list[index].Name + ".wav";
                    }
                    else if (folder_choice == 1)
                        soundpath = abspath + "/Resources/Piano/FirstOctave/" + notes_list[index].Name + ".wav";
                    else
                        soundpath = abspath + "/Resources/Piano/SecondOctave/" + notes_list[index].Name + ".wav";
                }
            }
            else
            {
                if (!difficulty) //проверка что выбран простой режим
                {
                    index = RandGen.Generate(0, 23);
                }
                else //если выбран усложненный режим, то может выпасть септаккорд
                {
                    index = RandGen.Generate(0, 30);
                }

                if (instrument == "piano")
                    soundpath = abspath + "/Resources/Piano/Chords/" + chord_list[index].Name + ".wav";
                else
                    soundpath = abspath + "/Resources/Guitar/Chords/" + chord_list[index].Name + ".wav";
            }

            return index;
        }
    }
}
