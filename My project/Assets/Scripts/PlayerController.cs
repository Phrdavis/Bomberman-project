using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rig;
    public float Speed;
    private Vector2 move; 


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){	

        Move();

    }

    void Move(){
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        move = new Vector2(horizontal, vertical).normalized * Speed * Time.fixedDeltaTime;

        rig.MovePosition(rig.position + move);
    }

    public void Death(){

        Destroy(gameObject);

    }
}
