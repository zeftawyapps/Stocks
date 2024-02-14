Imports System.Drawing.Printing

Public Class InvoicePrint

#Region " الخصائص الاساسية"
#Region "invoice page"
    Private WithEvents inv As PrintDocument
    Public Property MyInvoice As PrintDocument
        Get
            Return inv
        End Get
        Set(ByVal value As PrintDocument)
            inv = value
        End Set
    End Property
    Private marge As Margins
    ''' <summary>
    ''' يحدد هوامش الصفحة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PageMargien As Margins
        Get
            Return marge
        End Get
        Set(ByVal value As Margins)
            marge = value
        End Set
    End Property
    Private recpage As Rectangle
    ''' <summary>
    ''' يحدد حدود التقرير يعني يطرح من الصفحة الهوامش
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Property PageArea As Rectangle
        Get
            Return recpage
        End Get
        Set(ByVal value As Rectangle)
            recpage = value
        End Set
    End Property
#End Region
#Region "الاجزاء"
    Private headRec As Rectangle
    ''' <summary>
    ''' منطقة الراس الاولى
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FirstHeadArea As Rectangle
        Get
            Return headRec
        End Get
        Set(ByVal value As Rectangle)
            headRec = value
        End Set
    End Property

    Private S_headRec As Rectangle
    ''' <summary>
    '''  منطقة الراس الثانية
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SecondHeadArea As Rectangle
        Get
            Return S_headRec
        End Get
        Set(ByVal value As Rectangle)
            S_headRec = value
        End Set
    End Property

    Private Body As Rectangle
    ''' <summary>
    ''' حسم الفاتورة
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property BodyArea As Rectangle
        Get
            Return Body
        End Get
        Set(ByVal value As Rectangle)
            Body = value
        End Set
    End Property
    Private footRec As Rectangle
    ''' <summary>
    '''   منطقة الذيل 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FoaterArea As Rectangle
        Get
            Return footRec
        End Get
        Set(ByVal value As Rectangle)
            footRec = value
        End Set
    End Property

    '>>>>>>>>>>>>>>>>>>>Report parts in Aereas <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Private headpar As New reportPart
    ''' <summary>
    '''   جزء راس التقرير 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Markpart As reportPart
        Get
            Return headpar
        End Get
        Set(ByVal value As reportPart)
            headpar = value
        End Set
    End Property
    Private Markfont As New Font("Arial", 24, FontStyle.Underline)
    Private font As New Font("Arial", 20)
    Private _font As New Font("Arial", 20)

    ' زي الlabel
    Private NamePart, DatePart, InvoiceNopart As New reportPart
    'لادخال البيانات
    Private _NamePart, _DatePart, _InvoiceNopart As New reportPart
    Private Paperheight, paperWith As Single
