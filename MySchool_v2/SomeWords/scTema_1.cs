using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_1
    {
        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            if (lang == "ua")
            {
                sContent_Info = "Tема 1\n";
                sContent_Info += "Люди: men, boy, baby, name...\n";
                sContent_Info += "Сім\'я: sister, mother, parents, son...\n";
                sContent_Info += "Частини тіла: nose, eye, hand...";
            }
            else
            {
                sContent_Info = "Tема 1\n";
                sContent_Info += "Люди: men, boy, baby, name...\n";
                sContent_Info += "Семья: sister, mother, parents, son...\n";
                sContent_Info += "Части тела: nose, eye, hand...";
            }
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_01\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            //People
            DicArray.Add(new OneWord(eng: "people", ukr: "люди", rus: "люди", trk: "|ˈpiːpl|"));
            DicArray.Add(new OneWord(eng: "name", ukr: "ім'я", rus: "имя", trk: "|neɪm|"));
            DicArray.Add(new OneWord(eng: "surname", ukr: "прізвище", rus: "фамилия", trk: "|ˈsəːneɪm|"));
            DicArray.Add(new OneWord(eng: "baby", ukr: "малюк", rus: "малыш", trk: "|ˈbeɪbi|"));
            DicArray.Add(new OneWord(eng: "boy", ukr: "хлопчик", rus: "мальчик", trk: "|ˌbɔɪ|"));
            DicArray.Add(new OneWord(eng: "girl", ukr: "дівчина", rus: "девочка", trk: "|ɡɜːl|"));
            DicArray.Add(new OneWord(eng: "man", ukr: "чоловік", rus: "мужчина", trk: "|mæn|"));
            DicArray.Add(new OneWord(eng: "woman", ukr: "жінка", rus: "женщина", trk: "|ˈwʊmən|"));        //Family
            DicArray.Add(new OneWord(eng: "family", ukr: "сім'я", rus: "семья", trk: "|ˈfamɪli|"));
            DicArray.Add(new OneWord(eng: "uncle", ukr: "дядько", rus: "дядя", trk: "|ˈʌŋk(ə)l|"));
            DicArray.Add(new OneWord(eng: "aunt", ukr: "тітка", rus: "тётя", trk: "|ɑːnt|"));
            DicArray.Add(new OneWord(eng: "parents", ukr: "батьки", rus: "родители", trk: "|ˈpeərənts|"));
            DicArray.Add(new OneWord(eng: "mother", ukr: "мама", rus: "мать", trk: "|ˈmʌðə|"));
            DicArray.Add(new OneWord(eng: "father", ukr: "батько", rus: "отец", trk: "|ˈfɑːðə|"));
            DicArray.Add(new OneWord(eng: "brother", ukr: "брат", rus: "брат", trk: "|ˈbrʌðə|"));
            DicArray.Add(new OneWord(eng: "sister", ukr: "сестра", rus: "сестра", trk: "|ˈsɪstə|"));
            DicArray.Add(new OneWord(eng: "husband", ukr: "чоловік", rus: "муж, супруг", trk: "|ˈhʌzbənd|"));
            DicArray.Add(new OneWord(eng: "wife", ukr: "дружина", rus: "жена; супруга", trk: "|waɪf|"));
            DicArray.Add(new OneWord(eng: "person", ukr: "людина", rus: "человек", trk: "|ˈpəːs(ə)n|"));
            DicArray.Add(new OneWord(eng: "nephew", ukr: "племінник", rus: "племянник", trk: "|ˈnɛfjuː|"));
            DicArray.Add(new OneWord(eng: "niece", ukr: "племінниця", rus: "племянница", trk: "|niːs|"));
            DicArray.Add(new OneWord(eng: "child", ukr: "дитина", rus: "ребенок", trk: "|tʃʌɪld|"));
            DicArray.Add(new OneWord(eng: "children", ukr: "діти", rus: "дети", trk: "|ˈtʃɪldrən|"));
            DicArray.Add(new OneWord(eng: "daughter", ukr: "дочка", rus: "дочь", trk: "|ˈdɔːtə|"));
            DicArray.Add(new OneWord(eng: "son", ukr: "син", rus: "сын", trk: "|sʌn|"));
            DicArray.Add(new OneWord(eng: "relative", ukr: "родич", rus: "родственник", trk: "|ˈrɛlətɪv|"));
            DicArray.Add(new OneWord(eng: "friend", ukr: "друг", rus: "друг", trk: "|frɛnd|"));
            DicArray.Add(new OneWord(eng: "neighbour", ukr: "сусід", rus: "сосед", trk: "|ˈneɪbə|"));
            DicArray.Add(new OneWord(eng: "colleague", ukr: "колега", rus: "коллега", trk: "|ˈkɒliːɡ|"));
            DicArray.Add(new OneWord(eng: "grandmother", ukr: "бабуся", rus: "бабушка", trk: "|ˈɡran(d)mʌðə|"));
            DicArray.Add(new OneWord(eng: "grandfather", ukr: "дідусь", rus: "дедушка", trk: "|ˈɡran(d)fɑːðə|"));
            DicArray.Add(new OneWord(eng: "granddaughter", ukr: "внучка", rus: "внучка", trk: "|ˈɡrandɔːtə|"));
            DicArray.Add(new OneWord(eng: "grandson", ukr: "внук", rus: "внук", trk: "|ˈɡran(d)sʌn|"));      //Face
            DicArray.Add(new OneWord(eng: "face", ukr: "обличчя", rus: "лицо", trk: "|feɪs|"));
            DicArray.Add(new OneWord(eng: "nose", ukr: "ніс", rus: "нос", trk: "|nəʊz|"));
            DicArray.Add(new OneWord(eng: "lip", ukr: "губа", rus: "губа", trk: "|lɪp|"));
            DicArray.Add(new OneWord(eng: "mouth", ukr: "рот", rus: "рот", trk: "|maʊθ|"));
            DicArray.Add(new OneWord(eng: "eye", ukr: "око", rus: "глаз", trk: "|aɪ|"));
            DicArray.Add(new OneWord(eng: "cheek", ukr: "щока", rus: "щека", trk: "|tʃiːk|"));
            DicArray.Add(new OneWord(eng: "tooth", ukr: "зуб", rus: "зуб", trk: "|tuːθ|"));      //Human body
            DicArray.Add(new OneWord(eng: "human", ukr: "людський", rus: "человеческий", trk: "|ˈhjuːmən|"));
            DicArray.Add(new OneWord(eng: "body", ukr: "тіло", rus: "тело", trk: "|ˈbɒdi|"));
            DicArray.Add(new OneWord(eng: "head", ukr: "голова", rus: "голова", trk: "|hed|"));
            DicArray.Add(new OneWord(eng: "ear", ukr: "вухо", rus: "ухо", trk: "|ɪə|"));
            DicArray.Add(new OneWord(eng: "arm", ukr: "рука", rus: "рука", trk: "|ɑːm|"));
            DicArray.Add(new OneWord(eng: "hand", ukr: "кисть руки", rus: "кисть руки", trk: "|hænd|"));
            DicArray.Add(new OneWord(eng: "leg", ukr: "нога", rus: "нога", trk: "|leɡ|"));
            DicArray.Add(new OneWord(eng: "hair", ukr: "волосся", rus: "волосы", trk: "|heə|"));
            DicArray.Add(new OneWord(eng: "neck", ukr: "шия", rus: "шея", trk: "|nek|"));
            DicArray.Add(new OneWord(eng: "shoulder", ukr: "плече", rus: "плечо", trk: "|ˈʃəʊldə|"));
            DicArray.Add(new OneWord(eng: "finger", ukr: "палець", rus: "палец", trk: "|ˈfɪŋɡə|"));
            DicArray.Add(new OneWord(eng: "foot", ukr: "ступня", rus: "ступня", trk: "|fʊt|"));  
            return DicArray;
        }
    }
}
