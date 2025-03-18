using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class VasicVariables : MonoBehaviour
{
    public int gold = 0;
    public float Hp = 100.0f;
    public string playerName = "홍길동";
    public bool isAlive = true;

    void Start()
    {
        // == 두 값이 같을 때 true
        // != 두 값이 다르면 true
        // > 왼쪽 값이 더 크면 true
        // < 오른쪽 값이 더 크면 true
        // >= 왼쪽 값이 크거나 같으면 true
        // <= 오른쪽 값이 크거나 같으면 true

        if (gold > 50)

            Debug.Log("아이템을 구매할 수 있습니다.");
        else if (gold == 40) //if안에 조건이

            Debug.Log("골드가 40원 보유 중 입니다. 10 골드만 더 모으면 살 수 있어요!");
    }//else //if 안의 조건이 참이 아닐 때
    //{
    // Debug.Log("골드가 부족합니다.");
    //}

    // Update is cal led once per lrame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))    //space를 눌렀을 때 true
        {


        }

    }

}
    
        
  
