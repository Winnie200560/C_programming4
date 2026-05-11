using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Distance_Click(object sender, RoutedEventArgs e)
        {
            // Проверка ввода
            bool ok1 = double.TryParse(X1.Text, out double x1);
            bool ok2 = double.TryParse(Y1.Text, out double y1);
            bool ok3 = double.TryParse(X2.Text, out double x2);
            bool ok4 = double.TryParse(Y2.Text, out double y2);

            if (!ok1 || !ok2 || !ok3 || !ok4)
            {
                MessageBox.Show("Ошибка ввода координат!");
                return;
            }

            MyPoint p1 = new MyPoint(x1, y1);
            MyPoint p2 = new MyPoint(x2, y2);

            double distance = p1.DistanceTo(p2);

            Output.Text = "Расстояние: " + distance;
        }

        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            // Проверка ввода
            bool ok1 = double.TryParse(X1.Text, out double x1);
            bool ok2 = double.TryParse(Y1.Text, out double y1);
            bool ok3 = double.TryParse(X2.Text, out double x2);
            bool ok4 = double.TryParse(Y2.Text, out double y2);

            if (!ok1 || !ok2 || !ok3 || !ok4)
            {
                MessageBox.Show("Ошибка ввода координат!");
                return;
            }

            MyPoint p1 = new MyPoint(x1, y1);
            MyPoint p2 = new MyPoint(x2, y2);

            ComboBoxItem item = (ComboBoxItem)OperationBox.SelectedItem;
            string op = item.Content.ToString();
            string result = "";

            if (op == "X ++")
            {
                p1++;
                result = p1.ToString();
            }

            else if (op == "X --")
            {
                p2--;
                result = p2.ToString();
            }

            else if (op == "Расстояние")
            {
                double d = p1 + p2;
                result = "Расстояние: " + d;
            }

            else if (op == "X + число")
            {
                bool ok = int.TryParse(NumberBox.Text, out int num);

                if (!ok)
                {
                    MessageBox.Show("Введите число");
                    return;
                }

                MyPoint res = p1 + num;

                result = res.ToString();
            }

            else if (op == "Число + X")
            {
                bool ok = int.TryParse(NumberBox.Text, out int num);

                if (!ok)
                {
                    MessageBox.Show("Введите число");
                    return;
                }

                MyPoint res = num + p1;

                result = res.ToString();
            }

            else if (op == "Целая часть от X int(x)")
            {
                int val = (int)p1;

                result = val.ToString();
            }

            else if (op == "Координата Y double(x)")
            {
                double val = p1;

                result = val.ToString();
            }
            Output.Text = result;
        }
    }
}