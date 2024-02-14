Module DataStructure_myData
    Public Structure LogeIn
        Friend name As FieldMombers
        Friend passward As FieldMombers
        Friend power As FieldMombers

        Friend dataEnterTable As String
        Friend logine_Fm As FieldMombers()
        Friend Sub load()
            name.Name = "DataEName"
            passward.Name = "passeWord"
            power.Name = "Powr"
            logine_Fm = {name, passward, power}
            dataEnterTable = "DataENameTable"

        End Sub

    End Structure

    Public Structure StockDataShops

        Dim ser As FieldMombers
        Dim sanf As FieldMombers
        Dim Code As FieldMombers
        Dim main_sanf As FieldMombers
        Dim mark As FieldMombers
        Dim parnck As FieldMombers
        Dim AdditionalData As FieldMombers

        Dim ParchasePrice As FieldMombers
        Dim jom_price As FieldMombers
        Dim qut_price As FieldMombers
        Dim AtLeast As FieldMombers
        Dim isLow As FieldMombers
        Dim Balance As FieldMombers
        Friend StockData_TabaleName As String
        Friend StockDataShope_Fm As FieldMombers()
        Friend Sub load()

            Dim stock As New StockDataBookShops
            ser = New FieldMombers With {.Name = "ser"}
            sanf = New FieldMombers With {.Name = "sanf", .dgvVisalbe = True}
            Code = New FieldMombers With {.Name = "Code"}
            main_sanf = New FieldMombers With {.Name = "main_sanf"}
            mark = New FieldMombers With {.Name = "mark"}
            parnck = New FieldMombers With {.Name = "parnck"}
            AdditionalData = New FieldMombers With {.Name = "AdditionalData", .dgvVisalbe = True}
            Balance = New FieldMombers With {.Name = "Balance"}
            ParchasePrice = New FieldMombers With {.Name = "ParchasePrice"}
            jom_price = New FieldMombers With {.Name = "jom_price"}
            qut_price = New FieldMombers With {.Name = "qut_price"}

            AtLeast = New FieldMombers With {.Name = "AtLeast"}
            isLow = New FieldMombers With {.Name = "isLow"}

            StockDataShope_Fm = {sanf, Code, ParchasePrice, main_sanf, mark, parnck, jom_price, _
        qut_price, AtLeast, isLow, Balance, ser}

            StockData_TabaleName = "StockDataTableShops"

        End Sub

    End Structure

    Public Structure StockDataBookShops

        Dim ser As FieldMombers
        Dim sanf As FieldMombers
        Dim Code As FieldMombers
        Dim main_sanf As FieldMombers
        Dim moalef As FieldMombers
        Dim DarNashr As FieldMombers
        Dim bookName As FieldMombers

        Dim ParchasePrice As FieldMombers
        Dim jom_price As FieldMombers
        Dim qut_price As FieldMombers
        Dim AtLeast As FieldMombers
        Dim isLow As FieldMombers

        Friend StockData_TabaleName As String
        Friend StockDataBookShope_Fm As FieldMombers()
        Friend Sub load()

            Dim stock As New StockDataBookShops
            ser = New FieldMombers With {.Name = "ser"}
            sanf = New FieldMombers With {.Name = "sanf", .dgvVisalbe = True}
            Code = New FieldMombers With {.Name = "Code"}
            main_sanf = New FieldMombers With {.Name = "main_sanf"}
            moalef = New FieldMombers With {.Name = "moalef"}
            DarNashr = New FieldMombers With {.Name = "DarNashr"}
            bookName = New FieldMombers With {.Name = "BookName", .dgvVisalbe = True}

            ParchasePrice = New FieldMombers With {.Name = "ParchasePrice"}
            jom_price = New FieldMombers With {.Name = "jom_price"}
            qut_price = New FieldMombers With {.Name = "qut_price"}

            AtLeast = New FieldMombers With {.Name = "AtLeast"}
            isLow = New FieldMombers With {.Name = "isLow"}

            StockDataBookShope_Fm = {sanf, Code, ParchasePrice, main_sanf, moalef, DarNashr, jom_price, _
        qut_price, AtLeast, isLow, ser}

            StockData_TabaleName = "StockDataBookShops"

        End Sub

    End Structure

    Public Structure StockDatamarket

        'بيانات الجدول

        Dim ser As FieldMombers
        Dim sanf As FieldMombers
        Dim Code As FieldMombers
        Dim mark As FieldMombers
        Dim mainSanf As FieldMombers
        Dim ParchasePrice As FieldMombers
        Dim jom_price As FieldMombers
        Dim qut_price As FieldMombers

        Friend StockData_TabaleName As String
        Friend StockDataMarket_Fm As FieldMombers()
        Friend Sub load()
            'بيانات الجدول
            Dim stock As New StockDataBookShops
            Dim ser = New FieldMombers With {.Name = "ser"}
            Dim sanf = New FieldMombers With {.Name = "sanf"}
            Dim Code = New FieldMombers With {.Name = "Code"}
            Dim mark As New FieldMombers With {.Name = "mark"}
            Dim mainSanf As New FieldMombers With {.Name = "main_sanf"}
            Dim ParchasePrice = New FieldMombers With {.Name = "ParchasePrice"}
            Dim jom_price = New FieldMombers With {.Name = "jom_price"}
            Dim qut_price = New FieldMombers With {.Name = "qut_price"}
            StockDataMarket_Fm = {ser, sanf, Code, mainSanf, mark, ParchasePrice, jom_price, _
                                              qut_price}


            StockData_TabaleName = "StockDataMarket"

        End Sub

    End Structure

End Module
