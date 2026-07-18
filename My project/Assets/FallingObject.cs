using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public float fallSpeed = 3f;
    public float destroyY = -6f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fallPosition = transform.position;
        fallPosition.y += -1 * fallSpeed * Time.deltaTime;
        transform.position = fallPosition;

        if(transform.position.y < destroyY)
        {
            Destroy(gameObject);
        }
    }
}
