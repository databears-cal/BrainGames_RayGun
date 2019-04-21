using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionPopUp : MonoBehaviour
{
    public Text help;
    public Text instructionText;

    public string help_msg;
    public string instruction_msg;

    // Start is called before the first frame update
    void Start()
    {
        help = GameObject.Find("HelpText").GetComponent<Text>();
        instructionText = GameObject.Find("InstructionText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnVREnter()
    {
        help.text = help_msg;
        instructionText.text = instruction_msg;
    }

    void OnVRExit()
    {
        help.text = "";
        instructionText.text = "";

    }
}
