namespace Sample1.Connections
{
    public class MySqlConnection : IConnection
    {
        string IConnection.GetConnection()
        {
            return "Connection MySql";
        }
    }
}