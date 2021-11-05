using UnityEngine;
using UnityEngine.Transform;

public class Rotation : MonoBehaviour
{
    public Transform transform;
    public float degreesPerTick = 0;
    public float incrementPerTick = 0.2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float degrees = degreesPerTick * Time.deltaTime;
        transform.Rotate(0, degrees, 0, Space.World);
        degreesPerTick += incrementPerTick;
    }
}
