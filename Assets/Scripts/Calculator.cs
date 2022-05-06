using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public TMP_Text resultText;
    
    public TMP_InputField firstInputField;
    public TMP_InputField secondInputField;

    private float _firstNumber = 0f;
    private float _secondNumber = 0f;

    public void ReadText()
    {
        _firstNumber = Convert.ToInt32(firstInputField.text);
        _secondNumber = Convert.ToInt32(secondInputField.text);
    }
    
    public void Addition()
    {
        resultText.text = (_firstNumber + _secondNumber).ToString();
    }

    public void Subtraction()
    {
        resultText.text = (_firstNumber - _secondNumber).ToString();
    }

    public void Multiplication()
    {
        resultText.text = (_firstNumber * _secondNumber).ToString();
    }

    public void Division()
    {
        resultText.text = (_firstNumber / _secondNumber).ToString();
    }
}
