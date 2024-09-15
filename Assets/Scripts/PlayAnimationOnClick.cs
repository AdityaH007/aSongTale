using UnityEngine;

public class PlayAnimationOnClick : MonoBehaviour
{
    public Animator animator;
    public string animationName;

    public void PlayAnimation()
    {
        animator.Play(animationName);
    }
}
