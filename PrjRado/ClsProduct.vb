Public Class ClsProduct
    Const decVat As Decimal = 0.15
    Public intProdCode As Integer
    Public strDescription As String
    Public intQuantity As Integer
    Public decPrice As Decimal
    Public decProduct As Decimal


    Public Function AddProd() As Decimal
        decProduct = intQuantity * decPrice * decVat
        Return decProduct
    End Function
End Class
