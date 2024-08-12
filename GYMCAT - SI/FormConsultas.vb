Imports MySql.Data.MySqlClient

Public Class FormConsultas
    Private cmd As MySqlCommand
    Private tablaResultado As DataTable
    Private dataReader As MySqlDataReader
    Private miConexion As MySqlConnection

    Private Sub FormConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ElegirConsulta()
        miConexion = New MySqlConnection("Server=localhost; Database=gymcat; Uid=root; Pwd=;")
        miConexion.Open()
        Dim consulta = "SELECT nombre FROM cursos"
        Dim comando As New MySqlCommand(consulta, miConexion)
        Dim lector = comando.ExecuteReader

        If lector.HasRows Then
            While lector.Read()
                cbCurMiembro.Items.Add(lector("nombre"))
                cbCursos.Items.Add(lector("nombre"))
            End While
        End If
        lector.Close()
        miConexion.Close()

    End Sub

    Private Sub rbMiembrosenCursos_CheckedChanged(sender As Object, e As EventArgs) Handles rbMiembrosenCursos.CheckedChanged
        ElegirConsulta()
    End Sub

    Private Sub rbMiembrosconDeudas_CheckedChanged(sender As Object, e As EventArgs) Handles rbMiembrosconDeudas.CheckedChanged
        ElegirConsulta()
    End Sub

    Private Sub rbMejoresMiembros_CheckedChanged(sender As Object, e As EventArgs) Handles rbMejoresMiembros.CheckedChanged
        ElegirConsulta()
    End Sub

    Private Sub rbElementosenCursos_CheckedChanged(sender As Object, e As EventArgs) Handles rbElementosenCursos.CheckedChanged
        ElegirConsulta()
    End Sub

    Sub ElegirConsulta()
        Dim CursoMiembro As Control() = {cbCurMiembro}
        Dim MembreVencer As Control() = {dtpMemb}
        Dim MejorMiem As Control() = {cbMejMiemb}
        Dim ElemenCurso As Control() = {cbCursos}

        For Each ctrl As Control In CursoMiembro.Concat(MembreVencer).Concat(MejorMiem).Concat(ElemenCurso)
            ctrl.Enabled = False
        Next

        Select Case True
            Case rbMiembrosenCursos.Checked
                HabilitarControles(CursoMiembro)

            Case rbMiembrosconDeudas.Checked
                HabilitarControles(MembreVencer)

            Case rbMejoresMiembros.Checked
                HabilitarControles(MejorMiem)

            Case rbElementosenCursos.Checked
                HabilitarControles(ElemenCurso)
            Case Else

        End Select
    End Sub

    Private Sub HabilitarControles(controles As Control())
        For Each ctrl As Control In controles
            ctrl.Enabled = True
        Next
    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        miConexion.Open()
        cmd = New MySqlCommand

        Select Case True
            Case rbMiembrosenCursos.Checked
                cmd.CommandText = "
                SELECT
                    cursos.nombre AS 'Cursos',
                    miembros_cursos.ID_inscripción AS 'ID de Inscripción',
                    CONCAT(miembros.nombre, ' ', miembros.apellido) AS 'Nombre Completo',
                    miembros_cursos.fecha_inscripcion AS 'Fecha de Inscripción'
                FROM
                    cursos, miembros, miembros_cursos
                WHERE
                    miembros.ID_miembro = miembros_cursos.FK_miembros
                    AND cursos.ID_cursos = miembros_cursos.FK_cursos
                    AND cursos.nombre = @curso
                ORDER BY
                    cursos.nombre, miembros_cursos.id_inscripción;"

                cmd.Parameters.AddWithValue("@curso", cbCurMiembro.Text)

            Case rbMiembrosconDeudas.Checked

                cmd.CommandText = "
                            SELECT d.producto_id, p.nombre, SUM(d.cantidad) AS cantidad_ventas 
                            FROM detalle d
                            INNER JOIN productos p ON d.producto_id = p.id 
                            GROUP BY d.producto_id
                            ORDER BY cantidad_ventas DESC
                            LIMIT @nro"

                cmd.Parameters.AddWithValue("@nro", Convert.ToInt32(cbNroProductos.Text))

                '    Case rbMejoresMiembros.Checked
                '        If rbClienteCantidad.Checked Then
                '            cmd.CommandText = "
                '            SELECT f.cliente_id, CONCAT(c.nombre,' ', c.apellido ) AS nombre_completo, COUNT(f.cliente_id) AS cantidad_compras 
                '            FROM factura f
                '            INNER JOIN clientes c ON f.cliente_id = c.id 
                '            GROUP BY f.cliente_id
                '            ORDER BY cantidad_compras DESC
                '            LIMIT @nro"
                '        Else
                '            cmd.CommandText = "
                '            SELECT f.cliente_id, CONCAT(c.nombre,' ', c.apellido ) AS nombre_completo, SUM(d.cantidad * d.precio) AS monto_compras 
                '            FROM detalle d
                '            INNER JOIN factura f ON d.factura_id = f.id
                '            INNER JOIN clientes c ON f.cliente_id = c.id 
                '            GROUP BY f.cliente_id
                '            ORDER BY monto_compras DESC
                '            LIMIT @nro"
                '        End If

                '        cmd.Parameters.AddWithValue("@nro", Convert.ToInt32(cbNroClientes.Text))

            Case rbElementosenCursos.Checked
                cmd.CommandText = "
                SELECT
                    cursos.nombre AS 'Cursos',
                    CONCAT(`elementos deportivos`.nombre, ' ', `elementos deportivos`.modelo) AS 'Elemento',
                    cursos.turno,
                    cursos.horario
                FROM
                    cursos, `elementos deportivos`, cursos_elementos_maquinas
                WHERE
                    `elementos deportivos`.ID_elementos_deportivos = cursos_elementos_maquinas.FK_elementos
                    AND cursos.ID_cursos = cursos_elementos_maquinas.FK_cursos
                    AND cursos.nombre = @curso
                ORDER BY
                    cursos.nombre;"

                cmd.Parameters.AddWithValue("@curso", cbCursos.Text)

            Case rbStockBajo.Checked
                cmd.CommandText = "SELECT id, nombre, stock FROM productos WHERE stock <= @nro ORDER BY stock ASC"

                cmd.Parameters.AddWithValue("@nro", Convert.ToInt32(tbNroProductos.Text))

            Case Else

        End Select

        cmd.Connection = miConexion

        If tablaResultado Is Nothing Then
            tablaResultado = New DataTable
        Else
            tablaResultado.Clear()
            tablaResultado.Columns.Clear()
        End If

        dataReader = cmd.ExecuteReader

        If dataReader.HasRows Then
            tablaResultado.Load(dataReader)
        Else
            MsgBox("Consulta sin resultados")
        End If

        dataReader.Close()

        miConexion.Close()

        dgvResultados.DataSource = tablaResultado
    End Sub
End Class