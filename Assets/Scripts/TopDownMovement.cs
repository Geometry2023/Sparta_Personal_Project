using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    //������ �̵��� �Ͼ ������Ʈ

    // TopDownController.cs�� ������ �޾ƿ��� ���� �����Ѵ�.
    private TopDownController movementController;
    // Player ������Ʈ�� ������ �����̱� ���ؼ� �����Ѵ�.
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        // ���� ���ӿ�����Ʈ�� TopDownController, Rigidbody�� ������ �� 
        // Player ������Ʈ�� TopDownMovement.cs�� ����Ǿ� �����Ƿ� 
        // GetCompont�� Player ������Ʈ�� ������Ʈ�鿡�� �����ϰ� �ȴ�.
        movementController = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // OnMoveEvent�� Move�� ȣ��(����)�϶�� �����
        // OnMoveEvent�� ��������Ʈ�� ��ȯ���� void�� �Լ��� ������ �� �ִ�.
        // Move�� ��ȯ���� void�� �Լ��̴�.
        // OnMoveEvent�� Move�� �����Ѵ�. 
        // ������ �߰� ȣ���� ���� �ʾҴ�. 
        movementController.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        // ���� ������Ʈ���� ������ ����
        // Player ������Ʈ�� �Էµ� ����� ������ ���� �����̵��� �Ѵ�.
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        // �̵����⸸ ���صΰ� ������ ���������� ����.
        // �����̴� ���� ���� ������Ʈ���� ����(rigidbody�� �����ϱ�)
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        // �ش� Player ������Ʈ�� �ӵ��� direction ����
        movementRigidbody.velocity = direction;
    }

}
