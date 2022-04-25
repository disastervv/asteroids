using UnityEngine;

public class ShootAtPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject luoti;
    [SerializeField] GameObject player;
    [SerializeField] GameObject shootEmpty;
    float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distanceVector = 
            player.transform.position - shootEmpty.transform.position;
        Debug.Log(distanceVector.normalized.x);
        if (timer > 0.2f)
        {
            GameObject newLuoti = Instantiate(
                luoti, 
                shootEmpty.transform.position,
                Quaternion.FromToRotation(
                    shootEmpty.transform.position,
                    player.transform.position
                ));
            Destroy(newLuoti,10);
            MoveLuoti moveLuoti = newLuoti.GetComponent<MoveLuoti>();
            moveLuoti.velocity = distanceVector.normalized * 4.0f;
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}