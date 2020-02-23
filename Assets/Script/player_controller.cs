using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    Rigidbody2D rigid;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
                          
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("horizontal")
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);
        
    }
}
