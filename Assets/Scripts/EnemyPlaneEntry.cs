using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyPlaneEntry : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private Slider slider;

    public void ConnectTo(EnemyPlane enemyPlane)
    {
        enemyPlane.Subscribe(this);
    }

    public void ChangeValues(string name, float hits)
    {
        text.text = name;
        slider.value = hits;
    }
}