<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GPDatos = New System.Windows.Forms.GroupBox()
        Me.LBCarnet = New System.Windows.Forms.Label()
        Me.TBCarnet = New System.Windows.Forms.TextBox()
        Me.LBNombre = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.DATAFecha = New System.Windows.Forms.DateTimePicker()
        Me.LBFecha = New System.Windows.Forms.Label()
        Me.GPIdiomas = New System.Windows.Forms.GroupBox()
        Me.LBHoras = New System.Windows.Forms.Label()
        Me.CBDias = New System.Windows.Forms.ComboBox()
        Me.TBHoras = New System.Windows.Forms.TextBox()
        Me.LBDias = New System.Windows.Forms.Label()
        Me.CBIdioma = New System.Windows.Forms.ComboBox()
        Me.LBIdioma = New System.Windows.Forms.Label()
        Me.GPPago = New System.Windows.Forms.GroupBox()
        Me.RBCheque = New System.Windows.Forms.RadioButton()
        Me.RBEfectivo = New System.Windows.Forms.RadioButton()
        Me.DTResultados = New System.Windows.Forms.DataGridView()
        Me.DBRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBCarnet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBIdioma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBDias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBHoras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBDescuentoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBDescuentoDias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TSAgregar = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSLimpiar = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSSalir = New System.Windows.Forms.ToolStripLabel()
        Me.TSOpciones = New System.Windows.Forms.ToolStrip()
        Me.GPDatos.SuspendLayout()
        Me.GPIdiomas.SuspendLayout()
        Me.GPPago.SuspendLayout()
        CType(Me.DTResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TSOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'GPDatos
        '
        Me.GPDatos.Controls.Add(Me.LBCarnet)
        Me.GPDatos.Controls.Add(Me.TBCarnet)
        Me.GPDatos.Controls.Add(Me.LBNombre)
        Me.GPDatos.Controls.Add(Me.TBNombre)
        Me.GPDatos.Controls.Add(Me.DATAFecha)
        Me.GPDatos.Controls.Add(Me.LBFecha)
        Me.GPDatos.Location = New System.Drawing.Point(12, 39)
        Me.GPDatos.Name = "GPDatos"
        Me.GPDatos.Size = New System.Drawing.Size(468, 152)
        Me.GPDatos.TabIndex = 1
        Me.GPDatos.TabStop = False
        Me.GPDatos.Text = "Datos del Estudiante"
        '
        'LBCarnet
        '
        Me.LBCarnet.AutoSize = True
        Me.LBCarnet.Location = New System.Drawing.Point(69, 74)
        Me.LBCarnet.Name = "LBCarnet"
        Me.LBCarnet.Size = New System.Drawing.Size(56, 17)
        Me.LBCarnet.TabIndex = 3
        Me.LBCarnet.Text = "Carnet"
        '
        'TBCarnet
        '
        Me.TBCarnet.Location = New System.Drawing.Point(142, 71)
        Me.TBCarnet.Name = "TBCarnet"
        Me.TBCarnet.Size = New System.Drawing.Size(303, 25)
        Me.TBCarnet.TabIndex = 2
        Me.TBCarnet.Text = "0"
        '
        'LBNombre
        '
        Me.LBNombre.AutoSize = True
        Me.LBNombre.Location = New System.Drawing.Point(59, 43)
        Me.LBNombre.Name = "LBNombre"
        Me.LBNombre.Size = New System.Drawing.Size(66, 17)
        Me.LBNombre.TabIndex = 1
        Me.LBNombre.Text = "Nombre"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(142, 35)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(303, 25)
        Me.TBNombre.TabIndex = 0
        '
        'DATAFecha
        '
        Me.DATAFecha.Font = New System.Drawing.Font("HP Simplified", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATAFecha.Location = New System.Drawing.Point(197, 109)
        Me.DATAFecha.Name = "DATAFecha"
        Me.DATAFecha.Size = New System.Drawing.Size(248, 23)
        Me.DATAFecha.TabIndex = 4
        '
        'LBFecha
        '
        Me.LBFecha.AutoSize = True
        Me.LBFecha.Location = New System.Drawing.Point(20, 109)
        Me.LBFecha.Name = "LBFecha"
        Me.LBFecha.Size = New System.Drawing.Size(159, 17)
        Me.LBFecha.TabIndex = 5
        Me.LBFecha.Text = "Fecha de Inscripcion"
        '
        'GPIdiomas
        '
        Me.GPIdiomas.Controls.Add(Me.LBHoras)
        Me.GPIdiomas.Controls.Add(Me.CBDias)
        Me.GPIdiomas.Controls.Add(Me.TBHoras)
        Me.GPIdiomas.Controls.Add(Me.LBDias)
        Me.GPIdiomas.Controls.Add(Me.CBIdioma)
        Me.GPIdiomas.Controls.Add(Me.LBIdioma)
        Me.GPIdiomas.Location = New System.Drawing.Point(486, 39)
        Me.GPIdiomas.Name = "GPIdiomas"
        Me.GPIdiomas.Size = New System.Drawing.Size(441, 152)
        Me.GPIdiomas.TabIndex = 2
        Me.GPIdiomas.TabStop = False
        Me.GPIdiomas.Text = "Datos del Curso"
        '
        'LBHoras
        '
        Me.LBHoras.AutoSize = True
        Me.LBHoras.Location = New System.Drawing.Point(81, 105)
        Me.LBHoras.Name = "LBHoras"
        Me.LBHoras.Size = New System.Drawing.Size(50, 17)
        Me.LBHoras.TabIndex = 5
        Me.LBHoras.Text = "Horas"
        '
        'CBDias
        '
        Me.CBDias.ForeColor = System.Drawing.SystemColors.GrayText
        Me.CBDias.FormattingEnabled = True
        Me.CBDias.Items.AddRange(New Object() {"Viernes", "Sabado", "Ambos Dias"})
        Me.CBDias.Location = New System.Drawing.Point(152, 69)
        Me.CBDias.Name = "CBDias"
        Me.CBDias.Size = New System.Drawing.Size(248, 25)
        Me.CBDias.TabIndex = 7
        Me.CBDias.Text = "Seleccione Los Dias"
        '
        'TBHoras
        '
        Me.TBHoras.Location = New System.Drawing.Point(152, 102)
        Me.TBHoras.Name = "TBHoras"
        Me.TBHoras.Size = New System.Drawing.Size(248, 25)
        Me.TBHoras.TabIndex = 4
        Me.TBHoras.Text = "0"
        '
        'LBDias
        '
        Me.LBDias.AutoSize = True
        Me.LBDias.Location = New System.Drawing.Point(91, 77)
        Me.LBDias.Name = "LBDias"
        Me.LBDias.Size = New System.Drawing.Size(40, 17)
        Me.LBDias.TabIndex = 6
        Me.LBDias.Text = "Dias"
        '
        'CBIdioma
        '
        Me.CBIdioma.ForeColor = System.Drawing.SystemColors.GrayText
        Me.CBIdioma.FormattingEnabled = True
        Me.CBIdioma.Items.AddRange(New Object() {"Ingles", "Portugues", "Frances"})
        Me.CBIdioma.Location = New System.Drawing.Point(154, 35)
        Me.CBIdioma.Name = "CBIdioma"
        Me.CBIdioma.Size = New System.Drawing.Size(248, 25)
        Me.CBIdioma.TabIndex = 1
        Me.CBIdioma.Text = "Seleccione Un Idioma"
        '
        'LBIdioma
        '
        Me.LBIdioma.AutoSize = True
        Me.LBIdioma.Location = New System.Drawing.Point(80, 43)
        Me.LBIdioma.Name = "LBIdioma"
        Me.LBIdioma.Size = New System.Drawing.Size(59, 17)
        Me.LBIdioma.TabIndex = 0
        Me.LBIdioma.Text = "Idioma"
        '
        'GPPago
        '
        Me.GPPago.Controls.Add(Me.RBCheque)
        Me.GPPago.Controls.Add(Me.RBEfectivo)
        Me.GPPago.Location = New System.Drawing.Point(935, 39)
        Me.GPPago.Name = "GPPago"
        Me.GPPago.Size = New System.Drawing.Size(245, 152)
        Me.GPPago.TabIndex = 3
        Me.GPPago.TabStop = False
        Me.GPPago.Text = "Forma de Pago"
        '
        'RBCheque
        '
        Me.RBCheque.AutoSize = True
        Me.RBCheque.Location = New System.Drawing.Point(55, 84)
        Me.RBCheque.Name = "RBCheque"
        Me.RBCheque.Size = New System.Drawing.Size(80, 21)
        Me.RBCheque.TabIndex = 1
        Me.RBCheque.TabStop = True
        Me.RBCheque.Text = "Cheque"
        Me.RBCheque.UseVisualStyleBackColor = True
        '
        'RBEfectivo
        '
        Me.RBEfectivo.AutoSize = True
        Me.RBEfectivo.Location = New System.Drawing.Point(55, 43)
        Me.RBEfectivo.Name = "RBEfectivo"
        Me.RBEfectivo.Size = New System.Drawing.Size(86, 21)
        Me.RBEfectivo.TabIndex = 0
        Me.RBEfectivo.TabStop = True
        Me.RBEfectivo.Text = "Efectivo"
        Me.RBEfectivo.UseVisualStyleBackColor = True
        '
        'DTResultados
        '
        Me.DTResultados.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DTResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DBRegistro, Me.DBNombre, Me.DBCarnet, Me.DBIdioma, Me.DBFecha, Me.DBDias, Me.DBHoras, Me.DBSubtotal, Me.DBDescuentoPago, Me.DBDescuentoDias, Me.DBTotal})
        Me.DTResultados.EnableHeadersVisualStyles = False
        Me.DTResultados.Location = New System.Drawing.Point(2, 233)
        Me.DTResultados.Name = "DTResultados"
        Me.DTResultados.Size = New System.Drawing.Size(1215, 313)
        Me.DTResultados.TabIndex = 4
        '
        'DBRegistro
        '
        Me.DBRegistro.FillWeight = 1.0!
        Me.DBRegistro.HeaderText = "No. Registro"
        Me.DBRegistro.MinimumWidth = 2
        Me.DBRegistro.Name = "DBRegistro"
        Me.DBRegistro.Width = 75
        '
        'DBNombre
        '
        Me.DBNombre.HeaderText = "Nombre"
        Me.DBNombre.Name = "DBNombre"
        Me.DBNombre.Width = 150
        '
        'DBCarnet
        '
        Me.DBCarnet.HeaderText = "Carnet"
        Me.DBCarnet.Name = "DBCarnet"
        Me.DBCarnet.Width = 75
        '
        'DBIdioma
        '
        Me.DBIdioma.HeaderText = "Idioma"
        Me.DBIdioma.Name = "DBIdioma"
        '
        'DBFecha
        '
        Me.DBFecha.HeaderText = "Fecha De Inscripcion"
        Me.DBFecha.Name = "DBFecha"
        Me.DBFecha.Width = 180
        '
        'DBDias
        '
        Me.DBDias.HeaderText = "Dias"
        Me.DBDias.Name = "DBDias"
        Me.DBDias.Width = 120
        '
        'DBHoras
        '
        Me.DBHoras.HeaderText = "Horas"
        Me.DBHoras.Name = "DBHoras"
        Me.DBHoras.Width = 50
        '
        'DBSubtotal
        '
        Me.DBSubtotal.HeaderText = "Subtotal"
        Me.DBSubtotal.Name = "DBSubtotal"
        Me.DBSubtotal.Width = 110
        '
        'DBDescuentoPago
        '
        Me.DBDescuentoPago.HeaderText = "Descuento Pago"
        Me.DBDescuentoPago.Name = "DBDescuentoPago"
        Me.DBDescuentoPago.Width = 110
        '
        'DBDescuentoDias
        '
        Me.DBDescuentoDias.HeaderText = "Descuento Por Ambos Dias"
        Me.DBDescuentoDias.Name = "DBDescuentoDias"
        '
        'DBTotal
        '
        Me.DBTotal.HeaderText = "Total"
        Me.DBTotal.Name = "DBTotal"
        Me.DBTotal.Width = 102
        '
        'TSAgregar
        '
        Me.TSAgregar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSAgregar.Name = "TSAgregar"
        Me.TSAgregar.Size = New System.Drawing.Size(57, 22)
        Me.TSAgregar.Text = "Agregar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TSLimpiar
        '
        Me.TSLimpiar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSLimpiar.Name = "TSLimpiar"
        Me.TSLimpiar.Size = New System.Drawing.Size(55, 22)
        Me.TSLimpiar.Text = "Limpiar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TSSalir
        '
        Me.TSSalir.ActiveLinkColor = System.Drawing.Color.Salmon
        Me.TSSalir.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TSSalir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSalir.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TSSalir.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TSSalir.Name = "TSSalir"
        Me.TSSalir.Size = New System.Drawing.Size(35, 22)
        Me.TSSalir.Text = "Salir"
        Me.TSSalir.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'TSOpciones
        '
        Me.TSOpciones.BackColor = System.Drawing.Color.DarkKhaki
        Me.TSOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSAgregar, Me.ToolStripSeparator1, Me.TSLimpiar, Me.ToolStripSeparator2, Me.TSSalir})
        Me.TSOpciones.Location = New System.Drawing.Point(0, 0)
        Me.TSOpciones.Name = "TSOpciones"
        Me.TSOpciones.Size = New System.Drawing.Size(1219, 25)
        Me.TSOpciones.TabIndex = 0
        Me.TSOpciones.Text = "ToolStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(1219, 539)
        Me.Controls.Add(Me.DTResultados)
        Me.Controls.Add(Me.GPPago)
        Me.Controls.Add(Me.GPIdiomas)
        Me.Controls.Add(Me.GPDatos)
        Me.Controls.Add(Me.TSOpciones)
        Me.Font = New System.Drawing.Font("HP Simplified Hans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IDIOMAS"
        Me.GPDatos.ResumeLayout(False)
        Me.GPDatos.PerformLayout()
        Me.GPIdiomas.ResumeLayout(False)
        Me.GPIdiomas.PerformLayout()
        Me.GPPago.ResumeLayout(False)
        Me.GPPago.PerformLayout()
        CType(Me.DTResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TSOpciones.ResumeLayout(False)
        Me.TSOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GPDatos As GroupBox
    Friend WithEvents LBCarnet As Label
    Friend WithEvents TBCarnet As TextBox
    Friend WithEvents LBNombre As Label
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents GPIdiomas As GroupBox
    Friend WithEvents LBHoras As Label
    Friend WithEvents CBDias As ComboBox
    Friend WithEvents TBHoras As TextBox
    Friend WithEvents LBDias As Label
    Friend WithEvents LBFecha As Label
    Friend WithEvents DATAFecha As DateTimePicker
    Friend WithEvents CBIdioma As ComboBox
    Friend WithEvents LBIdioma As Label
    Friend WithEvents GPPago As GroupBox
    Friend WithEvents RBCheque As RadioButton
    Friend WithEvents RBEfectivo As RadioButton
    Friend WithEvents DTResultados As DataGridView
    Friend WithEvents DBRegistro As DataGridViewTextBoxColumn
    Friend WithEvents DBNombre As DataGridViewTextBoxColumn
    Friend WithEvents DBCarnet As DataGridViewTextBoxColumn
    Friend WithEvents DBIdioma As DataGridViewTextBoxColumn
    Friend WithEvents DBFecha As DataGridViewTextBoxColumn
    Friend WithEvents DBDias As DataGridViewTextBoxColumn
    Friend WithEvents DBHoras As DataGridViewTextBoxColumn
    Friend WithEvents DBSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents DBDescuentoPago As DataGridViewTextBoxColumn
    Friend WithEvents DBDescuentoDias As DataGridViewTextBoxColumn
    Friend WithEvents DBTotal As DataGridViewTextBoxColumn
    Friend WithEvents TSAgregar As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TSLimpiar As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TSSalir As ToolStripLabel
    Friend WithEvents TSOpciones As ToolStrip
End Class
