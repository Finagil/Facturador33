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
            Me.DescrTextBox.Visible = False
            Me.CalleTextBox.Visible = False
            Me.ColoniaTextBox.Visible = False
            Me.DelegacionTextBox.Visible = False
            Me.EstadoTextBox.Visible = False
            Me.CoposTextBox.Visible = False
            Me.RFCTextBox.Visible = False
            Me.EMail1TextBox.Visible = False
            Me.EMail2TextBox.Visible = False
        Else
            GroupTerceros.Enabled = False
            GroupFinagil.Enabled = True
            Me.DescrTextBox.Visible = True
            Me.CalleTextBox.Visible = True
            Me.ColoniaTextBox.Visible = True
            Me.DelegacionTextBox.Visible = True
            Me.EstadoTextBox.Visible = True
            Me.CoposTextBox.Visible = True
            Me.RFCTextBox.Visible = True
            Me.EMail1TextBox.Visible = True
            Me.EMail2TextBox.Visible = True
        End If
        TxtRSocial.Text = ""
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
        dtpFechaArfin.MinDate = Date.Now.AddDays(-3)
        dtpFechaArfin.MaxDate = Date.Now
        'TODO: esta línea de código carga datos en la tabla 'ProductionDS.CFDI_Impuestos_Adicionales' Puede moverla o quitarla según sea necesario.
        Me.CFDI_Impuestos_AdicionalesTableAdapter.Fill(Me.ProductionDS.CFDI_Impuestos_Adicionales)
        'TODO: esta línea de código carga datos en la tabla 'FinagilDS1.Clientes_ARFIN' Puede moverla o quitarla según sea necesario.
        'Me.Clientes_ARFINTableAdapter.Fill(Me.FinagilDS1.Clientes_ARFIN)
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
        CkDoctoRel.Checked = False
        chkFormato.Checked = False
        Me.FinagilDS1.FacturasExternas.Clear()
    End Sub

    Private Sub BTAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAgregar.Click
        If Trim(txbFolioFiscal.Text).Length <> 36 And (CmbSerie.Text = "CA" Or CmbSerie.Text = "C" Or CkDoctoRel.Checked = True) Then
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
        If RDFinagil.Checked = True And (CmbSerie.Text = "SA" Or CmbSerie.Text = "CA") Then
            MessageBox.Show("Error de Serie, solo para Arfin", "Errorde Serie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CmbSerie.Select()
            CmbSerie.SelectedIndex = -1
            Exit Sub
        End If
        If RDFinagil.Checked = False And (CmbSerie.Text <> "SA" And CmbSerie.Text <> "CA") Then
            MessageBox.Show("Error de Serie, Arfin solo puede usar serie SA", "Errorde Serie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CmbSerie.Select()
            CmbSerie.SelectedIndex = -1
            Exit Sub
        End If

        GroupFactura.Enabled = False
        Dim TasaIva As Decimal = 0
        Dim IVAaux As Decimal = 0
        Select Case UCase(cmbIva.Text)
            Case "16 %", "8 %"
                TasaIva = CDec(Mid(cmbIva.Text, 1, 2)) / 100
                If CmbSerie.Text = "C" Or CmbSerie.Text = "CA" Then
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
        r.RetencionBase = 0
        r.RetencionMonto = 0
        r.RetencionTasa = ""

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

        r.Moneda = cmbMoneda.Text
        If cmbMoneda.Text = "" And (CmbSerie.Text = "SA") Then
            MessageBox.Show("Falta seleccionar una moneda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbMoneda.Focus()
        End If
        r.TasaIva = cmbIva.Text
        r.Facturado = False
        If RBFinagil.Checked = False Then
            r.Nombre = UCase(TxtRSocial.Text)
            r.Calle = UCase(Txtcalle.Text)
            r.Colonia = UCase(Txtcol.Text)
            r.Municipio = UCase(Txtmunici.Text)
            r.Estado = UCase(TxtEdo.Text)
            r.CP = UCase(TxtCP.Text)
            r.RFC = UCase(TxtRFC.Text)
            r.Mail1 = TxtMail1.Text
            r.Mail2 = TxtMail2.Text
            r.fecha = dtpFechaArfin.Value.ToShortDateString
        Else
            r.fecha = FECHA_APLICACION
            r.Nombre = UCase(DescrTextBox.Text)
            r.Calle = UCase(CalleTextBox.Text)
            r.Colonia = UCase(ColoniaTextBox.Text)
            r.Municipio = UCase(DelegacionTextBox.Text)
            r.Estado = UCase(EstadoTextBox.Text)
            r.CP = UCase(CoposTextBox.Text)
            r.RFC = UCase(RFCTextBox.Text)
            r.Mail1 = EMail1TextBox.Text
            r.Mail2 = EMail2TextBox.Text
            FECHA_APLICACION = Me.FinagilDS1.FechasAplicacion.Rows(0).ItemArray(0)
        End If
        r.Unidad = TxtUnidad.Text
        r.UnidadInterna = txtUnidadInterna.Text
        r.MetodoPagoSAT = cmbPago.Text
        r.CodigoART = CmbConcepto.SelectedValue
        r.UsoCFDI = txtUsoClave.Text 'cmbUsoCfdi.SelectedValue
        r.Finagil = RDFinagil.Checked

        If chkRetenciones.Checked = True Then
            Select Case cmbImpuesto_Ret.Text
                Case "ISR", "IEPS"
                    'Dim taRet As New ProductionDSTableAdapters.CFDI_Impuestos_AdicionalesTableAdapter
                    'taRet.InsertQuery(CmbSerie.Text, CInt(LbFolio.Text), "Impuesto", "RE", txtBase.Text, CDec(txtMonto.Text), cmbImpuesto_Ret.Text.Replace("ISR", "001").Replace("IVA", "002").Replace("IEPS", "003"), cmbTFactor.Text, cmbTOC.Text, "", "", "")
                    'Dim ret As FinagilDS1.FacturasExternasRow
                    Dim ret As ProductionDS.CFDI_Impuestos_AdicionalesRow
                    ret = Me.ProductionDS.CFDI_Impuestos_Adicionales.NewRow
                    ret._27_Serie_Comprobante = CmbSerie.Text
                    ret._1_Folio = CInt(LbFolio.Text)
                    ret._1_Impuesto_TipoImpuesto = "Impuesto"
                    ret._2_Impuesto_Descripcion = "RE"
                    ret._3_Impuesto_Monto_base = txtBase.Text
                    ret._4_Impuesto_Monto_Impuesto = CDec(txtMonto.Text)
                    ret._5_Impuesto_Clave = cmbImpuesto_Ret.Text.Replace("ISR", "001").Replace("IVA", "002").Replace("IEPS", "003")
                    ret._6_Impuesto_Tasa = cmbTFactor.Text
                    ret._7_Impuesto_Porcentaje = cmbTOC.Text
                    ret.Spei_Certificado = ""
                    ret.Spei_Cadena = ""
                    ret.Spei_Sello = ""
                    ret.linea = Consec
                    Me.ProductionDS.CFDI_Impuestos_Adicionales.AddCFDI_Impuestos_AdicionalesRow(ret)
                Case "IVA"
                    r.RetencionBase = CDec(txtBase.Text)
                    r.RetencionMonto = CDec(txtMonto.Text)
                    r.RetencionTasa = cmbTOC.Text
            End Select
        End If

        Me.FinagilDS1.FacturasExternas.AddFacturasExternasRow(r)
        cmbIva.SelectedIndex = 1
        TxtCantidad.Clear()
        TxtPrecio.Clear()
        TotalGrid()
        TxtDesc.Text = ""

        txtBase.Text = ""
        cmbImpuesto_Ret.Text = "IVA"
        Select Case UCase(cmbIva.Text)
            Case "16 %"
                cmbTOC.Text = "0.160000"
            Case "8 %"
                cmbTOC.Text = "0.080000"
        End Select
        cmbTFactor.Text = "Tasa"
        txtMonto.Text = ""



    End Sub

    Private Sub CmbSerie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSerie.SelectedIndexChanged
        Dim Bandera As Boolean = False
        If CmbSerie.SelectedIndex <> -1 Then
            If RBFinagil.Checked = True Then

                If DescrTextBox.Text = "" And RBFinagil.Checked = True Then
                    MessageBox.Show("Falta seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DescrTextBox.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If DescrTextBox.Text = "" And RBTerceros.Checked = True Then
                    MessageBox.Show("Falta el nombre o razon social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DescrTextBox.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If CalleTextBox.Text = "" And RBTerceros.Checked = True Then
                    MessageBox.Show("Falta la calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CalleTextBox.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If ColoniaTextBox.Text = "" And RBTerceros.Checked = True Then
                    MessageBox.Show("Falta la colonia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ColoniaTextBox.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If DelegacionTextBox.Text = "" And RBTerceros.Checked = True Then
                    MessageBox.Show("Falta el municipio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DelegacionTextBox.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If EstadoTextBox.Text = "" And RBTerceros.Checked = True Then
                    MessageBox.Show("Falta el Estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    EstadoTextBox.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If (CoposTextBox.Text = "" Or Not IsNumeric(CoposTextBox.Text)) And RBTerceros.Checked = True Then
                    MessageBox.Show("Error en codigo postal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CoposTextBox.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If (RFCTextBox.Text = "" Or (RFCTextBox.Text.Length <> 10 And TxtRFC.Text.Length <> 12 And TxtRFC.Text.Length <> 13)) And RBTerceros.Checked = True Then
                    MessageBox.Show("Error en RFC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    RFCTextBox.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If EMail1TextBox.Text.Trim.Length > 0 And InStr(EMail1TextBox.Text, "@") = 0 And RBTerceros.Checked = True Then
                    MessageBox.Show("Error en correo electronico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    EMail1TextBox.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If EMail2TextBox.Text.Trim.Length > 0 And InStr(EMail2TextBox.Text, "@") = 0 And RBTerceros.Checked = True Then
                    MessageBox.Show("Error en correo electronico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    EMail2TextBox.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If RDFinagil.Checked = True And (CmbSerie.Text = "SA" Or CmbSerie.Text = "CA") Then
                    MessageBox.Show("Error de Serie, solo para Arfin", "Errorde Serie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CmbSerie.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If RDFinagil.Checked = False And (CmbSerie.Text <> "SA" And CmbSerie.Text <> "CA") Then
                    MessageBox.Show("Error de Serie, Arfin solo puede usar serie SA", "Errorde Serie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CmbSerie.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If

                GroupFactura.Enabled = True
                GroupClientes.Enabled = False
                GroupFinagil.Enabled = False
                GroupTerceros.Enabled = False
                cmbMoneda.Enabled = True
                CmbSerie.Enabled = False
                Dim Folios As New FinagilDS1TableAdapters.FoliosTableAdapter

                If CkDoctoRel.Checked = True Then
                    Bandera = True
                End If

                If CmbSerie.Text = "B" Then
                    LbFolio.Text = Folios.SerieB
                ElseIf CmbSerie.Text = "DV" Then
                    LbFolio.Text = Folios.SerieDV
                ElseIf CmbSerie.Text = "C" Then
                    LbFolio.Text = Folios.SerieC
                    Bandera = True
                    CkDoctoRel.Checked = True
                    cmbUsoCfdi.Enabled = True
                    cmbUsoCfdi.Text = "Devoluciones, descuentos o bonificaciones"
                ElseIf CmbSerie.Text = "CA" Then
                    LbFolio.Text = Folios.SerieC
                    Bandera = True
                    CkDoctoRel.Checked = True
                    cmbUsoCfdi.Enabled = True
                    cmbUsoCfdi.Text = "Devoluciones, descuentos o bonificaciones"
                ElseIf CmbSerie.Text = "SA" Then
                    LbFolio.Text = Folios.SerieSA
                ElseIf CmbSerie.Text = "F" Then
                    Dim folioF As String
                    folioF = InputBox("Ingrese folio consecutivo: ", "Control del folios", " ")
                    If IsNumeric(folioF) Then
                        LbFolio.Text = folioF
                        Exit Sub
                    ElseIf folioF = "" Or Not IsNumeric(folioF) Then
                        MessageBox.Show("El valor debe de ser numerico...")
                        CmbSerie.Enabled = True
                        Exit Sub
                    End If
                End If

                txbFolioFiscal.Visible = Bandera
                TxtSerieCFDI.Visible = Bandera
                TxtFolioCFDI.Visible = Bandera
                lblFolioFiscal.Visible = Bandera
                LbSerie.Visible = Bandera
                LbFolioCFDI.Visible = Bandera
                LbCli.Visible = Bandera
                TxtImporteFact.Visible = Bandera
                _29_FormaPagoTextBox.Visible = Bandera
                lklAgregarUuid.Visible = Bandera
                lklVerUuid.Visible = Bandera
            Else
                If TxtRSocial.Text = "" And RBFinagil.Checked = True Then
                    MessageBox.Show("Falta seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxtRSocial.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If TxtRSocial.Text = "" And RBTerceros.Checked = True Then
                    MessageBox.Show("Falta el nombre o razon social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxtRSocial.Select()
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
                If TxtMail2.Text.Trim.Length > 0 And InStr(TxtMail2.Text, "@") = 0 And RBTerceros.Checked = True Then
                    MessageBox.Show("Error en correo electronico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxtMail2.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If RDFinagil.Checked = True And (CmbSerie.Text = "SA" Or CmbSerie.Text = "CA") Then
                    MessageBox.Show("Error de Serie, solo para Arfin", "Errorde Serie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CmbSerie.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If
                If RDFinagil.Checked = False And (CmbSerie.Text <> "SA" And CmbSerie.Text <> "CA") Then
                    MessageBox.Show("Error de Serie, Arfin solo puede usar serie SA", "Errorde Serie", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CmbSerie.Select()
                    CmbSerie.SelectedIndex = -1
                    Exit Sub
                End If

                GroupFactura.Enabled = True
                GroupClientes.Enabled = False
                GroupFinagil.Enabled = False
                GroupTerceros.Enabled = False
                cmbMoneda.Enabled = True
                CmbSerie.Enabled = False
                Dim Folios As New FinagilDS1TableAdapters.FoliosTableAdapter

                If CkDoctoRel.Checked = True Then
                    Bandera = True
                End If

                If CmbSerie.Text = "B" Then
                    LbFolio.Text = Folios.SerieB
                ElseIf CmbSerie.Text = "DV" Then
                    LbFolio.Text = Folios.SerieDV
                ElseIf CmbSerie.Text = "C" Then
                    LbFolio.Text = Folios.SerieC
                    Bandera = True
                    CkDoctoRel.Checked = True
                    cmbUsoCfdi.Enabled = True
                    cmbUsoCfdi.Text = "Devoluciones, descuentos o bonificaciones"
                ElseIf CmbSerie.Text = "CA" Then
                    LbFolio.Text = Folios.SerieC
                    Bandera = True
                    CkDoctoRel.Checked = True
                    cmbUsoCfdi.Enabled = True
                    cmbUsoCfdi.Text = "Devoluciones, descuentos o bonificaciones"
                    cmbUsoCfdi.Enabled = False
                ElseIf CmbSerie.Text = "SA" Then
                    LbFolio.Text = Folios.SerieSA
                ElseIf CmbSerie.Text = "F" Then
                    Dim folioF As String
                    folioF = InputBox("Ingrese folio consecutivo: ", "Control del folios", " ")
                    If IsNumeric(folioF) Then
                        LbFolio.Text = folioF
                        Exit Sub
                    ElseIf folioF = "" Or Not IsNumeric(folioF) Then
                        MessageBox.Show("El valor debe de ser numerico...")
                        CmbSerie.Enabled = True
                        Exit Sub
                    End If
                End If

                txbFolioFiscal.Visible = Bandera
                TxtSerieCFDI.Visible = Bandera
                TxtFolioCFDI.Visible = Bandera
                lblFolioFiscal.Visible = Bandera
                LbSerie.Visible = Bandera
                LbFolioCFDI.Visible = Bandera
                LbCli.Visible = Bandera
                TxtImporteFact.Visible = Bandera
                _29_FormaPagoTextBox.Visible = Bandera
                chkFormato.Visible = Bandera
                lklAgregarUuid.Visible = Bandera
                lklVerUuid.Visible = Bandera
            End If

        End If
    End Sub

    Private Sub cmbMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMoneda.SelectedIndexChanged
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
        Dim RETE As Double
        Dim TT As Double
        For Each rr As DataGridViewRow In GridFactura.Rows
            ST += rr.Cells("ImporteDataGridViewTextBoxColumn").Value
            IVA += rr.Cells("IvaDataGridViewTextBoxColumn").Value
            rr.Cells("ColumnTotalX").Value = rr.Cells("ImporteDataGridViewTextBoxColumn").Value + rr.Cells("IvaDataGridViewTextBoxColumn").Value - rr.Cells("RetencionMonto").Value
            TT += rr.Cells("ColumnTotalX").Value
            RETE += rr.Cells("RetencionMonto").Value
        Next
        txtSubtotal.Text = ST.ToString("N2")
        TxtIva.Text = IVA.ToString("N2")
        TxtRetencion.Text = RETE.ToString("N2")
        TxtTotal.Text = Val(TT).ToString("N2")
    End Sub

    Private Sub GridFactura_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles GridFactura.RowsRemoved
        TotalGrid()
    End Sub

    Private Sub BtFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFacturar.Click

        'Inserta Valores en Tabla de clientes FINAGIL
        'Dim rowArf As FinagilDS1.FacturasExternasRow
        If RBFinagil.Checked = False Then
            Dim rowArf As FinagilDS1.Clientes_ARFINRow
            rowArf = Me.FinagilDS1.Clientes_ARFIN.NewClientes_ARFINRow

            Try
                rowArf.RFC = TxtRFC.Text.ToUpper
                rowArf.nombre = TxtRSocial.Text.ToUpper
                rowArf.direccion = Txtcalle.Text
                rowArf.colonia = Txtcol.Text
                rowArf.municipio = Txtmunici.Text
                rowArf.estado = TxtEdo.Text
                rowArf.cp = TxtCP.Text
                rowArf.email1 = TxtMail1.Text
                rowArf.email2 = TxtMail2.Text


                Me.FinagilDS1.Clientes_ARFIN.Rows.Add(rowArf)
                Me.Clientes_ARFINTableAdapter.Update(Me.FinagilDS1.Clientes_ARFIN)
            Catch ex As Exception
                MsgBox("Cliente existente", MsgBoxStyle.Critical, "Error al insertar nuevo Cliente")
            End Try
        End If

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
        ElseIf CmbSerie.Text = "CA" Then
            Folio = Folios.SerieCA
            Folios.UpdateCA(Folio)
        ElseIf CmbSerie.Text = "SA" Then
            Folio = Folios.SerieSA
            Folios.UpdateSA(Folio)
        ElseIf CmbSerie.Text = "F" Then
            Folio = CDbl(LbFolio.Text)
        End If
        If CkDoctoRel.Checked = True Then
            If dgvUuidRelacionado.Rows.Count > 1 Then
                For Each rows As DataGridViewRow In dgvUuidRelacionado.Rows
                    Dim ROWcomplemento As ProductionDS.CFDI_ComplementoPagoRow
                    ROWcomplemento = ProductionDS.CFDI_ComplementoPago.NewCFDI_ComplementoPagoRow()
                    ROWcomplemento._1_DetalleAux_Tipo = "DR"
                    ROWcomplemento._2_DetalleAux_DescTipo = "TipoRelacion"
                    If CmbSerie.Text = "C" Or CmbSerie.Text = "CA" Then
                        ROWcomplemento._3_DetalleAux_Misc01 = "01"
                    Else
                        ROWcomplemento._3_DetalleAux_Misc01 = "04"
                    End If
                    ROWcomplemento._4_DetalleAux_Misc02 = rows.Cells.Item(2).Value 'txbFolioFiscal.Text
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
                    ROWcomplemento._20_DetalleAux_Serie = CmbSerie.Text
                    Me.ProductionDS.CFDI_ComplementoPago.Rows.Add(ROWcomplemento)
                    Me.CfdI_ComplementoPagoTableAdapter.Update(Me.ProductionDS.CFDI_ComplementoPago)
                Next
            Else
                Dim ROWcomplemento As ProductionDS.CFDI_ComplementoPagoRow
                ROWcomplemento = ProductionDS.CFDI_ComplementoPago.NewCFDI_ComplementoPagoRow()
                ROWcomplemento._1_DetalleAux_Tipo = "DR"
                ROWcomplemento._2_DetalleAux_DescTipo = "TipoRelacion"
                If CmbSerie.Text = "C" Or CmbSerie.Text = "CA" Then
                    ROWcomplemento._3_DetalleAux_Misc01 = "01"
                Else
                    ROWcomplemento._3_DetalleAux_Misc01 = "04"
                End If
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
                ROWcomplemento._20_DetalleAux_Serie = CmbSerie.Text
                Me.ProductionDS.CFDI_ComplementoPago.Rows.Add(ROWcomplemento)
                Me.CfdI_ComplementoPagoTableAdapter.Update(Me.ProductionDS.CFDI_ComplementoPago)
            End If

            'Dim ROWcomplemento As ProductionDS.CFDI_ComplementoPagoRow
            'ROWcomplemento = ProductionDS.CFDI_ComplementoPago.NewCFDI_ComplementoPagoRow()
            'ROWcomplemento._1_DetalleAux_Tipo = "DR"
            'ROWcomplemento._2_DetalleAux_DescTipo = "TipoRelacion"
            'If CmbSerie.Text = "C" Or CmbSerie.Text = "CA" Then
            '    ROWcomplemento._3_DetalleAux_Misc01 = "01"
            'Else
            '    ROWcomplemento._3_DetalleAux_Misc01 = "04"
            'End If
            'ROWcomplemento._4_DetalleAux_Misc02 = txbFolioFiscal.Text
            'ROWcomplemento._5_DetalleAux_Misc03 = ""
            'ROWcomplemento._6_DetalleAux_Misc04 = ""
            'ROWcomplemento._7_DetalleAux_Misc05 = ""
            'ROWcomplemento._8_DetalleAux_Misc06 = " "
            'ROWcomplemento._9_DetalleAux_Misc07 = ""
            'ROWcomplemento._10_DetalleAux_Misc08 = ""
            'ROWcomplemento._11_DetalleAux_Misc09 = ""
            'ROWcomplemento._12_DetalleAux_Misc10 = ""
            'ROWcomplemento._13_DetalleAux_Misc11 = ""
            'ROWcomplemento._15_DetalleAux_Misc13 = ""
            'ROWcomplemento._16_DetalleAux_Misc14 = ""
            'ROWcomplemento._17_DetalleAux_Misc15 = ""
            'ROWcomplemento._18_DetalleAux_Misc16 = ""   ' la tabla NO Acepta Capo Null
            'ROWcomplemento._19_DetalleAux_Folio = LbFolio.Text
            'ROWcomplemento._20_DetalleAux_Serie = CmbSerie.Text
            'Me.ProductionDS.CFDI_ComplementoPago.Rows.Add(ROWcomplemento)
            'Me.CfdI_ComplementoPagoTableAdapter.Update(Me.ProductionDS.CFDI_ComplementoPago)
        End If

        For Each r As FinagilDS1.FacturasExternasRow In Me.FinagilDS1.FacturasExternas.Rows
            r.Factura = Folio
            r.UsoCFDI = txtUsoClave.Text
            If cmbPago.Text = "PPD" Then
                r.MetodoPago = "99"
            Else
                r.MetodoPago = UCase(CmbMetodo.SelectedValue)
                'If CmbSerie.Text = "C" Or CmbSerie.Text = "CA" Then
                'r.MetodoPago = _29_FormaPagoTextBox.Text.Trim
                'CmbMetodo.Enabled = False
                'End If
            End If
            If RDArfin.Checked = True Then
                If chkFormato.Checked = True Then
                    r.FormatoImp = "[AFARF]"
                End If
            End If
            If RDFinagil.Checked = True Then
                If chkFormato.Checked Then
                    r.FormatoImp = "[AFIN]"
                End If
            End If
        Next

        Me.FinagilDS1.FacturasExternas.GetChanges()

        Try
            Me.FacturasExternasTableAdapter.Update(Me.FinagilDS1.FacturasExternas)
            Me.CFDI_Impuestos_AdicionalesTableAdapter.Update(Me.ProductionDS.CFDI_Impuestos_Adicionales)
        Catch
            MessageBox.Show("La serie y folio ya se encuentrán registrados...")
        End Try
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
        If CmbSerie.Text = "CA" Or CmbSerie.Text = "C" Then
            cmbUsoCfdi.Enabled = False
        Else
            cmbUsoCfdi.Enabled = True
        End If
        If cmbPago.Text = "PPD" And CmbSerie.Text <> "C" And CmbSerie.Text <> "CA" Then
            lblFormapago.Text = "99, Por Definir"
            lblFormapago.Visible = True
            CmbMetodo.Visible = False
        Else
            CmbMetodo.Visible = True
        End If

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
        ElseIf CmbSerie.Text = "CA" Then
            Folio = Folios.SerieCA
            Folios.UpdateCA(Folio)
        End If
        For Each r As FinagilDS1.FacturasExternasRow In Me.FinagilDS1.FacturasExternas.Rows
            r.Factura = Folio
            If cmbPago.Text = "PPD" And CmbSerie.Text <> "C" And CmbSerie.Text <> "CA" Then
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
        'GroupFactura.Enabled = False
        If RDArfin.Checked = True Then
            chkRetenciones.Enabled = True
        Else
            chkRetenciones.Checked = False
            chkRetenciones.Enabled = False
        End If
    End Sub

    Private Sub TxtFolioCFDI_LostFocus(sender As Object, e As EventArgs) Handles TxtFolioCFDI.LostFocus
        If Not IsNumeric(TxtFolioCFDI.Text) Then
            TxtFolioCFDI.Text = 0
        End If
        Me.CfdI_EncabezadoTableAdapter.FillByFactura(ProductionDS.CFDI_Encabezado, TxtFolioCFDI.Text, TxtSerieCFDI.Text)
    End Sub


    Private Sub lblFolioFiscal_DoubleClick(sender As Object, e As EventArgs) Handles lblFolioFiscal.DoubleClick
        txbFolioFiscal.ReadOnly = False
    End Sub


    Private Sub btnCreaClientes_Click(sender As Object, e As EventArgs) Handles btnCreaClientes.Click
        FrmClientes.Show()
    End Sub

    Private Sub TxtRS_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtRS.TextChanged
        If TxtRS.Text.Length >= 3 Then
            Me.Clientes_ARFINTableAdapter.FillBy(Me.FinagilDS1.Clientes_ARFIN, TxtRS.Text)
            If TxtRSocial.Text <> "" Then
                Me.TxtRSocial.Enabled = False
                Me.Txtcol.Enabled = False
                Me.Txtcalle.Enabled = False
                Me.Txtmunici.Enabled = False
                Me.TxtEdo.Enabled = False
                Me.TxtCP.Enabled = False
                Me.TxtRFC.Enabled = False
                Me.TxtMail1.Enabled = False
                Me.TxtMail2.Enabled = False
            Else
                Me.TxtRSocial.Enabled = True
                Me.Txtcol.Enabled = True
                Me.Txtcalle.Enabled = True
                Me.Txtmunici.Enabled = True
                Me.TxtEdo.Enabled = True
                Me.TxtCP.Enabled = True
                Me.TxtRFC.Enabled = True
                Me.TxtMail1.Enabled = True
                Me.TxtMail2.Enabled = True
                TxtRSocial.Text = TxtRS.Text
            End If
        End If
    End Sub

    Private Sub chkRetenciones_CheckedChanged(sender As Object, e As EventArgs) Handles chkRetenciones.CheckedChanged
        If chkRetenciones.Checked = True Then
            gpRetenciones.Enabled = True
            txtBase.Text = Math.Round((Val(TxtCantidad.Text) * Val(TxtPrecio.Text)), 2)
        Else
            gpRetenciones.Enabled = False
            txtBase.Text = ""
            cmbImpuesto_Ret.Text = "IVA"
            Select Case UCase(cmbIva.Text)
                Case "16 %"
                    cmbTOC.Text = "0.160000"
                Case "8 %"
                    cmbTOC.Text = "0.080000"
            End Select
            cmbTFactor.Text = "Tasa"
            txtMonto.Text = ""
        End If
    End Sub

    Private Sub GridFactura_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridFactura.CellContentClick

    End Sub

    Private Sub txtBase_TextChanged(sender As Object, e As EventArgs) Handles txtBase.TextChanged
        txtMonto.Text = Math.Round((Val(txtBase.Text) * Val(cmbTOC.Text)), 2)
    End Sub

    Private Sub TxtFolioCFDI_TextChanged(sender As Object, e As EventArgs) Handles TxtFolioCFDI.TextChanged

    End Sub

    Private Sub RDArfin_CheckedChanged(sender As Object, e As EventArgs) Handles RDArfin.CheckedChanged
        If RDArfin.Checked = True Then
            chkRetenciones.Enabled = True
            dtpFechaArfin.Enabled = True
            Me.Text = "Facturas Serie ""B"", ""DV"" y NC   Fecha de Aplicacion: " & dtpFechaArfin.Value.ToShortDateString & ""
            lblFechaAplica.Text = dtpFechaArfin.Value.ToShortDateString
        Else
            chkRetenciones.Checked = False
            chkRetenciones.Enabled = False
            dtpFechaArfin.Enabled = False
            Me.Text = "Facturas Serie ""B"", ""DV"" y NC   Fecha de Aplicacion: " & FECHA_APLICACION.ToShortDateString & ""
            lblFechaAplica.Text = FECHA_APLICACION.ToShortDateString
        End If

    End Sub

    Private Sub cmbTOC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTOC.SelectedIndexChanged
        txtMonto.Text = Math.Round((Val(txtBase.Text) * Val(cmbTOC.Text)), 2)
    End Sub

    Private Sub cmbTFactor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTFactor.SelectedIndexChanged
        txtMonto.Text = Math.Round((Val(txtBase.Text) * Val(cmbTOC.Text)), 2)
    End Sub

    Private Sub cmbTOC_TextChanged(sender As Object, e As EventArgs) Handles cmbTOC.TextChanged
        txtMonto.Text = Math.Round((Val(txtBase.Text) * Val(cmbTOC.Text)), 2)
    End Sub

    Private Sub lklAgregarUuid_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklAgregarUuid.LinkClicked
        dgvUuidRelacionado.Rows.Add(TxtSerieCFDI.Text.Trim.ToUpper, TxtFolioCFDI.Text.Trim, txbFolioFiscal.Text.Trim, "Eliminar")
        dgvUuidRelacionado.Visible = True
    End Sub

    Private Sub lklVerUuid_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklVerUuid.LinkClicked
        dgvUuidRelacionado.Visible = True
    End Sub

    Private Sub FrmFacturas_Click(sender As Object, e As EventArgs) Handles Me.Click
        dgvUuidRelacionado.Visible = False
    End Sub

    Private Sub dgvUuidRelacionado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUuidRelacionado.CellContentClick
        If e.ColumnIndex = 3 And dgvUuidRelacionado.Item("Eliminar", e.RowIndex).Value = "Eliminar" Then
            dgvUuidRelacionado.Rows.Remove(dgvUuidRelacionado.CurrentRow)
        End If
    End Sub
End Class


