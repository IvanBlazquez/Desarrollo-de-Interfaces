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
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoCoralistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElaborarListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(507, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoCoralistaToolStripMenuItem, Me.ElaborarListaToolStripMenuItem, Me.VerListaToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'NuevoCoralistaToolStripMenuItem
        '
        Me.NuevoCoralistaToolStripMenuItem.Name = "NuevoCoralistaToolStripMenuItem"
        Me.NuevoCoralistaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NuevoCoralistaToolStripMenuItem.Text = "Nuevo Coralista"
        '
        'ElaborarListaToolStripMenuItem
        '
        Me.ElaborarListaToolStripMenuItem.Name = "ElaborarListaToolStripMenuItem"
        Me.ElaborarListaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ElaborarListaToolStripMenuItem.Text = "Elaborar Lista"
        '
        'VerListaToolStripMenuItem
        '
        Me.VerListaToolStripMenuItem.Name = "VerListaToolStripMenuItem"
        Me.VerListaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerListaToolStripMenuItem.Text = "Ver Lista"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 405)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoCoralistaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ElaborarListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerListaToolStripMenuItem As ToolStripMenuItem
End Class
