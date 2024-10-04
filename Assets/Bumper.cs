using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public bool isPlayer1;
    public bool isBot;
    public float speed = 5f;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
            transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime *2, 0f);
        else
            transform.Translate(0f, Input.GetAxis("Vertical2") * speed * Time.deltaTime*2, 0f);

        if (isBot)
        {
            transform.Translate(0f, target.transform.position.y/4 * speed * Time.deltaTime, 0f);
        }

    }
}
