using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "EmployeeList" , menuName = "Employee")]
public class DataLoader : ScriptableObject
{
    public List<Employee> Employees = new List<Employee>();
}

[System.Serializable]
public class Employee
{
    public enum EmployeeType
    {
        Trainee,
        Junior,
        Senior,
    }


    public EmployeeType currentPos;

    public string EmployeeName;

    public long PhoneNumber;

    public string Email;

    public string Password;

    public string Address;
}
    

