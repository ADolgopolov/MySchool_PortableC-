using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace MySchool_v2
{


    public static class ExtensionMethods
    {
        private static Action EmptyDelegate = delegate () { };

        public static void Refresh(this UIElement uiElement)
        {
            uiElement.Dispatcher.Invoke(DispatcherPriority.Render, EmptyDelegate);
        }
    }

    public class OneWord
    {
        public string eng { get; }
        public string trk { get; }
        public string ukr { get; }
        public string rus { get; }
        public string snd { get; }

        public OneWord(string eng, string trk, string ukr, string rus, string snd)
        {
            this.eng = eng;
            this.trk = trk;
            this.ukr = ukr;
            this.rus = rus;
            this.snd = snd;
        }
        public OneWord(string eng, string trk, string ukr, string rus)
        {
            this.eng = eng;
            this.trk = trk;
            this.ukr = ukr;
            this.rus = rus;
            this.snd = eng + ".mp3";
        }
    }

    class myDictionery
    {
        private bool _ClassProgramCompled = false;
        public bool ClassProgramCompled { get { return _ClassProgramCompled; } }

        private Label TopTitle;
        private Label AskBtn;
        private Label button1;
        private Label button2;
        private Label button3;
        private Label button4;
        private Label button5;
        private Label StatusBar;
        
        private List<OneWord> workDicArray;

        // Local var
        private int currentQuestion_n;
        private bool isFirstTimeClick = true;
        private int wrongAnsers = 0;

        private Random Rand = new Random();
        
        private MainWindow mainWnd;

        public myDictionery(MainWindow mWnd)
        {
            mainWnd = mWnd;

            TopTitle = mWnd.l_titleDic;
            AskBtn = mWnd.btn_ask;

            button1 = mWnd.button1;
            button2 = mWnd.button2;
            button3 = mWnd.button3;
            button4 = mWnd.button4;
            button5 = mWnd.button5;
            StatusBar = mWnd.l_Comment;

            
            //AskBtn.AddHandler(UIElement.MouseDownEvent, new RoutedEventHandler(Sound_Click));
            AskBtn.MouseDown += Sound_Click;

            button1.MouseDown += Button_Click;
            button2.MouseDown += Button_Click;
            button3.MouseDown += Button_Click;
            button4.MouseDown += Button_Click;
            button5.MouseDown += Button_Click;

        }

        public void MyDictioneryDestructor()
        {
            //AskBtn.RemoveHandler(UIElement.MouseDownEvent, new RoutedEventHandler(Sound_Click));
            AskBtn.MouseDown -= Sound_Click;

            button1.MouseDown -= Button_Click;
            button2.MouseDown -= Button_Click;
            button3.MouseDown -= Button_Click;
            button4.MouseDown -= Button_Click;
            button5.MouseDown -= Button_Click;
        }


        public void OnLoad()
        {
            TopTitle.Content = mainWnd.LangApp.DictioneryTopTitle;
            workDicArray = new List<OneWord>(mainWnd.DicArray);
            fillData();
            showMsgStatusBar(mainWnd.LangApp.str_Words_in_tema + workDicArray.Count);
        }

        private void setButtonStyleDefault(Label btn)
        {
            btn.Style = (Style)btn.FindResource("ButtonStyle_anseWordDefoult");
        }

        private void setButtonStyleRightMark(Label btn)
        {
            btn.Style = (Style)btn.FindResource("ButtonStyle_anseWordRight");
        }

        private void setButtonStyleWrongMark(Label btn)
        {
            btn.Style = (Style)btn.FindResource("ButtonStyle_anseWordWrong");
        }

        private string getRandomGoodMark()
        {
            //
            return mainWnd.LangApp.getGoodMark((string)StatusBar.Content);
            //
        }

        private void Sound_Click(object sender, RoutedEventArgs e)
        {
            if (!ClassProgramCompled)
            {
                StatusBar.Content = $"{workDicArray[currentQuestion_n].eng} - {workDicArray[currentQuestion_n].trk}";
                StatusBar.Foreground = (Brush)StatusBar.FindResource("StatusBar_Color_Black");

                MediaPlayer _mp = new MediaPlayer();
                string _uri;
                try
                {
                    _uri = Environment.CurrentDirectory;
                    _uri += @"\";
                    _uri += mainWnd.CurTemaSoundDirectory;
                    _uri += workDicArray[currentQuestion_n].snd;
                    if (File.Exists(_uri))
                    {
                        _mp.Open(new Uri(_uri, UriKind.Absolute));
                        _mp.Play();
                    }
                    else
                    {
                        _uri = mainWnd.CurTemaSoundDirectory;
                        _uri += workDicArray[currentQuestion_n].snd;
                        Uri u = new Uri(_uri, UriKind.Relative);
                        _mp.Open(u);
                        _mp.Play();
                    }
                }
                catch
                {
                    MessageBox.Show("Cann`t find this file with sound." );
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Label thisBtn = (Label)sender;
            if (!ClassProgramCompled)
            {
                string strTrueAnswer;
                if (mainWnd.appLanguage == "ua") { strTrueAnswer = workDicArray[currentQuestion_n].ukr; }
                else { strTrueAnswer = workDicArray[currentQuestion_n].rus; }
                if (isFirstTimeClick)
                {
                    isFirstTimeClick = false;

                    if ((string)thisBtn.Content == strTrueAnswer)
                    {
                        // right answer:
                        // delete this word from work array;
                        workDicArray.RemoveAt(currentQuestion_n);

                        // mark right answer button;
                        setButtonStyleRightMark(thisBtn);

                        showMsgStatusBar(getRandomGoodMark());
                        StatusBar.Foreground = (Brush)StatusBar.FindResource("StatusBar_Color_Green");
                        // вибираєм слідуюче слово
                        isFirstTimeClick = true;
                        thisBtn.Refresh();

                        System.Threading.Thread.Sleep(300);
                        // вибираєм слідуюче слово
                        fillData();
                    }
                    else
                    {
                        // wrong answer:
                        wrongAnsers += 1;
                        // mark right answer button;
                        if (strTrueAnswer == (string)button1.Content)
                        {
                            setButtonStyleRightMark(button1);
                        }
                        else
                        {
                            if (strTrueAnswer == (string)button2.Content)
                            {
                                setButtonStyleRightMark(button2);
                            }
                            else
                            {
                                if (strTrueAnswer == (string)button3.Content)
                                {
                                    setButtonStyleRightMark(button3);
                                }
                                else
                                {
                                    if (strTrueAnswer == (string)button4.Content)
                                    {
                                        setButtonStyleRightMark(button4);
                                    }
                                    else
                                    {
                                        if (strTrueAnswer == (string)button5.Content)
                                        {
                                            setButtonStyleRightMark(button5);
                                        }
                                    }
                                }
                            }
                        }
                        // mark wrong answer;
                        setButtonStyleWrongMark(thisBtn);

                        showMsgStatusBar(getRandomBadMark());
                        StatusBar.Foreground = (Brush)StatusBar.FindResource("StatusBar_Color_Red");
                    }
                }
                else
                {
                    if ((string)thisBtn.Content == strTrueAnswer)
                    {
                        isFirstTimeClick = true;
                        fillData();
                    }
                }
            }
        }

        private int getRandomNumber(int amount)
        {
            return Rand.Next(amount);
        }

        private string getRandomRusWord(string exceptWord)
        {
            string rusWord = exceptWord;
            //
            while (rusWord == exceptWord)
            {
                rusWord = mainWnd.DicArray[getRandomNumber(mainWnd.DicArray.Count)].rus;
            }
            return rusWord;
        }

        private List<string> getWrongAnswersArrRus(string rightAnswer)
        {
            string word;
            List<string> wordsArr = new List<string>();
            while (wordsArr.Count < 4)
            {
                word = getRandomRusWord(rightAnswer);
                if (!wordsArr.Contains(word)) wordsArr.Add(word);
            }
            return wordsArr;
        }

        private string getRandomUkrWord(string exceptWord)
        {
            string ukrWord = exceptWord;
            //
            while (ukrWord == exceptWord)
            {
                ukrWord = mainWnd.DicArray[getRandomNumber(mainWnd.DicArray.Count)].ukr;
            }
            return ukrWord;
        }

        private List<string> getWrongAnswersArrUkr(string rightAnswer)
        {
            string word;
            List<string> wordsArr = new List<string>();
            while (wordsArr.Count < 4)
            {
                word = getRandomUkrWord(rightAnswer);
                if (!wordsArr.Contains(word)) wordsArr.Add(word);
            }
            return wordsArr;
        }

        private string getRandomBadMark()
        {
            //
            return mainWnd.LangApp.getBadMark((string)StatusBar.Content);
            //
        }

        private void fillData()
        {

            List<string> WrongAnswersArr;
            string strTrueAnswer;
            // clear all mark
            setButtonStyleDefault(button1);
            setButtonStyleDefault(button2);
            setButtonStyleDefault(button3);
            setButtonStyleDefault(button4);
            setButtonStyleDefault(button5);
            if (StatusBar.Foreground == (Brush)StatusBar.FindResource("StatusBar_Color_Red"))
            {
                showMsgStatusBar(" "); //якщо попередня відповідь була не правильною - зачищаєм.
            }
            if (workDicArray.Count < 1) //тобто пустий
            {
                EndWorkingProc();
            }
            else
            {
                currentQuestion_n = getRandomNumber(workDicArray.Count);
                AskBtn.Content = workDicArray[currentQuestion_n].eng;
                if (mainWnd.appLanguage == "ua")
                {
                    strTrueAnswer = workDicArray[currentQuestion_n].ukr;
                    WrongAnswersArr = getWrongAnswersArrUkr(strTrueAnswer);
                }
                else
                {
                    strTrueAnswer = workDicArray[currentQuestion_n].rus;
                    WrongAnswersArr = getWrongAnswersArrRus(strTrueAnswer);
                }

                switch (getRandomNumber(5))
                {
                    case 0:
                        button1.Content = strTrueAnswer;
                        button2.Content = WrongAnswersArr[0];
                        button3.Content = WrongAnswersArr[1];
                        button4.Content = WrongAnswersArr[2];
                        button5.Content = WrongAnswersArr[3];
                        break;
                    case 1:
                        button1.Content = WrongAnswersArr[0];
                        button2.Content = strTrueAnswer;
                        button3.Content = WrongAnswersArr[1];
                        button4.Content = WrongAnswersArr[2];
                        button5.Content = WrongAnswersArr[3];
                        break;
                    case 2:
                        button1.Content = WrongAnswersArr[0];
                        button2.Content = WrongAnswersArr[1];
                        button3.Content = strTrueAnswer;
                        button4.Content = WrongAnswersArr[2];
                        button5.Content = WrongAnswersArr[3];
                        break;
                    case 3:
                        button1.Content = WrongAnswersArr[0];
                        button2.Content = WrongAnswersArr[1];
                        button3.Content = WrongAnswersArr[2];
                        button4.Content = strTrueAnswer;
                        button5.Content = WrongAnswersArr[3];
                        break;
                    default:
                        button1.Content = WrongAnswersArr[0];
                        button2.Content = WrongAnswersArr[1];
                        button3.Content = WrongAnswersArr[2];
                        button4.Content = WrongAnswersArr[3];
                        button5.Content = strTrueAnswer;
                        break;
                }
            }
        }

        private void EndWorkingProc()
        {
            TopTitle.Content = mainWnd.LangApp.str_Rest_and_try_late;
            AskBtn.Content = mainWnd.LangApp.str_Fine;
            button1.Content = mainWnd.LangApp.str_Mistakes + wrongAnsers;
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            StatusBar.Content = mainWnd.LangApp.str_All_tsks_done;


            // block events
            _ClassProgramCompled = true;
            // задаємо ширину:
            mainWnd.SetProgressBar(1.0, 0.0, 0.0);
            // виводим написи:
            mainWnd.TextProgressBar("", "", "");
        }
        
        private void showMsgStatusBar(string msg)
        {
            StatusBar.Content = msg;
            int rightAnswer = mainWnd.DicArray.Count - workDicArray.Count;// правильних відповідей
            int allAnswers = rightAnswer + wrongAnsers; // всього було поставлено питань

            if (allAnswers > 0)
            {
                double ProgressBar_width = ((double)workDicArray.Count) / mainWnd.DicArray.Count;
                ProgressBar_width = Math.Round(ProgressBar_width, 2);// всього залишилось

                double multiplierForMasteryBar = 1.0 - ProgressBar_width; //пройдено

                double persents = ((double) wrongAnsers) / allAnswers; // частина помилок
                double MasteryBarDanger_width = Math.Round(persents * multiplierForMasteryBar, 2);

                double MasteryBarSuccess_width = 1.0 - ProgressBar_width;//весь мастері-бар
                MasteryBarSuccess_width = MasteryBarSuccess_width - MasteryBarDanger_width;// з них успішно
                // задаємо ширину:
                mainWnd.SetProgressBar(MasteryBarSuccess_width, MasteryBarDanger_width, ProgressBar_width);
                // виводим написи:
                mainWnd.TextProgressBar(
                    rightAnswer + mainWnd.LangApp.str_true, 
                    wrongAnsers + mainWnd.LangApp.str_not_true, 
                    workDicArray.Count + mainWnd.LangApp.str_lost);
            }
            else
            {
                // задаємо ширину:
                mainWnd.SetProgressBar(0.0, 0.0, 1.0);
                // виводим написи:
                mainWnd.TextProgressBar("", "", mainWnd.LangApp.str_WordsAmount + workDicArray.Count);
            }
        }
    }//class myDictionery
}
