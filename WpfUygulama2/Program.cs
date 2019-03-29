using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WpfUygulama2
{
    class Program
    {
        [STAThread]
        static void Main() //Programin başlangıç noktası.
        {
            Window window = new Window(); //Bir Window nesnesi yaratılır
            window.Title = "Merhaba WPF"; //windows nesnesinin Başlığı ayarlanır
            window.Content = "Hello";
            window.Foreground = Brushes.DarkGreen; //diğer özellikler

            Application app = new Application();
            app.Run(window);
        }
    }
}
