using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    public GameObject enemy;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0, speed * Time.deltaTime);    
    }

    void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.CompareTag("Enemy")) {
        Destroy(collision.gameObject);
    }
    Destroy(gameObject);
}
    

}
