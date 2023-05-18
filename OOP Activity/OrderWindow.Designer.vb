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
        ShowShoppingCart_Btn = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        Label27 = New Label()
        Label28 = New Label()
        Label29 = New Label()
        Label30 = New Label()
        Label31 = New Label()
        Label32 = New Label()
        Label33 = New Label()
        Label34 = New Label()
        Label35 = New Label()
        Label36 = New Label()
        Label37 = New Label()
        Label38 = New Label()
        Label39 = New Label()
        Label40 = New Label()
        Label41 = New Label()
        Label42 = New Label()
        Label43 = New Label()
        Label44 = New Label()
        Label45 = New Label()
        Label46 = New Label()
        Label47 = New Label()
        Label48 = New Label()
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
        TopPanel.Size = New Size(1058, 80)
        TopPanel.TabIndex = 1
        ' 
        ' TopPanelHeader_Text
        ' 
        TopPanelHeader_Text.AutoSize = True
        TopPanelHeader_Text.Font = New Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point)
        TopPanelHeader_Text.Location = New Point(344, 9)
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
        Label1.Location = New Point(23, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 31)
        Label1.TabIndex = 0
        Label1.Text = "Choose your flavor:"
        ' 
        ' CreateMilkTea_Btn
        ' 
        CreateMilkTea_Btn.FlatAppearance.BorderSize = 0
        CreateMilkTea_Btn.FlatStyle = FlatStyle.Flat
        CreateMilkTea_Btn.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CreateMilkTea_Btn.ForeColor = Color.Indigo
        CreateMilkTea_Btn.Location = New Point(344, 16)
        CreateMilkTea_Btn.Name = "CreateMilkTea_Btn"
        CreateMilkTea_Btn.Size = New Size(156, 47)
        CreateMilkTea_Btn.TabIndex = 2
        CreateMilkTea_Btn.Text = "Create Milk Tea"
        CreateMilkTea_Btn.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(23, 48)
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
        Label2.Location = New Point(23, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 31)
        Label2.TabIndex = 4
        Label2.Text = "Size:"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(23, 114)
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
        Label3.Location = New Point(23, 143)
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
        CheckBox1.Location = New Point(23, 177)
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
        CheckBox2.Location = New Point(165, 177)
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
        CheckBox3.Location = New Point(283, 177)
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
        CheckBox4.Location = New Point(23, 210)
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
        CheckBox5.Location = New Point(146, 210)
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
        Label4.Location = New Point(23, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 31)
        Label4.TabIndex = 12
        Label4.Text = "Sweetness:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(23, 274)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(97, 19)
        RadioButton1.TabIndex = 19
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(126, 274)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(97, 19)
        RadioButton2.TabIndex = 20
        RadioButton2.Text = "RadioButton2"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(229, 274)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(97, 19)
        RadioButton3.TabIndex = 21
        RadioButton3.Text = "RadioButton3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(23, 299)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(97, 19)
        RadioButton4.TabIndex = 22
        RadioButton4.Text = "RadioButton4"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(126, 299)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(97, 19)
        RadioButton5.TabIndex = 23
        RadioButton5.Text = "RadioButton5"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ShowShoppingCart_Btn)
        Panel1.Controls.Add(RadioButton5)
        Panel1.Controls.Add(CreateMilkTea_Btn)
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
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(520, 361)
        Panel1.TabIndex = 2
        ' 
        ' ShowShoppingCart_Btn
        ' 
        ShowShoppingCart_Btn.FlatAppearance.BorderSize = 0
        ShowShoppingCart_Btn.FlatStyle = FlatStyle.Flat
        ShowShoppingCart_Btn.Location = New Point(421, 70)
        ShowShoppingCart_Btn.Name = "ShowShoppingCart_Btn"
        ShowShoppingCart_Btn.Size = New Size(79, 34)
        ShowShoppingCart_Btn.TabIndex = 24
        ShowShoppingCart_Btn.Text = "Cart"
        ShowShoppingCart_Btn.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Thistle
        Label5.Location = New Point(554, 94)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 31)
        Label5.TabIndex = 25
        Label5.Text = "Flavors"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(554, 130)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 26
        Label6.Text = "Label6"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(554, 150)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 20)
        Label7.TabIndex = 27
        Label7.Text = "Label7"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(554, 171)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 20)
        Label8.TabIndex = 28
        Label8.Text = "Label8"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(554, 191)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 20)
        Label9.TabIndex = 29
        Label9.Text = "Label9"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(554, 211)
        Label10.Name = "Label10"
        Label10.Size = New Size(61, 20)
        Label10.TabIndex = 30
        Label10.Text = "Label10"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(554, 232)
        Label11.Name = "Label11"
        Label11.Size = New Size(61, 20)
        Label11.TabIndex = 31
        Label11.Text = "Label11"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(554, 252)
        Label12.Name = "Label12"
        Label12.Size = New Size(61, 20)
        Label12.TabIndex = 32
        Label12.Text = "Label12"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(718, 130)
        Label13.Name = "Label13"
        Label13.Size = New Size(61, 20)
        Label13.TabIndex = 39
        Label13.Text = "Label13"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(718, 150)
        Label14.Name = "Label14"
        Label14.Size = New Size(61, 20)
        Label14.TabIndex = 38
        Label14.Text = "Label14"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(718, 170)
        Label15.Name = "Label15"
        Label15.Size = New Size(61, 20)
        Label15.TabIndex = 37
        Label15.Text = "Label15"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(718, 190)
        Label16.Name = "Label16"
        Label16.Size = New Size(61, 20)
        Label16.TabIndex = 36
        Label16.Text = "Label16"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(718, 210)
        Label17.Name = "Label17"
        Label17.Size = New Size(61, 20)
        Label17.TabIndex = 35
        Label17.Text = "Label17"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.Location = New Point(718, 230)
        Label18.Name = "Label18"
        Label18.Size = New Size(61, 20)
        Label18.TabIndex = 34
        Label18.Text = "Label18"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label19.Location = New Point(718, 250)
        Label19.Name = "Label19"
        Label19.Size = New Size(61, 20)
        Label19.TabIndex = 33
        Label19.Text = "Label19"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.FlatStyle = FlatStyle.Flat
        Label20.Font = New Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label20.ForeColor = Color.Thistle
        Label20.Location = New Point(554, 291)
        Label20.Name = "Label20"
        Label20.Size = New Size(82, 31)
        Label20.TabIndex = 40
        Label20.Text = "Sizes"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label21.Location = New Point(554, 322)
        Label21.Name = "Label21"
        Label21.Size = New Size(61, 20)
        Label21.TabIndex = 41
        Label21.Text = "Label21"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label22.Location = New Point(554, 342)
        Label22.Name = "Label22"
        Label22.Size = New Size(61, 20)
        Label22.TabIndex = 42
        Label22.Text = "Label22"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label23.Location = New Point(554, 362)
        Label23.Name = "Label23"
        Label23.Size = New Size(61, 20)
        Label23.TabIndex = 43
        Label23.Text = "Label23"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label24.Location = New Point(718, 322)
        Label24.Name = "Label24"
        Label24.Size = New Size(61, 20)
        Label24.TabIndex = 44
        Label24.Text = "Label24"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label25.Location = New Point(718, 342)
        Label25.Name = "Label25"
        Label25.Size = New Size(61, 20)
        Label25.TabIndex = 45
        Label25.Text = "Label25"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label26.Location = New Point(718, 362)
        Label26.Name = "Label26"
        Label26.Size = New Size(61, 20)
        Label26.TabIndex = 46
        Label26.Text = "Label26"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label27.ForeColor = Color.Thistle
        Label27.Location = New Point(820, 94)
        Label27.Name = "Label27"
        Label27.Size = New Size(157, 31)
        Label27.TabIndex = 25
        Label27.Text = "Sweetness"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label28.Location = New Point(820, 131)
        Label28.Name = "Label28"
        Label28.Size = New Size(61, 20)
        Label28.TabIndex = 47
        Label28.Text = "Label28"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label29.Location = New Point(820, 151)
        Label29.Name = "Label29"
        Label29.Size = New Size(61, 20)
        Label29.TabIndex = 48
        Label29.Text = "Label29"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label30.Location = New Point(820, 171)
        Label30.Name = "Label30"
        Label30.Size = New Size(61, 20)
        Label30.TabIndex = 49
        Label30.Text = "Label30"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label31.Location = New Point(820, 191)
        Label31.Name = "Label31"
        Label31.Size = New Size(61, 20)
        Label31.TabIndex = 50
        Label31.Text = "Label31"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label32.Location = New Point(820, 211)
        Label32.Name = "Label32"
        Label32.Size = New Size(61, 20)
        Label32.TabIndex = 51
        Label32.Text = "Label32"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label33.Location = New Point(951, 130)
        Label33.Name = "Label33"
        Label33.Size = New Size(61, 20)
        Label33.TabIndex = 52
        Label33.Text = "Label33"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label34.Location = New Point(951, 150)
        Label34.Name = "Label34"
        Label34.Size = New Size(61, 20)
        Label34.TabIndex = 53
        Label34.Text = "Label34"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label35.Location = New Point(951, 170)
        Label35.Name = "Label35"
        Label35.Size = New Size(61, 20)
        Label35.TabIndex = 54
        Label35.Text = "Label35"
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label36.Location = New Point(951, 190)
        Label36.Name = "Label36"
        Label36.Size = New Size(61, 20)
        Label36.TabIndex = 55
        Label36.Text = "Label36"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label37.Location = New Point(951, 210)
        Label37.Name = "Label37"
        Label37.Size = New Size(61, 20)
        Label37.TabIndex = 56
        Label37.Text = "Label37"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label38.ForeColor = Color.Thistle
        Label38.Location = New Point(820, 268)
        Label38.Name = "Label38"
        Label38.Size = New Size(131, 31)
        Label38.TabIndex = 57
        Label38.Text = "Add Ons"
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label39.Location = New Point(820, 300)
        Label39.Name = "Label39"
        Label39.Size = New Size(61, 20)
        Label39.TabIndex = 58
        Label39.Text = "Label39"
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label40.Location = New Point(820, 320)
        Label40.Name = "Label40"
        Label40.Size = New Size(61, 20)
        Label40.TabIndex = 59
        Label40.Text = "Label40"
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label41.Location = New Point(820, 339)
        Label41.Name = "Label41"
        Label41.Size = New Size(61, 20)
        Label41.TabIndex = 60
        Label41.Text = "Label41"
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label42.Location = New Point(820, 359)
        Label42.Name = "Label42"
        Label42.Size = New Size(61, 20)
        Label42.TabIndex = 61
        Label42.Text = "Label42"
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label43.Location = New Point(820, 379)
        Label43.Name = "Label43"
        Label43.Size = New Size(61, 20)
        Label43.TabIndex = 62
        Label43.Text = "Label43"
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label44.Location = New Point(951, 298)
        Label44.Name = "Label44"
        Label44.Size = New Size(61, 20)
        Label44.TabIndex = 63
        Label44.Text = "Label44"
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label45.Location = New Point(951, 319)
        Label45.Name = "Label45"
        Label45.Size = New Size(61, 20)
        Label45.TabIndex = 64
        Label45.Text = "Label45"
        ' 
        ' Label46
        ' 
        Label46.AutoSize = True
        Label46.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label46.Location = New Point(951, 338)
        Label46.Name = "Label46"
        Label46.Size = New Size(61, 20)
        Label46.TabIndex = 65
        Label46.Text = "Label46"
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label47.Location = New Point(951, 358)
        Label47.Name = "Label47"
        Label47.Size = New Size(61, 20)
        Label47.TabIndex = 66
        Label47.Text = "Label47"
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label48.Location = New Point(951, 378)
        Label48.Name = "Label48"
        Label48.Size = New Size(61, 20)
        Label48.TabIndex = 67
        Label48.Text = "Label48"
        ' 
        ' OrderWindow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1058, 441)
        Controls.Add(Label48)
        Controls.Add(Label47)
        Controls.Add(Label46)
        Controls.Add(Label45)
        Controls.Add(Label44)
        Controls.Add(Label43)
        Controls.Add(Label42)
        Controls.Add(Label41)
        Controls.Add(Label40)
        Controls.Add(Label39)
        Controls.Add(Label38)
        Controls.Add(Label37)
        Controls.Add(Label36)
        Controls.Add(Label35)
        Controls.Add(Label34)
        Controls.Add(Label33)
        Controls.Add(Label32)
        Controls.Add(Label31)
        Controls.Add(Label30)
        Controls.Add(Label29)
        Controls.Add(Label28)
        Controls.Add(Label27)
        Controls.Add(Label26)
        Controls.Add(Label25)
        Controls.Add(Label24)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Controls.Add(Label15)
        Controls.Add(Label16)
        Controls.Add(Label17)
        Controls.Add(Label18)
        Controls.Add(Label19)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(TopPanel)
        Name = "OrderWindow"
        Text = "Form1"
        TopPanel.ResumeLayout(False)
        TopPanel.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents ShowShoppingCart_Btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
End Class
