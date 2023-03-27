using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public int playerAnimationSpeed;
    public GameObject player;

    private Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = player.GetComponent<Animator>();
        playerIdle();
        playerRotate(0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playerMoving()
    {
        playerAnimator.SetFloat("Speed", 1.0f);
    }

    public void playerIdle()
    {
        playerAnimator.SetFloat("Speed", 0f);
    }

    public void playerRotate(float horizontalInput)
    {
        if (horizontalInput < 0f)
        {
            // Turn left
            playerAnimator.SetBool("TurnLeft", true);
        }
        else if (horizontalInput > 0f)
        {
            playerAnimator.SetBool("TurnRight", true);
        }
        else if (horizontalInput == 0)
        {
            playerAnimator.SetBool("TurnLeft", false);
            playerAnimator.SetBool("TurnRight", false);

        }
    }
}
