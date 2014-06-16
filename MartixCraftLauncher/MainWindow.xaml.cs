using System;
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
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Windows.Media.Animation;
using System.Reflection;
using System.Diagnostics;
using System.Net;
using System.Data;
using System.Threading;
using System.Net.Sockets;
using System.ComponentModel;
using System.Management;

namespace MartixCraftLauncher
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        static private string cfgfile = "mxcl.xml";
        public Boolean IsLaunchering;
        static int Maxmem;
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获取系统内存大小
        /// </summary>
        /// <returns>内存大小（单位M）</returns>
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (this.IsLaunchering)
                return;
            IsLaunchering = true;
            if (txtName.Text == "")
            {
                MessageBox.Show("请先修改用户名");
                txtName.Focus();
                return;
            }


            if (txtMem.Text == "")
            {
                MessageBox.Show("Set Memory First!");
                txtMem.Focus();
                return;
            }

        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMiniaze_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
