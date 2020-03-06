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
        Me.components = New System.ComponentModel.Container()
        Me.btn_x = New System.Windows.Forms.Button()
        Me.btn_j = New System.Windows.Forms.Button()
        Me.label_name = New System.Windows.Forms.Label()
        Me.label_age = New System.Windows.Forms.Label()
        Me.label_address = New System.Windows.Forms.Label()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.tb_a = New System.Windows.Forms.TextBox()
        Me.tb_d = New System.Windows.Forms.TextBox()
        Me.btn_txt = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btn_x
        '
        Me.btn_x.BackColor = System.Drawing.Color.Transparent
        Me.btn_x.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_x.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btn_x.FlatAppearance.BorderSize = 5
        Me.btn_x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn_x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_x.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_x.Font = New System.Drawing.Font("Kids Zone Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_x.ForeColor = System.Drawing.Color.White
        Me.btn_x.Location = New System.Drawing.Point(151, 396)
        Me.btn_x.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_x.Name = "btn_x"
        Me.btn_x.Size = New System.Drawing.Size(100, 44)
        Me.btn_x.TabIndex = 1
        Me.btn_x.Text = "XML"
        Me.btn_x.UseVisualStyleBackColor = False
        '
        'btn_j
        '
        Me.btn_j.BackColor = System.Drawing.Color.Transparent
        Me.btn_j.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_j.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btn_j.FlatAppearance.BorderSize = 5
        Me.btn_j.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn_j.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_j.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_j.Font = New System.Drawing.Font("Kids Zone Shadow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_j.ForeColor = System.Drawing.Color.Transparent
        Me.btn_j.Location = New System.Drawing.Point(259, 396)
        Me.btn_j.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_j.Name = "btn_j"
        Me.btn_j.Size = New System.Drawing.Size(100, 44)
        Me.btn_j.TabIndex = 2
        Me.btn_j.Text = "JSON"
        Me.btn_j.UseVisualStyleBackColor = False
        '
        'label_name
        '
        Me.label_name.AutoSize = True
        Me.label_name.BackColor = System.Drawing.Color.Transparent
        Me.label_name.Font = New System.Drawing.Font("Forte", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_name.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_name.Location = New System.Drawing.Point(36, 70)
        Me.label_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(119, 37)
        Me.label_name.TabIndex = 3
        Me.label_name.Text = "Name:"
        '
        'label_age
        '
        Me.label_age.AutoSize = True
        Me.label_age.BackColor = System.Drawing.Color.Transparent
        Me.label_age.Font = New System.Drawing.Font("Forte", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.label_age.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_age.Location = New System.Drawing.Point(36, 136)
        Me.label_age.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_age.Name = "label_age"
        Me.label_age.Size = New System.Drawing.Size(90, 37)
        Me.label_age.TabIndex = 4
        Me.label_age.Text = "Age:"
        Me.ToolTip1.SetToolTip(Me.label_age, "Please enter a valid input (number).")
        '
        'label_address
        '
        Me.label_address.AutoSize = True
        Me.label_address.BackColor = System.Drawing.Color.Transparent
        Me.label_address.Font = New System.Drawing.Font("Forte", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.label_address.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_address.Location = New System.Drawing.Point(36, 202)
        Me.label_address.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_address.Name = "label_address"
        Me.label_address.Size = New System.Drawing.Size(154, 37)
        Me.label_address.TabIndex = 5
        Me.label_address.Text = "Address:"
        '
        'tb_name
        '
        Me.tb_name.BackColor = System.Drawing.Color.DarkGray
        Me.tb_name.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.tb_name.ForeColor = System.Drawing.Color.Black
        Me.tb_name.Location = New System.Drawing.Point(406, 77)
        Me.tb_name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(263, 32)
        Me.tb_name.TabIndex = 6
        '
        'tb_a
        '
        Me.tb_a.BackColor = System.Drawing.Color.DarkGray
        Me.tb_a.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.tb_a.ForeColor = System.Drawing.Color.Black
        Me.tb_a.Location = New System.Drawing.Point(406, 143)
        Me.tb_a.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_a.Name = "tb_a"
        Me.tb_a.Size = New System.Drawing.Size(263, 32)
        Me.tb_a.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.tb_a, "Please enter a valid input (number)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'tb_d
        '
        Me.tb_d.BackColor = System.Drawing.Color.DarkGray
        Me.tb_d.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_d.ForeColor = System.Drawing.Color.Black
        Me.tb_d.Location = New System.Drawing.Point(406, 209)
        Me.tb_d.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_d.Name = "tb_d"
        Me.tb_d.Size = New System.Drawing.Size(263, 32)
        Me.tb_d.TabIndex = 8
        '
        'btn_txt
        '
        Me.btn_txt.BackColor = System.Drawing.Color.Transparent
        Me.btn_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_txt.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btn_txt.FlatAppearance.BorderSize = 5
        Me.btn_txt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn_txt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_txt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_txt.Font = New System.Drawing.Font("Kids Zone Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_txt.ForeColor = System.Drawing.Color.White
        Me.btn_txt.Location = New System.Drawing.Point(43, 396)
        Me.btn_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_txt.Name = "btn_txt"
        Me.btn_txt.Size = New System.Drawing.Size(100, 44)
        Me.btn_txt.TabIndex = 9
        Me.btn_txt.Text = "TXT"
        Me.btn_txt.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = Global.personal_form.My.Resources.Resources.imgonline_com_ua_resize_FGFglYqvFOaX37a6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(682, 453)
        Me.Controls.Add(Me.btn_txt)
        Me.Controls.Add(Me.tb_d)
        Me.Controls.Add(Me.tb_a)
        Me.Controls.Add(Me.tb_name)
        Me.Controls.Add(Me.label_address)
        Me.Controls.Add(Me.label_age)
        Me.Controls.Add(Me.label_name)
        Me.Controls.Add(Me.btn_j)
        Me.Controls.Add(Me.btn_x)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Convertion"
        Me.TransparencyKey = System.Drawing.Color.Silver
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_x As Button
    Friend WithEvents btn_j As Button
    Friend WithEvents label_name As Label
    Friend WithEvents label_age As Label
    Friend WithEvents label_address As Label
    Friend WithEvents tb_name As TextBox
    Friend WithEvents tb_a As TextBox
    Friend WithEvents tb_d As TextBox
    Friend WithEvents btn_txt As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
