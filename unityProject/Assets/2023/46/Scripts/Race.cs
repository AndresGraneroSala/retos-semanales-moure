using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Race : MonoBehaviour
{
    [SerializeField] private InputField input;

    public void SubmitBet()
    {
        string bet = input.text;
        
    }
}
