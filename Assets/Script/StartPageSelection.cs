using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPageSelection : MonoBehaviour
{
    public List<Toggle> EmployeeTypes;
    List<Employee> selectedEmployees = new List<Employee>();
    List<EmpModel> emp_name_obj = new List<EmpModel>();

    Employee.EmployeeType SelectedEmployeeType;

    public DataLoader dataloader;
    public EmpModel empPrefab;
    public Transform Deta;


    private void Start()
    {
        foreach (Toggle toggle in EmployeeTypes)
        {
            toggle.onValueChanged.AddListener( OnValueChanged);
        }
        CreateNewEmpObj(10);
        EmployeeTypes[0].isOn = true;
    }

    void CreateNewEmpObj(int count)
    {
        Debug.Log("CreateNewEmpObj");
        for (int i=0; i < count; i++)
        {
            EmpModel empmodel = Instantiate(empPrefab, Deta);
            emp_name_obj.Add(empmodel);
        }
    }

    public void OnValueChanged(bool value)
    {
        for(int i = 0; i < EmployeeTypes.Count; i++)
        {
            if(EmployeeTypes[i].isOn)
            {
                SelectedEmployeeType = (Employee.EmployeeType)i;
                ThisEmployee(SelectedEmployeeType);
                Debug.Log(SelectedEmployeeType);
                break;
            }
        }
    }

    void ThisEmployee(Employee.EmployeeType type)
    {
        selectedEmployees = dataloader.Employees.FindAll(x => x.employeeType == type);
        AllEmployeeList();
    }

    public void AllEmployeeList()
    {
        if(selectedEmployees.Count > emp_name_obj.Count)
        {
            CreateNewEmpObj(selectedEmployees.Count - emp_name_obj.Count);
        }

        int i = 0;
        foreach(EmpModel emp in emp_name_obj)
        {
            if (i > selectedEmployees.Count - 1)
            {
                emp.gameObject.SetActive(false);
            }
            else
            {
                emp.gameObject.SetActive(true);
                emp.SetData(selectedEmployees[i]);
            }
            i++;
        }
            
    }

    public void OnAddClick()
    {
        ScreenManager.Instance.HomePage.SetActive(false);
        ScreenManager.Instance.AddData.SetActive(true);
        ScreenManager.Instance.DisplayData.SetActive(false);
    }
    
}
