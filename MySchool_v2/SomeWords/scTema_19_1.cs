using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_19_1
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 19.1\n";

            sContent_Info += "Emotions, satisfy, satisfied, satisfying...\n";
            sContent_Info += "fascinate, fascinated, fascinating, charm...\n";
            sContent_Info += "surprising, amaze, amazed, amazing...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_19_1\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "get", trk: "|ˈɡet|", ukr: "отримати", rus: "получать, становиться", snd: "get.mp3"));
            DicArray.Add(new OneWord(eng: "got", trk: "|ˈɡɒt|", ukr: "отримати (V2, V3)", rus: "получать (V2, V3)", snd: "got.mp3"));
            DicArray.Add(new OneWord(eng: "become", trk: "|bɪˈkʌm|", ukr: "стати (V1, V2)", rus: "становиться (V1, V2)", snd: "become.mp3"));
            DicArray.Add(new OneWord(eng: "became", trk: "|bɪˈkeɪm|", ukr: "стати (V2)", rus: "становиться (V2)", snd: "became.mp3"));
            DicArray.Add(new OneWord(eng: "feel", trk: "|fiːl|", ukr: "почуватися", rus: "чувствовать себя", snd: "feel.mp3"));
            DicArray.Add(new OneWord(eng: "felt", trk: "|felt|", ukr: "почувати (V2, V3)", rus: "чувствовать себя (V2, V3)", snd: "felt.mp3"));
            DicArray.Add(new OneWord(eng: "look", trk: "|lʊk|", ukr: "виглядати", rus: "выглядеть", snd: "look.mp3"));
            DicArray.Add(new OneWord(eng: "seem", trk: "|siːm|", ukr: "задаватися, вбачатися", rus: "казаться", snd: "seem.mp3"));
            DicArray.Add(new OneWord(eng: "sound", trk: "|saʊnd|", ukr: "звучати", rus: "звучать", snd: "sound.mp3"));
            DicArray.Add(new OneWord(eng: "taste", trk: "|teɪst|", ukr: "мати смак", rus: "иметь вкус", snd: "taste.mp3"));
            DicArray.Add(new OneWord(eng: "smell", trk: "|smɛl|", ukr: "пахнути", rus: "пахнуть", snd: "smell.mp3"));
            DicArray.Add(new OneWord(eng: "smelt", trk: "|smɛlt|", ukr: "пахнути (V2, V3)", rus: "пахнуть (V2, V3)", snd: "smelt.mp3"));
            DicArray.Add(new OneWord(eng: "make", trk: "|ˈmeɪk|", ukr: "робити якимсь", rus: "сделать каким-либо", snd: "make.mp3"));
            DicArray.Add(new OneWord(eng: "find", trk: "|faɪnd|", ukr: "знайти", rus: "находить", snd: "find.mp3"));
            DicArray.Add(new OneWord(eng: "found", trk: "|faʊnd|", ukr: "знайти (V2, V3)", rus: "находить (V2, V3)", snd: "found.mp3"));
            DicArray.Add(new OneWord(eng: "emotion", trk: "|ɪˈməʊʃ(ə)n|", ukr: "емоція", rus: "эмоция", snd: "emotion.mp3"));
            DicArray.Add(new OneWord(eng: "satisfy", trk: "|ˈsatɪsfʌɪ|", ukr: "задовольнити", rus: "удовлетворять", snd: "satisfy.mp3"));
            DicArray.Add(new OneWord(eng: "satisfied", trk: "|ˈsatɪsfʌɪd|", ukr: "задоволений", rus: "удовлетворенный", snd: "satisfied.mp3"));
            DicArray.Add(new OneWord(eng: "satisfying", trk: "|ˈsatɪsfʌɪɪŋ|", ukr: "що дає задоволення", rus: "удовлетворяющий", snd: "satisfying.mp3"));
            DicArray.Add(new OneWord(eng: "relax", trk: "|rɪˈlaks|", ukr: "випочивати", rus: "отдыхать", snd: "relax.mp3"));
            DicArray.Add(new OneWord(eng: "relaxed", trk: "|rɪˈlakst|", ukr: "розслаблений", rus: "расслабленный", snd: "relaxed.mp3"));
            DicArray.Add(new OneWord(eng: "relaxing", trk: "|rɪˈlæksɪŋ|", ukr: "розслабляючий", rus: "расслабляющий", snd: "relaxing.mp3"));
            DicArray.Add(new OneWord(eng: "excite", trk: "|ɪkˈsʌɪt|", ukr: "збуджувати", rus: "возбуждать", snd: "excite.mp3"));
            DicArray.Add(new OneWord(eng: "excited", trk: "|ɪkˈsʌɪtɪd|", ukr: "збуджений", rus: "возбужденный", snd: "excited.mp3"));
            DicArray.Add(new OneWord(eng: "exciting", trk: "|ɪkˈsʌɪtɪŋ|", ukr: "збуджуючий", rus: "возбуждающий", snd: "exciting.mp3"));
            DicArray.Add(new OneWord(eng: "amuse", trk: "|əˈmjuːz|", ukr: "розважати", rus: "развлекать", snd: "amuse.mp3"));
            DicArray.Add(new OneWord(eng: "amused", trk: "|əˈmjuːzd|", ukr: "веселий", rus: "весёлый", snd: "amused.mp3"));
            DicArray.Add(new OneWord(eng: "amusing", trk: "|əˈmjuːzɪŋ|", ukr: "забавний", rus: "забавный", snd: "amusing.mp3"));
            DicArray.Add(new OneWord(eng: "fascinate", trk: "|ˈfasɪneɪt|", ukr: "зачарувати", rus: "очаровывать", snd: "fascinate.mp3"));
            DicArray.Add(new OneWord(eng: "fascinated", trk: "|ˈfæsɪneɪtɪd|", ukr: "зачарований", rus: "очарованный", snd: "fascinated.mp3"));
            DicArray.Add(new OneWord(eng: "fascinating", trk: "|ˈfasɪneɪtɪŋ|", ukr: "чарівний", rus: "очаровательный", snd: "fascinating.mp3"));
            DicArray.Add(new OneWord(eng: "charm", trk: "|tʃɑːm|", ukr: "заворожувати", rus: "очаровывать", snd: "charm.mp3"));
            DicArray.Add(new OneWord(eng: "charmed", trk: "|tʃɑːmd|", ukr: "зачарований", rus: "очарованный", snd: "charmed.mp3"));
            DicArray.Add(new OneWord(eng: "charming", trk: "|ˈtʃɑːmɪŋ|", ukr: "чарівний", rus: "очаровательный", snd: "charming.mp3"));
            DicArray.Add(new OneWord(eng: "inspire", trk: "|ɪnˈspʌɪə|", ukr: "надихати", rus: "вдохновлять", snd: "inspire.mp3"));
            DicArray.Add(new OneWord(eng: "inspired", trk: "|ɪnˈspʌɪəd|", ukr: "натхненний", rus: "вдохновленный", snd: "inspired.mp3"));
            DicArray.Add(new OneWord(eng: "inspiring", trk: "|ɪnˈspʌɪərɪŋ|", ukr: "надихаючий", rus: "вдохновляющий", snd: "inspiring.mp3"));
            DicArray.Add(new OneWord(eng: "surprise", trk: "|səˈprʌɪz|", ukr: "здивувати, здивування", rus: "удивлять, удивление", snd: "surprise.mp3"));
            DicArray.Add(new OneWord(eng: "surprised", trk: "|səˈprʌɪzd|", ukr: "здивований", rus: "удивленный", snd: "surprised.mp3"));
            DicArray.Add(new OneWord(eng: "surprising", trk: "|səˈprʌɪzɪŋ|", ukr: "несподіваний", rus: "неожиданный", snd: "surprising.mp3"));
            DicArray.Add(new OneWord(eng: "amaze", trk: "|əˈmeɪz|", ukr: "вражати", rus: "поражать", snd: "amaze.mp3"));
            DicArray.Add(new OneWord(eng: "amazed", trk: "|əˈmeɪzd|", ukr: "вражений", rus: "пораженный", snd: "amazed.mp3"));
            DicArray.Add(new OneWord(eng: "amazing", trk: "|əˈmeɪzɪŋ|", ukr: "разючий", rus: "поразительный ", snd: "amazing.mp3"));
            // */
            return DicArray;
        }
    }
}
