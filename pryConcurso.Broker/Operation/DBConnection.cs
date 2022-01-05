namespace pryConcurso.Broker.Operation
{
    public static class DBConnection
    {
        // Base de Datos Local:
        //public static string strConnectionString = @"Data Source=DESKTOP-PHVSG8C;Initial Catalog=dbaConcurso;User ID=concurso;Password=concurso;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Base de Datos en Azure:
        public static string strConnectionString = @"Server=tcp:concursoserver.database.windows.net,1433;Initial Catalog=dbaConcurso;Persist Security Info=False;User ID=dbaConcurso;Password=A8f_2Fa2GpB92_;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
}
