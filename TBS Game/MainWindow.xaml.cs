using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using TBS_Game.Moduls.GameMode;

namespace TBS_Game
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // глобальные перменые

        string leftop = ""; // Левый операнд
        string operation = ""; // Знак операции
        string rightop = ""; // Правый операнд

        public MainWindow()
        {
            InitializeComponent();

            // начало игрового кода 


            // Добавляем обработчик для всех кнопок на гриде
            foreach (UIElement c in LayoutRoot.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch ((string)((Button)e.OriginalSource).Content)
            {
                case "New Game":
                    {
                        NewGame x = new NewGame();
                    }
                    break;
                case "Load Game":
                    {
                        ContinueGame x = new ContinueGame();
                    }
                    break;
                case "Exit":
                    {
                        // закрыть окно приложения
                    }
                    break;
            }
        }
    }
}
