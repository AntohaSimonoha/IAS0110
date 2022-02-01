<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGui
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtInputText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOutputText1 = New System.Windows.Forms.TextBox()
        Me.txtOutputText2 = New System.Windows.Forms.TextBox()
        Me.btnInvert1 = New System.Windows.Forms.Button()
        Me.btnInvert2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInputText
        '
        Me.txtInputText.Location = New System.Drawing.Point(394, 95)
        Me.txtInputText.Name = "txtInputText"
        Me.txtInputText.Size = New System.Drawing.Size(292, 26)
        Me.txtInputText.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Input text:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Inverted output (func. ):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Inverted output (proc. ):"
        '
        'txtOutputText1
        '
        Me.txtOutputText1.Location = New System.Drawing.Point(394, 166)
        Me.txtOutputText1.Name = "txtOutputText1"
        Me.txtOutputText1.Size = New System.Drawing.Size(292, 26)
        Me.txtOutputText1.TabIndex = 4
        '
        'txtOutputText2
        '
        Me.txtOutputText2.Location = New System.Drawing.Point(394, 297)
        Me.txtOutputText2.Name = "txtOutputText2"
        Me.txtOutputText2.Size = New System.Drawing.Size(292, 26)
        Me.txtOutputText2.TabIndex = 5
        '
        'btnInvert1
        '
        Me.btnInvert1.Location = New System.Drawing.Point(394, 210)
        Me.btnInvert1.Name = "btnInvert1"
        Me.btnInvert1.Size = New System.Drawing.Size(111, 36)
        Me.btnInvert1.TabIndex = 6
        Me.btnInvert1.Text = "Invert (func. )"
        Me.btnInvert1.UseVisualStyleBackColor = True
        '
        'btnInvert2
        '
        Me.btnInvert2.Location = New System.Drawing.Point(394, 344)
        Me.btnInvert2.Name = "btnInvert2"
        Me.btnInvert2.Size = New System.Drawing.Size(111, 36)
        Me.btnInvert2.TabIndex = 7
        Me.btnInvert2.Text = "Invert (proc. )"
        Me.btnInvert2.UseVisualStyleBackColor = True
        '
        'FormGui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnInvert2)
        Me.Controls.Add(Me.btnInvert1)
        Me.Controls.Add(Me.txtOutputText2)
        Me.Controls.Add(Me.txtOutputText1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInputText)
        Me.Name = "FormGui"
        Me.Text = "Text_machine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInputText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOutputText1 As TextBox
    Friend WithEvents txtOutputText2 As TextBox
    Friend WithEvents btnInvert1 As Button
    Friend WithEvents btnInvert2 As Button
End Class
