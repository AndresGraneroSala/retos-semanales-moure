using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerInput : MonoBehaviour
{
    [SerializeField] private InputField input;
    private const  int numA32bit= 97;
    private const  int numÑAlphabet= 15;
    private const int totalLettersInAlphabet=27;
    
    //private char [] letters=
    public void SubmitWord()
    {

        string word = input.text;

        char[] letters = word.ToCharArray();

        int points=0;

        foreach (var letter in letters)
        {
            if (char.ToLower(letter) == 'ñ')
            {
                points += numÑAlphabet;
                print("ñ");
                continue;
            }

            int letterPos32bit = Convert.ToInt32(char.ToLower(letter));

            bool isUpperÑ = false;

            if (letterPos32bit >= numA32bit + numÑAlphabet - 1)
            {
                isUpperÑ = true;
                print("ñ " + letter);
            }



            points += char.ToLower(letter) - (numA32bit - 1);
            points += isUpperÑ ? 1 : 0;
        }

        print(points);
        input.text = "";
        
        
        
    }

    public void GoBackEdit()
    {
        input.ActivateInputField();
    }
}
