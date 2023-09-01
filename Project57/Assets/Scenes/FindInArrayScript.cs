using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindInArrayScript : MonoBehaviour
{
    public Text result;
    public InputField FirstInputField;
    int[] myArray = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
    int value;
    public int FirstOccurrence(int[] array, int value)
    {
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] == value)
            {
                return i;
            }
        }
        return -1;
    }
    
    public void OnFirstOccurrence()
    {
           
            int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
            int value = int.Parse(FirstInputField.text);
            int want = 3;
            int got = FirstOccurrence(array, value);
            string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
            result.text = got.ToString($"Индекс первого вхождения числа {value} в массив: {got} - {message}");

    }
}