using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KolmVormid
{
    public partial class Vorm2 : Form
    {
        Random randomizer = new Random();

        int addend1;
        int addend2;

        int minuend;
        int subtrahend;

        int multiplicand;
        int multiplier;

        int dividend;
        int divisor;

        int timeLeft;

        public Vorm2()
        {
            InitializeComponent();
        }

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            sum.Value = 0;

            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timeLabel.BackColor = DefaultBackColor;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 30;
            progressBar1.Value = 0;

            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            return (addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 30 - timeLeft;

            if (timeLeft <= 10)
                timeLabel.BackColor = Color.Red;

            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startButton.Enabled = true;
                HighlightAnswers();
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
                HighlightAnswers();
            }
        }

        private void HighlightAnswers()
        {
            sum.BackColor = sum.Value == addend1 + addend2 ? Color.LightGreen : Color.Red;
            difference.BackColor = difference.Value == minuend - subtrahend ? Color.LightGreen : Color.Red;
            product.BackColor = product.Value == multiplicand * multiplier ? Color.LightGreen : Color.Red;
            quotient.BackColor = quotient.Value == dividend / divisor ? Color.LightGreen : Color.Red;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
                answerBox.BackColor = Color.Yellow;
            }
        }

        private void answer_Leave(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
                answerBox.BackColor = DefaultBackColor;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timeLabel.BackColor = DefaultBackColor;

            sum.Value = 0;
            difference.Value = 0;
            product.Value = 0;
            quotient.Value = 0;

            plusLeftLabel.BackColor = DefaultBackColor;
            plusRightLabel.BackColor = DefaultBackColor;
            minusLeftLabel.BackColor = DefaultBackColor;
            minusRightLabel.BackColor = DefaultBackColor;
            timesLeftLabel.BackColor = DefaultBackColor;
            timesRightLabel.BackColor = DefaultBackColor;
            dividedLeftLabel.BackColor = DefaultBackColor;
            dividedRightLabel.BackColor = DefaultBackColor;

            startButton.Enabled = true;
        }

    }
}
