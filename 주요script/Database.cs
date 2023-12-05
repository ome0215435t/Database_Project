using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

public class Database : MonoBehaviour
{
    void Start()
    {
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";


        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM TABLE1";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string column1Value = reader["Column1"].ToString();
                            string column2Value = reader["Column2"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.LogError("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}