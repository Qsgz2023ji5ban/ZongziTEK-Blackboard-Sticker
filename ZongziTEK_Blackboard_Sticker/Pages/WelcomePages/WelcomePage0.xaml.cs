﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ZongziTEK_Blackboard_Sticker.Pages.WelcomePages
{
    /// <summary>
    /// WelcomePage0.xaml 的交互逻辑
    /// </summary>
    public partial class WelcomePage0 : Page
    {
        public WelcomePage0()
        {
            InitializeComponent();
            EmojiTimer_Tick(null, null);
            emojiTimer.Tick += EmojiTimer_Tick;
            emojiTimer.Start();
        }

        private DispatcherTimer emojiTimer = new()
        {
            Interval = TimeSpan.FromMilliseconds(2000),
        };

        private async void EmojiTimer_Tick(object sender, EventArgs e)
        {
            ThicknessAnimation downAnimation = new()
            {
                From = new Thickness(48, 36, 48, 60),
                To = new Thickness(48, 60, 48, 36),
                Duration = TimeSpan.FromSeconds(1),
                EasingFunction = new SineEase() { EasingMode = EasingMode.EaseInOut }
            };
            ImageEmoji.BeginAnimation(MarginProperty, downAnimation);

            await Task.Delay(1000);

            ThicknessAnimation upAnimation = new()
            {
                From = new Thickness(48, 60, 48, 36),
                To = new Thickness(48, 36, 48, 60),
                Duration = TimeSpan.FromSeconds(1),
                EasingFunction = new SineEase() { EasingMode = EasingMode.EaseInOut }
            };
            ImageEmoji.BeginAnimation(MarginProperty, upAnimation);
        }
    }
}
