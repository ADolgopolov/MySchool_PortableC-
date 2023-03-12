using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_3
    {
        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            if (lang == "ua")
            {
                sContent_Info = "Tема 3\n";
                sContent_Info += "Частини, вид: part, group, sort...\n";
                sContent_Info += "Кольори: black, white, red...\n";
                sContent_Info += "Вік: age, old, young...";
            }
            else
            {
                sContent_Info = "Tема 3\n";
                sContent_Info += "Части, вид: part, group, sort...\n";
                sContent_Info += "Цвета: black, white, red...\n";
                sContent_Info += "Возраст: age, old, young...";
            }
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_03\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            //Частина
            DicArray.Add(new OneWord(eng: "piece", ukr: "шматок", rus: "кусок", trk: "|piːs|", snd: "piece.mp3"));
            DicArray.Add(new OneWord(eng: "part", ukr: "частина", rus: "часть", trk: "|pɑːt|", snd: "part.mp3"));
            DicArray.Add(new OneWord(eng: "member", ukr: "член", rus: "член", trk: "|ˈmɛmbə|", snd: "member.mp3"));
            DicArray.Add(new OneWord(eng: "group", ukr: "група", rus: "группа", trk: "|ɡruːp|", snd: "group.mp3"));
            DicArray.Add(new OneWord(eng: "type", ukr: "тип", rus: "тип", trk: "|taɪp|", snd: "type.mp3"));
            DicArray.Add(new OneWord(eng: "kind", ukr: "вид", rus: "вид", trk: "|kaɪnd|", snd: "kind.mp3"));
            DicArray.Add(new OneWord(eng: "sort", ukr: "сорт", rus: "сорт", trk: "|sɔːt|", snd: "sort.mp3"));      //Запитання
            DicArray.Add(new OneWord(eng: "who", ukr: "хто", rus: "кто", trk: "|huː|", snd: "who.mp3"));
            DicArray.Add(new OneWord(eng: "what", ukr: "що", rus: "что", trk: "|ˈwɒt|", snd: "what.mp3"));
            DicArray.Add(new OneWord(eng: "whose", ukr: "чий", rus: "чей", trk: "|huːz|", snd: "whose.mp3"));      //Колір
            DicArray.Add(new OneWord(eng: "red", ukr: "червоний", rus: "красный", trk: "|red|", snd: "red.mp3"));
            DicArray.Add(new OneWord(eng: "black", ukr: "чорний", rus: "черный", trk: "|blak|", snd: "black.mp3"));
            DicArray.Add(new OneWord(eng: "green", ukr: "зелений", rus: "зеленый", trk: "|ɡriːn|", snd: "green.mp3"));
            DicArray.Add(new OneWord(eng: "orange", ukr: "оранжевий", rus: "оранжевый", trk: "|ˈɒrɪn(d)ʒ|", snd: "orange.mp3"));
            DicArray.Add(new OneWord(eng: "purple", ukr: "фіолетовий", rus: "фиолетовый", trk: "|ˈpəːp(ə)l|", snd: "purple.mp3"));
            DicArray.Add(new OneWord(eng: "yellow", ukr: "жовтий", rus: "желтый", trk: "|ˈjɛləʊ|", snd: "yellow.mp3"));
            DicArray.Add(new OneWord(eng: "blue", ukr: "синій", rus: "синий", trk: "|bluː|", snd: "blue.mp3"));
            DicArray.Add(new OneWord(eng: "brown", ukr: "коричневий", rus: "коричневый", trk: "|braʊn|", snd: "brown.mp3"));
            DicArray.Add(new OneWord(eng: "pink", ukr: "рожевий", rus: "розовый", trk: "|pɪŋk|", snd: "pink.mp3"));
            DicArray.Add(new OneWord(eng: "grey", ukr: "сірий", rus: "серый", trk: "|ɡreɪ|", snd: "grey.mp3"));
            DicArray.Add(new OneWord(eng: "white", ukr: "білий", rus: "белый", trk: "|wʌɪt|", snd: "white.mp3"));
            DicArray.Add(new OneWord(eng: "dark", ukr: "темний", rus: "темный", trk: "|dɑːk|", snd: "dark.mp3"));
            DicArray.Add(new OneWord(eng: "light", ukr: "світлий", rus: "светлый", trk: "|lʌɪt|", snd: "light.mp3"));      //Возраст
            DicArray.Add(new OneWord(eng: "age", ukr: "вік", rus: "возраст", trk: "|eɪdʒ|", snd: "age.mp3"));
            DicArray.Add(new OneWord(eng: "old", ukr: "старий", rus: "старый", trk: "|əʊld|", snd: "old.mp3"));
            DicArray.Add(new OneWord(eng: "young", ukr: "молодий", rus: "молодой", trk: "|jʌŋ|", snd: "young.mp3"));
            DicArray.Add(new OneWord(eng: "middle-aged", ukr: "середнього віку", rus: "среднего возраста", trk: "|ˈmɪd(ə)l - eɪdʒd|", snd: "middle-aged.mp3"));     //зовнішність
            DicArray.Add(new OneWord(eng: "appearance", ukr: "зовнішність", rus: "внешность", trk: "|əˈpɪər(ə)ns|", snd: "appearance.mp3"));
            DicArray.Add(new OneWord(eng: "beautiful", ukr: "гарний", rus: "прекрасный", trk: "|ˈbjuːtɪfʊl|", snd: "beautiful.mp3"));
            DicArray.Add(new OneWord(eng: "handsome", ukr: "красивий", rus: "красивый", trk: "|ˈhans(ə)m|", snd: "handsome.mp3"));
            DicArray.Add(new OneWord(eng: "ugly", ukr: "потворний", rus: "уродливый", trk: "|ˈʌɡli|", snd: "ugly.mp3"));
            DicArray.Add(new OneWord(eng: "slim", ukr: "стрункий", rus: "стройный", trk: "|slɪm|", snd: "slim.mp3"));
            DicArray.Add(new OneWord(eng: "stout", ukr: "товстий", rus: "толстый", trk: "|staʊt|", snd: "stout.mp3"));
            DicArray.Add(new OneWord(eng: "tall", ukr: "високий", rus: "высокий", trk: "|tɔːl|", snd: "tall.mp3"));
            DicArray.Add(new OneWord(eng: "short", ukr: "короткий", rus: "короткий", trk: "|ʃɔːt|", snd: "short.mp3"));  //Температура
            DicArray.Add(new OneWord(eng: "temperature", ukr: "температура", rus: "температура", trk: "|ˈtɛmp(ə)rətʃə|", snd: "temperature.mp3"));
            DicArray.Add(new OneWord(eng: "cold", ukr: "холодний", rus: "холодный", trk: "|kəʊld|", snd: "cold.mp3"));
            DicArray.Add(new OneWord(eng: "hot", ukr: "гарячий", rus: "горячий", trk: "|hɒt|", snd: "hot.mp3"));
            DicArray.Add(new OneWord(eng: "warm", ukr: "теплий", rus: "теплый", trk: "|wɔːm|", snd: "warm.mp3"));        //вага
            DicArray.Add(new OneWord(eng: "weight", ukr: "вага", rus: "вес", trk: "|weɪt|", snd: "weight.mp3"));
            DicArray.Add(new OneWord(eng: "heavy", ukr: "важкий", rus: "тяжелый", trk: "|ˈhɛvi|", snd: "heavy.mp3"));
            DicArray.Add(new OneWord(eng: "light", ukr: "легкий", rus: "легкий", trk: "|lʌɪt|", snd: "light.mp3"));
            DicArray.Add(new OneWord(eng: "size", ukr: "розмір", rus: "размер", trk: "|saɪz|", snd: "size.mp3"));
            DicArray.Add(new OneWord(eng: "shape", ukr: "форма", rus: "форма", trk: "|ʃeɪp|", snd: "shape.mp3"));        //Прислівники
            DicArray.Add(new OneWord(eng: "really", ukr: "дійсно", rus: "действительно", trk: "|ˈrɪəli|", snd: "really.mp3"));
            DicArray.Add(new OneWord(eng: "real", ukr: "дійсний", rus: "действительный", trk: "|rɪəl|", snd: "real.mp3"));
            DicArray.Add(new OneWord(eng: "slightly", ukr: "трохи, злегка", rus: "слегка, едва", trk: "|ˈslʌɪtli|", snd: "slightly.mp3"));
            DicArray.Add(new OneWord(eng: "slight", ukr: "незначний", rus: "незначительный", trk: "|slʌɪt|", snd: "slight.mp3"));
            DicArray.Add(new OneWord(eng: "completely", ukr: "повністю", rus: "полностью", trk: "|kəmˈpliːtli|", snd: "completely.mp3"));
            DicArray.Add(new OneWord(eng: "complete", ukr: "повний", rus: "полный", trk: "|kəmˈpliːt|", snd: "complete.mp3"));
            DicArray.Add(new OneWord(eng: "absolutely", ukr: "абсолютно", rus: "абсолютно", trk: "|ˈabsəluːtli|", snd: "absolutely.mp3"));
            DicArray.Add(new OneWord(eng: "absolute", ukr: "абсолютний", rus: "абсолютный", trk: "|ˈabsəluːt|", snd: "absolute.mp3"));
            DicArray.Add(new OneWord(eng: "fairly", ukr: "чесно", rus: "честно", trk: "|ˈfɛːli|", snd: "fairly.mp3"));
            DicArray.Add(new OneWord(eng: "awfully", ukr: "жахливо", rus: "ужасно", trk: "|ˈɔːfʊli|", snd: "awfully.mp3"));
            DicArray.Add(new OneWord(eng: "awful", ukr: "жахливий", rus: "ужасный", trk: "|ˈɔːfʊl|", snd: "awful.mp3"));
            DicArray.Add(new OneWord(eng: "terribly", ukr: "страшно", rus: "страшно", trk: "|ˈtɛrɪbli|", snd: "terribly.mp3"));
            DicArray.Add(new OneWord(eng: "terrible", ukr: "страшний", rus: "страшный", trk: "|ˈtɛrɪb(ə)l|", snd: "terrible.mp3")); //
            DicArray.Add(new OneWord(eng: "this", ukr: "цей", rus: "этот", trk: "|ðɪs|", snd: "this.mp3"));
            DicArray.Add(new OneWord(eng: "these", ukr: "ці", rus: "эти", trk: "|ðiːz|", snd: "these.mp3"));
            DicArray.Add(new OneWord(eng: "that", ukr: "той", rus: "тот", trk: "|ðæt|", snd: "that.mp3"));
            DicArray.Add(new OneWord(eng: "those", ukr: "ті", rus: "те", trk: "|ðəʊz|", snd: "those.mp3"));
            DicArray.Add(new OneWord(eng: "it", ukr: "це, воно", rus: "это, оно", trk: "|ɪt|", snd: "it.mp3"));
            DicArray.Add(new OneWord(eng: "how", ukr: "як", rus: "как", trk: "|ˈhaʊ|", snd: "how.mp3"));
            // */
            return DicArray;
        }
    }
}
