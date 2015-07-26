Namespace Controllers
    Public Class ajaxtestController
        Inherits Controller

        ' GET: ajaxtest
        Public Function ajaxtest() As ActionResult
            ViewBag.Name = "Sam Sandhu"
            Return View()
        End Function

        <HttpGet>
        Public Function test() As PartialViewResult
            Dim x As String = Date.Now
            ViewBag.date = x
            Return PartialView("test")
        End Function

        <HttpGet>
        Public Function calc(e1 As String, e2 As String, op As String) As PartialViewResult
            Dim x As Double
            Select Case Int(op)
                Case 1
                    x = Convert.ToDouble(e1) + Convert.ToDouble(e2)
                Case 2
                    x = Convert.ToDouble(e1) - Convert.ToDouble(e2)
                Case 3
                    x = Convert.ToDouble(e1) * Convert.ToDouble(e2)
                Case 4
                    x = Convert.ToDouble(e1) / Convert.ToDouble(e2)
                Case 5
                    x = Convert.ToDouble(e1) ^ Convert.ToDouble(e2)
                Case 6
                    x = Math.Sqrt(Convert.ToDouble(e1))
                Case Else
            End Select
            ViewBag.results = FormatNumber(x, 2, , , TriState.True)
            Return PartialView("calc")
        End Function

    End Class

End Namespace