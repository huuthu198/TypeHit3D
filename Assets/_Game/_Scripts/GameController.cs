using Lean.Pool;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    public List<Transform> spawnPositions = new List<Transform>();
    public List<GameObject> listAlphabet = new List<GameObject>();
    public List<AlphabetType> alphabetTypes;

    public void SpawnLetter()
    {
        if (spawnPositions.Count == alphabetTypes.Count)
        {
            for (int i = 0; i < spawnPositions.Count; i++)
            {
                LeanPool.Spawn(listAlphabet[(int)alphabetTypes[i]], spawnPositions[i].position, listAlphabet[(int)alphabetTypes[i]].transform.rotation);
            }
        }
    }
}

public enum AlphabetType
{
    q, w, e, r, t, y, u, i, o, p, a, s, d, f, g, h, j, k, l, z, x, c, v, b, n, m
}


