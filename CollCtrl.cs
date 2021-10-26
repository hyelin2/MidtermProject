using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 충돌처리함수
public class CollCtrl : MonoBehaviour
{ 
    int n = 0;
    public PlayerCtrl pc;
    public BulletCtrl bc;
    public GameObject ItemY;
    public GameObject ItemB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 0, 45) * Time.deltaTime);
        

    }

    void OnColisionEnter(Collision coll)
    {  //플레이어와 아이템 충돌처리
        if (coll.collider.CompareTag("ItemB"))
        {
            // 파란색 물체와 부딪히면 총알의 발사 간격이 0.2초 감소
            bc.ClickShot();
            Destroy(ItemB, 0.1f);
        }
        if (coll.collider.CompareTag("ItemY"))
        {
            //노란색 물체와 부딪히면 주인공 체력 증가 1
            pc.deathNum++;
            Destroy(ItemY, 0.1f);
        }
    }

    void Enem2Play()
    {
        //적과 주인공 충돌
        // 주인공 체력 감소
    }

    void EnemBullet2Play()
    {
        //적의 총알과 플레이어 충돌, 적의총알 제거, 주인공 체력 감소
    }

    void PlayerButtet2Enum()
    {
        //주인공 총알과 적 , 적 체력 감소
        // 제거한 몬스터 개수 증가

    }
    void Plyer2Item()
    {
        //아이템 제거
    }

    // 총알끼리는 충돌하지 않음  아이템은 주인공 이외에는 충돌하지 않음
   
    public void ClickShot()
    {
        StartCoroutine(Shot());

    }
    IEnumerator Shot()
    {
        yield return new WaitForSeconds(1.0f + 0.2f * n);
       // isDelay = false;
    }
  
   
}
