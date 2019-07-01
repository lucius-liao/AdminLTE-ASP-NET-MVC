Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace adminlte.Controllers

    Public Class UIController
        Inherits System.Web.Mvc.Controller
        'GET: UI
        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function Buttons() As ActionResult
            Return View()
        End Function

        Public Function General() As ActionResult
            Return View()
        End Function

        Public Function Icons() As ActionResult
            Return View()
        End Function

        Public Function Modals() As ActionResult
            Return View()
        End Function

        Public Function Timeline() As ActionResult
            Return View()
        End Function
    End Class
End Namespace