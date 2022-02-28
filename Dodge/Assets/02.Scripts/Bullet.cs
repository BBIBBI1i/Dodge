using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   //�̵��� ����� ������ٵ� ������Ʈ
    private Rigidbody bulletRigidbody;
    //ź�� �̵� �ӷ�
    public float speed = 8f;

    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();

        //������ٵ��� �ӵ� = ���ʹ���* �̵� �ӷ� / ������ * -1
        
        // transform.forward �� vector(x,y,z)0,0,1 ������

        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);



    }

    // Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼ҵ�
    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ���� ���� ������Ʈ�� Player �±׸� ��������
        if(other.tag== "Player")
        {
            // ����(�浹��) ���ӿ�����Ʈ���� PlayerController������Ʈ ��������
            PlayerController playerController =
                other.GetComponent<PlayerController>();

            //�������κ��� PlayerController ������Ʈ�� �������µ� �����ߴٸ�
            if (playerController!=null)
            {
                //playerController ������Ʈ�� Die() �޼ҵ� ����
                playerController.Die();
            }
    
        
        }
    }

    void Update()
    {
        
    }
}
