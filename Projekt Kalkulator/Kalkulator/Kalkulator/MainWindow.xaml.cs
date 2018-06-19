using System;
using System.Windows;
using System.Windows.Controls;

namespace MyCalculatorv1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda pobierająca wartość wciśniętego przycisku i dopisaniu go na wyświetlaczu
        ///
        /// </summary>
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;//zczytuje jaki został wcisniety przycisk i przypisuje go do zmiennej b
            tb.Text += b.Content.ToString();//wpisanie do textboxa liczby z nacisnietego przycisku
        }
        /// <summary>
   
        /// Metoda wywołująca <see cref="result"/>. W przypadku błędu wypisuje na wyświetlaczu Error
        /// </summary>
       
        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();//wywołanie metody liczącej
            }
            catch (Exception exc)
            {
                tb.Text = "Error!";//wyswietlenie błędu
            }
        }
        /// <summary>
        /// Metoda która dokonuje obliczeń w zależności od wybranego znaku.
        /// Wyświetla na ekranie przeprowadzone działanie
        /// </summary>
        private void result()
        {
            String op;
            int iOp = 0;
            if (tb.Text.Contains("+"))//sprawdzenie czy zawiera +
            {
                iOp = tb.Text.IndexOf("+");//przypisanie nr indexu w którym stoi "+"
            }
            else if (tb.Text.Contains("-"))
            {
                iOp = tb.Text.IndexOf("-");
            }
            else if (tb.Text.Contains("*"))
            {
                iOp = tb.Text.IndexOf("*");
            }
            else if (tb.Text.Contains("/"))
            {
                iOp = tb.Text.IndexOf("/");
            }
            else
            {
                //error    
            }

            op = tb.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(tb.Text.Substring(0, iOp));//przekonwertowanie do typu double przypisanie do zmiennej op1
            double op2 = Convert.ToDouble(tb.Text.Substring(iOp + 1, tb.Text.Length - iOp - 1));//przekonwertowanie do typu double przypisanie do zmiennej op2 + ucinanie

            if (op == "+")
            {
                tb.Text += "=" + (op1 + op2);//aktualizacja textboxa
            }
            else if (op == "-")
            {
                tb.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                tb.Text += "=" + (op1 * op2);
            }
            else
            {
                tb.Text += "=" + (op1 / op2);
            }
        }
        /// <summary>
        /// Metoda mająca na celu wyłączyć aplikację
        /// </summary>
       
        private void Off_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();//wyłaczenie aplikacji
        }
        /// <summary>
        /// Metoda mająca na celu usunąć wyświetlony tekst
        /// </summary>
        
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "";//czyszczenie textboxa
        }
        /// <summary>
        /// Metoda usuwająca ostatnio wpisany znak
        /// </summary>
        
        private void R_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);//ucinanie jednej wartosci
            }
        }
    }
}