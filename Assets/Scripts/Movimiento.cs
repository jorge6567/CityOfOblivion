using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Camera cam;
    [SerializeField] private float speed = 5f;

    private Rigidbody2D playerrb;
    private Vector2 moveInput;
    Vector2 mousePos;
    private Animator anim;

    void Start()
    {
        playerrb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (moveY != 0 || moveX != 0)
        {
            anim.SetFloat("Correr", 1);
        }
        else
        {
            anim.SetFloat("Correr", -2);
        }

    }

    private void FixedUpdate()
    {
        playerrb.MovePosition(playerrb.position + moveInput * speed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePos - playerrb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        playerrb.rotation = angle;
    }
}
