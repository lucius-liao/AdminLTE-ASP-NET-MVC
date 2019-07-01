Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace adminlte.Controllers

    Public Class TablesController
        Inherits System.Web.Mvc.Controller
        'GET: Tables
        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function Data() As ActionResult
            Return View()
        End Function

        Public Function Simple() As ActionResult
            Return View()
        End Function
    End Class
End Namespace