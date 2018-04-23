using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using DevExpress.Xpf.Core.Native;

namespace RichEditTabFocusWpf {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void MainWindow_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e) {
            if (e.Key == Key.Tab) {
                // Redirect focus to the next/previous control
                if (IsFocusedElementInRichEditControl()) {
                    FocusNavigationDirection fnd = (Keyboard.Modifiers == ModifierKeys.Shift ? FocusNavigationDirection.Previous : FocusNavigationDirection.Next);
                    richEditControl1.MoveFocus(new TraversalRequest(fnd));
                    e.Handled = true;
                    return;
                }

                // Redirect focus to the the RichEditControl
                this.Dispatcher.BeginInvoke(new Action(() => {
                    if (IsFocusedElementInRichEditControl())
                        Keyboard.Focus(richEditControl1.KeyCodeConverter);
                }), DispatcherPriority.Normal);
            }
        }
        
        private bool IsFocusedElementInRichEditControl() {
            FrameworkElement focusedElement = Keyboard.FocusedElement as FrameworkElement;

            if (focusedElement == null)
                return false;

            return LayoutHelper.FindElement(richEditControl1, e => e.Equals(focusedElement)) != null;
        }
    }
}