using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    protected Rigidbody2D myRigidbody;

    public virtual void Awake()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    public void Motion(Vector2 direction)
    {
        direction = direction.normalized;
        myRigidbody.velocity = direction * speed;
    }
}



