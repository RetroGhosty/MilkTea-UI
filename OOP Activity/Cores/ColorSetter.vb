Public Class ColorSetter
    'Default value
    Public Property PrimaryColor
    Public Property SecondaryColor
    Public Property PrimaryText
    Public Property SecondaryText
    Public Property PrimaryBtnColor
    Public Property SecondaryBtnColor

    'Light mode
    Private ReadOnly LightPrimary = "#f2545b" 'Indian red
    Private ReadOnly LightSecondary = "#fabc2a" 'Selective Yellow
    Private ReadOnly LightPrimaryText = "#000000" 'Black
    Private ReadOnly LightSecondaryText = "#f2edeb" 'Isabelline
    Private ReadOnly LightPrimaryBtnColor = "#9db17c"
    Private ReadOnly LightSecondaryBtnColor = "#9db17c"

    'Dark mode
    Private ReadOnly DarkPrimary = "#6b2d5c" 'Byzantium
    Private ReadOnly DarkSecondary = "#512500" 'SealBrown
    Private ReadOnly DarkPrimaryText = "#f2edeb" 'Isabelline
    Private ReadOnly DarkSecondaryText = "#000000" 'Black
    Private ReadOnly DarkPrimaryBtnColor = "#9db17c" 'Black
    Private ReadOnly DarkSecondaryBtnColor = "#9db17c" 'Isabelline

    Public Property IsDarkMode = False

    'Kailangan ng Color Translation nugget package para gumana
    Public Sub DarkModeSetter()
        If IsDarkMode = True Then
            PrimaryColor = ColorTranslator.FromHtml(DarkPrimary)
            SecondaryColor = ColorTranslator.FromHtml(DarkSecondary)
            PrimaryText = ColorTranslator.FromHtml(DarkPrimaryText)
            SecondaryText = ColorTranslator.FromHtml(DarkSecondaryText)
            PrimaryBtnColor = ColorTranslator.FromHtml(DarkPrimaryBtnColor)
            SecondaryBtnColor = ColorTranslator.FromHtml(DarkSecondaryBtnColor)

        ElseIf IsDarkMode = False Then
            PrimaryColor = ColorTranslator.FromHtml(LightPrimary)
            SecondaryColor = ColorTranslator.FromHtml(LightSecondary)
            PrimaryText = ColorTranslator.FromHtml(LightPrimaryText)
            SecondaryText = ColorTranslator.FromHtml(LightSecondaryText)
            PrimaryBtnColor = ColorTranslator.FromHtml(LightPrimaryBtnColor)
            SecondaryBtnColor = ColorTranslator.FromHtml(LightSecondaryBtnColor)
        Else
            PrimaryColor = ColorTranslator.FromHtml(DarkPrimary)
            SecondaryColor = ColorTranslator.FromHtml(DarkSecondary)
            PrimaryText = ColorTranslator.FromHtml(DarkPrimaryText)
            SecondaryText = ColorTranslator.FromHtml(DarkSecondaryText)
            PrimaryBtnColor = ColorTranslator.FromHtml(DarkPrimaryBtnColor)
            SecondaryBtnColor = ColorTranslator.FromHtml(DarkSecondaryBtnColor)
        End If
    End Sub


End Class
