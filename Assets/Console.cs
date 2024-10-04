using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Console : MonoBehaviour
{
    [SerializeField]
    public Text ConsoleText;
    public TMP_InputField inputfield;
    public Material ren;
    public Image menu;
    public bool show = true;

    void update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("c is now pressed");
            show = !show;
            menu.enabled = show;
        }
    }

    public Color ToColor(string color)
    {
        return ((Color)typeof(Color).GetProperty(color.ToLowerInvariant()).GetValue(null, null));
    }

    public void consoleCommand()
    {
        ConsoleText.text = inputfield.text;
        string placehold;
        placehold = ConsoleText.text;
        string lower = placehold.ToLower();
        try
        {
            ren.color = ToColor(lower);
        }
        catch
        {
            ConsoleText.text = "this is not a color";
            if ("exit" == lower)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
        

    }
}
