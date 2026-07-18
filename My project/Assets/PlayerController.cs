using System.Threading.Tasks;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float leftBound = -8f;
    public float rightBound = 8f;
    public Scores scores;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        Vector3 currentPosition =  transform.position;
        currentPosition.x += horizontalInput * speed * Time.deltaTime;
        currentPosition.x = Mathf.Clamp(currentPosition.x, leftBound, rightBound);

        transform.position = currentPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("FallingObject"))
        {
            scores.AddPoint();
            Destroy(collision.gameObject);
            Debug.Log("Caught");
        }
        else if (collision.gameObject.CompareTag("BadObject"))
        {
            scores.LoseLife();
            Destroy(collision.gameObject);
        }

        if(scores.lives <= 0)
        {
            new WaitForSeconds(1);
            scores.RestartGame();
        }


    }
}
