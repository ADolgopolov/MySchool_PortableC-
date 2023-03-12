using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_12_2
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 12.2\n";

            sContent_Info += "Forever, now, then, soon, suddenly...\n";
            sContent_Info += "together, alone, much / a lot, a little...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_12\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "forever", trk: "|fəˈrɛvə|", ukr: "назавжди", rus: "навсегда", snd: "forever.mp3"));
            DicArray.Add(new OneWord(eng: "now", trk: "|naʊ|", ukr: "зараз", rus: "сейчас", snd: "now.mp3"));
            DicArray.Add(new OneWord(eng: "then", trk: "|ðen|", ukr: "потім", rus: "потом", snd: "then.mp3"));
            DicArray.Add(new OneWord(eng: "soon", trk: "|suːn|", ukr: "скоро", rus: "скоро", snd: "soon.mp3"));
            DicArray.Add(new OneWord(eng: "suddenly", trk: "|ˈsʌd(ə)nli|", ukr: "раптом", rus: "внезапно", snd: "suddenly.mp3"));
            DicArray.Add(new OneWord(eng: "unexpectedly", trk: "|ˌʌnɪkˈspektɪdli|", ukr: "несподівано", rus: "неожиданно ", snd: "unexpectedly.mp3"));
            DicArray.Add(new OneWord(eng: "well", trk: "|wel|", ukr: "добре", rus: "хорошо", snd: "well.mp3"));
            DicArray.Add(new OneWord(eng: "fast", trk: "|fɑːst|", ukr: "швидко", rus: "быстро", snd: "fast.mp3"));
            DicArray.Add(new OneWord(eng: "hard", trk: "|hɑːd|", ukr: "важко", rus: "тяжело", snd: "hard.mp3"));
            DicArray.Add(new OneWord(eng: "nearly", trk: "|ˈnɪəli|", ukr: "майже", rus: "почти", snd: "nearly.mp3"));
            DicArray.Add(new OneWord(eng: "hardly", trk: "|ˈhɑːdli|", ukr: "навряд чи", rus: "вряд ли", snd: "hardly.mp3"));
            DicArray.Add(new OneWord(eng: "even", trk: "|ˈiːvən|", ukr: "навіть", rus: "даже", snd: "even.mp3"));
            DicArray.Add(new OneWord(eng: "almost", trk: "|ˈɔːlməʊst|", ukr: "майже", rus: "почти", snd: "almost.mp3"));
            DicArray.Add(new OneWord(eng: "only", trk: "|ˈəʊnli|", ukr: "тільки", rus: "только", snd: "only.mp3"));
            DicArray.Add(new OneWord(eng: "together", trk: "|təˈɡɛðə|", ukr: "разом", rus: "вместе", snd: "together.mp3"));
            DicArray.Add(new OneWord(eng: "alone", trk: "|əˈləʊn|", ukr: "поодинці", rus: "в одиночестве", snd: "alone.mp3"));
            DicArray.Add(new OneWord(eng: "much", trk: "|ˈmʌtʃ|", ukr: "багато", rus: "много", snd: "much.mp3"));
            DicArray.Add(new OneWord(eng: "a lot", trk: "|lɒt|", ukr: "велика кількість", rus: "большое количество", snd: "a lot.mp3"));
            DicArray.Add(new OneWord(eng: "a little", trk: "|ˈlɪt(ə)l|", ukr: "трішки", rus: "мало", snd: "a little.mp3"));
            DicArray.Add(new OneWord(eng: "at last", trk: "|æt lɑːst|", ukr: "нарешті", rus: "наконец ", snd: "at last.mp3"));
            DicArray.Add(new OneWord(eng: "finally", trk: "|ˈfʌɪnəli|", ukr: "нарешті", rus: "окончательно", snd: "finally.mp3"));
            DicArray.Add(new OneWord(eng: "just", trk: "|dʒəst|", ukr: "щойно", rus: "только что", snd: "just.mp3"));
            DicArray.Add(new OneWord(eng: "also", trk: "|ˈɔːlsəʊ|", ukr: "також", rus: "также", snd: "also.mp3"));
            DicArray.Add(new OneWord(eng: "as well", trk: "|æz wel|", ukr: "так само", rus: "также", snd: "as well.mp3"));
            DicArray.Add(new OneWord(eng: "too", trk: "|tuː|", ukr: "теж", rus: "тоже", snd: "too.mp3"));
            DicArray.Add(new OneWord(eng: "either", trk: "|ˈʌɪðə|", ukr: "так само (узаг.)", rus: "также (обоп.)", snd: "either.mp3"));
            DicArray.Add(new OneWord(eng: "any longer", trk: "|ˈeni ˈlɒŋɡə|", ukr: "більше (ні) (трив.)", rus: "больше (не) (длит.)", snd: "any longer.mp3"));
            DicArray.Add(new OneWord(eng: "any more", trk: "|ˈeni mɔː|", ukr: "більше (ні)", rus: "больше (не)", snd: "any more.mp3"));
            // */
            return DicArray;
        }
    }
}
