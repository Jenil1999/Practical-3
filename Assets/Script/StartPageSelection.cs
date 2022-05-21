using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPageSelection : MonoBehaviour
{
    public List<Toggle> EmployeeTypes;
    List<Employee> selectedEmployees = new List<Employee>();
    List<SceneLoader> emp_name_obj = new List<SceneLoader>();

    Employee.EmployeeType SelectedEmployeeType;

    public DataLoader dataloader;
    public SceneLoader empPrefab;
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
        for (int i=0; i < count; i++)
        {
            SceneLoader empmodel = Instantiate(empPrefab, Deta);
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
            }
        }
    }

    void ThisEmployee(Employee.EmployeeType type)
    {
        selectedEmployees = dataloader.Employees.FindAll(x => x.currentPos == type);
        AllEmployeeList();
    }

    public void AllEmployeeList()
    {
        if(selectedEmployees.Count > emp_name_obj.Count)
        {
            CreateNewEmpObj(selectedEmployees.Count - emp_name_obj.Count);
        }

        int i = 0;
        foreach(SceneLoader emp in emp_name_obj)
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
}
