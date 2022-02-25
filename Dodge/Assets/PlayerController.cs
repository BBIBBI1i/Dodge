using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{  
    // �̤Ǥ����� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;
    // Start is called before the first frame update
    // �̵��ӷ�
    public float speed = 8f;
    // �� �ڽ��� ���� ����

    public GameObject my;

    private void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã��
        // PlayerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();

    }

       // Update is called once per frame
    void Update()
    {

        //������� �������� �Է°��� �����ؼ� ����
        float xInput = Input.GetAxis("Horizontal");
        // Ű���� : 'A',<- :���� ���� : -1.0f
        // Ű���� : 'D', -> : ���� ���� : +1.0f
        float zInput = Input.GetAxis("Vertical");
        // Ű���� : 'W',^ :���� ���� : +1.0f

        // ���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vecxtor3 �ӵ��� (xSpeed, 0f. zSpeed) ����
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        //������ٵ��� �ӵ��� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;


    }

    void DirectInput()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, speed);

        }
        if
           (Input.GetKey(KeyCode.DownArrow) == true)
        {
            // �Ʒ��� ����Ű �Է��� ������ ��� - z�������ֱ�
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        if
             (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        if
             (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            // ���ʹ���Ű �Է� ���� -x ����
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }
       public void Die()
       { 
        my.SetActive(false);
        //gameObject.SetActive(false);
        // �� �̷��� �ҹ��ڷ� (����) �ϸ� ����Ƽ�� �ڵ����� ����
       }
}
