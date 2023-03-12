using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_17_1
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 17.1\n";

            sContent_Info += "Trade, shop, store, grocer`s, grocer...\n";
            sContent_Info += "deal, make a deal, sign, signature, rely...\n";
            sContent_Info += "fall ill, illness, sick, recover, cure...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_17\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "trade", trk: "|treɪd|", ukr: "торгівля", rus: "торговля", snd: "trade.mp3"));
            DicArray.Add(new OneWord(eng: "shop", trk: "|ʃɒp|", ukr: "магазин", rus: "магазин", snd: "shop.mp3"));
            DicArray.Add(new OneWord(eng: "store", trk: "|stɔː|", ukr: "магазин, склад", rus: "магазин, склад", snd: "store.mp3"));
            DicArray.Add(new OneWord(eng: "grocer`s", trk: "|ˈɡrəʊsə`s|", ukr: "бакалійний магазин", rus: "бакалейная лавка", snd: "grocer.mp3"));
            DicArray.Add(new OneWord(eng: "grocer", trk: "|ˈɡrəʊsə|", ukr: "бакалійник", rus: "бакалейщик", snd: "grocer.mp3"));

            DicArray.Add(new OneWord(eng: "butcher`s", trk: "|ˈbʊtʃə`s|", ukr: "м'ясний магазин", rus: "мясной магазин", snd: "butcher`s.mp3"));
            DicArray.Add(new OneWord(eng: "butcher", trk: "|ˈbʊtʃə|", ukr: "м'ясник", rus: "мясник", snd: "butcher.mp3"));
            DicArray.Add(new OneWord(eng: "bakery", trk: "|ˈbeɪk(ə)ri|", ukr: "булочна", rus: "булочная", snd: "bakery.mp3"));
            DicArray.Add(new OneWord(eng: "sell", trk: "|sel|", ukr: "продавати", rus: "продавать", snd: "sell.mp3"));
            DicArray.Add(new OneWord(eng: "sold", trk: "|səʊld|", ukr: "продавати (V2, V3)", rus: "продавать (V2, V3)", snd: "sold.mp3"));
            DicArray.Add(new OneWord(eng: "sale", trk: "|seɪl|", ukr: "продаж, розпродаж", rus: "продажа, распродажа", snd: "sale.mp3"));
            DicArray.Add(new OneWord(eng: "goods", trk: "|ɡʊdz|", ukr: "товари", rus: "товары", snd: "goods.mp3"));
            DicArray.Add(new OneWord(eng: "shop assistant", trk: "|ʃɒp əˈsɪstənt|", ukr: "продавець", rus: "продавец", snd: "shop assistant.mp3"));
            DicArray.Add(new OneWord(eng: "cashier", trk: "|kaˈʃɪə|", ukr: "касир", rus: "кассир", snd: "cashier.mp3"));
            DicArray.Add(new OneWord(eng: "customer", trk: "|ˈkʌstəmə|", ukr: "покупець", rus: "покупатель", snd: "customer.mp3"));
            DicArray.Add(new OneWord(eng: "department store", trk: "|dɪˈpɑːrtmənt stɔː|", ukr: "універмаг", rus: "универмаг", snd: "department store.mp3"));
            DicArray.Add(new OneWord(eng: "purchase", trk: "|ˈpəːtʃɪs|", ukr: "покупка", rus: "покупка", snd: "purchase.mp3"));
            DicArray.Add(new OneWord(eng: "advertise", trk: "|ˈadvətʌɪz|", ukr: "рекламувати", rus: "рекламировать", snd: "advertise.mp3"));
            DicArray.Add(new OneWord(eng: "advertisement", trk: "|ˌædvərˈtaɪzmənt|", ukr: "реклама", rus: "реклама", snd: "advertisement.mp3"));
            DicArray.Add(new OneWord(eng: "try on", trk: "|ˈtraɪ ɒn|", ukr: "приміряти", rus: "примерять", snd: "try on.mp3"));
            DicArray.Add(new OneWord(eng: "dressing room", trk: "|ˈdresɪŋ ruːm|", ukr: "примірочна", rus: "примерочная", snd: "dressing room.mp3"));
            DicArray.Add(new OneWord(eng: "suit", trk: "|suːt|", ukr: "пасувати", rus: "подходить", snd: "suit.mp3"));
            DicArray.Add(new OneWord(eng: "fit", trk: "|fɪt|", ukr: "бути до міри", rus: "быть впору", snd: "fit.mp3"));
            DicArray.Add(new OneWord(eng: "credit card", trk: "|ˈkrɛdɪt kɑːd|", ukr: "кредитна карта ", rus: "кредитная карта ", snd: "credit card.mp3"));
            DicArray.Add(new OneWord(eng: "coin", trk: "|kɔɪn|", ukr: "монета", rus: "монета", snd: "coin.mp3"));
            DicArray.Add(new OneWord(eng: "cash", trk: "|kæʃ|", ukr: "готівка", rus: "наличные деньги", snd: "cash.mp3"));
            DicArray.Add(new OneWord(eng: "account", trk: "|əˈkaʊnt|", ukr: "рахунок", rus: "счет", snd: "account.mp3"));
            DicArray.Add(new OneWord(eng: "discount", trk: "|ˈdɪskaʊnt|", ukr: "знижка", rus: "скидка", snd: "discount.mp3"));
            DicArray.Add(new OneWord(eng: "free", trk: "|friː|", ukr: "безкоштовно", rus: "бесплатно", snd: "free.mp3"));
            DicArray.Add(new OneWord(eng: "change", trk: "|tʃeɪndʒ|", ukr: "здача", rus: "здача", snd: "change.mp3"));
            DicArray.Add(new OneWord(eng: "borrow", trk: "|ˈbɒrəʊ|", ukr: "позичати", rus: "занимать, брать на время", snd: "borrow.mp3"));
            DicArray.Add(new OneWord(eng: "owe", trk: "|əʊ|", ukr: "бути в боргу", rus: "быть должным", snd: "owe.mp3"));
            DicArray.Add(new OneWord(eng: "debt", trk: "|det|", ukr: "борг", rus: "долг", snd: "debt.mp3"));
            DicArray.Add(new OneWord(eng: "lend", trk: "|lend|", ukr: "позичити", rus: "давать в долг", snd: "lend.mp3"));
            DicArray.Add(new OneWord(eng: "lent", trk: "|lent|", ukr: "позичити (V2, V3)", rus: "давать взаймы (V2, V3)", snd: "lent.mp3"));
            // */
            return DicArray;
        }
    }
}
