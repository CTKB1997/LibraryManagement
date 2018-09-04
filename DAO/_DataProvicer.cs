using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for DataProvider
/// </summary>
public static class _DataProvicer
{

    public static string getConnectionString()
    {
        string strConnection = ConfigurationManager.
            ConnectionStrings["LB"].ConnectionString;
        return strConnection;
    }

    //Execute Query
    public static DataSet ExecuteQueryWithDataSet(string strSQL,
        CommandType cmdType,
        params SqlParameter[] param)
    {
        SqlConnection cnn = new SqlConnection(getConnectionString());
        SqlCommand cmd = new SqlCommand(strSQL, cnn);
        cmd.CommandType = cmdType;
        cmd.Parameters.AddRange(param);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public static SqlDataReader ExecuteQueryWithDataReader(string strSQL,
        CommandType cmdType, params SqlParameter[] param)
    {
        SqlDataReader rd = null;
        SqlConnection cnn = new SqlConnection(getConnectionString());
        SqlCommand cmd = new SqlCommand(strSQL, cnn);
        cmd.CommandType = cmdType;
        cmd.Parameters.AddRange(param);
        try
        {
            cnn.Open();
            rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (Exception ex)
        {
            throw new Exception("Error : " + ex.Message);
        }
        return rd;
    }
    //ExecuteNonQuery
    public static bool ExecuteNonQuery(string strSQL,
        CommandType cmdType, params SqlParameter[] paramList)
    {
        bool result = false;
        SqlConnection cnn = new SqlConnection(getConnectionString());
        SqlCommand cmd = new SqlCommand(strSQL, cnn);
        cmd.CommandType = cmdType;
        cmd.Parameters.AddRange(paramList);
        try
        {
            cnn.Open();
            result = cmd.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            throw new Exception("Error : " + ex.Message);
        }
        finally
        {
            cnn.Close();
        }
        return result;
    }
}