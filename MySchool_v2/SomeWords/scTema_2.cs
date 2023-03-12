using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_2
    {
        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            //
            if (lang == "ua")
            {
                sContent_Info = "Tема 2\n";
                sContent_Info += "Одяг: shirt, tie, suit, pocket...\n";
                sContent_Info += "Їжа: milk, bread, ice...\n";
                sContent_Info += "Письмовий стіл: book, pen, pencil...";
            }
            else
            {
                sContent_Info = "Tема 2\n";
                sContent_Info += "Одежда: shirt, tie, suit, pocket...\n";
                sContent_Info += "Еда: milk, bread, ice...\n";
                sContent_Info += "Письменный стол: book, pen, pencil...";
            }
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_02\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();

            //clothes
            DicArray.Add(new OneWord(eng: "clothes", ukr: "одяг", rus: "одежда", trk: "|kləʊ(ð)z|", snd: "clothes.mp3"));
            DicArray.Add(new OneWord(eng: "shirt", ukr: "сорочка", rus: "рубашка", trk: "|ʃəːt|", snd: "shirt.mp3"));
            DicArray.Add(new OneWord(eng: "tie", ukr: "краватка", rus: "галстук", trk: "|taɪ|", snd: "tie.mp3"));
            DicArray.Add(new OneWord(eng: "suit", ukr: "костюм", rus: "костюм", trk: "|suːt|", snd: "suit.mp3"));
            DicArray.Add(new OneWord(eng: "pocket", ukr: "кишеня", rus: "карман", trk: "|ˈpɒkɪt|", snd: "pocket.mp3"));
            DicArray.Add(new OneWord(eng: "trousers", ukr: "штани", rus: "брюки", trk: "|ˈtraʊzəz|", snd: "trousers.mp3"));
            DicArray.Add(new OneWord(eng: "hat", ukr: "капелюх", rus: "шляпа", trk: "|hæt|", snd: "hat.mp3"));
            DicArray.Add(new OneWord(eng: "blouse", ukr: "блузка", rus: "блузка", trk: "|ˈblaʊz|", snd: "blouse.mp3"));
            DicArray.Add(new OneWord(eng: "jacket", ukr: "куртка, піджак", rus: "куртка, жакет", trk: "|ˈdʒakɪt|", snd: "jacket.mp3"));
            DicArray.Add(new OneWord(eng: "bag", ukr: "сумка", rus: "мешок, сумка", trk: "|bæɡ|", snd: "bag.mp3"));
            DicArray.Add(new OneWord(eng: "skirt", ukr: "спідниця", rus: "юбка", trk: "|skəːt|", snd: "skirt.mp3"));
            DicArray.Add(new OneWord(eng: "dress", ukr: "плаття", rus: "платье", trk: "|drɛs|", snd: "dress.mp3"));
            DicArray.Add(new OneWord(eng: "coat", ukr: "пальто", rus: "пальто", trk: "|ˈkəʊt|", snd: "coat.mp3"));
            DicArray.Add(new OneWord(eng: "shoe", ukr: "туфля", rus: "туфля", trk: "|ʃuː|", snd: "shoe.mp3"));     //Food
            DicArray.Add(new OneWord(eng: "food", ukr: "їжа", rus: "еда", trk: "|fuːd|", snd: "food.mp3"));
            DicArray.Add(new OneWord(eng: "drink", ukr: "напій", rus: "напиток", trk: "|drɪŋk|", snd: "drink.mp3"));
            DicArray.Add(new OneWord(eng: "bottle", ukr: "пляшка", rus: "бутылка", trk: "|ˈbɒt(ə)l|", snd: "bottle.mp3"));
            DicArray.Add(new OneWord(eng: "juice", ukr: "сік", rus: "сок", trk: "|dʒuːs|", snd: "juice.mp3"));
            DicArray.Add(new OneWord(eng: "water", ukr: "вода", rus: "вода", trk: "|ˈwɔːtə|", snd: "water.mp3"));
            DicArray.Add(new OneWord(eng: "ice", ukr: "лід", rus: "лед", trk: "|aɪs|", snd: "ice.mp3"));
            DicArray.Add(new OneWord(eng: "glass", ukr: "стакан", rus: "стакан", trk: "|ɡlɑːs|", snd: "glass.mp3"));
            DicArray.Add(new OneWord(eng: "milk", ukr: "молоко", rus: "молоко", trk: "|mɪlk|", snd: "milk.mp3"));
            DicArray.Add(new OneWord(eng: "bread", ukr: "хліб", rus: "хлеб", trk: "|brɛd|", snd: "bread.mp3"));
            DicArray.Add(new OneWord(eng: "vegetable", ukr: "овоч", rus: "овощ", trk: "|ˈvɛdʒtəb(ə)l|", snd: "vegetable.mp3"));
            DicArray.Add(new OneWord(eng: "fruit", ukr: "фрукт", rus: "фрукт", trk: "|fruːt|", snd: "fruit.mp3"));
            DicArray.Add(new OneWord(eng: "chicken", ukr: "курча", rus: "цыплёнок", trk: "|ˈtʃɪkɪn|", snd: "chicken.mp3"));
            DicArray.Add(new OneWord(eng: "salt", ukr: "сіль", rus: "соль", trk: "|sɔːlt|", snd: "salt.mp3"));
            DicArray.Add(new OneWord(eng: "tea", ukr: "чай", rus: "чай", trk: "|tiː|", snd: "tea.mp3"));
            DicArray.Add(new OneWord(eng: "cheese", ukr: "сир", rus: "сыр", trk: "|tʃiːz|", snd: "cheese.mp3"));
            DicArray.Add(new OneWord(eng: "butter", ukr: "масло", rus: "масло", trk: "|ˈbʌtə|", snd: "butter.mp3"));
            DicArray.Add(new OneWord(eng: "sugar", ukr: "цукор", rus: "сахар", trk: "|ˈʃʊɡə|", snd: "sugar.mp3"));
            DicArray.Add(new OneWord(eng: "meat", ukr: "м'ясо", rus: "мясо", trk: "|miːt|", snd: "meat.mp3"));
            DicArray.Add(new OneWord(eng: "fish", ukr: "риба", rus: "рыба", trk: "|fɪʃ|", snd: "fish.mp3"));
            DicArray.Add(new OneWord(eng: "sweets", ukr: "солодощі", rus: "сладости", trk: "|swiːt|", snd: "sweets.mp3"));
            DicArray.Add(new OneWord(eng: "spoon", ukr: "ложка", rus: "ложка", trk: "|spuːn|", snd: "spoon.mp3"));
            DicArray.Add(new OneWord(eng: "knife", ukr: "ніж", rus: "нож", trk: "|nʌɪf|", snd: "knife.mp3"));
            DicArray.Add(new OneWord(eng: "fork", ukr: "вилка", rus: "вилка", trk: "|fɔːk|", snd: "fork.mp3"));
            DicArray.Add(new OneWord(eng: "cup", ukr: "чашка", rus: "чашка", trk: "|kʌp|", snd: "cup.mp3"));
            DicArray.Add(new OneWord(eng: "saucer", ukr: "блюдце", rus: "блюдце", trk: "|ˈsɔːsə|", snd: "saucer.mp3"));
            DicArray.Add(new OneWord(eng: "plate", ukr: "тарілка", rus: "тарелка", trk: "|pleɪt|", snd: "plate.mp3")); //Письмовий стіл
            DicArray.Add(new OneWord(eng: "thing", ukr: "річ", rus: "вещь", trk: "|θɪŋ|", snd: "thing.mp3"));
            DicArray.Add(new OneWord(eng: "picture", ukr: "картина", rus: "картина", trk: "|ˈpɪktʃə|", snd: "picture.mp3"));
            DicArray.Add(new OneWord(eng: "portrait", ukr: "портрет", rus: "портрет", trk: "|ˈpɔːtrət|", snd: "portrait.mp3"));
            DicArray.Add(new OneWord(eng: "lamp", ukr: "лампа", rus: "лампа", trk: "|læmp|", snd: "lamp.mp3"));
            DicArray.Add(new OneWord(eng: "light", ukr: "світло", rus: "свет", trk: "|lʌɪt|", snd: "light.mp3"));
            DicArray.Add(new OneWord(eng: "paper", ukr: "папір", rus: "бумага", trk: "|ˈpeɪpə|", snd: "paper.mp3"));
            DicArray.Add(new OneWord(eng: "book", ukr: "книга", rus: "книга", trk: "|bʊk|", snd: "book.mp3"));
            DicArray.Add(new OneWord(eng: "page", ukr: "сторінка", rus: "страница", trk: "|peɪdʒ|", snd: "page.mp3"));
            DicArray.Add(new OneWord(eng: "fire", ukr: "вогонь", rus: "огонь", trk: "|ˈfaɪə|", snd: "fire.mp3"));
            DicArray.Add(new OneWord(eng: "sound", ukr: "звук", rus: "звук", trk: "|saʊnd|", snd: "sound.mp3"));
            DicArray.Add(new OneWord(eng: "shadow", ukr: "тінь", rus: "тень", trk: "|ˈʃadəʊ|", snd: "shadow.mp3"));
            DicArray.Add(new OneWord(eng: "spectacles", ukr: "окуляри", rus: "очки", trk: "|ˈspɛktək(ə)lz|", snd: "spectacles.mp3"));
            DicArray.Add(new OneWord(eng: "money", ukr: "гроші", rus: "деньги", trk: "|ˈmʌni|", snd: "money.mp3"));
            DicArray.Add(new OneWord(eng: "pen", ukr: "ручка", rus: "ручка", trk: "|pen|", snd: "pen.mp3"));
            DicArray.Add(new OneWord(eng: "pencil", ukr: "олівець", rus: "карандаш", trk: "|ˈpɛns(ə)l|", snd: "pencil.mp3"));
            DicArray.Add(new OneWord(eng: "air", ukr: "повітря", rus: "воздух", trk: "|eə|", snd: "air.mp3"));
            
            return DicArray;
        }
    }
}

