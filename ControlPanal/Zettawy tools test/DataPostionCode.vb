Imports System.ComponentModel
Imports ZeftawyTools

Public Class DataPostionCode



    ''' <summary>
    ''' اده تسهل للنقل بين السجلات وتتعامل مع  تصنيف الربط بالكود
    ''' </summary>
    ''' <remarks></remarks>

    Public Event movelast()
    Public Event movenext()
    Public Event movepreveus()
    Public Event movefirst()
    Public Event moveingRecord()

    Private Sub T_button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles movefirstB.Click
        RaiseEvent movefirst()
        RaiseEvent moveingRecord()
    End Sub

    Private fb As Color
    ''' <summary> 
    ''' لون الخط للزر
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description("  لون الخط للزر")> _
    Public Property ButtonFareColor() As Color
        Get
            Return fb
        End Get
        Set(ByVal value As Color)
            fb = value
            movefirstB.font_color = value
            movelastB.font_color = value
            movenextB.font_color = value
            moveprevB.font_color = value
        End Set
    End Property
    Private tecolor As Color
    Private Property Txtcolor() As Color
        Get
            Return tecolor
        End Get
        Set(ByVal value As Color)
            tecolor = value
            TextBox1.BackColor = value
        End Set
    End Property
    Private DataC As New OLEdatabaseCodeing
    ''' <summary> 
    ''' الربط بادة الكود
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(False)> _
    <Category("ZeftawyTools")> _
        <Description("باندينج سورس")> _
    Public Property DataCode() As OLEdatabaseCodeing
        Get
            Return DataC
        End Get
        Set(ByVal value As OLEdatabaseCodeing)
            DataC = value
        End Set
    End Property
    Private Sub move_last() Handles Me.movelast

        If Me.DataCode Is Nothing Then Exit Sub
        Me.DataCode.MoveLast()
        pchang()
    End Sub
    Private Sub move_next() Handles Me.movenext

        If Me.DataCode Is Nothing Then Exit Sub
        
            Me.DataCode.MoveNext()
            pchang()

    End Sub
    Private Sub move_first() Handles Me.movefirst

        If Me.DataCode Is Nothing Then Exit Sub
        Me.DataCode.MoveFirst()
        pchang()
    End Sub
    Private Sub move_prev() Handles Me.movepreveus

        If Me.DataCode Is Nothing Then Exit Sub
        Me.DataCode.MovePriviose()
        pchang()
    End Sub
    ''' <summary>
    ''' اظها رقم السجل
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub pchang()
        Me.TextBox1.Text = Me.DataCode.rowNo + 1
    End Sub
    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles movelastB.Click
        RaiseEvent movelast()
        RaiseEvent moveingRecord()
    End Sub

    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles movenextB.Click
        RaiseEvent movenext()
        RaiseEvent moveingRecord()
    End Sub
    Private cent_color As Color = Color.DodgerBlue
    ''' <summary> 
    ''' اللون ا لوسطي للزر في حالة التحميل
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description(" اللون الوسطي للزر في حالة  التحميل")> _
    <DefaultValueAttribute(GetType(Color), "PaleGreen")> _
    Public Property meloodcenter_color() As Color
        Get
            Return cent_color
        End Get
        Set(ByVal value As Color)
            cent_color = value
            movefirstB.meloodcenter_color = value
            moveprevB.meloodcenter_color = value
            movenextB.meloodcenter_color = value
            movelastB.meloodcenter_color = value
        End Set
    End Property
    Private surru_color As Color = Color.Blue
    ''' <summary> 
    ''' اللون ا الطرفي  للزر في حالة  التحميل
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description(" اللون الطرفي للزر في حالة  التحميل")> _
    <DefaultValueAttribute(GetType(Color), "LimeGreen")> _
    Public Property meloodserruonding_color() As Color
        Get
            Return surru_color
        End Get
        Set(ByVal value As Color)
            surru_color = value
            ' cent_color = value
            movefirstB.meloodserruonding_color = value
            moveprevB.meloodserruonding_color = value
            movenextB.meloodserruonding_color = value
            movelastB.meloodserruonding_color = value
        End Set
    End Property
    Private meclc_cent_color As Color = Color.Crimson
    ''' <summary> 
    ''' اللون ا لوسطي للزر في حالة نقر الزر
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description(" اللون الوسطي للزر في حالة   نقر الزر")> _
    <DefaultValueAttribute(GetType(Color), "GreenYellow")> _
    Public Property buttonclick_center_color() As Color
        Get
            Return meclc_cent_color
        End Get
        Set(ByVal value As Color)
            meclc_cent_color = value

            movefirstB.buttonclick_center_color = value
            moveprevB.buttonclick_center_color = value
            movenextB.buttonclick_center_color = value
            movelastB.buttonclick_center_color = value
        End Set
    End Property
    Private meclcsurrou_color As Color = Color.Cyan
    ''' <summary> 
    ''' اللون ا الطرفي  للزر في حالة نقر الزر
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description(" اللون الطرفي  للزر في حالة  نقر الزر")> _
    <DefaultValueAttribute(GetType(Color), "LimeGreen")> _
    Public Property buttonclick_surrounding_color() As Color
        Get
            Return meclcsurrou_color
        End Get
        Set(ByVal value As Color)
            meclcsurrou_color = value

            movefirstB.buttonclick_surrounding_color = value
            moveprevB.buttonclick_surrounding_color = value
            movenextB.buttonclick_surrounding_color = value
            movelastB.buttonclick_surrounding_color = value
        End Set
    End Property
    Private for_color As Color = Color.Black
    ''' <summary> 
    ''' لون خط نص الزر
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description(" لون خط نص الزر")> _
    Public Property font_color() As Color
        Get
            Return for_color
        End Get
        Set(ByVal value As Color)
            for_color = value
            Me.movefirstB.font_color = value
            Me.movenextB.font_color = value
            Me.moveprevB.font_color = value
            Me.movelastB.font_color = value

        End Set
    End Property
    Private movefor_color As Color = Color.White
    ''' <summary> 
    '''  لون الخط للزر في حالةمرور الماوس
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description("  لون الخط للزر في حالة مرور الماوس")> _
    Public Property font_color_Mousemove() As Color
        Get
            Return movefor_color
        End Get
        Set(ByVal value As Color)
            movefor_color = value
            Me.movefirstB.font_color_Mousemove = value
            Me.movenextB.font_color_Mousemove = value
            Me.moveprevB.font_color_Mousemove = value
            Me.movelastB.font_color_Mousemove = value

        End Set
    End Property
    Private clickfor_color As Color = Color.Yellow
    ''' <summary> 
    '''  لون الخط للزر في حالة نقر الزر
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description("  لون الخط للزر في حالة نقر الزر")> _
    Public Property font_color_Mouseclick() As Color
        Get
            Return clickfor_color
        End Get
        Set(ByVal value As Color)
            clickfor_color = value
            Me.movefirstB.font_color_Mouseclick = value
            Me.movenextB.font_color_Mouseclick = value
            Me.moveprevB.font_color_Mouseclick = value
            Me.movelastB.font_color_Mouseclick = value

        End Set
    End Property
    Private memovecent_color As Color = Color.Lime
    ''' <summary> 
    ''' اللون ا لوسطي للزر في حالة  مرور الماوس
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description(" اللون الوسطي للزر في حالة   مرور الماوس")> _
    <DefaultValueAttribute(GetType(Color), "LimeGreen")> _
    Public Property mousemove_center_color() As Color
        Get
            Return memovecent_color
        End Get
        Set(ByVal value As Color)
            memovecent_color = value

            movefirstB.mousemove_center_color = value
            moveprevB.mousemove_center_color = value
            movenextB.mousemove_center_color = value
            movelastB.mousemove_center_color = value
        End Set
    End Property
    Private memovesurr_color As Color = Color.GreenYellow
    ''' <summary> 
    ''' اللون ا الطرفي  للزر في حالة  مرور الماوس
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description(" اللون الطرفي للزر في حالة  مرور الماوس")> _
    <DefaultValueAttribute(GetType(Color), "GreenYellow")> _
    Public Property mousrmove_surronding_color() As Color
        Get
            Return memovesurr_color
        End Get
        Set(ByVal value As Color)
            memovesurr_color = value

            movefirstB.mousrmove_surronding_color = value
            moveprevB.mousrmove_surronding_color = value
            movenextB.mousrmove_surronding_color = value
            movelastB.mousrmove_surronding_color = value
        End Set
    End Property



    Private Sub T_button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles moveprevB.Click
        RaiseEvent movepreveus()
        RaiseEvent moveingRecord()
    End Sub
    Private t As String
    ''' <summary> 
    ''' عنوان الاداة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description("  عنوان الاداة")> _
    Public Overrides Property text() As String
        Get
            Return t
        End Get
        Set(ByVal value As String)
            t = value
            Me.GroupBox1.Text = value
        End Set
    End Property
    ''' <summary> 
    ''' لون خط عنوان الاداة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description("   لون خط عنوان الاداه")> _
    Public Overrides Property ForeColor() As System.Drawing.Color
        Get

            Return MyBase.ForeColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            MyBase.ForeColor = value
            Me.GroupBox1.ForeColor = value
        End Set
    End Property
    ''' <summary> 
    '''  خط عنوان الاداه
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description("  خط عنوان الاداة")> _
    Public Overrides Property Font() As System.Drawing.Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As System.Drawing.Font)
            MyBase.Font = value

            movefirstB.Font = value
            moveprevB.Font = value
            movenextB.Font = value
            movelastB.Font = value

        End Set
    End Property
    Private f As Font
    ''' <summary> 
    ''' عنوان الاداة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Category("ZeftawyTools")> _
        <Description("  عنوان الاداة")> _
    Public Property textfont() As System.Drawing.Font
        Get
            Return f
        End Get
        Set(ByVal value As System.Drawing.Font)
            f = value
            Me.GroupBox1.Font = value
        End Set
    End Property


    Private Sub datapostion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        pchang()

    End Sub
    Private Sub moveto()

        If Not IsNumeric(TextBox1.Text) Then
            Dim i As Integer
            TextBox1.Text = 1
            i = TextBox1.Text
            If i > DataCode.DataTable.Rows.Count Then i = DataCode.DataTable.Rows.Count - 1
            DataCode.MoveTo(i)

        End If
        RaiseEvent moveingRecord()
    End Sub
    ''' <summary>
    '''MyDesignForm تعديل الزر على اساس الزر في 
    ''' </summary>
    ''' <param name="b"></param>
    ''' <remarks></remarks>
    Public Sub GetT_buttonColor(ByVal b As t_button)
        Me.mousemove_center_color = b.mousemove_center_color
        Me.mousrmove_surronding_color = b.mousrmove_surronding_color
        Me.buttonclick_center_color = b.buttonclick_center_color
        Me.buttonclick_surrounding_color = b.buttonclick_surrounding_color
        Me.meloodcenter_color = b.meloodcenter_color
        Me.meloodserruonding_color = b.meloodserruonding_color
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            moveto()
        End If
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        moveto()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
