Public Class frm_Inventory_Data_Collector
    ' Global Variable
    Dim fileName As String = "C:\Users\Public\Documents\inventory.csv"

    ' Global Object
    Dim objWriter As New System.IO.StreamWriter(fileName, True)

    ' If file doesn't exists, creates file and adds header
    Private Sub frm_Inventory_Data_Collector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objWriter.Write("Qty, Each, Description, Location, Notes" & vbNewLine)
    End Sub

    ' Message asking the user to enter information for at least two items
    Private Sub frm_Inventory_Data_Collector_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        MessageBox.Show("Enter inventory data for at least two items.")
    End Sub

    ' Button to exit the program
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Dim Response As Integer
        Response = MessageBox.Show("Do you really want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
        End If
    End Sub

    ' Appends the inventory data to the files
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim validQty As Integer
        Dim validEach As Double

        If Integer.TryParse(txt_Qty.Text, validQty) Then
            If Double.TryParse(txt_Each.Text, validEach) Then
                If Not String.IsNullOrEmpty(LTrim(txt_Description.Text)) Then
                    If Not String.IsNullOrEmpty(LTrim(txt_Location.Text)) Then
                        objWriter.WriteLine(txt_Qty.Text + "," + FormatNumber(CDbl(txt_Each.Text), 2) + "," + txt_Description.Text +
                                                "," + txt_Location.Text + "," + txt_Notes.Text)

                        MessageBox.Show("Data added to the file")

                        txt_Qty.Clear()
                        txt_Each.Clear()
                        txt_Description.Clear()
                        txt_Location.Clear()
                        txt_Notes.Clear()
                    Else
                        MessageBox.Show("Enter a location.")
                    End If
                Else
                    MessageBox.Show("Enter a description.")
                End If
            Else
                MessageBox.Show("Enter a valid price.")
            End If
        Else
            MessageBox.Show("Enter a valid quantity.")
        End If
    End Sub

    ' Closes the file and alerts the user of such
    Private Sub btn_Finished_Click(sender As Object, e As EventArgs) Handles btn_Finished.Click
        objWriter.Close()

        MessageBox.Show("Inventory file has been saved successfully!")

        btn_Check.Enabled = True
    End Sub

    ' Reads file into message box
    Private Sub btn_Check_Click(sender As Object, e As EventArgs) Handles btn_Check.Click
        Dim TextLine As String = ""
        Dim objReader As New System.IO.StreamReader(fileName)

        Do While objReader.Peek() <> -1
            TextLine = TextLine & objReader.ReadLine() & vbNewLine
        Loop

        MessageBox.Show(TextLine)

        objReader.Close()
    End Sub
End Class