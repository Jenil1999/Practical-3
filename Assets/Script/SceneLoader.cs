using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{


    public Employee emp;
    public Text nametext;
    public void SetData(Employee empl)
    {
        emp = empl;
        nametext.text = emp.EmployeeName;
    }
    public void StartPage()
    {
        ScreenManager.Instance.HomePage.SetActive(true);
        ScreenManager.Instance.AddData.SetActive(false);
        ScreenManager.Instance.DisplayData.SetActive(false);

    }
    public void OnClickAddDetails()
    {
        ScreenManager.Instance.HomePage.SetActive(false);
        ScreenManager.Instance.AddData.SetActive(true);
        ScreenManager.Instance.DisplayData.SetActive(false);
    }

    public void DataList()
    {
        ScreenManager.Instance.HomePage.SetActive(false);
        DisplayData.Instance.SetDetails(emp);
        ScreenManager.Instance.AddData.SetActive(false);
        ScreenManager.Instance.DisplayData.SetActive(true);
    }
}
