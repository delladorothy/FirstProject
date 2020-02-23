using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    
    public float speed;
    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>(); //rigid 컴포넌스을 받아 변수에 할당
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horiz = Input.GetAxisRaw("Horizontal"); //입력한 좌우 방향을 가져온다
        float vert = Input.GetAxisRaw("Vertical");

            rigid.velocity = new Vector2(horiz, vert) * speed;

        Debug.Log("test: horiz:" + horiz); //입력한 키보드 방향 출력
        Debug.Log("test: vert:" + vert);


    }
}
