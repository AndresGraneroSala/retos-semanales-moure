using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerInput : MonoBehaviour
{
    [SerializeField] private InputField input;
    //private char [] letters=
    public void SubmitWord()
    {
        print(input.text);

        string word = input.text;
        
        input.text = "";
        
        
        
    }

    public void GoBackEdit()
    {
        input.ActivateInputField();
    }
}
