using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_19_2
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 19.2\n";

            sContent_Info += "Service, client, service station...\n";
            sContent_Info += "barber`s, barber, repair shop, repair...\n";
            sContent_Info += "photographer, dry cleaner`s, laundry...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_19_2\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "service", trk: "|ˈsəːvɪs|", ukr: "обслуговування", rus: "обслуживание", snd: "service.mp3"));
            DicArray.Add(new OneWord(eng: "client", trk: "|ˈklʌɪənt|", ukr: "клієнт", rus: "клиент", snd: "client.mp3"));
            DicArray.Add(new OneWord(eng: "service station", trk: "|ˈsəːvɪs ˈsteɪʃ(ə)n|", ukr: "станція техобслуговування", rus: "станция техобслуживания", snd: "service station.mp3"));
            DicArray.Add(new OneWord(eng: "mechanic", trk: "|mɪˈkanɪk|", ukr: "механік", rus: "механик", snd: "mechanic.mp3"));
            DicArray.Add(new OneWord(eng: "cut", trk: "|kʌt|", ukr: "стригти (V1, V2, V3)", rus: "стригти (V1, V2, V3)", snd: "cut.mp3"));
            DicArray.Add(new OneWord(eng: "haircut", trk: "|ˈhɛːkʌt|", ukr: "стрижка", rus: "стрижка", snd: "haircut.mp3"));
            DicArray.Add(new OneWord(eng: "style", trk: "|stʌɪl|", ukr: "стиль", rus: "стиль", snd: "style.mp3"));
            DicArray.Add(new OneWord(eng: "hairdresser`s", trk: "|ˈhɛːdrɛsə`s|", ukr: "перукарня", rus: "парикмахерская", snd: "hairdresser`s.mp3"));
            DicArray.Add(new OneWord(eng: "hairdresser", trk: "|ˈhɛːdrɛsə|", ukr: "перукар", rus: "парикмахер ", snd: "hairdresser.mp3"));
            DicArray.Add(new OneWord(eng: "barber`s", trk: "|ˈbɑːbə`s|", ukr: "перукарня", rus: "парикмахерская", snd: "barber`s.mp3"));
            DicArray.Add(new OneWord(eng: "barber", trk: "|ˈbɑːbə|", ukr: "цирюльник", rus: "цирюльник", snd: "barber.mp3"));
            DicArray.Add(new OneWord(eng: "repair shop", trk: "|rɪˈpɛː ʃɒp|", ukr: "ремонтна майстерня", rus: "ремонтная мастерская", snd: "repair shop.mp3"));
            DicArray.Add(new OneWord(eng: "repair", trk: "|rɪˈpɛː|", ukr: "ремонтировать", rus: "лагодити", snd: "repair.mp3"));
            DicArray.Add(new OneWord(eng: "tailor`s", trk: "|ˈteɪlə|", ukr: "кравецька крамниця", rus: "ателье пошива", snd: "tailor`s.mp3"));
            DicArray.Add(new OneWord(eng: "tailor", trk: "|ˈteɪlə|", ukr: "кравець", rus: "портной", snd: "tailor.mp3"));
            DicArray.Add(new OneWord(eng: "redecorate", trk: "|riːˈdɛkəreɪt|", ukr: "реконструювати", rus: "делать косметический ремонт", snd: "redecorate.mp3"));
            DicArray.Add(new OneWord(eng: "deliver", trk: "|dɪˈlɪvə|", ukr: "доставляти", rus: "поставлять", snd: "deliver.mp3"));
            DicArray.Add(new OneWord(eng: "workman", trk: "|ˈwəːkmən|", ukr: "робітник", rus: "работник", snd: "workman.mp3"));
            DicArray.Add(new OneWord(eng: "test", trk: "|ˈtest|", ukr: "перевіряти", rus: "проверять ", snd: "test.mp3"));
            DicArray.Add(new OneWord(eng: "photographer`s", trk: "|fəˈtɒɡrəfə`s|", ukr: "фотостудия", rus: "фотостудия", snd: "photographer`s.mp3"));
            DicArray.Add(new OneWord(eng: "photographer", trk: "|fəˈtɒɡrəfə|", ukr: "фотограф", rus: "фотограф", snd: "photographer.mp3"));
            DicArray.Add(new OneWord(eng: "dry cleaner`s", trk: "|draɪ ˈkliːnə`s|", ukr: "хімчистка", rus: "химчистка", snd: "dry cleaner`s.mp3"));
            DicArray.Add(new OneWord(eng: "laundry", trk: "|ˈlɔːndri|", ukr: "пральня", rus: "прачечная", snd: "laundry.mp3"));
            DicArray.Add(new OneWord(eng: "available", trk: "|əˈveɪləb(ə)l|", ukr: "доступний", rus: "доступный", snd: "available.mp3"));
            DicArray.Add(new OneWord(eng: "restaurant", trk: "|ˈrɛst(ə)rɒnt|", ukr: "ресторан", rus: "ресторан", snd: "restaurant.mp3"));
            DicArray.Add(new OneWord(eng: "snack bar", trk: "|snak bɑː|", ukr: "закусочна", rus: "закусочная ", snd: "snack bar.mp3"));
            DicArray.Add(new OneWord(eng: "snack", trk: "|snak|", ukr: "закуска", rus: "закуска", snd: "snack.mp3"));
            DicArray.Add(new OneWord(eng: "order", trk: "|ˈɔːdə|", ukr: "замовлення", rus: "заказ", snd: "order.mp3"));
            DicArray.Add(new OneWord(eng: "waiter", trk: "|ˈweɪtə|", ukr: "офіціант", rus: "официант", snd: "waiter.mp3"));
            DicArray.Add(new OneWord(eng: "waitress", trk: "|ˈweɪtrəs|", ukr: "офіціантка", rus: "официантка", snd: "waitress.mp3"));
            DicArray.Add(new OneWord(eng: "tip", trk: "|ˈtɪp|", ukr: "чайові", rus: "чаевые", snd: "tip.mp3"));
            DicArray.Add(new OneWord(eng: "dial", trk: "|ˈdaɪəl|", ukr: "набрати номер", rus: "набирать номер", snd: "dial.mp3"));
            DicArray.Add(new OneWord(eng: "ring", trk: "|rɪŋ|", ukr: "дзвонити", rus: "звонить", snd: "ring.mp3"));
            DicArray.Add(new OneWord(eng: "rang", trk: "|ræŋ|", ukr: "дзвонити (V2)", rus: "звонить (V2)", snd: "rang.mp3"));
            DicArray.Add(new OneWord(eng: "rung", trk: "|rʌŋ|", ukr: "дзвонити (V3)", rus: "звонить (V3)", snd: "rung.mp3"));
            DicArray.Add(new OneWord(eng: "ring up", trk: "|rɪŋ ʌp|", ukr: "телефонувати", rus: "звонить телефону", snd: "ring up.mp3"));
            DicArray.Add(new OneWord(eng: "answering machine", trk: "|ˈɑːnsərɪŋ məˈʃiːn|", ukr: "автовідповідач", rus: "автоответчик ", snd: "answering machine.mp3"));
            DicArray.Add(new OneWord(eng: "letter", trk: "|ˈlɛtə|", ukr: "лист", rus: "письмо", snd: "letter.mp3"));
            DicArray.Add(new OneWord(eng: "send", trk: "|send|", ukr: "відправити", rus: "отправлять", snd: "send.mp3"));
            DicArray.Add(new OneWord(eng: "sent", trk: "|sent|", ukr: "відправити (V2, V3)", rus: "отправлять (V2, V3)", snd: "sent.mp3"));
            DicArray.Add(new OneWord(eng: "receive", trk: "|rɪˈsiːv|", ukr: "отримувати", rus: "получать", snd: "receive.mp3"));
            DicArray.Add(new OneWord(eng: "envelope", trk: "|ˈɛnvələʊp|", ukr: "конверт", rus: "конверт", snd: "envelope.mp3"));
            DicArray.Add(new OneWord(eng: "stamp", trk: "|stamp|", ukr: "марка", rus: "марка", snd: "stamp.mp3"));
            DicArray.Add(new OneWord(eng: "address", trk: "|əˈdrɛs|", ukr: "адреса", rus: "адрес", snd: "address.mp3"));
            DicArray.Add(new OneWord(eng: "return address", trk: "|rɪˈtəːn əˈdrɛs|", ukr: "зворотня адреса", rus: "обратный адрес ", snd: "return address.mp3"));
            DicArray.Add(new OneWord(eng: "message", trk: "|ˈmɛsɪdʒ|", ukr: "повідомлення", rus: "сообщение", snd: "message.mp3"));
            DicArray.Add(new OneWord(eng: "a leave message", trk: "|liːv ˈmɛsɪdʒ|", ukr: "залишити повідомлення", rus: "оставить сообщение", snd: "leave message.mp3"));
            DicArray.Add(new OneWord(eng: "post", trk: "|pəʊst|", ukr: "пошта", rus: "почта", snd: "post.mp3"));
            DicArray.Add(new OneWord(eng: "post office", trk: "|pəʊst ˈɒfɪs|", ukr: "поштамт", rus: "почтовое отделение", snd: "post office.mp3"));
            // */
            return DicArray;
        }
    }
}
