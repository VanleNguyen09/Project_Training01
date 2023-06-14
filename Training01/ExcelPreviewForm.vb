Imports System.Threading
Imports OfficeFunctions = FuntionCommon.CommonOfficeFunctions

Public Class ExcelPreviewForm
    Private CallBack As Action(Of String)
    Public Property Datas As DataTable

    Private Sub ExcelPreviewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDGV()
        CustomElements.MovingDashboardByPanels(Me, pnHeader)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Callback.Invoke()
        Dim result = MessageBox.Show("Do you want to confirm saving?", Message.Title.notif, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Select Case result
            Case DialogResult.Yes
                'Me.Close()
                CallBack = AddressOf ShowDialogOpenExcel
                Dim excelThread = New Thread(Sub() OfficeFunctions.ExportToExcel(Datas, CallBack))
                excelThread.SetApartmentState(ApartmentState.STA) 'Single Threaded Apartment
                CustomElements.ShowCirProgressBar(3, New Size(200, 200))
                Try
                    excelThread.Start()
                Catch ex As Exception
                    MessageBox.Show("EXCEL ERROR: " & ex.Message, Message.Title.error, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            Case DialogResult.No
                Exit Sub
        End Select

    End Sub

    Private Sub ShowDialogOpenExcel(ByVal addressFile As String)
        'Fix Cross-thread operation not valid
        If Me.InvokeRequired Then
            Me.Invoke(Sub()
                          Dim result = MessageBox.Show(Me, "Do you want to open this file excel?", Message.Title.notif, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                          Select Case result
                              Case DialogResult.Yes
                                  Process.Start(addressFile)
                          End Select
                      End Sub)
        Else
            MessageBox.Show("Your message here!")
        End If
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Me.Close()
    End Sub

    Private Sub closeApp_MouseEnter(sender As Object, e As EventArgs) Handles closeApp.MouseEnter
        closeApp.BackColor = Color.Azure
    End Sub

    Private Sub closeApp_MouseLeave(sender As Object, e As EventArgs) Handles closeApp.MouseLeave
        closeApp.BackColor = Color.Transparent
    End Sub

    Private Sub dgv_Sorted(sender As Object, e As EventArgs) Handles dgv.Sorted

    End Sub

    Private Sub dgv_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.ColumnHeaderMouseClick
        Dim columnIndex = e.ColumnIndex
        Dim dgvColumn = dgv.Columns(columnIndex)

        If e.ColumnIndex <> 0 AndAlso e.Button = MouseButtons.Left AndAlso dgvColumn.SortMode <> DataGridViewColumnSortMode.NotSortable Then
            Dim replaceColumnNameList As New Dictionary(Of String, String)
            replaceColumnNameList.Add("emp_name", "name")
            Dim sortedColumnIndex = columnIndex
            Dim sortedDirection = dgv.Columns(sortedColumnIndex).HeaderCell.SortGlyphDirection

            If sortedDirection = SortOrder.None OrElse sortedDirection = SortOrder.Descending Then
                sortedDirection = SortOrder.Ascending
            ElseIf sortedDirection = SortOrder.Ascending Then
                sortedDirection = SortOrder.Descending
            End If

            dgv.Columns(sortedColumnIndex).HeaderCell.SortGlyphDirection = sortedDirection

            'Datas will change when sorted
            FuntionCommon.Sortation.SortDataTableAndPreventSttColumn(dgv, Datas,
                                                                     sortedColumnIndex, "stt", replaceColumnNameList)
            LoadDGV()
            dgv.Columns(sortedColumnIndex).HeaderCell.SortGlyphDirection = sortedDirection
        End If
    End Sub

    Private Sub LoadDGV()
        dgv.Columns("stt").DataPropertyName = "stt"
        dgv.Columns("id").DataPropertyName = "id"
        dgv.Columns("emp_name").DataPropertyName = "name"
        dgv.Columns("phone").DataPropertyName = "phone"
        dgv.Columns("birthday").DataPropertyName = "birthday"
        dgv.Columns("email").DataPropertyName = "email"
        dgv.Columns("salary_name").DataPropertyName = "salary_name"
        dgv.Columns("salary").DataPropertyName = "salary"

        dgv.DataSource = Datas
    End Sub
End Class