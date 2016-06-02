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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnbhop = New System.Windows.Forms.Button()
        Me.btncustom = New System.Windows.Forms.Button()
        Me.btni = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnbhop
        '
        Me.btnbhop.Location = New System.Drawing.Point(12, 12)
        Me.btnbhop.Name = "btnbhop"
        Me.btnbhop.Size = New System.Drawing.Size(75, 23)
        Me.btnbhop.TabIndex = 0
        Me.btnbhop.Text = "CSGO Bhop"
        Me.btnbhop.UseVisualStyleBackColor = True
        '
        'btncustom
        '
        Me.btncustom.Location = New System.Drawing.Point(12, 41)
        Me.btncustom.Name = "btncustom"
        Me.btncustom.Size = New System.Drawing.Size(75, 23)
        Me.btncustom.TabIndex = 1
        Me.btncustom.Text = "Custom"
        Me.btncustom.UseVisualStyleBackColor = True
        '
        'btni
        '
        Me.btni.Location = New System.Drawing.Point(12, 70)
        Me.btni.Name = "btni"
        Me.btni.Size = New System.Drawing.Size(75, 23)
        Me.btni.TabIndex = 2
        Me.btni.Text = "About/Help"
        Me.btni.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btni)
        Me.Controls.Add(Me.btncustom)
        Me.Controls.Add(Me.btnbhop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnbhop As Button
    Friend WithEvents btncustom As Button
    Friend WithEvents btni As Button
End Class
