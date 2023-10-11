Imports System.Data
Imports System.Data.SqlClient

Partial Class products
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Parth Rohit\source\repos\Practice\Practice\App_Data\register.mdf;Integrated Security=True"
        con.Open()

        cmd = New SqlCommand("INSERT INTO register VALUES(@fname, @lname, @email, @phone, @password)", con)
        cmd.Parameters.AddWithValue("@fname", fname.Text)
        cmd.Parameters.AddWithValue("@lname", lname.Text)
        cmd.Parameters.AddWithValue("@email", email.Text)
        cmd.Parameters.AddWithValue("@phone", phone.Text)
        cmd.Parameters.AddWithValue("@password", password.Text)

        If (fname.Text = "" Or lname.Text = "" Or email.Text = "" Or phone.Text = "" Or password.Text = "") Then
            MsgBox("Please Enter all details")
        Else
            cmd.ExecuteNonQuery()
            MsgBox("Your data is successfully added.", MsgBoxStyle.Information, "Success")
            fname.Text = ""
            lname.Text = ""
            email.Text = ""
            phone.Text = ""
            password.Text = ""
            Response.Redirect("Home.aspx")
        End If

        con.Close()
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Parth Rohit\source\repos\Practice\Practice\App_Data\register.mdf;Integrated Security=True"
        con.Open()

        ' Validate that searchbox.Text contains a valid integer
        Dim id As Integer
        If Integer.TryParse(btn.Text, id) Then
            cmd = New SqlCommand("SELECT * FROM register where Id = '" + searchbox.Text + "' ", con)
            cmd.Parameters.AddWithValue("@Id", id)

            dr = cmd.ExecuteReader

            If dr.Read Then
                p_id.Text = dr.GetValue(0).ToString() ' Id column (index 0)
                fname.Text = dr.GetString(1) ' FirstName column (index 1)
                lname.Text = dr.GetString(2) ' LastName column (index 2)
                email.Text = dr.GetString(3) ' Email column (index 3)
                phone.Text = dr.GetString(4) ' Phone column (index 4)
                password.Text = dr.GetString(5) ' Password column (index 5)
            Else
                MsgBox("Record not found")
            End If

        Else
            MsgBox("Please enter a valid numeric Id")
        End If

        con.Close()
    End Sub


End Class
