Imports System.IO

Public Class Form1
    'Declare variables
    Dim fileName As String
    Dim strFileName As String = "EmployeeData"
    Dim strFirstName As String
    Dim strMiddleName As String
    Dim strLastName As String
    Dim intEmpNumber As Int32
    Dim selectedDepartment As String
    Dim strTelephone As String
    Dim intExtension As Int32
    Dim strEmail As String
    Dim valid As Boolean = True

    Dim employeeDataFile As StreamWriter

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        valid = True
        InputDataValidation()
        If valid = True Then
            Try
                ' write the data to the file
                Dim sw As StreamWriter = File.AppendText(fileName)

                ' Get the data and write it to the file.
                strFirstName = txtFirstName.Text().Trim()
                strMiddleName = txtMiddleName.Text().Trim()
                strLastName = txtMiddleName.Text().Trim()
                selectedDepartment = cmbDepartment.SelectedItem.ToString()
                strTelephone = txtTelNumber.Text().Trim()
                strEmail = txtEmail.Text().Trim()



                sw.WriteLine(strFileName)
                sw.WriteLine(strMiddleName)
                sw.WriteLine(strLastName)
                sw.WriteLine(intEmpNumber)
                sw.WriteLine(selectedDepartment)
                sw.WriteLine(strTelephone)
                sw.WriteLine(intExtension)
                sw.WriteLine(strEmail)

                'close the file
                sw.Close()

                MessageBox.Show("Record Saved. ")

            Catch
                ' Error message
                MessageBox.Show("That file cannot be created.")
            End Try
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the form
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Do
            fileName = InputBox("Input Needed", "Enter the name of the file.")
            If fileName = Nothing Or fileName = "" Then
                MessageBox.Show("No file name entered.")
            Else
                Exit Do
            End If
        Loop
    End Sub

    Sub InputDataValidation()
        'textbox validation
        strFirstName = txtFirstName.Text().Trim()
        If strFirstName = "" Then
            valid = False
            MessageBox.Show("Please enter First Name")
        End If

        strLastName = txtMiddleName.Text().Trim()
        If strLastName = "" Then
            valid = False
            MessageBox.Show("Please enter last Name")
        End If

        If cmbDepartment.SelectedIndex = -1 Then
            valid = False
            MessageBox.Show("Please select a department")
        End If

        'Employee number validation
        Try
            intEmpNumber = CInt(txtEmpNum.Text)
        Catch
            valid = False
            MessageBox.Show("Please enter integer for employee number")
        End Try

        'extension number validation
        Try
            intExtension = CInt(txtExtension.Text)
        Catch
            valid = False
            MessageBox.Show("Please enter number for extension")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtEmpNum.Text = ""
        txtTelNumber.Text = ""
        txtExtension.Text = ""
        txtEmail.Text = ""
        cmbDepartment.SelectedIndex = -1


    End Sub
End Class
