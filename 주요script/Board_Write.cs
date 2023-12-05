using JetBrains.Annotations;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.UI;

public class Board_Write : MonoBehaviour
{
    public Text[] w;
    public InputField Board;
    public Text t;
    public int Board_n=0;
    private string write;
    public int good =0;
    public int j = 0;
    public string user_id = "pdy";
    public void Write_Board()
    {
        write =Board.GetComponent<InputField>().text;
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();

                // 데이터베이스 작업 수행 예시
                string query = "SELECT MAX(BOARD_N) AS BOARD_N FROM BOARDTABLE";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Board_n = reader.GetInt32(reader.GetOrdinal("BOARD_N"));
                            Board_n++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Board_n = 0;
            }
            finally
            {
                connection.Close();
            }
        }
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO BOARDTABLE VALUES (:value1, :value2, :value3)";

            using (OracleCommand cmd = new OracleCommand(insertQuery, connection))
            {
                cmd.Parameters.Add(new OracleParameter("value1", OracleDbType.Int64)).Value = Board_n;
                cmd.Parameters.Add(new OracleParameter("value2", OracleDbType.Varchar2)).Value = user_id;
                cmd.Parameters.Add(new OracleParameter("value3", OracleDbType.Varchar2)).Value = write;
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                }
                catch (OracleException ex)
                {
                    if (ex.Number == 1400)
                    {
                        t.text = "내용이 비어있습니다";
                    }
                    else
                    {
                        Debug.LogError("Oracle Exception: " + ex.Message);
                    }
                }
                finally
                {
                    connection.Close();
                }
            }

        }

    }
    public void Random_Read()
    {
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";

        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM BOARDTABLE";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read() && i < 5)
                        {
                            string read = reader["WRITE"].ToString();
                            string id = reader["USER_ID"].ToString();
                            w[i].text=id+" : "+read+"\n";
                            i++;
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
    public void My_Read()
    {

    }
}

