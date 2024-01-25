using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaesenToolkit.Models
{
    internal class Note
    {
        public int Id { get; set; }
        public string noteContext { get; set; }

        public Note(int id, string noteContext) 
        {
            this.Id = id;
            this.noteContext = noteContext;
        }
    }
}
