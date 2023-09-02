using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game_By_Using_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum enLevel { Hard, Medium, Easy, Custom };
        public enum enOperation { Mixed, Addition, Subtraction, Multiplication, Division };
        public enum enAnswerStyle { Writing, FourOption };

        struct stQuetion
        {
            public int Number1, Number2, Result, QuestionNumber;
            public char Operation;
        }
        public struct stGameInfo
        {
            public enLevel Level;
            public enOperation Operation;
            public enAnswerStyle AnswerStyle;
            public short NumberOfQuestion, NumberOfRightQuestion, NumberOfWrongQuestion;
        }
        public struct stGameTime
        {
            public DateTime GameTime;
            public TimeSpan GameTimeSpan;
        }
        public struct stCustomLevel
        {
            public short From, To;
        }

        //struct 
        stQuetion Question;
        stGameInfo GameInfo;
        public static stGameTime GameTime;
        public static stCustomLevel CustomLevel;

        Random RandomNumber = new Random();

        //Answer Text box and option
        MaskedTextBox AnswerTextBox = new MaskedTextBox();

        Button AnswerOption1 = new Button();
        Button AnswerOption2 = new Button();
        Button AnswerOption3 = new Button();
        Button AnswerOption4 = new Button();

        //Game Validation
        bool LevelValidation()
        {
            if (rbHard.Checked || rbEasy.Checked || rbMeddium.Checked || rbCustom.Checked)
            {
                GameInfoError.Clear();
                return true;
            }

            else
            {
                GameInfoError.SetError(gbLevel, "You Need To Pick The Level");
                return false;
            }
        }
        bool OperationValidation()
        {
            if (rbMixed.Checked || rbMultiplication.Checked || rbSubtraction.Checked
                || rbAddition.Checked || rbDivision.Checked)
            {
                GameInfoError.Clear();
                return true;
            }

            else
            {
                GameInfoError.SetError(gbOperation, "You Need To Pick Operation");
                return false;
            }
        }
        bool AnswerStyleValidation()
        {
            if (rbWriteAnswerStyle.Checked || rbOptionsStyle.Checked)
            {
                GameInfoError.Clear();

                if(rbWriteAnswerStyle.Checked)
                {
                    DrawAnswerTextBox();
                    RemoveAnswerOption();
                }

                else
                {
                    DrawAnswerOption();
                    RemoveAnswerTextBox();
                }

                return true;
            }

            else
            {
                GameInfoError.SetError(gbQuestionStyle, "You Need To Pick Quesiton Style");
                return false;
            }
        }
        bool GameValidation()
        {
            if (LevelValidation() && OperationValidation() && AnswerStyleValidation())
                return true;

            return false;
        }

        //Level Radion Button
        private void rbHard_CheckedChanged(object sender, EventArgs e)
        {
            lbLevel.Text = "Level: Hard";
            GameInfo.Level = enLevel.Hard;
            LevelValidation();


        }
        private void rbMeddium_CheckedChanged(object sender, EventArgs e)
        {
            lbLevel.Text = "Level: Meddium";
            GameInfo.Level = enLevel.Medium;
            LevelValidation();
        }
        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            lbLevel.Text = "Level: Easy";
            GameInfo.Level = enLevel.Easy;
            LevelValidation();
        }
        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            lbLevel.Text = "Level: Custom";
            GameInfo.Level = enLevel.Custom;
            LevelValidation();
        }


        //Prepare Question

        void MakeQuestion()
        {
            PrepareQuestion();

            lblTheMainTextOfGame.Text = Question.Number1.ToString() +
                       GetOperation() + Question.Number2.ToString() + "= ";

            if (rbOptionsStyle.Checked)
                setOptionAnswer();
        }
        void setCorrectOption()
        {
            AnswerOption1.Tag = "No";
            AnswerOption2.Tag = "No";
            AnswerOption3.Tag = "No";
            AnswerOption4.Tag = "No";

            switch (RandomNumber.Next(1, 5))
            {
                case 1:
                    AnswerOption1.Text = Question.Result.ToString();
                    AnswerOption1.Tag = "Yes";
                    break;

                case 2:
                    AnswerOption2.Text = Question.Result.ToString();
                    AnswerOption2.Tag = "Yes";
                    break;

                case 3:
                    AnswerOption3.Text = Question.Result.ToString();
                    AnswerOption3.Tag = "Yes";
                    break;

                default:
                    AnswerOption4.Text = Question.Result.ToString();
                    AnswerOption4.Tag = "Yes";
                    break;
            }
        }
        void setRandomOption()
        {
            if (AnswerOption1.Tag.ToString() == "No")
            {
                AnswerOption1.Text = RandomNumber.Next(Question.Result - 10, Question.Result + 10).ToString();
            }

            if (AnswerOption2.Tag.ToString() == "No")
            {
                do
                {
                    AnswerOption2.Text = RandomNumber.Next(Question.Result - 10, Question.Result + 10).ToString();

                } while (AnswerOption1.Text == AnswerOption2.Text);
            }

            if (AnswerOption3.Tag.ToString() == "No")
            {
                do
                {
                    AnswerOption3.Text = RandomNumber.Next(Question.Result - 10, Question.Result + 10).ToString();

                } while (AnswerOption1.Text == AnswerOption3.Text
                      || AnswerOption2.Text == AnswerOption3.Text);
            }

            if (AnswerOption4.Tag.ToString() == "No")
            {
                do
                {
                    AnswerOption4.Text = RandomNumber.Next(Question.Result - 10, Question.Result + 10).ToString();

                } while (AnswerOption1.Text == AnswerOption4.Text
                      || AnswerOption2.Text == AnswerOption4.Text
                      || AnswerOption3.Text == AnswerOption4.Text);
            }

        }
        void setOptionAnswer()
        {
            setCorrectOption();
            setRandomOption();
        }
        void PrepareQuestion()
        {
            Question.Number1 = GetRandomNumber();
            Question.Number2 = GetRandomNumber();
            Question.Operation = GetOperation();
            Question.Result = GetQuestionResult();
            Question.QuestionNumber++;

            lbQuestionNumber.Text = "Question Number: " + Question.QuestionNumber;

        }
        void PlayGame()
        {
            if(GameInfo.NumberOfQuestion <= Question.QuestionNumber)
            {
                ShowEndGameScreen();
                return;
            }
            MakeQuestion();
        }

        //End The Game

        void EndGame()
        {
            //Enable Groups
            gbLevel.Enabled = true;
            gbOperation.Enabled = true;
            gbQuestionNumber.Enabled = true;
            gbQuestionStyle.Enabled = true;
            gbTime.Enabled = true;

            //Lables
            lbLevel.Text = "Level: ";
            lbOperation.Text = "Operation: ";
            lbQuestionStyle.Text = "Question Style: ";
            lbQuestionNumber.Text = "Question Number: ";
            lbGameTime.Text = "Game Time: ";
            lbQuestionNumber.Text = "Question Number: ";
            lbRightQuestion.Text = "Right Question: ";
            lbWrongQuestion.Text = "Wrong Question: ";
            lbGameStatus.Text = "Game Status";
            lblTheMainTextOfGame.Text = "The Game Did Not Start";
            lbTimeLeft.Text = "Time Left: ";

            //Game Struct
            GameInfo.NumberOfRightQuestion = 0;
            GameInfo.NumberOfWrongQuestion = 0;
            Question.QuestionNumber = 0;

            //buttons and text box
            btnEndGame.Enabled = false;
            btnPauseGame.Enabled = false;
            btnStartGame.Enabled = true;
            btnData.Enabled = true;
            GameTimer.Enabled = false;
            AnswerTextBox.Enabled = false;


            //Empty Answer Text box and buttons option
            AnswerTextBox.Text = string.Empty;
            AnswerOption1.Text = string.Empty;
            AnswerOption2.Text = string.Empty;
            AnswerOption3.Text = string.Empty;
            AnswerOption4.Text = string.Empty;
        }
        void ShowEndGameScreen()
        {
            string Message = "\nLevel: " + GameInfo.Level +
                             "\nOperation: " + GameInfo.Operation +
                             "\nQuestion Style: " + GameInfo.AnswerStyle +
                             "\nQuestions Number" + GameInfo.NumberOfQuestion +
                             "\nRight Questions: " + GameInfo.NumberOfRightQuestion +
                             "\nWrong Questions: " + GameInfo.NumberOfWrongQuestion +
                             "\n" + lbGameTime.Text;

            if (GameValidation())
                StorageDataInFile();

            EndGame();

            MessageBox.Show(Message, "Round Result", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        //Operatin Radion Button
        private void rbMixed_CheckedChanged(object sender, EventArgs e)
        {
            lbOperation.Text = "Operation: Mixed";
            GameInfo.Operation = enOperation.Mixed;
            OperationValidation();
        }
        private void rbAddition_CheckedChanged(object sender, EventArgs e)
        {
            lbOperation.Text = "Operation: Addition";
            GameInfo.Operation = enOperation.Addition;
            OperationValidation();
        }
        private void rbSubtraction_CheckedChanged(object sender, EventArgs e)
        {
            lbOperation.Text = "Operation: Subtraction";
            GameInfo.Operation = enOperation.Subtraction;
            OperationValidation();
        }
        private void rbMultiplication_CheckedChanged(object sender, EventArgs e)
        {
            lbOperation.Text = "Operation: Multiplication";
            GameInfo.Operation = enOperation.Multiplication;
            OperationValidation();
        }
        private void rbDivision_CheckedChanged(object sender, EventArgs e)
        {
            lbOperation.Text = "Operation: Division";
            GameInfo.Operation = enOperation.Division;
            OperationValidation();
        }


        //Answer Style Radio Button
        private void rbWriteAnswerStyle_CheckedChanged(object sender, EventArgs e)
        {
            lbQuestionStyle.Text = "Question Style: Writing";
            GameInfo.AnswerStyle = enAnswerStyle.Writing;
            AnswerStyleValidation();
        }
        private void rbOptionsStyle_CheckedChanged(object sender, EventArgs e)
        {
            lbQuestionStyle.Text = "Question Style: Option";
            GameInfo.AnswerStyle = enAnswerStyle.FourOption;
            AnswerStyleValidation();
        }
        private void Numberical_QuestionNumber_ValueChanged(object sender, EventArgs e)
        {
            lbGameQuestionNumber.Text = "Question Number: " + Numberical_QuestionNumber.Value.ToString();
            GameInfo.NumberOfQuestion = Convert.ToInt16(Numberical_QuestionNumber.Value);
        }


        //Time
        string GetMinutes()
        {
            if (Convert.ToInt16(txtMinutes.Text) < 10 && txtMinutes.Text.Length < 2)
                return "0" + txtMinutes;

            return txtMinutes.Text;
        }
        string GetSeconds()
        {
            if (Convert.ToInt16(txtSeconds.Text) < 10 && txtSeconds.Text.Length < 2)
                return "0" + txtSeconds;

            return txtSeconds.Text;
        }
        private void chkIsWithTime_CheckedChanged(object sender, EventArgs e)
        {
            if(chkIsWithTime.Checked)
            {
                txtMinutes.Enabled = true;
                txtSeconds.Enabled = true;

                lbGameTime.Text = "Game Time: 00:00";
                lbTimeLeft.Text = "Time Left: " + GameTime.GameTime.ToString("mm:ss");
            }

            else
            {
                txtMinutes.Enabled = false;
                txtSeconds.Enabled = false;

                lbGameTime.Text = "Game Time: No Time";
                lbTimeLeft.Text = "Time Left: ";
            }
        }
        void UpdateTimeInGameInfo()
        {
            lbGameTime.Text = "Game Time: " + GetMinutes() + ":" + GetSeconds();

            GameTime.GameTime = DateTime.Today
                .AddMinutes(Convert.ToInt16(txtMinutes.Text))
                .AddSeconds(Convert.ToInt16(txtSeconds.Text));

            lbTimeLeft.Text = "Time Left: " + GameTime.GameTime.ToString("mm:ss");
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if(GameTime.GameTimeSpan.ToString("mm\\:ss") == "00:00")
            {
                ShowEndGameScreen();
            }

            else
            {
                GameTime.GameTimeSpan = GameTime.GameTimeSpan.Subtract(TimeSpan.FromSeconds(1));
                lbTimeLeft.Text = "Time Left: " + GameTime.GameTimeSpan.ToString("mm\\:ss");
            }
        }


        //mtxtTime
        private void txtMinutes_Validating(object sender, CancelEventArgs e)
        {
            UpdateTimeInGameInfo();
        }
        private void txtSeconds_Validating(object sender, CancelEventArgs e)
        {
            UpdateTimeInGameInfo();
        }


        //Answer

        void CheckAnswer(int Result)
        {
            if (Question.Result == Result)
                lbRightQuestion.Text = "Right Questioin: " + ++GameInfo.NumberOfRightQuestion;

            else
                lbWrongQuestion.Text = "Wrong Question: " + ++GameInfo.NumberOfWrongQuestion;

            PlayGame();
        }
        void setAnswerTextBox()
        {
            AnswerTextBox.Location = new Point(440, 150);
            AnswerTextBox.Size = new Size(254, 34);

            AnswerTextBox.Font = new Font("Microsoft Sans Serif", 14);
            AnswerTextBox.TextAlign = HorizontalAlignment.Center;

            AnswerTextBox.Enabled = false;
            AnswerTextBox.KeyDown += mtbEnterAnswer;

            
        }
        void DrawAnswerTextBox()
        {
            this.Controls.Add(AnswerTextBox);
        }
        void RemoveAnswerTextBox()
        {
            this.Controls.Remove(AnswerTextBox);
        }
        void setAnswerOption()
        {
            //First Button
            AnswerOption1.Location = new Point(270, 169);
            AnswerOption1.Size = new Size(118, 56);

            AnswerOption1.Font = new Font("Microsoft Sans Serif", 12);
            AnswerOption1.TextAlign = ContentAlignment.MiddleCenter;
            AnswerOption1.BackColor = Color.White;

            AnswerOption1.Click += OptinsClickAnswer;
            AnswerOption1.Enabled = false;

            //Second Button
            AnswerOption2.Location = new Point(427, 169);
            AnswerOption2.Size = new Size(118, 56);

            AnswerOption2.Font = new Font("Microsoft Sans Serif", 12);
            AnswerOption2.TextAlign = ContentAlignment.MiddleCenter;
            AnswerOption2.BackColor = Color.White;

            AnswerOption2.Click += OptinsClickAnswer;
            AnswerOption2.Enabled = false;

            //Third Button
            AnswerOption3.Location = new Point(584, 169);
            AnswerOption3.Size = new Size(118, 56);

            AnswerOption3.Font = new Font("Microsoft Sans Serif", 12);
            AnswerOption3.TextAlign = ContentAlignment.MiddleCenter;
            AnswerOption3.BackColor = Color.White;

            AnswerOption3.Click += OptinsClickAnswer;
            AnswerOption3.Enabled = false;

            //Frouth Button
            AnswerOption4.Location = new Point(741, 169);
            AnswerOption4.Size = new Size(118, 56);

            AnswerOption4.Font = new Font("Microsoft Sans Serif", 12);
            AnswerOption4.TextAlign = ContentAlignment.MiddleCenter;
            AnswerOption4.BackColor = Color.White;

            AnswerOption4.Click += OptinsClickAnswer;
            AnswerOption4.Enabled = false;

        }
        void DrawAnswerOption()
        {
            this.Controls.Add(AnswerOption1);
            this.Controls.Add(AnswerOption2);
            this.Controls.Add(AnswerOption3);
            this.Controls.Add(AnswerOption4);

        }
        void RemoveAnswerOption()
        {
            this.Controls.Remove(AnswerOption1);
            this.Controls.Remove(AnswerOption2);
            this.Controls.Remove(AnswerOption3);
            this.Controls.Remove(AnswerOption4);
        }
        void mtbEnterAnswer(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                MaskedTextBox MaskedTextBox = (MaskedTextBox) sender;

                int.TryParse(MaskedTextBox.Text, out int result);
                CheckAnswer(result);

                AnswerTextBox.Text = string.Empty;

            }
        }
        void OptinsClickAnswer(object sender, EventArgs e)
        {
            CheckAnswer(Convert.ToInt16(((Button)sender).Text));
        }

        //prepare Question

        int GetRandomNumber()
        {
            switch(GameInfo.Level)
            {
                case enLevel.Hard:
                    return RandomNumber.Next(0, 101);
                    break;

                case enLevel.Medium:
                    return RandomNumber.Next(0, 51);
                    break;

                case enLevel.Easy:
                    return RandomNumber.Next(0, 11);
                    break;

                default:
                    return RandomNumber.Next(CustomLevel.From, CustomLevel.To);
            }
        }
        char RandomOperation()
        {
            Random randNumber = new Random();
            
            switch(randNumber.Next(1, 5))
            {
                case 1:
                    return '+';
                    break;

                case 2:
                    return '-';
                    break;

                case 3:
                    return '/';
                    break;

                case 4:
                    return '*';
                    break;

                default:
                    return '+';
            }
        }
        char GetOperation()
        {
            switch(GameInfo.Operation)
            {
                case enOperation.Addition:
                    return '+';
                    break;

                case enOperation.Division:
                    return '/';
                    break;

                case enOperation.Subtraction:
                    return '-';
                    break;

                case enOperation.Multiplication:
                    return '*';
                    break;

                default:
                    return RandomOperation();
            }
        }
        int GetQuestionResult()
        {
            switch(Question.Operation)
            {
                case '+':
                    return Question.Number1 + Question.Number2;
                    break;

                case '-':
                    return Question.Number1 - Question.Number2;
                    break;

                case '/':
                    return Question.Number1 / Question.Number2;
                    break;

                case '*':
                    return Question.Number1 * Question.Number2;
                    break;

                default:
                    return Question.Number1 * Question.Number2;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setAnswerOption();
            setAnswerTextBox();
        }
        void StartGameScreen()
        {
            //Disable Group Boxes
            gbLevel.Enabled = false;
            gbOperation.Enabled = false;
            gbQuestionNumber.Enabled = false;
            gbQuestionStyle.Enabled = false;
            gbTime.Enabled = false;

            //Button
            btnStartGame.Enabled = false;
            btnEndGame.Enabled = true;
            btnData.Enabled = false;

            lbGameStatus.Text = "Game Status: In Progress";
            GameInfo.NumberOfQuestion = Convert.ToInt16(Numberical_QuestionNumber.Text);

            if(rbWriteAnswerStyle.Checked)
            {
                AnswerTextBox.Enabled = true;
                this.ActiveControl = AnswerTextBox;
                AnswerTextBox.Focus();
            }

            else
            {
                AnswerOption1.Enabled = true;
                AnswerOption2.Enabled = true;
                AnswerOption3.Enabled = true;
                AnswerOption4.Enabled = true;
            }
            
            if(chkIsWithTime.Checked)
            {
                btnPauseGame.Enabled = true;
                GameTimer.Enabled = true;

                GameTime.GameTimeSpan = TimeSpan.FromSeconds(GameTime.GameTime.Second)
                                   .Add(TimeSpan.FromMinutes(GameTime.GameTime.Minute));
            }
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if(GameValidation())
            {
                StartGameScreen();
                PlayGame();
            }
        }
        private void btnPauseGame_Click(object sender, EventArgs e)
        {
            if(GameTimer.Enabled)
            {
                GameTimer.Enabled = false;
                btnPauseGame.Text = "Contiue Game";
            }

            else
            {
                GameTimer.Enabled = true;
                btnPauseGame.Text = "Pause Game";
            }
        }
        private void btnEndGame_Click(object sender, EventArgs e)
        {
            ShowEndGameScreen();
        }
        private void rbCustom_Click(object sender, EventArgs e)
        {
            CustomForm frmCustomLevel = new CustomForm();

            GameInfo.Level = enLevel.Custom;
            lbLevel.Text = "Custom";

            frmCustomLevel.ShowDialog();
            LevelValidation();
        }

        //Storge Data
        string ConvertDataToLine(char Seperator = '#')
        {

            string DataLine;


            DataLine = GameInfo.Level.ToString() + Seperator + GameInfo.Operation.ToString()
                     + Seperator + GameInfo.AnswerStyle + Seperator + 
                     GameInfo.NumberOfQuestion+ Seperator+ GameInfo.NumberOfRightQuestion 
                     + Seperator + GameInfo.NumberOfWrongQuestion
                     + Seperator + GameTime.GameTime.ToString("mm:ss");

            return DataLine;

        }
        void StorageDataInFile()
        {
            string GameData = ConvertDataToLine();

            string FilePath = "D:\\mohammed abohdhd\\Math Game By Using C#\\Data.txt";

            try
            {
                using (StreamWriter writer = File.AppendText(FilePath))
                {
                    writer.WriteLine(GameData);
                }
            }

            catch(Exception ex)
            {
                
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            StorageData frmDataForm = new StorageData();
            frmDataForm.ShowDialog();
        }
    }
}
