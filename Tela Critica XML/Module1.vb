Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Module Module1

    Public sArm_xml As String

    Public sArm_Tipo As String

    Public Function GetConnectionXML() As SqlConnection
        'Recebe as variaveis para conectar no BD
        Dim strUsuarioBanco, strSenhaUsuarioBanco, strBanco, strServidor As String
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        strUsuarioBanco = configurationAppSettings.GetValue("userBD", GetType(System.String))
        strSenhaUsuarioBanco = configurationAppSettings.GetValue("passBD", GetType(System.String))
        strBanco = configurationAppSettings.GetValue("DBXML", GetType(System.String))
        strServidor = configurationAppSettings.GetValue("Server", GetType(System.String))
        'Obtem a string de conexão 
        Dim sConnString As String = "Data Source = " + strServidor + "; Initial Catalog = " + strBanco + "; User Id =" + strUsuarioBanco + "; Password =" + strSenhaUsuarioBanco
        'Retorna uma conexão.
        Return New SqlConnection(sConnString)
    End Function

    Public Function GetConnectionDBF() As OdbcConnection
        'Recebe as variaveis para conectar no BD DBF

        'oConn.ConnectionString = "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" & sSigamatDest & ";Exclusive=No;Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;"

        Dim sSigamatDest As String
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        sSigamatDest = configurationAppSettings.GetValue("DestinoSigaMat", GetType(System.String))
        'Obtem a string de conexão 
        Dim sConnString As String =
            "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" & sSigamatDest & ";Exclusive=No;Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;"
        'Retorna uma conexão.
        Return New OdbcConnection(sConnString)
    End Function

    Public Function GetConnectionERP() As SqlConnection

        Dim strUsuarioBanco, strSenhaUsuarioBanco, strBanco, strServidor As String

        Using con As SqlConnection = GetConnectionXML()
            Try
                con.Open()
                Dim cmd As New SqlCommand
                cmd.Connection = con
                Dim dr As SqlDataReader
                cmd.CommandText = "SELECT BDUSER, BDPWD, BDALIAS, BDSERVER FROM INSPETORXMLPARAM"
                dr = cmd.ExecuteReader()
                con.Dispose()
                While (dr.Read())
                    strUsuarioBanco = dr("BDUSER").ToString()
                    strSenhaUsuarioBanco = dr("BDPWD").ToString()
                    strBanco = dr("BDALIAS").ToString()
                    strServidor = dr("BDSERVER").ToString()
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

        'Obtem a string de conexão 
        Dim sConnString As String = "Data Source = " + strServidor + "; Initial Catalog = " + strBanco + "; User Id =" + strUsuarioBanco + "; Password =" + strSenhaUsuarioBanco
        'Retorna uma conexão.
        Return New SqlConnection(sConnString)
    End Function

    Sub fArmazenaXml(ByVal xml As String, ByVal Tipo As String)
        sArm_xml = xml
        sArm_Tipo = Tipo
    End Sub

End Module
