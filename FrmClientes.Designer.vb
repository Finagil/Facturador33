<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientes
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
        Dim RFCLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim MunicipioLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CpLabel As System.Windows.Forms.Label
        Dim Email1Label As System.Windows.Forms.Label
        Dim Email2Label As System.Windows.Forms.Label
        Me.Clientes_ARFINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArfinDS = New Facturador33.ArfinDS()
        Me.Clientes_ARFINTableAdapter = New Facturador33.ArfinDSTableAdapters.Clientes_ARFINTableAdapter()
        Me.TableAdapterManager = New Facturador33.ArfinDSTableAdapters.TableAdapterManager()
        Me.RFCTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox()
        Me.MunicipioTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.CpTextBox = New System.Windows.Forms.TextBox()
        Me.Email1TextBox = New System.Windows.Forms.TextBox()
        Me.Email2TextBox = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        RFCLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ColoniaLabel = New System.Windows.Forms.Label()
        MunicipioLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CpLabel = New System.Windows.Forms.Label()
        Email1Label = New System.Windows.Forms.Label()
        Email2Label = New System.Windows.Forms.Label()
        CType(Me.Clientes_ARFINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArfinDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RFCLabel
        '
        RFCLabel.AutoSize = True
        RFCLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RFCLabel.Location = New System.Drawing.Point(15, 15)
        RFCLabel.Name = "RFCLabel"
        RFCLabel.Size = New System.Drawing.Size(35, 13)
        RFCLabel.TabIndex = 0
        RFCLabel.Text = "RFC:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(15, 41)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(54, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(15, 67)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(65, 13)
        DireccionLabel.TabIndex = 4
        DireccionLabel.Text = "Dirección:"
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColoniaLabel.Location = New System.Drawing.Point(15, 93)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(53, 13)
        ColoniaLabel.TabIndex = 6
        ColoniaLabel.Text = "Colonia:"
        '
        'MunicipioLabel
        '
        MunicipioLabel.AutoSize = True
        MunicipioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MunicipioLabel.Location = New System.Drawing.Point(15, 119)
        MunicipioLabel.Name = "MunicipioLabel"
        MunicipioLabel.Size = New System.Drawing.Size(65, 13)
        MunicipioLabel.TabIndex = 8
        MunicipioLabel.Text = "Municipio:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(418, 18)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(50, 13)
        EstadoLabel.TabIndex = 10
        EstadoLabel.Text = "Estado:"
        '
        'CpLabel
        '
        CpLabel.AutoSize = True
        CpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CpLabel.Location = New System.Drawing.Point(418, 41)
        CpLabel.Name = "CpLabel"
        CpLabel.Size = New System.Drawing.Size(27, 13)
        CpLabel.TabIndex = 12
        CpLabel.Text = "CP:"
        '
        'Email1Label
        '
        Email1Label.AutoSize = True
        Email1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email1Label.Location = New System.Drawing.Point(418, 67)
        Email1Label.Name = "Email1Label"
        Email1Label.Size = New System.Drawing.Size(51, 13)
        Email1Label.TabIndex = 14
        Email1Label.Text = "email 1:"
        '
        'Email2Label
        '
        Email2Label.AutoSize = True
        Email2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email2Label.Location = New System.Drawing.Point(418, 96)
        Email2Label.Name = "Email2Label"
        Email2Label.Size = New System.Drawing.Size(51, 13)
        Email2Label.TabIndex = 16
        Email2Label.Text = "email 2:"
        '
        'Clientes_ARFINBindingSource
        '
        Me.Clientes_ARFINBindingSource.DataMember = "Clientes_ARFIN"
        Me.Clientes_ARFINBindingSource.DataSource = Me.ArfinDS
        '
        'ArfinDS
        '
        Me.ArfinDS.DataSetName = "ArfinDS"
        Me.ArfinDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Clientes_ARFINTableAdapter
        '
        Me.Clientes_ARFINTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Clientes_ARFINTableAdapter = Me.Clientes_ARFINTableAdapter
        Me.TableAdapterManager.UpdateOrder = Facturador33.ArfinDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RFCTextBox
        '
        Me.RFCTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RFCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "RFC", True))
        Me.RFCTextBox.Location = New System.Drawing.Point(86, 12)
        Me.RFCTextBox.Name = "RFCTextBox"
        Me.RFCTextBox.Size = New System.Drawing.Size(136, 20)
        Me.RFCTextBox.TabIndex = 1
        '
        'NombreTextBox
        '
        Me.NombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(86, 38)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(302, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(86, 64)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(302, 20)
        Me.DireccionTextBox.TabIndex = 3
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "colonia", True))
        Me.ColoniaTextBox.Location = New System.Drawing.Point(86, 90)
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.Size = New System.Drawing.Size(302, 20)
        Me.ColoniaTextBox.TabIndex = 4
        '
        'MunicipioTextBox
        '
        Me.MunicipioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MunicipioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "municipio", True))
        Me.MunicipioTextBox.Location = New System.Drawing.Point(86, 116)
        Me.MunicipioTextBox.Name = "MunicipioTextBox"
        Me.MunicipioTextBox.Size = New System.Drawing.Size(136, 20)
        Me.MunicipioTextBox.TabIndex = 5
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(486, 15)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(278, 20)
        Me.EstadoTextBox.TabIndex = 6
        '
        'CpTextBox
        '
        Me.CpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "cp", True))
        Me.CpTextBox.Location = New System.Drawing.Point(486, 41)
        Me.CpTextBox.Name = "CpTextBox"
        Me.CpTextBox.Size = New System.Drawing.Size(278, 20)
        Me.CpTextBox.TabIndex = 7
        '
        'Email1TextBox
        '
        Me.Email1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "email1", True))
        Me.Email1TextBox.Location = New System.Drawing.Point(486, 67)
        Me.Email1TextBox.Name = "Email1TextBox"
        Me.Email1TextBox.Size = New System.Drawing.Size(278, 20)
        Me.Email1TextBox.TabIndex = 8
        '
        'Email2TextBox
        '
        Me.Email2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Clientes_ARFINBindingSource, "email2", True))
        Me.Email2TextBox.Location = New System.Drawing.Point(486, 93)
        Me.Email2TextBox.Name = "Email2TextBox"
        Me.Email2TextBox.Size = New System.Drawing.Size(278, 20)
        Me.Email2TextBox.TabIndex = 9
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(608, 166)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 10
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(689, 166)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(233, 167)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(314, 168)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(178, 20)
        Me.txtBuscar.TabIndex = 18
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 202)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Email2Label)
        Me.Controls.Add(Me.Email2TextBox)
        Me.Controls.Add(Email1Label)
        Me.Controls.Add(Me.Email1TextBox)
        Me.Controls.Add(CpLabel)
        Me.Controls.Add(Me.CpTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(MunicipioLabel)
        Me.Controls.Add(Me.MunicipioTextBox)
        Me.Controls.Add(ColoniaLabel)
        Me.Controls.Add(Me.ColoniaTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(RFCLabel)
        Me.Controls.Add(Me.RFCTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes ARFIN"
        CType(Me.Clientes_ARFINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArfinDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Clientes_ARFINBindingSource As BindingSource
    Friend WithEvents ArfinDS As ArfinDS
    Friend WithEvents Clientes_ARFINTableAdapter As ArfinDSTableAdapters.Clientes_ARFINTableAdapter
    Friend WithEvents TableAdapterManager As ArfinDSTableAdapters.TableAdapterManager
    Friend WithEvents RFCTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ColoniaTextBox As TextBox
    Friend WithEvents MunicipioTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents CpTextBox As TextBox
    Friend WithEvents Email1TextBox As TextBox
    Friend WithEvents Email2TextBox As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
End Class
