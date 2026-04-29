using UnityEngine;

public class Win : MonoBehaviour
{
    public BoxCollider2D Collision;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Win!");
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
}
