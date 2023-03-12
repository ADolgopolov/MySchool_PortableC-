using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MySchool_v2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _appLanguage;
        internal string appLanguage => _appLanguage;
        internal myLangApp LangApp;

        internal List<OneWord> DicArray = new List<OneWord>();
        internal string CurTemaSoundDirectory;

        private myDictionery myD;
        private myGrammar myG;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitWndItems()
        {
            // Подписуєм заголовки вікна і закладок
            this.Title = LangApp.Main_Wnd_Title_sufiks;
            TabItemContent.Header = LangApp.Content_Header;
            TabItemDictionery.Header = LangApp.Dictionery_Header;
            TabItemGrammar.Header = LangApp.Grammar_Header;
            //TabItemContacts.Header = LangApp.Contacts_Header;

            l_Content_Info.Content = LangApp.Select_one_of_the_suggested_topics;
            l_Lang.Content = LangApp.Change_language;//"На русском языке";

            // Наповнюємо дерево
            TreeViewItem ContentItem, CapterItem1;
            /*------*/ TreeViewItem CapterItem2, CapterItem3;
            TreeViewItem curItem;

            ContentItem = new TreeViewItem();
            ContentItem.Header = LangApp.Content_Header;
            ContentItem.Tag = "Content";
            ContentItem.IsExpanded = true;

            CapterItem1 = new TreeViewItem();
            CapterItem1.Header = LangApp.CapterItem1_Header;
            CapterItem1.Tag = "Chapter1";
            CapterItem1.IsExpanded = true;
            #region Fill Chapter 1
            curItem = new TreeViewItem(); curItem.Header = "Тема 1"; curItem.Tag = "Tema1"; CapterItem1.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 2"; curItem.Tag = "Tema2"; CapterItem1.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 3"; curItem.Tag = "Tema3"; CapterItem1.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 4"; curItem.Tag = "Tema4"; CapterItem1.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 5"; curItem.Tag = "Tema5"; CapterItem1.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 6"; curItem.Tag = "Tema6"; CapterItem1.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 7"; curItem.Tag = "Tema7"; CapterItem1.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 8"; curItem.Tag = "Tema8"; CapterItem1.Items.Add(curItem);
            #endregion
            ContentItem.Items.Add(CapterItem1);
            // /*
            CapterItem2 = new TreeViewItem();
            CapterItem2.Header = LangApp.CapterItem2_Header;
            CapterItem2.Tag = "Chapter2";
            //CapterItem2.IsExpanded = true;
            #region Fill Chapter 2
            curItem = new TreeViewItem(); curItem.Header = "Тема 9.1"; curItem.Tag = "Tema91"; CapterItem2.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 9.2"; curItem.Tag = "Tema92"; CapterItem2.Items.Add(curItem);

            curItem = new TreeViewItem(); curItem.Header = "Тема 10.1"; curItem.Tag = "Tema101"; CapterItem2.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 10.2"; curItem.Tag = "Tema102"; CapterItem2.Items.Add(curItem);

            curItem = new TreeViewItem(); curItem.Header = "Тема 11.1"; curItem.Tag = "Tema111"; CapterItem2.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 11.2"; curItem.Tag = "Tema112"; CapterItem2.Items.Add(curItem);

            curItem = new TreeViewItem(); curItem.Header = "Тема 12.1"; curItem.Tag = "Tema121"; CapterItem2.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 12.2"; curItem.Tag = "Tema122"; CapterItem2.Items.Add(curItem);

            curItem = new TreeViewItem(); curItem.Header = "Тема 13.1"; curItem.Tag = "Tema131"; CapterItem2.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 13.2"; curItem.Tag = "Tema132"; CapterItem2.Items.Add(curItem);

            curItem = new TreeViewItem(); curItem.Header = "Тема 14.1"; curItem.Tag = "Tema141"; CapterItem2.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 14.2"; curItem.Tag = "Tema142"; CapterItem2.Items.Add(curItem);

            curItem = new TreeViewItem(); curItem.Header = "Тема 15.1"; curItem.Tag = "Tema151"; CapterItem2.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 15.2"; curItem.Tag = "Tema152"; CapterItem2.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 15.3"; curItem.Tag = "Tema153"; CapterItem2.Items.Add(curItem);
            #endregion
            ContentItem.Items.Add(CapterItem2);

            CapterItem3 = new TreeViewItem();
            CapterItem3.Header = LangApp.CapterItem3_Header;
            CapterItem3.Tag = "Chapter3";
            //CapterItem3.IsExpanded = true;
            #region Fill Chapter 3
            curItem = new TreeViewItem(); curItem.Header = "Тема 16"; curItem.Tag = "Tema16"; CapterItem3.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 17.1"; curItem.Tag = "Tema171"; CapterItem3.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 17.2"; curItem.Tag = "Tema172"; CapterItem3.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 18"; curItem.Tag = "Tema18"; CapterItem3.Items.Add(curItem);

            curItem = new TreeViewItem(); curItem.Header = "Тема 19.1"; curItem.Tag = "Tema191"; CapterItem3.Items.Add(curItem);
            curItem = new TreeViewItem(); curItem.Header = "Тема 19.2"; curItem.Tag = "Tema192"; CapterItem3.Items.Add(curItem);
            #endregion
            ContentItem.Items.Add(CapterItem3);
            // */
            ContentTreeView.Items.Clear();
            ContentTreeView.Items.Add(ContentItem);
            // Закладка контактів
            Cntcts_Name.Text = LangApp.Contcts_Name;
            Cntcts_Manager.Text = LangApp.Contcts_Manager;
            Cntcts_Wait_for_you.Text = LangApp.Contcts_Wait_for_you;
            Cntcts_Anytime_glad.Text = LangApp.Contcts_Anytime_glad;
            /*
            Cntcts_Address.Text = LangApp.Contcts_Address;
            Cntcts_AddressText.Text = LangApp.Contcts_AddressText;
            */
        }

        private void mainWnd_Initialized(object sender, EventArgs e)
        {
            /*
            LangWnd LanguageSettingsWindow = new LangWnd();
            LanguageSettingsWindow.ShowDialog();
            if (LanguageSettings.isUkrainianLanguage)
             appLanguage = "ua";
            else appLanguage = "ru";
            */

            /*
             * Откриваем в регістрі ключ MySchool,
             * або створюємо новий.
             */
            RegistryKey KeyMySchool = Registry.CurrentUser.OpenSubKey("MySchool");
            if (KeyMySchool != null)
            {
                _appLanguage = KeyMySchool.GetValue("Lang").ToString();
            }
            else
            {
                _appLanguage = "ua";
                KeyMySchool = Registry.CurrentUser.CreateSubKey("MySchool");
                KeyMySchool.SetValue("Lang", _appLanguage);
            }
            KeyMySchool.Close();

            //Ініціалізуєм "Клас МОВИ"
            LangApp = new myLangApp(appLanguage);

            // Наповнюємо написами вікно
            InitWndItems();
        }

        private void mainWnd_Closed(object sender, EventArgs e)
        {
            RegistryKey KeyMySchool = Registry.CurrentUser.CreateSubKey("MySchool");
            KeyMySchool.SetValue("Lang", _appLanguage);
            KeyMySchool.Close();
        }

        private void mainWnd_Loaded(object sender, RoutedEventArgs e)
        {
            /* якщо користувач не обрав теми: 
            * за замовчуванням,
            * обираємо тему № 1;
            * ще на загрузці вікна
            * підгружаємо слова першої теми.
            */
            //"Tema1":
            l_Content_Info.Content = MySchool_v2.SomeWords.scTema_1.TemaInfo(appLanguage);
            this.DicArray = MySchool_v2.SomeWords.scTema_1.GetWords();
            this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_1.SoundDirectory;
            StartDictioneryClass();
            StartGrammarClass();
        }

        // Подія при виділені пункта на TreeView
        private void ContentTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem Itm = ContentTreeView.SelectedItem as TreeViewItem;
            if (Itm != null)
            {
                string sTag = (string)Itm.Tag;

                bool bRefreshClasses = true;

                switch (sTag)
                {
                    case "Content":
                    case "Chapter1":
                    case "Chapter2":
                    case "Chapter3":
                        l_Content_Info.Content = LangApp.Select_one_of_the_suggested_topics;
                        // Відміняємо перезагрузку Класів.
                        bRefreshClasses = false;
                        break;
                    case "Tema1":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_1.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_1.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_1.SoundDirectory;
                        break;
                    case "Tema2":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_2.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_2.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_2.SoundDirectory;
                        break;

                    case "Tema3":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_3.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_3.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_3.SoundDirectory;
                        break;

                    case "Tema4":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_4.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_4.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_4.SoundDirectory;
                        break;

                    case "Tema5":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_5.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_5.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_5.SoundDirectory;
                        break;

                    case "Tema6":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_6.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_6.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_6.SoundDirectory;
                        break;

                    case "Tema7":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_7.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_7.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_7.SoundDirectory;
                        break;

                    case "Tema8":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_8.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_8.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_8.SoundDirectory;
                        break;

                    case "Tema91":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_9_1.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_9_1.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_9_1.SoundDirectory;
                        break;

                    case "Tema92":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_9_2.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_9_2.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_9_2.SoundDirectory;
                        break;

                    case "Tema101":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_10_1.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_10_1.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_10_1.SoundDirectory;
                        break;

                    case "Tema102":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_10_2.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_10_2.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_10_2.SoundDirectory;
                        break;

                    case "Tema111":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_11_1.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_11_1.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_11_1.SoundDirectory;
                        break;

                    case "Tema112":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_11_2.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_11_2.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_11_2.SoundDirectory;
                        break;

                    case "Tema121":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_12_1.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_12_1.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_12_1.SoundDirectory;
                        break;

                    case "Tema122":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_12_2.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_12_2.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_12_2.SoundDirectory;
                        break;

                    case "Tema131":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_13_1.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_13_1.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_13_1.SoundDirectory;
                        break;

                    case "Tema132":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_13_2.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_13_2.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_13_2.SoundDirectory;
                        break;

                    case "Tema141":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_14_1.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_14_1.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_14_1.SoundDirectory;
                        break;

                    case "Tema142":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_14_2.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_14_2.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_14_2.SoundDirectory;
                        break;

                    case "Tema151":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_15_1.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_15_1.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_15_1.SoundDirectory;
                        break;

                    case "Tema152":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_15_2.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_15_2.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_15_2.SoundDirectory;
                        break;

                    case "Tema153":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_15_3.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_15_3.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_15_3.SoundDirectory;
                        break;

                    case "Tema16":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_16.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_16.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_16.SoundDirectory;
                        break;

                    case "Tema171":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_17_1.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_17_1.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_17_1.SoundDirectory;
                        break;

                    case "Tema172":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_17_2.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_17_2.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_17_2.SoundDirectory;
                        break;

                    case "Tema18":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_18.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_18.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_18.SoundDirectory;
                        break;

                    case "Tema191":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_19_1.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_19_1.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_19_1.SoundDirectory;
                        break;

                    case "Tema192":
                        l_Content_Info.Content = MySchool_v2.SomeWords.scTema_19_2.TemaInfo(appLanguage);
                        this.DicArray = MySchool_v2.SomeWords.scTema_19_2.GetWords();
                        this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_19_2.SoundDirectory;
                        break;

                    default:
                        l_Content_Info.Content = $"Theme <{Itm.Header}> is not ready.";
                        bRefreshClasses = false;
                        break;
                }

                // Перезапускаєм класи.
                // якщо була вибрана, хоча б одна з тем
                if (bRefreshClasses)
                {
                    StartDictioneryClass();
                    StartGrammarClass();
                }
            }
        }
        
        // Подія при виборі закладки
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabControl tabControl = sender as TabControl; 
            TabItem item = tabControl.SelectedValue as TabItem;

            // SelectionChanged перехоплює фокус, тому тут потрібно його і повернути
            // інакше цю сторінку не буде виділено після роботи MessageBox.
            if (item != null)
            {
                item.Focus();
                /*
                * 1) грузяться слова, коли користувач вибирає елемент в TreeView
                * (або Тема 1 за замовчуванням призагрузці вікна див. mainWnd_Initialized())
                * 
                * 2) при виборі закладки ініціюється клас, що відповідає за подальшу роботу
                */
                switch (item.Name)
                {
                    case "TabItemDictionery":
                        if (myD.ClassProgramCompled)
                        {
                            // Програма класа пройдена. Питаєм користувача чи потрібно перегрузити клас?
                            if (MessageBox.Show(LangApp.Dictionary_of_the_current_topic_You_just_passed, LangApp.Atantion,
                                    MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                            {
                                StartDictioneryClass();
                            }
                        }
                        break;
                    case "TabItemGrammar":
                        if (myG.ClassProgramCompled)
                        {
                            // Програма класа пройдена. Питаєм користувача чи потрібно перегрузити клас?
                            if (MessageBox.Show(LangApp.Grammar_of_the_current_topic_You_just_passed, LangApp.Atantion,
                                    MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
                            {
                                StartGrammarClass();
                            }
                        }
                        break;
                    default: //TabItemContent
                        break;
                }
            }
        }
        
        private void StartDictioneryClass()
        {
            if (myD != null) {
                // оцепляєм делегати на кнопках
                // тоді попередній екземпляр класу не буде
                // слухать кнопки і точно здохне.
                myD.MyDictioneryDestructor(); }
            myD = new myDictionery(this);
            myD.OnLoad();
        }

        private void StartGrammarClass()
        {
            if (myG != null) {
                // оцепляєм делегати на кнопках
                // тоді попередній екземпляр класу не буде
                // слухать кнопки і точно здохне.
                myG.MyGrammarDestructor(); }
            myG = new myGrammar(this);
            myG.OnLoad();
        }

        #region  Service Procedures For ProgressBars

        internal void SetProgressBar(double SeccesPer, double DangerPer, double ProgressPer)
        {
            if (SeccesPer >= 0 && DangerPer >= 0 && ProgressPer >= 0) // виникли проблеми з нескінченним дробом 0.1
            {
                BarGreen.Width = new GridLength(SeccesPer, GridUnitType.Star);
                BarRed.Width = new GridLength(DangerPer, GridUnitType.Star);
                BarBlue.Width = new GridLength(ProgressPer, GridUnitType.Star);
            }
        }

        internal void SetProgressBar_ForGram(double SeccesPer, double DangerPer, double ProgressPer)
        {
            if (SeccesPer >= 0 && DangerPer >= 0 && ProgressPer >= 0) // виникли проблеми з нескінченним дробом 0.1
            {
                BarGreen_Gramm.Width = new GridLength(SeccesPer, GridUnitType.Star);
                BarRed_Gramm.Width = new GridLength(DangerPer, GridUnitType.Star);
                BarBlue_Gramm.Width = new GridLength(ProgressPer, GridUnitType.Star);
            }
        }

        internal void TextProgressBar(string sSeccesPer, string sDangerPer, string sProgressPer)
        {
            double WindWith = this.ActualWidth - 20.0;

            if (BarGreen.Width.Value * WindWith > 60)
            { // Якщо ширина контейнера більша відзазначеної виводим текст
                l_Seccess.Content = sSeccesPer;
            }
            else { l_Seccess.Content = ""; }

            if (BarRed.Width.Value * WindWith > 100.0)
            { // Якщо ширина контейнера більша відзазначеної виводим текст
                l_Danger.Content = sDangerPer;
            }
            else { l_Danger.Content = ""; }

            if (BarBlue.Width.Value * WindWith > 60.0)
            { // Якщо ширина контейнера більша відзазначеної виводим текст
                l_Progress.Content = sProgressPer;
            }
            else { l_Progress.Content = ""; }
        }

        internal void TextProgressBar_ForGram(string sSeccesPer, string sDangerPer, string sProgressPer)
        {
            double WindWith = this.ActualWidth - 20.0;

            if (BarGreen_Gramm.Width.Value * WindWith > 60)
            { // Якщо ширина контейнера більша відзазначеної виводим текст
                l_Seccess_Gramm.Content = sSeccesPer;
            }
            else { l_Seccess_Gramm.Content = ""; }

            if (BarRed_Gramm.Width.Value * WindWith > 110.0)
            { // Якщо ширина контейнера більша відзазначеної виводим текст
                l_Danger_Gramm.Content = sDangerPer;
            }
            else { l_Danger_Gramm.Content = ""; }

            if (BarBlue_Gramm.Width.Value * WindWith > 60.0)
            { // Якщо ширина контейнера більша відзазначеної виводим текст
                l_Progress_Gramm.Content = sProgressPer;
            }
            else { l_Progress_Gramm.Content = ""; }
        }

        #endregion

        private void MyEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                //Call the Process.Start method to open the default browser 
                //with a URL:
                System.Diagnostics.Process.Start("mailto:andriy.dolgopolov@gmail.com");
            }
            catch
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void l_Label_MouseEnter(object sender, MouseEventArgs e)
        {
            Label l_label = sender as Label;
            l_label.Foreground = Brushes.Yellow;
        }

        private void l_Label_MouseLeave(object sender, MouseEventArgs e)
        {
            Label l_label = sender as Label;
            l_label.Foreground = Brushes.LightGoldenrodYellow;
        }

        private void l_Lang_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_appLanguage == "ru")
            {
                _appLanguage = "ua";

                l_Lang.Content = "На русском языке";
            }
            else
            {
                _appLanguage = "ru";

                l_Lang.Content = "Українською мовою";
            }

            //Ініціалізуєм "Клас МОВИ"
            LangApp = new myLangApp(appLanguage);

            // Наповнюємо написами вікно
            InitWndItems();

            //"Tema1":
            l_Content_Info.Content = MySchool_v2.SomeWords.scTema_1.TemaInfo(appLanguage);
            this.DicArray = MySchool_v2.SomeWords.scTema_1.GetWords();
            this.CurTemaSoundDirectory = MySchool_v2.SomeWords.scTema_1.SoundDirectory;
            StartDictioneryClass();
            StartGrammarClass();
        }

        private void TxtBlock_MySiteLink_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                //Call the Process.Start method to open the default browser 
                //with a URL:
                System.Diagnostics.Process.Start("https://myschool.inf.ua/index.html");
            }
            catch
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
    }
}
