using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// These namespaces are initialized to allow for a connection to the database
using System.Data.OleDb;
using System.Net;
using System.Data;

/// <summary>
/// Summary description for clsDataLayer
/// </summary>
public class clsDataLayer
{

    // This function verifies a user in the tblUser table
    public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
    {
        // Sets variable names 
        dsUser DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;
        // Establishes the connection to the database
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=" + Database);
        // Compares input information to the existing database information.
        sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
        "where UserName like '" + UserName + "' " +
        "and UserPassword like '" + UserPassword + "'", sqlConn);
        // Creates a new user in the database
        DS = new dsUser();
        // Inputs new user information to the database on tblUserLogin
        sqlDA.Fill(DS.tblUserLogin);
        // Returns the DataSet information as DS
        return DS;
    }  

    // This function gets the user activity from the tblPersonnel
    public static dsPersonnel GetPersonnel(string Database, string strSearch)
    {
        // Establishes the data set and database connection
        dsPersonnel DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        // Adds connection known as sqlConn
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        // Allows data to access sql server
        if (strSearch == null || strSearch.Trim() == "")
             {
                 sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
             }
        else
             {
                 sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName = '" + strSearch + "'", sqlConn);
             }
        // Creates data set to track personnel information
        DS = new dsPersonnel();
        // Fills the Personnel table with data gathered
        sqlDA.Fill(DS.tblPersonnel);
        // Returns output of the Personnel table to the Personnel data set
        return DS;
    }
    // This function saves the personnel data
    public static bool SavePersonnel(string Database, string FirstName, string LastName,
    string PayRate, string StartDate, string EndDate)
    {
        bool recordSaved;

            // Try/Catch to validate data being inserted into tblPersonnel. ROLLBACK if invalid.
        OleDbTransaction myTransaction = null;
            try
            {
                // Opens a connection to the database we created last week, and stores all of the information as Database.
                OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
                conn.Open();
                OleDbCommand command = conn.CreateCommand();
                string strSQL;

                // Begins a transaction and named myTransaction
                myTransaction = conn.BeginTransaction();
                command.Transaction = myTransaction;


                //// Inserts the variables known as FirstName, LastName, PayRate, StartDate, and EndDate into the SQL table tblPersonnel.
                //strSQL = "Insert into tblPersonnel " + "(FirstName, LastName, PayRate, StartDate, EndDate) values ('" + FirstName + "', '" + LastName + "', " + PayRate + ", '" + StartDate + "', '" + EndDate + "')";
                //// Establishes the preceding variables and the command type as text.
                //command.CommandType = CommandType.Text;
                //command.CommandText = strSQL;                
                //// Executes the SQL INSERT into tblPersonnel
                //command.ExecuteNonQuery();                
                // Closes database connection

                // Added this section of code to supercede the code above (commented out).
                // This section of code modifies the previous section to allow for a two-step insert method.
                strSQL = "Insert into tblPersonnel " +
                "(FirstName, LastName) values ('" +
                FirstName + "', '" + LastName + "')";
                // Establishes the variables and command type as TEXT.
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                // Executes the SQL INSERT into tblPersonnel
                command.ExecuteNonQuery();
                // Names the variables to be INSERTed into tblPersonnel
                strSQL = "Update tblPersonnel " +
                "Set PayRate=" + PayRate + ", " +
                "StartDate='" + StartDate + "', " +
                "EndDate='" + EndDate + "' " +
                "Where ID=(Select Max(ID) From tblPersonnel)";
                // Establishes the variables and command type as TEXT.
                command.CommandType = CommandType.Text;
                command.CommandText = strSQL;
                // Executes the SQL INSERT into tblPersonnel.
                command.ExecuteNonQuery();
                // COMMITs myTransaction if it is valid
                myTransaction.Commit();
                // Closes database connection
                conn.Close();
                recordSaved = true;
            }
            catch (Exception ex)
            {
                // ROLLBACK to valid data if new data is invalid
                myTransaction.Rollback();
                recordSaved = false;
            }
        return recordSaved;
    }
    // This function gets the user activity from the tblUserActivity
    public static dsUserActivity GetUserActivity(string Database)
    {
        // Establishes the data set and database connection
        dsUserActivity DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        // Adds connection known as sqlConn
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);
        // Allows data to access sql server
        sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);
        // Creates data set to track user activity
        DS = new dsUserActivity();
        // Fills the User Activity table with data gathered
        sqlDA.Fill(DS.tblUserActivity);
        // Returns output of the User Activity table to the User Activity data set
        return DS;
    }
    // This function saves the user activity
    public static void SaveUserActivity(string Database, string FormAccessed)
    {
        // Establishes a connection to the database
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=" + Database);
        conn.Open();
        OleDbCommand command = conn.CreateCommand();
        string strSQL;
        strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
        GetIP4Address() + "', '" + FormAccessed + "')";
        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
    }

    // Saves a new user
    public static bool SaveUser(string Database, string UserName, string Password, string SecurityLevel)
    {
        // Establishes a connection to the database
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=" + Database);
        conn.Open();
        OleDbCommand command = conn.CreateCommand();
        string strSQL;
        strSQL = "Insert into tblUserLogin (UserName, UserPassword, SecurityLevel) values ('" +
        UserName + "', '" + Password + "', '" + SecurityLevel + "' )";
        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
        return true;
    }
    // This function gets the IP Address
    public static string GetIP4Address()
    {
        string IP4Address = string.Empty;
        foreach (IPAddress IPA in
        Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        if (IP4Address != string.Empty)
        {
            return IP4Address;
        }
        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        return IP4Address;
    }
	public clsDataLayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}

      
}