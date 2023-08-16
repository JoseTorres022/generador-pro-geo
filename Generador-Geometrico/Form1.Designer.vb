<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenProGeo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenProGeo))
        Me.LB1_PrimerNumero = New System.Windows.Forms.Label()
        Me.LB2_RadioComun = New System.Windows.Forms.Label()
        Me.LB3_NoTerminos = New System.Windows.Forms.Label()
        Me.TB1_PrimerNumero = New System.Windows.Forms.TextBox()
        Me.TB_RadioComun = New System.Windows.Forms.TextBox()
        Me.TB3_NoTerminos = New System.Windows.Forms.TextBox()
        Me.BT_CalcDatos = New System.Windows.Forms.Button()
        Me.LBOX1_VistaGenerada = New System.Windows.Forms.ListBox()
        Me.BT2_CerrarApp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LB1_PrimerNumero
        '
        resources.ApplyResources(Me.LB1_PrimerNumero, "LB1_PrimerNumero")
        Me.LB1_PrimerNumero.Name = "LB1_PrimerNumero"
        '
        'LB2_RadioComun
        '
        resources.ApplyResources(Me.LB2_RadioComun, "LB2_RadioComun")
        Me.LB2_RadioComun.Name = "LB2_RadioComun"
        '
        'LB3_NoTerminos
        '
        resources.ApplyResources(Me.LB3_NoTerminos, "LB3_NoTerminos")
        Me.LB3_NoTerminos.Name = "LB3_NoTerminos"
        '
        'TB1_PrimerNumero
        '
        resources.ApplyResources(Me.TB1_PrimerNumero, "TB1_PrimerNumero")
        Me.TB1_PrimerNumero.Name = "TB1_PrimerNumero"
        '
        'TB_RadioComun
        '
        resources.ApplyResources(Me.TB_RadioComun, "TB_RadioComun")
        Me.TB_RadioComun.Name = "TB_RadioComun"
        '
        'TB3_NoTerminos
        '
        resources.ApplyResources(Me.TB3_NoTerminos, "TB3_NoTerminos")
        Me.TB3_NoTerminos.Name = "TB3_NoTerminos"
        '
        'BT_CalcDatos
        '
        resources.ApplyResources(Me.BT_CalcDatos, "BT_CalcDatos")
        Me.BT_CalcDatos.Name = "BT_CalcDatos"
        Me.BT_CalcDatos.UseVisualStyleBackColor = True
        '
        'LBOX1_VistaGenerada
        '
        Me.LBOX1_VistaGenerada.FormattingEnabled = True
        resources.ApplyResources(Me.LBOX1_VistaGenerada, "LBOX1_VistaGenerada")
        Me.LBOX1_VistaGenerada.Name = "LBOX1_VistaGenerada"
        '
        'BT2_CerrarApp
        '
        resources.ApplyResources(Me.BT2_CerrarApp, "BT2_CerrarApp")
        Me.BT2_CerrarApp.Name = "BT2_CerrarApp"
        Me.BT2_CerrarApp.UseVisualStyleBackColor = True
        '
        'GenProGeo
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BT2_CerrarApp)
        Me.Controls.Add(Me.LBOX1_VistaGenerada)
        Me.Controls.Add(Me.BT_CalcDatos)
        Me.Controls.Add(Me.TB3_NoTerminos)
        Me.Controls.Add(Me.TB_RadioComun)
        Me.Controls.Add(Me.TB1_PrimerNumero)
        Me.Controls.Add(Me.LB3_NoTerminos)
        Me.Controls.Add(Me.LB2_RadioComun)
        Me.Controls.Add(Me.LB1_PrimerNumero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GenProGeo"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LB1_PrimerNumero As Label
    Friend WithEvents LB2_RadioComun As Label
    Friend WithEvents LB3_NoTerminos As Label
    Friend WithEvents TB1_PrimerNumero As TextBox
    Friend WithEvents TB_RadioComun As TextBox
    Friend WithEvents TB3_NoTerminos As TextBox
    Friend WithEvents BT_CalcDatos As Button
    Friend WithEvents LBOX1_VistaGenerada As ListBox
    Friend WithEvents BT2_CerrarApp As Button
End Class
