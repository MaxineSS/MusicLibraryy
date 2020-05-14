using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibraryy.Model
{
    public class MenuItem
    {
        //create two properties
        public string IconFile { get; set; }

        //calls sound category enum
        public SoundCategory Category { get; set; }
    }
}