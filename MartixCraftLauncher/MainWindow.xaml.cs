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
        static private string cfg = "mxcl.xml";
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
        #region 开始游戏部分
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "")
            {
                if (txtMem.Text == "")
                {
                    MessageBox.Show("请先修改用户名和内存大小");
                    txtName.Focus();
                    return;
                }
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("请先修改用户名");
                txtMem.Focus();
                return;
            }
            if (txtMem.Text == "")
            {
                MessageBox.Show("请先输入内存大小");
                txtMem.Focus();
                return;
            }
            if (File.Exists(cfgfile))
            {
                cfg = config.Load(cfgfile);
            }
            else
            {
                cfg = new config();
            }
            sliderJavaxmx.Maximum = config.getmem();
            if (cfg.javaw == "autosearch")
                txtJavaPath.Text = config.getjavadir();
            else
                txtJavaPath.Text = cfg.javaw;
            if (cfg.javaxmx == "autosearch")
                txtJavaXmx.Text = (config.getmem() / 4).ToString();
            else
                txtJavaXmx.Text = cfg.javaxmx;
            sliderJavaxmx.Value = int.Parse(txtJavaXmx.Text);
            txtUserName.Text = cfg.username;
        }
        #endregion
        #region 主界面的UI处理 拖动 最大化最小化关闭等
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMiniaze_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void DragMove(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        #endregion
    }
}
