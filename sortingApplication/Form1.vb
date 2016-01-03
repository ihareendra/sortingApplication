Imports System.IO


Public Class Form1

    Dim fileName As String 'defined to store the entire path and the name of the file
    Dim filePath As String 'defined to store only the path of the file excluding the file name
    Dim nameOnly As String 'defined to store only the file name excluding the rest of the path

    Private Sub openingFile()
        ' Create an instance of the open file dialog box.
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog
        'Dim fileName As String

        ' Set filter options and filter index.
        openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1

        openFileDialog1.Multiselect = True

        ' Call the ShowDialog method to show the dialogbox.
        Dim UserClickedOK As Boolean = openFileDialog1.ShowDialog

        ' Process input if the user clicked OK.
        If (UserClickedOK = True) Then
            'Open the selected file to read.
            Dim fileStream As System.IO.Stream = openFileDialog1.OpenFile

            fileName = openFileDialog1.FileName 'stores the entire path of the file
            filePath = IO.Path.GetDirectoryName(fileName) 'excludes file name and stores only path information
            nameOnly = IO.Path.GetFileNameWithoutExtension(fileName) 'excludes path and stores only file name


            Using reader As New System.IO.StreamReader(fileStream)
                ' Read the first line from the file and write it to the text box.
                tbResults.Text = reader.ReadToEnd
                txtFileName.Text = fileName  'displaying the path on the textbox for user ease     

            End Using
            fileStream.Close()
        End If
    End Sub

    Private Sub sortingNames()
        'sorting the names from the rich textbox 
        Dim LinesList As New List(Of String)
        LinesList.AddRange(tbResults.Lines)
        LinesList.Sort()

        tbResults.Text = ""

        For Each Str As String In LinesList
            tbResults.AppendText(Str & Environment.NewLine)
        Next
    End Sub

    Private Sub savingFileAs()
        ' Create a SaveFileDialog to request a path and file name to save to.
        Dim saveFile1 As New SaveFileDialog()

        ' Initialize the SaveFileDialog to specify the RTF extension for the file.
        saveFile1.DefaultExt = "*.txt"
        saveFile1.Filter = "Text Files|*.txt"

        ' Determine if the user selected a file name from the saveFileDialog.
        If (saveFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And (saveFile1.FileName.Length) > 0 Then

            ' Save the contents of the RichTextBox into the file.
            tbResults.SaveFile(saveFile1.FileName, _
                RichTextBoxStreamType.PlainText)

            MsgBox("Your file has been saved successfully", MsgBoxStyle.Information, "File Saved")

        End If
    End Sub

    Private Sub quickFileSave()
        ' Create a SaveFileDialog to request a path and file name to save to.
        Dim saveFile2 As New SaveFileDialog()

        ' Initialize the SaveFileDialog to specify the RTF extension for the file.
        'saveFile2.DefaultExt = "*.txt"
        'saveFile2.Filter = "Text Files|*.txt"
        saveFile2.FileName = filePath + "\" + nameOnly + "-sorted.txt"
       

        ' Save the contents of the RichTextBox into the file.
        tbResults.SaveFile(saveFile2.FileName, _
            RichTextBoxStreamType.PlainText)

        MsgBox("Your file has been saved successfully", MsgBoxStyle.Information, "File Saved")


    End Sub


    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        openingFile() 'calling the openFile function 
    End Sub

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        sortingNames() 'calling the sortingNames function 
    End Sub

    Private Sub btnSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAs.Click
        savingFileAs() 'calling the savingFileAs function 

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clearing the rich textbox contents
        tbResults.Text = ""
        txtFileName.Text = ""


    End Sub

    

    Private Sub btnQuickSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuickSave.Click
        quickFileSave() 'calling the quickFileSave function 


    End Sub

    Private Sub cbQuickSave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbQuickSave.CheckedChanged

        'determining whether the quick save button should be available or not
        If cbQuickSave.Checked = True Then

            btnQuickSave.Enabled = True

        Else
            btnQuickSave.Enabled = False

        End If

    End Sub

  
    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        helpForm.Show()
        Me.Hide()

    End Sub
End Class
