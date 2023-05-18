<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderWindow
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
        TopPanel = New Panel()
        TopPanelHeader_Text = New Label()
        Panel1 = New Panel()
        Button2 = New Button()
        Check_CreamPuff = New CheckBox()
        Check_CocoJelly = New CheckBox()
        Check_Pearl = New CheckBox()
        Check_CreamCheese = New CheckBox()
        Label3 = New Label()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Label1 = New Label()
        checkoutPnl = New Panel()
        Label4 = New Label()
        totalPrice_Value = New Label()
        totalPrice_Label = New Label()
        checkOut_Btn = New Button()
        TopPanel.SuspendLayout()
        Panel1.SuspendLayout()
        checkoutPnl.SuspendLayout()
        SuspendLayout()
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        TopPanel.Controls.Add(TopPanelHeader_Text)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(0, 0)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(809, 80)
        TopPanel.TabIndex = 1
        ' 
        ' TopPanelHeader_Text
        ' 
        TopPanelHeader_Text.AutoSize = True
        TopPanelHeader_Text.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        TopPanelHeader_Text.Location = New Point(12, 23)
        TopPanelHeader_Text.Name = "TopPanelHeader_Text"
        TopPanelHeader_Text.Size = New Size(140, 37)
        TopPanelHeader_Text.TabIndex = 0
        TopPanelHeader_Text.Text = "MILK TEA"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Check_CreamPuff)
        Panel1.Controls.Add(Check_CocoJelly)
        Panel1.Controls.Add(Check_Pearl)
        Panel1.Controls.Add(Check_CreamCheese)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(545, 346)
        Panel1.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(140, 16)
        Button2.Name = "Button2"
        Button2.Size = New Size(115, 30)
        Button2.TabIndex = 11
        Button2.Text = "Clear fields"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Check_CreamPuff
        ' 
        Check_CreamPuff.AutoSize = True
        Check_CreamPuff.Location = New Point(19, 282)
        Check_CreamPuff.Name = "Check_CreamPuff"
        Check_CreamPuff.Size = New Size(86, 19)
        Check_CreamPuff.TabIndex = 10
        Check_CreamPuff.Text = "Cream Puff"
        Check_CreamPuff.UseVisualStyleBackColor = True
        ' 
        ' Check_CocoJelly
        ' 
        Check_CocoJelly.AutoSize = True
        Check_CocoJelly.Location = New Point(19, 257)
        Check_CocoJelly.Name = "Check_CocoJelly"
        Check_CocoJelly.Size = New Size(79, 19)
        Check_CocoJelly.TabIndex = 9
        Check_CocoJelly.Text = "Coco Jelly"
        Check_CocoJelly.UseVisualStyleBackColor = True
        ' 
        ' Check_Pearl
        ' 
        Check_Pearl.AutoSize = True
        Check_Pearl.Location = New Point(19, 232)
        Check_Pearl.Name = "Check_Pearl"
        Check_Pearl.Size = New Size(82, 19)
        Check_Pearl.TabIndex = 8
        Check_Pearl.Text = "Boba Pearl"
        Check_Pearl.UseVisualStyleBackColor = True
        ' 
        ' Check_CreamCheese
        ' 
        Check_CreamCheese.AutoSize = True
        Check_CreamCheese.Location = New Point(19, 207)
        Check_CreamCheese.Name = "Check_CreamCheese"
        Check_CreamCheese.Size = New Size(100, 19)
        Check_CreamCheese.TabIndex = 7
        Check_CreamCheese.Text = "Cream cheese"
        Check_CreamCheese.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(19, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 30)
        Label3.TabIndex = 6
        Label3.Text = "Add ons"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        ComboBox2.Location = New Point(19, 141)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(131, 23)
        ComboBox2.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(19, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 30)
        Label2.TabIndex = 4
        Label2.Text = "SIZE"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Classic Milk Tea", "Pearl Milk Tea", "Honey Milk Tea", "Grass Jelly Milk Tea", "Pudding Milk Tea", "Red Bean Milk Tea", "Aloe Vera Milk Tea"})
        ComboBox1.Location = New Point(19, 82)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(223, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(19, 16)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 30)
        Button1.TabIndex = 2
        Button1.Text = "Create Milk Tea"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(19, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 30)
        Label1.TabIndex = 0
        Label1.Text = "TYPE OF MILK TEA"
        ' 
        ' checkoutPnl
        ' 
        checkoutPnl.Controls.Add(Label4)
        checkoutPnl.Controls.Add(totalPrice_Value)
        checkoutPnl.Controls.Add(totalPrice_Label)
        checkoutPnl.Controls.Add(checkOut_Btn)
        checkoutPnl.Dock = DockStyle.Fill
        checkoutPnl.Location = New Point(545, 80)
        checkoutPnl.Name = "checkoutPnl"
        checkoutPnl.Size = New Size(264, 346)
        checkoutPnl.TabIndex = 3
        checkoutPnl.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 4
        Label4.Text = "Label4"
        ' 
        ' totalPrice_Value
        ' 
        totalPrice_Value.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        totalPrice_Value.AutoSize = True
        totalPrice_Value.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        totalPrice_Value.Location = New Point(19, 294)
        totalPrice_Value.Name = "totalPrice_Value"
        totalPrice_Value.Size = New Size(23, 28)
        totalPrice_Value.TabIndex = 3
        totalPrice_Value.Text = "0"
        ' 
        ' totalPrice_Label
        ' 
        totalPrice_Label.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        totalPrice_Label.AutoSize = True
        totalPrice_Label.Location = New Point(19, 279)
        totalPrice_Label.Name = "totalPrice_Label"
        totalPrice_Label.Size = New Size(61, 15)
        totalPrice_Label.TabIndex = 2
        totalPrice_Label.Text = "Total Price"
        ' 
        ' checkOut_Btn
        ' 
        checkOut_Btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        checkOut_Btn.Location = New Point(140, 279)
        checkOut_Btn.Name = "checkOut_Btn"
        checkOut_Btn.Size = New Size(112, 43)
        checkOut_Btn.TabIndex = 1
        checkOut_Btn.Text = "Check Out"
        checkOut_Btn.UseVisualStyleBackColor = True
        ' 
        ' OrderWindow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(809, 426)
        Controls.Add(checkoutPnl)
        Controls.Add(Panel1)
        Controls.Add(TopPanel)
        Name = "OrderWindow"
        Text = "Form1"
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        checkoutPnl.ResumeLayout(False)
        checkoutPnl.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TopPanel As Panel
    Friend WithEvents TopPanelHeader_Text As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents checkoutPnl As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Check_CreamCheese As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Check_CreamPuff As CheckBox
    Friend WithEvents Check_CocoJelly As CheckBox
    Friend WithEvents Check_Pearl As CheckBox
    Friend WithEvents checkOut_Btn As Button
    Friend WithEvents totalPrice_Label As Label
    Friend WithEvents totalPrice_Value As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
End Class
