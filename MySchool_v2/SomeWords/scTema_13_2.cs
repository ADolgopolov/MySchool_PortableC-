using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_13_2
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 13.2\n";

            sContent_Info += "Happen, trouble, be in trouble, help...\n";
            sContent_Info += "result, influence, fault, mistake, main...\n";
            sContent_Info += "fiancee, wedding, single, divorce, divored...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_13_2\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "happen", trk: "|ˈhap(ə)n|", ukr: "статися", rus: "случаться", snd: "happen.mp3"));
            DicArray.Add(new OneWord(eng: "trouble", trk: "|ˈtrʌb(ə)l|", ukr: "неприємність", rus: "неприятность", snd: "trouble.mp3"));
            DicArray.Add(new OneWord(eng: "help", trk: "|help|", ukr: "допомогти", rus: "помогать", snd: "help.mp3"));
            DicArray.Add(new OneWord(eng: "complain", trk: "|kəmˈpleɪn|", ukr: "скаржитися", rus: "жаловаться", snd: "complain.mp3"));
            DicArray.Add(new OneWord(eng: "complaint", trk: "|kəmˈpleɪnt|", ukr: "скарга", rus: "жалоба", snd: "complaint.mp3"));
            DicArray.Add(new OneWord(eng: "apologize", trk: "|əˈpɒlədʒʌɪz|", ukr: "вибачитися", rus: "извиняться", snd: "apologize.mp3"));
            DicArray.Add(new OneWord(eng: "apology", trk: "|əˈpɒlədʒi|", ukr: "вибачення", rus: "извинение", snd: "apology.mp3"));
            DicArray.Add(new OneWord(eng: "thank", trk: "|θaŋk|", ukr: "дякувати", rus: "благодарить", snd: "thank.mp3"));
            DicArray.Add(new OneWord(eng: "reason", trk: "|ˈriːz(ə)n|", ukr: "причина", rus: "причина", snd: "reason.mp3"));
            DicArray.Add(new OneWord(eng: "purpose", trk: "|ˈpəːpəs|", ukr: "мета", rus: "цель", snd: "purpose.mp3"));
            DicArray.Add(new OneWord(eng: "result", trk: "|rɪˈzʌlt|", ukr: "результат", rus: "результат", snd: "result.mp3"));
            DicArray.Add(new OneWord(eng: "influence", trk: "|ˈɪnflʊəns|", ukr: "вплив", rus: "влияние", snd: "influence.mp3"));
            DicArray.Add(new OneWord(eng: "fault", trk: "|fɔːlt|", ukr: "провина", rus: "вина", snd: "fault.mp3"));
            DicArray.Add(new OneWord(eng: "mistake", trk: "|mɪˈsteɪk|", ukr: "помилка", rus: "ошибка", snd: "mistake.mp3"));
            DicArray.Add(new OneWord(eng: "main", trk: "|meɪn|", ukr: "основний", rus: "основной", snd: "main.mp3"));
            DicArray.Add(new OneWord(eng: "respect", trk: "|rɪˈspɛkt|", ukr: "поважати", rus: "уважать", snd: "respect.mp3"));
            DicArray.Add(new OneWord(eng: "earn", trk: "|ɜːn|", ukr: "заробляти", rus: "зарабатывать", snd: "earn.mp3"));
            DicArray.Add(new OneWord(eng: "a make living", trk: "|ˈmeɪk ˈlɪvɪŋ|", ukr: "заробляти на життя", rus: "зарабатывать на жизнь", snd: "make living.mp3"));
            DicArray.Add(new OneWord(eng: "belong", trk: "|bɪˈlɒŋ|", ukr: "належати", rus: "принадлежать", snd: "belong.mp3"));
            DicArray.Add(new OneWord(eng: "marry", trk: "|ˈmari|", ukr: "одружитися", rus: "жениться", snd: "marry.mp3"));
            DicArray.Add(new OneWord(eng: "married", trk: "|ˈmarɪd|", ukr: "одружений", rus: "женатый", snd: "married.mp3"));
            DicArray.Add(new OneWord(eng: "fiance", trk: "|fiˈɒnseɪ|", ukr: "наречений", rus: "жених", snd: "fiance.mp3"));
            DicArray.Add(new OneWord(eng: "fiancee", trk: "|fiˈɒnseɪ|", ukr: "наречена", rus: "невеста ", snd: "fiancee.mp3"));
            DicArray.Add(new OneWord(eng: "wedding", trk: "|ˈwɛdɪŋ|", ukr: "весілля", rus: "свадебный", snd: "wedding.mp3"));
            DicArray.Add(new OneWord(eng: "single", trk: "|ˈsɪŋɡ(ə)l|", ukr: "нежонатий", rus: "нежeнатый", snd: "single.mp3"));
            DicArray.Add(new OneWord(eng: "divorce", trk: "|dɪˈvɔːs|", ukr: "розлучення", rus: "развод", snd: "divorce.mp3"));
            DicArray.Add(new OneWord(eng: "divorced", trk: "|dɪˈvɔːst|", ukr: "розлучений", rus: "разведенный ", snd: "divorced.mp3"));
            DicArray.Add(new OneWord(eng: "retire", trk: "|rɪˈtʌɪə|", ukr: "піти у відставку", rus: "ходить в отставку", snd: "retire.mp3"));
            DicArray.Add(new OneWord(eng: "die", trk: "|daɪ|", ukr: "вмирати", rus: "умереть", snd: "die.mp3"));
            DicArray.Add(new OneWord(eng: "death", trk: "|dɛθ|", ukr: "смерть", rus: "смерть", snd: "death.mp3"));
            DicArray.Add(new OneWord(eng: "dead", trk: "|ded|", ukr: "мертвий", rus: "мертвый", snd: "dead.mp3"));
            DicArray.Add(new OneWord(eng: "widow", trk: "|ˈwɪdəʊ|", ukr: "вдова", rus: "вдова", snd: "widow.mp3"));
            DicArray.Add(new OneWord(eng: "widower", trk: "|ˈwɪdəʊə|", ukr: "вдівець", rus: "вдовец ", snd: "widower.mp3"));
            DicArray.Add(new OneWord(eng: "childhood", trk: "|ˈtʃʌɪldhʊd|", ukr: "дитинство", rus: "детство", snd: "childhood.mp3"));
            DicArray.Add(new OneWord(eng: "youth", trk: "|juːθ|", ukr: "молодь", rus: "молодежь", snd: "youth.mp3"));
            DicArray.Add(new OneWord(eng: "middle age", trk: "|ˈmɪd(ə)l eɪdʒ|", ukr: "середній вік", rus: "средний возраст", snd: "middle age.mp3"));
            DicArray.Add(new OneWord(eng: "old age", trk: "|əʊld eɪdʒ|", ukr: "похилий вік", rus: "преклонный возраст", snd: "old age.mp3"));
            DicArray.Add(new OneWord(eng: "whether", trk: "|ˈwɛðə|", ukr: "чи, котрий", rus: "ли, который", snd: "whether.mp3"));
            DicArray.Add(new OneWord(eng: "wonder", trk: "|ˈwʌndə|", ukr: "цікавитися", rus: "интересоваться", snd: "wonder.mp3"));
            // */
            return DicArray;
        }
    }
}
