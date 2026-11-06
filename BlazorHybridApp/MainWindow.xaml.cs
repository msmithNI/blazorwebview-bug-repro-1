using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorHybridApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        var services = new ServiceCollection();
        services.AddWpfBlazorWebView();
        Resources.Add("services", services.BuildServiceProvider());

        InitializeComponent();
    }
}