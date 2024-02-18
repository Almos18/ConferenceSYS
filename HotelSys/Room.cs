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
    class Room
    {
        private int roomNumber;
        private String roomType;
        private int capacity;
        private String roomName;
    
        public Room()
        {
            roomNumber = 0;
            roomType = "";
            capacity = 0;
            roomName = "";
        }

        public Room(int roomNumber, String roomType, int capacity, String description)
        {
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.capacity = capacity;
            this.roomName = description;
        }

        public void addRoom()
        {
            String strSQL = "INSERT INTO ROOM_TABLE(roomNumber, roomType, capacity, roomName) VALUES(" + this.roomNumber + ", '"
            + this.roomType + "', " + this.capacity + ",'" + this.roomName + "')";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void getRoomNumber(int roomNumber)
        {
            //define Sql Query
            String strSQL = "SELECT * FROM ROOM_TABLE WHERE roomNumber = " + roomNumber;
            //declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            //read the record returned in dr and use values to instantiate the object
            dr.Read();
            this.roomNumber = dr.GetInt32(0);
            //close database connection
            conn.Close();
        }

        public void deleteRoom()
        {
            String strSQL = "DELETE FROM ROOM_TABLE WHERE roomNumber = " + this.roomNumber;
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataSet getSummaryRooms()
        {
            String strSQL = "SELECT roomNumber, roomType, capacity, roomName FROM ROOM_TABLE ORDER BY roomNumber";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "WS");
            conn.Close();
            return ds;
        }

        public static bool roomNumberExists(int roomNumber)
        {
            Boolean result = false;

            String strSQL = "SELECT * FROM ROOM_TABLE WHERE roomNumber = '" + roomNumber + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                result = true;

            conn.Close();

            return result;
        }

        public static bool checkIfReserved(int roomNumber)
        {
            Boolean result = false;

            String strSQL = "SELECT * from BOOKING_TABLE WHERE roomNumber = '" + roomNumber + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                result = true;

            conn.Close();

            return result;
        }

        public static void loadRoomTypes(ComboBox cboName)
        {
            String strSQL = "SELECT * FROM Room_Types ORDER BY Description ";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                cboName.Items.Add(dr.GetString(0) + " " + dr.GetString(1));
            }

            conn.Close();
        }

        public static void loadRoomNumbers(ComboBox roomNumberBox)
        {
            String strSQL = "SELECT roomNumber FROM ROOM_TABLE";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                roomNumberBox.Items.Add(dr.GetString(0) + " ");
            }

            conn.Close();
        }


    }
}