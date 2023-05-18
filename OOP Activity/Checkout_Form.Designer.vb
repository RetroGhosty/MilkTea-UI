<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout_Form
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
        ListView1 = New ListView()
        Label1 = New Label()
        ClearCart_Btn = New Button()
        Label2 = New Label()
        totalPriceLbl_Value = New Label()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ListView1.Location = New Point(12, 50)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(732, 111)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 37)
        Label1.TabIndex = 1
        Label1.Text = "Shopping Cart"
        ' 
        ' ClearCart_Btn
        ' 
        ClearCart_Btn.FlatAppearance.BorderSize = 0
        ClearCart_Btn.FlatStyle = FlatStyle.Flat
        ClearCart_Btn.Location = New Point(648, 9)
        ClearCart_Btn.Name = "ClearCart_Btn"
        ClearCart_Btn.Size = New Size(96, 35)
        ClearCart_Btn.TabIndex = 2
        ClearCart_Btn.Text = "Clear Cart"
        ClearCart_Btn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(527, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 28)
        Label2.TabIndex = 3
        Label2.Text = "Total Price: "
        ' 
        ' totalPriceLbl_Value
        ' 
        totalPriceLbl_Value.AutoSize = True
        totalPriceLbl_Value.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        totalPriceLbl_Value.Location = New Point(643, 164)
        totalPriceLbl_Value.Name = "totalPriceLbl_Value"
        totalPriceLbl_Value.Size = New Size(23, 28)
        totalPriceLbl_Value.TabIndex = 4
        totalPriceLbl_Value.Text = "0"
        ' 
        ' Checkout_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(756, 239)
        Controls.Add(totalPriceLbl_Value)
        Controls.Add(Label2)
        Controls.Add(ClearCart_Btn)
        Controls.Add(Label1)
        Controls.Add(ListView1)
        Name = "Checkout_Form"
        Text = "Checkout_Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents ClearCart_Btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents totalPriceLbl_Value As Label
End Class
