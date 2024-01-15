using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace savichev10pr.Classes
{
    public class English : Human
    {
        private List<Phrase> Phrases { get; set; }

        private int stepAudio;

        private int StepAudio
        {
            get { return stepAudio; }
            set
            {
                stepAudio = value;
                if (stepAudio > Phrases.Count - 1)
                    stepAudio = 0;
            }
        }

        public English(string Name, string Img) : base(Name, Img)
        {
            this.Phrases = AllPhrases();
        }

        public override void Speak(Label Phrase)
        {
            Phrase.Content = Phrases[StepAudio]._Phrase;
            MainWindow.MediaPlayer.Open(new Uri(Phrases[StepAudio].Src));
            MainWindow.MediaPlayer.Play();
            StepAudio++;
        }

        public static List<Phrase> AllPhrases()
        {
            List<Phrase> allPhrases = new List<Phrase>();
            allPhrases.Add(new Phrase("Hellp", @"E:\01 01\savichev10pr+\Voices\en1.mp3"));
            allPhrases.Add(new Phrase("How are you", @"E:\01 01\savichev10pr+\Voices\en2.mp3"));
            allPhrases.Add(new Phrase("My name is Gleb", @"E:\01 01\savichev10pr+\Voices\en3.mp3"));
            return allPhrases;
        }
    }
}
