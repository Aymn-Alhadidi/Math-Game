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
    public partial class StorageData : Form
    {
        public StorageData()
        {
            InitializeComponent();
        }


        struct stDataStorg
        {
            public string Level, Operation, AnswerStyle, NumberOfQuestions;
            public string NumOfRightAnswer, NumOfWrongAnswer;
            public string GameTime;
        }
        stDataStorg ConvertLineToStruct(string Line)
        {
            string[] ArrLine = Line.Split('#');
            stDataStorg DataStorge;

            DataStorge.Level = ArrLine[0];
            DataStorge.Operation = ArrLine[1];
            DataStorge.AnswerStyle = ArrLine[2];
            DataStorge.NumberOfQuestions = ArrLine[3];
            DataStorge.NumOfRightAnswer = ArrLine[4];
            DataStorge.NumOfWrongAnswer = ArrLine[5];
            DataStorge.GameTime = ArrLine[6];

            return DataStorge;
        }
        void setItem(stDataStorg Data)
        {
            ListViewItem Item = new ListViewItem(Data.Level);
            Item.SubItems.Add(Data.Operation);
            Item.SubItems.Add(Data.AnswerStyle);
            Item.SubItems.Add(Data.NumberOfQuestions);
            Item.SubItems.Add(Data.NumOfRightAnswer);
            Item.SubItems.Add(Data.NumOfWrongAnswer);
            Item.SubItems.Add(Data.GameTime);

            listView1.Items.Add(Item);
        }
        void StorgeDataInFile()
        {
            string FilePath = "D:\\mohammed abohdhd\\Math Game By Using C#\\Data.txt";
            StreamReader sr = new StreamReader(FilePath);

            string Line;
            stDataStorg Data;

            while ((Line = sr.ReadLine()) != null)
            {
                Data = ConvertLineToStruct(Line);
                setItem(Data);
            }
        }
        private void StorageData_Load(object sender, EventArgs e)
        {
            StorgeDataInFile();
        }
    }
}
