using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_15_3
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 15.3\n";

            sContent_Info += "Accident, disaster, danger...\n";
            sContent_Info += "burn, flood, earthquake, destroy...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_15_3\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "accident", trk: "|ˈaksɪd(ə)nt|", ukr: "нещасний випадок", rus: "несчастный случай", snd: "accident.mp3"));
            DicArray.Add(new OneWord(eng: "disaster", trk: "|dɪˈzɑːstə|", ukr: "катастрофа", rus: "катастрофа", snd: "disaster.mp3"));
            DicArray.Add(new OneWord(eng: "danger", trk: "|ˈdeɪn(d)ʒə|", ukr: "небезпека", rus: "опасность", snd: "danger.mp3"));
            DicArray.Add(new OneWord(eng: "dangerous", trk: "|ˈdeɪn(d)ʒ(ə)rəs|", ukr: "небезпечний", rus: "опасный", snd: "dangerous.mp3"));
            DicArray.Add(new OneWord(eng: "emergency", trk: "|ɪˈməːdʒ(ə)nsi|", ukr: "надзвичайна ситуація", rus: "экстренная ситуация", snd: "emergency.mp3"));
            DicArray.Add(new OneWord(eng: "crash", trk: "|kraʃ|", ukr: "авария", rus: "авария", snd: "crash.mp3"));
            DicArray.Add(new OneWord(eng: "rule", trk: "|ruːl|", ukr: "правило", rus: "правило", snd: "rule.mp3"));
            DicArray.Add(new OneWord(eng: "fine", trk: "|faɪn|", ukr: "штраф", rus: "штраф", snd: "fine.mp3"));
            DicArray.Add(new OneWord(eng: "injure", trk: "|ˈɪndʒə|", ukr: "пошкодити", rus: "ранить", snd: "injure.mp3"));
            DicArray.Add(new OneWord(eng: "injury", trk: "|ˈɪn(d)ʒ(ə)ri|", ukr: "травма", rus: "травма", snd: "injury.mp3"));
            DicArray.Add(new OneWord(eng: "ambulance", trk: "|ˈambjʊl(ə)ns|", ukr: "швидка допомога", rus: "скорая помощь", snd: "ambulance.mp3"));
            DicArray.Add(new OneWord(eng: "first aid", trk: "|fəːst eɪd|", ukr: "перша допомога", rus: "первая помощь", snd: "first aid.mp3"));
            DicArray.Add(new OneWord(eng: "fire", trk: "|ˈfaɪə|", ukr: "вогонь, пожежа", rus: "огонь, пожар", snd: "fire.mp3"));
            DicArray.Add(new OneWord(eng: "fireman", trk: "|ˈfʌɪəmən|", ukr: "пожежник", rus: "пожарный", snd: "fireman.mp3"));
            DicArray.Add(new OneWord(eng: "burn", trk: "|bɜːn|", ukr: "горіти", rus: "гореть", snd: "burn.mp3"));
            DicArray.Add(new OneWord(eng: "flood", trk: "|flʌd|", ukr: "повінь", rus: "наводнение", snd: "flood.mp3"));
            DicArray.Add(new OneWord(eng: "earthquake", trk: "|ˈəːθkweɪk|", ukr: "землетрус", rus: "землетрясение", snd: "earthquake.mp3"));
            DicArray.Add(new OneWord(eng: "destroy", trk: "|dɪˈstrɔɪ|", ukr: "знищити", rus: "уничтожать", snd: "destroy.mp3"));
            DicArray.Add(new OneWord(eng: "destruction", trk: "|dɪˈstrʌkʃ(ə)n|", ukr: "руйнування", rus: "разрушение", snd: "destruction.mp3"));
            DicArray.Add(new OneWord(eng: "damage", trk: "|ˈdamɪdʒ|", ukr: "шкода", rus: "урон", snd: "damage.mp3"));
            DicArray.Add(new OneWord(eng: "report", trk: "|rɪˈpɔːt|", ukr: "звіт", rus: "отчет", snd: "report.mp3"));
            DicArray.Add(new OneWord(eng: "allege", trk: "|əˈlɛdʒ|", ukr: "стверджувати", rus: "утверждать", snd: "allege.mp3"));

            // */
            return DicArray;
        }
    }
}
