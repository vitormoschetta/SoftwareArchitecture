namespace Sample2.Connections
{
    public class OracleConnection : IConnection
    {
        public string GetConnection()
        {
            return "Connection Oracle";
        }
    }
}