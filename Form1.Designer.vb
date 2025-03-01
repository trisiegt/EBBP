<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tb_url = New System.Windows.Forms.TextBox()
        Me.tb_search = New System.Windows.Forms.TextBox()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.btnGoURL = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnForwards = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_url
        '
        Me.tb_url.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_url.Location = New System.Drawing.Point(113, 12)
        Me.tb_url.Name = "tb_url"
        Me.tb_url.Size = New System.Drawing.Size(545, 20)
        Me.tb_url.TabIndex = 1
        '
        'tb_search
        '
        Me.tb_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_search.Location = New System.Drawing.Point(758, 12)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.Size = New System.Drawing.Size(145, 20)
        Me.tb_search.TabIndex = 2
        '
        'btn_Search
        '
        Me.btn_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Search.Location = New System.Drawing.Point(909, 13)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(30, 19)
        Me.btn_Search.TabIndex = 3
        Me.btn_Search.Text = "Go!"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'btnGoURL
        '
        Me.btnGoURL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGoURL.Location = New System.Drawing.Point(664, 12)
        Me.btnGoURL.Name = "btnGoURL"
        Me.btnGoURL.Size = New System.Drawing.Size(34, 20)
        Me.btnGoURL.TabIndex = 4
        Me.btnGoURL.Text = "Go"
        Me.btnGoURL.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(89, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(18, 31)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "↻"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnForwards
        '
        Me.btnForwards.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForwards.Location = New System.Drawing.Point(59, 4)
        Me.btnForwards.Name = "btnForwards"
        Me.btnForwards.Size = New System.Drawing.Size(24, 30)
        Me.btnForwards.TabIndex = 6
        Me.btnForwards.Text = "→"
        Me.btnForwards.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(36, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(23, 30)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Location = New System.Drawing.Point(5, 58)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(933, 466)
        Me.WebView21.TabIndex = 8
        Me.WebView21.ZoomFactor = 1.0R
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(12, 4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(23, 30)
        Me.btnHome.TabIndex = 9
        Me.btnHome.Text = "⌂"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(704, 6)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 29)
        Me.btnHelp.TabIndex = 10
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 533)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.WebView21)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnForwards)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnGoURL)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.tb_search)
        Me.Controls.Add(Me.tb_url)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Edge-Based Browser Project"
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_url As TextBox
    Friend WithEvents tb_search As TextBox
    Friend WithEvents btn_Search As Button
    Friend WithEvents btnGoURL As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnForwards As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents btnHome As Button
    Friend WithEvents btnHelp As Button
End Class
