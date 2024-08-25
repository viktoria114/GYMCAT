Imports MySql.Data.MySqlClient

Public Class FormFinanzas
	Private _Conexion As Conexion
	Public Tabla As String = "Tingresos"
	Public Tabla2 As String = "Tgastos"
	Public Tabla3 As String = "TTodo"
	Public vistaDatos3 As DataView
	Private Sub FormFinanzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim consulta As String = "SELECT * FROM ingresos"
		Dim consulta2 As String = "SELECT * FROM gastos"
		Dim consulta3 As String = "SELECT ID_ingresos as 'ID Pago', fecha_pago, monto, forma_pago, concepto FROM ingresos UNION SELECT ID_gastos, fecha_gasto, monto, forma_pago, concepto FROM gastos ORDER BY fecha_pago"

		_Conexion = New Conexion(consulta, consulta2, consulta3, Tabla, Tabla2, Tabla3)

		' Mostrar ingresos por defecto
		dgvListadoFinanzas.DataSource = _Conexion.vistaDatos
		dgvListadoFinanzas.Columns(0).Visible = False

		cbMostrar.SelectedIndex = 0
	End Sub

	Private Sub cbMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMostrar.SelectedIndexChanged
		Select Case cbMostrar.SelectedItem.ToString()
			Case "Ingresos"
				dgvListadoFinanzas.DataSource = _Conexion.vistaDatos
				dgvListadoFinanzas.Columns(0).Visible = False
			Case "Egresos"
				dgvListadoFinanzas.DataSource = _Conexion.vistaDatos2
				dgvListadoFinanzas.Columns(0).Visible = False
			Case "Todos"
				dgvListadoFinanzas.DataSource = _Conexion.vistaDatos3
				dgvListadoFinanzas.Columns(0).Visible = False

		End Select
	End Sub

	Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

	End Sub
End Class