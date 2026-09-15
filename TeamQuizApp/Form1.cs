using System;
using System.Windows.Forms;

namespace TeamQuizApp
{
    public partial class Form1 : Form
    {
        private readonly QuestionLoader loader;
        private readonly AnswerChecker checker;
        private readonly ScoreManager score;
        private readonly UiUpdater ui;

        private Question current;


        public Form1()
        {
            InitializeComponent();

            loader = new QuestionLoader();
            checker = new AnswerChecker();
            score = new ScoreManager();
            ui = new UiUpdater();
        }
    }
}