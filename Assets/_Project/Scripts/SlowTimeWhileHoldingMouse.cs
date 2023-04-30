using UnityEngine;

public class SlowTimeWhileHoldingMouse : MonoBehaviour
{
    [SerializeField] private float timeToSlowed = 0.25f;
    [SerializeField] private float minTimeScale = 0.2f;

    private float _slowSpeed = 0f;

    private void Update()
    {
        _slowSpeed = 1f / timeToSlowed;
        
        var target = 1f;
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
            target = minTimeScale;
        }

        Time.timeScale = Mathf.MoveTowards(Time.timeScale, target, Time.unscaledDeltaTime * _slowSpeed);
    }
}
