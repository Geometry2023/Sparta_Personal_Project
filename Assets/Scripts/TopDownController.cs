using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    //Vector2 타입인 키들을 입력받고 그에 맞는 Action들을 참조하기 위한 선언.
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;


    //PlayerInputController.cs에서 호출한다.
    //Action에 관계된 키 입력이 들어오면 그 해당 Action(Move, Look, Fire)을 참조한다.
    //direction을 인자로 참조한 Action을 실행(Move(direction)처럼)
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}
