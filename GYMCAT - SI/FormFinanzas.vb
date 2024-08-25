Imports MySql.Data.MySqlClient

Public Class FormFinanzas
	Private _Conexion As Conexion
	Public Tabla As String = "Tingresos"
	Public Tabla2 As String = "Tgastos"

	Private Sub FormFinanzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim consulta As String = "SELECT * FROM ingresos"
		Dim consulta2 As String = "SELECT * FROM gastos"

		_Conexion = New Conexion(consulta, consulta2, Tabla, Tabla2)

		' Mostrar ingresos por defecto
		dgvListadoFinanzas.DataSource = _Conexion.vistaDatos
		dgvListadoFinanzas.Columns(0).Visible = False


		cbMostrar.SelectedIndex = 0

	End Sub

	Private Sub cbMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMostrar.SelectedIndexChanged
		Select Case cbMostrar.SelectedItem.ToString()
			Case "Ingresos"
				dgvListadoFinanzas.DataSource = _Conexion.vistaDatos
			Case "Egresos"
				dgvListadoFinanzas.DataSource = _Conexion.vistaDatos2
			Case "Todos"
				Dim todosLosMovimientos As DataTable = _Conexion.GymcatDataSet.Tables("Tingresos").Clone()
				todosLosMovimientos.Merge(_Conexion.GymcatDataSet.Tables("Tingresos"))
				todosLosMovimientos.Merge(_Conexion.GymcatDataSet.Tables("Tgastos"))
				dgvListadoFinanzas.DataSource = todosLosMovimientos.DefaultView
		End Select
	End Sub


End Class