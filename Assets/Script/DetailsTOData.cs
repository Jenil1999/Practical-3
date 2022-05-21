
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using System.Linq;
using TMPro;
using System.Collections.Generic;

public class DetailsTOData : MonoBehaviour
{
    
    public TMP_Dropdown Designation_Select;
    public TMP_InputField Emp_Name;
    public TMP_InputField Ph_No;
    public TMP_InputField Email_Text;
    public TMP_InputField Password_Text;
    public TMP_InputField Address_Text;
   

     public DataLoader dataLoader;
    public void OnSubmit()
    {
        if (DataNotEmpty())
        {
            Employee currentEmployee = new Employee();
            currentEmployee.EmployeeName = Emp_Name.text;
            currentEmployee.PhoneNumber = long.Parse(Ph_No.text);
            currentEmployee.Email = Email_Text.text;
            currentEmployee.Password = Password_Text.text;
            currentEmployee.Address = Address_Text.text;
            currentEmployee.currentPos = (Employee.EmployeeType)Designation_Select.value;

            dataLoader.Employees.Add(currentEmployee);

            ResetUI();

        }

    }
    bool DataNotEmpty()
    {
        if (Emp_Name.text == "")
        {
            Debug.Log("Enter Name");
            return false;
        }

        if (Emp_Name.text == "")
        {
            Debug.Log("Enter Name");
            return false;
        }

        if (Ph_No.text == "")
        {
            Debug.Log("Enter Number");
            return false;
        }

        if (Email_Text.text == "")
        {
            Debug.Log("Enter Email");
            return false;
        }

        bool isEmail = Regex.IsMatch(Email_Text.text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        if (isEmail == false)
        {
            Debug.Log("please enter valid Email address");
            return false;
        }

        if (Password_Text.text == "")
        {
            Debug.Log("Enter Password");
            return false;
        }

        if (Address_Text.text == "")
        {
            Debug.Log("Enter Address");
            return false;
        }
        return true;
    }
        
   public void ResetUI()
    {
        Emp_Name.text = "";
        Address_Text.text = "";
        Ph_No.text = "";
        Email_Text.text = "";
        
    }
 
}
