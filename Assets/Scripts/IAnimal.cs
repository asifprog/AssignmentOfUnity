using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class IAnimal : MonoBehaviour
{
    public GameObject PlayerI { get; set; }
    float xpos;
    float zpos;
    public static bool flag;
    public static int Cnt;
    public static  bool WLFlag;
    public GameObject[] prefabs;
    public GameObject CounterDisplay;
    private string str = "Go";
    private int TimeEnd =0;
    public static bool IAds;
    //GameObject PlayerI {get;set;}

    public GameObject Timer;
   // public GameObject Screen;

    public AudioSource source;

    void Start()
    {
       //Screen.gameObject.SetActive(false);
        StartCoroutine(ObjectGenerator());
        StartCoroutine(TimerForEnd());
        source = GetComponent<AudioSource>();
    }
    IEnumerator Counter()
    {
        for (int i=3;i>=1;i--)
        {
            CounterDisplay.GetComponent<Text>().text = i.ToString();
            yield return new WaitForSeconds(0.3f);

        }
        CounterDisplay.GetComponent<Text>().text = str ;
        yield return new WaitForSeconds(0.3f);
        CounterDisplay.gameObject.SetActive(false);
        yield return true;
    }
    IEnumerator ObjectGenerator()

    {
        if (AnimalInterface.BPress == true)
        {

          
            // objectToGenerate = Random.Range(1, 11);
            xpos =44.77F;
            zpos = 54.74F;
            StartCoroutine(Counter());
            //PlayerI =
            PlayerI =Instantiate(prefabs[0], new Vector3(xpos, 4, zpos), Quaternion.identity);
            CameraMovement.instance.Initialize(PlayerI);
            //Cnt = 0;
            flag = true;
            source.Play();
            yield return new WaitForSeconds(0.1f);
            // objectToGenerate += 1;
        }
      /*  else if (AnimalInterface.DPress==true)
        {

            // objectToGenerate = Random.Range(1, 11);
            xpos = 44.77F;
            zpos = 54.74F;
            Instantiate(prefabs[1], new Vector3(xpos, 4, zpos), Quaternion.identity);


            yield return new WaitForSeconds(0.1f);
            // objectToGenerate += 1;
        }*/

    }
   IEnumerator TimerForEnd()
    {
        for (int j=0;j<=200;j++)
        {
            Timer.GetComponent<Text>().text = TimeEnd.ToString();
            TimeEnd++;
            yield return new WaitForSeconds(0.3f);
        }
        yield return true;
    }
    IEnumerator WaitForEnd()
    {
        yield return new WaitForSeconds(0.5f);
    }
   private void Update()
    {
        Timer.GetComponent<Text>().text = TimeEnd.ToString();
        if(TimeEnd<200 && DestroyFruit.ScorePlayer>=10)
        {
          //  Screen.gameObject.SetActive(true);
            source.Stop();
          // Screen.GetComponent<Text>().text = Win;
            StartCoroutine(WaitForEnd());
            WLFlag = true;
            IAds = true;
            SceneManager.LoadScene("Console", LoadSceneMode.Single);

        }
        if (TimeEnd >= 200 && DestroyFruit.ScorePlayer<10)
        {
            //Screen.gameObject.SetActive(true);
            source.Stop();
           // Screen.GetComponent<Text>().text = Loss;
            StartCoroutine(WaitForEnd());
            WLFlag = false;
            IAds = true;
            SceneManager.LoadScene("Console", LoadSceneMode.Single);
        }
    }
    // Start is called before the first frame update

}
