Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Calc - About"

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Contact Sam"

        Return View()
    End Function
End Class
