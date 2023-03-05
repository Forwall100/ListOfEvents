using System;
using Avalonia.Controls;
using ListOfEvents.Models;
using ListOfEvents.ViewModels;

namespace ListOfEvents.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        var viewModel = new MainWindowViewModel();
        viewModel.Events = EventParser.ParseEvents("Events.xml");
        Console.WriteLine(viewModel.Events.Count);
        DataContext = viewModel;
    }
}