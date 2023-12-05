using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    public int numbers;
    public GameObject admin;
    public void Set_Number()
    {
        admin.GetComponent<Control>().cubeIdValue = numbers;
    }
}
