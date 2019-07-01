Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace adminlte.Controllers
    Public Class FormsController
        Inherits Controller
        'GET: Forms
        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function Advanced() As ActionResult
            Return View()
        End Function

        Public Function Editors() As ActionResult
            Return View()
        End Function

        Public Function General() As ActionResult
            Return View()
        End Function
    End Class
End Namespace