using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace P057.Speech_Synthesizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer robot = new SpeechSynthesizer();
            robot.SelectVoiceByHints(VoiceGender.Female);
            robot.Volume = 50;
            robot.Rate = 0; //-10 to 10

            //robot.Speak("Hello what is your name");
            robot.SpeakAsync("Hello what is your name");
            Console.WriteLine("Hello what is your name");
            var name = Console.ReadLine();

            //robot.Speak($"Your name is {name}");
            robot.SpeakAsync($"Your name is {name}");
            Console.WriteLine($"Your name is {name}");

            Console.ReadLine();

            //writing the wave file 
            //robot.SetOutputToWaveFile("Complete.wav");
            //robot.Speak("the applications is complete");
        }
    }
}
