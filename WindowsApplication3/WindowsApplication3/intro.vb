Public Class intro

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            RectangleShape1.Width += 1
            If (RectangleShape1.Width >= 645) Then
                Timer1.Stop()
                Me.Hide()
                menuprin.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class