
Option Strict On

Public Class CalcTax

    Const _cdecCalTax As Decimal = CDec(8.75)
    Public Property lblTotalCost As String


    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        Dim strNameOfItem As String
        Dim strCostOfItem As String
        Dim decCostOfItem As Decimal
        Dim decTotalCost As Decimal


        strNameOfItem = txtNameOfItem.Text
        strCostOfItem = txtCostOfItem.Text
        decCostOfItem = Convert.ToDecimal(strCostOfItem)
        decTotalCost = decCostOfItem + _cdecCalTax
        lblTotalCost = decTotalCost.ToString("")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNameOfItem.Clear()
        txtNameOfItem.Focus()
        txtCostOfItem.Clear()
        txtTotalCost.Clear()

    End Sub

    Private Sub CalcTax_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lblTotalCost = ""
        txtNameOfItem.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
