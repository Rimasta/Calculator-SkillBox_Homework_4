using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TwoNumbersComparer : MonoBehaviour
{
    public TMP_Text resultText;
    
    public TMP_InputField firstInputField;
    public TMP_InputField secondInputField;

    private int _firstNumber = 0;
    private int _secondNumber = 0;

    public void ReadText()
    {
        _firstNumber = Convert.ToInt32(firstInputField.text);
        _secondNumber = Convert.ToInt32(secondInputField.text);
    }

    public void Comparer()
    {
        if (_firstNumber > _secondNumber)
        {
            resultText.text = _firstNumber.ToString();
        } 
        else if (_firstNumber < _secondNumber)
        {
            resultText.text = _secondNumber.ToString();
        }
        else
        {
            resultText.text = "Числа равны";
        }
    }
}
