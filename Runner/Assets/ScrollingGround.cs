using UnityEngine;

public class ScrollingGround : MonoBehaviour
{
    public float scrollSpeed = 5f;
    public float groundWidth = 20f;

    void Start()
    {
        
    }


    void Update()
    {
        Vector3 movePosition = transform.position;
        movePosition.x += -1 * scrollSpeed * Time.deltaTime;
        transform.position = movePosition;

        if(transform.position.x < -groundWidth)
        {
            Vector3 resetPosition = transform.position;
            resetPosition.x += groundWidth * 2;
            transform.position = resetPosition;
        }
    }
}
