using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPListViewOverflowBug
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public ObservableCollection<int> Items10000 { get; } = new ObservableCollection<int>(Enumerable.Range(1, 10000));

        public ObservableCollection<int> Items25000 { get; } = new ObservableCollection<int>(Enumerable.Range(1, 25000));

        public ObservableCollection<int> Items50000 { get; } = new ObservableCollection<int>(Enumerable.Range(1, 50000));

        public ObservableCollection<int> Items75000 { get; } = new ObservableCollection<int>(Enumerable.Range(1, 75000));
    }
}
