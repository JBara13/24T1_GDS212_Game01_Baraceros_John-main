using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TMP_Text resultText;

    //Subject Answer Strings
    // MATH
    public string firstMathAnswer;
    public string secondMathAnswer;
    //HISTORY
    public string firstHistoryAnswer;
    public string secondHistoryAnswer;
    //SCIENCE
    public string firstScienceAnswer;
    public string secondScienceAnswer;
    //ENGLISH
    public string firstEnglishAnswer;
    public string secondEnglishAnswer;
    //MUSIC
    public string firstMusicAnswer;
    public string secondMusicAnswer;
    //GEOGRAPHY
    public string firstGeographyAnswer;
    public string secondGeographyAnswer;

    //Subject Books
    public GameObject mathBook;
    public GameObject historyBook;
    public GameObject scienceBook;
    public GameObject englishBook;
    public GameObject musicBook;
    public GameObject geographyBook;


    public TMP_Text checklistText;

    //MATHEMATICS

    public void ValidateFirstMathInput()
    {
        firstMathAnswer = inputField.text;
        

        if (firstMathAnswer == "14")
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

    public void ValidateSecondMathInput()
    {
        secondMathAnswer = inputField.text;
   
        if (secondMathAnswer == "144")
        {
            resultText.text = "Valid Input";
            resultText.color = Color.green;
            mathBook.SetActive(false);
            checklistText.text = "1/6 Subjects Passed";
        }
        else
        {
            resultText.text = "Invalid Input";
            resultText.color = Color.red;
        }
    }

    //HISTORY

    public void ValidateFirstHistoryInput()
    {
        firstHistoryAnswer = inputField.text;


        if (firstHistoryAnswer == "1914")
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

    public void ValidateSecondHistoryInput()
    {
        secondHistoryAnswer = inputField.text;

        if (secondHistoryAnswer == "Zeus")
        {
            resultText.text = "Valid Input";
            resultText.color = Color.green;
            historyBook.SetActive(false);
            checklistText.text = "2/6 Subjects Passed";
        }
        else
        {
            resultText.text = "Invalid Input";
            resultText.color = Color.red;
        }
    }

    //SCIENCE
    public void ValidateFirstScienceInput()
    {
        firstScienceAnswer = inputField.text;


        if (firstScienceAnswer == "Oxygen")
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

    public void ValidateSecondScienceInput()
    {
        secondScienceAnswer = inputField.text;

        if (secondScienceAnswer == "Lithium")
        {
            resultText.text = "Valid Input";
            resultText.color = Color.green;
            scienceBook.SetActive(false);
            checklistText.text = "3/6 Subjects Passed";
        }
        else
        {
            resultText.text = "Invalid Input";
            resultText.color = Color.red;
        }
    }
    //ENGLISH
    public void ValidateFirstEnglishInput()
    {
        firstEnglishAnswer = inputField.text;


        if (firstEnglishAnswer == "Shakespeare")
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

    public void ValidateSecondEnglishInput()
    {
        secondEnglishAnswer = inputField.text;

        if (secondEnglishAnswer == "The Call of Cthulhu")
        {
            resultText.text = "Valid Input";
            resultText.color = Color.green;
            englishBook.SetActive(false);
            checklistText.text = "4/6 Subjects Passed";
        }
        else
        {
            resultText.text = "Invalid Input";
            resultText.color = Color.red;
        }
    }
    //MUSIC
    public void ValidateFirstMusicInput()
    {
        firstMusicAnswer = inputField.text;


        if (firstMusicAnswer == "6")
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

    public void ValidateSecondMusicInput()
    {
        secondMusicAnswer = inputField.text;

        if (secondMusicAnswer == "Cymbals")
        {
            resultText.text = "Valid Input";
            resultText.color = Color.green;
            musicBook.SetActive(false);
            checklistText.text = "5/6 Subjects Passed";
        }
        else
        {
            resultText.text = "Invalid Input";
            resultText.color = Color.red;
        }
    }
    //GEOGRAPHY
    public void ValidateFirstGeographyInput()
    {
        firstGeographyAnswer = inputField.text;


        if (firstGeographyAnswer == "Brazil")
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

    public void ValidateSecondGeographyInput()
    {
        secondGeographyAnswer = inputField.text;

        if (secondGeographyAnswer == "Ghana")
        {
            resultText.text = "Valid Input";
            resultText.color = Color.green;
            geographyBook.SetActive(false);
            checklistText.text = "6/6 Subjects Passed";
        }
        else
        {
            resultText.text = "Invalid Input";
            resultText.color = Color.red;
        }
    }
}
