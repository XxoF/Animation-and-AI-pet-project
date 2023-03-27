using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 40f;

    private float horizontalMove = 0f;
    private float verticalMove = 0f;
    private GameController gameController;
    // Update is called once per frame

    void Start()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }

    void Update()
    {
        verticalMove = Input.GetAxis("Vertical") * runSpeed;
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;

        if (verticalMove > 0f)
        {
            gameController.playerMoving();
        }
        else
        {
            gameController.playerIdle();
        }

        gameController.playerRotate(horizontalMove);
    }
}
