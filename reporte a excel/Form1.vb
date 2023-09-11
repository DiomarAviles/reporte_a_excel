Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PRACTICA_XDDataSet.PERSONAS' Puede moverla o quitarla según sea necesario.
        Me.PERSONASTableAdapter.Fill(Me.PRACTICA_XDDataSet.PERSONAS)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As New SqlClient.SqlConnection("Data source=DESKTOP-QDSFA8K\SQLEXPRESS;initial catalog=capacitacion; integrated security=SSPI;persist security info=false; trusted_connection = yes;")
        Dim cmd As SqlClient.SqlCommand
        Dim sqlread As SqlClient.SqlDataReader
        Dim query As String


    End Sub
End Class
