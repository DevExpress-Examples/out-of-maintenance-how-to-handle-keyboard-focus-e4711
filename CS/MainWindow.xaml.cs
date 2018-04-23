using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using DevExpress.Xpf.Core.Native;
using System.Windows.Controls;

namespace RichEditTabFocusWpf {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void richEditControl1_PreviewKeyDown(object sender, KeyEventArgs e) {
            if((Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)) && e.Key == Key.Tab) {
                TraversalRequest tRequest = new TraversalRequest(FocusNavigationDirection.Previous);
                UIElement keyboardFocus = Keyboard.FocusedElement as UIElement;
                tRequest.Wrapped = true;
                e.Handled = true;
                ((Control)e.Source).MoveFocus(tRequest);
                return;
            }

            if(e.Key == Key.Tab) {
                TraversalRequest tRequest = new TraversalRequest(FocusNavigationDirection.Next);
                UIElement keyboardFocus = Keyboard.FocusedElement as UIElement;
                tRequest.Wrapped = true;
                e.Handled = true;
                keyboardFocus.MoveFocus(tRequest);
            } 
        }
    }
}