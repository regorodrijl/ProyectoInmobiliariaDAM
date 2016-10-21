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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.nom = New System.Windows.Forms.Label()
        Me.op = New System.Windows.Forms.OpenFileDialog()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.Lis = New System.Windows.Forms.ListBox()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(2, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(2, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'nom
        '
        Me.nom.AutoSize = True
        Me.nom.Location = New System.Drawing.Point(245, 311)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(39, 13)
        Me.nom.TabIndex = 2
        Me.nom.Text = "Label1"
        '
        'op
        '
        Me.op.FileName = "OpenFileDialog1"
        '
        'Pic
        '
        Me.Pic.BackColor = System.Drawing.Color.White
        Me.Pic.Location = New System.Drawing.Point(224, 12)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(406, 296)
        Me.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic.TabIndex = 4
        Me.Pic.TabStop = False
        '
        'Lis
        '
        Me.Lis.FormattingEnabled = True
        Me.Lis.Location = New System.Drawing.Point(99, 12)
        Me.Lis.Name = "Lis"
        Me.Lis.Size = New System.Drawing.Size(119, 290)
        Me.Lis.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 333)
        Me.Controls.Add(Me.Lis)
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents nom As System.Windows.Forms.Label
    Friend WithEvents op As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Lis As System.Windows.Forms.ListBox

End Class
