namespace Sample1.Connections
{
    public class OracleConnection : IConnection
    {
        public string GetConnection()
        {
            return "Connection Oracle";
        }
    }
}