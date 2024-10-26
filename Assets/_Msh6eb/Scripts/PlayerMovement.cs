using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private Transform objectToMove;
    [SerializeField] private Vector2 direction = new Vector2(1f, 0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (objectToMove == null)
        {
            objectToMove = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(objectToMove);
    }
    void MoveObject(Transform obj)
    {
        Vector2 movement;
        movement = direction.normalized * speed * Time.deltaTime;
        obj.Translate(movement);
    }
}

// feha tamra

