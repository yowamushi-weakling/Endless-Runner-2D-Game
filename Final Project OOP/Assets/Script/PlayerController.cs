using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Vector2 targetMove;
    public float Yincrement;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;

    public GameObject effect;
    public Text healthDisplay;

    private void Update()
    {
        healthDisplay.text = health.ToString();

        if (health == 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }

        transform.position = Vector2.MoveTowards(transform.position, targetMove, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetMove = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetMove = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }

    }
}
