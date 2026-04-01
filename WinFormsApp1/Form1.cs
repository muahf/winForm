namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new EventHandler(this.button1_Click);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
            opredelenie();
        }

        public void opredelenie()
        {
            try
            {
                // Получаем значения из текстовых полей
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);

                // Проверка на отрицательные числа
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    label5.Text = "Стороны не могут быть отрицательными или равны нулю!";
                    return;
                }

                // Проверка теоремы треугольника
                if (a + b > c && a + c > b && b + c > a)
                {
                    // Определение типа треугольника
                    if (a == b && b == c)
                    {
                        label5.Text = "Равносторонний";
                    }
                    else if (a == b || a == c || b == c)
                    {
                        label5.Text = "Равнобедренный";
                    }
                    else
                    {
                        label5.Text = "Разносторонний";
                    }
                }
                else
                {
                    label5.Text = "Не соответствует теореме о существовании треугольника";
                }
            }
            catch (FormatException)
            {
                label5.Text = "Ошибка: Введите корректные числа!";
            }
            catch (Exception ex)
            {
                label5.Text = $"Ошибка: {ex.Message}";
            }
        }
    }
    }
