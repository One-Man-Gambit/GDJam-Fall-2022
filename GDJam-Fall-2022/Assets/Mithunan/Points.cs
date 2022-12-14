using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static Points points;
    int pointsCollected = 0;
    public Text pointsText;
    
    // Start is called before the first frame update
    void Awake()
    {
        if(points != null && points != this)
        {
            Destroy(this);
        }
        else
        {
            points = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public int GetPoints()
    {
        return pointsCollected;
    }

    public void AddPoints(int _value)
    {
        pointsCollected += _value;
        pointsText.text = pointsCollected.ToString();
    }

    public void EndGame()
    {
        SceneManager.LoadScene("End Scene");
    }
    

}
