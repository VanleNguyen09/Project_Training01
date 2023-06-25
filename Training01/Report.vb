Imports Connection
Imports GrapeCity.ActiveReports
Imports GrapeCity.ActiveReports.Data
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel

Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomElements.MovingForm(Me)
        LoadReport()
    End Sub

    Private Sub LoadReport()

        Dim report As New SectionReport()

        Dim reportHeader As New ReportHeader()
        report.Sections.Add(reportHeader)

        Dim titleTextBox As New TextBox()

        titleTextBox.Text = "REPORT EMPLOYEE LIST"

        titleTextBox.Font = New Font("Arial", 16)
        reportHeader.Controls.Add(titleTextBox)

        ' Set horizontal alignment (horizontal alignment)

        'titleTextBox.TextJustify = TextJustify.Auto
        Dim detail As New Detail()

        detail.Height = 0.5
        report.Sections.Add(detail)

        Dim arr1 = {"Name", "Phone", "Address", "Gender", "Email", "Status"}

        For i As Integer = 0 To arr1.Length - 1
            Dim label As New Label()
            label.Text = arr1(i)
            label.Location = New PointF(i * 1.2, 0.2)

            Dim dataTextBox As New TextBox()
            dataTextBox.DataField = arr1(i)

            dataTextBox.Location = New PointF(i * 1.2, 0.5)
            reportHeader.Controls.Add(label)
            detail.Controls.Add(dataTextBox)
        Next

        'Dim dataSource As New SqlDBDataSource()

        'dataSource.ConnectionString = ConnectSQL.GetConnectionString()

        'Dim query = "Select * from Employees where status = 1"
        'dataSource.SQL = query

        'report.DataSource = dataSource

        Dim dbcontext As New DataClasses1DataContext(ConnectSQL.GetConnectionString())
        Console.WriteLine(ConnectSQL.GetConnectionString())

        Console.WriteLine(dbcontext)

        Dim query = From employee In dbcontext.Employees
                    Join dept_emp In dbcontext.Dept_emps On dept_emp.emp_id Equals employee.id
                    Join department In dbcontext.Departments On dept_emp.dept_id Equals department.id
                    Where dept_emp.status = 1
                    Order By dept_emp.id Descending
                    Select employee

        For Each data1 In query
            Console.WriteLine(data1)
        Next

        'Console.WriteLine(dbcontext.Employees)
        report.DataSource = query.ToList()

        'Dim sqlQuery As String = String.Join(" ", query)

        'dataSource.SQL = sqlQuery

        Dim reportFooter As New ReportFooter()

        report.Sections.Add(reportFooter)

        Viewer2.LoadDocument(report)
    End Sub

    Private Sub closeApp_Click(sender As Object, e As EventArgs) Handles closeApp.Click
        Me.Close()
    End Sub
End Class