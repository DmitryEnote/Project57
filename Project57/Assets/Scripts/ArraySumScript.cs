using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArraySumScript : MonoBehaviour
{
    public Text result;


    public void OnSumEvenNumbersInArray() //(string[] args)
    {
        int count = 0 ;
        int[] myArray = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        for(int i=0; i<myArray.Length; i++ )
        {
            if (myArray[i] % 2 == 0)
            {
                count = count + myArray[i];
                
            }
        }

        result.text = count.ToString();
    }
}   

