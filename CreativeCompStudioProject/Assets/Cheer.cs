using FMODUnity;
using UnityEngine;

public class Cheer : MonoBehaviour
{
    [EventRef, SerializeField] string audioKey = default;
    // Start is called before the first frame update
    void Start()
    {
        var audioEvent = RuntimeManager.CreateInstance(audioKey);
        audioEvent.start();
    }

}
