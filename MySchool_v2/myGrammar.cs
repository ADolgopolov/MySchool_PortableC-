using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MySchool_v2
{
    class myGrammar
    {
        private bool _ClassProgramCompled = false;
        public bool ClassProgramCompled => _ClassProgramCompled;
        
        private Label TopTitle;
        private Label QuestionBtn;
        private Label PrinterDiv;
        private Label StatusBar;

        private List<OneWord> workDicArray;

        private int currentQuestion_n;
        private int allAnswers = 0;
        private int wrongAnswers = 0;
        private int rightAnsersSuborder = 0;
        private List<string> wordAnserArr;
        
        // задаємо кількість слів для тестування
        // 0 - означає повністю копіюєм масив.
        private int WORD_AMOUNT = 20;

        private Random Rand = new Random();

        private MainWindow mainWnd;

        public myGrammar(MainWindow mWnd)
        {
            mainWnd = mWnd;
            // Продублювали доступ до елементів вікна
            TopTitle = mWnd.l_titleGramm;
            QuestionBtn = mWnd.btn_ask_gram;
            PrinterDiv = mWnd.l_PrintDiv;
            StatusBar = mWnd.l_Comment_Gramm;

            QuestionBtn.MouseDown += Sound_Click;
        }

        public void MyGrammarDestructor()
        {
            QuestionBtn.MouseDown -= Sound_Click;
        }

        public void OnLoad()
        {
            TopTitle.Content = mainWnd.LangApp.GrammarTopTitle;
            // make a copy of main array.
            workDicArray = new List<OneWord>(mainWnd.DicArray);
            if (WORD_AMOUNT > 0)
            {
                while (workDicArray.Count > WORD_AMOUNT)
                {
                    int n = getRandomNumber(workDicArray.Count);
                    workDicArray.RemoveAt(n);
                }
            }
            // choose new question
            initWriter(-1);
            showMsgStatusBar(mainWnd.LangApp.str_Words_Amount + workDicArray.Count, true);

            mainWnd.L_Needs.Visibility = Visibility.Collapsed;
            mainWnd.L_BtnNeeds.Visibility = Visibility.Collapsed;
        }

        private void initWriter( int oldWordIndex)
        {
            if (oldWordIndex !=-1)
            {
                // delete this word from work array;
                workDicArray.RemoveAt(oldWordIndex);
            }
            showMsgStatusBar(" ", true);
            if (workDicArray.Count == 0)
            {
                TopTitle.Content = mainWnd.LangApp.str_Rest_and_try_late;
                QuestionBtn.Content = mainWnd.LangApp.str_Fine;
                PrinterDiv.Content = mainWnd.LangApp.str_Mistakes + wrongAnswers; ;
                showMsgStatusBar(mainWnd.LangApp.str_All_tsks_done, false);
                _ClassProgramCompled = true;
            }
            else
            {
                currentQuestion_n = getRandomNumber(workDicArray.Count);

                if (mainWnd.appLanguage == "ua") { QuestionBtn.Content = workDicArray[currentQuestion_n].ukr; }
                else { QuestionBtn.Content = workDicArray[currentQuestion_n].rus; }

                string emptyString = "";
                int i = 0;
                if (workDicArray[currentQuestion_n].eng.IndexOf("a ") == 0)
                {
                    emptyString = "a ";
                    i = 2;
                }
                if (workDicArray[currentQuestion_n].eng.IndexOf("an ") == 0)
                {
                    emptyString = "an ";
                    i = 3;
                }
                wordAnserArr = new List<string>();
                while (i < workDicArray[currentQuestion_n].eng.Length)
                {
                    emptyString += "*";
                    wordAnserArr.Add(workDicArray[currentQuestion_n].eng.Substring(i,1));
                    i += 1;
                }
                outPutBtns();
                PrinterDiv.Content = emptyString;
            }
        }

        private void outPutBtns()
        {
            //Зачищаєм:
            mainWnd.btnBlock.Children.Clear();
            //Наповнюємо:
            Label newBtn;
            int curBtn;
            List<Label> charBtnArr = new List<Label>();
            for (int i = 0; i < wordAnserArr.Count; i++)
            {
                newBtn = new Label();
                newBtn.Content = wordAnserArr[i];
                newBtn.Style = (Style)mainWnd.FindResource("ButtonStyle_anseWordDefoult");

                newBtn.FontFamily = new FontFamily("Arial");
                newBtn.FontSize = 56;

                newBtn.Margin = new Thickness(3);
                newBtn.Padding = new Thickness(0);
                newBtn.Height = 75;
                newBtn.Width = 75;
                newBtn.HorizontalContentAlignment = HorizontalAlignment.Center;
                newBtn.VerticalContentAlignment = VerticalAlignment.Center;
                newBtn.MouseDown += Button_Click;
                charBtnArr.Add(newBtn);
            }
            while (charBtnArr.Count > 0)
            {
                curBtn = getRandomNumber(charBtnArr.Count);
                // у випадковому порядку заносимо кнопки у WrapPanel
                mainWnd.btnBlock.Children.Add(charBtnArr[curBtn]);
                charBtnArr.RemoveAt(curBtn);
            }
            mainWnd.btnBlock.Refresh();
        }

        private void Sound_Click(object sender, RoutedEventArgs e)
        {
            if (!ClassProgramCompled)
            {
                mainWnd.L_Needs.Visibility = Visibility.Collapsed;
                mainWnd.L_BtnNeeds.Visibility = Visibility.Collapsed;
                if (mainWnd.appLanguage == "ua")
                {
                    StatusBar.Content = $"{workDicArray[currentQuestion_n].trk} - {workDicArray[currentQuestion_n].ukr}";
                }
                else
                {
                    StatusBar.Content = $"{workDicArray[currentQuestion_n].eng} - {workDicArray[currentQuestion_n].rus}";
                }
                StatusBar.Foreground = (Brush)StatusBar.FindResource("StatusBar_Color_Black");
                ///////////////
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
                    MessageBox.Show("Cann`t find this file with sound.");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //
            allAnswers += 1;
            Label thisBtn = (Label)sender;
            if ((string)thisBtn.Content == wordAnserArr[0])
            {
                rightAnsersSuborder += 1;
                wordAnserArr.RemoveAt(0);
                mainWnd.btnBlock.Children.Remove(thisBtn);
                int knownCharsAmount = workDicArray[currentQuestion_n].eng.Length - wordAnserArr.Count;
                string prnString = workDicArray[currentQuestion_n].eng.Substring(0, knownCharsAmount);
                while (workDicArray[currentQuestion_n].eng.Length - knownCharsAmount > 0)
                {
                    prnString += "*";
                    knownCharsAmount += 1;
                }
                PrinterDiv.Content = prnString;

                mainWnd.L_Needs.Visibility = Visibility.Collapsed;
                mainWnd.L_BtnNeeds.Visibility = Visibility.Collapsed;
                showMsgStatusBar(getRandomGoodMark(),true);

                StatusBar.Foreground = (Brush)StatusBar.FindResource("StatusBar_Color_Green");

                if (wordAnserArr.Count == 0)// слово закінчилось перезапускаємось
                {
                    //setTimeout(initWriter, 1000, currentQuestion_n);
                    //mainWnd.Refresh();
                    //System.Threading.Thread.Sleep(500);
                    initWriter(currentQuestion_n);
                }
            }
            else
            {
                rightAnsersSuborder = 0;
                wrongAnswers += 1;
                
                mainWnd.L_Needs.Visibility = Visibility.Visible;
                mainWnd.L_Needs.Content = mainWnd.LangApp.str_Need;

                mainWnd.L_BtnNeeds.Visibility = Visibility.Visible;
                mainWnd.L_BtnNeeds.Content = wordAnserArr[0];

                showMsgStatusBar(getRandomBadMark(), true);

                StatusBar.Foreground = (Brush)StatusBar.FindResource("StatusBar_Color_Red");

                mainWnd.btnBlock.Children.Clear();
                mainWnd.Refresh();

                System.Threading.Thread.Sleep(1000);
                outPutBtns();
            }
        }

        private string getRandomBadMark()
        {
            //
            return mainWnd.LangApp.getBadMark((string)StatusBar.Content);
            //
        }

        private string getRandomGoodMark()
        {
            //
            if (allAnswers > 1 && rightAnsersSuborder == 1)
            {
                return mainWnd.LangApp.getMark((string)StatusBar.Content);
            }
            else
            {
                return mainWnd.LangApp.getGoodMark((string)StatusBar.Content);
            }
        }

        private int getRandomNumber(int amount)
        {
            return Rand.Next(amount);
        }

        private void showMsgStatusBar(string msg, bool showComment)
        {
            StatusBar.Content = msg;

            if (allAnswers > 0)
            {
                int rightAnswer = allAnswers - wrongAnswers; // правильних відповідей

                double ProgressBar_width = ((double)workDicArray.Count) / WORD_AMOUNT;
                ProgressBar_width = Math.Round(ProgressBar_width, 2);// всього залишилось

                double multiplierForMasteryBar = 1.0 - ProgressBar_width; //пройдено

                if (multiplierForMasteryBar == 0)
                { // додаткова умова для відображення результатів на першому слові
                    ProgressBar_width = ((double)WORD_AMOUNT - 1.0) / WORD_AMOUNT;
                    ProgressBar_width = Math.Round(ProgressBar_width, 2);
                    multiplierForMasteryBar = 1.0 - ProgressBar_width;
                }

                double persents = ((double)wrongAnswers) / allAnswers; // частина помилок
                double MasteryBarDanger_width = Math.Round(persents * multiplierForMasteryBar, 2);

                double MasteryBarSuccess_width = 1.0 - ProgressBar_width;//весь мастері-бар
                MasteryBarSuccess_width = MasteryBarSuccess_width - MasteryBarDanger_width;// з них успішно
                // задаємо ширину:
                mainWnd.SetProgressBar_ForGram(MasteryBarSuccess_width, MasteryBarDanger_width, ProgressBar_width);
                // виводим написи:
                if (showComment)
                {
                    mainWnd.TextProgressBar_ForGram(
                        rightAnswer + mainWnd.LangApp.str_true, 
                        wrongAnswers + mainWnd.LangApp.str_not_true, 
                        workDicArray.Count + mainWnd.LangApp.str_lost);
                }
                else
                {
                    mainWnd.TextProgressBar_ForGram(" ", " ", " ");
                }
            }
            else
            {
                // задаємо ширину:
                mainWnd.SetProgressBar_ForGram(0.0, 0.0, 1.0);
                // виводим написи:
                mainWnd.TextProgressBar_ForGram("", "", mainWnd.LangApp.str_WordsAmount + workDicArray.Count);
            }
        }
    }//class myGrammar
}
