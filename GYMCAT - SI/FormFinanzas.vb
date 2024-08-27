Imports DocumentFormat.OpenXml.Vml
Imports MySql.Data.MySqlClient

Public Class FormFinanzas
    Public _Conexion As Conexion
    Public Tabla As String = "Tingresos"
    Public Tabla2 As String = "Tgastos"
    Public Tabla3 As String = "TTodo"
    Public NumData As Integer
    Public miFormularioPago As FormPagopopup
    Private Sub FormFinanzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizardvg()
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
                dgvListadoFinanzas.Rows(0).Selected = True
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

    Sub actualizardvg()
        Dim consulta As String = "SELECT * FROM ingresos"
        Dim consulta2 As String = "SELECT * FROM gastos"
        Dim consulta3 As String = "SELECT ID_ingresos as 'ID Pago', fecha_pago, monto, forma_pago, concepto FROM ingresos UNION SELECT ID_gastos, fecha_gasto, monto, forma_pago, concepto FROM gastos ORDER BY fecha_pago"

        _Conexion = New Conexion(consulta, consulta2, consulta3, Tabla, Tabla2, Tabla3)


        ' Mostrar ingresos por defecto
        dgvListadoFinanzas.DataSource = _Conexion.vistaDatos
        dgvListadoFinanzas.Columns(0).Visible = False


        cbMostrar.SelectedIndex = 0
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        _Conexion.esNuevo = True
        miFormularioPago = New FormPagopopup(cbMostrar.Text)
        miFormularioPago.ShowDialog()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        _Conexion.esNuevo = False
        miFormularioPago = New FormPagopopup(cbMostrar.Text)
        miFormularioPago.ShowDialog()
    End Sub

    Sub GuardarIngresos()
        Dim fila As DataRow
        Dim cmd As String
        If _Conexion.esNuevo Then
            '1. Crear una nueva fila 
            fila = _Conexion.GymcatDataSet.Tables(Tabla).NewRow
            '2. Rellenar la fila con información
            fila("fecha_pago") = miFormularioPago.dtpFechaMov.Text
            fila("forma_pago") = miFormularioPago.cbFormaPago.Text
            fila("monto") = miFormularioPago.tbMonto.Text
            fila("concepto") = miFormularioPago.tbConcepto.Text

            '3. Agregar fila a la tabla del DataSet
            _Conexion.GymcatDataSet.Tables(Tabla).Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva cmd
            cmd = "INSERT INTO ingresos (fecha_pago, forma_pago, monto, concepto) VALUES (@fecha, @forma, @mon, @con)"
            _Conexion.TablaDataAdapter.InsertCommand = New MySqlCommand(cmd, _Conexion.miConexion)
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@fecha", MySqlDbType.Date, 20, "fecha_pago")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@forma", MySqlDbType.VarChar, 20, "forma_pago")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@mon", MySqlDbType.Int32, 50, "monto")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@con", MySqlDbType.VarChar, 250, "concepto")

            '5. Guardar los cambios en la base de datos
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))

            '6. V1olver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
            _Conexion.TablaDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM ingresos", _Conexion.miConexion)
            _Conexion.GymcatDataSet.Tables(Tabla).Clear()
            _Conexion.TablaDataAdapter.Fill(_Conexion.GymcatDataSet.Tables(Tabla))
        Else
            '1 seleccionar fila editar
            fila = _Conexion.GymcatDataSet.Tables(Tabla).Rows.Find(_Conexion.idFila)
            '2. Rellenar la fila con información
            fila("fecha_pago") = miFormularioPago.dtpFechaMov.Text
            fila("forma_pago") = miFormularioPago.cbFormaPago.Text
            fila("monto") = miFormularioPago.tbMonto.Text
            fila("concepto") = miFormularioPago.tbConcepto.Text

            '3. Crear el comando para odificar la Fila
            cmd = "UPDATE ingresos 
                       SET fecha_pago=@fecha, forma_pago=@forma, monto=@mon, concepto=@con
                       WHERE ID_ingresos=@id"
            _Conexion.TablaDataAdapter.UpdateCommand = New MySqlCommand(cmd, _Conexion.miConexion)
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@fecha", MySqlDbType.Date, 20, "fecha_pago")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@forma", MySqlDbType.VarChar, 20, "forma_pago")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@mon", MySqlDbType.Int32, 50, "monto")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@con", MySqlDbType.VarChar, 250, "concepto")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "ID_ingresos")

            '4. Guardar los cambios en la base de datos
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))
        End If
    End Sub

    Sub GuardarEgresos()
        Dim fila As DataRow
        Dim cmd As String
        If _Conexion.esNuevo Then
            '1. Crear una nueva fila 
            fila = _Conexion.GymcatDataSet.Tables(Tabla2).NewRow
            '2. Rellenar la fila con información
            fila("fecha_gasto") = miFormularioPago.dtpFechaMov.Text
            fila("monto") = miFormularioPago.tbMonto.Text
            fila("forma_pago") = miFormularioPago.cbFormaPago.Text
            fila("concepto") = miFormularioPago.tbConcepto.Text

            '3. Agregar fila a la tabla del DataSet
            _Conexion.GymcatDataSet.Tables(Tabla2).Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva cmd
            cmd = "INSERT INTO gastos (fecha_gasto, monto, forma_pago, concepto) VALUES (@fecha, @mon, @forma, @con)"
            _Conexion.TablaDataAdapter.InsertCommand = New MySqlCommand(cmd, _Conexion.miConexion)
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@fecha", MySqlDbType.Date, 20, "fecha_gasto")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@mon", MySqlDbType.Int32, 50, "monto")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@forma", MySqlDbType.VarChar, 20, "forma_pago")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@con", MySqlDbType.VarChar, 250, "concepto")

            '5. Guardar los cambios en la base de datos
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla2))

            '6. V1olver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
            _Conexion.TablaDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM gastos", _Conexion.miConexion)
            _Conexion.GymcatDataSet.Tables(Tabla2).Clear()
            _Conexion.TablaDataAdapter.Fill(_Conexion.GymcatDataSet.Tables(Tabla2))
        Else
            '1 seleccionar fila editar
            fila = _Conexion.GymcatDataSet.Tables(Tabla2).Rows.Find(_Conexion.idFila)
            '2. Rellenar la fila con información
            fila("fecha_gasto") = miFormularioPago.dtpFechaMov.Text
            fila("monto") = miFormularioPago.tbMonto.Text
            fila("forma_pago") = miFormularioPago.cbFormaPago.Text
            fila("concepto") = miFormularioPago.tbConcepto.Text

            '3. Crear el comando para odificar la Fila
            cmd = "UPDATE gastos 
                       SET fecha_gasto=@fecha, monto=@mon, forma_pago=@forma, concepto=@con
                       WHERE ID_gastos=@id"
            _Conexion.TablaDataAdapter.UpdateCommand = New MySqlCommand(cmd, _Conexion.miConexion)
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@fecha", MySqlDbType.Date, 20, "fecha_gasto")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@mon", MySqlDbType.Int32, 50, "monto")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@forma", MySqlDbType.VarChar, 20, "forma_pago")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@con", MySqlDbType.VarChar, 250, "concepto")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "ID_gastos")

            '4. Guardar los cambios en la base de datos
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla2))
        End If
    End Sub

    Private Sub dgvListadoFinanzas_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoFinanzas.RowEnter

    End Sub
End Class