#End Region
#End Region
#Region "setting Subs  "
    Private paperSize As New PaperSize
    Public Sub setPapers(ByVal w As Single)
        Dim wi As Integer = w * 100
        Dim hi As Integer = 500
        paperSize.PaperName = "Inv" : paperSize.Height = hi : paperSize.Width = wi
        Dim doc As New PrintDocument
        doc.DefaultPageSettings.PaperSize = paperSize
        Dim marg As New Margins
        doc.DefaultPageSettings.Margins.Top = 1
        doc.DefaultPageSettings.Margins.Bottom = 1
        doc.DefaultPageSettings.Margins.Left = 1
        doc.DefaultPageSettings.Margins.Right = 1
        doc.DefaultPageSettings.Landscape = False
        MyInvoice = doc
        marg = doc.DefaultPageSettings.Margins

        PageMargien = marg

        SetInvArea()
    End Sub
    Private Sub SetInvArea()
        Dim rec As New Rectangle
        rec.Y = MyInvoice.DefaultPageSettings.Bounds.Top + PageMargien.Top
        rec.X = MyInvoice.DefaultPageSettings.Bounds.Left + PageMargien.Left
        rec.Height = MyInvoice.DefaultPageSettings.Bounds.Height - PageMargien.Bottom - rec.Y
        rec.Width = MyInvoice.DefaultPageSettings.Bounds.Width - PageMargien.Right - rec.X
        PageArea = rec
    End Sub
    Public Sub Setinvoicepart()
        SetInvPart()

    End Sub
    Private Sub SetInvPart()
        Dim rec As New Rectangle
        Dim f As New Font("Arial", 24)
        Dim mash As New Size
        mash = TextRenderer.MeasureText("Z-Apps", f)
        '>>>>>>>>>>>>>>>>الراس الاول<<<<<<<<<<<<<<<<
        With rec
            .X = PageArea.Left
            .Y = PageArea.Top
            .Width = PageArea.Width
            .Height = mash.Height
        End With
        FirstHeadArea = rec
        '>>>>>>>>>>>>>>>>الراس الثاني<<<<<<<<<<<<<<<<
        With rec
            .X = PageArea.Left
            .Y = FirstHeadArea.Bottom + 25
            .Width = PageArea.Width
            .Height = mash.Height * 3
        End With
        SecondHeadArea = rec
        '>>>>>>>>>>>>>>>>جسم الفاتورة<<<<<<<<<<<<<<<<
        With rec
            .X = PageArea.Left
            .Y = SecondHeadArea.Bottom
            .Width = PageArea.Width
            .Height = mash.Height * 10
        End With
        BodyArea = rec
        '>>>>>>>>>>>>>>>>ذيل الفاتورة<<<<<<<<<<<<<<<<
        With rec
            .X = PageArea.Left
            .Y = BodyArea.Bottom
            .Width = PageArea.Width
            .Height = mash.Height * 3
        End With
        FoaterArea = rec
    End Sub

    Public Sub SetHeaders(ByVal mark As String, ByVal dates As String, ByVal Names As String, ByVal invno As String)
        Dim rec, _rec, markRec As New Rectangle
        Dim markSize, lblsize, txtsize As New Size
        markSize = TextRenderer.MeasureText(mark, Markfont)

        With markRec
            .Y = FirstHeadArea.Top
            .Width = markSize.Width
            .X = 100
            .Height = markSize.Height
        End With
        Markpart.reCtSetting(markRec)
        Markpart.SetText(mark, allinge.Center)
        Markpart.StringFont.SetFont(Color.Black, Markfont)
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> SecondHeader labels <<<<<<<<<<<<<<<<<<<<<<<<
        Dim lblfont As New Font("Arial", 18, FontStyle.Bold)

        'date
        lblsize = TextRenderer.MeasureText("التاريخ     :", lblfont)
        With rec
            .Height = lblsize.Height
            .Width = lblsize.Width
            .Y = SecondHeadArea.Top
            .X = SecondHeadArea.Right - rec.Width
        End With
        DatePart.reCtSetting(rec)
        DatePart.SetText("التاريخ    :", allinge.Center)
        DatePart.StringFont.SetFont(Color.Black, lblfont)
        'invoice nomber
        lblsize = TextRenderer.MeasureText(" : رقم الفاتورة", lblfont)
        With rec
            .Height = lblsize.Height
            .Width = lblsize.Width
            .Y = DatePart.Rectangle.Bottom
            .X = SecondHeadArea.Right - rec.Width
        End With
        InvoiceNopart.reCtSetting(rec)
        InvoiceNopart.SetText("رقم الفاتورة:  ", allinge.Center)
        InvoiceNopart.StringFont.SetFont(Color.Black, lblfont)
        'name
        lblsize = TextRenderer.MeasureText("الكاشير      :", lblfont)
        With rec
            .Height = lblsize.Height
            .Width = lblsize.Width
            .Y = InvoiceNopart.Rectangle.Bottom
            .X = SecondHeadArea.Right - rec.Width
        End With
        NamePart.reCtSetting(rec)
        NamePart.SetText("الكاشير     :", allinge.Center)
        NamePart.StringFont.SetFont(Color.Black, lblfont)

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> SecondHeader  texts <<<<<<<<<<<<<<<<<<<<<<<<
        Dim txtfont As New Font("Arial", 16, FontStyle.Underline)

        'date
        txtsize = TextRenderer.MeasureText(dates, txtfont)
        With _rec
            .Y = SecondHeadArea.Top
            .Height = txtsize.Height
            .Width = txtsize.Width
            .X = DatePart.Rectangle.Left - txtsize.Width
        End With
        _DatePart.reCtSetting(_rec)
        _DatePart.SetText(dates, allinge.reight)
        _DatePart.StringFont.SetFont(Color.Black, txtfont)

        'invoice no 
        txtsize = TextRenderer.MeasureText(invno, txtfont)
        With _rec
            .Y = _DatePart.Rectangle.Bottom
            .Height = txtsize.Height
            .Width = txtsize.Width
            .X = InvoiceNopart.Rectangle.Left - txtsize.Width
        End With
        _InvoiceNopart.reCtSetting(_rec)
        _InvoiceNopart.SetText(invno, allinge.reight)
        _InvoiceNopart.StringFont.SetFont(Color.Black, txtfont)

        'Name
        txtsize = TextRenderer.MeasureText(Names, txtfont)
        With _rec
            .Y = InvoiceNopart.Rectangle.Bottom
            .Height = txtsize.Height
            .Width = txtsize.Width
            .X = NamePart.Rectangle.Left - txtsize.Width
        End With
        _NamePart.reCtSetting(_rec)
        _NamePart.SetText(Names, allinge.reight)
        _NamePart.StringFont.SetFont(Color.Black, txtfont)
    End Sub

    Public Sub SetFooters(ByVal val As String, ByVal P As String, ByVal S As String)
        Dim rec, _rec As New Rectangle
        Dim lblsize, txtsize As New Size



        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Footer labels <<<<<<<<<<<<<<<<<<<<<<<<
        Dim lblfont As New Font("Arial", 18, FontStyle.Bold)

        'Total
        lblsize = TextRenderer.MeasureText("الاجمالي :", lblfont)
        With rec
            .Height = lblsize.Height
            .Width = lblsize.Width
            .Y = FoaterArea.Top
            .X = FoaterArea.Right - lblsize.Width
        End With
        TotalV.reCtSetting(rec)
        TotalV.SetText("الاجمالي :", allinge.Center)
        TotalV.StringFont.SetFont(Color.Black, lblfont)
        'Paid
        lblsize = TextRenderer.MeasureText(" : المدفوع", lblfont)
        With rec
            .Height = lblsize.Height
            .Width = lblsize.Width
            .Y = TotalV.Rectangle.Bottom
            .X = FoaterArea.Right - lblsize.Width
        End With
        Paid.reCtSetting(rec)
        Paid.SetText("المدفوع  :", allinge.Center)
        Paid.StringFont.SetFont(Color.Black, lblfont)

        'Steal
        lblsize = TextRenderer.MeasureText("الباقي    :", lblfont)
        With rec
            .Height = lblsize.Height
            .Width = lblsize.Width
            .Y = Paid.Rectangle.Bottom
            .X = FoaterArea.Right - rec.Width
        End With
        Steal.reCtSetting(rec)
        Steal.SetText("الباقي    :", allinge.Center)
        Steal.StringFont.SetFont(Color.Black, lblfont)

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Footer  texts <<<<<<<<<<<<<<<<<<<<<<<<

        Dim txtfont As New Font("Arial", 18, FontStyle.Underline)

        'Total
        txtsize = TextRenderer.MeasureText(val, txtfont)
        With rec
            .Height = txtsize.Height
            .Width = txtsize.Width
            .Y = FoaterArea.Top
            .X = TotalV.Rectangle.X - txtsize.Width
        End With
        _TotalV.reCtSetting(rec)
        _TotalV.SetText(val, allinge.Center)
        _TotalV.StringFont.SetFont(Color.Black, txtfont)

        'Paid
        txtsize = TextRenderer.MeasureText(P, txtfont)
        With rec
            .Height = txtsize.Height
            .Width = txtsize.Width
            .Y = _TotalV.Rectangle.Bottom
            .X = Paid.Rectangle.X - txtsize.Width
        End With
        _Paid.reCtSetting(rec)
        _Paid.SetText(P, allinge.Center)
        _Paid.StringFont.SetFont(Color.Black, txtfont)

        'Steal
        txtsize = TextRenderer.MeasureText(S, txtfont)
        With rec
            .Height = txtsize.Height
            .Width = txtsize.Width
            .Y = Paid.Rectangle.Bottom
            .X = Steal.Rectangle.X - txtsize.Width
        End With
        _Steal.reCtSetting(rec)
        _Steal.SetText(S, allinge.Center)
        _Steal.StringFont.SetFont(Color.Black, lblfont)


        Editpaper()

    End Sub
    Private Sub EditParts()

    End Sub
    Private Sub Editpaper()
        Dim rec As New Rectangle
        rec = PageArea
        rec.Height = (FirstHeadArea.Height + SecondHeadArea.Height + BodyArea.Height + FoaterArea.Height + 10)
        PageArea = rec
        paperSize.Height = PageArea.Height
    End Sub
