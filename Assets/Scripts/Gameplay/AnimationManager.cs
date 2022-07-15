using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private PlayerManager playerManager;
    private Animator animator;

    private void Awake()
    {
        playerManager = GetComponent<PlayerManager>();
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        UpdateAnimations();
    }

    private void UpdateAnimations()
    {
        animator.SetBool("isWalking", playerManager.isWalking);
        animator.SetBool("isGrounded", playerManager.isGrounded);
        animator.SetFloat("yVelocity", playerManager.rb.velocity.y);
        animator.SetBool("isWallSliding", playerManager.isWallSliding);
    }
}
