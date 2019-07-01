Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace adminlte.Controllers

    Public Class CalendarController
        Inherits Controller
        ' GET Calendar
        Public Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace