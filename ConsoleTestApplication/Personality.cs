using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTestApplication
{
    public class Personality
    {
        public string PersonalityCode { get; set; }
        public string PersonalistyName { get; set; }
        public  ICode _code;
        public List<Personality> Personalities { get; set; } = new List<Personality>();

        public bool Extraversion { get; set; }
        public bool Sensing { get; set; }
        public bool Thinking { get; set; }
        public bool Judging { get; set; }
        public Personality(ICode code, bool extraversion, bool sensing, bool thinking, bool judging)

        {
            _code = code;
            Extraversion = extraversion;
            Sensing = sensing;
            Thinking = thinking;
            Judging = judging;

            Personalities.Add(new Personality { PersonalistyName = "Architekt", PersonalityCode = "INTJ" });
            Personalities.Add(new Personality { PersonalistyName = "Logik", PersonalityCode = "INTP" });
            Personalities.Add(new Personality { PersonalistyName = "Dowódca", PersonalityCode = "ENTJ" });
            Personalities.Add(new Personality { PersonalistyName = "Dyskutant", PersonalityCode = "ENTP" });
            Personalities.Add(new Personality { PersonalistyName = "Rzecznik", PersonalityCode = "INFJ" });
            Personalities.Add(new Personality { PersonalistyName = "Pośrednik", PersonalityCode = "INFP" });
            Personalities.Add(new Personality { PersonalistyName = "Protagonista", PersonalityCode = "ENFJ" });
            Personalities.Add(new Personality { PersonalistyName = "Działacz", PersonalityCode = "ENFP" });
            Personalities.Add(new Personality { PersonalistyName = "Logistyk", PersonalityCode = "ISTJ" });
            Personalities.Add(new Personality { PersonalistyName = "Obrońca", PersonalityCode = "ISFJ" });
            Personalities.Add(new Personality { PersonalistyName = "Wykonawca", PersonalityCode = "ESTJ" });
            Personalities.Add(new Personality { PersonalistyName = "Doradca", PersonalityCode = "ESFJ" });
            Personalities.Add(new Personality { PersonalistyName = "Wirtuoz", PersonalityCode = "ISTP" });
            Personalities.Add(new Personality { PersonalistyName = "Poszukiwacz przygód", PersonalityCode = "ISFP" });
            Personalities.Add(new Personality { PersonalistyName = "Przedsiębiorca", PersonalityCode = "ESTP" });
            Personalities.Add(new Personality { PersonalistyName = "Animator", PersonalityCode = "ESFP" });

        }
        public Personality()
        {

        }
        public string GetPersonality()
        {
            

            var code = _code.GenerateCode(Extraversion, Sensing, Thinking, Judging);
            var personality = Personalities.FirstOrDefault(p=>p.PersonalityCode==code)?.PersonalistyName;
            if(string.IsNullOrWhiteSpace(personality))
            {
                throw new Exception();
            }
            return personality;
        }
    }
}
