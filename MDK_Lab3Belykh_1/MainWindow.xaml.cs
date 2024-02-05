using MDK_Lab3Belykh_1.Model;
using System;
using System.Windows;


namespace MDK_Lab3Belykh_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Time? time;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TimeAddOneSec(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = "0:0:0";
                MessageBox.Show("Неверные данные\n" +
                                "Установлено значение по умолчанию");
            }

            time += new Time(0, 0, 1);
            TimeField.Text = time.Print();
        }

        private void HowManySeconds(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                MessageBox.Show($"Всего {time.ToSeconds()} секунд");
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
                MessageBox.Show($"Всего {time.ToSeconds()} секунд");
            }
        }

        private void HowManyMinutes(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                MessageBox.Show($"Всего {time.ToMinutes()} минут");
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
                MessageBox.Show($"Всего {time.ToMinutes()} минут");
            }
        }

        private void AddSeconds(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                time += new Time(0, 0, Convert.ToInt32(AddSecondField.Text));
                TimeField.Text = time.Print();
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
                AddSecondField.Text = "0";
                MessageBox.Show("Неверные данные\n" +
                                "Установлено значение по умолчанию");
            }
        }

        private void SubSeconds(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                time -= new Time(0, 0, Convert.ToInt32(SubSecondField.Text));
                TimeField.Text = time.Print();
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
                SubSecondField.Text = "0";
                MessageBox.Show("Неверные данные\n" +
                                "Установлено значение по умолчанию");
            }
        }

        private void SubTime(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                Time otherTime = new Time(SubTimeField.Text);
                MessageBox.Show($"Разница в {time.TimeSub(otherTime)}");
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
            }
        }

        private void IsMoreTime(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                Time otherTime = new Time(СompareTimeField.Text);
                if (time > otherTime)
                {
                    MessageBox.Show("Да");
                }
                else
                {
                    MessageBox.Show("Нет");
                }
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
            }
        }

        private void IsLessTime(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                Time otherTime = new Time(СompareTimeField.Text);
                if (time < otherTime)
                {
                    MessageBox.Show("Да");
                }
                else
                {
                    MessageBox.Show("Нет");
                }
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
            }
        }

        private void IsEqualTime(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                Time otherTime = new Time(СompareTimeField.Text);
                if (time == otherTime)
                {
                    MessageBox.Show("Да");
                }
                else
                {
                    MessageBox.Show("Нет");
                }
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
            }
        }
    }
}