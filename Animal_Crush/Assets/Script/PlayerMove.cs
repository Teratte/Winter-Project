using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Move Horizontal")]
    [SerializeField]
    private float moveSpeed = 5; //�̵��ӵ�

    [Header("Move Vertical")]
    [SerializeField]
    private float jumpForce = 1;

    private Rigidbody2D rigid2D;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    //x�� �̵����� ����
    public void MoveTo(float x)
    {
        rigid2D.velocity = new Vector2(x * moveSpeed, rigid2D.velocity.y);
    }

    public bool JumpTo()
    {
        rigid2D.velocity = new Vector2(rigid2D.velocity.x, jumpForce);

        return true;
    }
}
