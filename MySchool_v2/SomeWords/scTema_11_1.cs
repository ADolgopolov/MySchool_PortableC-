using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_11_1
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 11.1\n";

            sContent_Info += "Use, open, close, hang, bring, keep...\n";
            sContent_Info += "hold, wait, lose, look for, find, found...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_11\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "use", trk: "|ˈjuːs|", ukr: "використовувати", rus: "использовать", snd: "use.mp3"));
            DicArray.Add(new OneWord(eng: "open", trk: "|ˈəʊpən|", ukr: "відкривати", rus: "открыть", snd: "open.mp3"));
            DicArray.Add(new OneWord(eng: "close", trk: "|kləʊs|", ukr: "закрити", rus: "закрывать", snd: "close.mp3"));
            DicArray.Add(new OneWord(eng: "hang", trk: "|hæŋ|", ukr: "повісити", rus: "вешать", snd: "hang.mp3"));
            DicArray.Add(new OneWord(eng: "hung", trk: "|hʌŋ|", ukr: "повісити (V2, V3)", rus: "вешать (V2, V3)", snd: "hung.mp3"));
            DicArray.Add(new OneWord(eng: "bring", trk: "|brɪŋ|", ukr: "принести", rus: "приносить", snd: "bring.mp3"));
            DicArray.Add(new OneWord(eng: "brought", trk: "|brɔːt|", ukr: "принести (V2, V3)", rus: "приносить (V2, V3)", snd: "brought.mp3"));
            DicArray.Add(new OneWord(eng: "keep", trk: "|kiːp|", ukr: "тримати", rus: "держать", snd: "keep.mp3"));
            DicArray.Add(new OneWord(eng: "kept", trk: "|kept|", ukr: "тримати (V2, V3)", rus: "держать (V2, V3)", snd: "kept.mp3"));
            DicArray.Add(new OneWord(eng: "hold", trk: "|həʊld|", ukr: "утримувати", rus: "удерживать", snd: "hold.mp3"));
            DicArray.Add(new OneWord(eng: "held", trk: "|held|", ukr: "утримувати (V2, V3)", rus: "удерживать (V2, V3)", snd: "held.mp3"));
            DicArray.Add(new OneWord(eng: "wait", trk: "|weɪt|", ukr: "чекати", rus: "ждать", snd: "wait.mp3"));
            DicArray.Add(new OneWord(eng: "lose", trk: "|luːz|", ukr: "втрачати", rus: "терять", snd: "lose.mp3"));
            DicArray.Add(new OneWord(eng: "lost", trk: "|lɒst|", ukr: "втрачати (V2, V3)", rus: "терять (V2, V3)", snd: "lost.mp3"));
            DicArray.Add(new OneWord(eng: "look for", trk: "|lʊk fɔː|", ukr: "шукати", rus: "искать ", snd: "look for.mp3"));
            DicArray.Add(new OneWord(eng: "find", trk: "|faɪnd|", ukr: "знайти", rus: "находить", snd: "find.mp3"));
            DicArray.Add(new OneWord(eng: "found", trk: "|faʊnd|", ukr: "знайти (V2, V3)", rus: "находить (V2, V3)", snd: "found.mp3"));
            DicArray.Add(new OneWord(eng: "change", trk: "|tʃeɪn(d)ʒ|", ukr: "змінити", rus: "изменять", snd: "change.mp3"));
            DicArray.Add(new OneWord(eng: "rise", trk: "|raɪz|", ukr: "підніматися", rus: "подниматься", snd: "rise.mp3"));
            DicArray.Add(new OneWord(eng: "rose", trk: "|rəʊz|", ukr: "підніматися (V2)", rus: "подниматься (V2)", snd: "rose.mp3"));
            DicArray.Add(new OneWord(eng: "risen", trk: "|ˈrɪzən|", ukr: "підніматися (V3)", rus: "подниматься (V3)", snd: "risen.mp3"));
            DicArray.Add(new OneWord(eng: "fall", trk: "|fɔːl|", ukr: "падати", rus: "падать", snd: "fall.mp3"));
            DicArray.Add(new OneWord(eng: "fell", trk: "|fel|", ukr: "падати (V2)", rus: "падать (V2)", snd: "fell.mp3"));
            DicArray.Add(new OneWord(eng: "fallen", trk: "|ˈfɔːlən|", ukr: "падати (V3)", rus: "падать (V3)", snd: "fallen.mp3"));
            DicArray.Add(new OneWord(eng: "break", trk: "|breɪk|", ukr: "зломити", rus: "ломать", snd: "break.mp3"));
            DicArray.Add(new OneWord(eng: "broke", trk: "|brəʊk|", ukr: "зломити (V2)", rus: "ломать (V2)", snd: "broke.mp3"));
            DicArray.Add(new OneWord(eng: "broken", trk: "|ˈbrəʊk(ə)n|", ukr: "зломити (V3)", rus: "ломать (V3)", snd: "broken.mp3"));
            DicArray.Add(new OneWord(eng: "catch", trk: "|katʃ|", ukr: "виловити", rus: "ловить", snd: "catch.mp3"));
            DicArray.Add(new OneWord(eng: "caught", trk: "|kɔːt|", ukr: "виловити (V2, V3)", rus: "ловить (V2, V3)", snd: "caught.mp3"));
            DicArray.Add(new OneWord(eng: "spoil", trk: "|spɔɪl|", ukr: "зіпсувати", rus: "портить", snd: "spoil.mp3"));
            DicArray.Add(new OneWord(eng: "spoilt", trk: "|spɔɪlt|", ukr: "зіпсувати (V2, V3)", rus: "портить (V2, V3)", snd: "spoilt.mp3"));
            DicArray.Add(new OneWord(eng: "sit", trk: "|sɪt|", ukr: "сидіти", rus: "сидеть", snd: "sit.mp3"));
            DicArray.Add(new OneWord(eng: "sat", trk: "|sæt|", ukr: "сидіти (V2, V3)", rus: "сидеть (V2, V3)", snd: "sat.mp3"));
            DicArray.Add(new OneWord(eng: "lie", trk: "|laɪ|", ukr: "лежати", rus: "лежать", snd: "lie.mp3"));
            DicArray.Add(new OneWord(eng: "lay", trk: "|leɪ|", ukr: "лежати (V2)", rus: "лежать (V2)", snd: "lay.mp3"));
            DicArray.Add(new OneWord(eng: "lain", trk: "|leɪn|", ukr: "лежати (V3)", rus: "лежать (V3)", snd: "lain.mp3"));
            DicArray.Add(new OneWord(eng: "lay", trk: "|leɪ|", ukr: "покласти", rus: "класть, положить", snd: "lay.mp3"));
            DicArray.Add(new OneWord(eng: "laid", trk: "|leɪd|", ukr: "покласти (V2, V3)", rus: "класть, положить (V2, V3)", snd: "laid.mp3"));
            DicArray.Add(new OneWord(eng: "stand", trk: "|stand|", ukr: "стояти", rus: "стоять", snd: "stand.mp3"));
            DicArray.Add(new OneWord(eng: "stood", trk: "|stʊd|", ukr: "стояти (V2, V3)", rus: "стоять (V2, V3)", snd: "stood.mp3"));
            DicArray.Add(new OneWord(eng: "visit", trk: "|ˈvɪzɪt|", ukr: "візит", rus: "визит", snd: "visit.mp3"));
            DicArray.Add(new OneWord(eng: "meet", trk: "|miːt|", ukr: "зустрітися", rus: "встречаться", snd: "meet.mp3"));
            DicArray.Add(new OneWord(eng: "met", trk: "|met|", ukr: "зустрітися (V2, V3)", rus: "встречаться (V2, V3)", snd: "met.mp3"));
            // */
            return DicArray;
        }
    }
}
