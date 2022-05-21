using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayData : MonoBehaviour
{

    public static DisplayData Instance;

    public TMP_Text NameOutField;
    public TMP_Text ContactOutField;
    public TMP_Text EmailOutField;
    public TMP_Text DesignationOutField;
    public TMP_Text AddressOutField;

    public DataLoader dataLoader;

    private void Awake()
    {
        Instance = this;
    }

 
    public void SetDetails(Employee employee)
    {
        NameOutField.text = employee.EmployeeName;
        ContactOutField.text = employee.PhoneNumber.ToString();
        EmailOutField.text = employee.Email;
        DesignationOutField.text = employee.currentPos.ToString();
        AddressOutField.text = employee.Address;
    }
}
