using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinSample.Win {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
            WinSampleWindowsFormsApplication _application = new WinSampleWindowsFormsApplication();
            _application.ConnectionString = Demo.CodeCentralExampleInMemoryDataStoreProvider.ConnectionString;
            try {
                DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.Register();
                                _application.ConnectionString = DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.ConnectionString;
                _application.Setup();
                _application.Start();
            } catch (Exception e) {
                _application.HandleException(e);
            }
        }
    }
}
