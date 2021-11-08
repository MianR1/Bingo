Public Class frm2
    Dim arrayB(), arrayI(), arrayN(), arrayG(), arrayO(), arrayAll() As Label
    Private Sub frm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetNumbers()
        Reset()
    End Sub
    Private Sub SetNumbers()
        Dim numVals As Integer = 1
        arrayB = {lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11, lbl12, lbl13, lbl14, lbl15}
        arrayI = {lbl16, lbl17, lbl18, lbl19, lbl20, lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27, lbl28, lbl29, lbl30}
        arrayN = {lbl31, lbl32, lbl33, lbl34, lbl35, lbl36, lbl37, lbl38, lbl39, lbl40, lbl41, lbl42, lbl43, lbl44, lbl45}
        arrayG = {lbl46, lbl47, lbl48, lbl49, lbl50, lbl51, lbl52, lbl53, lbl54, lbl55, lbl56, lbl57, lbl58, lbl59, lbl60}
        arrayO = {lbl61, lbl62, lbl63, lbl64, lbl65, lbl66, lbl67, lbl68, lbl69, lbl70, lbl71, lbl72, lbl73, lbl74, lbl75}
        For i As Integer = 0 To arrayB.Length - 1
            arrayB(i).Text = numVals
            numVals += 1
        Next
        For i As Integer = 0 To arrayI.Length - 1
            arrayI(i).Text = numVals
            numVals += 1
        Next
        For i As Integer = 0 To arrayN.Length - 1
            arrayN(i).Text = numVals
            numVals += 1
        Next
        For i As Integer = 0 To arrayG.Length - 1
            arrayG(i).Text = numVals
            numVals += 1
        Next
        For i As Integer = 0 To arrayO.Length - 1
            arrayO(i).Text = numVals
            numVals += 1
        Next
    End Sub
    Private Sub btnback1_Click(sender As Object, e As EventArgs) Handles btnback1.Click
        Me.Close()
        frm1.Show()
    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If counter = 75 Then
            MessageBox.Show("Game Over" & vbNewLine & "Press Clear To Start Again", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnGenerate.Enabled = False
            btnGenerate.BackColor = Color.Maroon
            Exit Sub
        End If
        randNum = random.Next(1, 76)
        Do Until generatedNums.Contains(randNum) = False
            randNum = random.Next(1, 76)
        Loop
        counter += 1
        generatedNums(generatedNIndex) = randNum
        generatedNIndex += 1
        ReDim Preserve generatedNums(generatedNums.Length + 1)
        arrayAll = {lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17, lbl18, lbl19, lbl20, lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27, lbl28, lbl29, lbl30, lbl31, lbl32, lbl33, lbl34, lbl35, lbl36, lbl37, lbl38, lbl39, lbl40, lbl41, lbl42, lbl43, lbl44, lbl45, lbl46, lbl47, lbl48, lbl49, lbl50, lbl51, lbl52, lbl53, lbl54, lbl55, lbl56, lbl57, lbl58, lbl59, lbl60, lbl61, lbl62, lbl63, lbl64, lbl65, lbl66, lbl67, lbl68, lbl69, lbl70, lbl71, lbl72, lbl73, lbl74, lbl75}
        arrayAll(randNum - 1).BackColor = Color.OrangeRed
        If randNum <= 15 Then
            lblChosen.Text = "B" & Space(1) & randNum
        ElseIf randNum >= 16 And randNum <= 30 Then
            lblChosen.Text = "I" & Space(1) & randNum
        ElseIf randNum >= 31 And randNum <= 45 Then
            lblChosen.Text = "N" & Space(1) & randNum
        ElseIf randNum >= 46 And randNum <= 60 Then
            lblChosen.Text = "G" & Space(1) & randNum
        ElseIf randNum >= 61 And randNum <= 75 Then
            lblChosen.Text = "O" & Space(1) & randNum
        End If
    End Sub
    Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        Reset()
    End Sub
    Public Sub Reset()
        Try
            For x As Integer = 0 To 74
                arrayAll(x).BackColor = Color.FromArgb(64, 0, 64)
            Next
        Catch
        End Try
        lblChosen.Text = ""
        counter = 0
        btnClear1.BackColor = Color.Empty
        btnGenerate.Enabled = True
        btnGenerate.BackColor = Color.Black
        generatedNIndex = 0
        ReDim Preserve generatedNums(1)
    End Sub
End Class