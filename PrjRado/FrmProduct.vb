Public Class FrmProduct

    Private Product As New ClsProduct
    Private Sub FrmProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim decProduct As Decimal
        Product.intProdCode = (txtProdCode.Text)
        Product.decPrice = CDec(txtPrice.Text)
        Product.intQuantity = CInt(txtQty.Text)
        Product.strDescription = txtDescription.Text
        decProduct = Product.AddProd()


        LstDisplay.Items.Add("Adding a Product")
        LstDisplay.Items.Add("")
        LstDisplay.Items.Add("")
        LstDisplay.Items.Add("ProdCode" & vbTab & Product.intProdCode)
        LstDisplay.Items.Add("Price" & vbTab & vbTab & Product.decPrice)
        LstDisplay.Items.Add("QTY" & vbTab & vbTab & Product.intQuantity)
        LstDisplay.Items.Add("Description" & vbTab & Product.strDescription)
        LstDisplay.Items.Add("Payment" & vbTab & vbTab & decProduct.ToString("C"))
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show(" Confirm if you want to Exit", "System Rulls", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub LstDisplay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstDisplay.SelectedIndexChanged

    End Sub

    Private Sub btnCalcSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcSelect.Click
        Product.intProdCode = (txtProdCode.Text)
        Product.decPrice = CDec(txtPrice.Text)
        Product.intQuantity = CInt(txtQty.Text)
        Product.strDescription = txtDescription.Text
        Product.AddProd()


        LstDisplay.Items.Add("Selecting a Product")
        LstDisplay.Items.Add("")
        LstDisplay.Items.Add("")
        LstDisplay.Items.Add("ProdCode" & vbTab & Product.intProdCode)
        LstDisplay.Items.Add("Price" & vbTab & vbTab & Product.decPrice)
        LstDisplay.Items.Add("QTY" & vbTab & vbTab & Product.intQuantity)
        LstDisplay.Items.Add("Description" & vbTab & Product.strDescription)
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
        FrmCustomer.Show()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtDescription.Clear()
        txtPrice.Clear()
        txtProdCode.Clear()
        txtQty.Clear()
        LstDisplay.Items.Clear()
    End Sub
End Class