using System;
using System.Windows;

namespace Exercise08
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

        private int MaxFunction(int triangleSideA, int triangleSideB, int triangleSideC)
        {
            return Math.Max(triangleSideA, Math.Max(triangleSideB, triangleSideC));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int triangleSideA = Convert.ToInt32(sideATextBox.Text);
            int triangleSideB = Convert.ToInt32(sideBTextBox.Text);
            int triangleSideC = Convert.ToInt32(sideCTextBox.Text);

            int triangleBiggestSide = MaxFunction(triangleSideA, triangleSideB, triangleSideC);

            if (triangleSideA >= (triangleSideB + triangleSideC))
            {
                errorTextBlock.Text = $"Deze zijden kunnen nooit een driehoek vormen: {triangleSideA} >= {triangleSideB} + {triangleSideC}";
                areaTextBlock.Text = string.Empty;
            }
            else if (triangleSideB >= (triangleSideA + triangleSideC))
            {
                errorTextBlock.Text = $"Deze zijden kunnen nooit een driehoek vormen: {triangleSideB} >= {triangleSideA} + {triangleSideC}";
                areaTextBlock.Text = string.Empty;
            }
            else if (triangleSideC >= (triangleSideA + triangleSideB))
            {
                errorTextBlock.Text = $"Deze zijden kunnen nooit een driehoek vormen: {triangleSideC} >= {triangleSideA} + {triangleSideB}";
                areaTextBlock.Text = string.Empty;
            }
            else
            {
                double semiPerimeterTriangle = (triangleSideA + triangleSideB + triangleSideC) / 2.0;
                double areaTriangle = Math.Sqrt(semiPerimeterTriangle * (semiPerimeterTriangle - triangleSideA) *
                                                                        (semiPerimeterTriangle - triangleSideB) *
                                                                        (semiPerimeterTriangle - triangleSideC));

                errorTextBlock.Text = string.Empty;
                areaTextBlock.Text = $"{areaTriangle:F3}";
            }
        }
    }
}