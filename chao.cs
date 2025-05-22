using UnityEngine;

public class chao : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject refPlayer;
    public GameObject refPrefab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)){

        refPlayer.SetActive(true);


      }

        if(Input.GetMouseButtonDown(0)){

      //refPlayer.SetActive(true);

      Destroy(refPlayer);


      }
      
        if(Input.GetKeyDown(KeyCode.S)){

        Instantiate(refPrefab, spawnPoint);
        score.circleCount++;


      }


    }
}
