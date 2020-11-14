Imports System.Runtime.CompilerServices

Public Module Worker
    Public Function CreateJobFuncs() As IEnumerable(Of Func(Of Integer))
        ' Create 5 some backround functions to be run one by one
        Return New List(Of Func(Of Integer)) From {
            CreateAsyncWork(1),
            CreateAsyncWork(2),
            CreateAsyncWork(3),
            CreateAsyncWork(4),
            CreateAsyncWork(5)
        }
    End Function

    Private Function CreateAsyncWork(delay As Integer) As Func(Of Integer)
        Return Function()
                   Return SomeBusyWork(delay)
               End Function
    End Function


    Private Function SomeBusyWork(delay As Integer) As Integer
        ' Pretend to be doing something busy, replace with network call etc
        ' Strictly no UI logic here (will crash if there is)
        Dim rand = New Random()
        Dim result = rand.Next(100)
        Threading.Thread.Sleep(delay * 1000)
        Return result
    End Function

    <Extension()>
    Public Function RunAsynchronously(Of T)(func As Func(Of T)) As Task(Of T)
        ' Wrap an background job func in a task so that it can be awaited from an async function
        Return Task.Run(Function() func())
    End Function
End Module
