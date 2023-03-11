using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ex3_oracledata
{
    public class omda
    {
        public string ConnectionString { get; set; }
        public Oracle.ManagedDataAccess.Client.OracleConnection Connection { get; set; }
        public string Uid { get; set; }
        public string Pwd { get; set; }
        public string Server { get; set; }
        public string Port { get; set; }
        public string Sid { get; set; }

        public bool Connected()
        {
            return (Connection.State == System.Data.ConnectionState.Open);
        }

        public bool Connect(string uid, string pwd, string server, string port, string sid)
        {
            try
            {
                ConnectionString = "User Id=" + uid + ";Password=" + pwd + ";Data Source=" + server + ":" + port + "/" + sid;
                Connection = new OracleConnection(ConnectionString);
                Connection.Open();

                Uid = uid;
                Pwd = pwd;
                Server = server;
                Port = port;
                Sid = sid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return Connected();
        }

        public DataTable CreateDataTable(string sql)
        {
            return CreateDataTable(sql, null);
        }

        public void SetParameters(OracleCommand command, List<OracleParameter> pars)
        {
            command.BindByName = true;
            // the default for this is false for some reason !!!
            // it is also possible to use the (:1, :2, :3) syntax with ordered parameters
            // but BindByName will have to be false for that to work

            if (pars != null)
            {
                foreach (OracleParameter par in pars)
                {
                    command.Parameters.Add(par);
                }
            }
        }
        public DataTable CreateDataTable(string sql, List<OracleParameter> parameters)
        {
            DataTable dt = new DataTable();
            OracleCommand command = Connection.CreateCommand();
            command.InitialLONGFetchSize = -1;
            command.CommandText = sql;
            command.Parameters.Clear();
            SetParameters(command, parameters);

            dt.Load(command.ExecuteReader());

            return dt;
        }

    }
}
