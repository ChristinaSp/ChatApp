using System.Text;
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

namespace ChatApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var dataContext = new MainWindowViewModel();
            DataContext = dataContext;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        { 
            //var openingAnimation = (Storyboard)FindResource("WindowOpeningAnimation");
            //if (openingAnimation != null) 
            //    openingAnimation.Begin(); 

            var storyboard = new Storyboard();
            var animation = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(0.5))
            };
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            storyboard.Children.Add(animation);
            storyboard.Begin(this);
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
          
            //var closingAnimation = (Storyboard)FindResource("WindowClosingAnimation");
            //if (closingAnimation != null)
            //    closingAnimation.Begin();

            var storyboard = new Storyboard();
            var animation = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(0.5))
            };
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            storyboard.Children.Add(animation);
            storyboard.Begin(this);
        }

      
    }
}