<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejer1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.btCal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "B"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(38, 62)
        Me.txtA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(52, 26)
        Me.txtA.TabIndex = 2
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(333, 62)
        Me.txtB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(52, 26)
        Me.txtB.TabIndex = 3
        '
        'btCal
        '
        Me.btCal.Location = New System.Drawing.Point(162, 348)
        Me.btCal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btCal.Name = "btCal"
        Me.btCal.Size = New System.Drawing.Size(112, 35)
        Me.btCal.TabIndex = 4
        Me.btCal.Text = "Calcular"
        Me.btCal.UseVisualStyleBackColor = True
        '
        'Ejer1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 402)
        Me.Controls.Add(Me.btCal)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Ejer1"
        Me.Text = "Ejer1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents btCal As Button
End Class
