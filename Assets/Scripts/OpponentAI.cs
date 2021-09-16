using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentAI : MonoBehaviour
{
    private Ball ball;
    [SerializeField] float mSpeed = 1.5f;
    public float stop = 3.1f;
    private Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ballPos = ball.transform.position;
        Vector2 opponentPos = this.transform.position;

        if (opponentPos.y > ballPos.y)
        {
            opponentPos.y -= mSpeed;
        }
        else if (opponentPos.y < ballPos.y)
        {
            opponentPos.y += mSpeed;
        }

        if (opponentPos.y > stop)
        {
            opponentPos.y = stop;
        }
        else if (opponentPos.y < -stop)
        {
            opponentPos.y = -stop;
        }
        transform.position = opponentPos;
    }
}
