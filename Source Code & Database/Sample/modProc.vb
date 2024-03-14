Imports System.Data.SqlClient
Module modProc
    Public con As New SqlConnection("Data Source=DESKTOP-LDAMHSD;Initial Catalog=vetdb;Integrated Security=True")
    Public cmd As New SqlCommand
    Public rdr As SqlDataReader

    Public Sub connect()

        If con.State = ConnectionState.Open Then
            con.Close()
            con.Open()
        ElseIf con.State = ConnectionState.Closed Then
            con.Open()
        Else
            con.Close()
            con.Open()
        End If
    End Sub
End Module
