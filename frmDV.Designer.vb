<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDV
    Inherits VBLibrary.VB6Form


#Region "Static constructor"

' This static constructor ensures that the VB6 support library be initialized before using current class.
Shared Sub New()
    EnsureVB6LibraryInitialization()
End Sub

#End Region

#Region "Windows Form Designer generated code "

    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'Create all controls and control arrays.
        InitializeComponents()
    End Sub

    ' This method wraps the call to InitializeComponent, but can be called from base class.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overrides Sub InitializeComponents()
        Me.ObjectIsInitializing = True
        InitializeComponent()
        Me.ObjectIsInitializing = False
    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then
                If components IsNot Nothing Then components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents txtRIC As VBLibrary.VB6TextBox
    Public WithEvents cmdCalcularRIC As VBLibrary.VB6CommandButton
    Public WithEvents cmdCalcularRG As VBLibrary.VB6CommandButton
    Public WithEvents txtRG As VBLibrary.VB6TextBox
    Public WithEvents lblDUVIDA As VBLibrary.VB6Label
    Public WithEvents lblATENCAO As VBLibrary.VB6Label
    Public WithEvents lblRIC As VBLibrary.VB6Label
    Public WithEvents lblDVRIC As VBLibrary.VB6Label
    Public WithEvents lblDVRG As VBLibrary.VB6Label
    Public WithEvents lblRG As VBLibrary.VB6Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDV))
        Me.txtRIC = New VBLibrary.VB6TextBox()
        Me.cmdCalcularRIC = New VBLibrary.VB6CommandButton()
        Me.cmdCalcularRG = New VBLibrary.VB6CommandButton()
        Me.txtRG = New VBLibrary.VB6TextBox()
        Me.lblDUVIDA = New VBLibrary.VB6Label()
        Me.lblATENCAO = New VBLibrary.VB6Label()
        Me.lblRIC = New VBLibrary.VB6Label()
        Me.lblDVRIC = New VBLibrary.VB6Label()
        Me.lblDVRG = New VBLibrary.VB6Label()
        Me.lblRG = New VBLibrary.VB6Label()
        Me.SuspendLayout()
        '
        'txtRIC
        '
        Me.txtRIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRIC.Location = New System.Drawing.Point(40, 276)
        Me.txtRIC.MaxLength = 10
        Me.txtRIC.Name = "txtRIC"
        Me.txtRIC.Size = New System.Drawing.Size(73, 20)
        Me.txtRIC.TabIndex = 5
        Me.txtRIC.Text = "1234567890"
        '
        'cmdCalcularRIC
        '
        Me.cmdCalcularRIC.BackColor = System.Drawing.Color.Silver
        Me.cmdCalcularRIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalcularRIC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalcularRIC.Location = New System.Drawing.Point(12, 304)
        Me.cmdCalcularRIC.Name = "cmdCalcularRIC"
        Me.cmdCalcularRIC.Size = New System.Drawing.Size(133, 21)
        Me.cmdCalcularRIC.TabIndex = 4
        Me.cmdCalcularRIC.Text = "&Calcular DV do RIC"
        Me.cmdCalcularRIC.UseVisualStyleBackColor = False
        '
        'cmdCalcularRG
        '
        Me.cmdCalcularRG.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCalcularRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalcularRG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalcularRG.Location = New System.Drawing.Point(20, 36)
        Me.cmdCalcularRG.Name = "cmdCalcularRG"
        Me.cmdCalcularRG.Size = New System.Drawing.Size(113, 33)
        Me.cmdCalcularRG.TabIndex = 2
        Me.cmdCalcularRG.Text = "&Calcular DV do RG"
        Me.cmdCalcularRG.UseVisualStyleBackColor = False
        '
        'txtRG
        '
        Me.txtRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRG.Location = New System.Drawing.Point(48, 8)
        Me.txtRG.MaxLength = 8
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(57, 20)
        Me.txtRG.TabIndex = 0
        Me.txtRG.Text = "42943412"
        '
        'lblDUVIDA
        '
        Me.lblDUVIDA.BackColor = System.Drawing.SystemColors.Control
        Me.lblDUVIDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDUVIDA.ForeColor = System.Drawing.Color.Blue
        Me.lblDUVIDA.Location = New System.Drawing.Point(12, 212)
        Me.lblDUVIDA.Name = "lblDUVIDA"
        Me.lblDUVIDA.Size = New System.Drawing.Size(129, 57)
        Me.lblDUVIDA.TabIndex = 9
        Me.lblDUVIDA.Text = "Dúvida! Como tratamos os restos """"0"""", """"1"""" e """"10""""? Exemplo: No RG, resto """"10" & _
    """"" é dígito """"X""""."
        '
        'lblATENCAO
        '
        Me.lblATENCAO.BackColor = System.Drawing.SystemColors.Control
        Me.lblATENCAO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblATENCAO.ForeColor = System.Drawing.Color.Red
        Me.lblATENCAO.Location = New System.Drawing.Point(12, 72)
        Me.lblATENCAO.Name = "lblATENCAO"
        Me.lblATENCAO.Size = New System.Drawing.Size(129, 133)
        Me.lblATENCAO.TabIndex = 8
        Me.lblATENCAO.Text = resources.GetString("lblATENCAO.Text")
        '
        'lblRIC
        '
        Me.lblRIC.BackColor = System.Drawing.SystemColors.Control
        Me.lblRIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRIC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRIC.Location = New System.Drawing.Point(12, 280)
        Me.lblRIC.Name = "lblRIC"
        Me.lblRIC.Size = New System.Drawing.Size(25, 17)
        Me.lblRIC.TabIndex = 7
        Me.lblRIC.Text = "RIC:"
        '
        'lblDVRIC
        '
        Me.lblDVRIC.BackColor = System.Drawing.SystemColors.Control
        Me.lblDVRIC.BorderStyle = VBLibrary.VB6BorderStyleConstants.FixedSingle
        Me.lblDVRIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDVRIC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDVRIC.Location = New System.Drawing.Point(120, 276)
        Me.lblDVRIC.Name = "lblDVRIC"
        Me.lblDVRIC.Size = New System.Drawing.Size(21, 23)
        Me.lblDVRIC.TabIndex = 6
        Me.lblDVRIC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDVRG
        '
        Me.lblDVRG.BackColor = System.Drawing.SystemColors.Control
        Me.lblDVRG.BorderStyle = VBLibrary.VB6BorderStyleConstants.FixedSingle
        Me.lblDVRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDVRG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDVRG.Location = New System.Drawing.Point(112, 8)
        Me.lblDVRG.Name = "lblDVRG"
        Me.lblDVRG.Size = New System.Drawing.Size(21, 23)
        Me.lblDVRG.TabIndex = 3
        Me.lblDVRG.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRG
        '
        Me.lblRG.BackColor = System.Drawing.SystemColors.Control
        Me.lblRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRG.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRG.Location = New System.Drawing.Point(20, 12)
        Me.lblRG.Name = "lblRG"
        Me.lblRG.Size = New System.Drawing.Size(25, 17)
        Me.lblRG.TabIndex = 1
        Me.lblRG.Text = "RG:"
        '
        'frmDV
        '
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorderStyle = VBLibrary.VBRUN.FormBorderStyleConstants.vbFixedSingle
        Me.ClientSize = New System.Drawing.Size(154, 333)
        Me.Controls.Add(Me.txtRIC)
        Me.Controls.Add(Me.cmdCalcularRIC)
        Me.Controls.Add(Me.cmdCalcularRG)
        Me.Controls.Add(Me.txtRG)
        Me.Controls.Add(Me.lblDUVIDA)
        Me.Controls.Add(Me.lblATENCAO)
        Me.Controls.Add(Me.lblRIC)
        Me.Controls.Add(Me.lblDVRIC)
        Me.Controls.Add(Me.lblDVRG)
        Me.Controls.Add(Me.lblRG)
        Me.DrawMode = VBLibrary.VBRUN.DrawModeConstants.vbCopyPen
        Me.DrawStyle = VBLibrary.VBRUN.DrawStyleConstants.vbSolid
        Me.FillStyle = VBLibrary.VBRUN.FillStyleConstants.vbFSTransparent
        Me.Location = New System.Drawing.Point(699, 283)
        Me.MaxButton = False
        Me.MinButton = False
        Me.MinimizeBox = False
        Me.MousePointer = VBLibrary.VBRUN.MousePointerConstants.vbDefault
        Me.Name = "frmDV"
        Me.OLEDropMode = VBLibrary.VBRUN.OLEDropConstants.vbOLEDropNone
        Me.ScaleMode = VBLibrary.VBRUN.ScaleModeConstants.vbTwips
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cálculo do DV"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


End Class
