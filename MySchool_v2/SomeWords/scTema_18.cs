using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_18
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 18\n";

            sContent_Info += "Appreciate, dislike, approve, approval...\n";
            sContent_Info += "imagination, feel like, enjoy, enjoyment...\n";
            sContent_Info += "postponement, deny, denial, admit, admission...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_18\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "appreciate", trk: "|əˈpriːʃɪeɪt|", ukr: "цінити", rus: "ценить", snd: "appreciate.mp3"));
            DicArray.Add(new OneWord(eng: "dislike", trk: "|dɪsˈlʌɪk|", ukr: "неприхильність", rus: "не любить", snd: "dislike.mp3"));
            DicArray.Add(new OneWord(eng: "approve", trk: "|əˈpruːv|", ukr: "схвалювати", rus: "одобрять", snd: "approve.mp3"));
            DicArray.Add(new OneWord(eng: "approval", trk: "|əˈpruːv(ə)l|", ukr: "одобрення", rus: "одобрение", snd: "approval.mp3"));
            DicArray.Add(new OneWord(eng: "disapprove", trk: "|dɪsəˈpruːv|", ukr: "не схвалювати", rus: "не одобрять", snd: "disapprove.mp3"));
            DicArray.Add(new OneWord(eng: "disapproval", trk: "|dɪsəˈpruːvl|", ukr: "несхвалення", rus: "неодобрение", snd: "disapproval.mp3"));
            DicArray.Add(new OneWord(eng: "quit", trk: "|kwɪt|", ukr: "залишати", rus: "оставить,перестать", snd: "quit.mp3"));
            DicArray.Add(new OneWord(eng: "recommend", trk: "|rɛkəˈmɛnd|", ukr: "рекомендувати", rus: "рекомендовать", snd: "recommend.mp3"));
            DicArray.Add(new OneWord(eng: "recommendation", trk: "|ˌrɛkəmɛnˈdeɪʃ(ə)n|", ukr: "рекомендація", rus: "рекомендация", snd: "recommendation.mp3"));
            DicArray.Add(new OneWord(eng: "imagine", trk: "|ɪˈmadʒɪn|", ukr: "уявити", rus: "воображать", snd: "imagine.mp3"));
            DicArray.Add(new OneWord(eng: "imagination", trk: "|ɪˌmædʒɪˈneɪʃn|", ukr: "уява", rus: "воображение", snd: "imagination.mp3"));
            DicArray.Add(new OneWord(eng: "feel like", trk: "|fiːl ˈlaɪk|", ukr: "мати бажання", rus: "хотеть, быть в настроении", snd: "feel like.mp3"));
            DicArray.Add(new OneWord(eng: "enjoy", trk: "|ɪnˈdʒɔɪ|", ukr: "насолоджуватися", rus: "наслаждаться", snd: "enjoy.mp3"));
            DicArray.Add(new OneWord(eng: "enjoyment", trk: "|ɪnˈdʒɔɪmənt|", ukr: "насолода", rus: "наслаждение", snd: "enjoyment.mp3"));
            DicArray.Add(new OneWord(eng: "regret", trk: "|rɪˈɡrɛt|", ukr: "жалкувати", rus: "сожалеть", snd: "regret.mp3"));
            DicArray.Add(new OneWord(eng: "resent", trk: "|rɪˈzɛnt|", ukr: "обурюватися", rus: "возмущаться", snd: "resent.mp3"));
            DicArray.Add(new OneWord(eng: "resentment", trk: "|rɪˈzɛntm(ə)nt|", ukr: "обурення", rus: "негодование", snd: "resentment.mp3"));
            DicArray.Add(new OneWord(eng: "suggest", trk: "|səˈdʒɛst|", ukr: "запропонувати", rus: "предлагать", snd: "suggest.mp3"));
            DicArray.Add(new OneWord(eng: "suggestion", trk: "|səˈdʒɛstʃ(ə)n|", ukr: "пропозиція", rus: "предложение", snd: "suggestion.mp3"));
            DicArray.Add(new OneWord(eng: "succeed", trk: "|səkˈsiːd|", ukr: "досягати успіху", rus: "добиваться успеха", snd: "succeed.mp3"));
            DicArray.Add(new OneWord(eng: "avoid", trk: "|əˈvɔɪd|", ukr: "уникати", rus: "избегать", snd: "avoid.mp3"));
            DicArray.Add(new OneWord(eng: "postpone", trk: "|pəʊs(t)ˈpəʊn|", ukr: "відкласти", rus: "откладывать", snd: "postpone.mp3"));
            DicArray.Add(new OneWord(eng: "postponement", trk: "|pəʊs(t)ˈpəʊnm(ə)nt|", ukr: "відстрочка", rus: "отсрочка", snd: "postponement.mp3"));
            DicArray.Add(new OneWord(eng: "deny", trk: "|dɪˈnaɪ|", ukr: "заперечувати", rus: "отрицать", snd: "deny.mp3"));
            DicArray.Add(new OneWord(eng: "denial", trk: "dɪˈnaɪ.əl", ukr: "відмова", rus: "отказ", snd: "denial.mp3"));
            DicArray.Add(new OneWord(eng: "admit", trk: "|ədˈmɪt|", ukr: "визнати", rus: "признавать", snd: "admit.mp3"));
            DicArray.Add(new OneWord(eng: "admission", trk: "|ədˈmɪʃ(ə)n|", ukr: "визнання", rus: "признание", snd: "admission.mp3"));
            DicArray.Add(new OneWord(eng: "miss", trk: "|mɪs|", ukr: "скучати", rus: "скучать", snd: "miss.mp3"));
            DicArray.Add(new OneWord(eng: "practise", trk: "|ˈpraktɪs|", ukr: "практикувати", rus: "практиковать", snd: "practise.mp3"));
            DicArray.Add(new OneWord(eng: "practice", trk: "|ˈpraktɪs|", ukr: "практика", rus: "практика", snd: "practice.mp3"));
            DicArray.Add(new OneWord(eng: "risk", trk: "|rɪsk|", ukr: "ризик", rus: "риск", snd: "risk.mp3"));
            DicArray.Add(new OneWord(eng: "mention", trk: "|ˈmenʃn|", ukr: "згадування", rus: "упоминание", snd: "mention.mp3"));
            DicArray.Add(new OneWord(eng: "prevent", trk: "|prɪˈvɛnt|", ukr: "запобігти", rus: "предотвращать", snd: "prevent.mp3"));
            DicArray.Add(new OneWord(eng: "prevention", trk: "|prɪˈvɛnʃn|", ukr: "запобігання", rus: "предотвращение", snd: "prevention.mp3"));
            DicArray.Add(new OneWord(eng: "prohibit", trk: "|prə(ʊ)ˈhɪbɪt|", ukr: "забороняти", rus: "запрещать", snd: "prohibit.mp3"));
            DicArray.Add(new OneWord(eng: "prohibition", trk: "|ˌprəʊhɪˈbɪʃ(ə)n|", ukr: "заборона", rus: "запрещение", snd: "prohibition.mp3"));
            DicArray.Add(new OneWord(eng: "keep", trk: "|kiːp|", ukr: "держати", rus: "держать", snd: "keep.mp3"));
            DicArray.Add(new OneWord(eng: "kept", trk: "|kept|", ukr: "держати (V2, V3)", rus: "держать (V2, V3)", snd: "kept.mp3"));
            DicArray.Add(new OneWord(eng: "a waste", trk: "|weɪst|", ukr: "марнувати", rus: "тратить впустую", snd: "waste.mp3"));
            DicArray.Add(new OneWord(eng: "difficulty", trk: "|ˈdɪfɪk(ə)lti|", ukr: "перешкода", rus: "трудность", snd: "difficulty.mp3"));
            DicArray.Add(new OneWord(eng: "be worth", trk: "|bi wəːθ|", ukr: "вартувати", rus: "стоить ", snd: "be worth.mp3"));
            DicArray.Add(new OneWord(eng: "try", trk: "|ˈtraɪ|", ukr: "спробувати", rus: "пытаться", snd: "try.mp3"));
            DicArray.Add(new OneWord(eng: "remember", trk: "|rɪˈmɛmbə|", ukr: "пам'ятати", rus: "помнить", snd: "remember.mp3"));
            DicArray.Add(new OneWord(eng: "forget", trk: "|fəˈɡɛt|", ukr: "забути", rus: "забывать", snd: "forget.mp3"));
            DicArray.Add(new OneWord(eng: "forgot", trk: "|fəˈɡɒt|", ukr: "забути (V2)", rus: "забывать (V2)", snd: "forgot.mp3"));
            DicArray.Add(new OneWord(eng: "forgotten", trk: "|fəˈɡɒtn|", ukr: "забути (V3)", rus: "забывать (V3)", snd: "forgotten.mp3"));
            DicArray.Add(new OneWord(eng: "stop", trk: "|stɒp|", ukr: "зупинятися", rus: "останавливаться ", snd: "stop.mp3"));
            DicArray.Add(new OneWord(eng: "when", trk: "|wen|", ukr: "коли", rus: "когда", snd: "when.mp3"));
            DicArray.Add(new OneWord(eng: "while", trk: "|wʌɪl|", ukr: "поки", rus: "пока", snd: "while.mp3"));
            // */
            return DicArray;
        }
    }
}
