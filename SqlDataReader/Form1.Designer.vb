<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarProductos
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
        Me.btnListarProductos = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnListarProductos
        '
        Me.btnListarProductos.Location = New System.Drawing.Point(136, 24)
        Me.btnListarProductos.Name = "btnListarProductos"
        Me.btnListarProductos.Size = New System.Drawing.Size(75, 23)
        Me.btnListarProductos.TabIndex = 0
        Me.btnListarProductos.Text = "Listar Productos"
        Me.btnListarProductos.UseVisualStyleBackColor = True
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(13, 53)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(320, 196)
        Me.dgvProductos.TabIndex = 1
        '
        'frmListarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 261)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.btnListarProductos)
        Me.Name = "frmListarProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar Productos"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnListarProductos As Button
    Friend WithEvents dgvProductos As DataGridView
End Class
