using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool_v2
{
    public class myLangApp
    {
        private Random _Rand = new Random();

        private List<string> _str_goodmark;
        private List<string> _str_bedmark;
        private List<string> _str_mark;

        private string _Select_one_of_the_suggested_topics;
        public string Select_one_of_the_suggested_topics => _Select_one_of_the_suggested_topics;

        private string _Dictionary_of_the_current_topic_You_just_passed;
        public string Dictionary_of_the_current_topic_You_just_passed => _Dictionary_of_the_current_topic_You_just_passed;

        private string _Grammar_of_the_current_topic_You_just_passed;
        public string Grammar_of_the_current_topic_You_just_passed => _Grammar_of_the_current_topic_You_just_passed;

        private string _Atantion;
        public string Atantion => _Atantion;

        private string _Main_Wnd_Title_sufiks;
        public string Main_Wnd_Title_sufiks => _Main_Wnd_Title_sufiks;

        private string _Content_Header;
        public string Content_Header => _Content_Header;

        private string _Dictionery_Header;
        public string Dictionery_Header => _Dictionery_Header;

        private string _Grammar_Header;
        public string Grammar_Header => _Grammar_Header;

        private string _Contacts_Header;
        public string Contacts_Header => _Contacts_Header;

        private string _CapterItem1_Header;
        public string CapterItem1_Header => _CapterItem1_Header;

        private string _CapterItem2_Header;
        public string CapterItem2_Header => _CapterItem2_Header;

        private string _CapterItem3_Header;
        public string CapterItem3_Header => _CapterItem3_Header;


        private string _GrammarTopTitle; //Заголовок "Граматики"
        public string GrammarTopTitle => _GrammarTopTitle;

        private string _true;
        public string str_true => _true;

        private string _not_true;
        public string str_not_true => _not_true;

        private string _lost;
        public string str_lost => _lost;

        private string _WordsAmount;
        public string str_WordsAmount => _WordsAmount;

        private string _Need;
        public string str_Need => _Need;

        private string _Rest_and_try_late;
        public string str_Rest_and_try_late => _Rest_and_try_late;

        private string _Fine;
        public string str_Fine => _Fine;

        private string _Mistakes;
        public string str_Mistakes => _Mistakes;

        private string _All_tsks_done;
        public string str_All_tsks_done => _All_tsks_done;

        private string _Words_Amount;
        public string str_Words_Amount => _Words_Amount;

        private string _DictioneryTopTitle; //Заголовок Словника
        public string DictioneryTopTitle => _DictioneryTopTitle;

        private string _Words_in_tema;
        public string str_Words_in_tema => _Words_in_tema;

        private string _Change_language; // Перемикач мови
        public string Change_language => _Change_language;

        public string _Contcts_Name;
        public string Contcts_Name => _Contcts_Name;
        
        public string _Contcts_Manager;
        public string Contcts_Manager => _Contcts_Manager;
        
        public string _Contcts_Wait_for_you;
        public string Contcts_Wait_for_you => _Contcts_Wait_for_you;

        public string _Contcts_Anytime_glad;
        public string Contcts_Anytime_glad => _Contcts_Anytime_glad;
        /*
        public string _Contcts_Address;
        public string Contcts_Address => _Contcts_Address;

        public string _Contcts_AddressText;
        public string Contcts_AddressText => _Contcts_AddressText;
        */
        public myLangApp(string Lang)
        {
            switch (Lang)
            {
                case "ua":
                    _Select_one_of_the_suggested_topics = "Оберіть одну із запропонованих тем.";
                    _Dictionary_of_the_current_topic_You_just_passed = "\"Словник\" обраної теми Ви щойно прошли. Повторити ще раз?";
                    _Grammar_of_the_current_topic_You_just_passed = "\"Граматику\" обраної теми Ви щойно прошли. Повторити ще раз?";
                    _Atantion = "Увага.";

                    _Main_Wnd_Title_sufiks = "My School - UA";
                    _Content_Header = "Зміст";
                    _Dictionery_Header = "Словник";
                    _Grammar_Header = "Граматика";
                    _Contacts_Header = "Контакти";

                    _CapterItem1_Header = "Частина І";
                    _CapterItem2_Header = "Частина IІ";
                    _CapterItem3_Header = "Частина IIІ";

                    _Change_language = "На русском языке";

                    #region UA Coments

                    _str_goodmark = new List<string>();
                    _str_goodmark.Add("Молодець!");
                    _str_goodmark.Add("Молодчинка!");
                    _str_goodmark.Add("Умнічка!");
                    _str_goodmark.Add("Просто геній!");
                    _str_goodmark.Add("Відмінно!");
                    _str_goodmark.Add("Дуже добре!");
                    _str_goodmark.Add("Талант!");
                    _str_goodmark.Add("Чудово!");
                    _str_goodmark.Add("Геніально!");
                    _str_goodmark.Add("Правильно!");
                    _str_goodmark.Add("Супер!");
                    _str_goodmark.Add("Добре!");

                    _str_bedmark = new List<string>();
                    _str_bedmark.Add("Неправильно.");
                    _str_bedmark.Add("Не поспішай.");
                    _str_bedmark.Add("Зконцентруйся.");
                    _str_bedmark.Add("Подумай.");
                    _str_bedmark.Add("Помилка.");
                    _str_bedmark.Add("Ні, не так.");
                    _str_bedmark.Add("Ні! Ні! Ні!");
                    _str_bedmark.Add("Не вірно.");
                    _str_bedmark.Add("Думай.");
                    _str_bedmark.Add("Погано.");
                    _str_bedmark.Add("Пригадай.");
                    _str_bedmark.Add("Запамятай.");
                    _str_bedmark.Add("Ти можеш краще.");
                    _str_bedmark.Add("Мені сумно.");
                    _str_bedmark.Add("Не спи!");

                    _str_mark = new List<string>();
                    _str_mark.Add("Ну, нарешті.");
                    _str_mark.Add("О, попав.");
                    _str_mark.Add("Продовжимо.");
                    _str_mark.Add("Головне увага.");
                    _str_mark.Add("Головне бажання.");
                    _str_mark.Add("Знайшов. Молодець.");
                    _str_mark.Add("Це всім відомо!");
                    #endregion

                    _GrammarTopTitle = "Склади з букв слово:";

                    _true = " вірно";
                    _not_true = " неправильно";
                    _lost = " залишилось";
                    _WordsAmount = "Всього слів: ";
                    _Need = "Потрібно: ";
                    _Rest_and_try_late = "Відпочинь і спробуй пізніше.";
                    _Fine = "Дуже добре!";
                    _Mistakes = "Помилок: ";
                    _All_tsks_done = "Молодець! Всі завдання виконані!!!";
                    _Words_Amount = "Кількість слів: ";

                    _DictioneryTopTitle = "Обери правильний переклад слова:";

                    _Words_in_tema = "Слів у темі: ";

                    _Contcts_Name = "Людмила Борисівна";
                    _Contcts_Manager = "Керівник центру вивчення іноземних мов «My School».";
                    _Contcts_Wait_for_you = "Чекаємо на Вас.";
                    _Contcts_Anytime_glad = "Завжди раді відповісти на Ваші запитання:";
                    /*
                    _Contcts_Address = "Адреса:";
                    _Contcts_AddressText = "м. Ірпінь, вул. Полтавська 15/2";
                    */
                    break;

                case "ru":
                    _Select_one_of_the_suggested_topics = "Выберите одну из предложеных тем.";
                    _Dictionary_of_the_current_topic_You_just_passed = "\"Словарь\" текущей темы Вы только что прошли. Повторить ещё раз?";
                    _Grammar_of_the_current_topic_You_just_passed = "\"Граматику\" текущей темы Вы только что прошли. Повторить ещё раз?";
                    _Atantion = "Внимание.";

                    _Main_Wnd_Title_sufiks = "My School - RU";
                    _Content_Header = "Содержание";
                    _Dictionery_Header = "Словарь";
                    _Grammar_Header = "Граматика";
                    _Contacts_Header = "Контакты";

                    _CapterItem1_Header = "Часть І";
                    _CapterItem2_Header = "Часть ІI";
                    _CapterItem3_Header = "Часть ІII";

                    _Change_language = "Українською мовою";

                    #region RU Coments

                    _str_goodmark = new List<string>();
                    _str_goodmark.Add("Это всем известно!");
                    _str_goodmark.Add("Молодец!");
                    _str_goodmark.Add("Молодчинка!");
                    _str_goodmark.Add("Умничка!");
                    _str_goodmark.Add("Просто гений!");
                    _str_goodmark.Add("Отлично!");
                    _str_goodmark.Add("Дуже добре!");
                    _str_goodmark.Add("Очень хорошо!");
                    _str_goodmark.Add("Прекрасно!");
                    _str_goodmark.Add("Гениально!");
                    _str_goodmark.Add("Правильно!");
                    _str_goodmark.Add("Супер!");
                    _str_goodmark.Add("Хорошо!");

                    _str_bedmark = new List<string>();
                    _str_bedmark.Add("Главное внимание.");
                    _str_bedmark.Add("Неправильно.");
                    _str_bedmark.Add("Не спеши.");
                    _str_bedmark.Add("Сконцентрируйся.");
                    _str_bedmark.Add("Подумай.");
                    _str_bedmark.Add("Ошибка.");
                    _str_bedmark.Add("Нет, не так.");
                    _str_bedmark.Add("Нет! Нет! Нет!");
                    _str_bedmark.Add("Не верно.");
                    _str_bedmark.Add("Подумай.");
                    _str_bedmark.Add("Плохо.");
                    _str_bedmark.Add("Вспомни.");
                    _str_bedmark.Add("Запомни.");
                    _str_bedmark.Add("Ты можешь лучше.");
                    _str_bedmark.Add("Мне грустно.");
                    _str_bedmark.Add("Не спи!");

                    _str_mark = new List<string>();
                    _str_mark.Add("Ну, наконец-то.");
                    _str_mark.Add("О, попал.");
                    _str_mark.Add("Продолжим.");
                    _str_mark.Add("Главное внимание.");
                    _str_mark.Add("Главное внимание.");
                    _str_mark.Add("Нашол. Молодец.");
                    _str_mark.Add("Это всем известно.");
                    #endregion

                    _GrammarTopTitle = "Сложи с букв слово:";

                    _true = " верно";
                    _not_true = " неправильно";
                    _lost = " осталось";
                    _WordsAmount = "Всего слов: ";
                    _Need = "Нужно: ";
                    _Rest_and_try_late = "Отдохни и попробуй позже.";
                    _Fine = "Очень хорошо!";
                    _Mistakes = "Ошибок: ";
                    _All_tsks_done = "Молодец! Все задания выполнены!!!";
                    _Words_Amount = "Количество слов: ";

                    _DictioneryTopTitle = "Выбери правильный перевод слова:";
                    _Words_in_tema = "Слов в теме: ";

                    _Contcts_Name = "Людмила Борисовна";
                    _Contcts_Manager = "Руководитель центра иностранных языков «My School».";
                    _Contcts_Wait_for_you = "Ждем Вас.";
                    _Contcts_Anytime_glad = "Всегда рады ответить на Ваши вопросы:";
                    /*
                    _Contcts_Address = "Адрес:";
                    _Contcts_AddressText = "г. Ирпень, вул. Полтавская 15/2";
                    */
                    break;
                default:
                    break;
            }
        }

        public string getBadMark(string curString)
        {
            //
            string newString;
            //
            do
            {
                newString = _str_bedmark[_Rand.Next(_str_bedmark.Count)];
            } while (newString == curString);
            return newString;
        }

        public string getGoodMark(string curString)
        {
            //
            string newString;
            //
            do
            {
                newString = _str_goodmark[_Rand.Next(_str_goodmark.Count)];
            } while (newString == curString);
            return newString;
        }

        public string getMark(string curString)
        {
            //
            string newString;
            //
            do
            {
                newString = _str_mark[_Rand.Next(_str_mark.Count)];
            } while (newString == curString);
            return newString;
        }
    }
}