#End Region
#Region "حسم الفاتورة"
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>بيانات الجدول<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Private SaVal, QVal, PVal, TotalVal As String()
    Private SaValR, QValR, PValR, TotalValR As reportPart()
    Private SaValRh, QValRh, PValRh, TotalValRh As New reportPart
    Private Sanfrec, Qrec, Prec, Valrec As New Rectangle
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>جسم الجدول<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    Private TotalV, Paid, Steal As New reportPart
    'لادخال البيانات
    Private _TotalV, _Paid, _Steal As New reportPart


    Private fh As New Font("Arial", 16, FontStyle.Underline)
    Private f As New Font("Arial", 14)
    Public Sub SetBodyArea(ByVal Datagrid As DataGridView, ByVal sanf As Integer, ByVal Q As Integer, ByVal P As Integer, ByVal Val As Integer)
        
        Dim dg As New DataGridView
        dg = Datagrid
        Dim r As Integer = dg.RowCount
        Dim o As Object
        Dim totalHiget As Integer
        totalHiget = (r * f.Height) + fh.Height
        Dim rec As New Rectangle
        rec = BodyArea

        rec.Height = totalHiget
        BodyArea = rec
        Dim Eval1(r - 1), Eval2(r - 1), Eval3(r - 1), Eval4(r - 1) As String
        For i = 0 To r - 1
            If IsDBNull(dg.Item(sanf, i).Value()) Then
                Eval1(i) = ""
            Else
                Eval1(i) = Datagrid.Item(sanf, i).Value

            End If
