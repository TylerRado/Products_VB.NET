Public Class FrmCustomer
    Private Customer As New ClsCustomer
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show(" Confirm if you want to Exit", "System Rulls", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.Hide()
        FrmProduct.Show()
    End Sub

    Private Sub btnAddCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCust.Click

        Customer.intID = CInt(txtId.Text)
        Customer.strName = (txtName.Text)
        Customer.intCellNo = CInt(txtCellNo.Text)
        Customer.strAddress = (txtAddress.Text)


        LstDisplay.Items.Add("Adding Customer")
        LstDisplay.Items.Add("")
        LstDisplay.Items.Add("Name:" & vbTab & vbTab & txtName.Text)
        LstDisplay.Items.Add("ID:" & vbTab & vbTab & txtId.Text)
        LstDisplay.Items.Add("Address:" & vbTab & vbTab & txtAddress.Text)
        LstDisplay.Items.Add("Cell Number:" & vbTab & txtCellNo.Text)



    End Sub

    Private Sub btnEditCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCust.Click
        Customer.intID = CInt(txtId.Text)
        Customer.strName = (txtName.Text)
        Customer.intCellNo = CInt(txtCellNo.Text)
        Customer.strAddress = (txtAddress.Text)


        LstDisplay.Items.Add("Edittimg Customer")
        LstDisplay.Items.Add("")
        LstDisplay.Items.Add("Name:" & vbTab & vbTab & txtName.Text)
        LstDisplay.Items.Add("ID:" & vbTab & vbTab & txtId.Text)
        LstDisplay.Items.Add("Address:" & vbTab & vbTab & txtAddress.Text)
        LstDisplay.Items.Add("Cell Number:" & vbTab & txtCellNo.Text)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtId.Clear()
        txtName.Clear()
        txtAddress.Clear()
        txtCellNo.Clear()
        LstDisplay.Items.Clear()

    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCellNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCellNo.TextChanged

    End Sub
End Class
