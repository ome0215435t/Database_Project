using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TerrainUtils;

public class Control : MonoBehaviour
{
    public Text status;
    public Text record;
    public GameObject Timer;
    public Text turn;
    public Text t;
    public int difficulty=0;
    public string difficulty_s;
    public string user_id="pdy";
    public Text Cube_n;
    public int cube_id = 0;
    public int turn_n = 0;
    public GameObject c;
    public GameObject s;
    public float time;
    public int cubeIdValue = 0;
    public Material red;
    public Material green;
    public Material blue;
    public Material orange;
    public Material yellow;
    public Material white;
    public GameObject[] f;
    public GameObject[] d;
    public GameObject[] l;
    public GameObject[] r;
    public GameObject[] u;
    public GameObject[] b;
    string column3 = "0";
    string column2 = "1";
    string column1 = "2";
    string column4 = "3";
    string[] stringArray = new string[24];
    public void Turn_Reset()
    {
        turn_n = 0;
        turn.text = "돌린 횟수 : 0";
    }
    public void Create_Start()
    {
        for (int i = 0; i < 4; i++)
        {
            u[i].GetComponent<Renderer>().material = yellow;
            d[i].GetComponent<Renderer>().material = white;
            l[i].GetComponent<Renderer>().material = blue;
            r[i].GetComponent<Renderer>().material = green;
            f[i].GetComponent<Renderer>().material = red;
            b[i].GetComponent<Renderer>().material = orange;
        }
    }
    public void Up()
    {
        Material[] temp = new Material[2];
        Renderer renderer1 = f[1].GetComponent<Renderer>();
        Renderer renderer2 = f[2].GetComponent<Renderer>();
        Renderer renderer3 = u[0].GetComponent<Renderer>();
        Renderer renderer4 = u[1].GetComponent<Renderer>();
        Renderer renderer5 = u[2].GetComponent<Renderer>();
        Renderer renderer6 = u[3].GetComponent<Renderer>();
        Renderer renderer7 = l[1].GetComponent<Renderer>();
        Renderer renderer8 = l[2].GetComponent<Renderer>();
        Renderer renderer9 = r[1].GetComponent<Renderer>();
        Renderer renderer10 = r[2].GetComponent<Renderer>();
        Renderer renderer11 = b[1].GetComponent<Renderer>();
        Renderer renderer12 = b[2].GetComponent<Renderer>();
        temp[0] = renderer5.material;
        renderer5.material = renderer4.material;
        renderer4.material = renderer3.material;
        renderer3.material = renderer6.material;
        renderer6.material = temp[0];
        temp[0] = renderer12.material;
        temp[1] = renderer11.material;
        renderer12.material = renderer7.material;
        renderer11.material = renderer8.material;
        renderer7.material = renderer1.material;
        renderer8.material = renderer2.material;
        renderer1.material = renderer10.material;
        renderer2.material = renderer9.material;
        renderer10.material = temp[0];
        renderer9.material = temp[1];
        turn_n++;
        turn.text = "돌린 횟수 : " + turn_n;
    }
    public void Up_()
    {
        Up();
        Up();
        Up();
        turn_n -= 2;
        turn.text = "돌린 횟수 : " + turn_n;
    }
    public void Down()
    {
        Down_();
        Down_();
        Down_();
        turn_n -= 2;
        turn.text = "돌린 횟수 : " + turn_n;
    }
    public void Down_()
    {
        Material[] temp = new Material[2];
        Renderer renderer1 = f[0].GetComponent<Renderer>();
        Renderer renderer2 = f[3].GetComponent<Renderer>();
        Renderer renderer3 = d[0].GetComponent<Renderer>();
        Renderer renderer4 = d[1].GetComponent<Renderer>();
        Renderer renderer5 = d[2].GetComponent<Renderer>();
        Renderer renderer6 = d[3].GetComponent<Renderer>();
        Renderer renderer7 = l[0].GetComponent<Renderer>();
        Renderer renderer8 = l[3].GetComponent<Renderer>();
        Renderer renderer9 = r[0].GetComponent<Renderer>();
        Renderer renderer10 = r[3].GetComponent<Renderer>();
        Renderer renderer11 = b[0].GetComponent<Renderer>();
        Renderer renderer12 = b[3].GetComponent<Renderer>();
        temp[0] = renderer3.material;
        renderer3.material = renderer6.material;
        renderer6.material = renderer5.material;
        renderer5.material = renderer4.material;
        renderer4.material = temp[0];
        temp[0] = renderer12.material;
        temp[1] = renderer11.material;
        renderer12.material = renderer7.material;
        renderer11.material = renderer8.material;
        renderer7.material = renderer1.material;
        renderer8.material = renderer2.material;
        renderer1.material = renderer10.material;
        renderer2.material = renderer9.material;
        renderer10.material = temp[0];
        renderer9.material = temp[1];
        turn_n++;
        turn.text = "돌린 횟수 : " + turn_n;
    }
    public void Right()
    {
        Material[] temp = new Material[2];
        Renderer renderer1 = u[0].GetComponent<Renderer>();
        Renderer renderer2 = u[3].GetComponent<Renderer>();
        Renderer renderer3 = f[0].GetComponent<Renderer>();
        Renderer renderer4 = f[1].GetComponent<Renderer>();
        Renderer renderer5 = f[2].GetComponent<Renderer>();
        Renderer renderer6 = f[3].GetComponent<Renderer>();
        Renderer renderer7 = l[2].GetComponent<Renderer>();
        Renderer renderer8 = l[3].GetComponent<Renderer>();
        Renderer renderer9 = r[2].GetComponent<Renderer>();
        Renderer renderer10 = r[3].GetComponent<Renderer>();
        Renderer renderer11 = d[2].GetComponent<Renderer>();
        Renderer renderer12 = d[3].GetComponent<Renderer>();
        temp[0] = renderer4.material;
        renderer4.material = renderer3.material;
        renderer3.material = renderer6.material;
        renderer6.material = renderer5.material;
        renderer5.material = temp[0];
        temp[0] = renderer2.material;
        temp[1] = renderer1.material;
        renderer2.material = renderer7.material;
        renderer1.material = renderer8.material;
        renderer7.material = renderer12.material;
        renderer8.material = renderer11.material;
        renderer12.material = renderer10.material;
        renderer11.material = renderer9.material;
        renderer10.material = temp[0];
        renderer9.material = temp[1];
        turn_n++;
        turn.text = "돌린 횟수 : " + turn_n;
    }
    public void Right_()
    {
        Right();
        Right();
        Right();
        turn_n -= 2;
        turn.text = "돌린 횟수 : " + turn_n;
    }
    public void Left()
    {
        Material[] temp = new Material[2];
        Renderer renderer1 = u[1].GetComponent<Renderer>();
        Renderer renderer2 = u[2].GetComponent<Renderer>();
        Renderer renderer3 = b[0].GetComponent<Renderer>();
        Renderer renderer4 = b[1].GetComponent<Renderer>();
        Renderer renderer5 = b[2].GetComponent<Renderer>();
        Renderer renderer6 = b[3].GetComponent<Renderer>();
        Renderer renderer7 = l[0].GetComponent<Renderer>();
        Renderer renderer8 = l[1].GetComponent<Renderer>();
        Renderer renderer9 = r[0].GetComponent<Renderer>();
        Renderer renderer10 = r[1].GetComponent<Renderer>();
        Renderer renderer11 = d[0].GetComponent<Renderer>();
        Renderer renderer12 = d[1].GetComponent<Renderer>();
        temp[0] = renderer4.material;
        renderer4.material = renderer3.material;
        renderer3.material = renderer6.material;
        renderer6.material = renderer5.material;
        renderer5.material = temp[0];
        temp[0] = renderer2.material;
        temp[1] = renderer1.material;
        renderer2.material = renderer8.material;
        renderer1.material = renderer7.material;
        renderer7.material = renderer12.material;
        renderer8.material = renderer11.material;
        renderer12.material = renderer10.material;
        renderer11.material = renderer9.material;
        renderer10.material = temp[1];
        renderer9.material = temp[0];
        turn_n++;
        turn.text = "돌린 횟수 : " + turn_n;
    }
    public void Left_()
    {
        Left();
        Left();
        Left();
        turn_n -= 2;
        turn.text = "돌린 횟수 : " + turn_n;
    }
    public void Back()
    {
        Material[] temp = new Material[2];
        Renderer renderer1 = u[2].GetComponent<Renderer>();
        Renderer renderer2 = u[3].GetComponent<Renderer>();
        Renderer renderer3 = r[0].GetComponent<Renderer>();
        Renderer renderer4 = r[1].GetComponent<Renderer>();
        Renderer renderer5 = r[2].GetComponent<Renderer>();
        Renderer renderer6 = r[3].GetComponent<Renderer>();
        Renderer renderer7 = b[2].GetComponent<Renderer>();
        Renderer renderer8 = b[3].GetComponent<Renderer>();
        Renderer renderer9 = f[2].GetComponent<Renderer>();
        Renderer renderer10 = f[3].GetComponent<Renderer>();
        Renderer renderer11 = d[1].GetComponent<Renderer>();
        Renderer renderer12 = d[2].GetComponent<Renderer>();
        temp[0] = renderer3.material;
        renderer3.material = renderer4.material;
        renderer4.material = renderer5.material;
        renderer5.material = renderer6.material;
        renderer6.material = temp[0];
        temp[0] = renderer1.material;
        temp[1] = renderer2.material;
        renderer1.material = renderer9.material;
        renderer2.material = renderer10.material;
        renderer9.material = renderer12.material;
        renderer10.material = renderer11.material;
        renderer12.material = renderer8.material;
        renderer11.material = renderer7.material;
        renderer8.material = temp[0];
        renderer7.material = temp[1];
        turn_n++;
        turn.text = "돌린 횟수 : " + turn_n;
    }
    public void Back_()
    {
        Back();
        Back();
        Back();
        turn_n -= 2;
        turn.text = "돌린 횟수 : " + turn_n;
    }
    public void Front()
    {
        Material[] temp = new Material[2];
        Renderer renderer1 = u[0].GetComponent<Renderer>();
        Renderer renderer2 = u[1].GetComponent<Renderer>();
        Renderer renderer3 = l[0].GetComponent<Renderer>();
        Renderer renderer4 = l[1].GetComponent<Renderer>();
        Renderer renderer5 = l[2].GetComponent<Renderer>();
        Renderer renderer6 = l[3].GetComponent<Renderer>();
        Renderer renderer7 = b[0].GetComponent<Renderer>();
        Renderer renderer8 = b[1].GetComponent<Renderer>();
        Renderer renderer9 = f[0].GetComponent<Renderer>();
        Renderer renderer10 = f[1].GetComponent<Renderer>();
        Renderer renderer11 = d[0].GetComponent<Renderer>();
        Renderer renderer12 = d[3].GetComponent<Renderer>();
        temp[0] = renderer3.material;
        renderer3.material = renderer6.material;
        renderer6.material = renderer5.material;
        renderer5.material = renderer4.material;
        renderer4.material = temp[0];
        temp[0] = renderer1.material;
        temp[1] = renderer2.material;
        renderer1.material = renderer8.material;
        renderer2.material = renderer7.material;
        renderer8.material = renderer11.material;
        renderer7.material = renderer12.material;
        renderer11.material = renderer9.material;
        renderer12.material = renderer10.material;
        renderer9.material = temp[0];
        renderer10.material = temp[1];
        turn_n++;
        turn.text = "돌린 횟수 : " + turn_n;

    }
    public void Front_()
    {
        Front();
        Front();
        Front();
        turn_n -= 2;
        turn.text = "돌린 횟수 : " + turn_n;
    }
    public void Clear()
    {
        if (u[0].GetComponent<Renderer>().material.color.Equals(u[1].GetComponent<Renderer>().material.color) && u[1].GetComponent<Renderer>().material.color.Equals(u[2].GetComponent<Renderer>().material.color) && u[2].GetComponent<Renderer>().material.color.Equals(u[3].GetComponent<Renderer>().material.color))
        {
            if (b[0].GetComponent<Renderer>().material.color.Equals(b[1].GetComponent<Renderer>().material.color) && b[1].GetComponent<Renderer>().material.color.Equals(b[2].GetComponent<Renderer>().material.color) && b[2].GetComponent<Renderer>().material.color.Equals(b[3].GetComponent<Renderer>().material.color))
            {
                if (f[0].GetComponent<Renderer>().material.color.Equals(f[1].GetComponent<Renderer>().material.color) && f[1].GetComponent<Renderer>().material.color.Equals(f[2].GetComponent<Renderer>().material.color) && f[2].GetComponent<Renderer>().material.color.Equals(f[3].GetComponent<Renderer>().material.color))
                {
                    if (r[0].GetComponent<Renderer>().material.color.Equals(r[1].GetComponent<Renderer>().material.color) && r[1].GetComponent<Renderer>().material.color.Equals(r[2].GetComponent<Renderer>().material.color) && r[2].GetComponent<Renderer>().material.color.Equals(r[3].GetComponent<Renderer>().material.color))
                    {
                        if (l[0].GetComponent<Renderer>().material.color.Equals(l[1].GetComponent<Renderer>().material.color) && l[1].GetComponent<Renderer>().material.color.Equals(l[2].GetComponent<Renderer>().material.color) && l[2].GetComponent<Renderer>().material.color.Equals(l[3].GetComponent<Renderer>().material.color))
                        {
                            if (d[0].GetComponent<Renderer>().material.color.Equals(d[1].GetComponent<Renderer>().material.color) && d[1].GetComponent<Renderer>().material.color.Equals(d[2].GetComponent<Renderer>().material.color) && d[2].GetComponent<Renderer>().material.color.Equals(d[3].GetComponent<Renderer>().material.color))
                            {
                                Timer.GetComponent<Timer>().StopStopwatch();
                                time = Timer.GetComponent<Timer>().time;
                                c.SetActive(true);
                                s.SetActive(false);
                                if (difficulty < 4)
                                {
                                    difficulty_s = "easy";
                                }
                                else if (difficulty < 8)
                                {
                                    difficulty_s = "nomal";
                                }
                                else
                                {
                                    difficulty_s = "hard";
                                }
                                string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";

                                int record_n=0;
                                using (OracleConnection connection = new OracleConnection(connectionString))
                                {
                                    try
                                    {
                                        connection.Open();

                                        // 데이터베이스 작업 수행 예시
                                        string query = "SELECT MAX(RECORD_N) AS RECORD_N FROM RECORDTABLE";
                                        using (OracleCommand command = new OracleCommand(query, connection))
                                        {
                                            using (OracleDataReader reader = command.ExecuteReader())
                                            {
                                                if (reader.Read())
                                                {
                                                    record_n = reader.GetInt32(reader.GetOrdinal("RECORD_N"));
                                                    record_n++;
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        UnityEngine.Debug.LogError("Error: " + ex.Message);
                                    }
                                    finally
                                    {
                                        connection.Close();
                                    }
                                }
                                using (OracleConnection connection = new OracleConnection(connectionString))
                                {
                                    
                                    try
                                    {
                                        connection.Open();

                                        // 데이터베이스 작업 수행 예시
                                        string query = "INSERT INTO RECORDTABLE VALUES (:value1, :value2, :value3, :value4, :value5)";

                                        using (OracleCommand cmd = new OracleCommand(query, connection))
                                        {
                                            cmd.Parameters.Add(new OracleParameter("value1", OracleDbType.Int64)).Value = cubeIdValue;
                                            cmd.Parameters.Add(new OracleParameter("value2", OracleDbType.Varchar2)).Value = user_id;
                                            cmd.Parameters.Add(new OracleParameter("value3", OracleDbType.Varchar2)).Value = time.ToString();
                                            cmd.Parameters.Add(new OracleParameter("value4", OracleDbType.Int64)).Value = record_n;
                                            cmd.Parameters.Add(new OracleParameter("value5", OracleDbType.Varchar2)).Value = difficulty_s;
                                            cmd.ExecuteNonQuery();
                                            status.text = "해결 완료";
                                        }
                                    }
                                    catch (OracleException ex)
                                    {
                                        UnityEngine.Debug.Log(ex);
                                    }
                                    finally
                                    {
                                        connection.Close();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


    }
    public void choose()
    {
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";

        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = $"SELECT * FROM CUBETABLE WHERE CUBE_ID={cubeIdValue}";
                for (int i = 0; i < stringArray.Length; i++)
                {
                    stringArray[i] = null;
                }
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            difficulty = reader.GetInt32(reader.GetOrdinal("DIFFICULTY"));
                            string column1Value = reader["CUBE_ID"].ToString();
                            t.text = "큐브번호 : " + column1Value;
                            stringArray[0] = reader["U0"].ToString();
                            stringArray[1] = reader["U1"].ToString();
                            stringArray[2] = reader["U2"].ToString();
                            stringArray[3] = reader["U3"].ToString();
                            stringArray[4] = reader["L0"].ToString();
                            stringArray[5] = reader["L1"].ToString();
                            stringArray[6] = reader["L2"].ToString();
                            stringArray[7] = reader["L3"].ToString();
                            stringArray[8] = reader["R0"].ToString();
                            stringArray[9] = reader["R1"].ToString();
                            stringArray[10] = reader["R2"].ToString();
                            stringArray[11] = reader["R3"].ToString();
                            stringArray[12] = reader["F0"].ToString();
                            stringArray[13] = reader["F1"].ToString();
                            stringArray[14] = reader["F2"].ToString();
                            stringArray[15] = reader["F3"].ToString();
                            stringArray[16] = reader["B0"].ToString();
                            stringArray[17] = reader["B1"].ToString();
                            stringArray[18] = reader["B2"].ToString();
                            stringArray[19] = reader["B3"].ToString();
                            stringArray[20] = reader["D0"].ToString();
                            stringArray[21] = reader["D1"].ToString();
                            stringArray[22] = reader["D2"].ToString();
                            stringArray[23] = reader["D3"].ToString();
                            for (int i = 0; i < 24; i++)
                            {
                                if (i < 4)
                                {
                                    if (string.Equals(stringArray[i], "1"))
                                    {
                                        u[i].GetComponent<Renderer>().material = yellow;
                                    }
                                    else if (string.Equals(stringArray[i], "2"))
                                    {
                                        u[i].GetComponent<Renderer>().material = blue;
                                    }
                                    else if (string.Equals(stringArray[i], "3"))
                                    {
                                        u[i].GetComponent<Renderer>().material = red;
                                    }
                                    else if (string.Equals(stringArray[i], "4"))
                                    {
                                        u[i].GetComponent<Renderer>().material = green;
                                    }
                                    else if (string.Equals(stringArray[i], "5"))
                                    {
                                        u[i].GetComponent<Renderer>().material = orange;
                                    }
                                    else
                                    {
                                        u[i].GetComponent<Renderer>().material = white;
                                    }
                                }
                                else if (i < 8)
                                {
                                    if (string.Equals(stringArray[i], "1"))
                                    {
                                        l[i % 4].GetComponent<Renderer>().material = yellow;
                                    }
                                    else if (string.Equals(stringArray[i], "2"))
                                    {
                                        l[i % 4].GetComponent<Renderer>().material = blue;
                                    }
                                    else if (string.Equals(stringArray[i], "3"))
                                    {
                                        l[i % 4].GetComponent<Renderer>().material = red;
                                    }
                                    else if (string.Equals(stringArray[i], "4"))
                                    {
                                        l[i % 4].GetComponent<Renderer>().material = green;
                                    }
                                    else if (string.Equals(stringArray[i], "5"))
                                    {
                                        l[i % 4].GetComponent<Renderer>().material = orange;
                                    }
                                    else
                                    {
                                        l[i % 4].GetComponent<Renderer>().material = white;
                                    }
                                }
                                else if (i < 12)
                                {
                                    if (string.Equals(stringArray[i], "1"))
                                    {
                                        r[i % 4].GetComponent<Renderer>().material = yellow;
                                    }
                                    else if (string.Equals(stringArray[i], "2"))
                                    {
                                        r[i % 4].GetComponent<Renderer>().material = blue;
                                    }
                                    else if (string.Equals(stringArray[i], "3"))
                                    {
                                        r[i % 4].GetComponent<Renderer>().material = red;
                                    }
                                    else if (string.Equals(stringArray[i], "4"))
                                    {
                                        r[i % 4].GetComponent<Renderer>().material = green;
                                    }
                                    else if (string.Equals(stringArray[i], "5"))
                                    {
                                        r[i % 4].GetComponent<Renderer>().material = orange;
                                    }
                                    else
                                    {
                                        r[i % 4].GetComponent<Renderer>().material = white;
                                    }
                                }
                                else if (i < 16)
                                {
                                    if (string.Equals(stringArray[i], "1"))
                                    {
                                        f[i % 4].GetComponent<Renderer>().material = yellow;
                                    }
                                    else if (string.Equals(stringArray[i], "2"))
                                    {
                                        f[i % 4].GetComponent<Renderer>().material = blue;
                                    }
                                    else if (string.Equals(stringArray[i], "3"))
                                    {
                                        f[i % 4].GetComponent<Renderer>().material = red;
                                    }
                                    else if (string.Equals(stringArray[i], "4"))
                                    {
                                        f[i % 4].GetComponent<Renderer>().material = green;
                                    }
                                    else if (string.Equals(stringArray[i], "5"))
                                    {
                                        f[i % 4].GetComponent<Renderer>().material = orange;
                                    }
                                    else
                                    {
                                        f[i % 4].GetComponent<Renderer>().material = white;
                                    }
                                }
                                else if (i < 20)
                                {
                                    if (string.Equals(stringArray[i], "1"))
                                    {
                                        b[i % 4].GetComponent<Renderer>().material = yellow;
                                    }
                                    else if (string.Equals(stringArray[i], "2"))
                                    {
                                        b[i % 4].GetComponent<Renderer>().material = blue;
                                    }
                                    else if (string.Equals(stringArray[i], "3"))
                                    {
                                        b[i % 4].GetComponent<Renderer>().material = red;
                                    }
                                    else if (string.Equals(stringArray[i], "4"))
                                    {
                                        b[i % 4].GetComponent<Renderer>().material = green;
                                    }
                                    else if (string.Equals(stringArray[i], "5"))
                                    {
                                        b[i % 4].GetComponent<Renderer>().material = orange;
                                    }
                                    else
                                    {
                                        b[i % 4].GetComponent<Renderer>().material = white;
                                    }
                                }
                                else
                                {
                                    if (string.Equals(stringArray[i], "1"))
                                    {
                                        d[i % 4].GetComponent<Renderer>().material = yellow;
                                    }
                                    else if (string.Equals(stringArray[i], "2"))
                                    {
                                        d[i % 4].GetComponent<Renderer>().material = blue;
                                    }
                                    else if (string.Equals(stringArray[i], "3"))
                                    {
                                        d[i % 4].GetComponent<Renderer>().material = red;
                                    }
                                    else if (string.Equals(stringArray[i], "4"))
                                    {
                                        d[i % 4].GetComponent<Renderer>().material = green;
                                    }
                                    else if (string.Equals(stringArray[i], "5"))
                                    {
                                        d[i % 4].GetComponent<Renderer>().material = orange;
                                    }
                                    else
                                    {
                                        d[i % 4].GetComponent<Renderer>().material = white;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
    public void create()
    {
        int[] n = new int[24];
        for (int i = 0; i < 24; i++)
        {
            if (i < 4)
            {
                if (u[i].GetComponent<Renderer>().material.color == yellow.color)
                {
                    n[i] = 1;
                }
                else if (u[i].GetComponent<Renderer>().material.color == blue.color)
                {
                    n[i] = 2;
                }
                else if (u[i].GetComponent<Renderer>().material.color == red.color)
                {
                    n[i] = 3;
                }
                else if (u[i].GetComponent<Renderer>().material.color == green.color)
                {
                    n[i] = 4;
                }
                else if (u[i].GetComponent<Renderer>().material.color == orange.color)
                {
                    n[i] = 5;
                }
                else if (u[i].GetComponent<Renderer>().material.color == white.color)
                {
                    n[i] = 6;
                }
            }

            else if (i < 8)
            {
                if (l[i % 4].GetComponent<Renderer>().material.color == yellow.color)
                {
                    n[i] = 1;
                }
                else if (l[i % 4].GetComponent<Renderer>().material.color == blue.color)
                {
                    n[i] = 2;
                }
                else if (l[i % 4].GetComponent<Renderer>().material.color == red.color)
                {
                    n[i] = 3;
                }
                else if (l[i % 4].GetComponent<Renderer>().material.color == green.color)
                {
                    n[i] = 4;
                }
                else if (l[i % 4].GetComponent<Renderer>().material.color == orange.color)
                {
                    n[i] = 5;
                }
                else if (l[i % 4].GetComponent<Renderer>().material.color == white.color)
                {
                    n[i] = 6;
                }
            }

            else if (i < 12)
            {
                if (r[i % 4].GetComponent<Renderer>().material.color == yellow.color)
                {
                    n[i] = 1;
                }
                else if (r[i % 4].GetComponent<Renderer>().material.color == blue.color)
                {
                    n[i] = 2;
                }
                else if (r[i % 4].GetComponent<Renderer>().material.color == red.color)
                {
                    n[i] = 3;
                }
                else if (r[i % 4].GetComponent<Renderer>().material.color == green.color)
                {
                    n[i] = 4;
                }
                else if (r[i % 4].GetComponent<Renderer>().material.color == orange.color)
                {
                    n[i] = 5;
                }
                else if (r[i % 4].GetComponent<Renderer>().material.color == white.color)
                {
                    n[i] = 6;
                }
            }

            else if (i < 16)
            {
                if (f[i % 4].GetComponent<Renderer>().material.color == yellow.color)
                {
                    n[i] = 1;
                }
                else if (f[i % 4].GetComponent<Renderer>().material.color == blue.color)
                {
                    n[i] = 2;
                }
                else if (f[i % 4].GetComponent<Renderer>().material.color == red.color)
                {
                    n[i] = 3;
                }
                else if (f[i % 4].GetComponent<Renderer>().material.color == green.color)
                {
                    n[i] = 4;
                }
                else if (f[i % 4].GetComponent<Renderer>().material.color == orange.color)
                {
                    n[i] = 5;
                }
                else if (f[i % 4].GetComponent<Renderer>().material.color == white.color)
                {
                    n[i] = 6;
                }
            }

            else if (i < 20)
            {
                if (b[i % 4].GetComponent<Renderer>().material.color == yellow.color)
                {
                    n[i] = 1;
                }
                else if (b[i % 4].GetComponent<Renderer>().material.color == blue.color)
                {
                    n[i] = 2;
                }
                else if (b[i % 4].GetComponent<Renderer>().material.color == red.color)
                {
                    n[i] = 3;
                }
                else if (b[i % 4].GetComponent<Renderer>().material.color == green.color)
                {
                    n[i] = 4;
                }
                else if (b[i % 4].GetComponent<Renderer>().material.color == orange.color)
                {
                    n[i] = 5;
                }
                else if (b[i % 4].GetComponent<Renderer>().material.color == white.color)
                {
                    n[i] = 6;
                }
            }

            else
            {
                if (d[i % 4].GetComponent<Renderer>().material.color == yellow.color)
                {
                    n[i] = 1;
                }
                else if (d[i % 4].GetComponent<Renderer>().material.color == blue.color)
                {
                    n[i] = 2;
                }
                else if (d[i % 4].GetComponent<Renderer>().material.color == red.color)
                {
                    n[i] = 3;
                }
                else if (d[i % 4].GetComponent<Renderer>().material.color == green.color)
                {
                    n[i] = 4;
                }
                else if (d[i % 4].GetComponent<Renderer>().material.color == orange.color)
                {
                    n[i] = 5;
                }
                else if (d[i % 4].GetComponent<Renderer>().material.color == white.color)
                {
                    n[i] = 6;
                }
            }
        }
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";


        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = "SELECT MAX(CUBE_ID) AS MaxCubeId FROM CUBETABLE";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cube_id = reader.GetInt32(reader.GetOrdinal("MaxCubeId"));
                            cube_id++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        using (OracleConnection connection = new OracleConnection(connectionString))
        {

            try
            {
                connection.Open();

                // 데이터베이스 작업 수행 예시
                string query = "INSERT INTO CUBETABLE VALUES (:value1, :value2, :value3, :value4, :value5, :value6, :value7, :value8, :value9, :value10, :value11, :value12, :value13, :value14, :value15, :value16, :value17, :value18, :value19, :value20, :value21, :value22, :value23, :value24, :value25, :value26, :value27)";

                using (OracleCommand cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add(new OracleParameter("value1", OracleDbType.Int64)).Value = cube_id;
                    cmd.Parameters.Add(new OracleParameter("value2", OracleDbType.Int64)).Value = turn_n;
                    cmd.Parameters.Add(new OracleParameter("value3", OracleDbType.Varchar2)).Value = n[0];
                    cmd.Parameters.Add(new OracleParameter("value4", OracleDbType.Varchar2)).Value = n[1];
                    cmd.Parameters.Add(new OracleParameter("value5", OracleDbType.Varchar2)).Value = n[2];
                    cmd.Parameters.Add(new OracleParameter("value6", OracleDbType.Varchar2)).Value = n[3];
                    cmd.Parameters.Add(new OracleParameter("value7", OracleDbType.Varchar2)).Value = n[4];
                    cmd.Parameters.Add(new OracleParameter("value8", OracleDbType.Varchar2)).Value = n[5];
                    cmd.Parameters.Add(new OracleParameter("value9", OracleDbType.Varchar2)).Value = n[6];
                    cmd.Parameters.Add(new OracleParameter("value10", OracleDbType.Varchar2)).Value = n[7];
                    cmd.Parameters.Add(new OracleParameter("value11", OracleDbType.Varchar2)).Value = n[8];
                    cmd.Parameters.Add(new OracleParameter("value12", OracleDbType.Varchar2)).Value = n[9];
                    cmd.Parameters.Add(new OracleParameter("value13", OracleDbType.Varchar2)).Value = n[10];
                    cmd.Parameters.Add(new OracleParameter("value14", OracleDbType.Varchar2)).Value = n[11];
                    cmd.Parameters.Add(new OracleParameter("value15", OracleDbType.Varchar2)).Value = n[12];
                    cmd.Parameters.Add(new OracleParameter("value16", OracleDbType.Varchar2)).Value = n[13];
                    cmd.Parameters.Add(new OracleParameter("value17", OracleDbType.Varchar2)).Value = n[14];
                    cmd.Parameters.Add(new OracleParameter("value18", OracleDbType.Varchar2)).Value = n[15];
                    cmd.Parameters.Add(new OracleParameter("value19", OracleDbType.Varchar2)).Value = n[16];
                    cmd.Parameters.Add(new OracleParameter("value20", OracleDbType.Varchar2)).Value = n[17];
                    cmd.Parameters.Add(new OracleParameter("value21", OracleDbType.Varchar2)).Value = n[18];
                    cmd.Parameters.Add(new OracleParameter("value22", OracleDbType.Varchar2)).Value = n[19];
                    cmd.Parameters.Add(new OracleParameter("value23", OracleDbType.Varchar2)).Value = n[20];
                    cmd.Parameters.Add(new OracleParameter("value24", OracleDbType.Varchar2)).Value = n[21]; 
                    cmd.Parameters.Add(new OracleParameter("value25", OracleDbType.Varchar2)).Value = n[22];
                    cmd.Parameters.Add(new OracleParameter("value26", OracleDbType.Varchar2)).Value = n[23];
                    cmd.Parameters.Add(new OracleParameter("value27", OracleDbType.Varchar2)).Value = user_id;
                    cmd.ExecuteNonQuery();
                    status.text = "출제 성공";
                    
                }
            }
            catch (OracleException ex)
            {
                UnityEngine.Debug.Log(ex);
            }
            finally
            {
                connection.Close();
            }

        }
    }
    public void record1()
    {
        record.text = "최근 기록\n\n\n";
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";


        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();

                // 데이터베이스 작업 수행 예시
                string query = "SELECT * FROM RECORDTABLE";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            column3 = reader["CUBE_NUMBER"].ToString();
                            column1 = reader["USER_ID"].ToString();
                            column2 = reader["TIME"].ToString();
                            column4 = reader["DIFFICULTY"].ToString();
                            record.text += "이름 : " + column1 + "   큐브번호 : " + column3 + "   걸린 시간 : " + column2 + "   난이도 : "+column4+"\n";
                        }
                       
                    }
                }
            }
            catch (Exception)
            {
                record.text = "없음";
            }
            finally
            {
                connection.Close();
            }
        }
    }
    public void My_record1()
    {
        record.text = "내 최근 기록\n\n\n";
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";


        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();

                // 데이터베이스 작업 수행 예시
                string query = $"SELECT * FROM RECORDTABLE WHERE USER_ID = '{user_id}'";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            column3 = reader["CUBE_NUMBER"].ToString();
                            column1 = reader["USER_ID"].ToString();
                            column2 = reader["TIME"].ToString();
                            column4 = reader["DIFFICULTY"].ToString();
                            record.text += "이름 : " + column1 + "   큐브번호 : " + column3 + "   걸린 시간 : " + column2 + "   난이도 : " + column4 + "\n";
                        }

                    }
                }
            }
            catch (Exception)
            {
                record.text = "없음";
            }
            finally
            {
                connection.Close();
            }
        }
    }
    public void Easy_record1()
    {
        record.text = "easy 최근 기록\n\n\n";
        string easy = "easy";
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";


        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();

                // 데이터베이스 작업 수행 예시
                string query = $"SELECT * FROM RECORDTABLE WHERE DIFFICULTY = '{easy}'";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            column3 = reader["CUBE_NUMBER"].ToString();
                            column1 = reader["USER_ID"].ToString();
                            column2 = reader["TIME"].ToString();
                            column4 = reader["DIFFICULTY"].ToString();
                            record.text += "이름 : " + column1 + "   큐브번호 : " + column3 + "   걸린 시간 : " + column2 + "   난이도 : " + column4 + "\n";
                        }

                    }
                }
            }
            catch (Exception)
            {
                record.text = "없음";
            }
            finally
            {
                connection.Close();
            }
        }
    }
    public void Nomal_record1()
    {
        record.text = "nomal 최근 기록\n\n\n";
        string nomal = "nomal";
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";


        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();

                // 데이터베이스 작업 수행 예시
                string query = $"SELECT * FROM RECORDTABLE WHERE DIFFICULTY ='{nomal}'";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            column3 = reader["CUBE_NUMBER"].ToString();
                            column1 = reader["USER_ID"].ToString();
                            column2 = reader["TIME"].ToString();
                            column4 = reader["DIFFICULTY"].ToString();
                            record.text += "이름 : " + column1 + "   큐브번호 : " + column3 + "   걸린 시간 : " + column2 + "   난이도 : " + column4 + "\n";
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                record.text = "없음";
            }
            finally
            {
                connection.Close();
            }
        }
    }
    public void Hard_record1()
    {
        record.text = "hard 최근 기록\n\n\n";
        string hard = "hard";
        string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.68.27.35)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl))); User Id = cubeadmin; Password = 1234;";


        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();

                // 데이터베이스 작업 수행 예시
                string query = $"SELECT * FROM RECORDTABLE WHERE DIFFICULTY = '{hard}'";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            column3 = reader["CUBE_NUMBER"].ToString();
                            column1 = reader["USER_ID"].ToString();
                            column2 = reader["TIME"].ToString();
                            column4 = reader["DIFFICULTY"].ToString();
                            record.text += "이름 : " + column1 + "   큐브번호 : " + column3 + "   걸린 시간 : " + column2 + "   난이도 : " + column4 + "\n";
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                record.text = "없음";
            }
            finally
            {
                connection.Close();
            }
        }
    }
}