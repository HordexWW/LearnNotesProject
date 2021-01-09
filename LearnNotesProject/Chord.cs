using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnNotesProject
{
    public class Chord
    {
        private string name;
        private List<Note> notes;

        public Chord()
        {

        }

        public Chord(string name, List<Note> notes)
        {
            this.name = name;
            this.notes = notes;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<Note> Notes
        {
            get => notes;
            set => notes = value;
        }
    }
}
