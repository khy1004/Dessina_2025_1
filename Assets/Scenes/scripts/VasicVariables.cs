using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class VasicVariables : MonoBehaviour
{
    public int gold = 0;
    public float Hp = 100.0f;
    public string playerName = "ȫ�浿";
    public bool isAlive = true;

    void Start()
    {
        // == �� ���� ���� �� true
        // != �� ���� �ٸ��� true
        // > ���� ���� �� ũ�� true
        // < ������ ���� �� ũ�� true
        // >= ���� ���� ũ�ų� ������ true
        // <= ������ ���� ũ�ų� ������ true

        if (gold > 50)

            Debug.Log("�������� ������ �� �ֽ��ϴ�.");
        else if (gold == 40) //if�ȿ� ������

            Debug.Log("��尡 40�� ���� �� �Դϴ�. 10 ��常 �� ������ �� �� �־��!");
    }//else //if ���� ������ ���� �ƴ� ��
    //{
    // Debug.Log("��尡 �����մϴ�.");
    //}

    // Update is cal led once per lrame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))    //space�� ������ �� true
        {


        }

    }

}
    
        
  
