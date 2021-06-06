using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleArrays : MonoBehaviour
{
    //array 1 string , array 2 float, array 3 int 

    string[] array1 = new string[4];
    float[] array2 = new float[] { 1.1f, 1.2f, 1.3f, 1.4f };
    int[] array3 = { 1, 2, 3, 4 };


    private void Start()
    {
        PrintArrayContents(array3);
        DisplayArrayLength(array3);
        ChangeValuesDirectly(array3);
        ChangeImageColors(); 
    }

    //1) Durchlaufen ausgeben der Werte
    void PrintArrayContents(int[] intArray)
    {
        string tmp = "";
        for (int i = 0; i < intArray.Length; i++)
        {
            tmp += intArray[i].ToString() + " ";
        }
        print(tmp);
    }
    //2) Länge des Arrays ausgeben als Debug 
    void DisplayArrayLength(int[] intArray)
    {
        print(intArray.Length.ToString());
    }
    //3) 2 Werte direkt ändern 
    void ChangeValuesDirectly(int[] intArray)
    {
        intArray[1] = 2;
        intArray[2] = 3;
    }

    //4) Objets Images anlegen, Tag vergeben, Zuweisen und Farbe Ändern 
    void ChangeImageColors()
    {
        GameObject[] images = GameObject.FindGameObjectsWithTag("RedImage");
        images[2].GetComponent<Image>().color = Color.red; 
    }
}   
