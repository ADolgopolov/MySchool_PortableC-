using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_10_2
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 10.2\n";

            sContent_Info += "Leave, return, go by bus, go by car...\n";
            sContent_Info += "sleep, begin, finish, end, be on time...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_10\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "leave", trk: "|liːv|", ukr: "залишати", rus: "оставлять", snd: "leave.mp3"));
            DicArray.Add(new OneWord(eng: "left", trk: "|left|", ukr: "залишати (V2, V3)", rus: "оставлять (V2, V3)", snd: "left.mp3"));
            DicArray.Add(new OneWord(eng: "return", trk: "|rɪˈtəːn|", ukr: "повернутися", rus: "возвращаться", snd: "return.mp3"));
            DicArray.Add(new OneWord(eng: "go by bus", trk: "|ɡəʊ baɪ bʌs|", ukr: "їхати автобусом", rus: "ехать автобусом", snd: "go by bus.mp3"));
            DicArray.Add(new OneWord(eng: "go by car", trk: "|ɡəʊ baɪ kɑː|", ukr: "їхати на машині", rus: "ехать на машине", snd: "go by car.mp3"));
            DicArray.Add(new OneWord(eng: "go by metro", trk: "|ɡəʊ baɪ ˈmɛtrəʊ|", ukr: "їхати на метро", rus: "ехать на метро", snd: "go by metro.mp3"));
            DicArray.Add(new OneWord(eng: "go on foot", trk: "|ɡəʊ ɒn fʊt|", ukr: "йти пішки", rus: "идти пешком", snd: "go on foot.mp3"));
            DicArray.Add(new OneWord(eng: "walk", trk: "|wɔːk|", ukr: "гуляти пішки", rus: "гулять пешком", snd: "walk.mp3"));
            DicArray.Add(new OneWord(eng: "go shopping", trk: "|ɡəʊ ˈʃɑːpɪŋ| ", ukr: "відправитися за покупками", rus: "отправляться за покупками", snd: "go shopping.mp3"));
            DicArray.Add(new OneWord(eng: "pay", trk: "|peɪ|", ukr: "платити", rus: "платить", snd: "pay.mp3"));
            DicArray.Add(new OneWord(eng: "paid", trk: "|peɪd|", ukr: "платити (V2, V3)", rus: "платить (V2, V3)", snd: "paid.mp3"));
            DicArray.Add(new OneWord(eng: "buy", trk: "|baɪ|", ukr: "купити", rus: "купить", snd: "buy.mp3"));
            DicArray.Add(new OneWord(eng: "bought", trk: "|bɔːt|", ukr: "купити (V2, V3)", rus: "купить (V2, V3)", snd: "bought.mp3"));
            DicArray.Add(new OneWord(eng: "price", trk: "|prʌɪs|", ukr: "ціна", rus: "цена", snd: "price.mp3"));
            DicArray.Add(new OneWord(eng: "cost", trk: "|kɒst|", ukr: "коштувати (V1, V2, V3)", rus: "стоить (V1, V2, V3)", snd: "cost.mp3"));
            DicArray.Add(new OneWord(eng: "clean", trk: "|kliːn|", ukr: "чистий", rus: "чистый", snd: "clean.mp3"));
            DicArray.Add(new OneWord(eng: "rest", trk: "|rest|", ukr: "відпочинок", rus: "отдых", snd: "rest.mp3"));
            DicArray.Add(new OneWord(eng: "sleep", trk: "|sliːp|", ukr: "спати", rus: "спать", snd: "sleep.mp3"));
            DicArray.Add(new OneWord(eng: "slept", trk: "|slɛpt|", ukr: "спати (V2, V3)", rus: "спать (V2, V3)", snd: "slept.mp3"));
            DicArray.Add(new OneWord(eng: "begin", trk: "|bɪˈɡɪn|", ukr: "почати", rus: "начинать", snd: "begin.mp3"));
            DicArray.Add(new OneWord(eng: "began", trk: "|bɪˈɡan|", ukr: "почати (V2)", rus: "начинать (V2)", snd: "began.mp3"));
            DicArray.Add(new OneWord(eng: "begun", trk: "|bɪˈɡʌn|", ukr: "почати (V3)", rus: "начинать (V3)", snd: "begun.mp3"));
            DicArray.Add(new OneWord(eng: "finish", trk: "|ˈfɪnɪʃ|", ukr: "закінчити", rus: "заканчивать", snd: "finish.mp3"));
            DicArray.Add(new OneWord(eng: "end", trk: "|end|", ukr: "кінець", rus: "конец", snd: "end.mp3"));
            DicArray.Add(new OneWord(eng: "be on time", trk: "|bi ɒn ˈtaɪm|", ukr: "бути вчасно", rus: "быть вовремя", snd: "be on time.mp3"));
            DicArray.Add(new OneWord(eng: "be late", trk: "|bi leɪt|", ukr: "спізнитися", rus: "опоздать", snd: "be late.mp3"));
            DicArray.Add(new OneWord(eng: "which", trk: "|wɪtʃ|", ukr: "котрий", rus: "который", snd: "which.mp3"));
            DicArray.Add(new OneWord(eng: "who", trk: "|huː|", ukr: "хто", rus: "кто", snd: "who.mp3"));
            DicArray.Add(new OneWord(eng: "whom", trk: "|huːm|", ukr: "кого", rus: "кого", snd: "whom.mp3"));
            DicArray.Add(new OneWord(eng: "that", trk: "|ðæt|", ukr: "той, який", rus: "тот, который", snd: "that.mp3"));
            // */
            return DicArray;
        }
    }
}
