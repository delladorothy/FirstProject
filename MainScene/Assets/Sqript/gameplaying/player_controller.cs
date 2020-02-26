using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{   
    //변수 선언
    public float speed = 3;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //컴포턴스 가져와 변수에 할당
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //상하좌우의 입력값을 받아오기
        float horiz = Input.GetAxisRaw("Horizontal"); //좌우
        float vert = Input.GetAxisRaw("Vertical"); //상하

        //입력값에다 스피드을 곱해서 플레이어의 속도을 지정
        rigid.velocity = new Vector2(horiz*speed, vert*speed);

        //방향전환 에니메이션
        if (Input.GetButtonDown("Horizontal")) //좌우키을 눌렀을때
        {
            //좌키이면 반전을 활성화
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1; 
        }

        //움직임 에니메이션 전환
        if(rigid.velocity == Vector2.zero)//속도가 0이면
        {
            anim.SetBool("isMove", false); //isMove변수을 false로 설정
        }
        else
            anim.SetBool("isMove", true);//isMove변수을 true로 설정




    }
}
