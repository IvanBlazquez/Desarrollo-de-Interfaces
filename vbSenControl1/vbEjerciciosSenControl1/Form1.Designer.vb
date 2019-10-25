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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EjerciciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejer1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejer2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejer3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EjerciciosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(426, 35)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EjerciciosToolStripMenuItem
        '
        Me.EjerciciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejer1ToolStripMenuItem, Me.Ejer2ToolStripMenuItem, Me.Ejer3ToolStripMenuItem})
        Me.EjerciciosToolStripMenuItem.Name = "EjerciciosToolStripMenuItem"
        Me.EjerciciosToolStripMenuItem.Size = New System.Drawing.Size(95, 29)
        Me.EjerciciosToolStripMenuItem.Text = "Ejercicios"
        '
        'Ejer1ToolStripMenuItem
        '
        Me.Ejer1ToolStripMenuItem.Name = "Ejer1ToolStripMenuItem"
        Me.Ejer1ToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.Ejer1ToolStripMenuItem.Text = "Ejer1"
        '
        'Ejer2ToolStripMenuItem
        '
        Me.Ejer2ToolStripMenuItem.Name = "Ejer2ToolStripMenuItem"
        Me.Ejer2ToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.Ejer2ToolStripMenuItem.Text = "Ejer2"
        '
        'Ejer3ToolStripMenuItem
        '
        Me.Ejer3ToolStripMenuItem.Name = "Ejer3ToolStripMenuItem"
        Me.Ejer3ToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.Ejer3ToolStripMenuItem.Text = "Ejer3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 402)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EjerciciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejer1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejer2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejer3ToolStripMenuItem As ToolStripMenuItem
End Class
