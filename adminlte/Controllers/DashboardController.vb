Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace adminlte.Controllers

    Public Class DashboardController
        Inherits Controller
        'GET: Dashboard
        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function Dashboardv1() As ActionResult
            Return View()
        End Function

        Public Function Dashboardv2() As ActionResult
            Return View()
        End Function
    End Class
End Namespace