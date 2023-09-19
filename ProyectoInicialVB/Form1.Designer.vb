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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrimerValortxt = New System.Windows.Forms.TextBox()
        Me.SegundoValortxt = New System.Windows.Forms.TextBox()
        Me.TercerValortxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCalculo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Promediotxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Borrarbtn = New System.Windows.Forms.Button()
        Me.Salirbtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Primer Valor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Segundo Valor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tercer Valor"
        '
        'PrimerValortxt
        '
        Me.PrimerValortxt.Location = New System.Drawing.Point(109, 32)
        Me.PrimerValortxt.Name = "PrimerValortxt"
        Me.PrimerValortxt.Size = New System.Drawing.Size(100, 20)
        Me.PrimerValortxt.TabIndex = 3
        '
        'SegundoValortxt
        '
        Me.SegundoValortxt.Location = New System.Drawing.Point(109, 71)
        Me.SegundoValortxt.Name = "SegundoValortxt"
        Me.SegundoValortxt.Size = New System.Drawing.Size(100, 20)
        Me.SegundoValortxt.TabIndex = 4
        '
        'TercerValortxt
        '
        Me.TercerValortxt.Location = New System.Drawing.Point(109, 110)
        Me.TercerValortxt.Name = "TercerValortxt"
        Me.TercerValortxt.Size = New System.Drawing.Size(100, 20)
        Me.TercerValortxt.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Borrarbtn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TercerValortxt)
        Me.GroupBox1.Controls.Add(Me.BtnCalculo)
        Me.GroupBox1.Controls.Add(Me.PrimerValortxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.SegundoValortxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 196)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los Valores"
        '
        'BtnCalculo
        '
        Me.BtnCalculo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCalculo.Location = New System.Drawing.Point(6, 167)
        Me.BtnCalculo.Name = "BtnCalculo"
        Me.BtnCalculo.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalculo.TabIndex = 7
        Me.BtnCalculo.Text = "Cálculo"
        Me.BtnCalculo.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Salirbtn)
        Me.GroupBox2.Controls.Add(Me.Promediotxt)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(279, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 110)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado de cálculo"
        '
        'Promediotxt
        '
        Me.Promediotxt.Location = New System.Drawing.Point(63, 35)
        Me.Promediotxt.Name = "Promediotxt"
        Me.Promediotxt.Size = New System.Drawing.Size(100, 20)
        Me.Promediotxt.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Promedio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(193, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Calcular el Promedio"
        '
        'Borrarbtn
        '
        Me.Borrarbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Borrarbtn.Location = New System.Drawing.Point(125, 167)
        Me.Borrarbtn.Name = "Borrarbtn"
        Me.Borrarbtn.Size = New System.Drawing.Size(73, 23)
        Me.Borrarbtn.TabIndex = 10
        Me.Borrarbtn.Text = "Borrar"
        Me.Borrarbtn.UseVisualStyleBackColor = False
        '
        'Salirbtn
        '
        Me.Salirbtn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Salirbtn.Location = New System.Drawing.Point(9, 81)
        Me.Salirbtn.Name = "Salirbtn"
        Me.Salirbtn.Size = New System.Drawing.Size(75, 23)
        Me.Salirbtn.TabIndex = 10
        Me.Salirbtn.Text = "Salir"
        Me.Salirbtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 291)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PrimerValortxt As TextBox
    Friend WithEvents SegundoValortxt As TextBox
    Friend WithEvents TercerValortxt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCalculo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Promediotxt As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Borrarbtn As Button
    Friend WithEvents Salirbtn As Button
End Class
