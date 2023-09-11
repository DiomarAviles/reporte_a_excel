<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERSONASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRACTICA_XDDataSet = New reporte_a_excel.PRACTICA_XDDataSet()
        Me.PERSONASTableAdapter = New reporte_a_excel.PRACTICA_XDDataSetTableAdapters.PERSONASTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRACTICA_XDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.APELLIDODataGridViewTextBoxColumn, Me.NUMERODataGridViewTextBoxColumn, Me.CORREDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PERSONASBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 244)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        '
        'APELLIDODataGridViewTextBoxColumn
        '
        Me.APELLIDODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO"
        Me.APELLIDODataGridViewTextBoxColumn.HeaderText = "APELLIDO"
        Me.APELLIDODataGridViewTextBoxColumn.Name = "APELLIDODataGridViewTextBoxColumn"
        '
        'NUMERODataGridViewTextBoxColumn
        '
        Me.NUMERODataGridViewTextBoxColumn.DataPropertyName = "NUMERO"
        Me.NUMERODataGridViewTextBoxColumn.HeaderText = "NUMERO"
        Me.NUMERODataGridViewTextBoxColumn.Name = "NUMERODataGridViewTextBoxColumn"
        '
        'CORREDataGridViewTextBoxColumn
        '
        Me.CORREDataGridViewTextBoxColumn.DataPropertyName = "CORRE"
        Me.CORREDataGridViewTextBoxColumn.HeaderText = "CORRE"
        Me.CORREDataGridViewTextBoxColumn.Name = "CORREDataGridViewTextBoxColumn"
        '
        'PERSONASBindingSource
        '
        Me.PERSONASBindingSource.DataMember = "PERSONAS"
        Me.PERSONASBindingSource.DataSource = Me.PRACTICA_XDDataSet
        '
        'PRACTICA_XDDataSet
        '
        Me.PRACTICA_XDDataSet.DataSetName = "PRACTICA_XDDataSet"
        Me.PRACTICA_XDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERSONASTableAdapter
        '
        Me.PERSONASTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(407, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 444)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRACTICA_XDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PRACTICA_XDDataSet As PRACTICA_XDDataSet
    Friend WithEvents PERSONASBindingSource As BindingSource
    Friend WithEvents PERSONASTableAdapter As PRACTICA_XDDataSetTableAdapters.PERSONASTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMERODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CORREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
