Imports System.Windows
Imports System.Windows.Input
Imports System.Windows.Controls

Namespace RichEditTabFocusWpf

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub richEditControl1_PreviewKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If(Keyboard.IsKeyDown(Key.LeftShift) OrElse Keyboard.IsKeyDown(Key.RightShift)) AndAlso e.Key = Key.Tab Then
                Dim tRequest As TraversalRequest = New TraversalRequest(FocusNavigationDirection.Previous)
                Dim keyboardFocus As UIElement = TryCast(Keyboard.FocusedElement, UIElement)
                tRequest.Wrapped = True
                e.Handled = True
                CType(e.Source, Control).MoveFocus(tRequest)
                Return
            End If

            If e.Key = Key.Tab Then
                Dim tRequest As TraversalRequest = New TraversalRequest(FocusNavigationDirection.Next)
                Dim keyboardFocus As UIElement = TryCast(Keyboard.FocusedElement, UIElement)
                tRequest.Wrapped = True
                e.Handled = True
                keyboardFocus.MoveFocus(tRequest)
            End If
        End Sub
    End Class
End Namespace
