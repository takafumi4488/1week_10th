﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    void Start()
    {
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(110);
    }
}
