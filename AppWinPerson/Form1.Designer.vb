<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonaFrm
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
        Me.GridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CountryID = New System.Windows.Forms.ComboBox()
        Me.TypeDocumentID = New System.Windows.Forms.ComboBox()
        Me.BirthDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Addres = New CustomControls.PersonTexBox()
        Me.PrincipalPhone = New CustomControls.PersonTexBox()
        Me.Name1 = New CustomControls.PersonTexBox()
        Me.DocumentID = New CustomControls.PersonTexBox()
        Me.SecondName = New CustomControls.PersonTexBox()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView
        '
        Me.GridView.AllowUserToAddRows = False
        Me.GridView.AllowUserToDeleteRows = False
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.ContextMenuStrip = Me.menu
        Me.GridView.Location = New System.Drawing.Point(12, 235)
        Me.GridView.Name = "GridView"
        Me.GridView.ReadOnly = True
        Me.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView.Size = New System.Drawing.Size(605, 213)
        Me.GridView.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BirthDate)
        Me.Panel1.Controls.Add(Me.CountryID)
        Me.Panel1.Controls.Add(Me.Addres)
        Me.Panel1.Controls.Add(Me.PrincipalPhone)
        Me.Panel1.Controls.Add(Me.TypeDocumentID)
        Me.Panel1.Controls.Add(Me.Name1)
        Me.Panel1.Controls.Add(Me.DocumentID)
        Me.Panel1.Controls.Add(Me.SecondName)
        Me.Panel1.Location = New System.Drawing.Point(30, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 217)
        Me.Panel1.TabIndex = 2
        '
        'CountryID
        '
        Me.CountryID.FormattingEnabled = True
        Me.CountryID.Location = New System.Drawing.Point(27, 125)
        Me.CountryID.Name = "CountryID"
        Me.CountryID.Size = New System.Drawing.Size(261, 21)
        Me.CountryID.TabIndex = 6
        '
        'TypeDocumentID
        '
        Me.TypeDocumentID.FormattingEnabled = True
        Me.TypeDocumentID.Location = New System.Drawing.Point(167, 100)
        Me.TypeDocumentID.Name = "TypeDocumentID"
        Me.TypeDocumentID.Size = New System.Drawing.Size(121, 21)
        Me.TypeDocumentID.TabIndex = 5
        '
        'BirthDate
        '
        Me.BirthDate.Location = New System.Drawing.Point(27, 165)
        Me.BirthDate.Name = "BirthDate"
        Me.BirthDate.Size = New System.Drawing.Size(261, 20)
        Me.BirthDate.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(24, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha de Cumpleaños"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(493, 187)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 28)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'menu
        '
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(118, 26)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Addres
        '
        Me.Addres.change = False
        Me.Addres.ForeColor = System.Drawing.Color.Gray
        Me.Addres.Location = New System.Drawing.Point(294, 22)
        Me.Addres.Multiline = True
        Me.Addres.Name = "Addres"
        Me.Addres.PlaceHolder = "Addres"
        Me.Addres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Addres.Size = New System.Drawing.Size(261, 163)
        Me.Addres.TabIndex = 8
        Me.Addres.Text = "Addres"
        Me.Addres.WordWrap = False
        '
        'PrincipalPhone
        '
        Me.PrincipalPhone.change = False
        Me.PrincipalPhone.ForeColor = System.Drawing.Color.Gray
        Me.PrincipalPhone.Location = New System.Drawing.Point(27, 74)
        Me.PrincipalPhone.Name = "PrincipalPhone"
        Me.PrincipalPhone.PlaceHolder = "Telefono"
        Me.PrincipalPhone.Size = New System.Drawing.Size(261, 20)
        Me.PrincipalPhone.TabIndex = 3
        Me.PrincipalPhone.Text = "Telefono"
        '
        'Name1
        '
        Me.Name1.change = False
        Me.Name1.ForeColor = System.Drawing.Color.Gray
        Me.Name1.Location = New System.Drawing.Point(27, 22)
        Me.Name1.Name = "Name1"
        Me.Name1.PlaceHolder = "Nombre"
        Me.Name1.Size = New System.Drawing.Size(261, 20)
        Me.Name1.TabIndex = 1
        Me.Name1.Text = "Nombre"
        '
        'DocumentID
        '
        Me.DocumentID.change = False
        Me.DocumentID.ForeColor = System.Drawing.Color.Gray
        Me.DocumentID.Location = New System.Drawing.Point(27, 100)
        Me.DocumentID.Name = "DocumentID"
        Me.DocumentID.PlaceHolder = "Documento de Identidad"
        Me.DocumentID.Size = New System.Drawing.Size(134, 20)
        Me.DocumentID.TabIndex = 4
        Me.DocumentID.Text = "Documento de Identidad"
        '
        'SecondName
        '
        Me.SecondName.change = False
        Me.SecondName.ForeColor = System.Drawing.Color.Gray
        Me.SecondName.Location = New System.Drawing.Point(27, 48)
        Me.SecondName.Name = "SecondName"
        Me.SecondName.PlaceHolder = "Apellido"
        Me.SecondName.Size = New System.Drawing.Size(261, 20)
        Me.SecondName.TabIndex = 2
        Me.SecondName.Text = "Apellido"
        '
        'PersonaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 448)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridView)
        Me.Name = "PersonaFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Persona"
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridView As System.Windows.Forms.DataGridView
    Friend WithEvents Name1 As CustomControls.PersonTexBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TypeDocumentID As System.Windows.Forms.ComboBox
    Friend WithEvents DocumentID As CustomControls.PersonTexBox
    Friend WithEvents SecondName As CustomControls.PersonTexBox
    Friend WithEvents CountryID As System.Windows.Forms.ComboBox
    Friend WithEvents Addres As CustomControls.PersonTexBox
    Friend WithEvents PrincipalPhone As CustomControls.PersonTexBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BirthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
