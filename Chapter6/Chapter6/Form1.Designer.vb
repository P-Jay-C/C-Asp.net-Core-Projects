<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.lblfirstname = New System.Windows.Forms.Label()
        Me.btndone = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(221, 55)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(100, 23)
        Me.txtfirstname.TabIndex = 0
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = true
        Me.lblfirstname.Location = New System.Drawing.Point(144, 63)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(72, 15)
        Me.lblfirstname.TabIndex = 1
        Me.lblfirstname.Text = "FIRST NAME"
        '
        'btndone
        '
        Me.btndone.Location = New System.Drawing.Point(47, 216)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(105, 48)
        Me.btndone.TabIndex = 2
        Me.btndone.Text = "DONE"
        Me.btndone.UseVisualStyleBackColor = true
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(271, 216)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(112, 48)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(143, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 4
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(221, 103)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(100, 23)
        Me.txtlastname.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(144, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "LAST  NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(144, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "GENDER"
        '
        'txtgender
        '
        Me.txtgender.Location = New System.Drawing.Point(221, 143)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(100, 23)
        Me.txtgender.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(398, 441)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btndone)
        Me.Controls.Add(Me.lblfirstname)
        Me.Controls.Add(Me.txtfirstname)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents lblfirstname As Label
    Friend WithEvents btndone As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtgender As TextBox
End Class
