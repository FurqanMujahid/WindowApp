using System.Data.OleDb;

namespace CURDform
{
    internal class ExecuteNonQuery
    {
        private OleDbCommand cmd;

        public ExecuteNonQuery(OleDbCommand cmd)
        {
            this.cmd = cmd;
        }
    }
}