using System.Collections.Generic;

namespace MySchool_v2.SomeWords
{
    public static class scTema_14_1
    {

        public static string TemaInfo(string lang)
        {
            string sContent_Info;
            sContent_Info = "Tема 14.1\n";

            sContent_Info += "Transport, plane, train, tram, car...\n";
            sContent_Info += "get on, get off, board, stop, airport...\n";
            sContent_Info += "traffic lights, timetable, change, drive...\n";
            return sContent_Info;
        }

        public static string SoundDirectory => @"Sound\mp3_14_1\";

        public static List<OneWord> GetWords()
        {
            List<OneWord> DicArray = new List<OneWord>();
            
            DicArray.Add(new OneWord(eng: "transport", trk: "|ˈtrænspɔːt|", ukr: "транспорт", rus: "транспорт", snd: "transport.mp3"));
            DicArray.Add(new OneWord(eng: "plane", trk: "|pleɪn|", ukr: "літак", rus: "самолет", snd: "plane.mp3"));
            DicArray.Add(new OneWord(eng: "train", trk: "|treɪn|", ukr: "поїзд", rus: "поезд", snd: "train.mp3"));
            DicArray.Add(new OneWord(eng: "tram", trk: "|træm|", ukr: "трамвай", rus: "трамвай", snd: "tram.mp3"));
            DicArray.Add(new OneWord(eng: "car", trk: "|kɑː|", ukr: "машина", rus: "машина", snd: "car.mp3"));
            DicArray.Add(new OneWord(eng: "bus", trk: "|bʌs|", ukr: "автобус", rus: "автобус", snd: "bus.mp3"));
            DicArray.Add(new OneWord(eng: "ship", trk: "|ʃɪp|", ukr: "корабель", rus: "корабль", snd: "ship.mp3"));
            DicArray.Add(new OneWord(eng: "boat", trk: "|bəʊt|", ukr: "човен", rus: "лодка", snd: "boat.mp3"));
            DicArray.Add(new OneWord(eng: "bicycle", trk: "|ˈbʌɪsɪk(ə)l|", ukr: "велосипед", rus: "велосипед", snd: "bicycle.mp3"));
            DicArray.Add(new OneWord(eng: "underground", trk: "|ˌʌndəˈɡraʊnd|", ukr: "метро", rus: "метро", snd: "underground.mp3"));
            DicArray.Add(new OneWord(eng: "subway", trk: "|ˈsʌbweɪ|", ukr: "метро", rus: "метро", snd: "subway.mp3"));
            DicArray.Add(new OneWord(eng: "metro", trk: "|ˈmɛtrəʊ|", ukr: "метро", rus: "метро", snd: "metro.mp3"));
            DicArray.Add(new OneWord(eng: "get in", trk: "|ˈɡet ɪn|", ukr: "входити", rus: "входить", snd: "get in.mp3"));
            DicArray.Add(new OneWord(eng: "get out", trk: "|ˈɡɛtaʊt|", ukr: "виходити", rus: "выходить", snd: "get out.mp3"));
            DicArray.Add(new OneWord(eng: "get on", trk: "|ˈɡet ɒn|", ukr: "сідати (на)", rus: "садиться (на)", snd: "get on.mp3"));
            DicArray.Add(new OneWord(eng: "get off", trk: "|ˈɡet ɒf|", ukr: "сходити", rus: "сходить", snd: "get off.mp3"));
            DicArray.Add(new OneWord(eng: "board", trk: "|bɔːd|", ukr: "сісти на борт", rus: "сесть (в поезд)", snd: "board.mp3"));
            DicArray.Add(new OneWord(eng: "stop", trk: "|stɒp|", ukr: "зупинка", rus: "остановка", snd: "stop.mp3"));
            DicArray.Add(new OneWord(eng: "airport", trk: "|ˈɛːpɔːt|", ukr: "аэропорт", rus: "аэропорт", snd: "airport.mp3"));
            DicArray.Add(new OneWord(eng: "railway station", trk: "|ˈreɪlweɪ ˈsteɪʃ(ə)n|", ukr: "вокзал", rus: "вокзал", snd: "railway station.mp3"));
            DicArray.Add(new OneWord(eng: "passenger", trk: "|ˈpasɪndʒə|", ukr: "пассажир", rus: "пассажир", snd: "passenger.mp3"));
            DicArray.Add(new OneWord(eng: "arrive", trk: "|əˈrʌɪv|", ukr: "прибути", rus: "прибывать", snd: "arrive.mp3"));
            DicArray.Add(new OneWord(eng: "depart", trk: "|dɪˈpɑːt|", ukr: "уезжать", rus: "від'їхати", snd: "depart.mp3"));
            DicArray.Add(new OneWord(eng: "departure", trk: "|dɪˈpɑːtʃə|", ukr: "отъезд", rus: "від'їзд", snd: "departure.mp3"));
            DicArray.Add(new OneWord(eng: "fare", trk: "|feə|", ukr: "вартість проїзду", rus: "плата за проезд", snd: "fare.mp3"));
            DicArray.Add(new OneWord(eng: "seat", trk: "|siːt|", ukr: "місце", rus: "место", snd: "seat.mp3"));
            DicArray.Add(new OneWord(eng: "pedestrian crossing", trk: "|pɪˈdɛstrɪən ˈkrɒsɪŋ|", ukr: "пішохідний перехід", rus: "пешеходный переход", snd: "pedestrian crossing.mp3"));
            DicArray.Add(new OneWord(eng: "traffic lights", trk: "|ˈtrafɪk lʌɪts|", ukr: "світлофор", rus: "светофор", snd: "traffic lights.mp3"));
            DicArray.Add(new OneWord(eng: "timetable", trk: "|ˈtʌɪmteɪb(ə)l|", ukr: "розклад", rus: "расписание", snd: "timetable.mp3"));
            DicArray.Add(new OneWord(eng: "change", trk: "|tʃeɪn(d)ʒ|", ukr: "змінити", rus: "менять", snd: "change.mp3"));
            DicArray.Add(new OneWord(eng: "drive", trk: "|drʌɪv|", ukr: "керувати", rus: "управлять", snd: "drive.mp3"));
            DicArray.Add(new OneWord(eng: "drove", trk: "|drəʊv|", ukr: "керувати (V2)", rus: "управлять (V2)", snd: "drove.mp3"));
            DicArray.Add(new OneWord(eng: "driven", trk: "|ˈdrɪvn|", ukr: "керувати (V3)", rus: "управлять (V3)", snd: "driven.mp3"));
            DicArray.Add(new OneWord(eng: "driver", trk: "|ˈdrʌɪvə|", ukr: "водій", rus: "водитель", snd: "driver.mp3"));
            DicArray.Add(new OneWord(eng: "driving licence", trk: "|ˈdrʌɪvɪŋ ˈlʌɪs(ə)ns|", ukr: "водійські права", rus: "водительские права", snd: "driving licence.mp3"));
            DicArray.Add(new OneWord(eng: "ride", trk: "|raɪd|", ukr: "їздити", rus: "ездить", snd: "ride.mp3"));
            DicArray.Add(new OneWord(eng: "rode", trk: "|rəʊd|", ukr: "їздити (V2)", rus: "ездить (V2)", snd: "rode.mp3"));
            DicArray.Add(new OneWord(eng: "ridden", trk: "|ˈrɪdn|", ukr: "їздити (V3)", rus: "ездить (V3)", snd: "ridden.mp3"));
            DicArray.Add(new OneWord(eng: "give lift", trk: "|ɡɪv lɪft|", ukr: "підкинути", rus: "подвести", snd: "give lift.mp3"));
            DicArray.Add(new OneWord(eng: "fly", trk: "|flaɪ|", ukr: "літати", rus: "летать", snd: "fly.mp3"));
            DicArray.Add(new OneWord(eng: "flew", trk: "|fluː|", ukr: "літати (V2)", rus: "летать (V2)", snd: "flew.mp3"));
            DicArray.Add(new OneWord(eng: "flown", trk: "|fləʊn|", ukr: "літати (V3)", rus: "летать (V3)", snd: "flown.mp3"));
            DicArray.Add(new OneWord(eng: "flight", trk: "|flʌɪt|", ukr: "політ", rus: "полет", snd: "flight.mp3"));
            DicArray.Add(new OneWord(eng: "cross", trk: "|krɒs|", ukr: "перетинати", rus: "пересекать", snd: "cross.mp3"));
            DicArray.Add(new OneWord(eng: "turn", trk: "|tɜːn|", ukr: "повертати", rus: "повернуть", snd: "turn.mp3"));
            DicArray.Add(new OneWord(eng: "follow", trk: "|ˈfɒləʊ|", ukr: "слідувати", rus: "следовать", snd: "follow.mp3"));
            DicArray.Add(new OneWord(eng: "lead", trk: "|liːd|", ukr: "вести", rus: "вести", snd: "lead.mp3"));
            DicArray.Add(new OneWord(eng: "led", trk: "|led|", ukr: "вести (V2, V3)", rus: "вести (V2, V3)", snd: "led.mp3"));
            DicArray.Add(new OneWord(eng: "quickly", trk: "|ˈkwɪkli|", ukr: "швидко", rus: "быстро", snd: "quickly.mp3"));
            DicArray.Add(new OneWord(eng: "slowly", trk: "|ˈsləʊli|", ukr: "повільно", rus: "медленно ", snd: "slowly.mp3"));
            DicArray.Add(new OneWord(eng: "speed", trk: "|spiːd|", ukr: "швидкість", rus: "скорость", snd: "speed.mp3"));
            DicArray.Add(new OneWord(eng: "hurry", trk: "|ˈhʌri|", ukr: "поспішати", rus: "торопиться", snd: "hurry.mp3"));
            DicArray.Add(new OneWord(eng: "way", trk: "|ˈweɪ|", ukr: "шлях", rus: "путь", snd: "way.mp3"));
            DicArray.Add(new OneWord(eng: "distance", trk: "|ˈdɪst(ə)ns|", ukr: "відстань", rus: "расстояние", snd: "distance.mp3"));
            // */
            return DicArray;
        }
    }
}
