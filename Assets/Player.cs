using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private Vector2 _input;

    public float Speed;

    public Transform GunPoint;

    public GameObject BulletPrefab;

    public float bulletForce = 20f;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.up = (MouseUtils.GetMousePosition2d() - (Vector2)transform.position ).normalized;
        _rigidbody.velocity = _input.normalized * Speed;
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(BulletPrefab, GunPoint.position, transform.rotation);
    }
}
