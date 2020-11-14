Public Class Form1
    Private Property NumberOfJobsExecuted As Integer = 0
    Private Property TotalProgress As Integer = 0

    ' The button event handler must be declared async
    Private Async Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Reset()
        Dim jobFuncs = Worker.CreateJobFuncs()
        For Each jobFunc In jobFuncs
            Try
                Me.ShowBusy(True)
                ' This runs the background task in a thread without locking up UI
                Dim newProgress = Await jobFunc.RunAsynchronously()
                ' UI thread will resume execution once the async function has returned
                Me.SetProgress(newProgress)
            Catch ex As Exception
                ' If the background task throws an expection it will be caught here
                MessageBox.Show("Something blew up")
                Me.Reset()
                Exit For
            Finally
                Me.ShowBusy(False)
            End Try
        Next
    End Sub

    Private Sub Reset()
        Me.TotalProgress = 0
        Me.NumberOfJobsExecuted = 0
        lbCount.Text = Me.TotalProgress.ToString()
    End Sub

    Private Sub SetProgress(progress As Integer)
        Me.TotalProgress += progress
        lbCount.Text = Me.TotalProgress.ToString()
    End Sub

    Private Sub ShowBusy(isBusy As Boolean)
        Me.btnStart.Enabled = Not isBusy

        If isBusy Then
            Me.NumberOfJobsExecuted += 1
            Me.lblWorking.Text = $"Running background task #{Me.NumberOfJobsExecuted}..."
        Else
            Me.lblWorking.Text = $"{Me.NumberOfJobsExecuted} tasks finished."
        End If
    End Sub
End Class
