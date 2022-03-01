<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formKujundid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtKylgA = New System.Windows.Forms.TextBox()
        Me.txtKylgB = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKorgus = New System.Windows.Forms.TextBox()
        Me.lblKylgB = New System.Windows.Forms.Label()
        Me.lblKylgA = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRoopkylik = New System.Windows.Forms.Button()
        Me.btnRomb = New System.Windows.Forms.Button()
        Me.btnRistkylik = New System.Windows.Forms.Button()
        Me.btnRuut = New System.Windows.Forms.Button()
        Me.btnKolmnurk = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTyyp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPindala = New System.Windows.Forms.TextBox()
        Me.txtYmbermoot = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.numKorgus = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numKorgus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKylgA
        '
        Me.txtKylgA.Location = New System.Drawing.Point(37, 46)
        Me.txtKylgA.Name = "txtKylgA"
        Me.txtKylgA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKylgA.Size = New System.Drawing.Size(147, 26)
        Me.txtKylgA.TabIndex = 0
        Me.txtKylgA.Tag = ""
        '
        'txtKylgB
        '
        Me.txtKylgB.Location = New System.Drawing.Point(37, 89)
        Me.txtKylgB.Name = "txtKylgB"
        Me.txtKylgB.Size = New System.Drawing.Size(147, 26)
        Me.txtKylgB.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numKorgus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblKylgB)
        Me.GroupBox1.Controls.Add(Me.lblKylgA)
        Me.GroupBox1.Controls.Add(Me.txtKylgA)
        Me.GroupBox1.Controls.Add(Me.txtKylgB)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 131)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algandmed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "H="
        '
        'txtKorgus
        '
        Me.txtKorgus.Location = New System.Drawing.Point(490, 318)
        Me.txtKorgus.Name = "txtKorgus"
        Me.txtKorgus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKorgus.Size = New System.Drawing.Size(147, 26)
        Me.txtKorgus.TabIndex = 4
        Me.txtKorgus.Tag = ""
        '
        'lblKylgB
        '
        Me.lblKylgB.AutoSize = True
        Me.lblKylgB.Location = New System.Drawing.Point(6, 92)
        Me.lblKylgB.Name = "lblKylgB"
        Me.lblKylgB.Size = New System.Drawing.Size(29, 20)
        Me.lblKylgB.TabIndex = 3
        Me.lblKylgB.Text = "B="
        '
        'lblKylgA
        '
        Me.lblKylgA.AutoSize = True
        Me.lblKylgA.Location = New System.Drawing.Point(6, 49)
        Me.lblKylgA.Name = "lblKylgA"
        Me.lblKylgA.Size = New System.Drawing.Size(29, 20)
        Me.lblKylgA.TabIndex = 2
        Me.lblKylgA.Text = "A="
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRoopkylik)
        Me.GroupBox2.Controls.Add(Me.btnRomb)
        Me.GroupBox2.Controls.Add(Me.btnRistkylik)
        Me.GroupBox2.Controls.Add(Me.btnRuut)
        Me.GroupBox2.Controls.Add(Me.btnKolmnurk)
        Me.GroupBox2.Location = New System.Drawing.Point(466, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 247)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kujundid"
        '
        'btnRoopkylik
        '
        Me.btnRoopkylik.Location = New System.Drawing.Point(96, 193)
        Me.btnRoopkylik.Name = "btnRoopkylik"
        Me.btnRoopkylik.Size = New System.Drawing.Size(111, 36)
        Me.btnRoopkylik.TabIndex = 6
        Me.btnRoopkylik.Text = "Rööpkülik"
        Me.btnRoopkylik.UseVisualStyleBackColor = True
        '
        'btnRomb
        '
        Me.btnRomb.Location = New System.Drawing.Point(96, 151)
        Me.btnRomb.Name = "btnRomb"
        Me.btnRomb.Size = New System.Drawing.Size(111, 36)
        Me.btnRomb.TabIndex = 6
        Me.btnRomb.Text = "Romb"
        Me.btnRomb.UseVisualStyleBackColor = True
        '
        'btnRistkylik
        '
        Me.btnRistkylik.Location = New System.Drawing.Point(96, 109)
        Me.btnRistkylik.Name = "btnRistkylik"
        Me.btnRistkylik.Size = New System.Drawing.Size(111, 36)
        Me.btnRistkylik.TabIndex = 6
        Me.btnRistkylik.Text = "Ristkülik"
        Me.btnRistkylik.UseVisualStyleBackColor = True
        '
        'btnRuut
        '
        Me.btnRuut.Location = New System.Drawing.Point(96, 67)
        Me.btnRuut.Name = "btnRuut"
        Me.btnRuut.Size = New System.Drawing.Size(111, 36)
        Me.btnRuut.TabIndex = 5
        Me.btnRuut.Text = "Ruut"
        Me.btnRuut.UseVisualStyleBackColor = True
        '
        'btnKolmnurk
        '
        Me.btnKolmnurk.Location = New System.Drawing.Point(96, 25)
        Me.btnKolmnurk.Name = "btnKolmnurk"
        Me.btnKolmnurk.Size = New System.Drawing.Size(111, 36)
        Me.btnKolmnurk.TabIndex = 4
        Me.btnKolmnurk.Text = "Kolmnurk"
        Me.btnKolmnurk.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTyyp)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtPindala)
        Me.GroupBox3.Controls.Add(Me.txtYmbermoot)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 262)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(409, 162)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tulemused"
        '
        'lblTyyp
        '
        Me.lblTyyp.AutoSize = True
        Me.lblTyyp.Location = New System.Drawing.Point(112, 39)
        Me.lblTyyp.Name = "lblTyyp"
        Me.lblTyyp.Size = New System.Drawing.Size(90, 20)
        Me.lblTyyp.TabIndex = 9
        Me.lblTyyp.Text = "määramata"
        Me.lblTyyp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Kujundi tüüp:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Pindala"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ümbermõõt"
        '
        'txtPindala
        '
        Me.txtPindala.Location = New System.Drawing.Point(109, 116)
        Me.txtPindala.Name = "txtPindala"
        Me.txtPindala.Size = New System.Drawing.Size(147, 26)
        Me.txtPindala.TabIndex = 5
        '
        'txtYmbermoot
        '
        Me.txtYmbermoot.Location = New System.Drawing.Point(109, 74)
        Me.txtYmbermoot.Name = "txtYmbermoot"
        Me.txtYmbermoot.Size = New System.Drawing.Size(147, 26)
        Me.txtYmbermoot.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "0"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.ComboBox1.Location = New System.Drawing.Point(59, 198)
        Me.ComboBox1.MaxDropDownItems = 4
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(147, 28)
        Me.ComboBox1.TabIndex = 5
        '
        'numKorgus
        '
        Me.numKorgus.Location = New System.Drawing.Point(246, 46)
        Me.numKorgus.Name = "numKorgus"
        Me.numKorgus.Size = New System.Drawing.Size(120, 26)
        Me.numKorgus.TabIndex = 6
        '
        'formKujundid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtKorgus)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formKujundid"
        Me.Text = "Kujundid"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.numKorgus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKylgA As TextBox
    Friend WithEvents txtKylgB As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblKylgB As Label
    Friend WithEvents lblKylgA As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnRoopkylik As Button
    Friend WithEvents btnRomb As Button
    Friend WithEvents btnRistkylik As Button
    Friend WithEvents btnRuut As Button
    Friend WithEvents btnKolmnurk As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPindala As TextBox
    Friend WithEvents txtYmbermoot As TextBox
    Friend WithEvents lblTyyp As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKorgus As TextBox
    Friend WithEvents numKorgus As NumericUpDown
End Class
