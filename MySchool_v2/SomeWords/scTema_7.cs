using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_7
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 7\n";
            sContent_Info += "Occupation, work, job, company...\n";
            sContent_Info += "Actor, actress, director, painter...\n";
            sContent_Info += "Busy, free, tired, responsible...";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_07\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            DicArray.Add(new OneWord(eng: "occupation", ukr: "професія", rus: "профессия", trk: "|ɒkjʊˈpeɪʃ(ə)n|"));
            DicArray.Add(new OneWord(eng: "work", ukr: "робота", rus: "работа", trk: "|ˈwɜːk|"));
            DicArray.Add(new OneWord(eng: "job", ukr: "праця", rus: "труд", trk: "|dʒɒb|"));
            DicArray.Add(new OneWord(eng: "company", ukr: "компанія", rus: "компания", trk: "|ˈkʌmp(ə)ni|"));
            DicArray.Add(new OneWord(eng: "organization", ukr: "організація", rus: "организация", trk: "|ɔːɡ(ə)nʌɪˈzeɪʃ(ə)n|"));
            DicArray.Add(new OneWord(eng: "owner", ukr: "власник", rus: "владелец", trk: "|ˈəʊnə|"));
            DicArray.Add(new OneWord(eng: "property", ukr: "власність", rus: "собственность", trk: "|ˈprɒpəti|"));
            DicArray.Add(new OneWord(eng: "employee", ukr: "працівник", rus: "работник", trk: "|ɛmplɔɪˈiː|"));
            DicArray.Add(new OneWord(eng: "staff", ukr: "персонал", rus: "персонал", trk: "|stɑːf|"));
            DicArray.Add(new OneWord(eng: "secretary", ukr: "секретар", rus: "секретарь", trk: "|ˈsɛkrɪt(ə)ri|"));
            DicArray.Add(new OneWord(eng: "accountant", ukr: "бухгалтер", rus: "бухгалтер", trk: "|əˈkaʊnt(ə)nt|"));
            DicArray.Add(new OneWord(eng: "doctor", ukr: "лікар", rus: "доктор", trk: "|ˈdɒktə|"));
            DicArray.Add(new OneWord(eng: "engineer", ukr: "інженер", rus: "инженер", trk: "|ɛndʒɪˈnɪə|"));
            DicArray.Add(new OneWord(eng: "politician", ukr: "політик", rus: "политик", trk: "|pɒlɪˈtɪʃ(ə)n|"));
            DicArray.Add(new OneWord(eng: "lawyer", ukr: "юрист", rus: "юрист", trk: "|ˈlɔːjə|"));
            DicArray.Add(new OneWord(eng: "law", ukr: "закон", rus: "закон", trk: "|lɔː|"));
            DicArray.Add(new OneWord(eng: "military", ukr: "військовий", rus: "военный", trk: "|ˈmɪlɪt(ə)ri|"));
            DicArray.Add(new OneWord(eng: "science", ukr: "наука", rus: "наука", trk: "|ˈsʌɪəns|"));
            DicArray.Add(new OneWord(eng: "art", ukr: "мистецтво", rus: "искусство", trk: "|ɑːt|"));
            DicArray.Add(new OneWord(eng: "literature", ukr: "література", rus: "литература", trk: "|ˈlɪt(ə)rətʃə|"));
            DicArray.Add(new OneWord(eng: "media", ukr: "ЗМІ", rus: "СМИ", trk: "|ˈmiːdɪə|"));
            DicArray.Add(new OneWord(eng: "musician", ukr: "музикант", rus: "музыкант", trk: "|mjuːˈzɪʃ(ə)n|"));
            DicArray.Add(new OneWord(eng: "composer", ukr: "композитор", rus: "композитор", trk: "|kəmˈpəʊzə|"));
            DicArray.Add(new OneWord(eng: "song", ukr: "пісня", rus: "песня", trk: "|sɒŋ|"));
            DicArray.Add(new OneWord(eng: "singer", ukr: "співак", rus: "певец", trk: "|ˈsɪŋə|"));
            DicArray.Add(new OneWord(eng: "movie", ukr: "кіно", rus: "кино", trk: "|ˈmuːvi|"));
            DicArray.Add(new OneWord(eng: "film", ukr: "фільм", rus: "фильм", trk: "|fɪlm|"));
            DicArray.Add(new OneWord(eng: "soap", ukr: "мило", rus: "мыло", trk: "|səʊp|"));
            DicArray.Add(new OneWord(eng: "opera", ukr: "опера", rus: "опера", trk: "|ˈɒp(ə)rə|"));
            DicArray.Add(new OneWord(eng: "actor", ukr: "актор", rus: "актер", trk: "|ˈaktə|"));
            DicArray.Add(new OneWord(eng: "actress", ukr: "актриса", rus: "актриса", trk: "|ˈaktrəs|"));
            DicArray.Add(new OneWord(eng: "director", ukr: "режисер", rus: "режиссер", trk: "|dɪˈrɛktə|"));
            DicArray.Add(new OneWord(eng: "painter", ukr: "художник", rus: "художник", trk: "|ˈpeɪntə|"));
            DicArray.Add(new OneWord(eng: "painting", ukr: "живопис", rus: "живопись", trk: "|ˈpeɪntɪŋ|"));
            DicArray.Add(new OneWord(eng: "sculptor", ukr: "скульптор", rus: "скульптор", trk: "|ˈskʌlptə|"));
            DicArray.Add(new OneWord(eng: "sculpture", ukr: "скульптура", rus: "скульптура", trk: "|ˈskʌlptʃə|"));
            DicArray.Add(new OneWord(eng: "architect", ukr: "архітектор", rus: "архитектор", trk: "|ˈɑːkɪtɛkt|"));
            DicArray.Add(new OneWord(eng: "architecture", ukr: "архітектура", rus: "архитектура", trk: "|ˈɑːkɪtɛktʃə|"));
            DicArray.Add(new OneWord(eng: "writer", ukr: "письменник", rus: "писатель", trk: "|ˈrʌɪtə|"));
            DicArray.Add(new OneWord(eng: "poet", ukr: "поет", rus: "поэт", trk: "|ˈpəʊɪt|"));
            DicArray.Add(new OneWord(eng: "novel", ukr: "роман", rus: "роман", trk: "|ˈnɑːvl|"));
            DicArray.Add(new OneWord(eng: "story", ukr: "оповідання", rus: "рассказ", trk: "|ˈstɔːri|"));
            DicArray.Add(new OneWord(eng: "newspaper", ukr: "газета", rus: "газета", trk: "|ˈnjuːzpeɪpə|"));
            DicArray.Add(new OneWord(eng: "magazine", ukr: "журнал", rus: "журнал", trk: "|maɡəˈziːn|"));
            DicArray.Add(new OneWord(eng: "news", ukr: "новини", rus: "новости", trk: "|njuːz|"));
            DicArray.Add(new OneWord(eng: "journalist", ukr: "журналіст", rus: "журналист", trk: "|ˈdʒəːn(ə)lɪst|"));
            DicArray.Add(new OneWord(eng: "talented", ukr: "талановитий", rus: "талантливый", trk: "|ˈtaləntɪd|"));
            DicArray.Add(new OneWord(eng: "genius", ukr: "геній", rus: "гений", trk: "|ˈdʒiːnɪəs|"));
            DicArray.Add(new OneWord(eng: "favourite", ukr: "улюблений", rus: "любимый", trk: "|ˈfeɪv(ə)rɪt|"));
            DicArray.Add(new OneWord(eng: "popular", ukr: "популярний", rus: "популярный", trk: "|ˈpɒpjʊlə|"));
            DicArray.Add(new OneWord(eng: "proud", ukr: "гордий", rus: "гордый", trk: "|praʊd|"));
            DicArray.Add(new OneWord(eng: "typical", ukr: "типовий", rus: "типичный", trk: "|ˈtɪpɪk(ə)l|"));
            DicArray.Add(new OneWord(eng: "busy", ukr: "зайнятий", rus: "занятой", trk: "|ˈbɪzi|"));
            DicArray.Add(new OneWord(eng: "free", ukr: "вільний", rus: "свободный", trk: "|friː|"));
            DicArray.Add(new OneWord(eng: "tired", ukr: "втомлений", rus: "уставший", trk: "|tʌɪəd|"));
            DicArray.Add(new OneWord(eng: "responsible", ukr: "відповідальний", rus: "ответственный", trk: "|rɪˈspɒnsɪb(ə)l|"));
            DicArray.Add(new OneWord(eng: "responsibility", ukr: "відповідальність", rus: "ответственность", trk: "|rɪˌspɒnsɪˈbɪlɪti|"));
            DicArray.Add(new OneWord(eng: "good", ukr: "хороший", rus: "хороший", trk: "|ɡʊd|"));
            // */
            return DicArray;
        }
    }
}
