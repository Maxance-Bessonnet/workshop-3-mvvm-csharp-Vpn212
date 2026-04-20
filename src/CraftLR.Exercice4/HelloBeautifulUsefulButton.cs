using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CraftLR.Exercice4;

public partial class HelloBeautifulUsefulButton : Window
{
    public HelloBeautifulUsefulButton()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object sender, RoutedEventArgs eventData)
    {
        Console.WriteLine("Hello, beautiful and useful button!");
    }
}