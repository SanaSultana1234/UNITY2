
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreTxt;
    void Update()
    {
        scoreTxt.text=(player.position.z).ToString("0");
        
    }
}
