using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_12_1
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 12.1\n";

            sContent_Info += "Awfully, relatively, regular...\n";
            sContent_Info += "later, twice, once, once more...\n";
            sContent_Info += "late, lately, already, yet, still...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_12\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "awfully", trk: "|ˈɔːfʊli|", ukr: "дуже", rus: "очень", snd: "awfully.mp3"));
            DicArray.Add(new OneWord(eng: "relatively", trk: "|ˈrɛlətɪvli|", ukr: "відносно", rus: "относительно", snd: "relatively.mp3"));
            DicArray.Add(new OneWord(eng: "regular", trk: "|ˈrɛɡjʊlə|", ukr: "регулярний", rus: "регулярный", snd: "regular.mp3"));
            DicArray.Add(new OneWord(eng: "regularly", trk: "|ˈreɡjʊləli|", ukr: "регулярно", rus: "регулярно", snd: "regularly.mp3"));
            DicArray.Add(new OneWord(eng: "usual", trk: "|ˈjuːʒʊəl|", ukr: "звичайний", rus: "обычный", snd: "usual.mp3"));
            DicArray.Add(new OneWord(eng: "usually", trk: "|ˈjuːʒʊəli|", ukr: "зазвичай", rus: "обычно", snd: "usually.mp3"));
            DicArray.Add(new OneWord(eng: "quick", trk: "|kwɪk|", ukr: "швидкий", rus: "быстрый", snd: "quick.mp3"));
            DicArray.Add(new OneWord(eng: "quickly", trk: "|ˈkwɪkli|", ukr: "швидко", rus: "быстро", snd: "quickly.mp3"));
            DicArray.Add(new OneWord(eng: "often", trk: "|ˈɒf(ə)n|", ukr: "часто", rus: "часто", snd: "often.mp3"));
            DicArray.Add(new OneWord(eng: "always", trk: "|ˈɔːlweɪz|", ukr: "завжди", rus: "всегда", snd: "always.mp3"));
            DicArray.Add(new OneWord(eng: "seldom", trk: "|ˈsɛldəm|", ukr: "рідко", rus: "редко ", snd: "seldom.mp3"));
            DicArray.Add(new OneWord(eng: "very", trk: "|ˈveri|", ukr: "дуже", rus: "очень", snd: "very.mp3"));
            DicArray.Add(new OneWord(eng: "more", trk: "|mɔː|", ukr: "більше", rus: "более", snd: "more.mp3"));
            DicArray.Add(new OneWord(eng: "later", trk: "|ˈleɪtə|", ukr: "пізніше", rus: "позже", snd: "later.mp3"));
            DicArray.Add(new OneWord(eng: "twice", trk: "|twʌɪs|", ukr: "двічі", rus: "дважды", snd: "twice.mp3"));
            DicArray.Add(new OneWord(eng: "once", trk: "|wʌns|", ukr: "один раз", rus: "один раз", snd: "once.mp3"));
            DicArray.Add(new OneWord(eng: "once more", trk: "|wʌns mɔː|", ukr: "ще раз", rus: "ещё раз", snd: "once more.mp3"));
            DicArray.Add(new OneWord(eng: "again", trk: "|əˈɡɛn|", ukr: "знову", rus: "снова", snd: "again.mp3"));
            DicArray.Add(new OneWord(eng: "rarely", trk: "|ˈrɛːli|", ukr: "рідко", rus: "редко", snd: "rarely.mp3"));
            DicArray.Add(new OneWord(eng: "sometimes", trk: "|ˈsʌmtʌɪmz|", ukr: "іноді", rus: "иногда", snd: "sometimes.mp3"));
            DicArray.Add(new OneWord(eng: "normally", trk: "| ˈnɔːməli |", ukr: "нормально", rus: "нормально", snd: "normally.mp3"));
            DicArray.Add(new OneWord(eng: "as rule", trk: "|æz ruːl|", ukr: "як правило", rus: "как правило", snd: "as rule.mp3"));
            DicArray.Add(new OneWord(eng: "ago", trk: "|əˈɡəʊ|", ukr: "тому назад", rus: "тому назад", snd: "ago.mp3"));
            DicArray.Add(new OneWord(eng: "recently", trk: "|ˈriːsntli|", ukr: "нещодавно", rus: "недавно", snd: "recently.mp3"));
            DicArray.Add(new OneWord(eng: "early", trk: "|ˈəːli|", ukr: "рано", rus: "рано", snd: "early.mp3"));
            DicArray.Add(new OneWord(eng: "late", trk: "|leɪt|", ukr: "пізній", rus: "поздний", snd: "late.mp3"));
            DicArray.Add(new OneWord(eng: "lately", trk: "|ˈleɪtli|", ukr: "нещодавно", rus: "недавно", snd: "lately.mp3"));
            DicArray.Add(new OneWord(eng: "already", trk: "|ɔːlˈrɛdi|", ukr: "вже", rus: "уже", snd: "already.mp3"));
            DicArray.Add(new OneWord(eng: "yet", trk: "|jet|", ukr: "все ще", rus: "все еще", snd: "yet.mp3"));
            DicArray.Add(new OneWord(eng: "still", trk: "|stɪl|", ukr: "досі", rus: "до сих пор", snd: "still.mp3"));
            DicArray.Add(new OneWord(eng: "never", trk: "|ˈnɛvə|", ukr: "ніколи", rus: "никогда", snd: "never.mp3"));
            DicArray.Add(new OneWord(eng: "ever", trk: "|ˈevə|", ukr: "коли-небудь", rus: "когда-либо", snd: "ever.mp3"));
            // */
            return DicArray;
        }
    }
}
