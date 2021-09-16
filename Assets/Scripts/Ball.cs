using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rib;
    public static Vector2 startPos;
    [SerializeField] float speedX = 1f;
    [SerializeField] float speedY = 1f;

    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        rib = GetComponent<Rigidbody2D>();
        rib.velocity = new Vector2(speedX, speedY);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void ResetBall()
    {
        gameObject.transform.position = startPos;
    }
}
