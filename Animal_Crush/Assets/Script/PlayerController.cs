using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private KeyCode jumpKey = KeyCode.Space;

    private PlayerMove move;

    private void Awake()
    {
        move = GetComponent<PlayerMove>();
    }

    private void Update()
    {
        UpdateMove();
        UpdateJump();
    }

    private void UpdateMove()
    {
        float x = Input.GetAxisRaw("Horizontal");

        move.MoveTo(x);
    }

    private void UpdateJump()
    {
        if(Input.GetKeyDown(jumpKey))
        {
            move.JumpTo();
        }
    }
}
