using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_4
    {
        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 4\n";
            sContent_Info += "Qualities, big, little, thin, square...\n";
            sContent_Info += "wrong, right, good, pleasant...\n";
            sContent_Info += "difficult, necessary, interesting...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_04\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            //Якості
            DicArray.Add(new OneWord(eng: "quality", ukr: "якість", rus: "качество", trk: "|ˈkwɒlɪti|", snd: "quality.mp3"));
            DicArray.Add(new OneWord(eng: "big", ukr: "крупний", rus: "крупный", trk: "|bɪɡ|", snd: "big.mp3"));
            DicArray.Add(new OneWord(eng: "large", ukr: "великий", rus: "большой", trk: "|lɑːdʒ|", snd: "large.mp3"));
            DicArray.Add(new OneWord(eng: "small", ukr: "невеликий", rus: "небольшой", trk: "|smɔːl|", snd: "small.mp3"));
            DicArray.Add(new OneWord(eng: "little", ukr: "маленький", rus: "маленький", trk: "|ˈlɪt(ə)l|", snd: "little.mp3"));
            DicArray.Add(new OneWord(eng: "thick", ukr: "товстий", rus: "толстый", trk: "|θɪk|", snd: "thick.mp3"));
            DicArray.Add(new OneWord(eng: "thin", ukr: "тонкий", rus: "тонкий", trk: "|θɪn|", snd: "thin.mp3"));
            DicArray.Add(new OneWord(eng: "long", ukr: "довгий", rus: "длинный", trk: "|ˈlɒŋ|", snd: "long.mp3"));
            DicArray.Add(new OneWord(eng: "short", ukr: "короткий", rus: "короткий", trk: "|ʃɔːt|", snd: "short.mp3"));
            DicArray.Add(new OneWord(eng: "wide", ukr: "широкий", rus: "широкий", trk: "|waɪd|", snd: "wide.mp3"));
            DicArray.Add(new OneWord(eng: "narrow", ukr: "вузький", rus: "узкий", trk: "|ˈnarəʊ|", snd: "narrow.mp3"));
            DicArray.Add(new OneWord(eng: "round", ukr: "круглий", rus: "круглый", trk: "|raʊnd|", snd: "round.mp3"));
            DicArray.Add(new OneWord(eng: "square", ukr: "квадратний", rus: "квадратный", trk: "|skwɛː|", snd: "square.mp3"));
            DicArray.Add(new OneWord(eng: "high", ukr: "високий", rus: "высокий", trk: "|haɪ|", snd: "high.mp3"));
            DicArray.Add(new OneWord(eng: "low", ukr: "низький", rus: "низкий", trk: "|ləʊ|", snd: "low.mp3"));
            DicArray.Add(new OneWord(eng: "suitable", ukr: "придатний", rus: "подходящий", trk: "|ˈsuːtəb(ə)l|", snd: "suitable.mp3"));
            DicArray.Add(new OneWord(eng: "useful", ukr: "корисний", rus: "полезный", trk: "|ˈjuːsfʊl|", snd: "useful.mp3"));
            DicArray.Add(new OneWord(eng: "expensive", ukr: "дорогий", rus: "дорогой", trk: "|ɪkˈspɛnsɪv|", snd: "expensive.mp3"));
            DicArray.Add(new OneWord(eng: "cheap", ukr: "дешево", rus: "дешевый", trk: "|tʃiːp|", snd: "cheap.mp3"));
            DicArray.Add(new OneWord(eng: "wrong", ukr: "помилковий", rus: "неправильный", trk: "|rɒŋ|", snd: "wrong.mp3"));
            DicArray.Add(new OneWord(eng: "right", ukr: "правильний", rus: "правильный", trk: "|rʌɪt|", snd: "right.mp3"));
            DicArray.Add(new OneWord(eng: "true", ukr: "істинний", rus: "истинный", trk: "|truː|", snd: "true.mp3"));
            DicArray.Add(new OneWord(eng: "loud", ukr: "гучний", rus: "громкий", trk: "|laʊd|", snd: "loud.mp3"));
            DicArray.Add(new OneWord(eng: "quiet", ukr: "тихий", rus: "тихий", trk: "|ˈkwʌɪət|", snd: "quiet.mp3"));
            DicArray.Add(new OneWord(eng: "good", ukr: "хороший", rus: "хороший", trk: "|ɡʊd|", snd: "good.mp3"));
            DicArray.Add(new OneWord(eng: "bad", ukr: "поганий", rus: "плохой", trk: "|bæd|", snd: "bad.mp3"));
            DicArray.Add(new OneWord(eng: "fine", ukr: "хороший", rus: "хороший", trk: "|faɪn|", snd: "fine.mp3"));
            DicArray.Add(new OneWord(eng: "nice", ukr: "славний", rus: "славный", trk: "|naɪs|", snd: "nice.mp3"));
            DicArray.Add(new OneWord(eng: "pleasant", ukr: "приємний", rus: "приятный", trk: "|ˈplɛz(ə)nt|", snd: "pleasant.mp3"));
            DicArray.Add(new OneWord(eng: "unpleasant", ukr: "неприємний", rus: "неприятный", trk: "|ʌnˈplɛz(ə)nt|", snd: "unpleasant.mp3"));
            DicArray.Add(new OneWord(eng: "delicious", ukr: "смачний", rus: "очень вкусный", trk: "|dɪˈlɪʃəs|", snd: "delicious.mp3"));
            DicArray.Add(new OneWord(eng: "important", ukr: "важливий", rus: "важный", trk: "|ɪmˈpɔːt(ə)nt|", snd: "important.mp3"));
            DicArray.Add(new OneWord(eng: "difficult", ukr: "важкий", rus: "трудный", trk: "|ˈdɪfɪk(ə)lt|", snd: "difficult.mp3"));
            DicArray.Add(new OneWord(eng: "simple", ukr: "простий", rus: "простой", trk: "|ˈsɪmp(ə)l|", snd: "simple.mp3"));
            DicArray.Add(new OneWord(eng: "easy", ukr: "легкий", rus: "легкий", trk: "|ˈiːzi|", snd: "easy.mp3"));
            DicArray.Add(new OneWord(eng: "clear", ukr: "чистий", rus: "чистый", trk: "|klɪə|", snd: "clear.mp3"));
            DicArray.Add(new OneWord(eng: "modern", ukr: "сучасний", rus: "современный", trk: "|ˈmɒd(ə)n|", snd: "modern.mp3"));
            DicArray.Add(new OneWord(eng: "new", ukr: "новий", rus: "новый", trk: "|njuː|", snd: "new.mp3"));
            DicArray.Add(new OneWord(eng: "necessary", ukr: "необхідний", rus: "необходимый", trk: "|ˈnɛsəs(ə)ri|", snd: "necessary.mp3"));
            DicArray.Add(new OneWord(eng: "different", ukr: "різний", rus: "различный", trk: "|ˈdɪf(ə)r(ə)nt|", snd: "different.mp3"));
            DicArray.Add(new OneWord(eng: "rich", ukr: "багатий", rus: "богатый", trk: "|rɪtʃ|", snd: "rich.mp3"));
            DicArray.Add(new OneWord(eng: "poor", ukr: "бідний", rus: "бедный", trk: "|pʊə|", snd: "poor.mp3"));
            DicArray.Add(new OneWord(eng: "strong", ukr: "сильний", rus: "сильный", trk: "|strɒŋ|", snd: "strong.mp3"));
            DicArray.Add(new OneWord(eng: "weak", ukr: "слабкий", rus: "слабый", trk: "|wiːk|", snd: "weak.mp3"));
            DicArray.Add(new OneWord(eng: "lazy", ukr: "лінивий", rus: "ленивый", trk: "|ˈleɪzi|", snd: "lazy.mp3"));
            DicArray.Add(new OneWord(eng: "hard-working", ukr: "працьовитий", rus: "трудолюбивый", trk: "|ˌhɑːdˈwəːkɪŋ|", snd: "hard-working.mp3"));
            DicArray.Add(new OneWord(eng: "clever", ukr: "розумний", rus: "умный", trk: "|ˈklɛvə|", snd: "clever.mp3"));
            DicArray.Add(new OneWord(eng: "stupid", ukr: "нетямущий", rus: "глупый", trk: "|ˈstjuːpɪd|", snd: "stupid.mp3"));
            DicArray.Add(new OneWord(eng: "happy", ukr: "щасливий", rus: "счастливый", trk: "|ˈhapi|", snd: "happy.mp3"));
            DicArray.Add(new OneWord(eng: "sad", ukr: "сумний", rus: "грустный", trk: "|sæd|", snd: "sad.mp3"));
            DicArray.Add(new OneWord(eng: "honest", ukr: "чесний", rus: "честный", trk: "|ˈɒnɪst|", snd: "honest.mp3"));
            DicArray.Add(new OneWord(eng: "dishonest", ukr: "нечесний", rus: "нечестный", trk: "|dɪsˈɒnɪst|", snd: "dishonest.mp3"));
            DicArray.Add(new OneWord(eng: "interesting", ukr: "цікавий", rus: "интересный", trk: "|ˈɪnt(ə)rɪstɪŋ|", snd: "interesting.mp3"));
            DicArray.Add(new OneWord(eng: "boring", ukr: "нудний", rus: "скучный", trk: "|ˈbɔːrɪŋ|", snd: "boring.mp3"));
            DicArray.Add(new OneWord(eng: "funny", ukr: "смішний", rus: "смешной", trk: "|ˈfʌni|", snd: "funny.mp3"));
            DicArray.Add(new OneWord(eng: "serious", ukr: "серйозний", rus: "серьезный", trk: "|ˈsɪərɪəs|", snd: "serious.mp3"));
            DicArray.Add(new OneWord(eng: "angry", ukr: "сердитий", rus: "сердитый", trk: "|ˈaŋɡri|", snd: "angry.mp3"));
            DicArray.Add(new OneWord(eng: "famous", ukr: "знаменитий", rus: "известный", trk: "|ˈfeɪməs|", snd: "famous.mp3"));
            DicArray.Add(new OneWord(eng: "great", ukr: "великий", rus: "великий", trk: "|ɡreɪt|", snd: "great.mp3"));// */
            return DicArray;
        }
    }
}
