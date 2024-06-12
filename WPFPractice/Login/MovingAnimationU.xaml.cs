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

namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MoveingAnimationContainer : UserControl
    {
        public event EventHandler<bool> AnimationFinish;
        private bool animation;
        public bool Animation
        {
            set
            {
                animation = value;
                MoveMethod();
            }
            get
            {
                return animation;
            }
        }
        public MoveingAnimationContainer()
        {
            InitializeComponent();
        }
        private async void MoveMethod()
        {
          await Move();
            AnimationFinish?.Invoke(this, Animation);
        }

        private async Task Move()
        {
            var tcs = new TaskCompletionSource<bool>();

            if (!Animation)
            {
                MovingContainer.Margin = new Thickness(ActualWidth - MovingContainer.ActualWidth, 0, 0, 0);
                ThicknessAnimation animation1 = new ThicknessAnimation()
                {
                    From = MovingContainer.Margin,
                    To = new Thickness(0, 0, 0, 0),
                    Duration = new Duration(TimeSpan.FromMilliseconds(200))
                };
                await AnimateAsync(MovingContainer, animation1, MarginProperty);
            }
            else
            {
                MovingContainer.Margin = new Thickness(0, 0, 0, 0);
                ThicknessAnimation animation1 = new ThicknessAnimation()
                {
                    From = MovingContainer.Margin,
                    To = new Thickness(ActualWidth - MovingContainer.ActualWidth, 0, 0, 0),
                    Duration = new Duration(TimeSpan.FromMilliseconds(200))
                };
                await AnimateAsync(MovingContainer, animation1, MarginProperty);
            }
        }

        private Task AnimateAsync(UIElement element, AnimationTimeline animating, DependencyProperty property)
        {
            var tcs = new TaskCompletionSource<bool>();

            if (animating == null)
                tcs.SetException(new ArgumentNullException(nameof(animating)));

            animating.Completed += (s, e) => tcs.SetResult(true);

            element.BeginAnimation(property, animating);

            return tcs.Task;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Animation = !animation;
        }
    }
}
