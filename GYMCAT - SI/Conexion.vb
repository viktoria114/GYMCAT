Imports MySql.Data.MySqlClient
Public Class Conexion
    Public miConexion As MySqlConnection
    Public XDataAdapter As MySqlDataAdapter
    Public GymcatDataSet As DataSet
    Public vistaDatos As DataView
    Public esNuevo As Boolean
    Public idFila As Integer


    Public Sub New(consulta As String, tabla As String)
        Me.miConexion = New MySqlConnection()
        Me.miConexion.ConnectionString = "Server=localhost; Database=gymcat; Uid=root; Pwd=;"
        Me.XDataAdapter = New MySqlDataAdapter()
        Me.XDataAdapter.SelectCommand = New MySqlCommand(consulta, miConexion)
        Me.GymcatDataSet = New DataSet()
        GymcatDataSet.Tables.Add(tabla)

        Me.XDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Me.XDataAdapter.Fill(GymcatDataSet.Tables(tabla))

        Me.vistaDatos = GymcatDataSet.Tables(tabla).DefaultView

    End Sub


End Class
