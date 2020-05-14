using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibraryy.Model
{
    public static class SoundManager //static is saying there will only be one instance of this class. it's a shared instance.
    {
        //create a new method for allsounds
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = getSounds();
            sounds.Clear();
            allSounds.ForEach(sound => sounds.Add(sound));
        }

        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory category)
        {
            var allSounds = getSounds();//added all sounds
            var filteredSounds = allSounds.Where(sound => sound.Category == category).ToList();//filtered sounds to category
            sounds.Clear();
            filteredSounds.ForEach(sound => sounds.Add(sound));//lambda expression

        }

        private static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();
            sounds.Add(new Sound("AcousticGuitar", SoundCategory.Relax));
            sounds.Add(new Sound("Harp", SoundCategory.Relax));
            sounds.Add(new Sound("Piano", SoundCategory.Relax));
            sounds.Add(new Sound("Violin", SoundCategory.Relax));
            sounds.Add(new Sound("Cat", SoundCategory.Relax));
            sounds.Add(new Sound("electric", SoundCategory.Upbeat));
            sounds.Add(new Sound("Spring", SoundCategory.Upbeat));
            sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Sound("LOL", SoundCategory.Taunts));
            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            return sounds;
        }
    }
}
