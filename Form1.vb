'***************************************************************************************************************************************************************************************************
' PROGRAMME	    :	Bingo Card  
' OUTLINE		:	This program lets you choose what type of bingo you want to play, either full bingo or normal,also you have the option to be the caller that tells the random numbers chosen.
' PROGRAMMER	:	Mian Rafay
' DATE		    :	November 2, 2019
' **************************************************************************************************************************************************************************************************
Public Class frm1
    Private Sub btnCallNums_Click_1(sender As Object, e As EventArgs) Handles btnCallNums.Click
        Me.Hide()
        frm2.Show()
    End Sub
    Private Sub btnPlay_Click_1(sender As Object, e As EventArgs) Handles btnPlay.Click
        Me.Hide()
        frm3.Show()
    End Sub
    Private Sub btnPlayFC_Click_1(sender As Object, e As EventArgs) Handles btnPlayFC.Click
        Me.Hide()
        frm4.Show()
    End Sub
End Class