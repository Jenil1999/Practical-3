using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public static ScreenManager Instance;
    public GameObject HomePage;
    public GameObject AddData;
    public GameObject DisplayData;

    private void Awake()
    {
        Instance = this;
    }

   
}
