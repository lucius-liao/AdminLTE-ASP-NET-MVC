Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace adminlte.Controllers

    Public Class LayoutController
        Inherits Controller
        'GET Layout
        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function Boxed() As ActionResult
            Return View()
        End Function

        Public Function CollapsedSidebar() As ActionResult
            Return View()
        End Function

        Public Function Fixed() As ActionResult
            Return View()
        End Function

        Public Function TopNav() As ActionResult
            Return View()
        End Function
    End Class
End Namespace