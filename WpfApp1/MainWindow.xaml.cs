using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {

        Image eye1Image;
        Image eye2Image;
        private DispatcherTimer timer;
        private int _rotationAngle;


        public MainWindow()
        {
            InitializeComponent();

             eye1Image = FindName("Eye_1") as Image;
             eye2Image = FindName("Eye_2") as Image;
            InitializeTimer();
         }

        public void InitializeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1); // 60 FPS
            timer.Start();
            timer.Tick += RotateImage;

        }

        private void RotateImage(object sender, EventArgs e)
        {

            if (++_rotationAngle > 360)  _rotationAngle =0;

            RotateTransform rotateTransform = new RotateTransform(_rotationAngle);
            eye1Image.RenderTransform = rotateTransform;
            eye2Image.RenderTransform = rotateTransform;

        }
    }


  
}
