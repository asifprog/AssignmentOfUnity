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
    public static int time=200;
    public static int size = 2;
    public static bool flag;
    int cntanimal = 0;
    public static int Cnt;
    public static  bool WLFlag;
    public  GameObject[] prefabs;
   public static List<string> animalname = new List<string>();
    //public static string[] animalname=new string[size];
    public GameObject CounterDisplay;
    private string str = "Go";
    public  static int TimeEnd =0;
    public static bool IAds;
    public static string pname;
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
            pname = gameObject.name;
            Debug.Log(prefabs[0].name);
            CameraMovement.instance.Initialize(PlayerI);
            //animalname.Add(prefabs[0].name);
            if (animalname.Count==0)
            {
                animalname.Add(prefabs[0].name);
                animalname.Add(DestroyFruit.ScorePlayer.ToString());

                Debug.Log("called");
                // animalname[0] = prefabs[0].name;

                cntanimal = 0;
                OnDestroy();
            }
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
    void OnDestroy()
    {
        PlayerPrefs.SetString(animalname[cntanimal],prefabs[cntanimal].name);
        PlayerPrefs.SetString(animalname[cntanimal+1],DestroyFruit.ScorePlayer.ToString());

        PlayerPrefs.Save();
    }
    IEnumerator TimerForEnd()
    {
        for (int j=0;j<=time;j++)
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
        if(TimeEnd<time && DestroyFruit.ScorePlayer>=20)
        {
          //  Screen.gameObject.SetActive(true);
            source.Stop();
          // Screen.GetComponent<Text>().text = Win;
            StartCoroutine(WaitForEnd());
            WLFlag = true;
            IAds = false;
            Console.ACnt = 1;
          
            SceneManager.LoadScene("Console", LoadSceneMode.Single);

        }
        if (TimeEnd >= time && DestroyFruit.ScorePlayer<20)
        {
            //Screen.gameObject.SetActive(true);
            source.Stop();
           // Screen.GetComponent<Text>().text = Loss;
            StartCoroutine(WaitForEnd());
            WLFlag = false;
            IAds = false;
            Console.ACnt = 1;
            
            SceneManager.LoadScene("Console", LoadSceneMode.Single);
        }
    }
    // Start is called before the first frame update

}