Next
        SaVal = Eval1

        For i = 0 To r - 1
            If IsDBNull(dg.Item(Q, i).Value) Then
                Eval2(i) = "0"
            Else
                Eval2(i) = dg.Item(Q, i).Value

            End If
Next
        QVal = Eval2

        For i = 0 To r - 1
            If IsDBNull(dg.Item(P, i).Value) Then
                Eval3(i) = "0"
            Else
                Eval3(i) = dg.Item(P, i).Value
            End If

        Next
        PVal = Eval3

        For i = 0 To r - 1
            If IsDBNull(dg.Item(Val, i).Value) Then
                Eval4(i) = "0"
            Else
                Eval4(i) = dg.Item(Val, i).Value
            End If

        Next
        TotalVal = Eval4

        SetTableInBodyArea()
        SetTableVal(r)
        Dim rec2 As New Rectangle
        rec2 = FoaterArea
        rec2.Y = BodyArea.Bottom
        FoaterArea = rec2

    End Sub

    Private Sub SetTableInBodyArea()
        'الاجراء لتقسيم اعمدة الجدول
        With Sanfrec
            .Y = BodyArea.Top
            .X = BodyArea.Right - BodyArea.Right / 3
            .Width = BodyArea.Width / 2
            .Height = BodyArea.Height
        End With

        With Qrec
            .Y = BodyArea.Top
            .Width = BodyArea.Width / 6
            .X = Sanfrec.X - Qrec.Width - 10
            .Height = BodyArea.Height
        End With

        With Prec
            .Y = BodyArea.Top
            .Width = BodyArea.Width / 6
            .X = Qrec.X - Prec.Width - 10
            .Height = BodyArea.Height
        End With

        With Valrec
            .Y = BodyArea.Top
            .Width = BodyArea.Width / 6
            .X = Prec.X - Valrec.Width - 10
            .Height = BodyArea.Height
        End With

    End Sub
    Private Sub SetTableVal(ByVal r As Integer)
        Dim RPart As New reportPart
        Dim rec As New Rectangle
        Dim recs(r - 1) As Rectangle
        Dim rps(r - 1), rpq(r - 1), rpP(r - 1), rpval(r - 1) As reportPart
        Dim txt(r - 1) As String
        'heads 
        With rec
            .X = Sanfrec.X
            .Y = Sanfrec.Y
            .Width = Sanfrec.Width
            .Height = fh.Height
        End With
        SaValRh.reCtSetting(rec)
        SaValRh.SetText("الصنف", allinge.Center)
        SaValRh.StringFont.SetFont(Color.Black, fh)
        With rec
            .X = Qrec.X
            .Y = Qrec.Y
            .Width = Qrec.Width
            .Height = fh.Height
        End With
        QValRh.reCtSetting(rec)
        QValRh.SetText("الكمية", allinge.Center)
        QValRh.StringFont.SetFont(Color.Black, fh)

        With rec
            .X = Prec.X
            .Y = Prec.Y
            .Width = Prec.Width
            .Height = fh.Height
        End With
        PValRh.reCtSetting(rec)
        PValRh.SetText("السعر", allinge.Center)
        PValRh.StringFont.SetFont(Color.Black, fh)

        With rec
            .X = Valrec.X
            .Y = Valrec.Y
            .Width = Valrec.Width
            .Height = fh.Height
        End With
      
        TotalValRh.reCtSetting(rec)
        TotalValRh.SetText("القيمة", allinge.Center)
        TotalValRh.StringFont.SetFont(Color.Black, fh)
        'sanf
        txt = SaVal
        For i = 0 To r - 1
            Dim RPart1 As New reportPart
            Dim rec1 As New Rectangle

            If i = 0 Then

                With rec1
                    .X = Sanfrec.X
                    .Y = SaValRh.Rectangle.Bottom + 5
                    .Width = Sanfrec.Width
                    .Height = f.Height
                End With
                RPart1.reCtSetting(rec1)
                RPart1.SetText(SaVal(0), allinge.Center)
                RPart1.StringFont.SetFont(Color.Black, f)
                rps(0) = RPart1
            Else
                With rec1
                    .X = Sanfrec.X
                    .Y = rps(i - 1).Rectangle.Bottom
                    .Width = Sanfrec.Width
                    .Height = f.Height
                End With
                RPart1.BackColor = Brushes.Gray
                RPart1.FramColor = Pens.Black
                RPart1.reCtSetting(rec1)
                RPart1.SetText(SaVal(i), allinge.Center)
                RPart1.StringFont.SetFont(Color.Black, f)
                rps(i) = RPart1
            End If

        Next
        SaValR = rps

        'Q
        For i = 0 To r - 1
            Dim RPart1 As New reportPart
            Dim rec1 As New Rectangle

            If i = 0 Then

                With rec1
                    .X = Qrec.X
                    .Y = QValRh.Rectangle.Bottom + 5
                    .Width = Qrec.Width
                    .Height = f.Height
                End With
                RPart1.reCtSetting(rec1)
                RPart1.SetText(QVal(0), allinge.Center)
                RPart1.StringFont.SetFont(Color.Black, f)
                rpq(0) = RPart1
            Else
                With rec1
                    .X = Qrec.X
                    .Y = rpq(i - 1).Rectangle.Bottom
                    .Width = Qrec.Width
                    .Height = f.Height
                End With
                RPart1.BackColor = Brushes.Gray
                RPart1.FramColor = Pens.Black
                RPart1.reCtSetting(rec1)
                RPart1.SetText(QVal(i), allinge.Center)
                RPart1.StringFont.SetFont(Color.Black, f)
                rpq(i) = RPart1
            End If

        Next
        QValR = rpq

        'p
        For i = 0 To r - 1
            Dim RPart1 As New reportPart
            Dim rec1 As New Rectangle

            If i = 0 Then

                With rec1
                    .X = Prec.X
                    .Y = PValRh.Rectangle.Bottom + 5
                    .Width = Prec.Width
                    .Height = f.Height
                End With
                RPart1.reCtSetting(rec1)
                RPart1.SetText(PVal(0), allinge.Center)
                RPart1.StringFont.SetFont(Color.Black, f)
                rpP(0) = RPart1
            Else
                With rec1
                    .X = Prec.X
                    .Y = rpP(i - 1).Rectangle.Bottom
                    .Width = Prec.Width
                    .Height = f.Height
                End With
                RPart1.BackColor = Brushes.Gray
                RPart1.FramColor = Pens.Black
                RPart1.reCtSetting(rec1)
                RPart1.SetText(PVal(i), allinge.Center)
                RPart1.StringFont.SetFont(Color.Black, f)
                rpP(i) = RPart1
            End If

        Next
        PValR = rpP
        'val
        For i = 0 To r - 1
            Dim RPart1 As New reportPart
            Dim rec1 As New Rectangle

            If i = 0 Then

                With rec1
                    .X = Valrec.X
                    .Y = TotalValRh.Rectangle.Bottom + 5
                    .Width = Valrec.Width
                    .Height = f.Height
                End With
                RPart1.reCtSetting(rec1)
                RPart1.SetText(TotalVal(0), allinge.Center)
                RPart1.StringFont.SetFont(Color.Black, f)
                rpval(0) = RPart1
            Else
                With rec1
                    .X = Valrec.X
                    .Y = rpval(i - 1).Rectangle.Bottom
                    .Width = Prec.Width
                    .Height = f.Height
                End With
                RPart1.BackColor = Brushes.Gray
                RPart1.FramColor = Pens.Black
                RPart1.reCtSetting(rec1)
                RPart1.SetText(TotalVal(i), allinge.Center)
                RPart1.StringFont.SetFont(Color.Black, f)
                rpval(i) = RPart1
            End If

        Next
        TotalValR = rpval
    End Sub
