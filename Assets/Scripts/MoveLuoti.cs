using UnityEngine;

public class MoveLuoti : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 velocity;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }
}