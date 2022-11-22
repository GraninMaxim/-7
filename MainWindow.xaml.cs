using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace project7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Triangle triangle;

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            inputValue1.Text = null;
            inputValue2.Text = null;
            inputValue3.Text = null;
            outArea.Text = null;
            outAngleA.Text = null;
            outAngleB.Text = null;
            outAngleC.Text = null;
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Calculate_Click(calculate, null);
            }
        }

        private void About_Program_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Определить производный класс Triangle с полями-сторонами. " +
                "Определить методы вычисления углов и площади треугольника", "О программе",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                uint sideA = uint.Parse(inputValue1.Text);
                uint sideB = uint.Parse(inputValue2.Text);
                uint sideC = uint.Parse(inputValue3.Text);

                triangle = new Triangle(sideA, sideB, sideC);
                double area = triangle.Area();
                triangle.Angles(out double angleA, out double angleB, out double angleC);

                outArea.Text = area.ToString();
                outAngleA.Text = angleA.ToString();
                outAngleB.Text = angleB.ToString();
                outAngleC.Text = angleC.ToString();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Объект не был создан!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Данные должны быть больше 0", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
