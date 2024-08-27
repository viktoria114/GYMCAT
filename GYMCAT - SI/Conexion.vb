Imports MySql.Data.MySqlClient
Public Class Conexion
    Public miConexion As MySqlConnection
    Public TablaDataAdapter As MySqlDataAdapter
    Public GymcatDataSet As DataSet
    Public vistaDatos As DataView
    Public vistaDatos2 As DataView
    Public vistaDatos3 As DataView
    Public esNuevo As Boolean
    Public idFila As Integer


    Public Sub New()
        Me.miConexion = New MySqlConnection()
        Me.miConexion.ConnectionString = "Server=localhost; Database=gymcat; Uid=root; Pwd=;"
    End Sub

    Public Sub New(consulta As String, tabla As String)
        Me.miConexion = New MySqlConnection()
        Me.miConexion.ConnectionString = "Server=localhost; Database=gymcat; Uid=root; Pwd=;"
        Me.TablaDataAdapter = New MySqlDataAdapter()
        Me.TablaDataAdapter.SelectCommand = New MySqlCommand(consulta, miConexion)
        Me.GymcatDataSet = New DataSet()
        GymcatDataSet.Tables.Add(tabla)

        Me.TablaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Me.TablaDataAdapter.Fill(GymcatDataSet.Tables(tabla))

        Me.vistaDatos = GymcatDataSet.Tables(tabla).DefaultView

    End Sub

    Public Sub New(consulta As String, consulta2 As String, tabla As String, tabla2 As String)
        Me.miConexion = New MySqlConnection()
        Me.miConexion.ConnectionString = "Server=localhost; Database=gymcat; Uid=root; Pwd=;"
        Me.TablaDataAdapter = New MySqlDataAdapter()

        Me.TablaDataAdapter.SelectCommand = New MySqlCommand(consulta, miConexion)
        Me.GymcatDataSet = New DataSet()
        GymcatDataSet.Tables.Add(tabla)
        Me.TablaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Me.TablaDataAdapter.Fill(GymcatDataSet.Tables(tabla))
        Me.vistaDatos = GymcatDataSet.Tables(tabla).DefaultView

        Me.TablaDataAdapter.SelectCommand = New MySqlCommand(consulta2, miConexion)
        GymcatDataSet.Tables.Add(tabla2)
        Me.TablaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Me.TablaDataAdapter.Fill(GymcatDataSet.Tables(tabla2))
        Me.vistaDatos2 = GymcatDataSet.Tables(tabla2).DefaultView

    End Sub

    Public Sub New(consulta As String, consulta2 As String, consulta3 As String, tabla As String, tabla2 As String, tabla3 As String)
        Me.miConexion = New MySqlConnection()
        Me.miConexion.ConnectionString = "Server=localhost; Database=gymcat; Uid=root; Pwd=;"
        Me.TablaDataAdapter = New MySqlDataAdapter()

        Me.TablaDataAdapter.SelectCommand = New MySqlCommand(consulta, miConexion)
        Me.GymcatDataSet = New DataSet()
        GymcatDataSet.Tables.Add(tabla)
        Me.TablaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Me.TablaDataAdapter.Fill(GymcatDataSet.Tables(tabla))
        Me.vistaDatos = GymcatDataSet.Tables(tabla).DefaultView

        Me.TablaDataAdapter.SelectCommand = New MySqlCommand(consulta2, miConexion)
        GymcatDataSet.Tables.Add(tabla2)
        Me.TablaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Me.TablaDataAdapter.Fill(GymcatDataSet.Tables(tabla2))
        Me.vistaDatos2 = GymcatDataSet.Tables(tabla2).DefaultView

        Me.TablaDataAdapter.SelectCommand = New MySqlCommand(consulta3, miConexion)
        GymcatDataSet.Tables.Add(tabla3)
        Me.TablaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Me.TablaDataAdapter.Fill(GymcatDataSet.Tables(tabla3))
        Me.vistaDatos3 = GymcatDataSet.Tables(tabla3).DefaultView

    End Sub

End Class





