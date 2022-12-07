using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    private const float plainSpeed = 80.0f;
    private const float upSpeed = 140.0f;
    private float realSpeed;
    Vector2 playerMove = new Vector2();
    // Start is called before the first frame update
    void Start()
    {
        realSpeed = plainSpeed;
    }

    public void MoveControl(ref Rigidbody2D playerRid, ref GeneLibrary geneLibrary) {
        playerMove.y = Input.GetAxis("Vertical");
        playerMove.x = Input.GetAxis("Horizontal");
        playerMove.x /= 2;
        playerMove.Normalize();
        SpeedChoose(geneLibrary.tile);
        // Debug.Log("Current speed is:" + realSpeed);
        playerRid.velocity = realSpeed * playerMove * Time.fixedDeltaTime;
    }

    private void SpeedChoose(bool haveTile) {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0) {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
                if (!haveTile) {
                    Debug.Log("Player don't have tile, can't change speed");
                    return;
                }
                realSpeed = upSpeed;
                return;
            }
        }
        realSpeed = plainSpeed;
    }
}
