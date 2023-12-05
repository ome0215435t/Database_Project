using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Difficulty : MonoBehaviour
{

    public GameObject[] n;
    private int[] num;
    private int j;
   public void Easy()
    {
        for(int i=0; i<n.Length; i++)
        {
            n[i].SetActive(false);
        }
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";


        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();

                // 데이터베이스 작업 수행 예시
                string query = "SELECT COUNT(*) FROM CUBETABLE WHERE DIFFICULTY<4";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        int rowCount = Convert.ToInt32(command.ExecuteScalar());
                        j = rowCount;
                        for(int i = 0; i < rowCount; i++){
                            n[i].SetActive(true);
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
    public void Normal()
    {
        for (int i = 0; i < n.Length; i++)
        {
            n[i].SetActive(false);
        }
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";

        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();

                // 데이터베이스 작업 수행 예시
                string query = "SELECT COUNT(*) FROM CUBETABLE WHERE DIFFICULTY >= 4 AND DIFFICULTY < 8";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        int rowCount = Convert.ToInt32(command.ExecuteScalar());
                        j = rowCount;
                        for (int i = 0; i < rowCount; i++)
                        {
                            n[i].SetActive(true);
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
    public void Hard()
    {
        for (int i = 0; i < n.Length; i++)
        {
            n[i].SetActive(false);
        }
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";


        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();

                // 데이터베이스 작업 수행 예시
                string query = "SELECT COUNT(*) FROM CUBETABLE WHERE DIFFICULTY>=8";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        int rowCount = Convert.ToInt32(command.ExecuteScalar());
                        j = rowCount;
                        for (int i = 0; i < rowCount; i++)
                        {
                            n[i].SetActive(true);
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
    public void Easy_cube()
    {
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";


        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();

                // 데이터베이스 작업 수행 예시
                string query = "SELECT CUBE_ID FROM CUBETABLE WHERE DIFFICULTY<4";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read() && i < j)
                        {
                            int cubeId = reader.GetInt32(reader.GetOrdinal("CUBE_ID"));
                            n[i].GetComponent<Number>().numbers = cubeId;
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
    public void Normal_cube()
    {
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";


        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();

                // 데이터베이스 작업 수행 예시
                string query = "SELECT CUBE_ID FROM CUBETABLE WHERE DIFFICULTY >= 4 AND DIFFICULTY < 8";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read() && i < j)
                        {
                            int cubeId = reader.GetInt32(reader.GetOrdinal("CUBE_ID"));
                            n[i].GetComponent<Number>().numbers = cubeId;
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
    public void Hard_cube()
    {
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";


        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();

                // 데이터베이스 작업 수행 예시
                string query = "SELECT CUBE_ID FROM CUBETABLE WHERE DIFFICULTY >= 8";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read() && i < j)
                        {
                            int cubeId = reader.GetInt32(reader.GetOrdinal("CUBE_ID"));
                            n[i].GetComponent<Number>().numbers = cubeId;
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
}