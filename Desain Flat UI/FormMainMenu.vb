Imports MySql.Data.MySqlClient
Public Class FormMainMenu
    Private PindahForm As Form = Nothing
    Public Sub BukaForm(Bukaform As Form)
        If PindahForm IsNot Nothing Then PindahForm.Close()
        PindahForm = Bukaform
        PindahForm.TopLevel = False
        PindahForm.FormBorderStyle = FormBorderStyle.None
        PindahForm.Dock = DockStyle.Fill
        PanelTampil.Controls.Add(Bukaform)
        Bukaform.BringToFront()
        Bukaform.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BukaForm(New FormButton_1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BukaForm(New FormButton_2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BukaForm(New FormButton_3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BukaForm(New FormButton_4)
    End Sub

    Private Sub bntMinimize_Click(sender As Object, e As EventArgs) Handles bntMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FormMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MsgBox("Yakin Akan Logout Dari Program?", vbYesNo) = vbYes Then
            Me.Close()
            Login.Show()
        End If
    End Sub


End Class
