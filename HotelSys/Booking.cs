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
    class Booking
    {
        private int bookingId;
        private int roomNumber;
        private String bookingDate;
        private String bookingTime;
        private int bookingCost;
        private int clientID;

        public Booking()
        {
            bookingId = 0;
            roomNumber = 0;
            bookingDate = "";
            bookingTime = "";
            bookingCost = 0;
            clientID = 0;
        }

        public Booking(int bookingId, int roomNumber, int clientID, String bookingDate, String bookingTime, int bookingCost)
        {
            this.bookingId = bookingId;
            this.roomNumber = roomNumber;
            this.bookingDate = bookingDate;
            this.bookingTime = bookingTime;
            this.bookingCost = bookingCost;
            this.clientID = clientID;
        }

        public static int generateCost(String time)
        {
            if(time == "09:00-11:30")
            {
                return 10;
            }

            else if(time == "12:00-14:30")
            {
                return 20;
            }

            else if(time == "15:00-17:30")
            {
                return 30;
            }

            else if(time == "18:00-20:30")
            {
                return 40;
            }
            else
            {
                return 50;
            }
        }

        public static int getNextBookingId()
        {
            int nextId;

            String strSQL = "SELECT MAX(bookingId) FROM BOOKING_TABLE";

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

        public static Boolean isReserved(String bookingDate, String bookingTime, int roomNumber)
        {
            Boolean result = false;

            String strSQL = "SELECT * FROM BOOKING_TABLE WHERE bookingDate = '" + bookingDate 
            + "' AND bookingTime = '" + bookingTime +"' AND roomNumber = '" + roomNumber + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                 result = true;

            conn.Close();

            return result;
        }

        public void addBooking()
        {
            String strSQL = "INSERT INTO BOOKING_TABLE(bookingId, bookingDate, roomNumber, clientID, bookingCost, bookingTime) VALUES(" + this.bookingId + ", '"
            + this.bookingDate + "', " + this.roomNumber + "," + this.clientID + "," + this.bookingCost + ",'" + this.bookingTime + "')";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void getBookingId(int bookingId)
        {
            String strSQL = "SELECT * FROM BOOKING_TABLE WHERE bookingId = " + bookingId;
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            this.bookingId = dr.GetInt32(0);
            conn.Close();
        }

        public static DataSet getSummaryBookings()
        {
            String strSQL = "SELECT bookingId, bookingDate, bookingTime, roomNumber FROM BOOKING_TABLE ORDER BY bookingDate";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "WS");
            conn.Close();
            return ds;
        }

        public void deleteBooking()
        {
            String strSQL = "DELETE FROM BOOKING_TABLE WHERE bookingId = " + this.bookingId;
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

