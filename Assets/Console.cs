using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    [SerializeField]
    public Text ConsoleText;
    public InputField inputfield;
    public GameObject background;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("c"))
        {

        }

    }


    public void consoleCommand(string input)
    {
        ConsoleText.text = input;
    }
}
