Imports System
Imports System.Windows
Imports System.Windows.Input
Imports System.Windows.Threading
Imports DevExpress.Xpf.Core.Native

Namespace RichEditTabFocusWpf
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub MainWindow_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Input.KeyEventArgs)
            If e.Key = Key.Tab Then
                ' Redirect focus to the next/previous control
                If IsFocusedElementInRichEditControl() Then
                    Dim fnd As FocusNavigationDirection = (If(Keyboard.Modifiers = ModifierKeys.Shift, FocusNavigationDirection.Previous, FocusNavigationDirection.Next))
                    richEditControl1.MoveFocus(New TraversalRequest(fnd))
                    e.Handled = True
                    Return
                End If

                ' Redirect focus to the the RichEditControl
                Me.Dispatcher.BeginInvoke(New Action(Sub()
                    If IsFocusedElementInRichEditControl() Then
                        Keyboard.Focus(richEditControl1.KeyCodeConverter)
                    End If
                End Sub), DispatcherPriority.Normal)
            End If
        End Sub

        Private Function IsFocusedElementInRichEditControl() As Boolean
            Dim focusedElement As FrameworkElement = TryCast(Keyboard.FocusedElement, FrameworkElement)

            If focusedElement Is Nothing Then
                Return False
            End If

            Return LayoutHelper.FindElement(richEditControl1, Function(e) e.Equals(focusedElement)) IsNot Nothing
        End Function
    End Class
End Namespace