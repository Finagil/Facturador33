Public Class FrmFacturas

    Dim Consec As Integer = 0
    Dim FECHA_APLICACION As Date

    Private Sub TxtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFiltro.TextChanged
        If TxtFiltro.Text = "" Then
            Me.ClientesTableAdapter.Fill(Me.FinagilDS1.Clientes, "WWWWW")
        Else
            If TxtFiltro.Text.Length >= 3 Then
                Me.ClientesTableAdapter.Fill(Me.FinagilDS1.Clientes, TxtFiltro.Text)
            End If
        End If
        ListClientes.SelectedIndex = -1
    End Sub

    Private Sub RBTerceros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBTerceros.CheckedChanged
        Bloquea()
    End Sub

    Private Sub RBFinagil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBFinagil.CheckedChanged
        Bloquea()
    End Sub

    Sub Bloquea()
        If RBTerceros.Checked = True Then
            GroupTerceros.Enabled = True
            GroupFinagil.Enabled = False
        Else
            GroupTerceros.Enabled = False
            GroupFinagil.Enabled = True
        End If
        TxtRS.Text = ""
        Txtcalle.Text = ""
        Txtmunici.Text = ""
        Txtcol.Text = ""
        TxtEdo.Text = ""
        TxtRFC.Text = ""
        TxtCP.Text = ""
        TxtMail1.Text = ""
        TxtMail2.Text = ""
    End Sub

    Private Sub FrmFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductionDS.CFDI_UsosCFDI' table. You can move, or remove it, as needed.
        Me.CFDI_UsosCFDITableAdapter.Fill(Me.ProductionDS.CFDI_UsosCFDI)
        'TODO: This line of code loads data into the 'ProductionDS.FacturasExternas' table. You can move, or remove it, as needed.
        'Me.FacturasExternasTableAdapter.Fill(Me.FinagilDS1.FacturasExternas)
        'TODO: esta línea de código carga datos en la tabla 'FinagilDS1.CodigosSAT_Concepto' Puede moverla o quitarla según sea necesario.
        Me.CodigosSAT_ConceptoTableAdapter.Fill(Me.FinagilDS1.CodigosSAT_Concepto)
        Me.MetodoPagoTableAdapter.Fill(Me.FinagilDS1.Metodopago)

        'Dim tipoCambio As String
        cmbIva.SelectedIndex = 1
        cmbMoneda.Enabled = False
        cmbPago.Enabled = False
        lblTipoCambio.Enabled = False
        lblTipoCambio.Visible = False
        CmbSerie.Enabled = True
        'Me.FacturasExternasTableAdapter.Fill(Me.FinagilDS1.FacturasExternas)
        Me.FechasAplicacionTableAdapter.Fill(Me.FinagilDS1.FechasAplicacion, "Vigente")
        FECHA_APLICACION = Me.FinagilDS1.FechasAplicacion.Rows(0).ItemArray(0)
        Me.Text = Me.Text & "   Fecha de Aplicacion: " & FECHA_APLICACION.ToShortDateString & ""
        'tipoCambio = Me.FacturasExternasTableAdapter1.SacaTipoCambio("01/12/2017", "USD")
        lblFechaAplica.Text = FECHA_APLICACION.ToShortDateString
    End Sub

    Private Sub Btcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btcancelar.Click
        LbFolio.Text = "Folio"
        CmbSerie.SelectedIndex = -1
        cmbMoneda.SelectedIndex = -1
        cmbIva.SelectedIndex = 1
        Consec = 0
        GroupClientes.Enabled = True
        RBFinagil.Checked = True
        GroupDET.Enabled = False
        GroupFactura.Enabled = True
        TxtFiltro.Text = ""
        txbFolioFiscal.Text = ""
        GroupFinagil.Enabled = True
        cmbMoneda.Enabled = False
        CmbSerie.Enabled = True
        txbFolioFiscal.Visible = False
        TxtSerieCFDI.Visible = False
        TxtFolioCFDI.Visible = False
        LbSerie.Visible = False
        LbFolioCFDI.Visible = False
        TxtImporteFact.Visible = False
        lblFolioFiscal.Visible = False
        Me.FinagilDS1.FacturasExternas.Clear()
    End Sub

    Private Sub BTAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAgregar.Click
        'cmbUsoCfdi.Enabled = True
        'cmbUsoCfdi.Visible = True
        'MsgBox("Longitud :" + txbFolioFiscal.Text.Length.ToString)
        If Trim(txbFolioFiscal.Text).Length <> 36 And CmbSerie.Text = "C" Then
            MessageBox.Show("Error en Folio Fiscal", "Error Logitud NO Valida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtSerieCFDI.Select()
            Exit Sub
        End If

        If txtMoral.Text = "False" And IsNumeric(Mid(TxtRFC.Text, 4, 1)) Then
            MessageBox.Show("Error en Uso de CFDI", "Error Tipo Peronsa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUsoCfdi.Select()
            Exit Sub
        End If

        If (TxtCantidad.Text = "" Or Not IsNumeric(TxtCantidad.Text) Or Val(TxtCantidad.Text) <= 0) Then
            MessageBox.Show("Error en Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtCantidad.Select()
            Exit Sub
        End If
        If (TxtPrecio.Text = "" Or Not IsNumeric(TxtPrecio.Text) Or Val(TxtPrecio.Text) <= 0) Then   ' Anterior Validacion:  Not IsNumeric(TxtPrecio.Text)
            MessageBox.Show("Error en Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPrecio.Select()
            Exit Sub
        End If
        If RDFinagil.Checked = True And CmbSerie.Text = "SA" Then
            MessageBox.Show("Error de Serie, solo para Arfin", "Errorde Serie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CmbSerie.Select()
            CmbSerie.SelectedIndex = -1
            Exit Sub
        End If
        If RDFinagil.Checked = False And CmbSerie.Text <> "SA" Then
            MessageBox.Show("Error de Serie, Arfin solo puede usar serie SA", "Errorde Serie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CmbSerie.Select()
            CmbSerie.SelectedIndex = -1
            Exit Sub
        End If

        GroupFactura.Enabled = False
        Dim TasaIva As Decimal = 0
        Dim IVAaux As Decimal = 0
        Select Case UCase(cmbIva.Text)
            Case "16 %"
                TasaIva = 0.16
                If CmbSerie.Text = "C" Then
                    If MessageBox.Show("Desea cambiar el importe de IVA", "IVA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        IVAaux = InputBox("Nuevo importe IVA", "IVA", Math.Round((TxtCantidad.Text * TxtPrecio.Text) * TasaIva, 2))
                    End If
                End If
            Case "0 %"
                TasaIva = 0.0
        End Select
        Consec += 1
        Dim r As FinagilDS1.FacturasExternasRow
        r = Me.FinagilDS1.FacturasExternas.NewRow
        r.Serie = CmbSerie.Text
        r.Factura = Consec
        r.Consec = Consec

        'r.Detalle = CmbConcepto.Text
        If TxtDesc.Text.Length > 0 Then
            r.Detalle = CmbConcepto.Text & " " & TxtDesc.Text.Trim
        Else
            r.Detalle = CmbConcepto.Text
        End If

        r.Cantidad = TxtCantidad.Text
        r.Unitario = TxtPrecio.Text
        If IVAaux > 0 Then
            r.Iva = IVAaux
        Else
            r.Iva = Math.Round((r.Cantidad * r.Unitario) * TasaIva, 2)
        End If

        r.Importe = Math.Round((r.Cantidad * r.Unitario), 2)
        r.fecha = FECHA_APLICACION
        r.Moneda = cmbMoneda.Text
        r.TasaIva = cmbIva.Text
        r.Facturado = False
        r.Nombre = UCase(TxtRS.Text)
        r.Calle = UCase(Txtcalle.Text)
        r.Colonia = UCase(Txtcol.Text)
        r.Municipio = UCase(Txtmunici.Text)
        r.Estado = UCase(TxtEdo.Text)
        r.CP = UCase(TxtCP.Text)
        r.RFC = UCase(TxtRFC.Text)
        r.Mail1 = TxtMail1.Text
        r.Mail2 = TxtMail2.Text
        r.Unidad = TxtUnidad.Text
        r.MetodoPagoSAT = cmbPago.Text
        r.CodigoART = CmbConcepto.SelectedValue
        r.UsoCFDI = txtUsoClave.Text 'cmbUsoCfdi.SelectedValue
        r.Finagil = RDFinagil.Checked

        Me.FinagilDS1.FacturasExternas.AddFacturasExternasRow(r)
        cmbIva.SelectedIndex = 1
        TxtCantidad.Clear()
        TxtPrecio.Clear()
        TotalGrid()
        TxtDesc.Text = ""

        'Else
        ''CmbMetodo.Visible = True
        'CmbMetodo.Visible = False
        'cmbUsoCfdi.Enabled = True

        'MsgBox("Seleccione Uso CFDI Válido para Persona Moral")
        'End If

    End Sub

    Private Sub CmbSerie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSerie.SelectedIndexChanged
        Dim Bandera As Boolean = False
        If CmbSerie.SelectedIndex <> -1 Then
            If TxtRS.Text = "" And RBFinagil.Checked = True Then
                MessageBox.Show("Falta seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtRS.Select()
                CmbSerie.SelectedIndex = -1
                Exit Sub
            End If
            If TxtRS.Text = "" And RBTerceros.Checked = True Then
                MessageBox.Show("Falta el nombre o razon social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtRS.Select()
                CmbSerie.SelectedIndex = -1
                Exit Sub
            End If
            If Txtcalle.Text = "" And RBTerceros.Checked = True Then
                MessageBox.Show("Falta la calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txtcalle.Select()
                CmbSerie.SelectedIndex = -1
                Exit Sub
            End If
            If Txtcol.Text = "" And RBTerceros.Checked = True Then
                MessageBox.Show("Falta la colonia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txtcol.Select()
                CmbSerie.SelectedIndex = -1
                Exit Sub
            End If
            If Txtmunici.Text = "" And RBTerceros.Checked = True Then
                MessageBox.Show("Falta el municipio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txtmunici.Select()
                CmbSerie.SelectedIndex = -1
                Exit Sub
            End If
            If TxtEdo.Text = "" And RBTerceros.Checked = True Then
                MessageBox.Show("Falta el Estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtEdo.Select()
                CmbSerie.SelectedIndex = -1
                Exit Sub
            End If
            If (TxtCP.Text = "" Or Not IsNumeric(TxtCP.Text)) And RBTerceros.Checked = True Then
                MessageBox.Show("Error en codigo postal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtCP.Select()
                CmbSerie.SelectedIndex = -1
                Exit Sub
            End If
            If (TxtRFC.Text = "" Or (TxtRFC.Text.Length <> 10 And TxtRFC.Text.Length <> 12 And TxtRFC.Text.Length <> 13)) And RBTerceros.Checked = True Then
                MessageBox.Show("Error en RFC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtRFC.Select()
                CmbSerie.SelectedIndex = -1
                Exit Sub
            End If
            If TxtMail1.Text.Trim.Length > 0 And InStr(TxtMail1.Text, "@") = 0 And RBTerceros.Checked = True Then
                MessageBox.Show("Error en correo electronico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtMail1.Select()
                CmbSerie.SelectedIndex = -1
                Exit Sub
            End If
            If TxtMail2.Text.Trim.Length > 0 And InStr(TxtMail1.Text, "@") = 0 And RBTerceros.Checked = True Then
                MessageBox.Show("Error en correo electronico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtMail2.Select()
                CmbSerie.SelectedIndex = -1
                Exit Sub
            End If
            If RDFinagil.Checked = True And CmbSerie.Text = "SA" Then
                MessageBox.Show("Error de Serie, solo para Arfin", "Errorde Serie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CmbSerie.Select()
                CmbSerie.SelectedIndex = -1
                Exit Sub
            End If
            If RDFinagil.Checked = False And CmbSerie.Text <> "SA" Then
                MessageBox.Show("Error de Serie, Arfin solo puede usar serie SA", "Errorde Serie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CmbSerie.Select()
                CmbSerie.SelectedIndex = -1
                Exit Sub
            End If
            GroupClientes.Enabled = False
            GroupFinagil.Enabled = False
            GroupTerceros.Enabled = False
            cmbMoneda.Enabled = True
            CmbSerie.Enabled = False
            Dim Folios As New FinagilDS1TableAdapters.FoliosTableAdapter

            If CmbSerie.Text = "B" Then
                LbFolio.Text = Folios.SerieB
            ElseIf CmbSerie.Text = "DV" Then
                LbFolio.Text = Folios.SerieDV
            ElseIf CmbSerie.Text = "C" Then
                LbFolio.Text = Folios.SerieC
                Bandera = True
            ElseIf CmbSerie.Text = "SA" Then
                LbFolio.Text = Folios.SerieSA
            End If

            txbFolioFiscal.Visible = Bandera
            TxtSerieCFDI.Visible = Bandera
            TxtFolioCFDI.Visible = Bandera
            lblFolioFiscal.Visible = Bandera
            LbSerie.Visible = Bandera
            LbFolioCFDI.Visible = Bandera
            LbCli.Visible = Bandera
            TxtImporteFact.Visible = Bandera

        End If
    End Sub

    Private Sub cmbMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMoneda.SelectedIndexChanged
        'GroupDET.Enabled = True
        'GroupFactura.Enabled = False
        Dim tipoCambio As String
        Dim FCambio As String = lblFechaAplica.Text.ToString
        tipoCambio = Me.FacturasExternasTableAdapter1.SacaTipoCambio(FCambio, "USD")


        'If CmbSerie.Text = "C" Then
        '    cmbPago.Text = "PUE"
        '    cmbPago.Enabled = False
        'Else
        cmbPago.Enabled = True
        'End If

        If cmbMoneda.Text = "USD" Then

            'FinagilDS1TableAdapters.FacturasExternasTableAdapter()

            lblTipoCambio.Enabled = True

            lblTipoCambio.Text = "Tipo de Cambio: " + tipoCambio
            lblTipoCambio.Visible = True
        Else
            lblTipoCambio.Enabled = False
            lblTipoCambio.Text = "  "
            lblTipoCambio.Visible = False
        End If
    End Sub

    Sub TotalGrid()
        Dim ST As Double
        Dim IVA As Double
        Dim TT As Double
        For Each rr As DataGridViewRow In GridFactura.Rows
            ST += rr.Cells("ImporteDataGridViewTextBoxColumn").Value
            IVA += rr.Cells("IvaDataGridViewTextBoxColumn").Value
            rr.Cells("ColumnTotalX").Value = rr.Cells("ImporteDataGridViewTextBoxColumn").Value + rr.Cells("IvaDataGridViewTextBoxColumn").Value
            TT += rr.Cells("ColumnTotalX").Value
        Next
        txtSubtotal.Text = ST.ToString("N2")
        TxtIva.Text = IVA.ToString("N2")
        TxtTotal.Text = TT.ToString("N2")
    End Sub

    Private Sub GridFactura_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles GridFactura.RowsRemoved
        TotalGrid()
    End Sub

    Private Sub BtFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFacturar.Click
        If GridFactura.Rows.Count <= 0 Then
            MessageBox.Show("Factura sin Lineas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim Folios As New FinagilDS1TableAdapters.FoliosTableAdapter
        Dim Folio As Double = 0

        'Dim NCredito As New ProductionDSTableAdapters.CFDI_ComplementoPagoTableAdapter
        'Dim Credito As Integer

        'Dim ROWcomplemento As Production_AUXDataSet.CFDI_ComplementoPagoRow
        'ROWcomplemento = Production_AUXDataSet.CFDI_ComplementoPago.NewCFDI_ComplementoPagoRow()

        Dim ROWcomplemento As ProductionDS.CFDI_ComplementoPagoRow
        'ROWcomplemento =
        'TableAdapters.CFDI_ComplementoPagoTableAdapterRow()
        'Production_AUXDataSet.CFDI_ComplementoPagoRow()
        ROWcomplemento = ProductionDS.CFDI_ComplementoPago.NewCFDI_ComplementoPagoRow()


        If CmbSerie.Text = "B" Then
            Folio = Folios.SerieB
            Folios.UpdateB(Folio)
        ElseIf CmbSerie.Text = "DV" Then
            Folio = Folios.SerieDV
            Folios.UpdateDV(Folio)
        ElseIf CmbSerie.Text = "C" Then
            Folio = Folios.SerieC

            'Me.NCredito.InsertaNotaCredito("DR", "TipoRelacion", "01", txbFolioFiscal, "", "", "", "", "", "", "", "", "", "", "", "", "", "", LbFolio.Text, "C")
            '  COMPLEMENTO DE PAGO  Registro 3
            ROWcomplemento = ProductionDS.CFDI_ComplementoPago.NewCFDI_ComplementoPagoRow()

            ROWcomplemento._1_DetalleAux_Tipo = "DR"
            ROWcomplemento._2_DetalleAux_DescTipo = "TipoRelacion"
            ROWcomplemento._3_DetalleAux_Misc01 = "01"
            ROWcomplemento._4_DetalleAux_Misc02 = txbFolioFiscal.Text
            ROWcomplemento._5_DetalleAux_Misc03 = ""
            ROWcomplemento._6_DetalleAux_Misc04 = ""
            ROWcomplemento._7_DetalleAux_Misc05 = ""
            ROWcomplemento._8_DetalleAux_Misc06 = " "
            ROWcomplemento._9_DetalleAux_Misc07 = ""
            ROWcomplemento._10_DetalleAux_Misc08 = ""
            ROWcomplemento._11_DetalleAux_Misc09 = ""
            ROWcomplemento._12_DetalleAux_Misc10 = ""
            ROWcomplemento._13_DetalleAux_Misc11 = ""
            ROWcomplemento._15_DetalleAux_Misc13 = ""
            ROWcomplemento._16_DetalleAux_Misc14 = ""
            ROWcomplemento._17_DetalleAux_Misc15 = ""
            ROWcomplemento._18_DetalleAux_Misc16 = ""   ' la tabla NO Acepta Capo Null
            ROWcomplemento._19_DetalleAux_Folio = LbFolio.Text
            ROWcomplemento._20_DetalleAux_Serie = "C"

            Me.ProductionDS.CFDI_ComplementoPago.Rows.Add(ROWcomplemento)
            Me.CFDI_ComplementoPagoTableAdapter.Update(Me.ProductionDS.CFDI_ComplementoPago)
            Folios.UpdateC(Folio)
            MsgBox("Se guardaron Datos de Factura en BD")

            'Credito = NCredito.InsertaNotaCredito("DR", "TipoRelacion", "01", txbFolioFiscal, "", "", "", "", "", "", "", "", "", "", "", "", "", "", LbFolio.Text, "C")

        ElseIf CmbSerie.Text = "SA" Then
            Folio = Folios.SerieSA
            Folios.UpdateSA(Folio)
        End If
        For Each r As FinagilDS1.FacturasExternasRow In Me.FinagilDS1.FacturasExternas.Rows
            'For Each r As ProductionDS.FacturasExternasRow In Me.FinagilDS1.FacturasExternas.Rows
            r.Factura = Folio

            r.UsoCFDI = txtUsoClave.Text
            If cmbPago.Text = "PPD" Then
                'MsgBox("Fijar Clave Forma de pago 99, Por Definir")
                'CmbMetodo.Text = "99 Por Definir"
                r.MetodoPago = "99"
            Else
                r.MetodoPago = UCase(CmbMetodo.SelectedValue)
            End If

            'r.MetodoPago = UCase(CmbMetodo.SelectedValue)

        Next
        Me.FinagilDS1.FacturasExternas.GetChanges()
        'Me.ProductionDS.FacturasExternas.GetChanges()
        Me.FacturasExternasTableAdapter.Update(Me.FinagilDS1.FacturasExternas)
        Me.FinagilDS1.FacturasExternas.Clear()
        Btcancelar_Click(Nothing, Nothing)
    End Sub

    Private Sub TxtCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub



    Function ValidaRFC(ByVal rfc As String, ByVal tipo As String)
        If IsNumeric(Mid(rfc, 4, 1)) Then
            tipo = "M"
        End If
        If tipo = "F" Or tipo = "E" Then
            If rfc.Length < 13 Then
                rfc = "XAXX010101000"
            Else
                If Microsoft.VisualBasic.Right(rfc, 3) = "000" Then
                    rfc = "XAXX010101000"
                End If
            End If
        End If
        Return rfc
    End Function

    Public Function Letras(ByVal numero As String, ByVal moneda As String) As String

        'Declaración de variables de datos
        Dim NumAux As Double = numero
        numero = NumAux.ToString("f2")
        Dim entero As String
        Dim cMillones As String
        Dim cMiles As String
        Dim cCentenas As String
        Dim cCant_Cent As String = ""
        Dim cCant_Mil As String = ""
        Dim cCant_Mill As String = ""
        Dim dec As String
        Dim cCant As String
        Dim flag2 As String = "N"
        Dim x As Integer

        'Dividir parte entera y decimal

        For x = 1 To Len(numero)
            If Mid(numero, x, 1) = "." Then
                flag2 = "S"
            Else
                If flag2 = "N" Then
                    entero = entero + Mid(numero, x, 1)
                Else
                    dec = dec + Mid(numero, x, 1)
                End If
            End If
        Next x

        If Len(dec) = 1 Then dec = dec & "0"

        If Len(entero) > 6 Then
            cCentenas = Mid(entero, (Len(entero) + 1) - 3, 3)
            cMiles = Mid(entero, (Len(entero) + 1) - 6, 3)
            cMillones = Mid(entero, 1, Len(entero) - 6)
        ElseIf Len(entero) <= 6 And Len(entero) > 3 Then
            cCentenas = Mid(entero, (Len(entero) + 1) - 3, 3)
            cMiles = Mid(entero, 1, Len(entero) - 3)
        ElseIf Len(entero) <= 3 Then
            cCentenas = Mid(entero, 1, Len(entero))
        End If

        'proceso de conversión

        cCant_Cent = Cambio(cCentenas)
        cCant_Mil = Cambio(cMiles)
        cCant_Mill = Cambio(cMillones)

        'Asigna la palabra millón

        If Trim(cCant_Mill) <> "" And Trim(cCant_Mill) <> "CERO" Then
            If Trim(cCant_Mill) = "UN" Then
                cCant = cCant_Mill & "MILLON "
            Else
                cCant = cCant_Mill & " MILLONES "
            End If
        End If

        'Asigna la palabra mil

        If Trim(cCant_Mil) <> "" And Trim(cCant_Mil) <> "CERO" Then
            If Trim(cCant_Mil) = "UN" And Trim(cCant) <> "" Then
                cCant = cCant & " MIL "
            ElseIf Trim(cCant_Mil) = "UN" And Trim(cCant) = "" Then
                cCant = "MIL "
            Else
                cCant = cCant & cCant_Mil & "MIL "
            End If
        End If

        'Asigna la palabra correspondiente a als unidades

        If Trim(cCant) <> "" And Trim(cCant_Cent) <> "CERO" Then
            cCant = cCant & cCant_Cent
        ElseIf Trim(cCant) = "" And Trim(cCant_Cent) <> "CERO" Then
            cCant = cCant_Cent
        ElseIf Trim(cCant) = "" And Trim(cCant_Cent) = "CERO" Then
            cCant = cCant_Cent
        End If

        'Se une la parte entera y la parte decimal
        If moneda <> "USD" Then
            If dec <> "" Then
                If Trim(cCant_Mill) <> "" And Trim(cCant_Mil) = "" Or Trim(cCant_Mil) = "CERO" Then
                    Letras = "(" & cCant & "DE PESOS " & dec & "/100 M.N.)"
                Else
                    Letras = "(" & cCant & "PESOS " & dec & "/100 M.N.)"
                End If
            Else
                If Trim(cCant_Mill) <> "" And Trim(cCant_Mil) = "" Or Trim(cCant_Mil) = "CERO" Then
                    Letras = "(" & cCant & "DE PESOS 00/100 M.N.)"
                Else
                    Letras = "(" & cCant & "PESOS 00/100 M.N.)"
                End If
            End If
        ElseIf moneda = "USD" Then
            If dec <> "" Then
                If Trim(cCant_Mill) <> "" And Trim(cCant_Mil) = "" Or Trim(cCant_Mil) = "CERO" Then
                    Letras = "(" & cCant & "DE DOLAES " & dec & "/100 " & moneda & ")"
                Else
                    Letras = "(" & cCant & "DOLARES " & dec & "/100 " & moneda & ")"
                End If
            Else
                If Trim(cCant_Mill) <> "" And Trim(cCant_Mil) = "" Or Trim(cCant_Mil) = "CERO" Then
                    Letras = "(" & cCant & "DE DOLARES 00/100 " & moneda & ")"
                Else
                    Letras = "(" & cCant & "DOLARES 00/100 " & moneda & ")"
                End If
            End If
        End If
    End Function

    Function Cambio(ByVal Cantidad As String) As String

        Dim y As Integer
        Dim num As Integer
        Dim flag As String = "N"
        Dim palabras As String = ""

        For y = Len(Cantidad) To 1 Step -1

            num = Len(Cantidad) - (y - 1)

            Select Case y

                Case 3

                    'Asigna las palabras para las centenas

                    Select Case Mid(Cantidad, num, 1)
                        Case "1"
                            If Mid(Cantidad, num + 1, 1) = "0" And Mid(Cantidad, num + 2, 1) = "0" Then
                                palabras = palabras & "CIEN "
                            Else
                                palabras = palabras & "CIENTO "
                            End If
                        Case "2"
                            palabras = palabras & "DOSCIENTOS "
                        Case "3"
                            palabras = palabras & "TRESCIENTOS "
                        Case "4"
                            palabras = palabras & "CUATROCIENTOS "
                        Case "5"
                            palabras = palabras & "QUINIENTOS "
                        Case "6"
                            palabras = palabras & "SEISCIENTOS "
                        Case "7"
                            palabras = palabras & "SETECIENTOS "
                        Case "8"
                            palabras = palabras & "OCHOCIENTOS "
                        Case "9"
                            palabras = palabras & "NOVECIENTOS "
                    End Select
                Case 2

                    'Asigna las palabras para las decenas 

                    Select Case Mid(Cantidad, num, 1)

                        Case "0"
                            flag = "N"
                        Case "1"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                flag = "S"
                                palabras = palabras & "DIEZ "
                            End If
                            If Mid(Cantidad, num + 1, 1) = "1" Then
                                flag = "S"
                                palabras = palabras & "ONCE "
                            End If
                            If Mid(Cantidad, num + 1, 1) = "2" Then
                                flag = "S"
                                palabras = palabras & "DOCE "
                            End If
                            If Mid(Cantidad, num + 1, 1) = "3" Then
                                flag = "S"
                                palabras = palabras & "TRECE "
                            End If
                            If Mid(Cantidad, num + 1, 1) = "4" Then
                                flag = "S"
                                palabras = palabras & "CATORCE "
                            End If
                            If Mid(Cantidad, num + 1, 1) = "5" Then
                                flag = "S"
                                palabras = palabras & "QUINCE "
                            End If
                            If Mid(Cantidad, num + 1, 1) > "5" Then
                                flag = "N"
                                palabras = palabras & "DIECI"
                            End If
                        Case "2"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "VEINTE "
                                flag = "S"
                            Else
                                palabras = palabras & "VEINTI"
                                flag = "N"
                            End If
                        Case "3"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "TREINTA "
                                flag = "S"
                            Else
                                palabras = palabras & "TREINTA Y "
                                flag = "N"
                            End If
                        Case "4"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "CUARENTA "
                                flag = "S"
                            Else
                                palabras = palabras & "CUARENTA Y "
                                flag = "N"
                            End If
                        Case "5"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "CINCUENTA "
                                flag = "S"
                            Else
                                palabras = palabras & "CINCUENTA Y "
                                flag = "N"
                            End If
                        Case "6"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "SESENTA "
                                flag = "S"
                            Else
                                palabras = palabras & "SESENTA Y "
                                flag = "N"
                            End If
                        Case "7"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "SETENTA "
                                flag = "S"
                            Else
                                palabras = palabras & "SETENTA Y "
                                flag = "N"
                            End If
                        Case "8"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "OCHENTA "
                                flag = "S"
                            Else
                                palabras = palabras & "OCHENTA Y "
                                flag = "N"
                            End If
                        Case "9"
                            If Mid(Cantidad, num + 1, 1) = "0" Then
                                palabras = palabras & "NOVENTA "
                                flag = "S"
                            Else
                                palabras = palabras & "NOVENTA Y "
                                flag = "N"
                            End If
                    End Select
                Case 1

                    'Asigna las palabras para las unidades

                    Select Case Mid(Cantidad, num, 1)
                        Case "1"
                            If flag = "N" Then
                                If y = 1 Then
                                    palabras = palabras & "UN "
                                Else
                                    palabras = palabras & "UN "
                                End If
                            End If
                        Case "2"
                            If flag = "N" Then palabras = palabras & "DOS "
                        Case "3"
                            If flag = "N" Then palabras = palabras & "TRES "
                        Case "4"
                            If flag = "N" Then palabras = palabras & "CUATRO "
                        Case "5"
                            If flag = "N" Then palabras = palabras & "CINCO "
                        Case "6"
                            If flag = "N" Then palabras = palabras & "SEIS "
                        Case "7"
                            If flag = "N" Then palabras = palabras & "SIETE "
                        Case "8"
                            If flag = "N" Then palabras = palabras & "OCHO "
                        Case "9"
                            If flag = "N" Then palabras = palabras & "NUEVE "
                        Case "0"
                            If Trim(palabras) = "" Then
                                If flag = "N" Then palabras = palabras & "CERO "
                            End If
                    End Select
            End Select

        Next y
        Cambio = palabras

    End Function

    Private Sub cmbPago_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPago.LostFocus
        ' MD 19Dic GroupDET.Enabled = True
    End Sub

    Private Sub cmbPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPago.SelectedIndexChanged

        If cmbPago.Text = "PPD" Then
            lblFormapago.Text = "99, Por Definir"
            lblFormapago.Visible = True
            'CmbMetodo.Text = "99 Por Definir"
            CmbMetodo.Visible = False
        Else
            CmbMetodo.Visible = True
        End If
        cmbUsoCfdi.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridFactura.Rows.Count <= 0 Then
            MessageBox.Show("Factura sin Lineas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim Folios As New FinagilDS1TableAdapters.FoliosTableAdapter
        Dim Folio As Double = 0
        If CmbSerie.Text = "B" Then
            Folio = Folios.SerieB
            Folios.UpdateB(Folio)
        ElseIf CmbSerie.Text = "DV" Then
            Folio = Folios.SerieDV
            Folios.UpdateDV(Folio)
        ElseIf CmbSerie.Text = "C" Then
            Folio = Folios.SerieC
            Folios.UpdateC(Folio)
        End If
        For Each r As FinagilDS1.FacturasExternasRow In Me.FinagilDS1.FacturasExternas.Rows
            r.Factura = Folio
            If cmbPago.Text = "PPD" Then
                MsgBox("Fijar Clave Forma de pago 99, Por Definir")
                'CmbMetodo.Text = "99 Por Definir"
                r.MetodoPago = "99"
            Else
                r.MetodoPago = UCase(CmbMetodo.SelectedValue)
            End If
        Next
        Me.FinagilDS1.FacturasExternas.GetChanges()
        Me.FacturasExternasTableAdapter.Update(Me.FinagilDS1.FacturasExternas)
        'Me.FinagilDS1.FacturasExternas.Clear()
        'Btcancelar_Click(Nothing, Nothing)

    End Sub

    Private Sub cmbUsoCfdi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUsoCfdi.SelectedIndexChanged
        GroupDET.Enabled = True
        GroupFactura.Enabled = False

    End Sub

    Private Sub TxtFolioCFDI_LostFocus(sender As Object, e As EventArgs) Handles TxtFolioCFDI.LostFocus
        If Not IsNumeric(TxtFolioCFDI.Text) Then
            TxtFolioCFDI.Text = 0
        End If
        Me.CfdI_EncabezadoTableAdapter.FillByFactura(ProductionDS.CFDI_Encabezado, TxtFolioCFDI.Text, TxtSerieCFDI.Text)
    End Sub
End Class


