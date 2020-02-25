using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_monster : MonoBehaviour
{
    Rigidbody2D rigid;
    public int nextMove1;
    public int nextMove2;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

        Invoke("Think", 5); // think 함수를 5초 뒤에 호출
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = new Vector2(nextMove1, nextMove2);
    }

    void Think()
    {
        nextMove1 = Random.Range(-1, 2); //좌우
        nextMove2 = Random.Range(-1, 2); //상하

        Invoke("Think", 5);

    }
}
