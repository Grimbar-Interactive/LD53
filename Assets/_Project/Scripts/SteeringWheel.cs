using UnityEngine;

public class SteeringWheel : MonoBehaviour
{
    [SerializeField] private Vector3 axisScale = Vector3.forward;
    [SerializeField] private float maxSteering = 30f;
    private float _steering = 0f;
    
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _steering = Mathf.Lerp(_steering, -1f, 0.2f);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _steering = Mathf.Lerp(_steering, 1f, 0.2f);
        }
        else
        {
            _steering = Mathf.Lerp(_steering, 0f, 0.2f);
        }

        transform.localRotation = Quaternion.Euler(axisScale * (_steering * maxSteering));
    }
}
