using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_17_2
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 17.2\n";

            sContent_Info += "Trade, shop, store, grocer`s, grocer...\n";
            sContent_Info += "deal, make a deal, sign, signature, rely...\n";
            sContent_Info += "fall ill, illness, sick, recover, cure...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_17\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "job", trk: "|dʒɒb|", ukr: "робота", rus: "работа", snd: "job.mp3"));
            DicArray.Add(new OneWord(eng: "employ", trk: "|ɪmˈplɔɪ|", ukr: "наймати на роботу", rus: "нанимать  на работу", snd: "employ.mp3"));
            DicArray.Add(new OneWord(eng: "employment", trk: "|ɪmˈplɔɪmənt|", ukr: "найм", rus: "наем", snd: "employment.mp3"));
            DicArray.Add(new OneWord(eng: "employer", trk: "|ɪmˈplɔɪə|", ukr: "наймач", rus: "наниматель", snd: "employer.mp3"));
            DicArray.Add(new OneWord(eng: "dismiss", trk: "|dɪsˈmɪs|", ukr: "звільнити", rus: "увольнять", snd: "dismiss.mp3"));
            DicArray.Add(new OneWord(eng: "dismissal", trk: "|dɪsˈmɪsl|", ukr: "звільнення", rus: "увольнение", snd: "dismissal.mp3"));
            DicArray.Add(new OneWord(eng: "fire", trk: "|ˈfaɪə|", ukr: "звільняти", rus: "увольнять", snd: "fire.mp3"));
            DicArray.Add(new OneWord(eng: "salary", trk: "|ˈsaləri|", ukr: "зарплата", rus: "зарплата", snd: "salary.mp3"));
            DicArray.Add(new OneWord(eng: "fulfil", trk: "|fʊlˈfɪl|", ukr: "виконувати", rus: "выполнять", snd: "fulfil.mp3"));
            DicArray.Add(new OneWord(eng: "fulfilment", trk: "|fʊlˈfɪlmənt|", ukr: "виконання", rus: "выполнение", snd: "fulfilment.mp3"));
            DicArray.Add(new OneWord(eng: "full-time job", trk: "|fʊl ˈtaɪm dʒɒb|", ukr: "робота на повний день", rus: "работа на полный день", snd: "full-time job.mp3"));
            DicArray.Add(new OneWord(eng: "part-time job", trk: "|pɑrt ˈtaɪm dʒɒb|", ukr: "робота на не повний день", rus: "работа на не полный день", snd: "part-time job.mp3"));

            DicArray.Add(new OneWord(eng: "apply", trk: "|əˈplʌɪ|", ukr: "використувати", rus: "применять", snd: "apply.mp3"));
            DicArray.Add(new OneWord(eng: "applicant", trk: "|ˈaplɪk(ə)nt|", ukr: "кандидат", rus: "кандидат, претендент", snd: "applicant.mp3"));
            DicArray.Add(new OneWord(eng: "form", trk: "|ˈfɔːm|", ukr: "форма, бланк", rus: "форма, бланк", snd: "form.mp3"));
            DicArray.Add(new OneWord(eng: "fill in", trk: "|fɪl ɪn|", ukr: "заповнити", rus: "заполнять", snd: "fill in.mp3"));
            DicArray.Add(new OneWord(eng: "summary", trk: "|ˈsʌm(ə)ri|", ukr: "підсумок", rus: "резюме", snd: "summary.mp3"));
            DicArray.Add(new OneWord(eng: "experience", trk: "|ɪkˈspɪərɪəns|", ukr: "досвід", rus: "опыт", snd: "experience.mp3"));
            DicArray.Add(new OneWord(eng: "experienced", trk: "|ɪkˈspɪərɪənst|", ukr: "досвідчений", rus: "опытный", snd: "experienced.mp3"));
            DicArray.Add(new OneWord(eng: "deal", trk: "|diːl|", ukr: "угода", rus: "сделка", snd: "deal.mp3"));
            DicArray.Add(new OneWord(eng: "make a deal", trk: "|ˈmeɪk diːl|", ukr: "укласти угоду", rus: "заключать сделку", snd: "make deal.mp3"));
            DicArray.Add(new OneWord(eng: "sign", trk: "|saɪn|", ukr: "підписувати", rus: "подписывать", snd: "sign.mp3"));
            DicArray.Add(new OneWord(eng: "signature", trk: "|ˈsɪɡnətʃə|", ukr: "підпис", rus: "подпись", snd: "signature.mp3"));
            DicArray.Add(new OneWord(eng: "rely", trk: "|rɪˈlʌɪ|", ukr: "сподіватися", rus: "полагаться", snd: "rely.mp3"));
            DicArray.Add(new OneWord(eng: "reliable", trk: "|rɪˈlʌɪəb(ə)l|", ukr: "надійний", rus: "надежный", snd: "reliable.mp3"));
            DicArray.Add(new OneWord(eng: "let down", trk: "|ˈlɛtdaʊn|", ukr: "підводити", rus: "подводить", snd: "let down.mp3"));
            DicArray.Add(new OneWord(eng: "health", trk: "|hɛlθ|", ukr: "здоров'я", rus: "здоровье", snd: "health.mp3"));
            DicArray.Add(new OneWord(eng: "healthy", trk: "|ˈhɛlθi|", ukr: "здоровий", rus: "здоровый", snd: "healthy.mp3"));
            DicArray.Add(new OneWord(eng: "harm", trk: "|hɑːm|", ukr: "шкодити", rus: "вредить", snd: "harm.mp3"));
            DicArray.Add(new OneWord(eng: "harmful", trk: "|ˈhɑːmfʊl|", ukr: "шкідливий", rus: "вредный", snd: "harmful.mp3"));
            DicArray.Add(new OneWord(eng: "disease", trk: "|dɪˈziːz|", ukr: "хвороба", rus: "болезнь", snd: "disease.mp3"));
            DicArray.Add(new OneWord(eng: "suffer", trk: "|ˈsʌfə|", ukr: "страждати", rus: "страдать", snd: "suffer.mp3"));
            DicArray.Add(new OneWord(eng: "ill", trk: "|ɪl|", ukr: "хворий", rus: "больной", snd: "ill.mp3"));
            DicArray.Add(new OneWord(eng: "fall ill", trk: "|fɔːl ɪl|", ukr: "захворіти", rus: "заболеть ", snd: "fall ill.mp3"));
            DicArray.Add(new OneWord(eng: "illness", trk: "|ɪlnəs|", ukr: "хвороба", rus: "болезнь", snd: "illness.mp3"));
            DicArray.Add(new OneWord(eng: "sick", trk: "|sɪk|", ukr: "хворий", rus: "больной", snd: "sick.mp3"));
            DicArray.Add(new OneWord(eng: "recover", trk: "|rɪˈkʌvə|", ukr: "видужувати", rus: "выздоравливать", snd: "recover.mp3"));
            DicArray.Add(new OneWord(eng: "cure", trk: "|kjʊə|", ukr: "вилікувати", rus: "лечить", snd: "cure.mp3"));
            DicArray.Add(new OneWord(eng: "treat", trk: "|triːt|", ukr: "лікувати", rus: "лечить", snd: "treat.mp3"));
            DicArray.Add(new OneWord(eng: "medical treatment", trk: "|ˈmɛdɪk(ə)l ˈtriːtm(ə)nt|", ukr: "лікування", rus: "лечение", snd: "medical treatment.mp3"));
            DicArray.Add(new OneWord(eng: "patient", trk: "|ˈpeɪʃ(ə)nt|", ukr: "пацієнт", rus: "пациент", snd: "patient.mp3"));
            DicArray.Add(new OneWord(eng: "hospital", trk: "|ˈhɒspɪt(ə)l|", ukr: "лікарня", rus: "больница", snd: "hospital.mp3"));
            DicArray.Add(new OneWord(eng: "clinic", trk: "|ˈklɪnɪk|", ukr: "клініка", rus: "клиника", snd: "clinic.mp3"));
            DicArray.Add(new OneWord(eng: "medical insurance", trk: "|ˈmɛdɪk(ə)l ɪnˈʃʊər(ə)ns|", ukr: "медичне страхування", rus: "медицинское страхование", snd: "medical insurance.mp3"));
            DicArray.Add(new OneWord(eng: "pain", trk: "|peɪn|", ukr: "біль", rus: "боль", snd: "pain.mp3"));
            DicArray.Add(new OneWord(eng: "ache", trk: "|eɪk|", ukr: "біль", rus: "боль", snd: "ache.mp3"));
            DicArray.Add(new OneWord(eng: "toothache", trk: "|ˈtuːθeɪk|", ukr: "зубний біль", rus: "зубная боль", snd: "toothache.mp3"));
            DicArray.Add(new OneWord(eng: "headache", trk: "|ˈhɛdeɪk|", ukr: "головний біль", rus: "головная боль", snd: "headache.mp3"));
            DicArray.Add(new OneWord(eng: "hurt", trk: "|hɜːt|", ukr: "боліти (V1, V2, V3)", rus: "болеть (V1, V2, V3)", snd: "hurt.mp3"));
            DicArray.Add(new OneWord(eng: "cold", trk: "|kəʊld|", ukr: "застуда", rus: "простуда", snd: "cold.mp3"));
            DicArray.Add(new OneWord(eng: "cough", trk: "|kɒf|", ukr: "кашель", rus: "кашель", snd: "cough.mp3"));
            DicArray.Add(new OneWord(eng: "sore throat", trk: "|sɔː θrəʊt|", ukr: "хворе горло", rus: "больное горло", snd: "sore throat.mp3"));
            DicArray.Add(new OneWord(eng: "flu", trk: "|fluː|", ukr: "грип", rus: "грипп", snd: "flu.mp3"));
            DicArray.Add(new OneWord(eng: "medicine", trk: "|ˈmɛds(ə)n|", ukr: "медицина", rus: "медицина", snd: "medicine.mp3"));
            DicArray.Add(new OneWord(eng: "chemist`s", trk: "|ˈkɛmɪst`s|", ukr: "аптека", rus: "аптека", snd: "chemist`s.mp3"));
            DicArray.Add(new OneWord(eng: "chemist", trk: "|ˈkɛmɪst|", ukr: "хімік, аптекар", rus: "химик, аптекарь", snd: "chemist.mp3"));
            DicArray.Add(new OneWord(eng: "drugstore", trk: "|ˈdrʌɡstɔː|", ukr: "аптека", rus: "аптека", snd: "drugstore.mp3"));
            DicArray.Add(new OneWord(eng: "prescribe", trk: "|prɪˈskrʌɪb|", ukr: "призначати", rus: "предписывать", snd: "prescribe.mp3"));
            DicArray.Add(new OneWord(eng: "prescription", trk: "|prɪˈskrɪpʃ(ə)n|", ukr: "рецепт", rus: "рецепт", snd: "prescription.mp3"));
            DicArray.Add(new OneWord(eng: "consult", trk: "|kənˈsʌlt|", ukr: "консультуватися", rus: "консультироваться", snd: "consult.mp3"));
            DicArray.Add(new OneWord(eng: "consultation", trk: "|kɒnsəlˈteɪʃ(ə)n|", ukr: "консультація", rus: "консультация", snd: "consultation.mp3"));
            DicArray.Add(new OneWord(eng: "weight", trk: "|weɪt|", ukr: "вага", rus: "вес", snd: "weight.mp3"));
            DicArray.Add(new OneWord(eng: "a diet", trk: "|ˈdaɪət|", ukr: "дієта", rus: "диета", snd: "diet.mp3"));
            DicArray.Add(new OneWord(eng: "pregnant", trk: "|ˈprɛɡnənt|", ukr: "вагітна", rus: "беременная", snd: "pregnant.mp3"));
            // */
            return DicArray;
        }
    }
}
