Public Class loading

    Private Sub loading_Load(sender As Object, e As EventArgs)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            RectangleShape3.Width += 1
            If RectangleShape3.Width >= 484 Then
                Timer1.Stop()
                Me.Hide()
                intro.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
