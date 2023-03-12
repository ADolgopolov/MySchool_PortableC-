using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_14_2
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 14.2\n";

            sContent_Info += "Travelling, abroad, trip, business trip...\n";
            sContent_Info += "ticket office, reserve, luggage, baggage...\n";
            sContent_Info += "single room, double room, key, facilities...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_14_2\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "travelling", trk: "|ˈtravəlɪŋ|", ukr: "подорож", rus: "путешествие", snd: "travelling.mp3"));
            DicArray.Add(new OneWord(eng: "abroad", trk: "|əˈbrɔːd|", ukr: "за кордоном", rus: "за границей", snd: "abroad.mp3"));
            DicArray.Add(new OneWord(eng: "trip", trk: "|trɪp|", ukr: "поїздка", rus: "поездка", snd: "trip.mp3"));
            DicArray.Add(new OneWord(eng: "business trip", trk: "|ˈbɪznəs trɪp|", ukr: "бізнес-подорож", rus: "командировка ", snd: "business trip.mp3"));
            DicArray.Add(new OneWord(eng: "voyage", trk: "|ˈvɔɪɪdʒ|", ukr: "вояж", rus: "вояж", snd: "voyage.mp3"));
            DicArray.Add(new OneWord(eng: "tour", trk: "|tʊə|", ukr: "тур", rus: "тур", snd: "tour.mp3"));
            DicArray.Add(new OneWord(eng: "have been", trk: "|hæv biːn|", ukr: "побувати", rus: "побывал", snd: "have been.mp3"));
            DicArray.Add(new OneWord(eng: "ticket", trk: "|ˈtɪkɪt|", ukr: "квиток", rus: "билет", snd: "ticket.mp3"));
            DicArray.Add(new OneWord(eng: "return ticket", trk: "|rɪˈtəːn ˈtɪkɪt|", ukr: "зворотній квиток", rus: "обратный билет", snd: "return ticket.mp3"));
            DicArray.Add(new OneWord(eng: "one-way ticket", trk: "|wʌn-ˈweɪ ˈtɪkɪt|", ukr: "квиток в один бік", rus: "билет в один конец", snd: "one-way ticket.mp3"));
            DicArray.Add(new OneWord(eng: "ticket office", trk: "|ˈtɪkɪt ˈɒfɪs|", ukr: "каса", rus: "касса", snd: "ticket office.mp3"));
            DicArray.Add(new OneWord(eng: "reserve", trk: "|rɪˈzəːv|", ukr: "резерв", rus: "резерв", snd: "reserve.mp3"));
            DicArray.Add(new OneWord(eng: "luggage", trk: "|ˈlʌɡɪdʒ|", ukr: "багаж", rus: "багаж", snd: "luggage.mp3"));
            DicArray.Add(new OneWord(eng: "baggage", trk: "|ˈbaɡɪdʒ|", ukr: "багаж", rus: "багаж", snd: "baggage.mp3"));
            DicArray.Add(new OneWord(eng: "customs", trk: "|ˈkʌstəmz|", ukr: "митниця", rus: "таможня", snd: "customs.mp3"));
            DicArray.Add(new OneWord(eng: "check", trk: "|tʃɛk|", ukr: "перевіряти", rus: "ппроверять", snd: "check.mp3"));
            DicArray.Add(new OneWord(eng: "guide", trk: "|ɡʌɪd|", ukr: "гід", rus: "гид", snd: "guide.mp3"));
            DicArray.Add(new OneWord(eng: "reception", trk: "|rɪˈsɛpʃ(ə)n|", ukr: "ресепшн", rus: "ресепшн", snd: "reception.mp3"));
            DicArray.Add(new OneWord(eng: "receptionist", trk: "|rɪˈsɛpʃ(ə)nɪst|", ukr: "реєстратор", rus: "регистратор", snd: "receptionist.mp3"));
            DicArray.Add(new OneWord(eng: "single room", trk: "|ˈsɪŋɡ(ə)l ruːm|", ukr: "одномісний номер", rus: "одноместный номер", snd: "single room.mp3"));
            DicArray.Add(new OneWord(eng: "double room", trk: "|ˈdʌb(ə)l ruːm|", ukr: "двомісний номер", rus: "номер на двоих", snd: "double room.mp3"));
            DicArray.Add(new OneWord(eng: "key", trk: "|kiː|", ukr: "ключ", rus: "ключ", snd: "key.mp3"));
            DicArray.Add(new OneWord(eng: "facilities", trk: "|fəˈsɪlɪtɪz|", ukr: "зручності", rus: "удобства", snd: "facilities.mp3"));
            DicArray.Add(new OneWord(eng: "stay", trk: "|steɪ|", ukr: "залишатися", rus: "оставаться", snd: "stay.mp3"));
            DicArray.Add(new OneWord(eng: "rent", trk: "|rent|", ukr: "винаймати", rus: "арендовать", snd: "rent.mp3"));
            DicArray.Add(new OneWord(eng: "bill", trk: "|bɪl|", ukr: "рахунок", rus: "счет", snd: "bill.mp3"));
            DicArray.Add(new OneWord(eng: "resort", trk: "|rɪˈzɔːt|", ukr: "курорт", rus: "курорт", snd: "resort.mp3"));
            DicArray.Add(new OneWord(eng: "hope", trk: "|həʊp|", ukr: "надіятися", rus: "надеяться", snd: "hope.mp3"));
            DicArray.Add(new OneWord(eng: "afraid", trk: "|əˈfreɪd|", ukr: "боятися", rus: "бояться", snd: "afraid.mp3"));
            // */
            return DicArray;
        }
    }
}
