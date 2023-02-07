using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
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
using System.Configuration;
namespace ABC_Song_Layout
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        byte[] layout0 = { 0 };
        byte[] layout2 = { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 0x1E, 00, 0x10, 00, 0x30, 00, 0x11, 00, 0x2E, 00, 0x12, 00, 0x20, 00, 0x13, 00, 0x12, 00, 0x16, 00, 0x21, 00, 0X17, 00, 0x22, 00, 0X18, 00, 0x23, 00, 0x1E, 00, 0x17, 00, 0x1F, 00, 0x24, 00, 0x20, 00, 0x25, 00, 0x21, 00, 0x26, 00, 0x24, 00, 0x32, 00, 0x25, 00, 0x31, 00, 0x26, 00, 0x18, 00, 0x2C, 00, 0x19, 00, 0x2D, 00, 0x10, 00, 0x2E, 00, 0x13, 00, 0x2F, 00, 0x1F, 00, 0x32, 00, 0x14, 00, 0x33, 00, 0x16, 00, 0x34, 00, 0x2F, 00, 0x14, 00, 0x11, 00, 0x22, 00, 0x2D, 00, 0x30, 00, 0x15, 00, 0x15, 00, 0x33, 00, 0x23, 00, 0x2C, 00, 0x31, 00, 0x34, 00, 0x19, 00 };
        byte[] layout1 = { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 0x1E, 00, 0x10, 00, 0x30, 00, 0x11, 00, 0x2E, 00, 0x12, 00, 0x20, 00, 0x13, 00, 0x12, 00, 0x16, 00, 0x21, 00, 0X17, 00, 0x22, 00, 0X18, 00, 0x23, 00, 0x1E, 00, 0x17, 00, 0x1F, 00, 0x24, 00, 0x20, 00, 0x25, 00, 0x21, 00, 0x26, 00, 0x24, 00, 0x32, 00, 0x25, 00, 0x31, 00, 0x26, 00, 0x18, 00, 0x2C, 00, 0x19, 00, 0x2D, 00, 0x10, 00, 0x2E, 00, 0x33, 00, 0x2F, 00, 0x13, 00, 0x32, 00, 0x1F, 00, 0x33, 00, 0x14, 00, 0x34, 00, 0x16, 00, 0x14, 00, 0x2F, 00, 0x22, 00, 0x11, 00, 0x30, 00, 0x2D, 00, 0x15, 00, 0x15, 00, 0x23, 00, 0x2C, 00, 0x31, 00, 0x34, 00, 0x19, 00 };
        byte[] layout3 = { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 0x1E, 00, 0x10, 00, 0x30, 00, 0x11, 00, 0x2E, 00, 0x12, 00, 0x20, 00, 0x13, 00, 0x12, 00, 0x16, 00, 0x21, 00, 0X17, 00, 0x22, 00, 0X18, 00, 0x23, 00, 0x1E, 00, 0x17, 00, 0x1F, 00, 0x24, 00, 0x20, 00, 0x25, 00, 0x21, 00, 0x32, 00, 0x24, 00, 0x31, 00, 0x25, 00, 0x18, 00, 0x26, 00, 0x10, 00, 0x2C, 00, 0x13, 00, 0x2D, 00, 0x1F, 00, 0x2E, 00, 0x34, 00, 0x2F, 00, 0x14, 00, 0x32, 00, 0x16, 00, 0x33, 00, 0x2F, 00, 0x34, 00, 0x11, 00, 0x14, 00, 0x33, 00, 0x22, 00, 0x2D, 00, 0x30, 00, 0x15, 00, 0x15, 00, 0x26, 00, 0x23, 00, 0x2C, 00, 0x31, 00, 0x19, 00, 0x27, 00, 0x27, 00, 0x19, 00 };
        List<byte[]> layouts;
        int currLayoutIndex;
        PackIcon icon;
        RegistryKey key;

        public MainWindow()
        {
            InitializeComponent();
            InitLayout();
            key = InitRegistryKey();
            icon = new PackIcon { Kind = PackIconKind.CheckOutline };
            currLayoutIndex = Properties.Settings.Default.currentLayoutIndex;
            UpdateSelect();
        }
        private void UpdateSelect()
        {
            badged1.Badge = null;
            badged2.Badge = null;
            
            if (currLayoutIndex == 1)
            {
                badged1.Badge = icon;
            }else if (currLayoutIndex == 2)
            {
                badged2.Badge = icon;
            }
        }

        private void InitLayout()
        {
            layouts = new List<byte[]>();
            layouts.Add(layout0);
            layouts.Add(layout1);
            layouts.Add(layout2);
            layouts.Add(layout3);
        }
        private RegistryKey InitRegistryKey()
        {
            return Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Keyboard Layout", true);
        }
        private void UpdateCurrentLayoutIndex(int i)
        {
            currLayoutIndex = i;
            Properties.Settings.Default.currentLayoutIndex = currLayoutIndex;
        }

        private void Reset2DefaultLayout(object sender, RoutedEventArgs e)
        {
            try
            {
                key.DeleteValue(@"Scancode Map");
                MessageBox.Show("Restore to Default Layout Success!");
                UpdateCurrentLayoutIndex(0);
                UpdateSelect();
            }
            catch
            {
                MessageBox.Show("Restore to Default Layout Failed!");
            }
            
            
        }

        private void WriteLayout(object sender, RoutedEventArgs e)
        {
            key.SetValue(@"Scancode Map", layouts[currLayoutIndex], RegistryValueKind.Binary);
            MessageBox.Show("Set Layout Success! Logout to take effect ");
        }

        private void SelectClicked(object sender, RoutedEventArgs e)
        {
                        
            String str1= ((Button)sender).Name;
            
            if (str1.Equals("SelectButton1"))
            {
                UpdateCurrentLayoutIndex(1);
            }
            else if(str1.Equals("SelectButton2"))
            {
                UpdateCurrentLayoutIndex(2);
            }
            else if (str1.Equals("SelectButton3"))
            {
                UpdateCurrentLayoutIndex(3);
            }
            UpdateSelect();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
