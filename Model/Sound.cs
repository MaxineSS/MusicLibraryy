using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibraryy.Model
{
    //enum is not a collection because its a CHOICE. You have to choose one.
    public enum SoundCategory
    {
        Relax,
        Upbeat,
        Taunts,
        Warnings
    }
    public class Sound
    {

        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public Sound(string name, SoundCategory category)
        {
            Name = name;
            Category = category;
            AudioFile = $"/Assets/Audio/{category}/{name}.wav";
            ImageFile = $"/Assets/Images/{category}/{name}.png";
        }  
        //need to create SoundManager class so we can instantiate Sound and give it to UI to bind to
    }
}
