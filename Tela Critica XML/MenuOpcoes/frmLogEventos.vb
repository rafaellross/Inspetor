Imports System.Data.SqlClient
Imports System.IO

Public Class frmLogEventos
    Private Sub frmLogEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sPath As String = ""

        'caminho log
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT CAMINHOLOG FROM INSPETORXMLPARAM"
                dr = cmd.ExecuteReader()
                While (dr.Read())
                    sPath = dr("CAMINHOLOG").ToString()
                End While
            Catch ex As Exception
                MsgBox("Nao")
            End Try
            con.Dispose()
        End Using
        ListBox1.DataSource = File.ReadAllLines(sPath)
    End Sub

    Private Sub btLogEventoFechar_Click(sender As Object, e As EventArgs) Handles btLogEventoFechar.Click
        Me.Close()
    End Sub
End Class