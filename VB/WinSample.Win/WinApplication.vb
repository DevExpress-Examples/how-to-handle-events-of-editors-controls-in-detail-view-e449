Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo
Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Win

Namespace WinSample.Win
	Partial Public Class WinSampleWindowsFormsApplication
		Inherits WinApplication
        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
        End Sub
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub WinSampleWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
			e.Updater.Update()
			e.Handled = True
		End Sub
	End Class
End Namespace
