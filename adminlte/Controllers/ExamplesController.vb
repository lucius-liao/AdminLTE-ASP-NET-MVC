Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace adminlte.Controllers

    Public Class ExamplesController
        Inherits Controller
        'GET: Examples
        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function Page404() As ActionResult
            Return View()
        End Function

        Public Function Page500() As ActionResult
            Return View()
        End Function

        Public Function Blank() As ActionResult
            Return View()
        End Function

        Public Function InvoicePrint() As ActionResult
            Return View()
        End Function

        Public Function Invoice() As ActionResult
            Return View()
        End Function

        Public Function Lockscreen() As ActionResult
            Return View()
        End Function

        Public Function Login() As ActionResult
            Return View()
        End Function

        Public Function Pace() As ActionResult
            Return View()
        End Function

        Public Function PageProfile() As ActionResult
            Return View()
        End Function

        Public Function Register() As ActionResult
            Return View()
        End Function
    End Class
End Namespace