using System.Data;
using System.Data.SqlClient;

public class sqlConnection
{
    private string m_strConnectionString;
    private SqlConnection m_cnnConnection;
    private sqlConnection m_oConnection;

    private SqlTransaction m_oTransaction;

    public object SetInitialValues()
    {
        m_oConnection = new sqlConnection();
        return m_oConnection;
    }


    private SqlConnection Connect2Database()
    {
        SqlConnection cnnConnection = default(SqlConnection);

        if (m_oConnection == null)
        {
            m_oConnection = new sqlConnection();
        }
        cnnConnection = new SqlConnection();

        cnnConnection.ConnectionString = GetConnectionString();
        cnnConnection.Open();
        return cnnConnection;
    }

    public SqlConnection DBConnection
    {
        get
        {
            if (m_cnnConnection == null)
            {
                m_cnnConnection = Connect2Database();
            }
            if (m_cnnConnection.State == ConnectionState.Broken | m_cnnConnection.State == ConnectionState.Closed)
            {
                m_cnnConnection = Connect2Database();
            }
            return m_cnnConnection;
        }
        set
        {
            if (value == null)
            {
                if (m_oTransaction == null)
                {
                    if ((m_cnnConnection != null))
                    {
                        if (m_cnnConnection.State == ConnectionState.Open)
                        {
                            m_cnnConnection.Close();
                        }
                        m_cnnConnection.Dispose();
                    }
                }
            }
            m_cnnConnection = value;
        }
    }

    public SqlTransaction DBTransaction
    {
        get
        {
            if (m_oTransaction == null)
            {
                m_oTransaction = DBConnection.BeginTransaction();
            }
            return m_oTransaction;
        }
        set { m_oTransaction = value; }
    }

    private string GetConnectionString()
    {
        m_strConnectionString = "server=Onurerdemiroglu; Initial Catalog=Bimser;Integrated Security=SSPI";
        return m_strConnectionString;
    }

    public string CONNECTION_STRING
    {
        get { return m_strConnectionString; }
        set { m_strConnectionString = value; }
    }

}