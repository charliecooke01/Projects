using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Animator goatAnim;

    //Jump Values
    public float jumpDuration = 0.5f;
    public float jumpDistance = 3;
    private bool jumping = false;
    private float jumpStartVelocityY;

    //Controls for character gravity
    private Vector3 fall;
    public float gravity = -10;
    private bool falling = false;

    //Set Lane : 0 = Left, 1 = Middle, 2 = Right
    private int lane = 1;

    private GameObject gameController;

    //Set at game start
    private void Start()
    {
        //connect animator
        goatAnim = GetComponent<Animator>();

        //set starting velocity of jump
        jumpStartVelocityY = -jumpDuration * Physics.gravity.y / 2;

        gameController = GameObject.FindWithTag("GameController");
    }

    //Run every frame
    private void Update()
    {
        if (this.falling)
        {
            this.fall.y += this.gravity * Time.deltaTime;
            gameObject.transform.position = this.fall;
        } else
        {
            //If jumping don't move
            if (jumping)
            {
                return;
            }
            else
            {
                string keyPress = "";
                if (Input.GetKeyDown(KeyCode.LeftArrow)) keyPress = "left";
                if (Input.GetKeyDown(KeyCode.UpArrow)) keyPress = "up";
                if (Input.GetKeyDown(KeyCode.RightArrow)) keyPress = "right";

                if (keyPress != "")
                {
                    StartCoroutine(InitiateJump(keyPress));
                }

            }
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EmptyPlatform")
        {
            Debug.Log("Falling!");
            this.falling = true;
        }
    }

    private IEnumerator InitiateJump(string direction)
    {
        //Set direction movements
        Vector3 left = (transform.forward - transform.right + transform.up) * jumpDistance;
        Vector3 right = (transform.forward + transform.right + transform.up) * jumpDistance;
        Vector3 forward = (transform.forward + transform.up) * jumpDistance;
        Vector3 jumpDirection = forward;

        //Move Left
        if (direction == "left" && lane > 0)
        {
            jumpDirection = left;
            lane--;
        }

        //Move Right
        else if (direction == "right" && lane < 2)
        {
            jumpDirection = right;
            lane++;
        }
        if (direction == "left" || direction == "up" || direction == "right")
        {
            StartCoroutine(Jump(jumpDirection));
        }

        yield break;
    }

    //Jump function
    private IEnumerator Jump(Vector3 direction)
    {
        //set jumping bool
        this.jumping = true;

        //Position values
        Vector3 startPoint = transform.position;
        Vector3 targetPoint = startPoint + direction;

        //Movement values
        float time = 0;
        float jumpProgress = 0;
        float velocityY = 9;//jumpStartVelocityY;
        float height = startPoint.y;

        bool finishedJumping = false;

        while (!finishedJumping)
        {
            //Set jump duration
            jumpProgress = time / jumpDuration;

            //Stop jump
            if (jumpProgress >= 1)
            {
                finishedJumping = true;
                jumpProgress = 1;
            }

            //transform position to target position
            Vector3 currentPos = Vector3.Lerp(startPoint, targetPoint, jumpProgress);
            currentPos.y = height;
            transform.position = currentPos;

            //Wait until next frame.
            yield return null;

            //Set jump height and velocity
            height += velocityY * Time.deltaTime;
            velocityY += Time.deltaTime * Physics.gravity.y;
            time += Time.deltaTime;
        }

        //Transform position
        transform.position = targetPoint;

        Debug.Log("Calling LevelManager.handleRowManagement() from within the PlayerMovement.Jump() Coroutine");
        gameController.GetComponent<LevelManager>().handleRowManagement();
        Debug.Log("Calling LevelManager.increasePlayerRow() from within the PlayerMovement.Jump() Coroutine");
        gameController.GetComponent<LevelManager>().increasePlayerRow();

        this.fall = gameObject.transform.position;
        this.jumping = false;

        yield break;
    }

    public void setFalling(bool falling)
    {
        Debug.Log("PlayerMovement.setFalling(" + falling + ")");
        this.falling = falling;
    }

}
