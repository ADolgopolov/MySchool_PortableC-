using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_10_1
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 10.1\n";

            sContent_Info += "Wake, get up, exercise, wash, shower, bath...\n";
            sContent_Info += "lunch, dinner, supper, meal, cook, eat, drink...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_10\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "wake", trk: "|nəʊz|", ukr: "прокидатися", rus: "просыпаться", snd: "wake.mp3"));
            DicArray.Add(new OneWord(eng: "woke", trk: "|wəʊk|", ukr: "прокидатися (V2)", rus: "просыпаться (V2)", snd: "woke.mp3"));
            DicArray.Add(new OneWord(eng: "woken", trk: "|ˈwəʊkən|", ukr: "прокидатися (V3)", rus: "просыпаться (V3)", snd: "woken.mp3"));
            DicArray.Add(new OneWord(eng: "get up", trk: "|ˈɡet ʌp|", ukr: "вставати", rus: "вставать", snd: "get up.mp3"));
            DicArray.Add(new OneWord(eng: "exercise", trk: "|ˈɛksəsʌɪz|", ukr: "вправи", rus: "упражнение", snd: "exercise.mp3"));
            DicArray.Add(new OneWord(eng: "wash", trk: "|wɒʃ|", ukr: "мити", rus: "мыть", snd: "wash.mp3"));
            DicArray.Add(new OneWord(eng: "shower", trk: "|ˈʃaʊə|", ukr: "душ", rus: "душ", snd: "shower.mp3"));
            DicArray.Add(new OneWord(eng: "bath", trk: "|bɑːθ|", ukr: "ванна", rus: "ванна", snd: "bath.mp3"));
            DicArray.Add(new OneWord(eng: "brush", trk: "|brʌʃ|", ukr: "щітка", rus: "щетка", snd: "brush.mp3"));
            DicArray.Add(new OneWord(eng: "comb", trk: "|kəʊm|", ukr: "розчісуватися", rus: "расчесывать", snd: "comb.mp3"));
            DicArray.Add(new OneWord(eng: "shave", trk: "|ʃeɪv|", ukr: "голитись", rus: "бриться", snd: "shave.mp3"));
            DicArray.Add(new OneWord(eng: "put on", trk: "|ˈpʊt ɒn|", ukr: "одягнути", rus: "надевать", snd: "put on.mp3"));
            DicArray.Add(new OneWord(eng: "take off", trk: "|ˈteɪkɒf|", ukr: "знімати", rus: "снимать", snd: "take off.mp3"));
            DicArray.Add(new OneWord(eng: "dress", trk: "|drɛs|", ukr: "одягатися", rus: "одеваться", snd: "dress.mp3"));
            DicArray.Add(new OneWord(eng: "wear", trk: "|weə|", ukr: "носити", rus: "носить", snd: "wear.mp3"));
            DicArray.Add(new OneWord(eng: "wore", trk: "|wɔː|", ukr: "носити (V2)", rus: "носить (V2)", snd: "wore.mp3"));
            DicArray.Add(new OneWord(eng: "worn", trk: "|wɔːn|", ukr: "носити (V3)", rus: "носить (V3)", snd: "worn.mp3"));
            DicArray.Add(new OneWord(eng: "breakfast", trk: "|ˈbrɛkfəst|", ukr: "сніданок", rus: "завтрак", snd: "breakfast.mp3"));
            DicArray.Add(new OneWord(eng: "lunch", trk: "|lʌn(t)ʃ|", ukr: "обід", rus: "обед", snd: "lunch.mp3"));
            DicArray.Add(new OneWord(eng: "dinner", trk: "|ˈdɪnə|", ukr: "вечеря, обід", rus: "ужин, обед", snd: "dinner.mp3"));
            DicArray.Add(new OneWord(eng: "supper", trk: "|ˈsʌpə|", ukr: "вечеря", rus: "ужин", snd: "supper.mp3"));
            DicArray.Add(new OneWord(eng: "meal", trk: "|miːl|", ukr: "їжа", rus: "еда", snd: "meal.mp3"));
            DicArray.Add(new OneWord(eng: "cook", trk: "|kʊk|", ukr: "готувати", rus: "готовить", snd: "cook.mp3"));
            DicArray.Add(new OneWord(eng: "eat", trk: "|iːt|", ukr: "їсти", rus: "есть", snd: "eat.mp3"));
            DicArray.Add(new OneWord(eng: "ate", trk: "|et|", ukr: "їсти (V2)", rus: "есть (V2)", snd: "ate.mp3"));
            DicArray.Add(new OneWord(eng: "eaten", trk: "|ˈiːtən|", ukr: "їсти (V3)", rus: "есть (V3)", snd: "eaten.mp3"));
            DicArray.Add(new OneWord(eng: "drink", trk: "|drɪŋk|", ukr: "пити", rus: "пить", snd: "drink.mp3"));
            DicArray.Add(new OneWord(eng: "drank", trk: "|draŋk|", ukr: "пити (V2)", rus: "пить (V2)", snd: "drank.mp3"));
            DicArray.Add(new OneWord(eng: "drunk", trk: "|drʌŋk|", ukr: "пити (V3)", rus: "пить (V3)", snd: "drunk.mp3"));
            DicArray.Add(new OneWord(eng: "hungry", trk: "|ˈhʌŋɡri|", ukr: "голодний", rus: "голодный", snd: "hungry.mp3"));
            DicArray.Add(new OneWord(eng: "thirsty", trk: "|ˈθəːsti|", ukr: "спраглий", rus: "испытующий жажду", snd: "thirsty.mp3"));
            // */
            return DicArray;
        }
    }
}
