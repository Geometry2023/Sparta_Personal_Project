using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerInputController : TopDownController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }

    // On + Action이름(Move)
    //InpuValue value : 사용자의 W,S,A,D키 입력값 정보가 저장됨. 
    public void OnMove(InputValue value)
    {
        // Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;

        //해당하는 입력 값과 그 입력에 대응하는 Action(Move 동작)의 정보를 주어 
        //CallMoveEvent가 Move을 참조하게 된다.
        CallMoveEvent(moveInput);  // 상속받은 메소드. 
    }

    // On + Action이름(Look)
    //InpuValue value : 사용자의 마우스 위치값 정보가 저장됨. 
    public void OnLook(InputValue value)
    {
        // Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= .9f)
        // Vector 값을 실수로 변환
        {
            //해당하는 입력 값과 그 입력에 대응하는 Action(Look 동작)의 정보를 주어 
            //CallMoveEvent가 Look을 참조하게 된다.
            CallLookEvent(newAim);  // 상속받은 메소드
        }
    }

    // On + Action이름(Fire)
    //InpuValue value : 사용자의 마우스 Left 입력값이 저장됨.
    public void OnFire(InputValue value)
    {
        Debug.Log("OnFire" + value.ToString());
    }

}
