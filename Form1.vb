Imports Microsoft.Web.WebView2.WinForms
Imports Microsoft.Web.WebView2.Core
Imports System.IO
Imports System.Drawing.Text


Public Class Form1

    Private hintColor As Color = Color.Gray
    Private normalColor As Color = Color.Black
    Dim URLWarning
    Private darkModeBackgroundColor As Color = Color.FromArgb(32, 32, 32) ' Dark background color
    Private darkModeTextColor As Color = Color.LightGray ' Light text color


    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await WebView21.EnsureCoreWebView2Async()
        Dim startUrl As String = GetStartUrlFromConfig()
        If Not String.IsNullOrEmpty(startUrl) Then
            WebView21.CoreWebView2.Navigate(startUrl)
        Else
            ' If config.txt is missing or invalid, load a default URL.
            WebView21.CoreWebView2.Navigate("https://www.duckduckgo.com")
        End If
        tb_url.Text = WebView21.CoreWebView2.Source
        tb_url.ForeColor = hintColor
        URLWarning = MsgBox("URL box requires headers such as https://, http://, steam://, etc.", 0, "Edge-Based Browser Project")
        If IsDarkModeEnabled() Then
            ApplyDarkMode()
        End If
    End Sub

    Private Function IsDarkModeEnabled() As Boolean
        Try
            Dim configFilePath As String = Path.Combine(Application.StartupPath, "config.txt")
            If File.Exists(configFilePath) Then
                Dim lines As String() = File.ReadAllLines(configFilePath)
                For Each line As String In lines
                    Dim trimmedLine As String = line.Trim()
                    If Not trimmedLine.StartsWith("//") AndAlso trimmedLine.StartsWith("darkmode =") Then
                        Dim valuePart As String = trimmedLine.Substring("darkmode =".Length).Trim()
                        If Not String.IsNullOrEmpty(valuePart) Then
                            Return Boolean.Parse(valuePart)
                        End If
                    End If
                Next
            End If
            Return False ' Default to light mode if not specified
        Catch ex As Exception
            ' Handle exceptions (e.g., file access errors).
            Return False
        End Try
    End Function

    Private Sub ApplyDarkMode()
        Me.BackColor = darkModeBackgroundColor
        tb_url.BackColor = darkModeBackgroundColor
        tb_url.ForeColor = darkModeTextColor
        tb_search.BackColor = darkModeBackgroundColor
        tb_search.ForeColor = darkModeTextColor
        ' Apply dark mode to other controls as needed
    End Sub

    Private Sub btn_search_Click(sender As EventArgs, e As EventArgs) Handles btn_Search.Click
        PerformSearch()
    End Sub

    Private Sub tb_search_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_search.KeyDown
        If e.KeyCode = Keys.Enter Then
            PerformSearch()
        End If
    End Sub

    Private Sub PerformSearch()
        Dim searchTerm As String = tb_search.Text.Trim()
        If Not String.IsNullOrEmpty(searchTerm) Then
            Dim searchUrl As String = GetSearchEngineUrlFromConfig().Replace("{query}", Uri.EscapeDataString(searchTerm))
            WebView21.CoreWebView2.Navigate(searchUrl)
        End If
    End Sub

    Private Sub btnGoURL_Click(sender As EventArgs, e As EventArgs) Handles btnGoURL.Click
        NavigateToUrl()
    End Sub

    Private Sub tb_url_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_url.KeyDown
        If e.KeyCode = Keys.Enter Then
            NavigateToUrl()
        End If
    End Sub

    Private Sub NavigateToUrl()
        Dim url As String = tb_url.Text.Trim()
        If Not String.IsNullOrEmpty(url) Then
            If Not url.StartsWith("http://") And Not url.StartsWith("https://") Then
                url = "http://" & url ' Add http if missing
            End If
            WebView21.CoreWebView2.Navigate(url)
        End If
    End Sub

    Private Sub WebView21_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs)
        tb_url.Text = WebView21.CoreWebView2.Source 'Update the tb_url with the current url
    End Sub

    Private Function GetStartUrlFromConfig() As String
        Try
            Dim configFilePath As String = Path.Combine(Application.StartupPath, "config.txt")
            If File.Exists(configFilePath) Then
                Dim lines As String() = File.ReadAllLines(configFilePath)
                For Each line As String In lines
                    Dim trimmedLine As String = line.Trim()
                    If Not trimmedLine.StartsWith("//") AndAlso trimmedLine.StartsWith("startpage =") Then
                        Dim urlPart As String = trimmedLine.Substring("startpage =".Length).Trim()
                        If Not String.IsNullOrEmpty(urlPart) Then
                            Return urlPart
                        End If
                    End If
                Next
            End If
            Return String.Empty ' Return empty if startpage is not found
        Catch ex As Exception
            ' Handle exceptions (e.g., file access errors).
            Return String.Empty
        End Try
    End Function

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        WebView21.CoreWebView2.Reload()
    End Sub

    Private Sub btnForwards_Click(sender As Object, e As EventArgs) Handles btnForwards.Click
        If WebView21.CoreWebView2.CanGoForward Then
            WebView21.CoreWebView2.GoForward()
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If WebView21.CoreWebView2.CanGoForward Then
            WebView21.CoreWebView2.GoForward()
        End If
    End Sub

    Private Function GetSearchEngineUrlFromConfig() As String
        Try
            Dim configFilePath As String = Path.Combine(Application.StartupPath, "config.txt")
            If File.Exists(configFilePath) Then
                Dim lines As String() = File.ReadAllLines(configFilePath)
                For Each line As String In lines
                    Dim trimmedLine As String = line.Trim()
                    If Not trimmedLine.StartsWith("//") AndAlso trimmedLine.StartsWith("searchengine =") Then
                        Dim urlPart As String = trimmedLine.Substring("searchengine =".Length).Trim()
                        If Not String.IsNullOrEmpty(urlPart) Then
                            Return urlPart
                        End If
                    End If
                Next
            End If
            Return "https://duckduckgo.com/?q={query}" ' Default to DuckDuckGo
        Catch ex As Exception
            ' Handle exceptions (e.g., file access errors).
            Return "https://duckduckgo.com/?q={query}" ' Default to DuckDuckGo
        End Try
    End Function
End Class