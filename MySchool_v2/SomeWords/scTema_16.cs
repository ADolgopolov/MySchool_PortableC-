using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_16
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 16\n";

            sContent_Info += "Try, want, wish, agree, refuse...\n";
            sContent_Info += "encouragement, warn, warning, manage...\n";
            sContent_Info += "chance, opportunity, forbid, forbabe...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_16\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "try", trk: "|ˈtraɪ|", ukr: "пробувати", rus: "пытаться", snd: "try.mp3"));
            DicArray.Add(new OneWord(eng: "want", trk: "|wɒnt|", ukr: "бажати", rus: "хотеть", snd: "want.mp3"));
            DicArray.Add(new OneWord(eng: "wish", trk: "|wɪʃ|", ukr: "бажати", rus: "желать", snd: "wish.mp3"));
            DicArray.Add(new OneWord(eng: "agree", trk: "|əˈɡriː|", ukr: "погоджуватися", rus: "соглашаться", snd: "agree.mp3"));
            DicArray.Add(new OneWord(eng: "refuse", trk: "|rɪˈfjuːz|", ukr: "відмовитися", rus: "отказываться", snd: "refuse.mp3"));
            DicArray.Add(new OneWord(eng: "refusal", trk: "|rɪˈfjuːz(ə)l|", ukr: "відмова", rus: "отказ", snd: "refusal.mp3"));
            DicArray.Add(new OneWord(eng: "decide", trk: "|dɪˈsʌɪd|", ukr: "вирішувати", rus: "решать", snd: "decide.mp3"));
            DicArray.Add(new OneWord(eng: "decision", trk: "|dɪˈsɪʒ(ə)n|", ukr: "рішення", rus: "решение", snd: "decision.mp3"));
            DicArray.Add(new OneWord(eng: "expect", trk: "|ɪkˈspɛkt|", ukr: "чекати", rus: "ожидать", snd: "expect.mp3"));
            DicArray.Add(new OneWord(eng: "expectation", trk: "|ɛkspɛkˈteɪʃ(ə)n|", ukr: "очікування", rus: "ожидание", snd: "expectation.mp3"));
            DicArray.Add(new OneWord(eng: "hope", trk: "|həʊp|", ukr: "надія, надіятися", rus: "надежда, надеяться", snd: "hope.mp3"));
            DicArray.Add(new OneWord(eng: "plan", trk: "|plæn|", ukr: "план", rus: "план", snd: "plan.mp3"));
            DicArray.Add(new OneWord(eng: "promise", trk: "|ˈprɒmɪs|", ukr: "обіцяти", rus: "обещать", snd: "promise.mp3"));
            DicArray.Add(new OneWord(eng: "encourage", trk: "|ɪnˈkʌrɪdʒ|", ukr: "заохочувати", rus: "поощрять", snd: "encourage.mp3"));
            DicArray.Add(new OneWord(eng: "encouragement", trk: "|ɪnˈkʌrɪdʒm(ə)nt|", ukr: "заохочення", rus: "поощрение", snd: "encouragement.mp3"));
            DicArray.Add(new OneWord(eng: "warn", trk: "|wɔːn|", ukr: "попередити", rus: "предупреждать", snd: "warn.mp3"));
            DicArray.Add(new OneWord(eng: "warning", trk: "|ˈwɔːnɪŋ|", ukr: "застереження", rus: "предупреждение", snd: "warning.mp3"));
            DicArray.Add(new OneWord(eng: "manage", trk: "|ˈmanɪdʒ|", ukr: "керувати", rus: "суметь, справиться", snd: "manage.mp3"));
            DicArray.Add(new OneWord(eng: "fail", trk: "|feɪl|", ukr: "зазнати невдачі", rus: "терпеть неудачу", snd: "fail.mp3"));
            DicArray.Add(new OneWord(eng: "failure", trk: "|ˈfeɪljə|", ukr: "невдача", rus: "неудача", snd: "failure.mp3"));
            DicArray.Add(new OneWord(eng: "prepare", trk: "|prɪˈpɛː|", ukr: "готувати", rus: "готовить", snd: "prepare.mp3"));
            DicArray.Add(new OneWord(eng: "be ready", trk: "|bi ˈrɛdi|", ukr: "бути готовим", rus: "быть готовым", snd: "be ready.mp3"));
            DicArray.Add(new OneWord(eng: "teach", trk: "|tiːtʃ|", ukr: "вчити", rus: "учить", snd: "teach.mp3"));
            DicArray.Add(new OneWord(eng: "taught", trk: "|tɔːt|", ukr: "вчити (V2, V3)", rus: "учить (V2, V3)", snd: "taught.mp3"));
            DicArray.Add(new OneWord(eng: "offer", trk: "|ˈɒfə|", ukr: "пропозиція, пропонувати", rus: "предложение, предлагать", snd: "offer.mp3"));
            DicArray.Add(new OneWord(eng: "advise", trk: "|ədˈvʌɪz|", ukr: "радити", rus: "советовать", snd: "advise.mp3"));
            DicArray.Add(new OneWord(eng: "advice", trk: "|ədˈvʌɪs|", ukr: "порада", rus: "совет", snd: "advice.mp3"));
            DicArray.Add(new OneWord(eng: "chance", trk: "|tʃɑːns|", ukr: "шанс", rus: "шанс", snd: "chance.mp3"));
            DicArray.Add(new OneWord(eng: "opportunity", trk: "|ɒpəˈtjuːnɪti|", ukr: "можливість", rus: "благоприятная возможность", snd: "opportunity.mp3"));
            DicArray.Add(new OneWord(eng: "forbid", trk: "|fəˈbɪd|", ukr: "забороняти", rus: "запрещать", snd: "forbid.mp3"));
            DicArray.Add(new OneWord(eng: "forbade", trk: "|fəˈbad|", ukr: "забороняти (V2)", rus: "запрещать (V2)", snd: "forbade.mp3"));
            DicArray.Add(new OneWord(eng: "forbidden", trk: "|fəˈbɪd(ə)n|", ukr: "забороняти (V3)", rus: "запрещать (V3)", snd: "forbidden.mp3"));
            DicArray.Add(new OneWord(eng: "allow", trk: "|əˈlaʊ|", ukr: "дозволити", rus: "разрешать", snd: "allow.mp3"));
            DicArray.Add(new OneWord(eng: "pretend", trk: "|prɪˈtɛnd|", ukr: "вдавати", rus: "притворяться", snd: "pretend.mp3"));
            DicArray.Add(new OneWord(eng: "persuade", trk: "|pəˈsweɪd|", ukr: "переконувати", rus: "убеждать", snd: "persuade.mp3"));
            DicArray.Add(new OneWord(eng: "continue", trk: "|kənˈtɪnjuː|", ukr: "продовжити", rus: "продолжать", snd: "continue.mp3"));
            DicArray.Add(new OneWord(eng: "deserve", trk: "|dɪˈzəːv|", ukr: "заслуговувати", rus: "заслуживать", snd: "deserve.mp3"));
            DicArray.Add(new OneWord(eng: "deserts", trk: "|dɪˈzəːts|", ukr: "заслуги", rus: "заслуги", snd: "deserts.mp3"));
            DicArray.Add(new OneWord(eng: "would", trk: "|wʊd|", ukr: "мати звичку", rus: "мати звичку", snd: "would.mp3"));
            DicArray.Add(new OneWord(eng: "used to", trk: "|ˈjuːzd tuː|", ukr: "мати звичку", rus: "иметь привычку", snd: "used to.mp3"));
            DicArray.Add(new OneWord(eng: "seem to", trk: "|siːm tuː|", ukr: "здається", rus: "кажется", snd: "seem to.mp3"));
            DicArray.Add(new OneWord(eng: "happen to", trk: "|ˈhæpən tuː|", ukr: "статися з", rus: "так случилось, что", snd: "happen to.mp3"));
            DicArray.Add(new OneWord(eng: "be likely to", trk: "|bi ˈlʌɪkli tuː|", ukr: "швидше за все", rus: "похоже, что", snd: "be likely to.mp3"));
            DicArray.Add(new OneWord(eng: "be pleased", trk: "|bi pliːzd|", ukr: "бути задоволеним", rus: "быть довольным", snd: "be pleased.mp3"));
            DicArray.Add(new OneWord(eng: "be glad", trk: "|bi ɡlæd|", ukr: "бути радим", rus: "быть довольным", snd: "be glad.mp3"));
            DicArray.Add(new OneWord(eng: "be delighted", trk: "|bi dɪˈlʌɪtɪd|", ukr: "будь в захваті", rus: "восхищаться, радоваться ", snd: "be delighted.mp3"));
            DicArray.Add(new OneWord(eng: "need", trk: "|niːd|", ukr: "мати потребу", rus: "нуждаться, нужно", snd: "need.mp3"));
            DicArray.Add(new OneWord(eng: "help", trk: "|help|", ukr: "допомогти", rus: "помогать", snd: "help.mp3"));
            DicArray.Add(new OneWord(eng: "tell", trk: "|tel|", ukr: "говорити", rus: "говорить", snd: "tell.mp3"));
            DicArray.Add(new OneWord(eng: "enough", trk: "|ɪˈnʌf|", ukr: "достатньо", rus: "достаточно", snd: "enough.mp3"));
            DicArray.Add(new OneWord(eng: "alleged", trk: "|əˈlɛdʒd|", ukr: "стверджуваний", rus: "утверждать", snd: "alleged.mp3"));
            // */
            return DicArray;
        }
    }
}
