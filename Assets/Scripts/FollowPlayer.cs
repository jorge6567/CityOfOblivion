using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float Distance;
    public float SpeedEnemy;
    private Vector2 posEnemy;
    public Transform posPlayer;
    private Vector2 MovE;
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
            int Slime = LayerMask.NameToLayer("Slime");
            int Wolf = LayerMask.NameToLayer("Wolf");
            int Zombie = LayerMask.NameToLayer("Zombie");
            gameObject.GetComponent<IA_Movimiento>().enabled = false;
            transform.position = Vector2.MoveTowards(transform.position, posPlayer.position, SpeedEnemy * Time.deltaTime);
            if (gameObject.layer == Zombie)
            {
                Vector3 direction = posPlayer.position - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90f;
                rb.rotation = angle;
                MovE = direction;
                direction.Normalize();
            }
            if (gameObject.layer == Wolf)
            {
                Vector3 direction = posPlayer.position - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90f;
                rb.rotation = angle;
                MovE = direction;
                direction.Normalize();
            }
            if (gameObject.layer ==Slime)
            {
                Debug.Log("SlimeMoV");
            }
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
