Public Class frm4
    Private Sub frm4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Vars()
        ResetA()
    End Sub
    Public Sub ResetA()
        Dim generateIndex = 0, generated(1) As Integer
        For b As Integer = 0 To arrayB.Length - 1
            Do Until generated.Contains(numsB) = False
                numsB = random.Next(1, 16)
            Loop
            arrayB(b).Text = numsB
            generated(generateIndex) = numsB
            generateIndex += 1
            ReDim Preserve generated(generated.Length + 1)
        Next
        For i As Integer = 0 To arrayI.Length - 1
            Do Until generated.Contains(numsI) = False
                numsI = random.Next(16, 31)
            Loop
            arrayI(i).Text = numsI
            generated(generateIndex) = numsI
            generateIndex += 1
            ReDim Preserve generated(generated.Length + 1)
        Next
        For n As Integer = 0 To arrayN.Length - 1
            Do Until generated.Contains(numsN) = False
                numsN = random.Next(31, 46)
            Loop
            arrayN(n).Text = numsN
            generated(generateIndex) = numsN
            generateIndex += 1
            ReDim Preserve generated(generated.Length + 1)
        Next
        For g As Integer = 0 To arrayG.Length - 1
            Do Until generated.Contains(numsG) = False
                numsG = random.Next(31, 46)
            Loop
            arrayG(g).Text = numsG
            generated(generateIndex) = numsG
            generateIndex += 1
            ReDim Preserve generated(generated.Length + 1)
        Next
        For o As Integer = 0 To arrayO.Length - 1
            Do Until generated.Contains(numsO) = False
                numsO = random.Next(61, 76)
            Loop
            arrayO(o).Text = numsO
            generated(generateIndex) = numsO
            generateIndex += 1
            ReDim Preserve generated(generated.Length + 1)
        Next
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
    Public Sub Vars()
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
    End Sub
    Private Sub btnNewCard_Click(sender As Object, e As EventArgs) Handles btnNewCard.Click
        Vars()
        ResetA()
        colors()
        Try
            For s As Integer = 0 To arrayAll.Length - 1
                arrayAll(s).Enabled = True
            Next
        Catch
        End Try
        lblBingo.Visible = False
    End Sub
    Private Sub btnback2_Click(sender As Object, e As EventArgs) Handles btnback2.Click
        Me.Close()
        frm1.Show()
    End Sub
    Private Sub btnB1_Click(sender As Object, e As EventArgs) Handles btnB1.Click, btnB2.Click, btnB3.Click, btnB4.Click, btnB5.Click, btnI1.Click, btnI2.Click, btnI3.Click, btnI4.Click, btnI5.Click, btnN1.Click, btnN2.Click, btnN4.Click, btnN5.Click, btnG1.Click, btnG2.Click, btnG3.Click, btnG4.Click, btnG5.Click, btnO1.Click, btnO2.Click, btnO3.Click, btnO4.Click, btnO5.Click
        Dim selectedbtn As Button = sender
        If selectedbtn.BackColor = Color.FromArgb(64, 0, 64) Then
            selectedbtn.BackColor = Color.OrangeRed
        Else selectedbtn.BackColor = Color.FromArgb(64, 0, 64)
        End If
        If CheckFullCardWin() = True Then
            lblBingo.Visible = True
        End If
    End Sub
    Private Function CheckFullCardWin() As Boolean
        Dim winAll As Integer
        arrayAll = {btnB1, btnB2, btnB3, btnB4, btnB5, btnI1, btnI2, btnI3, btnI4, btnI5, btnN1, btnN2, btnN4, btnN5, btnG1, btnG2, btnG3, btnG4, btnG5, btnO1, btnO2, btnO3, btnO4, btnO5}
        For i As Integer = 0 To arrayAll.Length - 1
            If arrayAll(i).BackColor = Color.OrangeRed Then
                winAll += 1
            End If
        Next
        If winAll = 24 Then
            For c As Integer = 0 To arrayAll.Length - 1
                arrayAll(c).BackColor = Color.Maroon
                arrayAll(c).Enabled = False
            Next
            Return True
        End If
    End Function
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Reset()
    End Sub
    Public Sub Reset()
        colors()
        Try
            For f As Integer = 0 To arrayAll.Length - 1
                arrayAll(f).Enabled = True
            Next
        Catch
        End Try
        lblBingo.Visible = False
    End Sub
End Class