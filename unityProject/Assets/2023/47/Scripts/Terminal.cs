using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Terminal : MonoBehaviour
{
    /*[SerializeField]*/ private List<string> historic;
    [SerializeField] private InputField input;
    [SerializeField] private int positionInHistoric=0;

    private void Start()
    {
        historic = new List<string>();
    }

    public void AddHistoric()
    {
        positionInHistoric = 0;
        historic.Add(input.text); 
    }

    public void Update()
    {
        ChangeInputWithHistoric();
    }

    void ChangeInputWithHistoric()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)&& historic.Count != positionInHistoric)
        {
            input.text = historic[historic.Count-1-positionInHistoric];
            positionInHistoric++;
        }  
        
        if (Input.GetKeyDown(KeyCode.DownArrow)&& positionInHistoric>1)
        {
            print(historic.Count+1-positionInHistoric);
            input.text = historic[historic.Count+1-positionInHistoric];
            positionInHistoric--;
        }
        
    }
    
}
