using System;

using UWP_TextEditor.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWP_TextEditor.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
