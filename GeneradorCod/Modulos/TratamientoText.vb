Module TratamientoText
    Public Function M1_REMPLAZATODOCLAVEVALOR(dgvValoresARemplazar As DataGridView, Texto As String) As String
        Dim ContenidoComponenteRichTextBox As String
        ContenidoComponenteRichTextBox = RemplazosDeClaveValor(dgvValoresARemplazar, Texto)
        Return ContenidoComponenteRichTextBox
    End Function

    'Remplaza todos los calve valor que hay en un texto, recibe un datagrid con los clave valor y el texto donde hara los remplazos
    Public Function RemplazosDeClaveValor(dgvClaveValor As DataGridView, ByVal TextoComoParametro As String) As String
        '1- Genera el Datatable con el contenido del dgv que contiene los replaces y valores a remplazar
        Dim DtRemplazos As DataTable
        DtRemplazos = DataGridViewToDataTable(dgvClaveValor)
        DtRemplazos.Columns("DataGridViewTextBoxColumn3").ColumnName = "Clave"
        DtRemplazos.Columns("DataGridViewTextBoxColumn4").ColumnName = "Valor"
        Dim ValorTemporal As String
        Dim valorentregado As String = ""
        'Dim TextoRemplazado As String
        ''2- Trunca la tabla de replace para limpiar su contenido 
        'AccesoDatos.TruncaReplace()
        ''3- Guarda el texto que llega con los parametros para luego ir siendo actualizado cada vez que se haga un replace
        'AccesoDatos.InsertaArchivoRepalce(TextoComoParametro)
        For Each row As DataRow In DtRemplazos.Rows
            Dim Clave As String = CStr(row("Clave"))
            Dim Valor As String = CStr(row("Valor"))
            ValorTemporal = TextoComoParametro.Replace(Clave, Valor)
        Next
        'Se pone este return ya que no se entiende quien usa esta funcion y esta dando una advertencia
        Return valorentregado
    End Function

    Public Function DataGridViewToDataTable(dgv As DataGridView) As DataTable

        ' Si no es válido el control DataGridView,
        ' devolvemos el valor Nothing.
        '
        If (dgv Is Nothing) Then Return Nothing

        ' Creamos un nuevo objeto DataTable.
        '
        Dim dt As New DataTable()

        ' Conforme recorremos las columnas existentes
        ' en el control DataGridView, vamos creando
        ' nuevas columnas en el objeto DataTable.
        '
        For Each col As DataGridViewColumn In dgv.Columns
            Dim column As New DataColumn(col.Name, Type.GetType("System.String"))
            dt.Columns.Add(column)
        Next

        ' Una vez creada la estructura del objeto DataTable,
        ' recorremos las filas del control DataGridView para
        ' rellenar de datos el objeto DataTable.
        '
        For Each viewRow As DataGridViewRow In dgv.Rows

            ' Creamos una nueva fila en el objeto DataTable;
            ' un objeto DataRow.
            '
            Dim row As DataRow = dt.NewRow()

            For Each col As DataGridViewColumn In dgv.Columns

                ' Valor de la celda actual del control DataGridView1.
                '
                Dim value As Object = viewRow.Cells(col.Name).Value

                ' Si el valor es Nothing, le asignamos un valor NULL a la
                ' columna del objeto DataTable; en caso contrario le asignamos
                ' el valor de la celda del control DataGridView.
                '
                row.Item(col.Name) = If(value Is Nothing, DBNull.Value, value)

            Next col        ' Siguiente columna

            ' Añadimos la fila al objeto DataTable.
            '
            dt.Rows.Add(row)

        Next viewRow ' Siguiente fila

        ' Por último devolvemos el objeto DataTable creado.
        '
        Return dt

    End Function



End Module
