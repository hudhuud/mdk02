using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form1 : Form
    {
        //создаем обьект, который генерирует рандомные числа
        Random randomizer = new Random();

        //целочисленные переменные для чисел. сложение
        int addend1;
        int addend2;

        //вычитание
        int minuend;
        int subtrahend;

        //умножение
        int multiplicand;
        int multiplier;

        //деления
        int dividend;
        int divisor;

        //оставшееся время
        int timeLeft;

        public void StartTheQuiz()
        {
            //задача сложения
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //преобразование значений в строку
            plusleftlabel.Text = addend1.ToString();
            plusrightlabel.Text = addend2.ToString();

            //изначально должно равняться 0
            sum.Value = 0;

            //вычитание
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusleftlabel.Text = minuend.ToString();
            minusrightlabel.Text = subtrahend.ToString();
            difference.Value = 0;

            //умножение
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesleftlabel15.Text = multiplicand.ToString();
            timesrightlabel.Text = multiplier.ToString();
            product.Value = 0;

            //деление
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedleftlabel.Text = dividend.ToString();
            dividedrightlabel.Text = divisor.ToString();
            quotient.Value = 0;

            //таймер
            timeLeft = 30;
            timelabel.Text = "30 секунд";
            timer1.Start();
        }

        private bool checktheanswer()
        //метод для проверки ответов
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startbutton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checktheanswer())
            {
                //если метод для проверки выводит все правильно
                //остановить таймер и вывести messagebox
                timer1.Stop();
                MessageBox.Show("Вы на все вопросы ответили правильно!",
                                "Поздравляю!");
                startbutton.Enabled = true;
            }
            else if (timeLeft > 0)
            //если метод проверки выводит неверно и время еще есть
            // продолжать счет
            {
                timeLeft = timeLeft - 1;
                timelabel.Text = timeLeft + "секунды";

                //если осталось пять и меньше секунд, окно красное
                if (timeLeft <= 5 && timeLeft >= 0)
                {
                    timelabel.BackColor = Color.Red;
                }
            }
            else
            {
                //если время закончилось то выводится messagebox
                //и выводятся все верные ответы
                timer1.Stop();
                timelabel.Text = "Время вышло!";
                MessageBox.Show("Вы не смогли закончить вовремя.", "Извините!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startbutton.Enabled = true;
            }
            }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void начатьНовуюИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startbutton.Enabled = false;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        
}
