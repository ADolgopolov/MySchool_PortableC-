using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_15_1
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 15.1\n";

            sContent_Info += "State, politics, society, power...\n";
            sContent_Info += "invade, defend, war, peace, fight...\n";
            sContent_Info += "produce, production, build, built...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_15_1\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "state", trk: "|steɪt|", ukr: "держава", rus: "государство", snd: "state.mp3"));
            DicArray.Add(new OneWord(eng: "politics", trk: "|ˈpɒlɪtɪks|", ukr: "політика", rus: "политика", snd: "politics.mp3"));
            DicArray.Add(new OneWord(eng: "society", trk: "|səˈsʌɪɪti|", ukr: "суспільство", rus: "общество", snd: "society.mp3"));
            DicArray.Add(new OneWord(eng: "power", trk: "|ˈpaʊə|", ukr: "влада", rus: "власть", snd: "power.mp3"));
            DicArray.Add(new OneWord(eng: "government", trk: "|ˈɡʌvərnmənt|", ukr: "уряд", rus: "правительство", snd: "government.mp3"));
            DicArray.Add(new OneWord(eng: "parliament", trk: "|ˈpɑːləm(ə)nt|", ukr: "парламент", rus: "парламент", snd: "parliament.mp3"));
            DicArray.Add(new OneWord(eng: "mayor", trk: "|mɛː|", ukr: "мер", rus: "мэр ", snd: "mayor.mp3"));
            DicArray.Add(new OneWord(eng: "elect", trk: "|ɪˈlɛkt|", ukr: "вибрати", rus: "избирать", snd: "elect.mp3"));
            DicArray.Add(new OneWord(eng: "election", trk: "|ɪˈlɛkʃ(ə)n|", ukr: "вибори", rus: "выборы", snd: "election.mp3"));
            DicArray.Add(new OneWord(eng: "vote", trk: "|vəʊt|", ukr: "голосувати", rus: "голосовать", snd: "vote.mp3"));
            DicArray.Add(new OneWord(eng: "party", trk: "|ˈpɑːti|", ukr: "партія", rus: "партия", snd: "party.mp3"));
            DicArray.Add(new OneWord(eng: "freedom", trk: "|ˈfriːdəm|", ukr: "свобода", rus: "свобода", snd: "freedom.mp3"));
            DicArray.Add(new OneWord(eng: "army", trk: "|ˈɑːmi|", ukr: "армія", rus: "армия", snd: "army.mp3"));
            DicArray.Add(new OneWord(eng: "invade", trk: "|ɪnˈveɪd|", ukr: "вторгнутися", rus: "вторгаться", snd: "invade.mp3"));
            DicArray.Add(new OneWord(eng: "defend", trk: "|dɪˈfɛnd|", ukr: "захищати", rus: "защищать", snd: "defend.mp3"));
            DicArray.Add(new OneWord(eng: "invasion", trk: "|ɪnˈveɪʒn|", ukr: "вторгнення", rus: "вторжение", snd: "invasion.mp3"));
            DicArray.Add(new OneWord(eng: "war", trk: "|wɔː|", ukr: "війна", rus: "война", snd: "war.mp3"));
            DicArray.Add(new OneWord(eng: "peace", trk: "|piːs|", ukr: "мир", rus: "мир", snd: "peace.mp3"));
            DicArray.Add(new OneWord(eng: "fight", trk: "|fʌɪt|", ukr: "вести бій", rus: "вести бой", snd: "fight.mp3"));
            DicArray.Add(new OneWord(eng: "fought", trk: "|fɔːt|", ukr: "вести бій (V2, V3)", rus: "вести бой (V2, V3)", snd: "fought.mp3"));
            DicArray.Add(new OneWord(eng: "win", trk: "|wɪn|", ukr: "перемагати", rus: "побеждать", snd: "win.mp3"));
            DicArray.Add(new OneWord(eng: "won", trk: "|wʌn|", ukr: "перемагати (V2, V3)", rus: "побеждать (V2, V3)", snd: "won.mp3"));
            DicArray.Add(new OneWord(eng: "lose", trk: "|luːz|", ukr: "програвати", rus: "проигрывать", snd: "lose.mp3"));
            DicArray.Add(new OneWord(eng: "lost", trk: "|lɒst|", ukr: "програвати (V2, V3)", rus: "проигрывать (V2, V3)", snd: "lost.mp3"));
            DicArray.Add(new OneWord(eng: "loss", trk: "|lɒs|", ukr: "програш", rus: "проигрыш", snd: "loss.mp3"));
            DicArray.Add(new OneWord(eng: "tax", trk: "|tæks|", ukr: "податок", rus: "податок", snd: "tax.mp3"));
            DicArray.Add(new OneWord(eng: "tax-payer", trk: "|tæks ˈpeɪər|", ukr: "платник податків", rus: "налогоплательщик", snd: "tax-payer.mp3"));
            DicArray.Add(new OneWord(eng: "reform", trk: "|rɪˈfɔːm|", ukr: "реформа", rus: "реформа", snd: "reform.mp3"));
            DicArray.Add(new OneWord(eng: "increase", trk: "|ɪnˈkriːs|", ukr: "збільшити", rus: "увеличивать", snd: "increase.mp3"));
            DicArray.Add(new OneWord(eng: "reduce", trk: "|rɪˈdjuːs|", ukr: "зменшити", rus: "уменьшить", snd: "reduce.mp3"));
            DicArray.Add(new OneWord(eng: "produce", trk: "|prəˈdjuːs|", ukr: "виробляти", rus: "производить", snd: "produce.mp3"));
            DicArray.Add(new OneWord(eng: "production", trk: "|prəˈdʌkʃ(ə)n|", ukr: "виробництво", rus: "производство", snd: "production.mp3"));
            DicArray.Add(new OneWord(eng: "build", trk: "|bɪld|", ukr: "будувати", rus: "строить", snd: "build.mp3"));
            DicArray.Add(new OneWord(eng: "built", trk: "|bɪlt|", ukr: "будувати (V2, V3)", rus: "строить (V2, V3)", snd: "built.mp3"));
            DicArray.Add(new OneWord(eng: "reconstruct", trk: "|riːkənˈstrʌkt|", ukr: "реконструювати", rus: "реконструировать", snd: "reconstruct.mp3"));
            DicArray.Add(new OneWord(eng: "design", trk: "|dɪˈzʌɪn|", ukr: "дизайн", rus: "дизайн", snd: "design.mp3"));
            DicArray.Add(new OneWord(eng: "knock down", trk: "|ˈnɒkdaʊn|", ukr: "зносити", rus: "сносить", snd: "knock down.mp3"));
            DicArray.Add(new OneWord(eng: "restore", trk: "|rɪˈstɔː|", ukr: "відновити", rus: "восстанавливать", snd: "restore.mp3"));
            DicArray.Add(new OneWord(eng: "restoration", trk: "|rɛstəˈreɪʃ(ə)n|", ukr: "відновлення", rus: "восстановление", snd: "restoration.mp3"));
            DicArray.Add(new OneWord(eng: "found", trk: "|faʊnd|", ukr: "основувати", rus: "основывать", snd: "found.mp3"));
            DicArray.Add(new OneWord(eng: "name", trk: "|ˈneɪm|", ukr: "називати", rus: "назвать", snd: "name.mp3"));
            DicArray.Add(new OneWord(eng: "foundation", trk: "|faʊnˈdeɪʃ(ə)n|", ukr: "заснування", rus: "основание", snd: "foundation.mp3"));
            DicArray.Add(new OneWord(eng: "rename", trk: "|riːˈneɪm|", ukr: "перейменувати", rus: "переименовать", snd: "rename.mp3"));
            DicArray.Add(new OneWord(eng: "develop", trk: "|dɪˈvɛləp|", ukr: "розвиватися", rus: "развиваться", snd: "develop.mp3"));
            DicArray.Add(new OneWord(eng: "invent", trk: "|ɪnˈvɛnt|", ukr: "винаходити", rus: "изобретать", snd: "invent.mp3"));
            DicArray.Add(new OneWord(eng: "discover", trk: "|dɪˈskʌvə|", ukr: "відкрити", rus: "обнаруживать", snd: "discover.mp3"));
            DicArray.Add(new OneWord(eng: "discovery", trk: "|dɪˈskʌv(ə)ri|", ukr: "відкриття", rus: "открытие", snd: "discovery.mp3"));
            DicArray.Add(new OneWord(eng: "include", trk: "|ɪnˈkluːd|", ukr: "включать", rus: "включати", snd: "include.mp3"));
            DicArray.Add(new OneWord(eng: "solve", trk: "|sɒlv|", ukr: "вирішити", rus: "решать", snd: "solve.mp3"));
            DicArray.Add(new OneWord(eng: "public opinion", trk: "|ˈpʌblɪk əˈpɪnjən|", ukr: "громадська думка", rus: "общественное мнение", snd: "public opinion.mp3"));
            DicArray.Add(new OneWord(eng: "blame", trk: "|bleɪm|", ukr: "звинувачувати", rus: "обвинять", snd: "blame.mp3"));
            DicArray.Add(new OneWord(eng: "custom", trk: "|ˈkʌstəm|", ukr: "звичай", rus: "обычай", snd: "custom.mp3"));
            DicArray.Add(new OneWord(eng: "generation", trk: "|dʒɛnəˈreɪʃ(ə)n|", ukr: "покоління", rus: "поколение", snd: "generation.mp3"));
            // */
            return DicArray;
        }
    }
}
