using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    [SerializeField]
    public Text ConsoleText;
    public TMP_InputField inputfield;
    public Camera CamColor;
    public TMP_Text inputText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("c"))
        //{

        //}

    }


    public void consoleCommand()
    {
        //ConsoleText.text = inputfield.text;

        try
        {
            CamColor.backgroundColor = inputfield.text;
        }
        catch
        {
            ConsoleText.text("this is not a color");
        }
        
        
    }
}
