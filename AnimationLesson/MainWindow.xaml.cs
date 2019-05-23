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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimationLesson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DoubleAnimation animation = new DoubleAnimation();
            animation.From = rectangle.Width;
            animation.To = rectangle.Width + 325;
            animation.Duration = new Duration(TimeSpan.FromSeconds(5));
            animation.Completed += StoryboardCompleted;

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTargetName(animation, rectangle.Name);
            Storyboard.SetTargetProperty(animation, new PropertyPath(WidthProperty));
            storyboard.Begin(this);

        }

        private void StoryboardCompleted(object sender, EventArgs e)
        {
            border.Visibility = Visibility.Hidden;
            rectangle.Visibility = Visibility.Hidden;
            label.Content = "Готово!";
        }
    }
}
