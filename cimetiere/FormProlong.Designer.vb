<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProlong
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvConcessions = New cimetiere.DataGridViewConcessions()
        Me.ColNomCsnr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDateDebut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDateFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNbreRenouv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmpl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOccupants = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvConcessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvConcessions
        '
        Me.DgvConcessions.AllowUserToAddRows = False
        Me.DgvConcessions.AllowUserToDeleteRows = False
        Me.DgvConcessions.AllowUserToOrderColumns = True
        Me.DgvConcessions.AllowUserToResizeRows = False
        Me.DgvConcessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvConcessions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvConcessions.BackgroundColor = System.Drawing.Color.White
        Me.DgvConcessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConcessions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNomCsnr, Me.ColDateDebut, Me.ColDateFin, Me.ColNbreRenouv, Me.ColEmpl, Me.ColOccupants})
        Me.DgvConcessions.CustomFilterFunc = Nothing
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvConcessions.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgvConcessions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvConcessions.Location = New System.Drawing.Point(12, 12)
        Me.DgvConcessions.MultiSelect = False
        Me.DgvConcessions.Name = "DgvConcessions"
        Me.DgvConcessions.ReadOnly = True
        Me.DgvConcessions.RowHeadersVisible = False
        Me.DgvConcessions.RowTemplate.Height = 24
        Me.DgvConcessions.SelectedItem = Nothing
        Me.DgvConcessions.SelectedRowIndex = -1
        Me.DgvConcessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConcessions.Size = New System.Drawing.Size(909, 263)
        Me.DgvConcessions.TabIndex = 0
        '
        'ColNomCsnr
        '
        Me.ColNomCsnr.DataPropertyName = "NomCompletCsnr"
        Me.ColNomCsnr.FillWeight = 80.0!
        Me.ColNomCsnr.HeaderText = "Concessionnaire"
        Me.ColNomCsnr.Name = "ColNomCsnr"
        Me.ColNomCsnr.ReadOnly = True
        '
        'ColDateDebut
        '
        Me.ColDateDebut.DataPropertyName = "DateDebut"
        Me.ColDateDebut.FillWeight = 50.0!
        Me.ColDateDebut.HeaderText = "Début"
        Me.ColDateDebut.Name = "ColDateDebut"
        Me.ColDateDebut.ReadOnly = True
        '
        'ColDateFin
        '
        Me.ColDateFin.DataPropertyName = "DateFin"
        Me.ColDateFin.FillWeight = 50.0!
        Me.ColDateFin.HeaderText = "Fin"
        Me.ColDateFin.Name = "ColDateFin"
        Me.ColDateFin.ReadOnly = True
        '
        'ColNbreRenouv
        '
        Me.ColNbreRenouv.DataPropertyName = "NbreRenovations"
        Me.ColNbreRenouv.FillWeight = 25.0!
        Me.ColNbreRenouv.HeaderText = "Renouvellements"
        Me.ColNbreRenouv.Name = "ColNbreRenouv"
        Me.ColNbreRenouv.ReadOnly = True
        '
        'ColEmpl
        '
        Me.ColEmpl.DataPropertyName = "RefEmpl"
        Me.ColEmpl.FillWeight = 30.0!
        Me.ColEmpl.HeaderText = "Empl."
        Me.ColEmpl.Name = "ColEmpl"
        Me.ColEmpl.ReadOnly = True
        '
        'ColOccupants
        '
        Me.ColOccupants.DataPropertyName = "NomsOccupants"
        Me.ColOccupants.FillWeight = 120.0!
        Me.ColOccupants.HeaderText = "Occupant(s)"
        Me.ColOccupants.Name = "ColOccupants"
        Me.ColOccupants.ReadOnly = True
        '
        'FormProlong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 509)
        Me.Controls.Add(Me.DgvConcessions)
        Me.Name = "FormProlong"
        Me.Text = "FormProlong"
        CType(Me.DgvConcessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvConcessions As DataGridViewConcessions
    Friend WithEvents ColNomCsnr As DataGridViewTextBoxColumn
    Friend WithEvents ColDateDebut As DataGridViewTextBoxColumn
    Friend WithEvents ColDateFin As DataGridViewTextBoxColumn
    Friend WithEvents ColNbreRenouv As DataGridViewTextBoxColumn
    Friend WithEvents ColEmpl As DataGridViewTextBoxColumn
    Friend WithEvents ColOccupants As DataGridViewTextBoxColumn
End Class
