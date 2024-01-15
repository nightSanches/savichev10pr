using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace savichev10pr.Classes
{
    public class Russian : Human
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

        public Russian(string Name, string Img) : base(Name, Img)
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
            allPhrases.Add(new Phrase("Привет", @"E:\01 01\savichev10pr+\Voices\ru1.mp3"));
            allPhrases.Add(new Phrase("Как дела", @"E:\01 01\savichev10pr+\Voices\ru2.mp3"));
            allPhrases.Add(new Phrase("Меня зовут Глеб", @"E:\01 01\savichev10pr+\Voices\ru3.mp3"));
            return allPhrases;
        }
    }
}
