using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GeneLibrary geneLibrary;
    private GeneBehavior geneBehavior;
    private Rigidbody2D playerRid;
    private Animator playerAnimator;
    private PlayerMoveController playerMoveController;
    // Start is called before the first frame update
    void Start()
    {
        playerRid = GetComponent<Rigidbody2D>();
        gameObject.AddComponent<PlayerMoveController>();
        gameObject.AddComponent<GeneBehavior>();
        gameObject.AddComponent<GeneLibrary>();
        playerMoveController = GetComponent<PlayerMoveController>();
        geneBehavior = GetComponent<GeneBehavior>();
        geneLibrary = GetComponent<GeneLibrary>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMoveController.MoveControl(ref playerRid, ref geneLibrary);
    }
}
