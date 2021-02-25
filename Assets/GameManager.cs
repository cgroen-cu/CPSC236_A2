using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Load file of student names
    //On button click in ui - randomly pick name
    //Assign to tesxt object in GUI the name

    public string fileName = "default.txt";
    public Text displayName;

    private string[] studentNames;

    //Start is called before frame update
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
        int i = UnityEngine.Random.Range(0, this.studentNames.Length); //25 = 0-24
        string name = studentNames[i];
        displayName.text= name;
    }
}