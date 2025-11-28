
using UnityEngine;
using UnityEngine.UI;

public class SimpleManager : MonoBehaviour
{

    [SerializeField]
    private Text scoreText;
    private int scoreValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreValue = PlayerPrefs.GetInt("score");
        if(scoreValue == 0)
        {
            PlayerPrefs.SetInt("score", 0);
            scoreValue = 0;
        }
        scoreText.text = scoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyCilinder()
    {
        scoreValue++;
        scoreText.text = scoreValue.ToString();
        PlayerPrefs.SetInt("score", scoreValue);
        Destroy(this.gameObject);
    }

    public void openDoor()
    {
        if(this.GetComponent<Transform>().rotation.y > 0.1f)
        {
            this.GetComponent<Transform>().Translate(new Vector3(-1f, 0, +1f ));
            this.GetComponent<Transform>().Rotate(0, -90, 0);
        }
        else
        {
            this.GetComponent<Transform>().Translate(new Vector3(-1f, 0, -1f));
            this.GetComponent<Transform>().Rotate(0, 90f, 0);
        }
            
        
    }
}
