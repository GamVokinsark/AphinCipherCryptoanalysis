using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aphin
{
    public partial class Form1 : Form
    {
        static string alp; // Алфавит
        private int a;
        private int b;
        private int n;
        private string input = "";
        private string result = "";
        private int maxSize;

        class letter
        {
            public int num; // Порядковый номер символа
            public int count; // Частота символа
            public char lett; // Символ
            public letter(int n, char l) { num = n; lett = l; count = 0; }
        }

        public Form1()
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        static int NOD(int n, int m) // Проверка на взаимопростоту
        {
            return n == m ? n : n > m ? NOD(n - m, m) : NOD(m - n, n);
        }

        static int invert(int a, int n) // Поиск обратного по модулю
        {
            if (NOD(a, n) != 1) // Если можем застрять
            {
                MessageBox.Show("Кажется, мы попали в бессконечный цикл... Спасите! Помогите! Вытащите отсюда! Здесь темно... неуютно... и холодно...", 
                    "Ошибка");
                return 1; // Спасаем (выходим)
            }

            int result = 0;

            for (int i = 0; ; i++)
            {
                result = i * n + 1;
                if ((result % a) == 0) break;
            }
            result = result / a;

            return result;
        }

        private void encrypt(string input) // Шифрование
        {
            string output = "";
            char t; // Для временного хранения символа
            for (int i = 0; i < input.Length; i++)
            {
                // Если символа нету в алфавите, допишем его как есть
                if (!alp.Contains(char.ToLower(input[i]).ToString())) output += input[i];
                else
                {
                    t = alp[(a * alp.IndexOf(char.ToLower(input[i])) + b) % n];
                    t = char.IsLower(input[i]) || char.IsNumber(input[i]) ? t : char.ToUpper(t);
                    output += t;
                }
            }
            result = output;
        }

        private void freqAn(string input, int X1, int X2) // Частотный анализ
        {
            string output = "";
            string freques = ""; // Строка для вывода частот на экран
            letter[] letters = new letter[n]; // Для подсчета частоты

            for (int i = 0; i < n; i++) // Заполнение массива
                letters[i] = new letter(i, alp[i]);

            for (int i = 0; i < input.Length; i++) // Подсчет частот символов
                if (alp.Contains(char.ToLower(input[i]).ToString())) // Усли есть в алфавите
                    letters[alp.IndexOf(char.ToLower(input[i]))].count++;

            letter temp; // Временная переменная для алгоритма сортировки
            for (int j = 0; j < letters.Length; j++) // Обычная сортировка по частоте
            {
                for (int i = 0; i < letters.Length - 1; i++)
                {
                    if (letters[i].count < letters[i + 1].count)
                    {
                        temp = letters[i];
                        letters[i] = letters[i + 1];
                        letters[i + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < letters.Length; i++) // Заполнение строки для вывода частот
                freques += (letters[i].lett + ":  ..................  " + letters[i].count + Environment.NewLine);

            int x1, x2, y1, y2, z, d;
            x1 = X1;
            x2 = X2;
            y1 = letters[0].num; // Нашли два символа
            y2 = letters[1].num; // с наибольшей частотой
            if (y1 > y2)
            {
                z = x1 - x2;
                d = y1 - y2;
            }
            else
            {
                z = x2 - x1;
                d = y2 - y1;
            }

            if (z < 0) z = n + z;
            a = (invert(z, n) * d) % n; // Находим а
            b = (y1 - a * x1) % n; // Находим b
            if (b < 0) b = n + b;

            int invA = invert(a, n); // Поиск обратного по модулю
            int tempIndex; // Временный индекс
            char t; // Временный символ
            for (int i = 0; i < input.Length; i++)
            {
                // Если символа нету в алфавите, допишем его как есть
                if (!alp.Contains(char.ToLower(input[i]).ToString())) output += input[i];
                else
                {
                    tempIndex = (invA * (alp.IndexOf(char.ToLower(input[i])) - b)) % n;
                    if (tempIndex < 0) tempIndex = tempIndex + n;
                    t = alp[tempIndex];
                    t = char.IsLower(input[i]) || char.IsNumber(input[i]) ? t : char.ToUpper(t);
                    output += t;
                }
            }
            result = output;
            inpA.Text = a.ToString();
            inpB.Text = b.ToString();
            textBox3.Text = freques;
        }

        private void brForce(string input) // Полный перебор
        {
            result = "";
            string output = "";
            // Динамическое задание длины отображаемого на экране текста,
            // так как отображается часть текста из-за его количества
            int size = input.Length > maxSize ? maxSize : input.Length;
            for (a = 1; a < n; a++)
            {
                // Если не проходит условие, сразу начать новый шаг цикла
                if (NOD(a, n) != 1) continue;
                for (b = 0; b < n; b++)
                {
                    output = "";
                    int invA = invert(a, n);
                    int temp;
                    char t;

                    for (int i = 0; i < size; i++)
                    {
                        // Если символа нету в алфавите, допишем его как есть
                        if (!alp.Contains(char.ToLower(input[i]).ToString())) output += input[i];
                        else
                        {
                            temp = (invA * (alp.IndexOf(char.ToLower(input[i])) - b)) % n;
                            if (temp < 0) temp = n + temp;
                            t = alp[temp];
                            t = char.IsLower(input[i]) || char.IsNumber(input[i]) ? t : char.ToUpper(t);
                            output += t;
                        }
                    }
                    result += "Для a=" + a + ", b=" + b + " первые " + size + " символов: " + output + Environment.NewLine;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Событие для обработки нажатия кнопки
        {
            alp = inpAlp.Text; // Считать алфавит с поля
            if (alp == "") // Проверка на пустоту алфавита
            {
                // Говорим пользователю всю правду
                MessageBox.Show("Хозяин, конечно, барин, но я с пустым алфавитом работать не собираюсь =)", "Ошибка");
                return;
            }
            n = alp.Length; // Запомнить размер алфавита
            input = this.textBox1.Text;
            if (rB1.Checked) // Если выбран режим Шифрования
            {
                if(!int.TryParse(inpA.Text, out a)) //Проверка a
                {
                    MessageBox.Show("a должно быть числом!", "Ошибка");
                    return;
                }
                else if (a > n)
                {
                    a = a % n;
                    inpA.Text = a.ToString();
                }

                if(!int.TryParse(inpB.Text, out b)) // Проверка b
                {
                    MessageBox.Show("b должно быть числом!", "Ошибка");
                    return;
                }
                else if (b > n)
                {
                    b = b % n;
                    inpB.Text = b.ToString();
                }

                encrypt(input); // Шифрование
            }
            else if (rB2.Checked) // Если выбран режим полного перебора
            {
                inpA.Text = "";
                inpB.Text = "";
                if (!int.TryParse(inpSize.Text, out maxSize)) // Проверка Size
                {
                    MessageBox.Show("Количество должно быть числом!", "Ошибка");
                    return;
                }
                brForce(input); // Полный перебор
            }
            else // Если выбран режим частотного анализа
            {
                // Если пользователь выбрал одинаковые символы
                // для 2 символов таблицы частот
                if (cB1.SelectedIndex == cB2.SelectedIndex)
                    cB2.SelectedIndex = (cB2.SelectedIndex + 1) % n;
                freqAn(input, cB1.SelectedIndex, cB2.SelectedIndex); // Частотный анализ
            }
            
            textBox2.Text = result; // Вывод результата на экран
        }

        private void button2_Click(object sender, EventArgs e) // Обработка события нажатия на "Очистить"
        {
            inpA.Text = "";
            inpB.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e) // Нажатие на "Скопировать"
        {
            if (textBox2.Text != "")
                Clipboard.SetText(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e) // Нажатие на "<->"
        {
            int temp = cB1.SelectedIndex;
            cB1.SelectedIndex = cB2.SelectedIndex;
            cB2.SelectedIndex = temp;
        }

        private void rB1_CheckedChanged(object sender, EventArgs e)
        {
            inpA.Text = "";
            inpB.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            if (rB1.Checked)
            {
                inpA.ReadOnly = false;
                inpB.ReadOnly = false;
            }
            else 
            {
                inpA.ReadOnly = true;
                inpB.ReadOnly = true;
            }
        }

        private void rB2_CheckedChanged(object sender, EventArgs e)
        {
            inpA.Text = "";
            inpB.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            if (rB2.Checked)
            {
                inpSize.Visible = true;
                lbSize.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                inpA.Visible = false;
                inpB.Visible = false;
            }
            else
            {
                inpSize.Visible = false;
                lbSize.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                inpA.Visible = true;
                inpB.Visible = true;
            }
        }

        private void rB3_CheckedChanged(object sender, EventArgs e)
        {
            inpA.Text = "";
            inpB.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            if(rB3.Checked)
            {
                this.Width = 1000;
                cB1.Visible = true;
                cB2.Visible = true;
                lbX1.Visible = true;
                lbX2.Visible = true;
                reverse.Visible = true;
            }
            else
            {
                this.Width = 800;
                cB1.Visible = false;
                cB2.Visible = false;
                lbX1.Visible = false;
                lbX2.Visible = false;
                reverse.Visible = false;
            }
        }

        private void inpAlp_TextChanged(object sender, EventArgs e)
        {
            inpN.Text = inpAlp.Text.Length.ToString();
        }
    }
}
