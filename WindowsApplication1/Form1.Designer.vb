<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Inventory_Data_Collector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Inventory_Data_Collector))
        Me.txt_Qty = New System.Windows.Forms.TextBox()
        Me.txt_Each = New System.Windows.Forms.TextBox()
        Me.txt_Description = New System.Windows.Forms.TextBox()
        Me.txt_Location = New System.Windows.Forms.TextBox()
        Me.txt_Notes = New System.Windows.Forms.TextBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.lbl_Qty = New System.Windows.Forms.Label()
        Me.lbl_Description = New System.Windows.Forms.Label()
        Me.lbl_Each = New System.Windows.Forms.Label()
        Me.lbl_Location = New System.Windows.Forms.Label()
        Me.lbl_Notes = New System.Windows.Forms.Label()
        Me.btn_Finished = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Check = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_Qty
        '
        Me.txt_Qty.Location = New System.Drawing.Point(24, 35)
        Me.txt_Qty.Multiline = True
        Me.txt_Qty.Name = "txt_Qty"
        Me.txt_Qty.Size = New System.Drawing.Size(168, 20)
        Me.txt_Qty.TabIndex = 0
        '
        'txt_Each
        '
        Me.txt_Each.Location = New System.Drawing.Point(207, 35)
        Me.txt_Each.MaxLength = 1000
        Me.txt_Each.Multiline = True
        Me.txt_Each.Name = "txt_Each"
        Me.txt_Each.Size = New System.Drawing.Size(169, 20)
        Me.txt_Each.TabIndex = 1
        '
        'txt_Description
        '
        Me.txt_Description.Location = New System.Drawing.Point(24, 83)
        Me.txt_Description.Multiline = True
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.Size = New System.Drawing.Size(168, 20)
        Me.txt_Description.TabIndex = 2
        '
        'txt_Location
        '
        Me.txt_Location.Location = New System.Drawing.Point(207, 83)
        Me.txt_Location.Multiline = True
        Me.txt_Location.Name = "txt_Location"
        Me.txt_Location.Size = New System.Drawing.Size(169, 20)
        Me.txt_Location.TabIndex = 3
        '
        'txt_Notes
        '
        Me.txt_Notes.Location = New System.Drawing.Point(24, 131)
        Me.txt_Notes.Multiline = True
        Me.txt_Notes.Name = "txt_Notes"
        Me.txt_Notes.Size = New System.Drawing.Size(352, 59)
        Me.txt_Notes.TabIndex = 4
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(24, 210)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 5
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'lbl_Qty
        '
        Me.lbl_Qty.AutoSize = True
        Me.lbl_Qty.Location = New System.Drawing.Point(21, 15)
        Me.lbl_Qty.Name = "lbl_Qty"
        Me.lbl_Qty.Size = New System.Drawing.Size(23, 13)
        Me.lbl_Qty.TabIndex = 0
        Me.lbl_Qty.Text = "Qty"
        '
        'lbl_Description
        '
        Me.lbl_Description.AutoSize = True
        Me.lbl_Description.Location = New System.Drawing.Point(21, 67)
        Me.lbl_Description.Name = "lbl_Description"
        Me.lbl_Description.Size = New System.Drawing.Size(60, 13)
        Me.lbl_Description.TabIndex = 0
        Me.lbl_Description.Text = "Description"
        '
        'lbl_Each
        '
        Me.lbl_Each.AutoSize = True
        Me.lbl_Each.Location = New System.Drawing.Point(204, 19)
        Me.lbl_Each.Name = "lbl_Each"
        Me.lbl_Each.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Each.TabIndex = 0
        Me.lbl_Each.Text = "Each"
        '
        'lbl_Location
        '
        Me.lbl_Location.AutoSize = True
        Me.lbl_Location.Location = New System.Drawing.Point(204, 67)
        Me.lbl_Location.Name = "lbl_Location"
        Me.lbl_Location.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Location.TabIndex = 0
        Me.lbl_Location.Text = "Location"
        '
        'lbl_Notes
        '
        Me.lbl_Notes.AutoSize = True
        Me.lbl_Notes.Location = New System.Drawing.Point(21, 115)
        Me.lbl_Notes.Name = "lbl_Notes"
        Me.lbl_Notes.Size = New System.Drawing.Size(83, 13)
        Me.lbl_Notes.TabIndex = 0
        Me.lbl_Notes.Text = "Notes (Optional)"
        '
        'btn_Finished
        '
        Me.btn_Finished.Location = New System.Drawing.Point(117, 210)
        Me.btn_Finished.Name = "btn_Finished"
        Me.btn_Finished.Size = New System.Drawing.Size(75, 23)
        Me.btn_Finished.TabIndex = 6
        Me.btn_Finished.Text = "Finished"
        Me.btn_Finished.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(301, 210)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Exit.TabIndex = 8
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_Check
        '
        Me.btn_Check.Enabled = False
        Me.btn_Check.Location = New System.Drawing.Point(207, 210)
        Me.btn_Check.Name = "btn_Check"
        Me.btn_Check.Size = New System.Drawing.Size(75, 23)
        Me.btn_Check.TabIndex = 7
        Me.btn_Check.Text = "Check"
        Me.btn_Check.UseVisualStyleBackColor = True
        '
        'frm_Inventory_Data_Collector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 245)
        Me.Controls.Add(Me.btn_Check)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Finished)
        Me.Controls.Add(Me.lbl_Notes)
        Me.Controls.Add(Me.lbl_Location)
        Me.Controls.Add(Me.lbl_Each)
        Me.Controls.Add(Me.lbl_Description)
        Me.Controls.Add(Me.lbl_Qty)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.txt_Notes)
        Me.Controls.Add(Me.txt_Location)
        Me.Controls.Add(Me.txt_Description)
        Me.Controls.Add(Me.txt_Each)
        Me.Controls.Add(Me.txt_Qty)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Inventory_Data_Collector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Data Collector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Qty As TextBox
    Friend WithEvents txt_Each As TextBox
    Friend WithEvents txt_Description As TextBox
    Friend WithEvents txt_Location As TextBox
    Friend WithEvents txt_Notes As TextBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents lbl_Qty As Label
    Friend WithEvents lbl_Description As Label
    Friend WithEvents lbl_Each As Label
    Friend WithEvents lbl_Location As Label
    Friend WithEvents lbl_Notes As Label
    Friend WithEvents btn_Finished As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_Check As Button
End Class
