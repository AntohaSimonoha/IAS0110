﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnSmile = New System.Windows.Forms.Button()
        Me.btnStar = New System.Windows.Forms.Button()
        Me.btnTeeth = New System.Windows.Forms.Button()
        Me.btnYell = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.UCtrlEmotion1 = New PrjFaces.UCtrlEmotion()
        Me.UBulbCtrl1 = New UBulb.UBulbCtrl()
        Me.USwitchCtrl1 = New USwitch.USwitchCtrl()
        Me.SuspendLayout()
        '
        'btnConfused
        '
        Me.btnConfused.Location = New System.Drawing.Point(539, 57)
        Me.btnConfused.Name = "btnConfused"
        Me.btnConfused.Size = New System.Drawing.Size(110, 42)
        Me.btnConfused.TabIndex = 1
        Me.btnConfused.Text = "Confused"
        Me.btnConfused.UseVisualStyleBackColor = True
        '
        'btnCool
        '
        Me.btnCool.Location = New System.Drawing.Point(539, 108)
        Me.btnCool.Name = "btnCool"
        Me.btnCool.Size = New System.Drawing.Size(110, 42)
        Me.btnCool.TabIndex = 2
        Me.btnCool.Text = "Cool"
        Me.btnCool.UseVisualStyleBackColor = True
        '
        'btnSmile
        '
        Me.btnSmile.Location = New System.Drawing.Point(539, 156)
        Me.btnSmile.Name = "btnSmile"
        Me.btnSmile.Size = New System.Drawing.Size(110, 42)
        Me.btnSmile.TabIndex = 3
        Me.btnSmile.Text = "Smile"
        Me.btnSmile.UseVisualStyleBackColor = True
        '
        'btnStar
        '
        Me.btnStar.Location = New System.Drawing.Point(539, 204)
        Me.btnStar.Name = "btnStar"
        Me.btnStar.Size = New System.Drawing.Size(110, 42)
        Me.btnStar.TabIndex = 4
        Me.btnStar.Text = "Star"
        Me.btnStar.UseVisualStyleBackColor = True
        '
        'btnTeeth
        '
        Me.btnTeeth.Location = New System.Drawing.Point(539, 252)
        Me.btnTeeth.Name = "btnTeeth"
        Me.btnTeeth.Size = New System.Drawing.Size(110, 42)
        Me.btnTeeth.TabIndex = 5
        Me.btnTeeth.Text = "Teeth"
        Me.btnTeeth.UseVisualStyleBackColor = True
        '
        'btnYell
        '
        Me.btnYell.Location = New System.Drawing.Point(539, 300)
        Me.btnYell.Name = "btnYell"
        Me.btnYell.Size = New System.Drawing.Size(110, 42)
        Me.btnYell.TabIndex = 6
        Me.btnYell.Text = "Yell"
        Me.btnYell.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(539, 348)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 42)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'UCtrlEmotion1
        '
        Me.UCtrlEmotion1.Location = New System.Drawing.Point(12, 12)
        Me.UCtrlEmotion1.Name = "UCtrlEmotion1"
        Me.UCtrlEmotion1.Size = New System.Drawing.Size(128, 128)
        Me.UCtrlEmotion1.TabIndex = 0
        '
        'UBulbCtrl1
        '
        Me.UBulbCtrl1.Location = New System.Drawing.Point(170, 12)
        Me.UBulbCtrl1.Name = "UBulbCtrl1"
        Me.UBulbCtrl1.Size = New System.Drawing.Size(287, 320)
        Me.UBulbCtrl1.TabIndex = 10
        '
        'USwitchCtrl1
        '
        Me.USwitchCtrl1.Location = New System.Drawing.Point(170, 364)
        Me.USwitchCtrl1.Name = "USwitchCtrl1"
        Me.USwitchCtrl1.Size = New System.Drawing.Size(226, 82)
        Me.USwitchCtrl1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 458)
        Me.Controls.Add(Me.USwitchCtrl1)
        Me.Controls.Add(Me.UBulbCtrl1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnYell)
        Me.Controls.Add(Me.btnTeeth)
        Me.Controls.Add(Me.btnStar)
        Me.Controls.Add(Me.btnSmile)
        Me.Controls.Add(Me.btnCool)
        Me.Controls.Add(Me.btnConfused)
        Me.Controls.Add(Me.UCtrlEmotion1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UCtrlEmotion1 As PrjFaces.UCtrlEmotion
    Friend WithEvents btnConfused As Button
    Friend WithEvents btnCool As Button
    Friend WithEvents btnSmile As Button
    Friend WithEvents btnStar As Button
    Friend WithEvents btnTeeth As Button
    Friend WithEvents btnYell As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents UBulbCtrl1 As UBulb.UBulbCtrl
    Friend WithEvents USwitchCtrl1 As USwitch.USwitchCtrl
End Class