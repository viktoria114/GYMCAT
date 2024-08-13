Imports MySql.Data.MySqlClient

Public Class FormFinanzas

	Private miconexion As MySqlConnection
	Private FinanzasDataAdapter As MySqlDataAdapter
	Private finanzasdataset As DataSet
	Private vistadatosingresos As DataView
	Private vistadatosgastos As DataView
	Private Sub FormFinanzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		miconexion = New MySqlConnection()
		miconexion.ConnectionString = "Server=localhost; Database=gymcat; Uid=root; Pwd=;"
		FinanzasDataAdapter = New MySqlDataAdapter()

		' Cargar ingresos
		FinanzasDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM ingresos", miconexion)
		finanzasdataset = New DataSet()
		FinanzasDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
		FinanzasDataAdapter.Fill(finanzasdataset, "Tingresos")

		' Cargar egresos
		FinanzasDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM gastos", miconexion)
		FinanzasDataAdapter.Fill(finanzasdataset, "Tgastos")

		' Crear vistas de datos
		vistadatosingresos = finanzasdataset.Tables("Tingresos").DefaultView
		vistadatosgastos = finanzasdataset.Tables("Tgastos").DefaultView

		' Mostrar ingresos por defecto
		dgvListadoFinanzas.DataSource = vistadatosingresos
		dgvListadoFinanzas.Columns(0).Visible = False

		cbMostrar.SelectedIndex = 0
	End Sub

	Private Sub cbMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMostrar.SelectedIndexChanged
		Select Case cbMostrar.SelectedItem.ToString()
			Case "Ingresos"
				dgvListadoFinanzas.DataSource = vistadatosingresos
			Case "Egresos"
				dgvListadoFinanzas.DataSource = vistadatosgastos
			Case "Todos"
				Dim todosLosMovimientos As DataTable = finanzasdataset.Tables("Tingresos").Clone()
				todosLosMovimientos.Merge(finanzasdataset.Tables("Tingresos"))
				todosLosMovimientos.Merge(finanzasdataset.Tables("Tgastos"))
				dgvListadoFinanzas.DataSource = todosLosMovimientos.DefaultView
		End Select
	End Sub

	Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

	End Sub
End Class