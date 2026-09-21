using UnityEngine;

public class BatmanHeadMovement : MonoBehaviour
{
    public Vector2 mousePosition;
    public Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        mousePosition.x = (Input.mousePosition.x / Screen.width) * 2f - 1f;
        mousePosition.y = (Input.mousePosition.y / Screen.height) * 2f - 1f;

        animator.SetFloat("HeadX", mousePosition.x);
        animator.SetFloat("HeadY", mousePosition.y);
    }
}
