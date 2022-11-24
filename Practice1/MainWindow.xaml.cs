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

namespace Practice1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          /* TextBlock myTb = new TextBlock();
            myTb.Text = "Hello Shahzaib Good Morning";
            myTb.Inlines.Add(" This is an Inline Content");
            myTb.Inlines.Add(new Run("This is a NEW run command")
            {
                Foreground = Brushes.Black,
                TextDecorations = TextDecorations.Underline
            });
            myTb.TextWrapping= TextWrapping.WrapWithOverflow;
            myTb.Foreground = Brushes.BlueViolet;
            this.Content = myTb;*/
        }

        private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (myTextBlock != null && mySlider.Value > 0d)
            {
                myTextBlock.Text = "Hello World" + mySlider.Value.ToString();
                myTextBlock.FontSize = mySlider.Value;
            }
        }
                

        //private void myImage_MouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    myImage.Source = new BitmapImage(new Uri(@"\Imaages\Imran_Ahmed_Khan_Niazi_-_UNGA_(48784380531)_(cropped).jpg",UriKind.Relative));
        //}


        //private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        //{
        //    System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    double myFontSize = myLabel.FontSize;
        //    myLabel.FontSize = myFontSize + 1;

        //}

        //private void myButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    double myFontSize = myLabel.FontSize;
        //    myLabel.FontSize = myFontSize - 1;
        //}

        //private void myButton_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    myLabel.Foreground =Brushes.White;
        //}
        //private void myButton_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    myLabel.Foreground =Brushes.BlueViolet;
        //}

    }
}
