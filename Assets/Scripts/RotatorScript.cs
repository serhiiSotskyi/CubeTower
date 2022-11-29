
using UnityEngine;

public class RotatorScript : MonoBehaviour
{
    public float speed = 5f;
    private Transform _ratator;
    private void Start()
    {
        _ratator = GetComponent<Transform>();
         
    }
    private void Update()
    {
        _ratator.Rotate(0, speed * Time.deltaTime, 0);
    }
}
