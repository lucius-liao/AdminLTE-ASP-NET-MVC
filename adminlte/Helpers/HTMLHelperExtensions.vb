Imports System.Web.Mvc
Imports System.Runtime.CompilerServices
Public Module HTMLHelperExtensions
    <Extension()>
    Public Function IsSelected(ByVal html As HtmlHelper, Optional ByVal controller As String = Nothing, Optional ByVal action As String = Nothing, Optional ByVal cssClass As String = Nothing) As String
        If String.IsNullOrEmpty(cssClass) Then
            cssClass = "active"
        End If

        Dim currentAction As String = html.ViewContext.RouteData.Values("action")
        Dim currentController As String = html.ViewContext.RouteData.Values("controller")

        If String.IsNullOrEmpty(controller) Then
            controller = currentController
        End If

        If String.IsNullOrEmpty(action) Then
            action = currentAction
        End If

        If controller = currentController And action = currentAction Then
            Return cssClass
        Else
            Return String.Empty
        End If

    End Function

    Public Function PageClass(ByVal html As HtmlHelper) As String
        Dim currentAction As String = html.ViewContext.RouteData.Values("action")
        Return currentAction
    End Function
End Module
