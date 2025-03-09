using UnityEngine;

public class Wheeling : MonoBehaviour
{
    [SerializeField] float wheelSpeed;
    void Start()
    {

    }

    void Update()
    {
        WheelProcess();
    }

    void WheelProcess()
    {
        transform.Rotate(wheelSpeed * Time.deltaTime, 0, 0);
    }
}
