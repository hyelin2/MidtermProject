using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

   
    public float delayTime = 1f;
    public int deathNum = 10; // 체력 10

    public float moveSpeed = 10.0f;
    public float rotSpeed = 10.0f;

    float h = 0.0f;
    float v = 0.0f;
    Transform tr;

    // move 변수
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
     

        //회전 : 키보드 좌우 방향키(Y축 기준 회전)
        h = Input.GetAxis("Horizontal");
        tr.Rotate(0, h * rotSpeed, 0, Space.World);
        //이동 : 키보드 전후 방향키(평면에서 앞뒤로 이동)
        v = Input.GetAxis("Vertical");
        float tz = v * moveSpeed * Time.deltaTime;
          tr.Translate(0, 0, tz);

    }

    
    void move()
    {
        
        

     
      
    }
    void death()
    {
        
        //총알에 맞으면 체력 1 감소

    }

    //코루틴 함수
   
}
