using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmpModel : MonoBehaviour
{
    

    public  Employee employee;
    public Text nametext;
    public DataLoader dataLoader;

    
    public void SetData(Employee empl)
    {
        Debug.Log("SetData : " + empl.EmployeeName);
        employee = empl;
        nametext.text = employee.EmployeeName;
    }

    public void DataList()
    {
        ScreenManager.Instance.DisplayData.SetActive(true);
        DisplayData.Instance.SetDetails(employee);
        ScreenManager.Instance.HomePage.SetActive(false); ;
        ScreenManager.Instance.AddData.SetActive(false);
      
    }

   
      

    

    
}
