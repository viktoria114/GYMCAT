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

    'Public Sub New(miConexion As MySqlConnection, xDataAdapter As MySqlDataAdapter, gymcatDataSet As DataSet, vistaDatos As DataView, esNuevo As Boolean, idFila As Integer)
    '    Me.miConexion = miConexion
    '    Me.XDataAdapter = xDataAdapter
    '    Me.GymcatDataSet = gymcatDataSet
    '    Me.vistaDatos = vistaDatos
    '    Me.esNuevo = esNuevo
    '    Me.idFila = idFila
    'End Sub




    'miConexion = New MySqlConnection("Server=localhost; Database=gymcat; Uid=root; Pwd=;")
End Class
