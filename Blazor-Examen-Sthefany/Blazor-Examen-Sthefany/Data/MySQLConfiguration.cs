namespace Blazor_Examen_Sthefany.Data
{
    public class MySQLConfiguration
    {
        public string CadenaConexion { get; }

        public MySQLConfiguration(string cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
        }
    }
}

