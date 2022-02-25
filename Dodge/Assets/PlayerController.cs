using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{  
    // 이ㅗㄷㅇ에 사용할 리지드바디 컴포넌트
    public Rigidbody playerRigidbody;
    // Start is called before the first frame update
    // 이동속력
    public float speed = 8f;
    // 내 자신을 담을 변수

    public GameObject my;

    private void Start()
    {
        //게임 오브젝트에서 Rigidbody 컴포넌트를 찾아
        // PlayerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();

    }

       // Update is called once per frame
    void Update()
    {

        //수평축과 수직축의 입력값을 감지해서 저장
        float xInput = Input.GetAxis("Horizontal");
        // 키보드 : 'A',<- :음의 방향 : -1.0f
        // 키보드 : 'D', -> : 양의 방향 : +1.0f
        float zInput = Input.GetAxis("Vertical");
        // 키보드 : 'W',^ :양의 방향 : +1.0f

        // 실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vecxtor3 속도를 (xSpeed, 0f. zSpeed) 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        //리지드바디의 속도에 newVelocity 할당
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
            // 아래쪽 방향키 입력이 감지된 경우 - z방향힘주기
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
            // 왼쪽방향키 입력 감지 -x 방향
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }
       public void Die()
       { 
        my.SetActive(false);
        //gameObject.SetActive(false);
        // ㄴ 이렇게 소문자로 (변수) 하면 유니티가 자동으로 해줌
       }
}
