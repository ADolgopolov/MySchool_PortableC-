using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_15_2
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 15.2\n";

            sContent_Info += "Law, crime, break, criminal, thief...\n";
            sContent_Info += "victim, kidnap, ransom, guilty, suspect...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_15_2\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "law", trk: "|lɔː|", ukr: "закон", rus: "закон", snd: "law.mp3"));
            DicArray.Add(new OneWord(eng: "crime", trk: "|krʌɪm|", ukr: "злочин", rus: "преступление", snd: "crime.mp3"));
            DicArray.Add(new OneWord(eng: "break", trk: "|breɪk|", ukr: "перерва", rus: "перерыв", snd: "break.mp3"));
            DicArray.Add(new OneWord(eng: "criminal", trk: "|ˈkrɪmɪn(ə)l|", ukr: "злочинець", rus: "преступник", snd: "criminal.mp3"));
            DicArray.Add(new OneWord(eng: "thief", trk: "|θiːf|", ukr: "злодій", rus: "вор", snd: "thief.mp3"));
            DicArray.Add(new OneWord(eng: "thieves", trk: "|θiːvz|", ukr: "злодії", rus: "воры", snd: "thieves.mp3"));
            DicArray.Add(new OneWord(eng: "steal", trk: "|stiːl|", ukr: "вкрасти", rus: "воровать", snd: "steal.mp3"));
            DicArray.Add(new OneWord(eng: "stole", trk: "|stəʊl|", ukr: "вкрасти (V2)", rus: "воровать (V2)", snd: "stole.mp3"));
            DicArray.Add(new OneWord(eng: "stolen", trk: "|ˈstəʊlən|", ukr: "вкрасти (V3)", rus: "воровать (V3)", snd: "stolen.mp3"));
            DicArray.Add(new OneWord(eng: "rob", trk: "|rɒb|", ukr: "грабувати", rus: "грабить", snd: "rob.mp3"));
            DicArray.Add(new OneWord(eng: "robber", trk: "|ˈrɒbə|", ukr: "розбійник", rus: "разбойник", snd: "robber.mp3"));
            DicArray.Add(new OneWord(eng: "robbery", trk: "|ˈrɒb(ə)ri|", ukr: "пограбування", rus: "ограбление", snd: "robbery.mp3"));
            DicArray.Add(new OneWord(eng: "cheat", trk: "|tʃiːt|", ukr: "обманювати", rus: "обманывать", snd: "cheat.mp3"));
            DicArray.Add(new OneWord(eng: "kill", trk: "|kɪl|", ukr: "вбити", rus: "убивать", snd: "kill.mp3"));
            DicArray.Add(new OneWord(eng: "murder", trk: "|ˈməːdə|", ukr: "вбивство", rus: "убийство", snd: "murder.mp3"));
            DicArray.Add(new OneWord(eng: "murderer", trk: "|ˈməːd(ə)rə|", ukr: "вбивця", rus: "убийца", snd: "murderer.mp3"));
            DicArray.Add(new OneWord(eng: "gun", trk: "|ɡʌn|", ukr: "пістолет", rus: "пистолет", snd: "gun.mp3"));
            DicArray.Add(new OneWord(eng: "shoot", trk: "|ʃuːt|", ukr: "стріляти", rus: "стрелять", snd: "shoot.mp3"));
            DicArray.Add(new OneWord(eng: "shot", trk: "|ʃɒt|", ukr: "стріляти (V2, V3)", rus: "стрелять (V2, V3)", snd: "shot.mp3"));
            DicArray.Add(new OneWord(eng: "victim", trk: "|ˈvɪktɪm|", ukr: "жертва", rus: "жертва", snd: "victim.mp3"));
            DicArray.Add(new OneWord(eng: "kidnap", trk: "|ˈkɪdnap|", ukr: "викрадати людей", rus: "похищать людей", snd: "kidnap.mp3"));
            DicArray.Add(new OneWord(eng: "ransom", trk: "|ˈrans(ə)m|", ukr: "викуп", rus: "викуп", snd: "ransom.mp3"));
            DicArray.Add(new OneWord(eng: "guilty", trk: "|ˈɡɪlti|", ukr: "винний", rus: "виновный", snd: "guilty.mp3"));
            DicArray.Add(new OneWord(eng: "suspect", trk: "|səˈspekt|", ukr: "підозрюваний", rus: "подозреваемый", snd: "suspect.mp3"));
            DicArray.Add(new OneWord(eng: "suspicion", trk: "|səˈspɪʃ(ə)n|", ukr: "підозри", rus: "подозрение", snd: "suspicion.mp3"));
            DicArray.Add(new OneWord(eng: "accuse", trk: "|əˈkjuːz|", ukr: "звинуватити", rus: "обвинять", snd: "accuse.mp3"));
            DicArray.Add(new OneWord(eng: "accusation", trk: "|akjʊˈzeɪʃ(ə)n|", ukr: "звинувачення", rus: "обвинение", snd: "accusation.mp3"));
            DicArray.Add(new OneWord(eng: "court", trk: "|kɔːt|", ukr: "суд", rus: "суд", snd: "court.mp3"));
            DicArray.Add(new OneWord(eng: "punish", trk: "|ˈpʌnɪʃ|", ukr: "покарати", rus: "наказать", snd: "punish.mp3"));
            DicArray.Add(new OneWord(eng: "punishment", trk: "|ˈpʌnɪʃm(ə)nt|", ukr: "покарання", rus: "наказание", snd: "punishment.mp3"));
            DicArray.Add(new OneWord(eng: "prison", trk: "|ˈprɪz(ə)n|", ukr: "в'язниця", rus: "тюрьма", snd: "prison.mp3"));
            DicArray.Add(new OneWord(eng: "prisoner", trk: "|ˈprɪz(ə)nə|", ukr: "в'язень", rus: "заключенный", snd: "prisoner.mp3"));
            DicArray.Add(new OneWord(eng: "police station", trk: "|pəˈliːs ˈsteɪʃ(ə)n|", ukr: "поліцейська дільниця", rus: "полицейский участок", snd: "police station.mp3"));
            // */
            return DicArray;
        }
    }
}
