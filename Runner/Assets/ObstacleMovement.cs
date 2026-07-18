using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 5f;
    public float destroyX = -8f;

    void Start()
    {
        
    }


    void Update()
    {
        Vector3 movePosition = transform.position;
        movePosition.x += -1 * speed * Time.deltaTime;
        transform.position = movePosition;

        if(movePosition.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}
