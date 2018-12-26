﻿using System;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace RecordMetaViewer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel.MainViewModel();
        }
        public MainWindow(string path)
        {
            InitializeComponent();
            this.DataContext = new ViewModel.MainViewModel(path);
        }

    }

}
