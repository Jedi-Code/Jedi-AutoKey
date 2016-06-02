<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Custom
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Custom))
        Me.tmrrun = New System.Windows.Forms.Timer(Me.components)
        Me.tbxstring = New System.Windows.Forms.TextBox()
        Me.tbxinterval = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblexe = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.tmrstop = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HotkeysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartStopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrrun
        '
        '
        'tbxstring
        '
        Me.tbxstring.Location = New System.Drawing.Point(180, 53)
        Me.tbxstring.Name = "tbxstring"
        Me.tbxstring.Size = New System.Drawing.Size(80, 20)
        Me.tbxstring.TabIndex = 1
        Me.tbxstring.Text = "Sample"
        '
        'tbxinterval
        '
        Me.tbxinterval.AllowDrop = True
        Me.tbxinterval.Location = New System.Drawing.Point(207, 34)
        Me.tbxinterval.Multiline = True
        Me.tbxinterval.Name = "tbxinterval"
        Me.tbxinterval.Size = New System.Drawing.Size(48, 20)
        Me.tbxinterval.TabIndex = 2
        Me.tbxinterval.Text = "100"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "# of executes:"
        '
        'lblexe
        '
        Me.lblexe.AutoSize = True
        Me.lblexe.Location = New System.Drawing.Point(84, 59)
        Me.lblexe.Name = "lblexe"
        Me.lblexe.Size = New System.Drawing.Size(13, 13)
        Me.lblexe.TabIndex = 4
        Me.lblexe.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Text"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(140, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Interval(ms)"
        '
        'btnmenu
        '
        Me.btnmenu.Location = New System.Drawing.Point(185, 79)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(75, 23)
        Me.btnmenu.TabIndex = 7
        Me.btnmenu.Text = "Menu"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'tmrstop
        '
        Me.tmrstop.Interval = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HotkeysToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(263, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HotkeysToolStripMenuItem
        '
        Me.HotkeysToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartStopToolStripMenuItem})
        Me.HotkeysToolStripMenuItem.Name = "HotkeysToolStripMenuItem"
        Me.HotkeysToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.HotkeysToolStripMenuItem.Text = "Hotkeys"
        '
        'StartStopToolStripMenuItem
        '
        Me.StartStopToolStripMenuItem.Name = "StartStopToolStripMenuItem"
        Me.StartStopToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.StartStopToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.StartStopToolStripMenuItem.Text = "Start/Stop"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "CTRL + C to start"
        '
        'Custom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(263, 261)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblexe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxinterval)
        Me.Controls.Add(Me.tbxstring)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Custom"
        Me.Text = "Custom"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrrun As Timer
    Friend WithEvents tbxstring As TextBox
    Friend WithEvents tbxinterval As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblexe As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnmenu As Button
    Friend WithEvents tmrstop As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HotkeysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartStopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
End Class
