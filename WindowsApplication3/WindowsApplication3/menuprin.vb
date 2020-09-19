Imports System.ComponentModel

Public Class menuprin
    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick
        t_0.Show()
    End Sub

    Private Sub TileItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem3.ItemClick
        t_1.Show()
    End Sub

    Private Sub TileItem5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem5.ItemClick
        t_2.Show()
    End Sub

    Private Sub TileItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem2.ItemClick
        t_3.Show()
    End Sub

    Private Sub TileItem6_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem6.ItemClick
        t_4.Show()
    End Sub

    Private Sub TileItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem4.ItemClick
        t_5.Show()
    End Sub

    Private Sub menuprin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MessageBox.Show("¿Esta seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then

            End
        Else
            e.Cancel = True
        End If
    End Sub

End Class