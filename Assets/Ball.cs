using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f;

    [SerializeField]
    private int playerOneScore;
    [SerializeField]
    private int playerTwoScore;

    public Vector3 spawnPoint;

    public TextMeshProUGUI playerOneText;
    public TextMeshProUGUI playerTwoText;
    // Start is called before the first frame update
    void Start()
    {
        playerOneScore = 0;
        playerTwoScore = 0;

        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        playerOneText.text = playerOneScore.ToString();
        playerTwoText.text = playerTwoScore.ToString();
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "WestWall")
        {
            playerTwoScore++;
            transform.position = spawnPoint;
        }
        if (col.gameObject.name == "EastWall")
        {
            playerOneScore++;
            transform.position = spawnPoint;
        }
    }
}
