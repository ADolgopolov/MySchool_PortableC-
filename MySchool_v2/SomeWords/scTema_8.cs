using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_8
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 8\n";
            sContent_Info += "Sunny, windy, cool, raining...\n";
            sContent_Info += "Whole, most, each, every, same, other...\n";
            sContent_Info += "Both, neither, either, somebody, someone...";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_08\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "sunny", ukr: "сонячно", rus: "солнечно ", trk: "|ˈsʌni|"));
            DicArray.Add(new OneWord(eng: "windy", ukr: "вітряний", rus: "ветреный", trk: "|ˈwɪndi|"));
            DicArray.Add(new OneWord(eng: "cool", ukr: "прохолодний", rus: "прохладный", trk: "|kuːl|"));
            DicArray.Add(new OneWord(eng: "raining", ukr: "дощить", rus: "дождит", trk: "|ˈreɪnɪŋ|"));
            DicArray.Add(new OneWord(eng: "rainy", ukr: "дощовий", rus: "дождливый", trk: "|ˈreɪni|"));
            DicArray.Add(new OneWord(eng: "cloudy", ukr: "хмарно", rus: "облачно", trk: "|ˈklaʊdi|"));
            DicArray.Add(new OneWord(eng: "stuffy", ukr: "задушливий", rus: "душный", trk: "|ˈstʌfi|"));
            DicArray.Add(new OneWord(eng: "cold", ukr: "холодний", rus: "холодный", trk: "|kəʊld|"));
            DicArray.Add(new OneWord(eng: "snowing", ukr: "іде сніг", rus: "идет снег", trk: "|ˈsnəʊɪŋ|"));
            DicArray.Add(new OneWord(eng: "weather", ukr: "погода", rus: "погода", trk: "|ˈwɛðə|"));
            DicArray.Add(new OneWord(eng: "nasty", ukr: "неприємний", rus: "неприятный", trk: "|ˈnɑːsti|"));
            DicArray.Add(new OneWord(eng: "some", ukr: "дещо", rus: "некий", trk: "|sʌm|"));
            DicArray.Add(new OneWord(eng: "any", ukr: "будь-який", rus: "какой-угодно", trk: "|ˈeni|"));
            DicArray.Add(new OneWord(eng: "no", ukr: "ні, ніякий", rus: "нет, никакой", trk: "|nəʊ|"));
            DicArray.Add(new OneWord(eng: "none", ukr: "ніхто, ніщо", rus: "никто, ничто", trk: "|nʌn|"));
            DicArray.Add(new OneWord(eng: "all", ukr: "все", rus: "все", trk: "|ɔːl|"));
            DicArray.Add(new OneWord(eng: "whole", ukr: "цілий", rus: "целый", trk: "|həʊl|"));
            DicArray.Add(new OneWord(eng: "most", ukr: "більшість", rus: "большинство", trk: "|məʊst|"));
            DicArray.Add(new OneWord(eng: "each", ukr: "кожен", rus: "каждый", trk: "|iːtʃ|"));
            DicArray.Add(new OneWord(eng: "every", ukr: "кожен", rus: "каждый", trk: "|ˈɛvri|"));
            DicArray.Add(new OneWord(eng: "same", ukr: "той же", rus: "тот же", trk: "|seɪm|"));
            DicArray.Add(new OneWord(eng: "other", ukr: "інший", rus: "другой", trk: "|ˈʌðə|"));
            DicArray.Add(new OneWord(eng: "rest", ukr: "решта", rus: "остальное", trk: "|rest|"));
            DicArray.Add(new OneWord(eng: "own", ukr: "власний", rus: "собственный", trk: "|əʊn|"));
            DicArray.Add(new OneWord(eng: "one", ukr: "якийсь", rus: "этот же", trk: "|wʌn|"));
            DicArray.Add(new OneWord(eng: "both", ukr: "обидва", rus: "оба", trk: "|bəʊθ|"));
            DicArray.Add(new OneWord(eng: "neither", ukr: "ніхто, ніщо", rus: "никто, ништо", trk: "|ˈnʌɪðə|"));
            DicArray.Add(new OneWord(eng: "either", ukr: "один з двох", rus: "любой из двух ", trk: "|ˈʌɪðə|"));
            DicArray.Add(new OneWord(eng: "somebody", ukr: "хтось", rus: "кто-то", trk: "|ˈsʌmbədi|"));
            DicArray.Add(new OneWord(eng: "someone", ukr: "хтось", rus: "кто-то", trk: "|ˈsʌmwʌn|"));
            DicArray.Add(new OneWord(eng: "anybody", ukr: "хто завгодно", rus: "кто угодно", trk: "|ˈɛnɪbɒdi|"));
            DicArray.Add(new OneWord(eng: "anyone", ukr: "хто завгодно", rus: "кто угодно", trk: "|ˈɛnɪwʌn|"));
            DicArray.Add(new OneWord(eng: "everybody", ukr: "кожен", rus: "каждый", trk: "|ˈɛvrɪbɒdi|"));
            DicArray.Add(new OneWord(eng: "everyone", ukr: "кожен", rus: "каждый", trk: "|ˈɛvrɪwʌn|"));
            DicArray.Add(new OneWord(eng: "nobody", ukr: "ніхто", rus: "никто", trk: "|ˈnəʊbədi|"));
            DicArray.Add(new OneWord(eng: "something", ukr: "щось", rus: "что-то", trk: "|ˈsʌmθɪŋ|"));
            DicArray.Add(new OneWord(eng: "anything", ukr: "що завгодно", rus: "что угодно", trk: "|ˈɛnɪθɪŋ|"));
            DicArray.Add(new OneWord(eng: "everything", ukr: "все", rus: "все ", trk: "|ˈɛvrɪθɪŋ|"));
            DicArray.Add(new OneWord(eng: "nothing", ukr: "нічого", rus: "ничто", trk: "|ˈnʌθɪŋ|"));
            DicArray.Add(new OneWord(eng: "somewhere", ukr: "десь", rus: "где-то", trk: "|ˈsʌmwɛː|"));
            DicArray.Add(new OneWord(eng: "anywhere", ukr: "де завгодно", rus: "где угодно", trk: "|ˈɛnɪwɛː|"));
            DicArray.Add(new OneWord(eng: "everywhere", ukr: "скрізь", rus: "везде", trk: "|ˈɛvrɪwɛː|"));
            DicArray.Add(new OneWord(eng: "nowhere", ukr: "ніде", rus: "нигде", trk: "|ˈnəʊwɛː|"));
            // */
            return DicArray;
        }
    }
}
