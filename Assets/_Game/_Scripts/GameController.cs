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
        //if (spawnPositions.Count == alphabetTypes.Count)
        //{
        //    for (int i = 0; i < spawnPositions.Count; i++)
        //    {
        //        LeanPool.Spawn(listAlphabet[(int)alphabetTypes[i]], spawnPositions[i].position, listAlphabet[(int)alphabetTypes[i]].transform.rotation);
        //    }
        //}
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


