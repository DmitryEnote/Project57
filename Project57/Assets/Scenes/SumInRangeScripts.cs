using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scripts : MonoBehaviour
{
    public InputField FirstInputField;
    public InputField SecondInputField;
    public Text result;

    public void OnSumEvenNumbersInRange()
    {
        int count = 0;
        int a,b;
        a = int.Parse(FirstInputField.text);
        b = int.Parse(SecondInputField.text);
        while (a <= b)
        {
            if ( a % 2 == 0)
            {   
                count = count + a;
            }
           
            a++;
        }
        result.text = count.ToString();

    }

}
