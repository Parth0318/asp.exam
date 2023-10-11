Imports System.Data
Imports System.Data.SqlClient
Partial Class Home
    Inherits System.Web.UI.Page
    Dim connect As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Parth Rohit\source\repos\Practice\Practice\App_Data\register.mdf;Integrated Security=True")
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim productid As Integer = txtproductID.Text
        Dim itemname As String = txtitemname.Text
        Dim specification As String = txtspecification.Text
        Dim unit As String = Dropunit.SelectedValue
        Dim color As String = Radiocolor.SelectedValue
        Dim insertdate As DateTime = txtdate.Text
        Dim opening As Double = txtopeningqty.Text
        Dim status As String = ""



        For Each item As ListItem In Checkregular.Items
            If item.Selected Then
                status = "Regular"
            Else
                status = "Irregular"
            End If
        Next


        connect.Open()
        Dim command As New SqlCommand("Insert into Product_Info values ('" & productid & "','" & itemname & "','" & specification & "','" & unit & "','" & color & "','" & insertdate & "','" & opening & "','" & status & "')", connect)
        command.ExecuteNonQuery()
        MsgBox("Successfull inserted", MsgBoxStyle.Information, "Message")
        connect.Close()
        ListProduct()

    End Sub

    Private Sub ListProduct()
        Dim command As New SqlCommand("select * from Product_Info", connect)
        Dim sd As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sd.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub



    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim productid As Integer = txtproductID.Text
        Dim itemname As String = txtitemname.Text
        Dim specification As String = txtspecification.Text
        Dim unit As String = Dropunit.SelectedValue
        Dim color As String = Radiocolor.SelectedValue
        Dim insertdate As DateTime = txtdate.Text
        Dim opening As Double = txtopeningqty.Text
        Dim status As String = ""



        For Each item As ListItem In Checkregular.Items
            If item.Selected Then
                status = "Regular"
            Else
                status = "Irregular"
            End If
        Next


        connect.Open()
        Dim command As New SqlCommand("Update Product_Info set ItemName = '" & itemname & "',Specification='" & specification & "',Unit='" & unit & "',Color= '" & color & "',InsertDate='" & insertdate & "',Opening='" & opening & "',Status='" & status & "' where ProductID= '" & productid & "' ", connect)
        command.ExecuteNonQuery()
        MsgBox("Successfull updated", MsgBoxStyle.Information, "Message")
        connect.Close()
        ListProduct()

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListProduct()

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim productid As Integer = txtproductID.Text
        connect.Open()
        Dim command As New SqlCommand("Delete Product_Info where ProductID = '" & productid & "'", connect)
        command.ExecuteNonQuery()
        MsgBox("Successfull Delete", MsgBoxStyle.Information, "Message")
        connect.Close()
        ListProduct()

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim productid As Integer = txtproductID.Text
        Dim command As New SqlCommand("select * from Product_Info where ProductID = '" & productid & "'", connect)
        Dim sd As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sd.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub
End Class
