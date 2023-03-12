using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_5
    {
        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 5\n";
            sContent_Info += "Situated, ocean, sea, lake, countryside...\n";
            sContent_Info += "Farm, garden, plant, tree, leaf...\n";
            sContent_Info += "Building, balcony, wall, door...";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_05\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            //Якості
            DicArray.Add(new OneWord(eng: "situated", ukr: "розташований", rus: "расположенный", trk: "|ˈsɪtjueɪtɪd|"));
            DicArray.Add(new OneWord(eng: "located", ukr: "розташований", rus: "расположенный", trk: "|ləʊˈkeɪtɪd|"));
            DicArray.Add(new OneWord(eng: "where", ukr: "де, куди", rus: "где, куда", trk: "|wɛː|"));
            DicArray.Add(new OneWord(eng: "ocean", ukr: "океан", rus: "океан", trk: "|ˈəʊʃ(ə)n|"));
            DicArray.Add(new OneWord(eng: "sea", ukr: "море", rus: "море", trk: "|siː|"));
            DicArray.Add(new OneWord(eng: "lake", ukr: "озеро", rus: "озеро", trk: "|leɪk|"));
            DicArray.Add(new OneWord(eng: "river", ukr: "річка", rus: "река", trk: "|ˈrɪvə|"));
            DicArray.Add(new OneWord(eng: "island", ukr: "острів", rus: "остров", trk: "|ˈʌɪlənd|"));
            DicArray.Add(new OneWord(eng: "mountain", ukr: "гора", rus: "гора", trk: "|ˈmaʊntɪn|"));
            DicArray.Add(new OneWord(eng: "hill", ukr: "пагорб", rus: "холм", trk: "|hɪl|"));
            DicArray.Add(new OneWord(eng: "country", ukr: "країна", rus: "страна", trk: "|ˈkʌntri|"));
            DicArray.Add(new OneWord(eng: "border", ukr: "кордон", rus: "граница", trk: "|ˈbɔːdə|"));
            DicArray.Add(new OneWord(eng: "citizen", ukr: "громадянин", rus: "гражданин", trk: "|ˈsɪtɪz(ə)n|"));
            DicArray.Add(new OneWord(eng: "foreign", ukr: "іноземний", rus: "иностранный", trk: "|ˈfɒrɪn|"));
            DicArray.Add(new OneWord(eng: "city", ukr: "місто", rus: "город", trk: "|ˈsɪti|"));
            DicArray.Add(new OneWord(eng: "town", ukr: "містечко", rus: "городок", trk: "|taʊn|"));
            DicArray.Add(new OneWord(eng: "countryside", ukr: "сільська місцевість", rus: "сельская местность", trk: "|ˈkʌntrɪ sʌɪd|"));
            DicArray.Add(new OneWord(eng: "village", ukr: "село", rus: "деревня", trk: "|ˈvɪlɪdʒ|"));
            DicArray.Add(new OneWord(eng: "capital", ukr: "столиця", rus: "столица", trk: "|ˈkapɪt(ə)l|"));
            DicArray.Add(new OneWord(eng: "district", ukr: "район", rus: "район", trk: "|ˈdɪstrɪkt|"));
            DicArray.Add(new OneWord(eng: "centre", ukr: "центр", rus: "центр", trk: "|ˈsɛntə|"));
            DicArray.Add(new OneWord(eng: "street", ukr: "вулиця", rus: "улица", trk: "|striːt|"));
            DicArray.Add(new OneWord(eng: "square", ukr: "площа", rus: "площадь", trk: "|skwɛː|"));
            DicArray.Add(new OneWord(eng: "bridge", ukr: "міст", rus: "мост", trk: "|brɪdʒ|"));
            DicArray.Add(new OneWord(eng: "museum", ukr: "музей", rus: "музей", trk: "|mjuːˈzɪəm|"));
            DicArray.Add(new OneWord(eng: "palace", ukr: "палац", rus: "дворец", trk: "|ˈpalɪs|"));
            DicArray.Add(new OneWord(eng: "theatre", ukr: "театр", rus: "театр", trk: "|ˈθɪətə|"));
            DicArray.Add(new OneWord(eng: "monument", ukr: "пам'ятник", rus: "памятник", trk: "|ˈmɒnjʊm(ə)nt|"));
            DicArray.Add(new OneWord(eng: "library", ukr: "бібліотека", rus: "библиотека", trk: "|ˈlʌɪbrəri|"));
            DicArray.Add(new OneWord(eng: "hotel", ukr: "готель", rus: "отель", trk: "|həʊˈtɛl|"));//animall
            DicArray.Add(new OneWord(eng: "sky", ukr: "небо", rus: "небо", trk: "|skaɪ|"));
            DicArray.Add(new OneWord(eng: "sun", ukr: "сонце", rus: "солнце", trk: "|sʌn|"));
            DicArray.Add(new OneWord(eng: "farm", ukr: "ферма", rus: "ферма", trk: "|fɑːm|"));
            DicArray.Add(new OneWord(eng: "garden", ukr: "сад", rus: "сад", trk: "|ˈɡɑːd(ə)n|"));
            DicArray.Add(new OneWord(eng: "plant", ukr: "рослина", rus: "растение", trk: "|plɑːnt|"));
            DicArray.Add(new OneWord(eng: "tree", ukr: "дерево", rus: "дерево", trk: "|triː|"));
            DicArray.Add(new OneWord(eng: "leaf", ukr: "листок", rus: "лист", trk: "|liːf|"));
            DicArray.Add(new OneWord(eng: "leaves", ukr: "листя", rus: "листва", trk: "|liːvz|"));
            DicArray.Add(new OneWord(eng: "flower", ukr: "квітка", rus: "цветок", trk: "|ˈflaʊə|"));
            DicArray.Add(new OneWord(eng: "moon", ukr: "місяць", rus: "луна", trk: "|muːn|"));
            DicArray.Add(new OneWord(eng: "star", ukr: "зірка", rus: "звезда", trk: "|stɑː|"));
            DicArray.Add(new OneWord(eng: "forest", ukr: "ліс", rus: "лес", trk: "|ˈfɒrɪst|"));
            DicArray.Add(new OneWord(eng: "field", ukr: "поле", rus: "поле", trk: "|fiːld|"));
            DicArray.Add(new OneWord(eng: "road", ukr: "дорога", rus: "дорога", trk: "|rəʊd|"));
            DicArray.Add(new OneWord(eng: "grass", ukr: "трава", rus: "трава", trk: "|ɡrɑːs|"));
            DicArray.Add(new OneWord(eng: "ground", ukr: "земля", rus: "земля", trk: "|ɡraʊnd|"));// house p.49
            DicArray.Add(new OneWord(eng: "house", ukr: "будинок", rus: "дом", trk: "|haʊs|"));
            DicArray.Add(new OneWord(eng: "building", ukr: "будівля", rus: "здание", trk: "|ˈbɪldɪŋ|"));
            DicArray.Add(new OneWord(eng: "balcony", ukr: "балкон", rus: "балкон", trk: "|ˈbalkəni|"));
            DicArray.Add(new OneWord(eng: "wall", ukr: "стіна", rus: "стена", trk: "|wɔːl|"));
            DicArray.Add(new OneWord(eng: "door", ukr: "двері", rus: "дверь", trk: "|dɔː|"));
            DicArray.Add(new OneWord(eng: "roof", ukr: "дах", rus: "крыша", trk: "|ruːf|"));
            DicArray.Add(new OneWord(eng: "staircase", ukr: "сходи", rus: "лестница", trk: "|ˈstɛːkeɪs|"));
            DicArray.Add(new OneWord(eng: "window", ukr: "вікно", rus: "окно", trk: "|ˈwɪndəʊ|"));// */
            return DicArray;
        }
    }
}
