Imports ZeftawyTools
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
<Serializable()> _
Public Class DesigneControlFrm
    Inherits myformDesign
    Implements ISerializable

    Private Sub DesigneControlFrm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        LoadPrpertyfrm()
    End Sub

    Private Sub DesigneControlFrm_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        LoadPrpertyfrm()
    End Sub
    Private Sub DesigneControlFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        prperty_hide()
    End Sub
    Private Sub prperty_hide()
        t_txtPnl.Visible = False
        T_buttonpnl.Visible = False
        FrmPnl.Visible = False
    End Sub
    Private Sub loadPrpertySizes(ByVal p As Panel)
        prperty_hide()
        p.Width = 285
        p.Top = 43
        p.Left = 538
    End Sub
    Private Sub LoadPrpertyT_button()
        loadPrpertySizes(T_buttonpnl)
        T_buttonpnl.Height = 709
        T_buttonpnl.Visible = True
    End Sub

    Private Sub LoadPrpertyt_text()
        loadPrpertySizes(t_txtPnl)
        t_txtPnl.Height = 709
        t_txtPnl.Visible = True
    End Sub

    Private Sub LoadPrpertyfrm()
        loadPrpertySizes(FrmPnl)
        FrmPnl.Height = 485
        FrmPnl.Visible = True
    End Sub
    Private Sub RunTimePorperty1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'T_button.meloodcenter_color = RunTimeColorPorperty1.Color
    End Sub

    Private Sub RunTimeColorPorperty1_ColorChange() Handles loadSCprty.ColorChange
        T_button.meloodserruonding_color = loadSCprty.Color
        T_button.Refresh()

        MsgT_Button.meloodserruonding_color = loadSCprty.Color
        MsgT_Button.Refresh()
        T_button1.meloodserruonding_color = T_button.meloodserruonding_color
        T_button1.Refresh()
    End Sub

    Private Sub RunTimeColorPorperty1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadSCprty.Load
        T_button.meloodserruonding_color = loadSCprty.Color
        T_button.Refresh()

        MsgT_Button.meloodserruonding_color = loadSCprty.Color
        MsgT_Button.Refresh()
        T_button1.meloodserruonding_color = T_button.meloodserruonding_color
        T_button1.Refresh()
    End Sub

    Private Sub loaCcprty_ColorChange() Handles loaCcprty.ColorChange
        T_button.meloodcenter_color = loaCcprty.Color
        T_button.Refresh()

        MsgT_Button.meloodcenter_color = loaCcprty.Color
        MsgT_Button.Refresh()
        T_button1.meloodcenter_color = T_button.meloodcenter_color
        T_button1.Refresh()
    End Sub

    Private Sub loaCcprty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loaCcprty.Load
        T_button.meloodcenter_color = loaCcprty.Color
        T_button.Refresh()

        MsgT_Button.meloodcenter_color = loaCcprty.Color
        MsgT_Button.Refresh()
        T_button1.meloodcenter_color = T_button.meloodcenter_color
        T_button1.Refresh()
    End Sub

    Private Sub moveSCprty_ColorChange() Handles moveSCprty.ColorChange
        T_button.mousrmove_surronding_color = moveSCprty.Color
        T_button.Refresh()

        MsgT_Button.mousrmove_surronding_color = moveSCprty.Color
        MsgT_Button.Refresh()
        T_button1.mousrmove_surronding_color = T_button.mousrmove_surronding_color
        T_button1.Refresh()
    End Sub


    Private Sub moveSCprty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles moveSCprty.Load
        T_button.mousrmove_surronding_color = moveSCprty.Color
        T_button.Refresh()

        MsgT_Button.mousrmove_surronding_color = moveSCprty.Color
        MsgT_Button.Refresh()
        T_button1.mousrmove_surronding_color = T_button.mousrmove_surronding_color
        T_button1.Refresh()
    End Sub

    Private Sub moveCcprty_ColorChange() Handles moveCcprty.ColorChange
        T_button.mousemove_center_color = moveCcprty.Color
        T_button.Refresh()

        MsgT_Button.mousemove_center_color = moveCcprty.Color
        MsgT_Button.Refresh()
        T_button1.mousemove_center_color = T_button.mousemove_center_color
        T_button1.Refresh()
    End Sub

    Private Sub moveCcprty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles moveCcprty.Load
        T_button.mousemove_center_color = moveCcprty.Color
        T_button.Refresh()

        MsgT_Button.mousemove_center_color = moveCcprty.Color
        MsgT_Button.Refresh()
        T_button1.mousemove_center_color = T_button.mousemove_center_color
        T_button1.Refresh()
    End Sub

    Private Sub ClickSCprty_ColorChange() Handles ClickSCprty.ColorChange
        T_button.buttonclick_surrounding_color = ClickSCprty.Color
        T_button.Refresh()

        MsgT_Button.buttonclick_surrounding_color = ClickSCprty.Color
        MsgT_Button.Refresh()
        T_button1.buttonclick_surrounding_color = T_button.buttonclick_surrounding_color
        T_button1.Refresh()
    End Sub

    Private Sub ClickSCprty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClickSCprty.Load
        T_button.buttonclick_surrounding_color = ClickSCprty.Color
        T_button.Refresh()

        MsgT_Button.buttonclick_surrounding_color = ClickSCprty.Color
        MsgT_Button.Refresh()
        T_button1.buttonclick_surrounding_color = T_button.buttonclick_surrounding_color
        T_button1.Refresh()
    End Sub

    Private Sub ClickCcprty_ColorChange() Handles ClickCcprty.ColorChange
        T_button.buttonclick_center_color = ClickCcprty.Color
        T_button.Refresh()

        MsgT_Button.buttonclick_center_color = ClickCcprty.Color
        MsgT_Button.Refresh()
        T_button1.buttonclick_center_color = T_button.buttonclick_center_color
        T_button1.Refresh()
    End Sub

    Private Sub ClickCcprty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClickCcprty.Load
        T_button.buttonclick_center_color = ClickCcprty.Color
        T_button.Refresh()

        MsgT_Button.buttonclick_center_color = ClickCcprty.Color
        MsgT_Button.Refresh()
        T_button1.buttonclick_center_color = T_button.buttonclick_center_color
        T_button1.Refresh()
    End Sub

    Private Sub ForeColorprty_ColorChange() Handles ForeColorprty.ColorChange
        T_button.font_color_Mouseclick = ForeColorprty.Color
        T_button.Refresh()

        MsgT_Button.font_color_Mouseclick = ForeColorprty.Color
        MsgT_Button.Refresh()
        T_button1.font_color_Mouseclick = T_button.font_color_Mouseclick
        T_button1.Refresh()
    End Sub


    Private Sub ForeColorprty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForeColorprty.Load
        T_button.font_color_Mouseclick = ForeColorprty.Color
        T_button.Refresh()

        MsgT_Button.font_color_Mouseclick = ForeColorprty.Color
        MsgT_Button.Refresh()
        T_button1.font_color_Mouseclick = T_button.font_color_Mouseclick
        T_button1.Refresh()
    End Sub

    Private Sub T_textprty_ColorChange() Handles T_textprty.ColorChange
        T_textbox.BackColor = T_textprty.Color

    End Sub

    Private Sub T_textprty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textprty.Load
        T_textbox.BackColor = T_textprty.Color

    End Sub

    Private Sub t_txtEnterprty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_txtEnterprty.Load
        T_textbox.enter_color = t_txtEnterprty.Color

    End Sub

    Private Sub FCtxtprty_ColorChange() Handles FCtxtprty.ColorChange
        T_textbox.textColor = FCtxtprty.Color
    End Sub

    Private Sub FCtxtprty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FCtxtprty.Load
        T_textbox.textColor = FCtxtprty.Color

    End Sub

    Private Sub Lbltrpy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbltrpy.Load
        Labelbox.ForeColor = Lbltrpy.Color
        MsgText.ForeColor = Lbltrpy.Color
    End Sub

    Private Sub SCfrmprty_ColorChange() Handles SCfrmprty.ColorChange
        Me.MyFormSurrundColor = SCfrmprty.Color
        Me.Refresh()
    End Sub

    Private Sub SCfrmprty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SCfrmprty.Load
        Me.MyFormSurrundColor = SCfrmprty.Color
        Me.Refresh()
    End Sub

    Private Sub CCfrmprty_ColorChange() Handles CCfrmprty.ColorChange
        Me.MyFormCenterColor = CCfrmprty.Color
        Me.Refresh()
    End Sub

    Private Sub CCfrmprty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCfrmprty.Load
        Me.MyFormCenterColor = CCfrmprty.Color
        Me.Refresh()
    End Sub

    Private Sub Titlprty_ColorChange() Handles Titlprty.ColorChange
        Titel.ForeColor = Titlprty.Color
    End Sub

    Private Sub Titlprty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Titlprty.Load
        Titel.ForeColor = Titlprty.Color
    End Sub

    Private Sub TitelParPrty_ColorChange() Handles TitelParPrty.ColorChange
        TitelBar.BackColor = TitelParPrty.Color
        MsgTilteBar.BackColor = TitelParPrty.Color
    End Sub

    Private Sub TitelParPrty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitelParPrty.Load
        TitelBar.BackColor = TitelParPrty.Color
        MsgTilteBar.BackColor = TitelParPrty.Color
    End Sub

    Private Sub MsgPrty_ColorChange() Handles MsgPrty.ColorChange
        massegBoxFormat.BackColor = MsgPrty.Color
    End Sub

    Private Sub MsgPrty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgPrty.Load
        massegBoxFormat.BackColor = MsgPrty.Color
    End Sub

    Private Sub T_textbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox.Enter
        LoadPrpertyt_text()

    End Sub

    Private Sub MsgT_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgT_Button.Click
        LoadPrpertyT_button()
    End Sub

    

    Public Sub GetObjectData(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext) Implements System.Runtime.Serialization.ISerializable.GetObjectData
        info.AddValue("form", Me.MyFormCenterColor)

    End Sub
    ' Deserialization
    
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    ' Deserialization
    Private Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        Dim s As SerializationInfoEnumerator
        s = info.GetEnumerator()

    End Sub

    Private Sub CloosBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloosBtn.Click
        
        Dim FDC As New DesigneControlFrm
        FDC = Me
        Dim st As FileStream = File.Open("FDC.zdc", FileMode.OpenOrCreate)
        Dim fdd As New BinaryFormatter
        fdd.Serialize(st, FDC)
        st.Close()



    End Sub
    Friend info As SerializationInfo
    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click
        myProjectWork.GetFormDesign(DesgineFrm, Me)
    End Sub

    Private Sub T_button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button3.Click
        Dim FDC As New DesigneControlFrm
        FDC = Me
        Dim st As FileStream = File.Open("FDC.zdc", FileMode.OpenOrCreate)
        Dim fdd As New BinaryFormatter
        fdd.Serialize(st, FDC)
        st.Close()

    End Sub

    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click

    End Sub
End Class