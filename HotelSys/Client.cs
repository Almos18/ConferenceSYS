using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceSYS_Prototype
{
    class Client
    {
        private int clientId;
        private String firstName;
        private String lastName;
        private String clientEmail;
        private String telephone;


        public Client()
        {
            clientId = 0;
            firstName = "";
            lastName = "";
            clientEmail = "";
            telephone = "";
        }

        public Client(int clientId, String firstName, String lastName, String clientEmail, String telephone)
        {
            this.clientId = clientId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.clientEmail = clientEmail;
            this.telephone = telephone;
        }

        public int getClientId()
        {
            return clientId;
        }

        public void setClientId(int clientId)
        {
            this.clientId = clientId;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public String getEmail()
        {
            return clientEmail;
        }

        public void setEmail(String clientEmail)
        {
            this.clientEmail = clientEmail;
        }

        public String getPhone()
        {
            return telephone;
        }

        public void setPhone(String telephone)
        {
            this.telephone = telephone;
        }

        public static int getNextClientId()
        {
            int nextId;

            String strSQL = "SELECT MAX(clientId) FROM CLIENT_TABLE";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
 
                nextId = 1;           

            else
                nextId = dr.GetInt32(0) + 1;
                conn.Close();
            
                return nextId;
            
        }

        public void addClient()
        {
            String strSQL = "INSERT INTO CLIENT_TABLE(clientId , firstName, lastName, clientEmail, telephone) VALUES(" + getNextClientId() + ",'" + 
                this.firstName + "','" + this.lastName + "','" + this.clientEmail + "','" + this.telephone + "')";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataSet getSummaryClients()
        {
            //define Sql Query to get summary of available clients
            String strSQL = "SELECT clientId, lastname, firstname, clientEmail FROM CLIENT_TABLE ORDER BY lastname, firstname";
            //declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            //declare DataSet to return records to application
            DataSet ds = new DataSet();
            da.Fill(ds, "WS");
            //Close database connection
            conn.Close();
            return ds;
        }

        public void getClient(int clientId)
        {
            //define Sql Query
            String strSQL = "SELECT * FROM CLIENT_TABLE WHERE clientId = " + clientId;
            //declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            //read the record returned in dr and use values to instantiate the object
            dr.Read();
            this.clientId = dr.GetInt32(0);
            this.firstName = dr.GetString(1);
            this.lastName = dr.GetString(2);
            this.clientEmail = dr.GetString(3);
            this.telephone = dr.GetString(4);
            //close database connection
            conn.Close();
        }

        public void updateClient()
        {
            String strSQL = "UPDATE CLIENT_TABLE SET clientId = " + this.clientId +
              ", firstName  = '" + this.firstName + "', lastName = '" + this.lastName +
              "', clientEmail = '" + this.clientEmail + "', telephone = '" + this.telephone +
                     "' WHERE clientId = " + this.clientId;
            //declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void loadClients(ComboBox clientsCbo)
        {
            String strSQL = "SELECT * FROM CLIENT_TABLE ORDER BY clientID ";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                clientsCbo.Items.Add(dr.GetString(0) + " " );
            }

            conn.Close();
        }

    }
}