#End Region
#Region "Printing"
    Private Sub Print_Headers(ByVal g As Graphics)
        Markpart.Print_String(g)
        DatePart.Print_String(g)
        NamePart.Print_String(g)
        InvoiceNopart.Print_String(g)
        '
        _DatePart.Print_String(g)
        _NamePart.Print_String(g)
        _InvoiceNopart.Print_String(g)
    End Sub

    Private Sub Print_Footer(ByVal g As Graphics)
        TotalV.Print_String(g)
        Paid.Print_String(g)
        Steal.Print_String(g)

        '
        _TotalV.Print_String(g)
        _Paid.Print_String(g)
        _Steal.Print_String(g)
    End Sub
    Private Sub Print_body(ByVal g As Graphics)
        SaValRh.Print_String(g)
        QValRh.Print_String(g)
        PValRh.Print_String(g)
        TotalValRh.Print_String(g)

        For i = 0 To SaValR.Length - 1
            SaValR(i).BackColor = Brushes.Red
            SaValR(i).FramColor = Pens.Black
            SaValR(i).Print_String(g)
            'SaValR(i).Print_Rect(g)
        Next

        For i = 0 To QValR.Length - 1
            QValR(i).BackColor = Brushes.White
            QValR(i).FramColor = Pens.White
            QValR(i).Print_Rect(g)
            QValR(i).Print_String(g)

        Next

        For i = 0 To PValR.Length - 1
            PValR(i).BackColor = Brushes.White
            PValR(i).FramColor = Pens.White
            PValR(i).Print_Rect(g)
            PValR(i).Print_String(g)

        Next
        For i = 0 To TotalValR.Length - 1
            TotalValR(i).BackColor = Brushes.White
            TotalValR(i).FramColor = Pens.White
            TotalValR(i).Print_Rect(g)
            TotalValR(i).Print_String(g)

        Next
    End Sub
    Public Sub print(ByVal send As Object, ByVal e As Printing.PrintPageEventArgs) Handles inv.PrintPage

        Print_Headers(e.Graphics)

        Print_body(e.Graphics)
        Print_Footer(e.Graphics)

    End Sub
#End Region
End Class
