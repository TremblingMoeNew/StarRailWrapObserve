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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DodocoTales.SR.Gui.Views.Screens
{
    /// <summary>
    /// DDCVSettingsWindowChangeLogScreen.xaml 的交互逻辑
    /// </summary>
    public partial class DDCVSettingsWindowChangeLogScreen : DDCVSwapableScreen
    {
        public DDCVSettingsWindowChangeLogScreen()
        {
            InitializeComponent();
        }
        public override void Refresh()
        {
            VM.Refresh();
        }
    }
}
