Public Class frm3
    Private Sub frm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetAll()
    End Sub
    Private Sub btnback2_Click(sender As Object, e As EventArgs) Handles btnback2.Click
        Me.Close()
        frm1.Show()
    End Sub
    Private Sub btnNewCard_Click(sender As Object, e As EventArgs) Handles btnNewCard.Click
        ResetAll()
    End Sub
    Public Sub vrbls()
        arrayB = {btnB1, btnB2, btnB3, btnB4, btnB5}
        arrayI = {btnI1, btnI2, btnI3, btnI4, btnI5}
        arrayN = {btnN1, btnN2, btnFree, btnN4, btnN5}
        arrayG = {btnG1, btnG2, btnG3, btnG4, btnG5}
        arrayO = {btnO1, btnO2, btnO3, btnO4, btnO5}
        numsB = random.Next(1, 16)
        numsI = random.Next(16, 31)
        numsN = random.Next(31, 46)
        numsG = random.Next(46, 61)
        numsO = random.Next(61, 76)
        arrayAB = {btnB1, btnI1, btnN1, btnG1, btnO1}
        arrayAI = {btnB2, btnI2, btnN2, btnG2, btnO2}
        arrayAN = {btnB3, btnI3, btnFree, btnG3, btnO3}
        arrayAG = {btnB4, btnI4, btnN4, btnG4, btnO4}
        arrayAO = {btnB5, btnI5, btnN5, btnG5, btnO5}
        arrayDR = {btnB1, btnI2, btnFree, btnG4, btnO5}
        arrayDL = {btnO1, btnG2, btnFree, btnI4, btnB5}
        arrayAll = {btnB1, btnB2, btnB3, btnB4, btnB5, btnI1, btnI2, btnI3, btnI4, btnI5, btnN1, btnN2, btnN4, btnN5, btnG1, btnG2, btnG3, btnG4, btnG5, btnO1, btnO2, btnO3, btnO4, btnO5}
    End Sub
    Public Sub colors()
        For r As Integer = 0 To arrayB.Length - 1
            arrayB(r).BackColor = Color.FromArgb(64, 0, 64)
            arrayI(r).BackColor = Color.FromArgb(64, 0, 64)
            arrayN(r).BackColor = Color.FromArgb(64, 0, 64)
            arrayG(r).BackColor = Color.FromArgb(64, 0, 64)
            arrayO(r).BackColor = Color.FromArgb(64, 0, 64)
        Next
    End Sub
    Public Sub ResetAll()
        Dim generateIndex = 0, generated(1) As Integer
        vrbls()
        For i As Integer = 0 To arrayB.Length - 1
            Do Until generated.Contains(numsB) = False
                numsB = random.Next(1, 16)
            Loop
            arrayB(i).Text = numsB
            generated(generateIndex) = numsB
            generateIndex += 1
            ReDim Preserve generated(generated.Length + 1)
            Do Until generated.Contains(numsI) = False
                numsI = random.Next(16, 31)
            Loop
            arrayI(i).Text = numsI
            generated(generateIndex) = numsI
            generateIndex += 1
            ReDim Preserve generated(generated.Length + 1)
            Do Until generated.Contains(numsN) = False
                numsN = random.Next(31, 46)
            Loop
            arrayN(i).Text = numsN
            generated(generateIndex) = numsN
            generateIndex += 1
            ReDim Preserve generated(generated.Length + 1)
            Do Until generated.Contains(numsG) = False
                numsG = random.Next(46, 61)
            Loop
            arrayG(i).Text = numsG
            generated(generateIndex) = numsG
            generateIndex += 1
            ReDim Preserve generated(generated.Length + 1)
            Do Until generated.Contains(numsO) = False
                numsO = random.Next(61, 76)
            Loop
            arrayO(i).Text = numsO
            generated(generateIndex) = numsO
            generateIndex += 1
            ReDim Preserve generated(generated.Length + 1)
        Next
        colors()
        Try
            For s As Integer = 0 To arrayAll.Length - 1
                arrayAll(s).Enabled = True
            Next
        Catch
        End Try
        lblBingo.Visible = False
    End Sub
    Private Sub btnB1_Click(sender As Object, e As EventArgs) Handles btnB1.Click, btnB2.Click, btnB3.Click, btnB4.Click, btnB5.Click, btnI1.Click, btnI2.Click, btnI3.Click, btnI4.Click, btnI5.Click, btnN1.Click, btnN2.Click, btnN4.Click, btnN5.Click, btnG1.Click, btnG2.Click, btnG3.Click, btnG4.Click, btnG5.Click, btnO1.Click, btnO2.Click, btnO3.Click, btnO4.Click, btnO5.Click
        Dim selectedbtn As Button = sender
        If selectedbtn.BackColor = Color.FromArgb(64, 0, 64) Then
            selectedbtn.BackColor = Color.OrangeRed
        Else selectedbtn.BackColor = Color.FromArgb(64, 0, 64)
        End If
        If CheckNormalWin() = True Then
            lblBingo.Visible = True
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ResetCard()
    End Sub
    Public Sub ResetCard()
        colors()
        Try
            For s As Integer = 0 To arrayAll.Length - 1
                arrayAll(s).Enabled = True
            Next
        Catch
        End Try
        lblBingo.Visible = False
    End Sub
    Function CheckNormalWin() As Boolean
        Dim winB = 0, winI = 0, winN = 0, winG = 0, winO = 0, winAB = 0, winAI = 0, winAN = 0, winAG = 0, winAO = 0, winDR = 0, WinDL = 0, q As Integer
        vrbls()
        For i As Integer = 0 To arrayDR.Length - 1
            If arrayDR(i).BackColor = Color.OrangeRed Then
                winDR += 1
            End If
            If arrayDL(i).BackColor = Color.OrangeRed Then
                WinDL += 1
            End If
            If arrayAB(i).BackColor = Color.OrangeRed Then
                winAB += 1
            End If
            If arrayAI(i).BackColor = Color.OrangeRed Then
                winAI += 1
            End If
            If arrayAN(i).BackColor = Color.OrangeRed Then
                winAN += 1
            End If
            If arrayAG(i).BackColor = Color.OrangeRed Then
                winAG += 1
            End If
            If arrayAO(i).BackColor = Color.OrangeRed Then
                winAO += 1
            End If
            If arrayB(i).BackColor = Color.OrangeRed Then
                winB += 1
            End If
            If arrayI(i).BackColor = Color.OrangeRed Then
                winI += 1
            End If
            If arrayN(i).BackColor = Color.OrangeRed Then
                winN += 1
            End If
            If arrayG(i).BackColor = Color.OrangeRed Then
                winG += 1
            End If
            If arrayO(i).BackColor = Color.OrangeRed Then
                winO += 1
            End If
        Next
        If winDR = 4 Then
            CheckNormalWin = True
            For c As Integer = 0 To arrayDR.Length - 1
                arrayDR(c).BackColor = Color.Maroon
            Next
            For r As Integer = 0 To arrayAll.Length - 1
                arrayAll(r).Enabled = False
            Next
        End If
        If WinDL = 4 Then
            CheckNormalWin = True
            For c As Integer = 0 To arrayDL.Length - 1
                arrayDL(c).BackColor = Color.Maroon
            Next
            For r As Integer = 0 To arrayAll.Length - 1
                arrayAll(r).Enabled = False
            Next
        End If
        If winB = 5 Then
            CheckNormalWin = True
            For c As Integer = 0 To arrayB.Length - 1
                arrayB(c).BackColor = Color.Maroon
            Next
            For r As Integer = 0 To arrayAll.Length - 1
                arrayAll(r).Enabled = False
            Next
        End If
        If winI = 5 Then
            CheckNormalWin = True
            For c As Integer = 0 To arrayI.Length - 1
                arrayI(c).BackColor = Color.Maroon
            Next
            For r As Integer = 0 To arrayAll.Length - 1
                arrayAll(r).Enabled = False
            Next
        End If
        If winN = 4 Then
            CheckNormalWin = True
            For c As Integer = 0 To arrayN.Length - 1
                arrayN(c).BackColor = Color.Maroon
            Next
            For r As Integer = 0 To arrayAll.Length - 1
                arrayAll(r).Enabled = False
            Next
        End If
        If winG = 5 Then
            CheckNormalWin = True
            For c As Integer = 0 To arrayG.Length - 1
                arrayG(c).BackColor = Color.Maroon
            Next
            For r As Integer = 0 To arrayAll.Length - 1
                arrayAll(r).Enabled = False
            Next
        End If
        If winO = 5 Then
            CheckNormalWin = True
            For c As Integer = 0 To arrayO.Length - 1
                arrayO(c).BackColor = Color.Maroon
            Next
            For r As Integer = 0 To arrayAll.Length - 1
                arrayAll(r).Enabled = False
            Next
        End If
        If winAB = 5 Then
            CheckNormalWin = True
            For c As Integer = 0 To arrayAB.Length - 1
                arrayAB(c).BackColor = Color.Maroon
            Next
            For r As Integer = 0 To arrayAll.Length - 1
                arrayAll(r).Enabled = False
            Next
        End If
        If winAI = 5 Then
            CheckNormalWin = True
            For c As Integer = 0 To arrayAI.Length - 1
                arrayAI(c).BackColor = Color.Maroon
            Next
            For r As Integer = 0 To arrayAll.Length - 1
                arrayAll(r).Enabled = False
            Next
        End If
        If winAN = 4 Then
            CheckNormalWin = True
            For c As Integer = 0 To arrayAN.Length - 1
                arrayAN(c).BackColor = Color.Maroon
            Next
            For r As Integer = 0 To arrayAll.Length - 1
                arrayAll(r).Enabled = False
            Next
        End If
        If winAG = 5 Then
            CheckNormalWin = True
            For c As Integer = 0 To arrayAG.Length - 1
                arrayAG(c).BackColor = Color.Maroon
            Next
            lblBingo.Visible = True
            For r As Integer = 0 To arrayAll.Length - 1
                arrayAll(r).Enabled = False
            Next
        End If
        If winAO = 5 Then
            CheckNormalWin = True
            For c As Integer = 0 To arrayAO.Length - 1
                arrayAO(c).BackColor = Color.Maroon
            Next
            For r As Integer = 0 To arrayAll.Length - 1
                arrayAll(r).Enabled = False
            Next
        End If
    End Function
End Class