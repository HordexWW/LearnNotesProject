using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnNotesProject
{
    public class Note
    {
        private string name;

        public Note()
        {

        }

        public Note(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
