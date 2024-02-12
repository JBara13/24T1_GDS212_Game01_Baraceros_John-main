using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TMP_Text resultText;
    public string firstAnswer;

    public void ValidateInput()
    {
        firstAnswer = inputField.text;

        if (firstAnswer == "14")
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
