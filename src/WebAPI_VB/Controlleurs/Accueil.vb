
Imports Microsoft.AspNetCore.Mvc

<Route("[controller]")>
Public Class Accueil
    Inherits ControllerBase

    Public Function Index() As String
        Return "Hello world"
    End Function

End Class