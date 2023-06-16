Imports System.ComponentModel
Imports System.Windows.Forms
Imports Guna.UI2.WinForms

Public Class AsyncLoad
    Private Property DGV As DataGridView
    Private Property CBB As ComboBox
    Private Property ProgressBarLoad As Guna2CircleProgressBar
    Private Property LoadFunction As Action

    Private Timer As Timer

    ''' <summary>
    ''' ASYNC LOAD FOR COMBOBOX DATAS
    ''' </summary>
    ''' <param name="cbb">Function loading datas</param>
    ''' <param name="loadFunc"></param>
    Public Shared Sub AsyncLoadCBB(ByRef cbb As ComboBox, loadFunc As Action)
        Dim aLoad As New AsyncLoad
        aLoad.CBB = cbb
        aLoad.LoadFunction = loadFunc

        Dim bgw As New BackgroundWorker()

        AddHandler bgw.DoWork, Sub(sender As Object, e As EventArgs)
                                   aLoad.CBB.Invoke(Sub() aLoad.LoadFunction.Invoke())
                               End Sub
        bgw.RunWorkerAsync()
    End Sub

    ''' <summary>
    ''' ASYNC LOAD FOR DATAGRIDVIEW DATAS
    ''' </summary>
    ''' <param name="dgv"></param>
    ''' <param name="loadFunc">Function loading datas</param>
    ''' <param name="pbar">Guna2CircleProgressBar set in form</param>
    Public Shared Sub AsyncLoadDGV(ByRef dgv As DataGridView, loadFunc As Action, Optional ByRef pbar As Guna2CircleProgressBar = Nothing)
        Dim aLoad As New AsyncLoad
        aLoad.DGV = dgv
        aLoad.ProgressBarLoad = pbar
        aLoad.LoadFunction = loadFunc

        Dim bgw As New BackgroundWorker()

        AddHandler bgw.DoWork, Sub(sender As Object, e As EventArgs)
                                   aLoad.DGV.Invoke(Sub()
                                                        If aLoad.ProgressBarLoad IsNot Nothing Then
                                                            aLoad.Timer = New Timer
                                                            aLoad.Timer.Interval = 1
                                                            AddHandler aLoad.Timer.Tick, Sub()
                                                                                             Timer_Tick(aLoad.ProgressBarLoad, aLoad.Timer)
                                                                                         End Sub
                                                            aLoad.Timer.Enabled = True

                                                            aLoad.ProgressBarLoad.Value = 0
                                                            aLoad.ProgressBarLoad.Visible = True

                                                            aLoad.Timer.Start()
                                                        End If
                                                        aLoad.LoadFunction.Invoke()
                                                    End Sub)
                               End Sub
        AddHandler bgw.RunWorkerCompleted, Sub()
                                               LoadCompleted(aLoad.ProgressBarLoad, aLoad.Timer)
                                           End Sub

        bgw.RunWorkerAsync()
    End Sub
    Private Shared Sub Timer_Tick(ByRef ProgressBarLoad As Guna2CircleProgressBar, ByRef Timer As Timer)
        ProgressBarLoad.Increment(1)
        If ProgressBarLoad.Value = ProgressBarLoad.Maximum Then
            Timer.Enabled = False
        End If
    End Sub

    Private Shared Sub LoadCompleted(ByRef ProgressBarLoad As Guna2CircleProgressBar, ByRef Timer As Timer)
        If ProgressBarLoad IsNot Nothing Then
            ProgressBarLoad.Visible = False
            Timer.Enabled = False
        End If
    End Sub
End Class