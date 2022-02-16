<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConfused = New System.Windows.Forms.Button()
        Me.btnCool = New System.Windows.Forms.Button()
        Me.btnStar = New System.Windows.Forms.Button()
        Me.btnSmile = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnYell = New System.Windows.Forms.Button()
        Me.btnTeeth = New System.Windows.Forms.Button()
        Me.UBulbCtrl1 = New UBulb.UBulbCtrl()
        Me.USwitchCtrl1 = New USwitch.USwitchCtrl()
        Me.UCtrlEmotion1 = New PrjFaces.UCtrlEmotion()
        Me.SuspendLayout()
        '
        'btnConfused
        '
        Me.btnConfused.Location = New System.Drawing.Point(663, 53)
        Me.btnConfused.Name = "btnConfused"
        Me.btnConfused.Size = New System.Drawing.Size(108, 36)
        Me.btnConfused.TabIndex = 3
        Me.btnConfused.Text = "Confused"
        Me.btnConfused.UseVisualStyleBackColor = True
        '
        'btnCool
        '
        Me.btnCool.Location = New System.Drawing.Point(663, 95)
        Me.btnCool.Name = "btnCool"
        Me.btnCool.Size = New System.Drawing.Size(108, 36)
        Me.btnCool.TabIndex = 4
        Me.btnCool.Text = "Cool"
        Me.btnCool.UseVisualStyleBackColor = True
        '
        'btnStar
        '
        Me.btnStar.Location = New System.Drawing.Point(663, 179)
        Me.btnStar.Name = "btnStar"
        Me.btnStar.Size = New System.Drawing.Size(108, 36)
        Me.btnStar.TabIndex = 6
        Me.btnStar.Text = "Star"
        Me.btnStar.UseVisualStyleBackColor = True
        '
        'btnSmile
        '
        Me.btnSmile.Location = New System.Drawing.Point(663, 137)
        Me.btnSmile.Name = "btnSmile"
        Me.btnSmile.Size = New System.Drawing.Size(108, 36)
        Me.btnSmile.TabIndex = 5
        Me.btnSmile.Text = "Smile"
        Me.btnSmile.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(663, 305)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 36)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnYell
        '
        Me.btnYell.Location = New System.Drawing.Point(663, 263)
        Me.btnYell.Name = "btnYell"
        Me.btnYell.Size = New System.Drawing.Size(108, 36)
        Me.btnYell.TabIndex = 8
        Me.btnYell.Text = "Yell"
        Me.btnYell.UseVisualStyleBackColor = True
        '
        'btnTeeth
        '
        Me.btnTeeth.Location = New System.Drawing.Point(663, 221)
        Me.btnTeeth.Name = "btnTeeth"
        Me.btnTeeth.Size = New System.Drawing.Size(108, 36)
        Me.btnTeeth.TabIndex = 7
        Me.btnTeeth.Text = "Teeth"
        Me.btnTeeth.UseVisualStyleBackColor = True
        '
        'UBulbCtrl1
        '
        Me.UBulbCtrl1.Location = New System.Drawing.Point(205, 3)
        Me.UBulbCtrl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UBulbCtrl1.Name = "UBulbCtrl1"
        Me.UBulbCtrl1.Size = New System.Drawing.Size(263, 434)
        Me.UBulbCtrl1.TabIndex = 2
        '
        'USwitchCtrl1
        '
        Me.USwitchCtrl1.Location = New System.Drawing.Point(12, 335)
        Me.USwitchCtrl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.USwitchCtrl1.Name = "USwitchCtrl1"
        Me.USwitchCtrl1.Size = New System.Drawing.Size(187, 102)
        Me.USwitchCtrl1.TabIndex = 1
        '
        'UCtrlEmotion1
        '
        Me.UCtrlEmotion1.Location = New System.Drawing.Point(12, 13)
        Me.UCtrlEmotion1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UCtrlEmotion1.Name = "UCtrlEmotion1"
        Me.UCtrlEmotion1.Size = New System.Drawing.Size(144, 160)
        Me.UCtrlEmotion1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnYell)
        Me.Controls.Add(Me.btnTeeth)
        Me.Controls.Add(Me.btnStar)
        Me.Controls.Add(Me.btnSmile)
        Me.Controls.Add(Me.btnCool)
        Me.Controls.Add(Me.btnConfused)
        Me.Controls.Add(Me.UBulbCtrl1)
        Me.Controls.Add(Me.USwitchCtrl1)
        Me.Controls.Add(Me.UCtrlEmotion1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UCtrlEmotion1 As PrjFaces.UCtrlEmotion
    Friend WithEvents USwitchCtrl1 As USwitch.USwitchCtrl
    Friend WithEvents UBulbCtrl1 As UBulb.UBulbCtrl
    Friend WithEvents btnConfused As Button
    Friend WithEvents btnCool As Button
    Friend WithEvents btnStar As Button
    Friend WithEvents btnSmile As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnYell As Button
    Friend WithEvents btnTeeth As Button
End Class
