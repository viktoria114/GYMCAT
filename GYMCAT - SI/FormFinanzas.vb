Imports MySql.Data.MySqlClient

Public Class FormFinanzas
    Private _Conexion As Conexion
    Public Tabla As String = "Tingresos"
    Public Tabla2 As String = "Tgastos"
    Public Tabla3 As String = "TTodo"
    Public NumData As Integer
    Private Sub FormFinanzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As String = "SELECT * FROM ingresos"
        Dim consulta2 As String = "SELECT * FROM gastos"
        Dim consulta3 As String = "SELECT ID_ingresos as ID_Pago, fecha_pago, monto, forma_pago, concepto FROM ingresos UNION SELECT ID_gastos, fecha_gasto, monto, forma_pago, concepto FROM gastos ORDER BY fecha_pago"

        _Conexion = New Conexion(consulta, consulta2, consulta3, Tabla, Tabla2, Tabla3)

        Dim dt As DataTable = _Conexion.GymcatDataSet.Tables("TTodo")
        ' Define la clave primaria
        dt.PrimaryKey = New DataColumn() {dt.Columns("ID_Pago1")}

        ' Mostrar ingresos por defecto
        dgvListadoFinanzas.DataSource = _Conexion.vistaDatos
        dgvListadoFinanzas.Columns(0).Visible = False
        NumData = 1

        cbMostrar.SelectedIndex = 0
    End Sub

    Private Sub cbMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMostrar.SelectedIndexChanged
        Select Case cbMostrar.SelectedItem.ToString()
            Case "Ingresos"
                dgvListadoFinanzas.DataSource = _Conexion.vistaDatos
                dgvListadoFinanzas.Columns(0).Visible = False
                NumData = 1
                btnAgregar.Enabled = True
                btnAgregar.BackColor = Color.FromArgb(239, 41, 84)
                btnBorrar.Enabled = True
                btnBorrar.BackColor = Color.FromArgb(239, 41, 84)
                btnEditar.Enabled = True
                btnEditar.BackColor = Color.FromArgb(239, 41, 84)
            Case "Egresos"
                dgvListadoFinanzas.DataSource = _Conexion.vistaDatos2
                dgvListadoFinanzas.Columns(0).Visible = False
                NumData = 2
                btnAgregar.Enabled = True
                btnAgregar.BackColor = Color.FromArgb(239, 41, 84)
                btnBorrar.Enabled = True
                btnBorrar.BackColor = Color.FromArgb(239, 41, 84)
                btnEditar.Enabled = True
                btnEditar.BackColor = Color.FromArgb(239, 41, 84)
            Case "Todos"
                dgvListadoFinanzas.DataSource = _Conexion.vistaDatos3
                dgvListadoFinanzas.Columns(0).Visible = False
                NumData = 3
                btnAgregar.Enabled = False
                btnAgregar.BackColor = Color.FromArgb(35, 32, 39)
                btnBorrar.Enabled = False
                btnBorrar.BackColor = Color.FromArgb(35, 32, 39)
                btnEditar.Enabled = False
                btnEditar.BackColor = Color.FromArgb(35, 32, 39)
        End Select
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If _Conexion.miConexion.State = ConnectionState.Closed Then
            _Conexion.miConexion.Open()
        End If

        Select Case NumData
            Case 1
                Borrar_Ingreso()
            Case 2
                Borrar_Gasto()
        End Select

        _Conexion.miConexion.Close()
    End Sub

    Sub Borrar_Ingreso()
        Dim fila As DataGridViewRow = dgvListadoFinanzas.CurrentRow
        _Conexion.idFila = fila.Cells(0).Value
        If (MessageBox.Show("¿Está seguro de eliminar este Ingreso?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            Dim deleteDependentRecordsCommand As New MySqlCommand("DELETE FROM miembros_mes_ingresos WHERE FK_ingresos = @id", _Conexion.miConexion)
            deleteDependentRecordsCommand.Parameters.Add("@id", MySqlDbType.Int64).Value = _Conexion.idFila
            deleteDependentRecordsCommand.ExecuteNonQuery()

            ' Luego elimina el registro en la tabla gastos
            _Conexion.GymcatDataSet.Tables(Tabla).Rows.Find(_Conexion.idFila).Delete()
            _Conexion.TablaDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM ingresos WHERE ID_ingresos = @id", _Conexion.miConexion)
            _Conexion.TablaDataAdapter.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int64).Value = _Conexion.idFila
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))
        End If
    End Sub

    Sub Borrar_Gasto()
        Dim fila As DataGridViewRow = dgvListadoFinanzas.CurrentRow
        _Conexion.idFila = fila.Cells(0).Value
        If (MessageBox.Show("¿Está seguro de eliminar este Gasto?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            Dim deleteDependentRecordsCommand As New MySqlCommand("DELETE FROM empleados_mes_gastos WHERE FK_gastos = @id", _Conexion.miConexion)
            deleteDependentRecordsCommand.Parameters.Add("@id", MySqlDbType.Int64).Value = _Conexion.idFila
            deleteDependentRecordsCommand.ExecuteNonQuery()

            ' Luego elimina el registro en la tabla gastos
            _Conexion.GymcatDataSet.Tables(Tabla2).Rows.Find(_Conexion.idFila).Delete()
            _Conexion.TablaDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM gastos WHERE ID_gastos = @id", _Conexion.miConexion)
            _Conexion.TablaDataAdapter.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int64).Value = _Conexion.idFila
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla2))
        End If
    End Sub

End Class