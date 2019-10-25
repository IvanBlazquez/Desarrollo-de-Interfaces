<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejer2
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
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAños = New System.Windows.Forms.TextBox()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstAños = New System.Windows.Forms.ListBox()
        Me.lstCapital = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btCalcular = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Capital Inicial"
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(24, 46)
        Me.txtCapital.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.Size = New System.Drawing.Size(148, 26)
        Me.txtCapital.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "% internes"
        '
        'txtAños
        '
        Me.txtAños.Location = New System.Drawing.Point(176, 154)
        Me.txtAños.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAños.Name = "txtAños"
        Me.txtAños.Size = New System.Drawing.Size(92, 26)
        Me.txtAños.TabIndex = 3
        '
        'txtInteres
        '
        Me.txtInteres.Location = New System.Drawing.Point(18, 154)
        Me.txtInteres.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(103, 26)
        Me.txtInteres.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Años"
        '
        'lstAños
        '
        Me.lstAños.FormattingEnabled = True
        Me.lstAños.ItemHeight = 20
        Me.lstAños.Location = New System.Drawing.Point(314, 46)
        Me.lstAños.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstAños.Name = "lstAños"
        Me.lstAños.Size = New System.Drawing.Size(145, 224)
        Me.lstAños.TabIndex = 6
        '
        'lstCapital
        '
        Me.lstCapital.FormattingEnabled = True
        Me.lstCapital.ItemHeight = 20
        Me.lstCapital.Location = New System.Drawing.Point(470, 46)
        Me.lstCapital.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstCapital.Name = "lstCapital"
        Me.lstCapital.Size = New System.Drawing.Size(145, 224)
        Me.lstCapital.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(322, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Años"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(465, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Capital"
        '
        'btCalcular
        '
        Me.btCalcular.Location = New System.Drawing.Point(314, 283)
        Me.btCalcular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btCalcular.Name = "btCalcular"
        Me.btCalcular.Size = New System.Drawing.Size(112, 35)
        Me.btCalcular.TabIndex = 10
        Me.btCalcular.Text = "Calcular"
        Me.btCalcular.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(504, 283)
        Me.btSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(112, 35)
        Me.btSalir.TabIndex = 11
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'Ejer2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 346)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btCalcular)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstCapital)
        Me.Controls.Add(Me.lstAños)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtInteres)
        Me.Controls.Add(Me.txtAños)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCapital)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Ejer2"
        Me.Text = "Ejer2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCapital As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAños As TextBox
    Friend WithEvents txtInteres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstAños As ListBox
    Friend WithEvents lstCapital As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btCalcular As Button
    Friend WithEvents btSalir As Button
End Class
