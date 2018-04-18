<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupClientes = New System.Windows.Forms.GroupBox()
        Me.RBTerceros = New System.Windows.Forms.RadioButton()
        Me.RBFinagil = New System.Windows.Forms.RadioButton()
        Me.GroupFinagil = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListClientes = New System.Windows.Forms.ListBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinagilDS1 = New Facturador33.FinagilDS1()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupTerceros = New System.Windows.Forms.GroupBox()
        Me.EMail2TextBox = New System.Windows.Forms.TextBox()
        Me.EMail1TextBox = New System.Windows.Forms.TextBox()
        Me.RFCTextBox = New System.Windows.Forms.TextBox()
        Me.CoposTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.DelegacionTextBox = New System.Windows.Forms.TextBox()
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox()
        Me.CalleTextBox = New System.Windows.Forms.TextBox()
        Me.DescrTextBox = New System.Windows.Forms.TextBox()
        Me.TxtRSocial = New System.Windows.Forms.TextBox()
        Me.Clientes_ARFINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtMail2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtMail1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtRFC = New System.Windows.Forms.TextBox()
        Me.TxtCP = New System.Windows.Forms.TextBox()
        Me.TxtEdo = New System.Windows.Forms.TextBox()
        Me.Txtmunici = New System.Windows.Forms.TextBox()
        Me.Txtcol = New System.Windows.Forms.TextBox()
        Me.Txtcalle = New System.Windows.Forms.TextBox()
        Me.TxtRS = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupDET = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtUnidadInterna = New System.Windows.Forms.TextBox()
        Me.CodigosSATConceptoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTipoCambio = New System.Windows.Forms.Label()
        Me.CmbConcepto = New System.Windows.Forms.ComboBox()
        Me.TxtUnidad = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.BTAgregar = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.cmbIva = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupFactura = New System.Windows.Forms.GroupBox()
        Me.txtUsoClave = New System.Windows.Forms.TextBox()
        Me.CFDI_UsosCFDIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDS = New Facturador33.ProductionDS()
        Me.cmbUsoCfdi = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbPago = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LbFolio = New System.Windows.Forms.Label()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbSerie = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMoral = New System.Windows.Forms.TextBox()
        Me.Btcancelar = New System.Windows.Forms.Button()
        Me.GridFactura = New System.Windows.Forms.DataGridView()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadInterna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaIvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MunicipioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mail1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mail2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTotalX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetodoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasExternasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.TxtIva = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BtFacturar = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CmbMetodo = New System.Windows.Forms.ComboBox()
        Me.MetodoPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblFechaAplica = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblFormapago = New System.Windows.Forms.Label()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CFDI_UsosCFDITableAdapter = New Facturador33.ProductionDSTableAdapters.CFDI_UsosCFDITableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RDArfin = New System.Windows.Forms.RadioButton()
        Me.RDFinagil = New System.Windows.Forms.RadioButton()
        Me.ClientesTableAdapter = New Facturador33.FinagilDS1TableAdapters.ClientesTableAdapter()
        Me.FacturasExternasTableAdapter = New Facturador33.FinagilDS1TableAdapters.FacturasExternasTableAdapter()
        Me.FechasAplicacionTableAdapter = New Facturador33.FinagilDS1TableAdapters.FechasAplicacionTableAdapter()
        Me.MetodoPagoTableAdapter = New Facturador33.FinagilDS1TableAdapters.MetodopagoTableAdapter()
        Me.CodigosSAT_ConceptoTableAdapter = New Facturador33.FinagilDS1TableAdapters.CodigosSAT_ConceptoTableAdapter()
        Me.txbFolioFiscal = New System.Windows.Forms.TextBox()
        Me.CFDIEncabezadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblFolioFiscal = New System.Windows.Forms.Label()
        Me.CfdI_ComplementoPagoTableAdapter = New Facturador33.ProductionDSTableAdapters.CFDI_ComplementoPagoTableAdapter()
        Me.FacturasExternasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasExternasTableAdapter1 = New Facturador33.ProductionDSTableAdapters.FacturasExternasTableAdapter()
        Me.LbSerie = New System.Windows.Forms.Label()
        Me.TxtSerieCFDI = New System.Windows.Forms.TextBox()
        Me.LbFolioCFDI = New System.Windows.Forms.Label()
        Me.TxtFolioCFDI = New System.Windows.Forms.TextBox()
        Me.CfdI_EncabezadoTableAdapter = New Facturador33.ProductionDSTableAdapters.CFDI_EncabezadoTableAdapter()
        Me.LbCli = New System.Windows.Forms.Label()
        Me.TxtImporteFact = New System.Windows.Forms.TextBox()
        Me.CkDoctoRel = New System.Windows.Forms.CheckBox()
        Me.btnCreaClientes = New System.Windows.Forms.Button()
        Me.Clientes_ARFINTableAdapter = New Facturador33.FinagilDS1TableAdapters.Clientes_ARFINTableAdapter()
        Me.ClientesARFINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._29_FormaPagoTextBox = New System.Windows.Forms.TextBox()
        Me.chkFormato = New System.Windows.Forms.CheckBox()
        Me.GroupClientes.SuspendLayout()
        Me.GroupFinagil.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinagilDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupTerceros.SuspendLayout()
        CType(Me.Clientes_ARFINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDET.SuspendLayout()
        CType(Me.CodigosSATConceptoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupFactura.SuspendLayout()
        CType(Me.CFDI_UsosCFDIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasExternasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetodoPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CFDIEncabezadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasExternasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesARFINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupClientes
        '
        Me.GroupClientes.Controls.Add(Me.RBTerceros)
        Me.GroupClientes.Controls.Add(Me.RBFinagil)
        Me.GroupClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupClientes.Location = New System.Drawing.Point(12, 12)
        Me.GroupClientes.Name = "GroupClientes"
        Me.GroupClientes.Size = New System.Drawing.Size(200, 50)
        Me.GroupClientes.TabIndex = 1
        Me.GroupClientes.TabStop = False
        Me.GroupClientes.Text = "Clientes"
        '
        'RBTerceros
        '
        Me.RBTerceros.AutoSize = True
        Me.RBTerceros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTerceros.Location = New System.Drawing.Point(110, 19)
        Me.RBTerceros.Name = "RBTerceros"
        Me.RBTerceros.Size = New System.Drawing.Size(75, 17)
        Me.RBTerceros.TabIndex = 2
        Me.RBTerceros.Text = "Terceros"
        Me.RBTerceros.UseVisualStyleBackColor = True
        '
        'RBFinagil
        '
        Me.RBFinagil.AutoSize = True
        Me.RBFinagil.Checked = True
        Me.RBFinagil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBFinagil.Location = New System.Drawing.Point(15, 19)
        Me.RBFinagil.Name = "RBFinagil"
        Me.RBFinagil.Size = New System.Drawing.Size(62, 17)
        Me.RBFinagil.TabIndex = 1
        Me.RBFinagil.TabStop = True
        Me.RBFinagil.Text = "Finagil"
        Me.RBFinagil.UseVisualStyleBackColor = True
        '
        'GroupFinagil
        '
        Me.GroupFinagil.Controls.Add(Me.Label2)
        Me.GroupFinagil.Controls.Add(Me.ListClientes)
        Me.GroupFinagil.Controls.Add(Me.TxtFiltro)
        Me.GroupFinagil.Controls.Add(Me.Label1)
        Me.GroupFinagil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupFinagil.Location = New System.Drawing.Point(12, 68)
        Me.GroupFinagil.Name = "GroupFinagil"
        Me.GroupFinagil.Size = New System.Drawing.Size(474, 229)
        Me.GroupFinagil.TabIndex = 3
        Me.GroupFinagil.TabStop = False
        Me.GroupFinagil.Text = "Finagil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Seleccionar Cliente"
        '
        'ListClientes
        '
        Me.ListClientes.CausesValidation = False
        Me.ListClientes.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesBindingSource, "Cliente", True))
        Me.ListClientes.DataSource = Me.ClientesBindingSource
        Me.ListClientes.DisplayMember = "Descr"
        Me.ListClientes.FormattingEnabled = True
        Me.ListClientes.Location = New System.Drawing.Point(15, 71)
        Me.ListClientes.Name = "ListClientes"
        Me.ListClientes.Size = New System.Drawing.Size(453, 147)
        Me.ListClientes.TabIndex = 7
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.FinagilDS1
        '
        'FinagilDS1
        '
        Me.FinagilDS1.DataSetName = "FinagilDS1"
        Me.FinagilDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(53, 23)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(415, 20)
        Me.TxtFiltro.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Filtro"
        '
        'GroupTerceros
        '
        Me.GroupTerceros.Controls.Add(Me.EMail2TextBox)
        Me.GroupTerceros.Controls.Add(Me.EMail1TextBox)
        Me.GroupTerceros.Controls.Add(Me.RFCTextBox)
        Me.GroupTerceros.Controls.Add(Me.CoposTextBox)
        Me.GroupTerceros.Controls.Add(Me.EstadoTextBox)
        Me.GroupTerceros.Controls.Add(Me.DelegacionTextBox)
        Me.GroupTerceros.Controls.Add(Me.ColoniaTextBox)
        Me.GroupTerceros.Controls.Add(Me.CalleTextBox)
        Me.GroupTerceros.Controls.Add(Me.DescrTextBox)
        Me.GroupTerceros.Controls.Add(Me.TxtRSocial)
        Me.GroupTerceros.Controls.Add(Me.TxtMail2)
        Me.GroupTerceros.Controls.Add(Me.Label13)
        Me.GroupTerceros.Controls.Add(Me.TxtMail1)
        Me.GroupTerceros.Controls.Add(Me.Label12)
        Me.GroupTerceros.Controls.Add(Me.TxtRFC)
        Me.GroupTerceros.Controls.Add(Me.TxtCP)
        Me.GroupTerceros.Controls.Add(Me.TxtEdo)
        Me.GroupTerceros.Controls.Add(Me.Txtmunici)
        Me.GroupTerceros.Controls.Add(Me.Txtcol)
        Me.GroupTerceros.Controls.Add(Me.Txtcalle)
        Me.GroupTerceros.Controls.Add(Me.TxtRS)
        Me.GroupTerceros.Controls.Add(Me.Label10)
        Me.GroupTerceros.Controls.Add(Me.Label9)
        Me.GroupTerceros.Controls.Add(Me.Label8)
        Me.GroupTerceros.Controls.Add(Me.Label7)
        Me.GroupTerceros.Controls.Add(Me.Label3)
        Me.GroupTerceros.Controls.Add(Me.Label4)
        Me.GroupTerceros.Controls.Add(Me.Label11)
        Me.GroupTerceros.Enabled = False
        Me.GroupTerceros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupTerceros.Location = New System.Drawing.Point(492, 68)
        Me.GroupTerceros.Name = "GroupTerceros"
        Me.GroupTerceros.Size = New System.Drawing.Size(499, 267)
        Me.GroupTerceros.TabIndex = 4
        Me.GroupTerceros.TabStop = False
        Me.GroupTerceros.Text = "Terceros"
        '
        'EMail2TextBox
        '
        Me.EMail2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "EMail2", True))
        Me.EMail2TextBox.Location = New System.Drawing.Point(260, 200)
        Me.EMail2TextBox.Name = "EMail2TextBox"
        Me.EMail2TextBox.Size = New System.Drawing.Size(224, 20)
        Me.EMail2TextBox.TabIndex = 57
        '
        'EMail1TextBox
        '
        Me.EMail1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "EMail1", True))
        Me.EMail1TextBox.Location = New System.Drawing.Point(14, 200)
        Me.EMail1TextBox.Name = "EMail1TextBox"
        Me.EMail1TextBox.Size = New System.Drawing.Size(237, 20)
        Me.EMail1TextBox.TabIndex = 56
        '
        'RFCTextBox
        '
        Me.RFCTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RFCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "RFC", True))
        Me.RFCTextBox.Location = New System.Drawing.Point(260, 161)
        Me.RFCTextBox.Name = "RFCTextBox"
        Me.RFCTextBox.Size = New System.Drawing.Size(224, 20)
        Me.RFCTextBox.TabIndex = 55
        '
        'CoposTextBox
        '
        Me.CoposTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Copos", True))
        Me.CoposTextBox.Location = New System.Drawing.Point(189, 161)
        Me.CoposTextBox.Name = "CoposTextBox"
        Me.CoposTextBox.Size = New System.Drawing.Size(62, 20)
        Me.CoposTextBox.TabIndex = 54
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(11, 161)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(169, 20)
        Me.EstadoTextBox.TabIndex = 53
        '
        'DelegacionTextBox
        '
        Me.DelegacionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DelegacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Delegacion", True))
        Me.DelegacionTextBox.Location = New System.Drawing.Point(273, 120)
        Me.DelegacionTextBox.Name = "DelegacionTextBox"
        Me.DelegacionTextBox.Size = New System.Drawing.Size(211, 20)
        Me.DelegacionTextBox.TabIndex = 52
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Colonia", True))
        Me.ColoniaTextBox.Location = New System.Drawing.Point(11, 120)
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.Size = New System.Drawing.Size(248, 20)
        Me.ColoniaTextBox.TabIndex = 51
        '
        'CalleTextBox
        '
        Me.CalleTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Calle", True))
        Me.CalleTextBox.Location = New System.Drawing.Point(11, 81)
        Me.CalleTextBox.Name = "CalleTextBox"
        Me.CalleTextBox.Size = New System.Drawing.Size(473, 20)
        Me.CalleTextBox.TabIndex = 50
        '
        'DescrTextBox
        '
        Me.DescrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Descr", True))
        Me.DescrTextBox.Location = New System.Drawing.Point(11, 41)
        Me.DescrTextBox.Name = "DescrTextBox"
        Me.DescrTextBox.Size = New System.Drawing.Size(473, 20)
        Me.DescrTextBox.TabIndex = 49
        '
        'TxtRSocial
        '
        Me.TxtRSocial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "nombre", True))
        Me.TxtRSocial.Location = New System.Drawing.Point(11, 41)
        Me.TxtRSocial.Name = "TxtRSocial"
        Me.TxtRSocial.ReadOnly = True
        Me.TxtRSocial.Size = New System.Drawing.Size(473, 20)
        Me.TxtRSocial.TabIndex = 40
        '
        'Clientes_ARFINBindingSource
        '
        Me.Clientes_ARFINBindingSource.DataMember = "Clientes_ARFIN"
        Me.Clientes_ARFINBindingSource.DataSource = Me.FinagilDS1
        '
        'TxtMail2
        '
        Me.TxtMail2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "email2", True))
        Me.TxtMail2.Location = New System.Drawing.Point(260, 200)
        Me.TxtMail2.MaxLength = 50
        Me.TxtMail2.Name = "TxtMail2"
        Me.TxtMail2.Size = New System.Drawing.Size(224, 20)
        Me.TxtMail2.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(257, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Email 2"
        '
        'TxtMail1
        '
        Me.TxtMail1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "email1", True))
        Me.TxtMail1.Location = New System.Drawing.Point(14, 200)
        Me.TxtMail1.MaxLength = 50
        Me.TxtMail1.Name = "TxtMail1"
        Me.TxtMail1.Size = New System.Drawing.Size(237, 20)
        Me.TxtMail1.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Email 1"
        '
        'TxtRFC
        '
        Me.TxtRFC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "RFC", True))
        Me.TxtRFC.Location = New System.Drawing.Point(260, 161)
        Me.TxtRFC.MaxLength = 13
        Me.TxtRFC.Name = "TxtRFC"
        Me.TxtRFC.Size = New System.Drawing.Size(224, 20)
        Me.TxtRFC.TabIndex = 35
        '
        'TxtCP
        '
        Me.TxtCP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "cp", True))
        Me.TxtCP.Location = New System.Drawing.Point(189, 161)
        Me.TxtCP.MaxLength = 5
        Me.TxtCP.Name = "TxtCP"
        Me.TxtCP.Size = New System.Drawing.Size(62, 20)
        Me.TxtCP.TabIndex = 34
        '
        'TxtEdo
        '
        Me.TxtEdo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "estado", True))
        Me.TxtEdo.Location = New System.Drawing.Point(11, 161)
        Me.TxtEdo.MaxLength = 45
        Me.TxtEdo.Name = "TxtEdo"
        Me.TxtEdo.Size = New System.Drawing.Size(169, 20)
        Me.TxtEdo.TabIndex = 33
        '
        'Txtmunici
        '
        Me.Txtmunici.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "municipio", True))
        Me.Txtmunici.Location = New System.Drawing.Point(273, 120)
        Me.Txtmunici.MaxLength = 45
        Me.Txtmunici.Name = "Txtmunici"
        Me.Txtmunici.Size = New System.Drawing.Size(211, 20)
        Me.Txtmunici.TabIndex = 32
        '
        'Txtcol
        '
        Me.Txtcol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "colonia", True))
        Me.Txtcol.Location = New System.Drawing.Point(11, 120)
        Me.Txtcol.MaxLength = 45
        Me.Txtcol.Name = "Txtcol"
        Me.Txtcol.Size = New System.Drawing.Size(248, 20)
        Me.Txtcol.TabIndex = 31
        '
        'Txtcalle
        '
        Me.Txtcalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "direccion", True))
        Me.Txtcalle.Location = New System.Drawing.Point(11, 81)
        Me.Txtcalle.MaxLength = 120
        Me.Txtcalle.Name = "Txtcalle"
        Me.Txtcalle.Size = New System.Drawing.Size(473, 20)
        Me.Txtcalle.TabIndex = 30
        '
        'TxtRS
        '
        Me.TxtRS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRS.Location = New System.Drawing.Point(99, 15)
        Me.TxtRS.MaxLength = 120
        Me.TxtRS.Name = "TxtRS"
        Me.TxtRS.Size = New System.Drawing.Size(385, 20)
        Me.TxtRS.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(257, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "R.F.C."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(186, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "C.P."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Estado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(273, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Municipio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Colonia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Calle y numero"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Razon Social"
        '
        'GroupDET
        '
        Me.GroupDET.Controls.Add(Me.Label27)
        Me.GroupDET.Controls.Add(Me.txtUnidadInterna)
        Me.GroupDET.Controls.Add(Me.lblTipoCambio)
        Me.GroupDET.Controls.Add(Me.CmbConcepto)
        Me.GroupDET.Controls.Add(Me.TxtUnidad)
        Me.GroupDET.Controls.Add(Me.Label23)
        Me.GroupDET.Controls.Add(Me.BTAgregar)
        Me.GroupDET.Controls.Add(Me.Label17)
        Me.GroupDET.Controls.Add(Me.Label16)
        Me.GroupDET.Controls.Add(Me.TxtPrecio)
        Me.GroupDET.Controls.Add(Me.Label15)
        Me.GroupDET.Controls.Add(Me.TxtCantidad)
        Me.GroupDET.Controls.Add(Me.cmbIva)
        Me.GroupDET.Controls.Add(Me.Label14)
        Me.GroupDET.Enabled = False
        Me.GroupDET.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDET.Location = New System.Drawing.Point(359, 303)
        Me.GroupDET.Name = "GroupDET"
        Me.GroupDET.Size = New System.Drawing.Size(632, 74)
        Me.GroupDET.TabIndex = 3
        Me.GroupDET.TabStop = False
        Me.GroupDET.Text = "Detalles"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(510, 26)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(46, 13)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = "U Inter"
        '
        'txtUnidadInterna
        '
        Me.txtUnidadInterna.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodigosSATConceptoBindingSource, "UnidadInterna", True))
        Me.txtUnidadInterna.Location = New System.Drawing.Point(512, 42)
        Me.txtUnidadInterna.Name = "txtUnidadInterna"
        Me.txtUnidadInterna.ReadOnly = True
        Me.txtUnidadInterna.Size = New System.Drawing.Size(45, 20)
        Me.txtUnidadInterna.TabIndex = 23
        '
        'CodigosSATConceptoBindingSource
        '
        Me.CodigosSATConceptoBindingSource.DataMember = "CodigosSAT_Concepto"
        Me.CodigosSATConceptoBindingSource.DataSource = Me.FinagilDS1
        '
        'lblTipoCambio
        '
        Me.lblTipoCambio.AutoSize = True
        Me.lblTipoCambio.Location = New System.Drawing.Point(69, 13)
        Me.lblTipoCambio.Name = "lblTipoCambio"
        Me.lblTipoCambio.Size = New System.Drawing.Size(95, 13)
        Me.lblTipoCambio.TabIndex = 22
        Me.lblTipoCambio.Text = "Tipo de Cambio"
        '
        'CmbConcepto
        '
        Me.CmbConcepto.DataSource = Me.CodigosSATConceptoBindingSource
        Me.CmbConcepto.DisplayMember = "Concepto"
        Me.CmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbConcepto.FormattingEnabled = True
        Me.CmbConcepto.Location = New System.Drawing.Point(244, 42)
        Me.CmbConcepto.Name = "CmbConcepto"
        Me.CmbConcepto.Size = New System.Drawing.Size(210, 21)
        Me.CmbConcepto.TabIndex = 17
        Me.CmbConcepto.ValueMember = "Codigo"
        '
        'TxtUnidad
        '
        Me.TxtUnidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CodigosSATConceptoBindingSource, "Unidad", True))
        Me.TxtUnidad.Location = New System.Drawing.Point(459, 42)
        Me.TxtUnidad.Name = "TxtUnidad"
        Me.TxtUnidad.ReadOnly = True
        Me.TxtUnidad.Size = New System.Drawing.Size(48, 20)
        Me.TxtUnidad.TabIndex = 21
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(457, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 13)
        Me.Label23.TabIndex = 20
        Me.Label23.Text = "U SAT"
        '
        'BTAgregar
        '
        Me.BTAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAgregar.Location = New System.Drawing.Point(561, 31)
        Me.BTAgregar.Name = "BTAgregar"
        Me.BTAgregar.Size = New System.Drawing.Size(68, 40)
        Me.BTAgregar.TabIndex = 19
        Me.BTAgregar.Text = "Agregar Detalle"
        Me.BTAgregar.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(248, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Concepto"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(167, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Precio"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(164, 42)
        Me.TxtPrecio.MaxLength = 10
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(74, 20)
        Me.TxtPrecio.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(86, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Cantidad"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(89, 42)
        Me.TxtCantidad.MaxLength = 10
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(69, 20)
        Me.TxtCantidad.TabIndex = 13
        '
        'cmbIva
        '
        Me.cmbIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIva.FormattingEnabled = True
        Me.cmbIva.Items.AddRange(New Object() {"Exento", "16 %", "0 %", "No Objeto"})
        Me.cmbIva.Location = New System.Drawing.Point(3, 42)
        Me.cmbIva.Name = "cmbIva"
        Me.cmbIva.Size = New System.Drawing.Size(79, 21)
        Me.cmbIva.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Iva"
        '
        'GroupFactura
        '
        Me.GroupFactura.Controls.Add(Me.txtUsoClave)
        Me.GroupFactura.Controls.Add(Me.cmbUsoCfdi)
        Me.GroupFactura.Controls.Add(Me.Label25)
        Me.GroupFactura.Controls.Add(Me.cmbPago)
        Me.GroupFactura.Controls.Add(Me.Label21)
        Me.GroupFactura.Controls.Add(Me.LbFolio)
        Me.GroupFactura.Controls.Add(Me.cmbMoneda)
        Me.GroupFactura.Controls.Add(Me.Label6)
        Me.GroupFactura.Controls.Add(Me.CmbSerie)
        Me.GroupFactura.Controls.Add(Me.Label5)
        Me.GroupFactura.Controls.Add(Me.txtMoral)
        Me.GroupFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupFactura.Location = New System.Drawing.Point(15, 303)
        Me.GroupFactura.Name = "GroupFactura"
        Me.GroupFactura.Size = New System.Drawing.Size(339, 74)
        Me.GroupFactura.TabIndex = 3
        Me.GroupFactura.TabStop = False
        Me.GroupFactura.Text = "Factura"
        '
        'txtUsoClave
        '
        Me.txtUsoClave.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_UsosCFDIBindingSource, "UsoCFDI", True))
        Me.txtUsoClave.Enabled = False
        Me.txtUsoClave.Location = New System.Drawing.Point(302, 22)
        Me.txtUsoClave.Name = "txtUsoClave"
        Me.txtUsoClave.ReadOnly = True
        Me.txtUsoClave.Size = New System.Drawing.Size(31, 20)
        Me.txtUsoClave.TabIndex = 19
        '
        'CFDI_UsosCFDIBindingSource
        '
        Me.CFDI_UsosCFDIBindingSource.DataMember = "CFDI_UsosCFDI"
        Me.CFDI_UsosCFDIBindingSource.DataSource = Me.ProductionDS
        '
        'ProductionDS
        '
        Me.ProductionDS.DataSetName = "ProductionDS"
        Me.ProductionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbUsoCfdi
        '
        Me.cmbUsoCfdi.DataSource = Me.CFDI_UsosCFDIBindingSource
        Me.cmbUsoCfdi.DisplayMember = "Descripcion"
        Me.cmbUsoCfdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsoCfdi.Enabled = False
        Me.cmbUsoCfdi.FormattingEnabled = True
        Me.cmbUsoCfdi.Location = New System.Drawing.Point(216, 43)
        Me.cmbUsoCfdi.Name = "cmbUsoCfdi"
        Me.cmbUsoCfdi.Size = New System.Drawing.Size(117, 21)
        Me.cmbUsoCfdi.TabIndex = 18
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(213, 26)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 13)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Uso CFDI"
        '
        'cmbPago
        '
        Me.cmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPago.FormattingEnabled = True
        Me.cmbPago.Items.AddRange(New Object() {"PUE", "PPD"})
        Me.cmbPago.Location = New System.Drawing.Point(156, 42)
        Me.cmbPago.Name = "cmbPago"
        Me.cmbPago.Size = New System.Drawing.Size(54, 21)
        Me.cmbPago.TabIndex = 16
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(161, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 13)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Pago"
        '
        'LbFolio
        '
        Me.LbFolio.AutoSize = True
        Me.LbFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFolio.Location = New System.Drawing.Point(58, 25)
        Me.LbFolio.Name = "LbFolio"
        Me.LbFolio.Size = New System.Drawing.Size(34, 13)
        Me.LbFolio.TabIndex = 13
        Me.LbFolio.Text = "Folio"
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Items.AddRange(New Object() {"MXN", "USD"})
        Me.cmbMoneda.Location = New System.Drawing.Point(98, 42)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(52, 21)
        Me.cmbMoneda.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(98, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Moneda"
        '
        'CmbSerie
        '
        Me.CmbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSerie.FormattingEnabled = True
        Me.CmbSerie.Items.AddRange(New Object() {"B", "DV", "C", "SA", "F"})
        Me.CmbSerie.Location = New System.Drawing.Point(9, 42)
        Me.CmbSerie.Name = "CmbSerie"
        Me.CmbSerie.Size = New System.Drawing.Size(83, 21)
        Me.CmbSerie.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Serie"
        '
        'txtMoral
        '
        Me.txtMoral.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDI_UsosCFDIBindingSource, "Moral", True))
        Me.txtMoral.Enabled = False
        Me.txtMoral.Location = New System.Drawing.Point(302, 43)
        Me.txtMoral.Name = "txtMoral"
        Me.txtMoral.ReadOnly = True
        Me.txtMoral.Size = New System.Drawing.Size(23, 20)
        Me.txtMoral.TabIndex = 20
        '
        'Btcancelar
        '
        Me.Btcancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btcancelar.Location = New System.Drawing.Point(906, 22)
        Me.Btcancelar.Name = "Btcancelar"
        Me.Btcancelar.Size = New System.Drawing.Size(84, 40)
        Me.Btcancelar.TabIndex = 5
        Me.Btcancelar.Text = "Cancelar Captura"
        Me.Btcancelar.UseVisualStyleBackColor = True
        '
        'GridFactura
        '
        Me.GridFactura.AllowUserToAddRows = False
        Me.GridFactura.AutoGenerateColumns = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.GridFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SerieDataGridViewTextBoxColumn, Me.FacturaDataGridViewTextBoxColumn, Me.ConsecDataGridViewTextBoxColumn, Me.DetalleDataGridViewTextBoxColumn, Me.Unidad, Me.UnidadInterna, Me.CantidadDataGridViewTextBoxColumn, Me.UnitarioDataGridViewTextBoxColumn, Me.IvaDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.MonedaDataGridViewTextBoxColumn, Me.TasaIvaDataGridViewTextBoxColumn, Me.FacturadoDataGridViewCheckBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CalleDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.MunicipioDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.CPDataGridViewTextBoxColumn, Me.RFCDataGridViewTextBoxColumn, Me.Mail1DataGridViewTextBoxColumn, Me.Mail2DataGridViewTextBoxColumn, Me.ColumnTotalX, Me.MetodoPago, Me.Cuenta})
        Me.GridFactura.DataSource = Me.FacturasExternasBindingSource
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridFactura.DefaultCellStyle = DataGridViewCellStyle15
        Me.GridFactura.Location = New System.Drawing.Point(15, 443)
        Me.GridFactura.Name = "GridFactura"
        Me.GridFactura.ReadOnly = True
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridFactura.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.GridFactura.Size = New System.Drawing.Size(975, 148)
        Me.GridFactura.TabIndex = 6
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "Serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.ReadOnly = True
        Me.SerieDataGridViewTextBoxColumn.Visible = False
        '
        'FacturaDataGridViewTextBoxColumn
        '
        Me.FacturaDataGridViewTextBoxColumn.DataPropertyName = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.HeaderText = "Factura"
        Me.FacturaDataGridViewTextBoxColumn.Name = "FacturaDataGridViewTextBoxColumn"
        Me.FacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FacturaDataGridViewTextBoxColumn.Visible = False
        '
        'ConsecDataGridViewTextBoxColumn
        '
        Me.ConsecDataGridViewTextBoxColumn.DataPropertyName = "Consec"
        Me.ConsecDataGridViewTextBoxColumn.HeaderText = "Consec"
        Me.ConsecDataGridViewTextBoxColumn.Name = "ConsecDataGridViewTextBoxColumn"
        Me.ConsecDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConsecDataGridViewTextBoxColumn.Visible = False
        '
        'DetalleDataGridViewTextBoxColumn
        '
        Me.DetalleDataGridViewTextBoxColumn.DataPropertyName = "Detalle"
        Me.DetalleDataGridViewTextBoxColumn.HeaderText = "Concepto"
        Me.DetalleDataGridViewTextBoxColumn.Name = "DetalleDataGridViewTextBoxColumn"
        Me.DetalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetalleDataGridViewTextBoxColumn.Width = 270
        '
        'Unidad
        '
        Me.Unidad.DataPropertyName = "Unidad"
        Me.Unidad.HeaderText = "Unid SAT"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        Me.Unidad.Width = 80
        '
        'UnidadInterna
        '
        Me.UnidadInterna.DataPropertyName = "UnidadInterna"
        Me.UnidadInterna.HeaderText = "Unid Int"
        Me.UnidadInterna.Name = "UnidadInterna"
        Me.UnidadInterna.ReadOnly = True
        Me.UnidadInterna.Width = 80
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle10.Format = "N1"
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitarioDataGridViewTextBoxColumn
        '
        Me.UnitarioDataGridViewTextBoxColumn.DataPropertyName = "Unitario"
        DataGridViewCellStyle11.Format = "n2"
        Me.UnitarioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.UnitarioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.UnitarioDataGridViewTextBoxColumn.Name = "UnitarioDataGridViewTextBoxColumn"
        Me.UnitarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IvaDataGridViewTextBoxColumn
        '
        Me.IvaDataGridViewTextBoxColumn.DataPropertyName = "Iva"
        DataGridViewCellStyle12.Format = "n2"
        Me.IvaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.IvaDataGridViewTextBoxColumn.HeaderText = "Iva"
        Me.IvaDataGridViewTextBoxColumn.Name = "IvaDataGridViewTextBoxColumn"
        Me.IvaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle13.Format = "n2"
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "SubTotal"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Visible = False
        '
        'MonedaDataGridViewTextBoxColumn
        '
        Me.MonedaDataGridViewTextBoxColumn.DataPropertyName = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.HeaderText = "Moneda"
        Me.MonedaDataGridViewTextBoxColumn.Name = "MonedaDataGridViewTextBoxColumn"
        Me.MonedaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MonedaDataGridViewTextBoxColumn.Visible = False
        '
        'TasaIvaDataGridViewTextBoxColumn
        '
        Me.TasaIvaDataGridViewTextBoxColumn.DataPropertyName = "TasaIva"
        Me.TasaIvaDataGridViewTextBoxColumn.HeaderText = "TasaIva"
        Me.TasaIvaDataGridViewTextBoxColumn.Name = "TasaIvaDataGridViewTextBoxColumn"
        Me.TasaIvaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TasaIvaDataGridViewTextBoxColumn.Width = 60
        '
        'FacturadoDataGridViewCheckBoxColumn
        '
        Me.FacturadoDataGridViewCheckBoxColumn.DataPropertyName = "Facturado"
        Me.FacturadoDataGridViewCheckBoxColumn.HeaderText = "Facturado"
        Me.FacturadoDataGridViewCheckBoxColumn.Name = "FacturadoDataGridViewCheckBoxColumn"
        Me.FacturadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.FacturadoDataGridViewCheckBoxColumn.Visible = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Visible = False
        '
        'CalleDataGridViewTextBoxColumn
        '
        Me.CalleDataGridViewTextBoxColumn.DataPropertyName = "Calle"
        Me.CalleDataGridViewTextBoxColumn.HeaderText = "Calle"
        Me.CalleDataGridViewTextBoxColumn.Name = "CalleDataGridViewTextBoxColumn"
        Me.CalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.CalleDataGridViewTextBoxColumn.Visible = False
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ColoniaDataGridViewTextBoxColumn.Visible = False
        '
        'MunicipioDataGridViewTextBoxColumn
        '
        Me.MunicipioDataGridViewTextBoxColumn.DataPropertyName = "Municipio"
        Me.MunicipioDataGridViewTextBoxColumn.HeaderText = "Municipio"
        Me.MunicipioDataGridViewTextBoxColumn.Name = "MunicipioDataGridViewTextBoxColumn"
        Me.MunicipioDataGridViewTextBoxColumn.ReadOnly = True
        Me.MunicipioDataGridViewTextBoxColumn.Visible = False
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Visible = False
        '
        'CPDataGridViewTextBoxColumn
        '
        Me.CPDataGridViewTextBoxColumn.DataPropertyName = "CP"
        Me.CPDataGridViewTextBoxColumn.HeaderText = "CP"
        Me.CPDataGridViewTextBoxColumn.Name = "CPDataGridViewTextBoxColumn"
        Me.CPDataGridViewTextBoxColumn.ReadOnly = True
        Me.CPDataGridViewTextBoxColumn.Visible = False
        '
        'RFCDataGridViewTextBoxColumn
        '
        Me.RFCDataGridViewTextBoxColumn.DataPropertyName = "RFC"
        Me.RFCDataGridViewTextBoxColumn.HeaderText = "RFC"
        Me.RFCDataGridViewTextBoxColumn.Name = "RFCDataGridViewTextBoxColumn"
        Me.RFCDataGridViewTextBoxColumn.ReadOnly = True
        Me.RFCDataGridViewTextBoxColumn.Visible = False
        '
        'Mail1DataGridViewTextBoxColumn
        '
        Me.Mail1DataGridViewTextBoxColumn.DataPropertyName = "Mail1"
        Me.Mail1DataGridViewTextBoxColumn.HeaderText = "Mail1"
        Me.Mail1DataGridViewTextBoxColumn.Name = "Mail1DataGridViewTextBoxColumn"
        Me.Mail1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Mail1DataGridViewTextBoxColumn.Visible = False
        '
        'Mail2DataGridViewTextBoxColumn
        '
        Me.Mail2DataGridViewTextBoxColumn.DataPropertyName = "Mail2"
        Me.Mail2DataGridViewTextBoxColumn.HeaderText = "Mail2"
        Me.Mail2DataGridViewTextBoxColumn.Name = "Mail2DataGridViewTextBoxColumn"
        Me.Mail2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Mail2DataGridViewTextBoxColumn.Visible = False
        '
        'ColumnTotalX
        '
        DataGridViewCellStyle14.Format = "n2"
        Me.ColumnTotalX.DefaultCellStyle = DataGridViewCellStyle14
        Me.ColumnTotalX.HeaderText = "Total"
        Me.ColumnTotalX.Name = "ColumnTotalX"
        Me.ColumnTotalX.ReadOnly = True
        '
        'MetodoPago
        '
        Me.MetodoPago.DataPropertyName = "MetodoPago"
        Me.MetodoPago.HeaderText = "MetodoPago"
        Me.MetodoPago.Name = "MetodoPago"
        Me.MetodoPago.ReadOnly = True
        Me.MetodoPago.Visible = False
        '
        'Cuenta
        '
        Me.Cuenta.DataPropertyName = "Cuenta"
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.ReadOnly = True
        Me.Cuenta.Visible = False
        '
        'FacturasExternasBindingSource
        '
        Me.FacturasExternasBindingSource.DataMember = "FacturasExternas"
        Me.FacturasExternasBindingSource.DataSource = Me.FinagilDS1
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(888, 600)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 7
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtIva
        '
        Me.TxtIva.Enabled = False
        Me.TxtIva.Location = New System.Drawing.Point(888, 626)
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.Size = New System.Drawing.Size(100, 20)
        Me.TxtIva.TabIndex = 8
        Me.TxtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(889, 652)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 9
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(828, 603)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Subtotal"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(857, 629)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 13)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Iva"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(846, 655)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 13)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Total"
        '
        'BtFacturar
        '
        Me.BtFacturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtFacturar.Location = New System.Drawing.Point(732, 615)
        Me.BtFacturar.Name = "BtFacturar"
        Me.BtFacturar.Size = New System.Drawing.Size(84, 40)
        Me.BtFacturar.TabIndex = 24
        Me.BtFacturar.Text = "Facturar"
        Me.BtFacturar.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(525, 610)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 13)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "Forma de Pago"
        '
        'CmbMetodo
        '
        Me.CmbMetodo.DataSource = Me.MetodoPagoBindingSource
        Me.CmbMetodo.DisplayMember = "InstrumentoMonetario"
        Me.CmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMetodo.FormattingEnabled = True
        Me.CmbMetodo.Location = New System.Drawing.Point(527, 625)
        Me.CmbMetodo.Name = "CmbMetodo"
        Me.CmbMetodo.Size = New System.Drawing.Size(199, 21)
        Me.CmbMetodo.TabIndex = 23
        Me.CmbMetodo.ValueMember = "SAT"
        Me.CmbMetodo.Visible = False
        '
        'MetodoPagoBindingSource
        '
        Me.MetodoPagoBindingSource.DataMember = "MetodoPago"
        Me.MetodoPagoBindingSource.DataSource = Me.FinagilDS1
        '
        'lblFechaAplica
        '
        Me.lblFechaAplica.AutoSize = True
        Me.lblFechaAplica.Location = New System.Drawing.Point(356, 36)
        Me.lblFechaAplica.Name = "lblFechaAplica"
        Me.lblFechaAplica.Size = New System.Drawing.Size(66, 13)
        Me.lblFechaAplica.TabIndex = 33
        Me.lblFechaAplica.Text = "FechaAplica"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(238, 35)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(110, 13)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "Fecha de Aplicacion: "
        '
        'lblFormapago
        '
        Me.lblFormapago.AutoSize = True
        Me.lblFormapago.Location = New System.Drawing.Point(525, 649)
        Me.lblFormapago.Name = "lblFormapago"
        Me.lblFormapago.Size = New System.Drawing.Size(45, 13)
        Me.lblFormapago.TabIndex = 35
        Me.lblFormapago.Text = "Label25"
        Me.lblFormapago.Visible = False
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(192, 383)
        Me.TxtDesc.MaxLength = 970
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(714, 54)
        Me.TxtDesc.TabIndex = 20
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(104, 404)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(82, 13)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "Descripción: "
        '
        'CFDI_UsosCFDITableAdapter
        '
        Me.CFDI_UsosCFDITableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RDArfin)
        Me.GroupBox1.Controls.Add(Me.RDFinagil)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(444, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 50)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empresa"
        '
        'RDArfin
        '
        Me.RDArfin.AutoSize = True
        Me.RDArfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDArfin.Location = New System.Drawing.Point(110, 19)
        Me.RDArfin.Name = "RDArfin"
        Me.RDArfin.Size = New System.Drawing.Size(51, 17)
        Me.RDArfin.TabIndex = 2
        Me.RDArfin.Text = "Arfin"
        Me.RDArfin.UseVisualStyleBackColor = True
        '
        'RDFinagil
        '
        Me.RDFinagil.AutoSize = True
        Me.RDFinagil.Checked = True
        Me.RDFinagil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDFinagil.Location = New System.Drawing.Point(15, 19)
        Me.RDFinagil.Name = "RDFinagil"
        Me.RDFinagil.Size = New System.Drawing.Size(62, 17)
        Me.RDFinagil.TabIndex = 1
        Me.RDFinagil.TabStop = True
        Me.RDFinagil.Text = "Finagil"
        Me.RDFinagil.UseVisualStyleBackColor = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'FacturasExternasTableAdapter
        '
        Me.FacturasExternasTableAdapter.ClearBeforeFill = True
        '
        'FechasAplicacionTableAdapter
        '
        Me.FechasAplicacionTableAdapter.ClearBeforeFill = True
        '
        'MetodoPagoTableAdapter
        '
        Me.MetodoPagoTableAdapter.ClearBeforeFill = True
        '
        'CodigosSAT_ConceptoTableAdapter
        '
        Me.CodigosSAT_ConceptoTableAdapter.ClearBeforeFill = True
        '
        'txbFolioFiscal
        '
        Me.txbFolioFiscal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEncabezadoBindingSource, "Guid", True))
        Me.txbFolioFiscal.Location = New System.Drawing.Point(12, 652)
        Me.txbFolioFiscal.Name = "txbFolioFiscal"
        Me.txbFolioFiscal.ReadOnly = True
        Me.txbFolioFiscal.Size = New System.Drawing.Size(243, 20)
        Me.txbFolioFiscal.TabIndex = 39
        Me.txbFolioFiscal.Visible = False
        '
        'CFDIEncabezadoBindingSource
        '
        Me.CFDIEncabezadoBindingSource.DataMember = "CFDI_Encabezado"
        Me.CFDIEncabezadoBindingSource.DataSource = Me.ProductionDS
        '
        'lblFolioFiscal
        '
        Me.lblFolioFiscal.AutoSize = True
        Me.lblFolioFiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolioFiscal.Location = New System.Drawing.Point(9, 636)
        Me.lblFolioFiscal.Name = "lblFolioFiscal"
        Me.lblFolioFiscal.Size = New System.Drawing.Size(71, 13)
        Me.lblFolioFiscal.TabIndex = 40
        Me.lblFolioFiscal.Text = "Folio Fiscal"
        Me.lblFolioFiscal.Visible = False
        '
        'CfdI_ComplementoPagoTableAdapter
        '
        Me.CfdI_ComplementoPagoTableAdapter.ClearBeforeFill = True
        '
        'FacturasExternasBindingSource1
        '
        Me.FacturasExternasBindingSource1.DataMember = "FacturasExternas"
        Me.FacturasExternasBindingSource1.DataSource = Me.ProductionDS
        '
        'FacturasExternasTableAdapter1
        '
        Me.FacturasExternasTableAdapter1.ClearBeforeFill = True
        '
        'LbSerie
        '
        Me.LbSerie.AutoSize = True
        Me.LbSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSerie.Location = New System.Drawing.Point(15, 597)
        Me.LbSerie.Name = "LbSerie"
        Me.LbSerie.Size = New System.Drawing.Size(36, 13)
        Me.LbSerie.TabIndex = 42
        Me.LbSerie.Text = "Serie"
        Me.LbSerie.Visible = False
        '
        'TxtSerieCFDI
        '
        Me.TxtSerieCFDI.Location = New System.Drawing.Point(12, 613)
        Me.TxtSerieCFDI.MaxLength = 10
        Me.TxtSerieCFDI.Name = "TxtSerieCFDI"
        Me.TxtSerieCFDI.Size = New System.Drawing.Size(47, 20)
        Me.TxtSerieCFDI.TabIndex = 21
        Me.TxtSerieCFDI.Visible = False
        '
        'LbFolioCFDI
        '
        Me.LbFolioCFDI.AutoSize = True
        Me.LbFolioCFDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFolioCFDI.Location = New System.Drawing.Point(68, 597)
        Me.LbFolioCFDI.Name = "LbFolioCFDI"
        Me.LbFolioCFDI.Size = New System.Drawing.Size(34, 13)
        Me.LbFolioCFDI.TabIndex = 44
        Me.LbFolioCFDI.Text = "Folio"
        Me.LbFolioCFDI.Visible = False
        '
        'TxtFolioCFDI
        '
        Me.TxtFolioCFDI.Location = New System.Drawing.Point(65, 613)
        Me.TxtFolioCFDI.MaxLength = 10
        Me.TxtFolioCFDI.Name = "TxtFolioCFDI"
        Me.TxtFolioCFDI.Size = New System.Drawing.Size(74, 20)
        Me.TxtFolioCFDI.TabIndex = 22
        Me.TxtFolioCFDI.Visible = False
        '
        'CfdI_EncabezadoTableAdapter
        '
        Me.CfdI_EncabezadoTableAdapter.ClearBeforeFill = True
        '
        'LbCli
        '
        Me.LbCli.AutoSize = True
        Me.LbCli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEncabezadoBindingSource, "42_Nombre_Receptor", True))
        Me.LbCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCli.Location = New System.Drawing.Point(145, 615)
        Me.LbCli.Name = "LbCli"
        Me.LbCli.Size = New System.Drawing.Size(46, 13)
        Me.LbCli.TabIndex = 45
        Me.LbCli.Text = "Cliente"
        Me.LbCli.Visible = False
        '
        'TxtImporteFact
        '
        Me.TxtImporteFact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEncabezadoBindingSource, "56_Monto_Total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TxtImporteFact.Location = New System.Drawing.Point(259, 652)
        Me.TxtImporteFact.Name = "TxtImporteFact"
        Me.TxtImporteFact.ReadOnly = True
        Me.TxtImporteFact.Size = New System.Drawing.Size(95, 20)
        Me.TxtImporteFact.TabIndex = 46
        Me.TxtImporteFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtImporteFact.Visible = False
        '
        'CkDoctoRel
        '
        Me.CkDoctoRel.AutoSize = True
        Me.CkDoctoRel.Location = New System.Drawing.Point(650, 45)
        Me.CkDoctoRel.Name = "CkDoctoRel"
        Me.CkDoctoRel.Size = New System.Drawing.Size(121, 17)
        Me.CkDoctoRel.TabIndex = 47
        Me.CkDoctoRel.Text = "Docto. Relacionado"
        Me.CkDoctoRel.UseVisualStyleBackColor = True
        '
        'btnCreaClientes
        '
        Me.btnCreaClientes.Location = New System.Drawing.Point(650, 17)
        Me.btnCreaClientes.Name = "btnCreaClientes"
        Me.btnCreaClientes.Size = New System.Drawing.Size(75, 23)
        Me.btnCreaClientes.TabIndex = 48
        Me.btnCreaClientes.Text = "Clientes"
        Me.btnCreaClientes.UseVisualStyleBackColor = True
        '
        'Clientes_ARFINTableAdapter
        '
        Me.Clientes_ARFINTableAdapter.ClearBeforeFill = True
        '
        'ClientesARFINBindingSource
        '
        Me.ClientesARFINBindingSource.DataMember = "Clientes_ARFIN"
        Me.ClientesARFINBindingSource.DataSource = Me.FinagilDS1
        '
        '_29_FormaPagoTextBox
        '
        Me._29_FormaPagoTextBox.BackColor = System.Drawing.SystemColors.Control
        Me._29_FormaPagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CFDIEncabezadoBindingSource, "29_FormaPago", True))
        Me._29_FormaPagoTextBox.Location = New System.Drawing.Point(359, 652)
        Me._29_FormaPagoTextBox.Name = "_29_FormaPagoTextBox"
        Me._29_FormaPagoTextBox.Size = New System.Drawing.Size(52, 20)
        Me._29_FormaPagoTextBox.TabIndex = 49
        Me._29_FormaPagoTextBox.Visible = False
        '
        'chkFormato
        '
        Me.chkFormato.AutoSize = True
        Me.chkFormato.Location = New System.Drawing.Point(529, 666)
        Me.chkFormato.Name = "chkFormato"
        Me.chkFormato.Size = New System.Drawing.Size(116, 17)
        Me.chkFormato.TabIndex = 50
        Me.chkFormato.Text = "Formato Activo Fijo"
        Me.chkFormato.UseVisualStyleBackColor = True
        '
        'FrmFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1011, 700)
        Me.Controls.Add(Me.chkFormato)
        Me.Controls.Add(Me._29_FormaPagoTextBox)
        Me.Controls.Add(Me.btnCreaClientes)
        Me.Controls.Add(Me.CkDoctoRel)
        Me.Controls.Add(Me.TxtImporteFact)
        Me.Controls.Add(Me.LbCli)
        Me.Controls.Add(Me.LbFolioCFDI)
        Me.Controls.Add(Me.TxtFolioCFDI)
        Me.Controls.Add(Me.LbSerie)
        Me.Controls.Add(Me.TxtSerieCFDI)
        Me.Controls.Add(Me.lblFolioFiscal)
        Me.Controls.Add(Me.txbFolioFiscal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TxtDesc)
        Me.Controls.Add(Me.lblFormapago)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lblFechaAplica)
        Me.Controls.Add(Me.CmbMetodo)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.BtFacturar)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtIva)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.GridFactura)
        Me.Controls.Add(Me.Btcancelar)
        Me.Controls.Add(Me.GroupFactura)
        Me.Controls.Add(Me.GroupDET)
        Me.Controls.Add(Me.GroupTerceros)
        Me.Controls.Add(Me.GroupFinagil)
        Me.Controls.Add(Me.GroupClientes)
        Me.Name = "FrmFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas Serie ""B"", ""DV"" y NC"
        Me.GroupClientes.ResumeLayout(False)
        Me.GroupClientes.PerformLayout()
        Me.GroupFinagil.ResumeLayout(False)
        Me.GroupFinagil.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinagilDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupTerceros.ResumeLayout(False)
        Me.GroupTerceros.PerformLayout()
        CType(Me.Clientes_ARFINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDET.ResumeLayout(False)
        Me.GroupDET.PerformLayout()
        CType(Me.CodigosSATConceptoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupFactura.ResumeLayout(False)
        Me.GroupFactura.PerformLayout()
        CType(Me.CFDI_UsosCFDIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasExternasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetodoPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CFDIEncabezadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasExternasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesARFINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupClientes As System.Windows.Forms.GroupBox
    Friend WithEvents RBTerceros As System.Windows.Forms.RadioButton
    Friend WithEvents RBFinagil As System.Windows.Forms.RadioButton
    Friend WithEvents GroupFinagil As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListClientes As System.Windows.Forms.ListBox
    Friend WithEvents FinagilDS1 As Facturador33.FinagilDS1
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Facturador33.FinagilDS1TableAdapters.ClientesTableAdapter
    Friend WithEvents GroupTerceros As System.Windows.Forms.GroupBox
    Friend WithEvents TxtRFC As System.Windows.Forms.TextBox
    Friend WithEvents TxtCP As System.Windows.Forms.TextBox
    Friend WithEvents TxtEdo As System.Windows.Forms.TextBox
    Friend WithEvents Txtmunici As System.Windows.Forms.TextBox
    Friend WithEvents Txtcol As System.Windows.Forms.TextBox
    Friend WithEvents Txtcalle As System.Windows.Forms.TextBox
    Friend WithEvents TxtRS As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtMail1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtMail2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupDET As System.Windows.Forms.GroupBox
    Friend WithEvents GroupFactura As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbSerie As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbIva As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Btcancelar As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BTAgregar As System.Windows.Forms.Button
    Friend WithEvents GridFactura As System.Windows.Forms.DataGridView
    Friend WithEvents FacturasExternasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturasExternasTableAdapter As Facturador33.FinagilDS1TableAdapters.FacturasExternasTableAdapter
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtIva As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents BtFacturar As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LbFolio As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents FechasAplicacionTableAdapter As FinagilDS1TableAdapters.FechasAplicacionTableAdapter
    Friend WithEvents CmbMetodo As ComboBox
    Friend WithEvents MetodoPagoBindingSource As BindingSource
    Friend WithEvents MetodoPagoTableAdapter As FinagilDS1TableAdapters.MetodopagoTableAdapter
    Friend WithEvents CmbConcepto As ComboBox
    Friend WithEvents TxtUnidad As TextBox
    Friend WithEvents CodigosSATConceptoBindingSource As BindingSource
    Friend WithEvents CodigosSAT_ConceptoTableAdapter As FinagilDS1TableAdapters.CodigosSAT_ConceptoTableAdapter
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbPago As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoCambio As System.Windows.Forms.Label
    Friend WithEvents ProductionDS As Facturador33.ProductionDS
    Friend WithEvents lblFechaAplica As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblFormapago As System.Windows.Forms.Label
    Friend WithEvents TxtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents CFDI_UsosCFDIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CFDI_UsosCFDITableAdapter As Facturador33.ProductionDSTableAdapters.CFDI_UsosCFDITableAdapter
    Friend WithEvents cmbUsoCfdi As System.Windows.Forms.ComboBox
    Friend WithEvents txtUsoClave As System.Windows.Forms.TextBox
    Friend WithEvents txtMoral As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RDArfin As System.Windows.Forms.RadioButton
    Friend WithEvents RDFinagil As System.Windows.Forms.RadioButton
    Friend WithEvents txbFolioFiscal As System.Windows.Forms.TextBox
    Friend WithEvents lblFolioFiscal As System.Windows.Forms.Label
    Friend WithEvents CfdI_ComplementoPagoTableAdapter As Facturador33.ProductionDSTableAdapters.CFDI_ComplementoPagoTableAdapter
    Friend WithEvents FacturasExternasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents FacturasExternasTableAdapter1 As Facturador33.ProductionDSTableAdapters.FacturasExternasTableAdapter
    Friend WithEvents LbSerie As Label
    Friend WithEvents TxtSerieCFDI As TextBox
    Friend WithEvents LbFolioCFDI As Label
    Friend WithEvents TxtFolioCFDI As TextBox
    Friend WithEvents CfdI_EncabezadoTableAdapter As ProductionDSTableAdapters.CFDI_EncabezadoTableAdapter
    Friend WithEvents LbCli As Label
    Friend WithEvents CFDIEncabezadoBindingSource As BindingSource
    Friend WithEvents TxtImporteFact As TextBox
    Friend WithEvents CkDoctoRel As CheckBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtUnidadInterna As TextBox
    Friend WithEvents SerieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConsecDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Unidad As DataGridViewTextBoxColumn
    Friend WithEvents UnidadInterna As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonedaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TasaIvaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MunicipioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RFCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Mail1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Mail2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTotalX As DataGridViewTextBoxColumn
    Friend WithEvents MetodoPago As DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As DataGridViewTextBoxColumn
    Friend WithEvents btnCreaClientes As Button
    Friend WithEvents Clientes_ARFINBindingSource As BindingSource
    Friend WithEvents Clientes_ARFINTableAdapter As FinagilDS1TableAdapters.Clientes_ARFINTableAdapter
    Friend WithEvents ClientesARFINBindingSource As BindingSource
    Friend WithEvents TxtRSocial As TextBox
    Friend WithEvents DescrTextBox As TextBox
    Friend WithEvents EMail2TextBox As TextBox
    Friend WithEvents EMail1TextBox As TextBox
    Friend WithEvents RFCTextBox As TextBox
    Friend WithEvents CoposTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents DelegacionTextBox As TextBox
    Friend WithEvents ColoniaTextBox As TextBox
    Friend WithEvents CalleTextBox As TextBox
    Friend WithEvents _29_FormaPagoTextBox As TextBox
    Friend WithEvents chkFormato As CheckBox
End Class
