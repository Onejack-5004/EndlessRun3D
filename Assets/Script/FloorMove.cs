using UnityEngine;

public class FloorMove : MonoBehaviour
{
    public float speed = 0.1f;
    public Transform startLocation = null;
    public Transform endLocation = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Translate(new Vector3(0.0f, 0.0f, -speed * Time.deltaTime));
        if (gameObject.transform.position.z < endLocation.position.z)
        {
            Vector3 pos = gameObject.transform.position;
            pos.z = startLocation.position.z;
            gameObject.transform.position = pos;
        }
    }
}
