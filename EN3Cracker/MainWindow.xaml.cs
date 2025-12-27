using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EN3Cracker
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Introduction.Selection.Load(new FileStream(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "introduction.rtf"),FileMode.Open),DataFormats.Rtf);
        }
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            AgreementWindow agreementWindow = new AgreementWindow();
            agreementWindow.Owner = this;
            if (!agreementWindow.ShowDialog().Value)
            {
                Process.GetCurrentProcess().Kill();
            }
        }
        }


        private void repo_Click(object sender, RoutedEventArgs e)
        {
            Hyperlink link = sender as Hyperlink;
            Process.Start(new ProcessStartInfo(link.NavigateUri.AbsoluteUri));
        }
    }
}
