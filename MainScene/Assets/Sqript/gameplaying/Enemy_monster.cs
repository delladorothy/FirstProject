using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_monster : MonoBehaviour
{
    //변수 선언
    Rigidbody2D rigid;
    public int nextMove1;
    public int nextMove2;
    SpriteRenderer spriteRenderer;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        //invoke 특정시간 후에 지정 함수 호출
        Invoke("Think", 5); // think 함수를 5초 뒤에 호출
    }

    // Update is called once per frame
    void Update()
    {
        //속도 변경
        rigid.velocity = new Vector2(nextMove1, nextMove2);

        // 움직임 에니메이션 방향전환
        spriteRenderer.flipX = nextMove1 == 1;
        

        //움직임 에니메이션 전환
        if (rigid.velocity == Vector2.zero)//속도가 0이면
        {
            anim.SetBool("isMove", false); //isMove변수을 false로 설정
        }
        else
            anim.SetBool("isMove", true);//isMove변수을 true로 설정


    }

    //어디로 움직일지 고민
    void Think()
    {
        //움직일 방향을 랜덤으로 move random 
        nextMove1 = Random.Range(-1, 2); //좌우
        nextMove2 = Random.Range(-1, 2); //상하
        
        //다음 생각할 시간또한 랜덤으로
        float nextThinkTime = Random.Range(2f, 5f); //2~5
        //재귀함수 실행 recursive
        Invoke("Think", nextThinkTime);
        


    }



}
