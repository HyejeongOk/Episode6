using TMPro;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI output;
    [SerializeField] private TMP_InputField input;

    void Start()
    {
        
    }

    void Update()
    {
        output.text  = input.text;
    }
    
}
