using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_13_1
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 13.1\n";

            sContent_Info += "Biography, birth, be born, grow...\n";
            sContent_Info += "exam, examination, test, major...\n";
            sContent_Info += "become, depend, task, choose, chose...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_13_1\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "biography", trk: "|bʌɪˈɒɡrəfi|", ukr: "біографія", rus: "биография", snd: "biography.mp3"));
            DicArray.Add(new OneWord(eng: "birth", trk: "|bəːθ|", ukr: "народження", rus: "рождение", snd: "birth.mp3"));
            DicArray.Add(new OneWord(eng: "be born", trk: "|bi bɔːn|", ukr: "родитися", rus: "родиться ", snd: "be born.mp3"));
            DicArray.Add(new OneWord(eng: "grow", trk: "|ɡrəʊ|", ukr: "рости", rus: "расти", snd: "grow.mp3"));
            DicArray.Add(new OneWord(eng: "grew", trk: "|ɡruː|", ukr: "рости (V2)", rus: "расти (V2)", snd: "grew.mp3"));
            DicArray.Add(new OneWord(eng: "grown", trk: "|ɡrəʊn|", ukr: "рости (V3)", rus: "расти (V3)", snd: "grown.mp3"));
            DicArray.Add(new OneWord(eng: "bring up", trk: "|brɪŋ ʌp|", ukr: "виховувати", rus: "воспитывать", snd: "bring up.mp3"));
            DicArray.Add(new OneWord(eng: "care", trk: "|keə|", ukr: "турбота", rus: "забота", snd: "care.mp3"));
            DicArray.Add(new OneWord(eng: "take care", trk: "|teɪk keə|", ukr: "піклуватися", rus: "заботиться", snd: "take care.mp3"));
            DicArray.Add(new OneWord(eng: "study", trk: "|ˈstʌdi|", ukr: "вивчення", rus: "изучение", snd: "study.mp3"));
            DicArray.Add(new OneWord(eng: "finish", trk: "|ˈfɪnɪʃ|", ukr: "закінчити", rus: "заканчивать", snd: "finish.mp3"));
            DicArray.Add(new OneWord(eng: "enter", trk: "|ˈɛntə|", ukr: "вступати", rus: "поступать", snd: "enter.mp3"));
            DicArray.Add(new OneWord(eng: "entrance", trk: "|ˈentrəns|", ukr: "вхід", rus: "вход", snd: "entrance.mp3"));
            DicArray.Add(new OneWord(eng: "exam", trk: "|ɪɡˈzæm|", ukr: "іспит", rus: "экзамен ", snd: "exam.mp3"));
            DicArray.Add(new OneWord(eng: "test", trk: "|ˈtest|", ukr: "тест", rus: "тест", snd: "test.mp3"));
            DicArray.Add(new OneWord(eng: "major", trk: "|ˈmeɪdʒə|", ukr: "спеціалізуватися", rus: "специализироваться ", snd: "major.mp3"));
            DicArray.Add(new OneWord(eng: "graduate", trk: "|ˈɡrædʒuət|", ukr: "завершувати", rus: "заканчивать", snd: "graduate.mp3"));
            DicArray.Add(new OneWord(eng: "diploma", trk: "|dɪˈpləʊmə|", ukr: "диплом", rus: "диплом", snd: "diploma.mp3"));
            DicArray.Add(new OneWord(eng: "certificate", trk: "|səˈtɪfɪkət|", ukr: "сертифікат", rus: "сертификат", snd: "certificate.mp3"));
            DicArray.Add(new OneWord(eng: "postgraduate studies", trk: "|pəʊs(t)ˈɡradjʊət ˈstʌdɪz|", ukr: "аспірантура", rus: "аспирантура ", snd: "postgraduate studies.mp3"));
            DicArray.Add(new OneWord(eng: "thesis", trk: "|ˈθiːsɪs|", ukr: "дисертація", rus: "диссертация", snd: "thesis.mp3"));
            DicArray.Add(new OneWord(eng: "became", trk: "|bɪˈkeɪm|", ukr: "ставати (V2)", rus: "становиться (V2)", snd: "became.mp3"));
            DicArray.Add(new OneWord(eng: "become", trk: "|bɪˈkʌm|", ukr: "ставати (V1, V3)", rus: "становиться (V1, V3)", snd: "become.mp3"));
            DicArray.Add(new OneWord(eng: "depend", trk: "|dɪˈpɛnd|", ukr: "залежати", rus: "зависеть", snd: "depend.mp3"));
            DicArray.Add(new OneWord(eng: "task", trk: "|tɑːsk|", ukr: "завдання", rus: "задание", snd: "task.mp3"));
            DicArray.Add(new OneWord(eng: "choose", trk: "|tʃuːz|", ukr: "вибирати", rus: "выбирать", snd: "choose.mp3"));
            DicArray.Add(new OneWord(eng: "chose", trk: "|tʃəʊz|", ukr: "вибирати (V2)", rus: "выбирать (V2)", snd: "chose.mp3"));
            DicArray.Add(new OneWord(eng: "chosen", trk: "|ˈtʃəʊzn|", ukr: "вибирати (V3)", rus: "выбирать (V3)", snd: "chosen.mp3"));
            DicArray.Add(new OneWord(eng: "prefer", trk: "|prɪˈfəː|", ukr: "віддавати перевагу", rus: "предпочитать", snd: "prefer.mp3"));
            DicArray.Add(new OneWord(eng: "preference", trk: "|ˈprefrəns|", ukr: "перевага", rus: "предпочтение", snd: "preference.mp3"));
            DicArray.Add(new OneWord(eng: "move", trk: "|muːv|", ukr: "рухатися", rus: "двигаться", snd: "move.mp3"));
            DicArray.Add(new OneWord(eng: "movement", trk: "|ˈmuːvm(ə)nt|", ukr: "рух", rus: "движение", snd: "movement.mp3"));
            DicArray.Add(new OneWord(eng: "position", trk: "|pəˈzɪʃ(ə)n|", ukr: "позиція", rus: "позиция", snd: "position.mp3"));
            DicArray.Add(new OneWord(eng: "promotion", trk: "|prəˈməʊʃn|", ukr: "просування по службі", rus: "продвижение по службе", snd: "promotion.mp3"));
            DicArray.Add(new OneWord(eng: "successful", trk: "|səkˈsɛsfʊl|", ukr: "успішний", rus: "успешный", snd: "successful.mp3"));
            DicArray.Add(new OneWord(eng: "give up", trk: "|ɡɪv ʌp|", ukr: "облишати, кидати", rus: "оставлять, бросать", snd: "give up.mp3"));
            DicArray.Add(new OneWord(eng: "event", trk: "|ɪˈvɛnt|", ukr: "подія", rus: "событие", snd: "event.mp3"));
            DicArray.Add(new OneWord(eng: "take part", trk: "|teɪk pɑːt|", ukr: "брати участь", rus: "участвовать", snd: "take part.mp3"));
            DicArray.Add(new OneWord(eng: "take place", trk: "|teɪk pleɪs|", ukr: "відбуватися", rus: "происходить", snd: "take place.mp3"));
            // */
            return DicArray;
        }
    }
}
