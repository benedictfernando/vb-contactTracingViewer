Imports System.IO

Public Class Form1

    ' Create empty array of string for entries
    Private entries As String()

    Private Sub viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize database file & its directory
        Dim username As String = "Benedict"
        Dim database As String = $"C:\Users\{username}\Documents\CTDatabase.txt"

        If File.Exists(database) Then
            entries = File.ReadAllText(database).Split(vbLf & vbLf).SkipLast(1).ToArray()
            firstEntry()
        Else
            MessageBox.Show("No 'CTDatabase.txt' file was found." & vbLf & vbLf &
                    "Kindly submit at least one entry first using our " &
                    "Contact Tracer App, then return to us again later.",
                    "CT Database Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.[Exit]()
        End If
    End Sub

    ' Load 1st entry
    Private Sub firstEntry()
        pages.Text = "1 out of " & entries.Length
        loadEntry(1)
        If entries.Length = 1 Then rightArrow.Enabled = False
    End Sub

    ' Load nth entries
    Private Sub loadEntry(ByVal page As Integer)
        ' Create an array of data from individual entries
        Dim data As String() = entries(System.Threading.Interlocked.Decrement(page)).Split(vbLf)

        ' Initialize array of the fields from our app
        Dim field As Label() = {submission, temp, fullName, gender, address, status, contacts}

        ' Set each field to its corresponding data from text database
        For i As Integer = 0 To field.Length - 1
            field(i).Text = data(i)
        Next
    End Sub

    ' Handle button click
    Private Sub transferPage(sender As Object, e As EventArgs) Handles rightArrow.Click, leftArrow.Click
        Dim list As Integer = entries.Length
        Dim space As Integer = pages.Text.IndexOf(" "c)
        Dim page As Integer = Int32.Parse(pages.Text.Substring(0, space))

        ' Increment or decrement page
        If (TryCast(sender, Button)).Name = "rightArrow" Then
            page += 1
        Else
            page -= 1
        End If

        ' Disable back & forward buttons
        If page = 1 Then
            leftArrow.Enabled = False
        Else
            leftArrow.Enabled = True
        End If

        If page = list Then
            rightArrow.Enabled = False
        Else
            rightArrow.Enabled = True
        End If

        ' Load necessary changes
        loadEntry(page)
        pages.Text = $"{page} out of {list}"
    End Sub
End Class
