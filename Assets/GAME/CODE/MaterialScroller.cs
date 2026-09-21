using UnityEngine;

public class MaterialScroller : MonoBehaviour
{
    public float scrollSpeed = 1f;

    private Renderer rend;
    private Vector2 offset;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        offset.y += Time.deltaTime * scrollSpeed;
        rend.material.mainTextureOffset = offset;
    }
}
