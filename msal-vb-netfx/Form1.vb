Imports System.Configuration
Imports Microsoft.Identity.Client

Public Class Form1

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim app As IPublicClientApplication = PublicClientApplicationBuilder.Create(ConfigurationManager.AppSettings.Item("clientId")).WithDefaultRedirectUri().Build()
        Dim result = Await app.AcquireTokenInteractive(New String() {}).ExecuteAsync().ConfigureAwait(False)

        Dim name = result.ClaimsPrincipal.FindFirst("name").Value
        Label1.Text = $"You logged in as {result.Account.Username}{If(String.IsNullOrWhiteSpace(name), "", $" ({name})")}"

    End Sub
End Class
