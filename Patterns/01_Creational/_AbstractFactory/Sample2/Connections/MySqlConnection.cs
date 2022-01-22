namespace Sample2.Connections
{
    public class MySqlConnection : IConnection
    {
        string IConnection.GetConnection()
        {
            return "Connection MySql";
        }
    }
}