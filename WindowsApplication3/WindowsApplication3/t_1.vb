Public Class t_1

    'TEXTBOX1 NUMERICO
    Private Sub BunifuMetroTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox1.KeyPress
        'NUMEROS
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            'TECLA DE CONTROL
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'SEPARADOR
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            'NEGATIVOS
        ElseIf Asc(e.KeyChar) = 45 Then 'alt+45 = -
            e.Handled = False
            'DIVISION
        ElseIf Asc(e.keychar) = 47 Then 'alt+47 = /
            e.Handled = False
            'ALFABETO
        Else
            e.Handled = True
        End If
    End Sub

    'TEXTBOX2 NUMERICO
    Private Sub BunifuMetroTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox2.KeyPress
        'NUMEROS
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            'TECLA DE CONTROL
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'SEPARADOR
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            'NEGATIVOS
        ElseIf Asc(e.KeyChar) = 45 Then 'alt+45 = -
            e.Handled = False
            'DIVISION
        ElseIf Asc(e.KeyChar) = 47 Then 'alt+47 = /
            e.Handled = False
            'ALFABETO
        Else
            e.Handled = True
        End If
    End Sub

    'CALCULAR
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        Dim a As Integer
        Dim n As Double
        Dim res As Double
        Dim c As Double

        a = BunifuMetroTextbox1.Text
        n = BunifuMetroTextbox2.Text

        If BunifuMetroTextbox1.Text = "" And BunifuMetroTextbox2.Text = "" Then
            MsgBox("Ingrese un valor.", vbOKOnly, "Error")
        Else
            res = a * n
            c = n - 1
            BunifuMetroTextbox3.Text = res
            BunifuMetroTextbox4.Text = c
            If c = 0 Then
                BunifuCustomLabel10.Hide()
                BunifuMetroTextbox4.Text = ""
            Else
                BunifuCustomLabel10.Show()
            End If
        End If

    End Sub

    'MUESTRA OTRA VEZ EL LABEL
    Private Sub BunifuMetroTextbox1_Click(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.Click
        BunifuCustomLabel10.Show()
    End Sub

    'SALIR
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        BunifuMetroTextbox1.Text = ""
        BunifuMetroTextbox2.Text = ""
        BunifuMetroTextbox3.Text = ""
        BunifuMetroTextbox4.Text = ""
        BunifuMetroTextbox1.Focus()
        Me.Hide()
    End Sub

End Class