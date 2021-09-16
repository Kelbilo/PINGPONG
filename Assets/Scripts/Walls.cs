using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            string wallName = this.transform.name;
            GameHandler.Score(wallName);
            collision.gameObject.SendMessage("ResetBall", 1, SendMessageOptions.RequireReceiver);
        }
    }
}
