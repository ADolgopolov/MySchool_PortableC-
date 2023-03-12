using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_6
    {
        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 6\n";
            sContent_Info += "Room, floor, corner, ceiling, nursery...\n";
            sContent_Info += "Shelf, shelves, desk, chair, living-room...\n";
            sContent_Info += "Educated, knowledge, school, schoolboy...";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_06\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "room", ukr: "кімната", rus: "комната", trk: "|ruːm|"));
            DicArray.Add(new OneWord(eng: "floor", ukr: "підлога", rus: "пол", trk: "|flɔː|"));
            DicArray.Add(new OneWord(eng: "corner", ukr: "кут", rus: "угол", trk: "|ˈkɔːnə|"));
            DicArray.Add(new OneWord(eng: "ceiling", ukr: "стеля", rus: "потолок", trk: "|ˈsiːlɪŋ|"));
            DicArray.Add(new OneWord(eng: "nursery", ukr: "дитяча кімната", rus: "детская комната", trk: "|ˈnəːs(ə)ri|"));
            DicArray.Add(new OneWord(eng: "curtain", ukr: "занавіска", rus: "занавеска", trk: "|ˈkəːt(ə)n|"));
            DicArray.Add(new OneWord(eng: "bathroom", ukr: "ванна", rus: "ванная", trk: "|ˈbɑːθruːm|"));
            DicArray.Add(new OneWord(eng: "washing machine", ukr: "пральна машина", rus: "стиральная машина", trk: "|ˈwɒʃɪŋ|"));
            DicArray.Add(new OneWord(eng: "kitchen", ukr: "кухня", rus: "кухня", trk: "|ˈkɪtʃɪn|"));
            DicArray.Add(new OneWord(eng: "table", ukr: "стіл", rus: "стол", trk: "|ˈteɪbl|"));
            DicArray.Add(new OneWord(eng: "refrigerator", ukr: "холодильник", rus: "холодильник", trk: "|rɪˈfrɪdʒəreɪtə|"));
            DicArray.Add(new OneWord(eng: "stove", ukr: "плита", rus: "плита", trk: "|stəʊv|"));
            DicArray.Add(new OneWord(eng: "bedroom", ukr: "спальня", rus: "спальня ", trk: "|ˈbɛdruːm|"));
            DicArray.Add(new OneWord(eng: "furniture", ukr: "меблі", rus: "мебель", trk: "|ˈfəːnɪtʃə|"));
            DicArray.Add(new OneWord(eng: "bed", ukr: "ліжко", rus: "кровать", trk: "|bed|"));
            DicArray.Add(new OneWord(eng: "wardrobe", ukr: "гардероб", rus: "гардероб", trk: "|ˈwɔːdrəʊb|"));
            DicArray.Add(new OneWord(eng: "study", ukr: "кабінет", rus: "кабинет", trk: "|ˈstʌdi|"));
            DicArray.Add(new OneWord(eng: "bookcase", ukr: "книжкова шафа", rus: "книжный шкаф", trk: "|ˈbʊkkeɪs|"));
            DicArray.Add(new OneWord(eng: "shelf", ukr: "полиця", rus: "полка", trk: "|ʃɛlf|"));
            DicArray.Add(new OneWord(eng: "shelves", ukr: "полиці", rus: "полки", trk: "|ʃɛlvz|"));
            DicArray.Add(new OneWord(eng: "desk", ukr: "стіл", rus: "стол", trk: "|desk|"));
            DicArray.Add(new OneWord(eng: "chair", ukr: "стілець", rus: "стул", trk: "|tʃɛː|"));
            DicArray.Add(new OneWord(eng: "living-room", ukr: "вітальня", rus: "гостинная", trk: "|ˈlɪvɪŋ ruːm|"));
            DicArray.Add(new OneWord(eng: "cupboard", ukr: "буфет", rus: "буфет", trk: "|ˈkʌbəd|"));
            DicArray.Add(new OneWord(eng: "fireplace", ukr: "камін", rus: "камин", trk: "|ˈfʌɪəpleɪs|"));
            DicArray.Add(new OneWord(eng: "armchair", ukr: "крісло", rus: "кресло", trk: "|ˈɑːmtʃeə(r)|"));
            DicArray.Add(new OneWord(eng: "sofa", ukr: "диван", rus: "диван", trk: "|ˈsəʊfə|"));
            DicArray.Add(new OneWord(eng: "recorder", ukr: "магнитофон", rus: "магнитофон", trk: "|rɪˈkɔːdə|"));
            DicArray.Add(new OneWord(eng: "carpet", ukr: "килим", rus: "ковер", trk: "|ˈkɑːpɪt|"));
            DicArray.Add(new OneWord(eng: "educated", ukr: "освічений", rus: "образованный", trk: "|ˈɛdjʊkeɪtɪd|"));
            DicArray.Add(new OneWord(eng: "knowledge", ukr: "знання", rus: "знание", trk: "|ˈnɒlɪdʒ|"));
            DicArray.Add(new OneWord(eng: "school", ukr: "школа", rus: "школа", trk: "|skuːl|"));
            DicArray.Add(new OneWord(eng: "schoolboy", ukr: "школяр", rus: "школьник", trk: "|ˈskuːlbɔɪ|"));
            DicArray.Add(new OneWord(eng: "schoolgirl", ukr: "школярка", rus: "школьница", trk: "|ˈskuːlɡəːl|"));
            DicArray.Add(new OneWord(eng: "university", ukr: "університет", rus: "университет", trk: "|juːnɪˈvəːsɪti|"));
            DicArray.Add(new OneWord(eng: "pupil", ukr: "учень", rus: "ученик", trk: "|ˈpjuːpɪl|"));
            DicArray.Add(new OneWord(eng: "lesson", ukr: "урок", rus: "урок", trk: "|ˈlɛs(ə)n|"));
            DicArray.Add(new OneWord(eng: "class", ukr: "клас", rus: "класс", trk: "|klɑːs|"));
            DicArray.Add(new OneWord(eng: "lecture", ukr: "лекція", rus: "лекция", trk: "|ˈlɛktʃə|"));
            DicArray.Add(new OneWord(eng: "teacher", ukr: "вчитель", rus: "учитель", trk: "|ˈtiːtʃə|"));
            DicArray.Add(new OneWord(eng: "subject", ukr: "предмет", rus: "предмет", trk: "|ˈsʌbdʒɪkt|"));
            // */
            return DicArray;
        }
    }
}
