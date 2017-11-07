Imports System.Data.SqlClient
Public Class frmListarProductos
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnListarProductos_Click(sender As Object, e As EventArgs) Handles btnListarProductos.Click

        'Conexion
        Dim builder As New SqlConnectionStringBuilder
        builder("Data Source") = "SERVIDOR01\SQLEXPRESS"
        builder("Integrated Security") = True
        builder("Initial Catalog") = "AdventureWorks2012"

        Using connection As New SqlConnection(builder.ConnectionString)

            Dim cmd As SqlCommand = New SqlCommand("Select DepartmentID, Name From HumanResources.Department", connection)
            cmd.CommandType = CommandType.Text

            connection.Open()
            Dim reader As SqlClient.SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)

            Dim bs As BindingSource = New BindingSource
            bs.DataSource = reader

            dgvProductos.DataSource = bs
            connection.Close()

        End Using
    End Sub
End Class
