using System.Threading;
using System.Windows;

namespace Players
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static bool XBtnFlag=true;
        public static void ChangeCulture(string culture)
        {
            XBtnFlag = false;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            var tempWindow = new MainWindow();
            var oldWindow = App.Current.MainWindow;
            tempWindow.Show();
            oldWindow.Close();
            var newWindow = new MainWindow();
            newWindow.Show();
            tempWindow.Close();

        }
    }

}
