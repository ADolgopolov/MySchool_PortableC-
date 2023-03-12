using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_9_2
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 9.2\n";

            sContent_Info += "Answer, call, made, did, done, went...\n";
            sContent_Info += "taken, gave, given, thought, belief...\n";
            sContent_Info += "felt, wrote, written, read, told, said...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_09\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "life", trk: "|laɪf|", ukr: "життя", rus: "жизнь", snd: "life.mp3"));
            DicArray.Add(new OneWord(eng: "think", trk: "|θɪŋk|", ukr: "думати", rus: "думать", snd: "think.mp3"));
            DicArray.Add(new OneWord(eng: "thought", trk: "θɔːt", ukr: "думати (V2, V3)", rus: "думать (V2, V3)", snd: "thought.mp3"));
            DicArray.Add(new OneWord(eng: "believe", trk: "|bɪˈliːv|", ukr: "вірити", rus: "верить", snd: "believe.mp3"));
            DicArray.Add(new OneWord(eng: "belief", trk: "|bɪˈliːf|", ukr: "віра, довіра", rus: "вера, доверие", snd: "belief.mp3"));
            DicArray.Add(new OneWord(eng: "suppose", trk: "|səˈpəʊz|", ukr: "припускати", rus: "предполагать", snd: "suppose.mp3"));
            DicArray.Add(new OneWord(eng: "supposition", trk: "|ˌsʌpəˈzɪʃ(ə)n|", ukr: "припущення", rus: "предположение ", snd: "supposition.mp3"));
            DicArray.Add(new OneWord(eng: "know", trk: "|nəʊ|", ukr: "знати", rus: "знать", snd: "know.mp3"));
            DicArray.Add(new OneWord(eng: "knew", trk: "|njuː|", ukr: "знати (V2)", rus: "знать (V2)", snd: "knew.mp3"));
            DicArray.Add(new OneWord(eng: "known", trk: "|nəʊn|", ukr: "знати (V3)", rus: "знать (V3)", snd: "known.mp3"));
            DicArray.Add(new OneWord(eng: "learn", trk: "|ləːn|", ukr: "вчитися", rus: "учиться", snd: "learn.mp3"));
            DicArray.Add(new OneWord(eng: "explain", trk: "|ɪkˈspleɪn|", ukr: "пояснити", rus: "объяснять", snd: "explain.mp3"));
            DicArray.Add(new OneWord(eng: "explanation", trk: "|ɛkspləˈneɪʃ(ə)n|", ukr: "пояснення", rus: "объяснение", snd: "explanation.mp3"));
            DicArray.Add(new OneWord(eng: "understand", trk: "|ʌndəˈstand|", ukr: "зрозуміти", rus: "понимать", snd: "understand.mp3"));
            DicArray.Add(new OneWord(eng: "understood", trk: "|ʌndəˈstʊd|", ukr: "зрозуміти (V2, V3)", rus: "понимать (V2, V3)", snd: "understood.mp3"));
            DicArray.Add(new OneWord(eng: "remember", trk: "|rɪˈmɛmbə|", ukr: "запам'ятати", rus: "помнить", snd: "remember.mp3"));
            DicArray.Add(new OneWord(eng: "forget", trk: "|fəˈɡɛt|", ukr: "забувати", rus: "забывать", snd: "forget.mp3"));
            DicArray.Add(new OneWord(eng: "forgot", trk: "|fəˈɡɒt|", ukr: "забувати (V2)", rus: "забывать (V2)", snd: "forgot.mp3"));
            DicArray.Add(new OneWord(eng: "forgotten", trk: "|fəˈɡɒtn|", ukr: "забувати (V3)", rus: "забывать (V3)", snd: "forgotten.mp3"));
            DicArray.Add(new OneWord(eng: "feel", trk: "|fiːl|", ukr: "відчувати", rus: "чувствовать", snd: "feel.mp3"));
            DicArray.Add(new OneWord(eng: "felt", trk: "|felt|", ukr: "відчувати (V2, V3)", rus: "чувствовать (V2, V3)", snd: "felt.mp3"));
            DicArray.Add(new OneWord(eng: "write", trk: "|rʌɪt|", ukr: "писати", rus: "писать", snd: "write.mp3"));
            DicArray.Add(new OneWord(eng: "wrote", trk: "|rəʊt|", ukr: "писати (V2)", rus: "писать (V2)", snd: "wrote.mp3"));
            DicArray.Add(new OneWord(eng: "written", trk: "|ˈrɪtn|", ukr: "писати (V3)", rus: "писать (V3)", snd: "written.mp3"));
            DicArray.Add(new OneWord(eng: "read", trk: "|riːd|", ukr: "читати (V1, V2, V3)", rus: "читать (V1, V2, V3)", snd: "read.mp3"));
            DicArray.Add(new OneWord(eng: "talk", trk: "|ˈtɔːk|", ukr: "говорити", rus: "разговаривать", snd: "talk.mp3"));
            DicArray.Add(new OneWord(eng: "told", trk: "|təʊld|", ukr: "розказувати (V2, V3)", rus: "рассказывать (V2, V3)", snd: "told.mp3"));
            DicArray.Add(new OneWord(eng: "tell", trk: "|tel|", ukr: "розказувати", rus: "рассказывать", snd: "tell.mp3"));
            DicArray.Add(new OneWord(eng: "say", trk: "|ˈseɪ|", ukr: "сказати", rus: "сказать", snd: "say.mp3"));
            DicArray.Add(new OneWord(eng: "said", trk: "|ˈsed|", ukr: "сказати (V2, V3)", rus: "сказать (V2, V3)", snd: "said.mp3"));
            DicArray.Add(new OneWord(eng: "speak", trk: "|spiːk|", ukr: "вимовляти", rus: "говорить", snd: "speak.mp3"));
            DicArray.Add(new OneWord(eng: "spoke", trk: "|spəʊk|", ukr: "вимовляти (V2)", rus: "говорить (V2)", snd: "spoke.mp3"));
            DicArray.Add(new OneWord(eng: "spoken", trk: "|ˈspəʊk(ə)n|", ukr: "вимовляти (V3)", rus: "говорить (V3)", snd: "spoken.mp3"));
            DicArray.Add(new OneWord(eng: "speech", trk: "|spiːtʃ|", ukr: "промова", rus: "речь", snd: "speech.mp3"));
            DicArray.Add(new OneWord(eng: "question", trk: "|ˈkwɛstʃ(ə)n|", ukr: "питання", rus: "вопрос", snd: "question.mp3"));
            DicArray.Add(new OneWord(eng: "ask", trk: "|ɑːsk|", ukr: "питати", rus: "спрашивать", snd: "ask.mp3"));
            DicArray.Add(new OneWord(eng: "answer", trk: "|ˈɑːnsə|", ukr: "відповісти", rus: "отвечать", snd: "answer.mp3"));
            DicArray.Add(new OneWord(eng: "call", trk: "|kɔːl|", ukr: "викликати", rus: "звать, звонить", snd: "call.mp3"));
            // */
            return DicArray;
        }
    }
}
