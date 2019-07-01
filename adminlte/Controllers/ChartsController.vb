Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace adminlte.Controllers

    Public Class ChartsController
        Inherits Controller
        ' GET Charts
        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function Chartjs() As ActionResult
            Return View()
        End Function

        Public Function Flot() As ActionResult
            Return View()
        End Function

        Public Function Inline() As ActionResult
            Return View()
        End Function

        Public Function Morris() As ActionResult
            Return View()
        End Function
    End Class
End Namespace