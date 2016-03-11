<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcTax
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalcTax))
        Me.picStoreName = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblNameOfItem = New System.Windows.Forms.Label()
        Me.txtNameOfItem = New System.Windows.Forms.TextBox()
        Me.lblCostOfItem = New System.Windows.Forms.Label()
        Me.txtCostOfItem = New System.Windows.Forms.TextBox()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TotalCost = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        CType(Me.picStoreName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picStoreName
        '
        Me.picStoreName.ErrorImage = CType(resources.GetObject("picStoreName.ErrorImage"), System.Drawing.Image)
        Me.picStoreName.Image = CType(resources.GetObject("picStoreName.Image"), System.Drawing.Image)
        Me.picStoreName.Location = New System.Drawing.Point(11, 10)
        Me.picStoreName.Name = "picStoreName"
        Me.picStoreName.Size = New System.Drawing.Size(386, 151)
        Me.picStoreName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStoreName.TabIndex = 0
        Me.picStoreName.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(74, 164)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(261, 27)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Sales Tax Calculator"
        '
        'lblNameOfItem
        '
        Me.lblNameOfItem.AutoSize = True
        Me.lblNameOfItem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOfItem.Location = New System.Drawing.Point(48, 221)
        Me.lblNameOfItem.Name = "lblNameOfItem"
        Me.lblNameOfItem.Size = New System.Drawing.Size(129, 20)
        Me.lblNameOfItem.TabIndex = 2
        Me.lblNameOfItem.Text = "Name of Item(s):"
        '
        'txtNameOfItem
        '
        Me.txtNameOfItem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameOfItem.Location = New System.Drawing.Point(271, 215)
        Me.txtNameOfItem.Name = "txtNameOfItem"
        Me.txtNameOfItem.Size = New System.Drawing.Size(100, 26)
        Me.txtNameOfItem.TabIndex = 3
        Me.txtNameOfItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCostOfItem
        '
        Me.lblCostOfItem.AutoSize = True
        Me.lblCostOfItem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfItem.Location = New System.Drawing.Point(48, 264)
        Me.lblCostOfItem.Name = "lblCostOfItem"
        Me.lblCostOfItem.Size = New System.Drawing.Size(200, 20)
        Me.lblCostOfItem.TabIndex = 4
        Me.lblCostOfItem.Text = "Cost Of Item(s) Before Tax:"
        '
        'txtCostOfItem
        '
        Me.txtCostOfItem.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostOfItem.Location = New System.Drawing.Point(271, 264)
        Me.txtCostOfItem.Name = "txtCostOfItem"
        Me.txtCostOfItem.Size = New System.Drawing.Size(100, 26)
        Me.txtCostOfItem.TabIndex = 5
        Me.txtCostOfItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.Location = New System.Drawing.Point(31, 360)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(101, 23)
        Me.btnDisplayCost.TabIndex = 6
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(154, 360)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(277, 360)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TotalCost
        '
        Me.TotalCost.AutoSize = True
        Me.TotalCost.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCost.Location = New System.Drawing.Point(52, 308)
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.Size = New System.Drawing.Size(83, 20)
        Me.TotalCost.TabIndex = 9
        Me.TotalCost.Text = "Total Cost:"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCost.Location = New System.Drawing.Point(271, 308)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalCost.TabIndex = 10
        Me.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CalcTax
        '
        Me.AcceptButton = Me.btnDisplayCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(409, 462)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.TotalCost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.txtCostOfItem)
        Me.Controls.Add(Me.lblCostOfItem)
        Me.Controls.Add(Me.txtNameOfItem)
        Me.Controls.Add(Me.lblNameOfItem)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picStoreName)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "CalcTax"
        Me.Text = "Form1"
        CType(Me.picStoreName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picStoreName As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblNameOfItem As Label
    Friend WithEvents txtNameOfItem As TextBox
    Friend WithEvents lblCostOfItem As Label
    Friend WithEvents txtCostOfItem As TextBox
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents TotalCost As Label
    Friend WithEvents txtTotalCost As TextBox
End Class
