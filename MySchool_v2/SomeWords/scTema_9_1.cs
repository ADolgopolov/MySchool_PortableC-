using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_9_1
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 9.1\n";
            sContent_Info += "Make, do, go, come, work, need, show...\n";
            sContent_Info += "like, hate, live, life, think, believe...\n";
            sContent_Info += "feel, write, read, talk, tell, say, speak...";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_09\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "make", trk: "|ˈmeɪk|", ukr: "зробити, виготовляти", rus: "делать, производить", snd: "make.mp3"));
            DicArray.Add(new OneWord(eng: "made", trk: "|ˈmeɪd|", ukr: "зробити, виготовляти (V2, V3)", rus: "делать, производить (V2, V3)", snd: "made.mp3"));
            DicArray.Add(new OneWord(eng: "do", trk: "|duː|", ukr: "робити, виконувати", rus: "делать, выполнять", snd: "do.mp3"));
            DicArray.Add(new OneWord(eng: "did", trk: "|dɪd|", ukr: "робити, виконувати (V2)", rus: "делать, выполнять (V2)", snd: "did.mp3"));
            DicArray.Add(new OneWord(eng: "done", trk: "|dʌn|", ukr: "робити, виконувати (V3)", rus: "делать, выполнять (V3)", snd: "done.mp3"));
            DicArray.Add(new OneWord(eng: "go", trk: "|ɡəʊ|", ukr: "йти, їхати", rus: "идти, ехать", snd: "go.mp3"));
            DicArray.Add(new OneWord(eng: "went", trk: "|ˈwent|", ukr: "йти, їхати (V2)", rus: "идти, ехать (V2)", snd: "went.mp3"));
            DicArray.Add(new OneWord(eng: "gone", trk: "|ɡɒn|", ukr: "йти, їхати (V3)", rus: "идти, ехать (V3)", snd: "gone.mp3"));
            DicArray.Add(new OneWord(eng: "came", trk: "|keɪm|", ukr: "приходити (V2)", rus: "приходить (V2)", snd: "came.mp3"));
            DicArray.Add(new OneWord(eng: "come", trk: "|kʌm|", ukr: "приходити (V1, V3)", rus: "приходить (V1, V3)", snd: "come.mp3"));
            DicArray.Add(new OneWord(eng: "work", trk: "|ˈwɜːk|", ukr: "працювати", rus: "трудиться", snd: "work.mp3"));
            DicArray.Add(new OneWord(eng: "need", trk: "|niːd|", ukr: "мати потребу", rus: "нуждаться", snd: "need.mp3"));
            DicArray.Add(new OneWord(eng: "show", trk: "|ʃəʊ|", ukr: "показати", rus: "показывать", snd: "show.mp3"));
            DicArray.Add(new OneWord(eng: "showed", trk: "|ʃəʊd|", ukr: "показати (V2)", rus: "показывать (V2)", snd: "showed.mp3"));
            DicArray.Add(new OneWord(eng: "shown", trk: "|ʃəʊn|", ukr: "показати (V3)", rus: "показывать (V3)", snd: "shown.mp3"));
            DicArray.Add(new OneWord(eng: "watch", trk: "|wɒtʃ|", ukr: "спостерігати", rus: "наблюдать", snd: "watch.mp3"));
            DicArray.Add(new OneWord(eng: "look", trk: "|lʊk|", ukr: "подивитися", rus: "смотреть", snd: "look.mp3"));
            DicArray.Add(new OneWord(eng: "see", trk: "|ˈsiː|", ukr: "побачити", rus: "видеть", snd: "see.mp3"));
            DicArray.Add(new OneWord(eng: "saw", trk: "|ˈsɔː|", ukr: "побачити (V2)", rus: "видеть (V2)", snd: "saw.mp3"));
            DicArray.Add(new OneWord(eng: "seen", trk: "|ˈsiːn|", ukr: "побачити (V3)", rus: "видеть (V3)", snd: "seen.mp3"));
            DicArray.Add(new OneWord(eng: "listen", trk: "|ˈlɪsn|", ukr: "слухати", rus: "слушать", snd: "listen.mp3"));
            DicArray.Add(new OneWord(eng: "hear", trk: "|hɪə|", ukr: "чути", rus: "слышать", snd: "hear.mp3"));
            DicArray.Add(new OneWord(eng: "heard", trk: "|ˈhɝːd|", ukr: "чути (V2, V3)", rus: "слышать (V2, V3)", snd: "heard.mp3"));
            DicArray.Add(new OneWord(eng: "get", trk: "|ˈɡet|", ukr: "отримати", rus: "получать", snd: "get.mp3"));
            DicArray.Add(new OneWord(eng: "got", trk: "|ˈɡɒt|", ukr: "отримати (V2, V3)", rus: "получать (V2, V3)", snd: "got.mp3"));
            DicArray.Add(new OneWord(eng: "put", trk: "|ˈpʊt|", ukr: "покласти (V1, V2, V3)", rus: "положить (V1, V2, V3)", snd: "put.mp3"));
            DicArray.Add(new OneWord(eng: "take", trk: "|teɪk|", ukr: "брати", rus: "брать", snd: "take.mp3"));
            DicArray.Add(new OneWord(eng: "took", trk: "|tʊk|", ukr: "брати (V2)", rus: "брать (V2)", snd: "took.mp3"));
            DicArray.Add(new OneWord(eng: "taken", trk: "|ˈteɪkən|", ukr: "брати (V3)", rus: "брать (V3)", snd: "taken.mp3"));
            DicArray.Add(new OneWord(eng: "give", trk: "|ɡɪv|", ukr: "давати", rus: "давать", snd: "give.mp3"));
            DicArray.Add(new OneWord(eng: "gave", trk: "|ɡeɪv|", ukr: "давати (V2)", rus: "давать (V2)", snd: "gave.mp3"));
            DicArray.Add(new OneWord(eng: "given", trk: "|ˈɡɪv(ə)n|", ukr: "давати (V3)", rus: "давать (V3)", snd: "given.mp3"));
            DicArray.Add(new OneWord(eng: "love", trk: "|ˈlʌv|", ukr: "кохати", rus: "любить", snd: "love.mp3"));
            DicArray.Add(new OneWord(eng: "like", trk: "|ˈlaɪk|", ukr: "подобатися", rus: "нравиться", snd: "like.mp3"));
            DicArray.Add(new OneWord(eng: "hate", trk: "|heɪt|", ukr: "ненавидіти", rus: "ненавидеть", snd: "hate.mp3"));
            DicArray.Add(new OneWord(eng: "live", trk: "|lɪv|", ukr: "жити", rus: "жить", snd: "live.mp3"));
            // */
            return DicArray;
        }
    }
}
