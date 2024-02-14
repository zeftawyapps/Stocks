Imports ZeftawyTools
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class myProjectWork
    Public Overloads Shared Sub GetFormDesign(ByVal myformde As myformDesign, ByVal f As myformDesign, Optional ByVal rec As recshaps = recshaps.center)
        'On Error Resume Next
       
        f.Get_MyformDesignAndControlcolor(myformde, rec)
        f.get_Close_And_MinButtons_Like_Myclose(myformde)
        f.Get_msg(myformde)
        f.SetMyControlsColor(f, True)
        f.TitelBar.BackColor = myformde.TitelBar.BackColor
        ' st.Close()
    End Sub


    Public Shared Sub changeTextforcolor(ByVal g As Control, ByVal color As Color)
        For Each c As Control In g.Controls
            If TypeOf c Is t_textbox Then
                c.ForeColor = color
            End If
        Next
    End Sub
    Public Shared Moarid As String = "مورد"
    Public Shared Client As String = "عميل"
    ''' <summary>
    ''' هذه الداله لا تستخدم في الادخال المباشر على التكست بوكس ولكن تستخدم في التحويل فقط
    ''' </summary>
    ''' <param name="un"></param>
    ''' <param name="q"></param>
    ''' <param name="opiset"></param>
    ''' <remarks></remarks>
    Friend Function UnitedQ(ByVal un As Unet_major, ByVal q As String, Optional ByVal unQ As Integer = 12, Optional ByVal opiset As Boolean = False)
        Dim val As Object
        If Not IsNumeric(q) Then Exit Function
        Select Case un
            Case Unet_major.unit
                val = q
            Case Unet_major.kg
                If Not opiset Then
                    val = q * 1000
                Else
                    val = Math.Round(q / 1000, 5)
                End If
            Case Unet_major.dasta
                If Not opiset Then
                    val = q * unQ
                Else
                    val = Math.Round(q / unQ, 2)
                End If
            Case Unet_major.leter
                If Not opiset Then
                    val = q * 1000
                Else

                    val = Math.Round(q / 1000, 5)
                End If
        End Select
        Return val
    End Function
    Public Function calculatMajor(ByVal unMajor As Unet_major, ByVal s As String, ByVal unMajlbl As t_lableButton, Optional ByVal unentQ As String = "12", Optional ByVal op As Boolean = False) As String
        If Not IsNumeric(s) Then s = 0
        If Not IsNumeric(unentQ) Then unentQ = 1

        If unMajlbl.check Then
            If op Then
                Return UnitedQ(unMajor, s, unentQ, True) 'دسته
            Else
                Return UnitedQ(unMajor, s, unentQ, False)
            End If
        Else '
            If Not op Then
                Return UnitedQ(unMajor, s, unentQ, True)
            Else
                Return UnitedQ(unMajor, s, unentQ, False)
            End If
        End If
    End Function

  
End Class
Public Class WordProcesse
    Public Shared Function WordProcess(ByVal str As String) As String
        Dim s As String = str
        Static i As String = s
        i = s.Replace("أ", "ا")
        s = i
        i = s.Replace("ى ", "ي ")
        s = i
        i = s.Replace("عبد ", "عبد")
        s = i
        i = s.Replace("ابو ", "ابو")
        s = i
        i = s.Replace("ة", "ه")
        s = i
        i = ""
        Return s
    End Function

    Public Shared Function DateProssce(ByVal str As String) As Date
        If IsNumeric(str) Then
            Dim d, m, y As String
            Dim datelen As Integer = Len(str)
            Dim dates As String
            Select Case datelen
                Case Is = 6
                    d = Mid(str, 1, 1)
                    m = Mid(str, 2, 1)
                    y = Mid(str, 3, 4)
                Case Is = 7
                    d = Mid(str, 1, 2)
                    m = Mid(str, 3, 1)
                    y = Mid(str, 4, 4)
                Case Is = 8
                    d = Mid(str, 1, 2)
                    m = Mid(str, 3, 2)
                    y = Mid(str, 5, 4)

                Case Else
                    dates = Date.Now
                    Return dates
                    Exit Function
            End Select
            Dim mm, dd As Integer
            mm = CInt(m)
            dd = CInt(d)
            If mm > 12 Then
                dd = CInt(mm)
                mm = d
                If mm > 12 Then
                    mm = 1
                End If
            End If
            Dim ddd As Integer
            Select Case mm
                Case 1, 3, 5, 7, 8, 10, 12
                    ddd = 31
                Case 4, 6, 9, 11
                    ddd = 30
                Case 2
                    Dim yyy As Integer
                    yyy = y Mod 4
                    If yyy = 0 Then
                        ddd = 29
                    Else
                        ddd = 28
                    End If
            End Select
            If dd > ddd Then
                dd = ddd
            End If
            m = CStr(mm)
            d = CInt(dd)
            dates = d + "/" + m + "/" + y
            Return CDate(dates)
        Else
            Return Date.Now
            Exit Function
        End If
    End Function
    Public Shared Function timeProssce(ByVal str As String) As Date
        If IsNumeric(str) Then
            Dim h, m, t As String
            Dim timelen As Integer = Len(str)
            Dim times As String
            Select Case timelen
                Case 2
                    h = Mid(str, 1, 1)
                    m = Mid(str, 2, 1)
                    t = "ص"
                Case Is = 3
                    h = Mid(str, 1, 1)
                    m = Mid(str, 2, 2)

                Case Is = 4
                    h = Mid(str, 1, 2)
                    m = Mid(str, 3, 2)


                Case Else
                    times = CDate("1:1 ص")
                    Return times
                    Exit Function
            End Select
            Dim mm, hh As Integer
            mm = CInt(m)
            hh = CInt(h)
            If hh > 23 Then
                mm = CInt(hh)
                hh = m

                If hh > 23 Then
                    hh = 1
                    t = "ص"
                End If
            End If
            Dim hhh As Integer
            Select Case hh
                Case Is >= 12
                    hhh = hh - 12
                    t = "م"
                    hh = hhh
                Case Is < 12
                    t = "ص"

            End Select
            If mm > 59 Then mm = 1
            m = CStr(mm)
            h = CInt(hh)
            times = h + ":" + m + " " + t
            Return CDate(times)
        Else
            Return CDate("1:1 ص")
            Exit Function
        End If
    End Function

   
End Class
