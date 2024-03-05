
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManger manager;
    void OnTriggerEnter()
    {
        manager.CompleteLevel();
    }
}
