using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerSlime : MonoBehaviour
{
    public GameObject player;
    public float Distance;
    public float SpeedEnemy;
    private Vector2 posEnemy;
    public Transform posPlayer;
    private Rigidbody2D rb;
    void Start()
    {
        posPlayer = player.GetComponent<Transform>();
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, posPlayer.position) < Distance)
        {
            gameObject.GetComponent<IA_Movimiento>().enabled = false;
            transform.position = Vector2.MoveTowards(transform.position, posPlayer.position, SpeedEnemy * Time.deltaTime);
        }
        else
        {
            gameObject.GetComponent<IA_Movimiento>().enabled = true;
            if (Vector2.Distance(transform.position, posEnemy) <= 0)
            {

            }
            else
            {

            }
        }
    }
}
