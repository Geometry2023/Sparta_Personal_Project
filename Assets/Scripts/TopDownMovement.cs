using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    //실제로 이동이 일어날 컴포넌트

    // TopDownController.cs의 정보를 받아오기 위해 선언한다.
    private TopDownController movementController;
    // Player 오브젝트를 실제로 움직이기 위해서 선언한다.
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        // 같은 게임오브젝트의 TopDownController, Rigidbody를 가져올 것 
        // Player 오브젝트에 TopDownMovement.cs가 적용되어 있으므로 
        // GetCompont는 Player 오브젝트의 컴포넌트들에서 선택하게 된다.
        movementController = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // OnMoveEvent에 Move를 호출(참조)하라고 등록함
        // OnMoveEvent는 델리게이트로 반환형이 void인 함수를 참조할 수 있다.
        // Move는 반환혀이 void인 함수이다.
        // OnMoveEvent는 Move을 참조한다. 
        // 참조만 했고 호출은 하지 않았다. 
        movementController.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        // 물리 업데이트에서 움직임 적용
        // Player 오브젝트가 입력된 값들로 실제로 부터 움직이도록 한다.
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        // 이동방향만 정해두고 실제로 움직이지는 않음.
        // 움직이는 것은 물리 업데이트에서 진행(rigidbody가 물리니까)
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        // 해당 Player 오브젝트의 속도를 direction 으로
        movementRigidbody.velocity = direction;
    }

}
