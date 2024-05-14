using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    //Vector2 Ÿ���� Ű���� �Է¹ް� �׿� �´� Action���� �����ϱ� ���� ����.
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;


    //PlayerInputController.cs���� ȣ���Ѵ�.
    //Action�� ����� Ű �Է��� ������ �� �ش� Action(Move, Look, Fire)�� �����Ѵ�.
    //direction�� ���ڷ� ������ Action�� ����(Move(direction)ó��)
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}
