using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayData : MonoBehaviour
{


    DataLoader detaloader;
    public Text NameOutField;
    public Text ContactOutField;
    public Text EmailOutField;
    public Text DesignationOutField;
    public Text AddressOutField;
    public Employee employee;
    
    public static DisplayData Instance;

    private void Awake()
    {
        Instance = this;
    }


    public void SetDetails(Employee empl)
    {

        employee = empl;
        NameOutField.text = employee.EmployeeName;
        Debug.Log(employee.EmployeeName);
        ContactOutField.text = empl.PhoneNumber.ToString();
        EmailOutField.text = empl.Email;
        DesignationOutField.text = empl.employeeType.ToString();
        AddressOutField.text = empl.Address;
    }

    public void CloseButton()
    {
        ScreenManager.Instance.DisplayData.SetActive(false);
        ScreenManager.Instance.AddData.SetActive(false);
        ScreenManager.Instance.HomePage.SetActive(true);
    }
}
