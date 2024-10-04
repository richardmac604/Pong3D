using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f;

    [SerializeField]
    private int playerOneScore;
    [SerializeField]
    private int playerTwoScore;

    public Vector3 spawnPoint;
    public bool isWinner;

    public TextMeshProUGUI playerOneText;
    public TextMeshProUGUI playerTwoText;
    public TextMeshProUGUI playerTextWinner;
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

        if (playerOneScore > 4)
        {
            playerTextWinner.SetText("Player One Wins");
            StartCoroutine(Delay());
            
        }
        if (playerTwoScore > 4)
        {
            playerTextWinner.SetText("Player Two Wins");
            StartCoroutine(Delay());
          
        }

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

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
