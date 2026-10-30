using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField]
    Rigidbody2D RB;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, v, 0) * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RB.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
        }
    }
}