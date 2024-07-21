﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ZongziTEK_Blackboard_Sticker.Pages.SettingsPages
{
    /// <summary>
    /// AutomationSettingsPage.xaml 的交互逻辑
    /// </summary>
    public partial class AutomationSettingsPage : Page
    {
        public AutomationSettingsPage()
        {
            InitializeComponent();

            DataContext = MainWindow.Settings.Automation;
        }

        private void HyperlinkButton_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://alist.xrgzs.top/d/pxy/eduimg/seewo/!Files/%E5%B8%8C%E6%B2%83%E6%9C%8D%E5%8A%A1%E5%8F%8A%E5%B8%8C%E6%B2%83%E7%AE%A1%E5%AE%B6/%E5%B8%8C%E6%B2%83%E7%AE%A1%E5%AE%B6%E7%BA%AF%E5%87%80%E6%A8%A1%E5%BC%8F.reg");
        }

        private void ToggleSwitchIsAutoHideHugoAssistantEnabled_Toggled(object sender, RoutedEventArgs e)
        {
            MainWindow.SaveSettings();

            if (MainWindow.Settings.Automation.IsAutoHideHugoAssistantEnabled && MainWindow.isSeewoServiceAssistantHided == false)
                (Application.Current.MainWindow as MainWindow).timerHideSeewoServiceAssistant.Start();
            else
                (Application.Current.MainWindow as MainWindow).timerHideSeewoServiceAssistant.Stop();
        }
    }
}
