
/*
Name: Nina Valdez
Student ID#: 2324247
Chapman email: divaldez@chapman.edu
Course Number and Section: 236-03
Project: 2 - Little Button of Death
This assignment was done as part of class on 2/24/21 
*/

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;


public class GameManagerScript : MonoBehaviour
{
    // Load the file of student names
    // on Button click in UI, randomly pick student name
    // Assign to test object in GUI the chosen student name


    public string fileName = "default.txt";
    public Text displayName;
    private string[] studentNames;


    // Start is called before the first frame update
    void Start()
    {
        LoadStudentNames();
        ButtonClick();
    }


    private void LoadStudentNames()
    {
        this.studentNames = File.ReadAllLines(fileName);
    }


    public void ButtonClick()
    {
        int i = UnityEngine.Random.Range(0, this.studentNames.Length); 
        string name = this.studentNames[i];
        displayName.text = name;
    }
}
