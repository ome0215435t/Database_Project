using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    private bool log=false;
    public Text t;
    public GameObject admin;
    public GameObject login_canvas;
    public GameObject mode_canvas;
    public InputField id_text;
    public InputField password_text;
    private string id,password;
    public void Login_press()
    {
        id = id_text.GetComponent<InputField>().text;
        password = password_text.GetComponent<InputField>().text;
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM USERTABLE";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string column1Value = reader["ID"].ToString();
                            string column2Value = reader["PASSWORD"].ToString();
                            if(string.Equals(id, column1Value, StringComparison.Ordinal)&& string.Equals(password, column2Value, StringComparison.Ordinal))
                            {
                                log= true;
                                login_canvas.SetActive(false);
                                mode_canvas.SetActive(true);
                                admin.GetComponent<Control>().user_id = column1Value;
                                admin.GetComponent<Board_Write>().user_id = column1Value;
                                break;
                            }
                            else
                            {
                                log = false;
                            }
                        }
                        if (!log)
                        {
                            t.text="로그인 실패";
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
    public void Create_account()
    {
        id = id_text.GetComponent<InputField>().text;
        password = password_text.GetComponent<InputField>().text;
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";


        try
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO USERTABLE (ID, PASSWORD) VALUES (:value1, :value2)";

                using (OracleCommand cmd = new OracleCommand(insertQuery, connection))
                {
                    cmd.Parameters.Add(new OracleParameter("value1", OracleDbType.Varchar2)).Value = id;
                    cmd.Parameters.Add(new OracleParameter("value2", OracleDbType.Varchar2)).Value = password;

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            t.text="회원가입 완료";
                        }
                        else
                        {
                            t.text = "오류 발생";
                        }
                    }
                    catch (OracleException ex)
                    {
                        if (ex.Number == 1)
                        {
                            t.text = "이미 사용중인 아이디입니다";
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
        catch (Exception ex)
        {
            Debug.LogError("Error: " + ex.Message);
        }

    }
}