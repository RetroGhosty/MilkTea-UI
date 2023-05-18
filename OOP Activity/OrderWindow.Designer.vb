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
        ClearTray_Btn = New Button()
        totalPrice_Value = New Label()
        totalPrice_Label = New Label()
        CheckOut_Btn = New Button()
        Label1 = New Label()
        CreateMilkTea_Btn = New Button()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        ComboBox2 = New ComboBox()
        Label3 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        Label4 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        Panel1 = New Panel()
        TopPanel.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TopPanel
        ' 
        TopPanel.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        TopPanel.Controls.Add(TopPanelHeader_Text)
        TopPanel.Dock = DockStyle.Top
        TopPanel.Location = New Point(0, 0)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New Size(907, 80)
        TopPanel.TabIndex = 1
        ' 
        ' TopPanelHeader_Text
        ' 
        TopPanelHeader_Text.AutoSize = True
        TopPanelHeader_Text.Font = New Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point)
        TopPanelHeader_Text.Location = New Point(277, 9)
        TopPanelHeader_Text.Name = "TopPanelHeader_Text"
        TopPanelHeader_Text.Size = New Size(369, 55)
        TopPanelHeader_Text.TabIndex = 0
        TopPanelHeader_Text.Text = "It's Boba time!"
        ' 
        ' ClearTray_Btn
        ' 
        ClearTray_Btn.Location = New Point(160, 6)
        ClearTray_Btn.Name = "ClearTray_Btn"
        ClearTray_Btn.Size = New Size(101, 40)
        ClearTray_Btn.TabIndex = 11
        ClearTray_Btn.Text = "Clear Tray"
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
        ' CheckOut_Btn
        ' 
        CheckOut_Btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        CheckOut_Btn.Location = New Point(-124, 279)
        CheckOut_Btn.Name = "CheckOut_Btn"
        CheckOut_Btn.Size = New Size(112, 43)
        CheckOut_Btn.TabIndex = 1
        CheckOut_Btn.Text = "Check Out"
        CheckOut_Btn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Thistle
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 31)
        Label1.TabIndex = 0
        Label1.Text = "Choose your flavor:"
        ' 
        ' CreateMilkTea_Btn
        ' 
        CreateMilkTea_Btn.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CreateMilkTea_Btn.ForeColor = Color.Indigo
        CreateMilkTea_Btn.Location = New Point(381, 368)
        CreateMilkTea_Btn.Name = "CreateMilkTea_Btn"
        CreateMilkTea_Btn.Size = New Size(159, 30)
        CreateMilkTea_Btn.TabIndex = 2
        CreateMilkTea_Btn.Text = "Create Milk Tea"
        CreateMilkTea_Btn.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 49)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(223, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Thistle
        Label2.Location = New Point(12, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 31)
        Label2.TabIndex = 4
        Label2.Text = "Size:"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(12, 109)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(131, 23)
        ComboBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Thistle
        Label3.Location = New Point(12, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 31)
        Label3.TabIndex = 6
        Label3.Text = "Add ons"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.ForeColor = Color.Plum
        CheckBox1.Location = New Point(12, 169)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(136, 27)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Cream cheese"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox2.ForeColor = Color.Plum
        CheckBox2.Location = New Point(154, 169)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(112, 27)
        CheckBox2.TabIndex = 8
        CheckBox2.Text = "Boba Pearl"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox3.ForeColor = Color.Plum
        CheckBox3.Location = New Point(272, 169)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(107, 27)
        CheckBox3.TabIndex = 9
        CheckBox3.Text = "Coco Jelly"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox4.ForeColor = Color.Plum
        CheckBox4.Location = New Point(12, 202)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(117, 27)
        CheckBox4.TabIndex = 10
        CheckBox4.Text = "Cream Puff"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox5.ForeColor = Color.Plum
        CheckBox5.Location = New Point(135, 202)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(134, 27)
        CheckBox5.TabIndex = 11
        CheckBox5.Text = "Nata de Coco"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Thistle
        Label4.Location = New Point(12, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 31)
        Label4.TabIndex = 12
        Label4.Text = "Sweetness:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(12, 266)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(97, 19)
        RadioButton1.TabIndex = 19
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(115, 266)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(97, 19)
        RadioButton2.TabIndex = 20
        RadioButton2.Text = "RadioButton2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(218, 266)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(97, 19)
        RadioButton3.TabIndex = 21
        RadioButton3.Text = "RadioButton3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(12, 291)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(97, 19)
        RadioButton4.TabIndex = 22
        RadioButton4.Text = "RadioButton4"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(115, 291)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(97, 19)
        RadioButton5.TabIndex = 23
        RadioButton5.Text = "RadioButton5"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(RadioButton5)
        Panel1.Controls.Add(RadioButton4)
        Panel1.Controls.Add(RadioButton3)
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(CheckBox5)
        Panel1.Controls.Add(CheckBox4)
        Panel1.Controls.Add(CheckBox3)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(CreateMilkTea_Btn)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(907, 431)
        Panel1.TabIndex = 2
        ' 
        ' OrderWindow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(907, 511)
        Controls.Add(Panel1)
        Controls.Add(TopPanel)
        Name = "OrderWindow"
        Text = "Form1"
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TopPanel As Panel
    Friend WithEvents TopPanelHeader_Text As Label
    Friend WithEvents CheckOut_Btn As Button
    Friend WithEvents totalPrice_Label As Label
    Friend WithEvents totalPrice_Value As Label
    Friend WithEvents ClearTray_Btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CreateMilkTea_Btn As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents Panel1 As Panel
End Class
