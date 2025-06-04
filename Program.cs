namespace SistemaDeCitasMordagiss;
using System;
using System.Windows.Forms;
using SistemaDeCitasMordagiss.DataAccess;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
       // Application.Run(new Form1());

        if (!Database.TestConnection())
        {
            MessageBox.Show("No se pudo conectar a la base de datos." +
                "verificar que ClinicaMordargiss.db este en la carpeta bin\\Debug\\netX." +
                "Error de conexion " + MessageBoxButtons.OK + MessageBoxIcon.Error);
            return;
        }
        Application.Run(new Views.LoginForm());
    }
   

}