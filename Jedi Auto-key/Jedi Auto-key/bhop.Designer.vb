<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bhop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bhop))
        Me.tmrbhop = New System.Windows.Forms.Timer(Me.components)
        Me.btnstart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblhopcount = New System.Windows.Forms.Label()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HotkeysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartStopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrbhop
        '
        Me.tmrbhop.Interval = 50
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(13, 26)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(75, 23)
        Me.btnstart.TabIndex = 0
        Me.btnstart.Text = "Start/Stop"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hops:"
        '
        'lblhopcount
        '
        Me.lblhopcount.AutoSize = True
        Me.lblhopcount.Location = New System.Drawing.Point(126, 31)
        Me.lblhopcount.Name = "lblhopcount"
        Me.lblhopcount.Size = New System.Drawing.Size(13, 13)
        Me.lblhopcount.TabIndex = 2
        Me.lblhopcount.Text = "0"
        '
        'btnmenu
        '
        Me.btnmenu.Location = New System.Drawing.Point(13, 55)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(75, 23)
        Me.btnmenu.TabIndex = 3
        Me.btnmenu.Text = "Menu"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 59)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Note: You cannot get VAC banned from using this, however Overwatch can still dete" &
    "ct it if your not careful"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HotkeysToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(268, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
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
        Me.StartStopToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.StartStopToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.StartStopToolStripMenuItem.Text = "Start/Stop"
        '
        'bhop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(268, 188)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnmenu)
        Me.Controls.Add(Me.lblhopcount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "bhop"
        Me.Text = "bhop"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrbhop As Timer
    Friend WithEvents btnstart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblhopcount As Label
    Friend WithEvents btnmenu As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HotkeysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartStopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
