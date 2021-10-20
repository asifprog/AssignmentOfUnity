using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveName : MonoBehaviour
{
    public static List<string> animalname = new List<string>();
    static int cntanimal = 0;
    public static string pname;
    // Start is called before the first frame update
    

    public void Onclicked()
    {
        pname = InputPlayerName.inputname;
        CheckAdd(pname);

    }
  
    public void CheckAdd(string name)
    {
        if (animalname.Count > 0)
        {
            if (CheckExits(name) == false)
            {
                animalname.Add(name);
                animalname.Add(DestroyFruit.ScorePlayer.ToString());

                Debug.Log(name);
                Debug.Log(DestroyFruit.ScorePlayer.ToString());

                // Debug.Log("called");
                // animalname[0] = prefabs[0].name;

                // cntanimal = 0;
                OnEnd();
            }
        }
        else
        {
            animalname.Add(name);
            animalname.Add(DestroyFruit.ScorePlayer.ToString());

            Debug.Log(name);
            Debug.Log(DestroyFruit.ScorePlayer.ToString());
            // animalname[0] = prefabs[0].name;

            // cntanimal = 0;
            OnEnd();
        }

    }
    public bool CheckExits(string name)
    {
        if (animalname.Count > 0)
        {
            for (int i = 0; i < animalname.Count; i = i + 2)
            {
                if (string.Compare(animalname[i], name) == 0)
                {
                    cntanimal = i;
                    //cflag = true;
                    return true;
                    //break;
                }
            }
            return false;
        }
        return false;
    }
    void OnEnd()
    {
        PlayerPrefs.SetString(animalname[cntanimal], InputPlayerName.inputname);
        PlayerPrefs.SetString(animalname[cntanimal + 1], DestroyFruit.ScorePlayer.ToString());

        PlayerPrefs.Save();
    }
}
