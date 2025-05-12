using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public bool move = true;
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        var cachedVel = rb.velocity;
        var forwardVel = transform.forward * speed;
        rb.velocity = new Vector3(forwardVel.x, cachedVel.y, forwardVel.z);

    }
    public void OnFootstep()
    {
    }
}
