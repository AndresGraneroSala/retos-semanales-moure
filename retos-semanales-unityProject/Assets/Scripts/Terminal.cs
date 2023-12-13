using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Terminal : MonoBehaviour
{
    /*[SerializeField]*/ private List<string> _historic;
    [SerializeField] private InputField input;
    [SerializeField] private int positionInHistoric=0;

    public List<string> commands;
    [SerializeField] private string originalText;
    
    private void Start()
    {
        _historic = new List<string>();
        GoBackEdit();
    }

    public void AddHistoric()
    {
        if (string.IsNullOrEmpty( input.text)) {return;}
        if (string.IsNullOrWhiteSpace( input.text)) {return;}       
        
        positionInHistoric = 0;
        _historic.Add(input.text); 
    }

    public void Update()
    {
        ChangeInputWithHistoric();
    }

    void ChangeInputWithHistoric()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)&& _historic.Count != positionInHistoric)
        {
            input.text = _historic[_historic.Count-1-positionInHistoric];
            positionInHistoric++;
        }  
        
        if (Input.GetKeyDown(KeyCode.DownArrow)&& positionInHistoric>1)
        {
            //print(_historic.Count+1-positionInHistoric);
            input.text = _historic[_historic.Count+1-positionInHistoric];
            positionInHistoric--;
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            bool isTextACommand=false;
            
            foreach (var command in commands)
            {
                if (command==input.text)
                {
                    isTextACommand = true;
                }
            }

            if (!isTextACommand)
            {
                originalText = input.text;
            }
            
            foreach (var command in commands)
            {
                if (command == input.text)
                {
                    continue;
                }
                
                if (command.ToLower().Contains(originalText.ToLower()))
                {
                    input.text = command;
                    input.caretPosition = command.Length;
                    break;
                }
            }
        }
        
        
    }
    
    public void GoBackEdit()
    {
        input.ActivateInputField();
    }
    
}
