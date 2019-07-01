Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace adminlte.Controllers

    Public Class WidgetsController
        Inherits System.Web.Mvc.Controller
        ' GET: Widgets
        Public Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace