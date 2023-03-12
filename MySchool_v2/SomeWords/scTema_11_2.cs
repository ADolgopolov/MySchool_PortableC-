using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_11_2
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 11.2\n";

            sContent_Info += "Spent, party, invite, guest, host...\n";
            sContent_Info += "joke, dance, game, play, card, chess...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_11\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "spend", trk: "|spɛnd|", ukr: "витрачати, проводити", rus: "тратить, проводить", snd: "spend.mp3"));
            DicArray.Add(new OneWord(eng: "spent", trk: "|spɛnt|", ukr: "витрачати, проводити (V2, V3)", rus: "тратить, проводить (V2, V3)", snd: "spent.mp3"));
            DicArray.Add(new OneWord(eng: "party", trk: "|ˈpɑːti|", ukr: "вечірка", rus: "вечеринка", snd: "party.mp3"));
            DicArray.Add(new OneWord(eng: "invite", trk: "|ɪnˈvʌɪt|", ukr: "запросити", rus: "приглашать ", snd: "invite.mp3"));
            DicArray.Add(new OneWord(eng: "guest", trk: "|ɡɛst|", ukr: "гість", rus: "гость", snd: "guest.mp3"));
            DicArray.Add(new OneWord(eng: "host", trk: "|həʊst|", ukr: "господар", rus: "хозяин", snd: "host.mp3"));
            DicArray.Add(new OneWord(eng: "hostess", trk: "|ˈhəʊstəs|", ukr: "господиня", rus: "хозяйка", snd: "hostess.mp3"));
            DicArray.Add(new OneWord(eng: "celebrate", trk: "|ˈsɛlɪbreɪt|", ukr: "святкувати", rus: "праздновать", snd: "celebrate.mp3"));
            DicArray.Add(new OneWord(eng: "celebration", trk: "|sɛlɪˈbreɪʃ(ə)n|", ukr: "святкування", rus: "празднование", snd: "celebration.mp3"));
            DicArray.Add(new OneWord(eng: "present", trk: "|ˈprɛz(ə)nt|", ukr: "подарунок", rus: "подарок", snd: "present.mp3"));
            DicArray.Add(new OneWord(eng: "chat", trk: "|tʃæt|", ukr: "балакати", rus: "беседовать", snd: "chat.mp3"));
            DicArray.Add(new OneWord(eng: "have fun", trk: "|hæv fʌn|", ukr: "веселитися", rus: "забавляться, приятно проводить время", snd: "have fun.mp3"));
            DicArray.Add(new OneWord(eng: "laugh", trk: "|lɑːf|", ukr: "сміятися", rus: "смеяться", snd: "laugh.mp3"));
            DicArray.Add(new OneWord(eng: "smile", trk: "|smʌɪl|", ukr: "усмішка", rus: "улыбка", snd: "smile.mp3"));
            DicArray.Add(new OneWord(eng: "joke", trk: "|dʒəʊk|", ukr: "жарт", rus: "шутка", snd: "joke.mp3"));
            DicArray.Add(new OneWord(eng: "dance", trk: "|dɑːns|", ukr: "танцювати", rus: "танцевать", snd: "dance.mp3"));
            DicArray.Add(new OneWord(eng: "game", trk: "|ɡeɪm|", ukr: "гра", rus: "игра", snd: "game.mp3"));
            DicArray.Add(new OneWord(eng: "play", trk: "|ˈpleɪ|", ukr: "грати", rus: "играть", snd: "play.mp3"));
            DicArray.Add(new OneWord(eng: "card", trk: "|kɑːrd|", ukr: "карта", rus: "карта", snd: "card.mp3"));
            DicArray.Add(new OneWord(eng: "chess", trk: "|tʃɛs|", ukr: "шахи", rus: "шахматы", snd: "chess.mp3"));
            DicArray.Add(new OneWord(eng: "sing", trk: "|sɪŋ|", ukr: "співати", rus: "петь", snd: "sing.mp3"));
            DicArray.Add(new OneWord(eng: "sang", trk: "|sæŋ|", ukr: "співати (V2)", rus: "петь (V2)", snd: "sang.mp3"));
            DicArray.Add(new OneWord(eng: "sung", trk: "|sʌŋ|", ukr: "співати (V3)", rus: "петь (V3)", snd: "sung.mp3"));
            DicArray.Add(new OneWord(eng: "travel", trk: "|ˈtrav(ə)l|", ukr: "подорожувати", rus: "путешествовать", snd: "travel.mp3"));
            DicArray.Add(new OneWord(eng: "sightseeing", trk: "|ˈsʌɪtsiːɪŋ|", ukr: "екскурсії", rus: "екскурсии", snd: "sightseeing.mp3"));
            DicArray.Add(new OneWord(eng: "swim", trk: "|swɪm|", ukr: "плавати", rus: "плавать", snd: "swim.mp3"));
            DicArray.Add(new OneWord(eng: "swam", trk: "|swæm|", ukr: "плавати (V2)", rus: "плавать (V2)", snd: "swam.mp3"));
            DicArray.Add(new OneWord(eng: "swum", trk: "|swʌm|", ukr: "плавати (V3)", rus: "плавать (V3)", snd: "swum.mp3"));
            DicArray.Add(new OneWord(eng: "sun", trk: "|sʌn|", ukr: "сонце", rus: "солнце", snd: "sun.mp3"));
            DicArray.Add(new OneWord(eng: "beach", trk: "|biːtʃ|", ukr: "пляж", rus: "пляж", snd: "beach.mp3"));
            DicArray.Add(new OneWord(eng: "picnic", trk: "|ˈpɪknɪk|", ukr: "пікнік", rus: "пикник", snd: "picnic.mp3"));
            // */
            return DicArray;
        }
    }
}
