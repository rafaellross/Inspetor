Imports System.Data.SqlClient
Imports InspetorXML_Console.Classes.ERP.Generico



Public Class frmLogin
    Public Property Logado As Boolean
    Public Property selecao As frmSelecaoEmpresa

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                cmd.CommandText = "select usuario, senha, ativo from usuario where usuario = '" + txtUsuario.Text + "';"
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If dr.HasRows Then
                    dr.Read()
                    Dim usuario = dr.Item(0).ToString()
                    Dim senha = dr.Item(1).ToString()
                    Dim ativo = dr.Item(2).ToString()

                    If senha = FuncoesErp.getMD5Hash(txtSenha.Text) And ativo = "True" Then
                        selecao = New frmSelecaoEmpresa()
                        selecao.Show()

                        Me.Hide()

                    ElseIf senha <> FuncoesErp.getMD5Hash(txtSenha.Text) Then
                        MessageBox.Show("Usuário ou senha inválidos", "Erro ao logar!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf ativo = "0" Then
                    End If
                Else
                    MessageBox.Show("Usuário ou senha inválidos", "Erro ao logar!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception

            End Try
        End Using
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Application.Exit()
    End Sub


End Class