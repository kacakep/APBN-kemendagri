Imports MySql.Data.MySqlClient

Public Class FormButton_1

    Sub Bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        tampil_data()
    End Sub
    Private Sub FormButton_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Button Simpan
        If Me.TextBox1.Text = "" Or Me.TextBox2.Text = "" Or TextBox3.Text = "" Or Me.TextBox4.Text = "" Then
            MsgBox("isi data dengan lengkap")
        Else
            Dim simpan As String
            MsgBox("data akan disimpan")
            simpan = "INSERT INTO data_daerah (kode,provinsi,kode_site,kabupaten_atau_kota) VALUES('" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "')"
            cmd = New MySqlCommand(simpan, con)
            cmd.ExecuteNonQuery()
            Bersih()
        End If
        Bersih()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Button Edit
        Bersih()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Button Hapus
        Bersih()
    End Sub

    Sub tampil_data()
        koneksi()
        da = New MySqlDataAdapter("SELECT * FROM data_daerah order by kode", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "data_daerah")
        Me.DataGridView1.DataSource = (ds.Tables("data_daerah"))
    End Sub
End Class