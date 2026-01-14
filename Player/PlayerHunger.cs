using UnityEngine;
using UnityEngine.UI;
public class PlayerHunger : MonoBehaviour
{

    [SerializeField] float maxHunger = 100;
    float currentHunger;
    float hungerDecrease = 0.4f;

    public Slider hungerSlider;
    
    
    void Start()
    {
        currentHunger = maxHunger;

        if(hungerSlider != null)
        {
            hungerSlider.maxValue = maxHunger;
            hungerSlider.value = currentHunger;
        }

    }

    void Update()
    {
        float randomVariation = Random.Range(-0.2f, 0.3f);
        currentHunger -= (hungerDecrease + randomVariation) * Time.deltaTime;
    }


}
