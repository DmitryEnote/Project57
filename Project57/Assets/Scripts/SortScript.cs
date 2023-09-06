using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SortScript : MonoBehaviour
{
    public Text result;
    public void SortArray()
    {
        int[] myArray = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        Array.Sort(myArray);
        string sortedArray = "  ";

        foreach (int i in myArray)
        {
            sortedArray += i;
        }
        
        result.text = ($"Массив отсортирован :   {sortedArray,4}");
    }
}  
    

