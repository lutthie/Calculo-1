Public Class t_2

    'TEOREMA 0
    Private Sub teo0()
        Dim n As Integer
        n = 0
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox8.Text = n
        End If
    End Sub

    'TEOREMA 1
    Private Sub teo1()
        Dim a As Integer
        Dim b As Double
        Dim res As Double
        Dim por As Double

        a = BunifuMetroTextbox2.Text
        b = BunifuMetroTextbox3.Text

        If BunifuMetroTextbox2.Text = "" And BunifuMetroTextbox3.Text = "" Then
            MsgBox("Ingrese un valor.", vbOKOnly, "Error")
        Else
            por = a * b
            res = b - 1
            BunifuMetroTextbox6.Text = por
            If res = 0 Then
                BunifuCustomLabel12.Hide()
                BunifuMetroTextbox7.Text = ""
            Else
                BunifuCustomLabel7.Show()
                BunifuMetroTextbox7.Text = res
            End If
        End If
    End Sub

    'BOTON CALCULAR
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim s As Integer
        s = BunifuMetroTextbox1.Text
        teo1()
        teo0()
        BunifuMetroTextbox5.Text = s
    End Sub

    'SOLO NUMEROS TEXTBOX1
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
            'ALFABETO
        Else
            e.Handled = True
        End If
    End Sub

    'SOLO NUMEROS TEXTBOX2
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
            'ALFABETO
        Else
            e.Handled = True
        End If
    End Sub

    'SOLO NUMEROS TEXTBOX3
    Private Sub BunifuMetroTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox3.KeyPress
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
            'ALFABETO
        Else
            e.Handled = True
        End If
    End Sub

    'SOLO NUMEROS TEXTBOX4
    Private Sub BunifuMetroTextbox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox4.KeyPress
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
            'ALFABETO
        Else
            e.Handled = True
        End If
    End Sub

    'CAMBIA EL LABEL +/- DEPENDE DE QUE QUIERE EL USUARIO
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                BunifuCustomLabel13.Text = "+"
            Case 1
                BunifuCustomLabel13.Text = "-"
        End Select
    End Sub

    'SALIR
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        BunifuMetroTextbox1.Text = ""
        BunifuMetroTextbox2.Text = ""
        BunifuMetroTextbox3.Text = ""
        BunifuMetroTextbox4.Text = ""
        BunifuMetroTextbox5.Text = ""
        BunifuMetroTextbox6.Text = ""
        BunifuMetroTextbox7.Text = ""
        BunifuMetroTextbox8.Text = ""
        BunifuMetroTextbox1.Focus()
        Me.Hide()
    End Sub

End Class