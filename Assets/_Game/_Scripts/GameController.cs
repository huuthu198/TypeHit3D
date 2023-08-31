using Lean.Pool;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    public List<Transform> spawnPositions = new List<Transform>();
    public List<GameObject> listAlphabet = new List<GameObject>();
    public List<GameObject> listAlphabeCurrent = new List<GameObject>();
    public List<AlphabetType> alphabetTypes;
    public int count;

    public void SpawnLetter()
    {
      for(int i = 0; i < listAlphabet.Count; i++) 
        {
            for (int j = 0; j < spawnPositions.Count; j++)
            {
                
            }    
        }
        //--------------//

       /* if (listAlphabet[i].GetComponent<LetterManager>().alphabet == alphabetType)
        {
            var letter = LeanPool.Spawn(listAlphabet[i]);
            letter.transform.position = spawnText[currentInput].position;

            if (i < spawnPositions.Count)
            {
                Transform specificSpawnPosition = spawnPositions[i];
                letter.transform.position = specificSpawnPosition.position;
            }
            
        }*/

        if (count < spawnPositions.Count)
        {
            spawnPositions[count].gameObject.SetActive(false);
            var a = LeanPool.Spawn(listAlphabet[(int)alphabetTypes[count]], spawnPositions[count].position, listAlphabet[(int)alphabetTypes[count]].transform.rotation,null);
            listAlphabeCurrent.Add(a);
            a.GetComponent<Rigidbody>().isKinematic = true;
            count++;
            if(count == spawnPositions.Count)
            {
                foreach (var item in listAlphabeCurrent)
                {
                    item.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
        }
    }
}

public enum AlphabetType
{
    q, w, e, r, t, y, u, i, o, p, a, s, d, f, g, h, j, k, l, z, x, c, v, b, n, m
}


