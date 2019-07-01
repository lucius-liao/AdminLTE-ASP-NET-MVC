Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace adminlte.Controllers

    Public Class MailboxController
        Inherits System.Web.Mvc.Controller
        'GET: Mailbox
        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function Compose() As ActionResult
            Return View()
        End Function

        Public Function Mailbox() As ActionResult
            Return View()
        End Function

        Public Function ReadMail() As ActionResult
            Return View()
        End Function
    End Class
End Namespace