using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TMP_Text resultText;

    public void ValidateInput()
    {
        string input = inputField.text;

        if (input.Length > 1)
        {
            resultText.text = "Valid Input";
            resultText.color = Color.green;
        }
        else
        {
            resultText.text = "Invalid Input";
            resultText.color = Color.red;
        }
    }
}
