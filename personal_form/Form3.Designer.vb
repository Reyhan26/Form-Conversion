<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.l3 = New System.Windows.Forms.Label()
        Me.l2 = New System.Windows.Forms.Label()
        Me.l1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'l3
        '
        Me.l3.BackColor = System.Drawing.Color.Transparent
        Me.l3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.ForeColor = System.Drawing.Color.White
        Me.l3.Location = New System.Drawing.Point(51, 215)
        Me.l3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(477, 55)
        Me.l3.TabIndex = 5
        Me.l3.Text = "<>"
        '
        'l2
        '
        Me.l2.BackColor = System.Drawing.Color.Transparent
        Me.l2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.ForeColor = System.Drawing.Color.White
        Me.l2.Location = New System.Drawing.Point(51, 133)
        Me.l2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(224, 54)
        Me.l2.TabIndex = 4
        Me.l2.Text = "<>"
        '
        'l1
        '
        Me.l1.BackColor = System.Drawing.Color.Transparent
        Me.l1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.White
        Me.l1.Location = New System.Drawing.Point(51, 42)
        Me.l1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(477, 58)
        Me.l1.TabIndex = 3
        Me.l1.Text = "<>"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = Global.personal_form.My.Resources.Resources.imgonline_com_ua_resize_FGFglYqvFOaX37a6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(682, 453)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.l1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form3"
        Me.Text = "XML"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents l3 As Label
    Friend WithEvents l2 As Label
    Friend WithEvents l1 As Label
End Class
