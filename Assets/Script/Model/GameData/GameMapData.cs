﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 所有的武器数据
public class GameMapData {
    private List<Map> m_MapData = new List<Map>();

    public GameMapData() {
        m_MapData.Add(new Map(16, 20, new byte[] {
                1,0,0,1,1,3,3,3,2,1,1,1,1,1,1,1,
                1,0,2,0,1,3,3,0,0,0,0,10,11,1,1,1,
                1,2,2,3,2,2,0,0,0,0,2,12,13,1,1,1,
                1,1,2,0,0,0,0,0,0,0,0,5,5,1,1,1,
                1,3,2,0,0,0,0,0,0,0,0,2,5,5,1,1,
                4,3,3,2,0,0,0,0,0,0,0,0,2,5,1,1,
                4,3,4,2,0,0,3,0,0,0,0,5,5,5,5,5,
                4,4,4,2,2,1,1,0,0,0,0,0,5,5,6,6,
                4,3,3,3,0,3,1,1,1,1,1,0,0,1,1,6,
                3,3,3,2,2,0,0,1,1,1,1,1,0,0,1,6,
                1,3,2,0,0,0,0,2,1,1,1,1,1,1,1,1,
                1,1,2,0,0,9,0,0,0,2,2,1,1,1,1,1,
                1,1,1,1,0,2,1,1,0,0,8,2,1,1,1,1,
                7,1,1,1,1,1,1,1,1,0,0,0,2,1,1,2,
                7,7,1,1,1,1,0,0,0,0,0,2,2,1,2,2,
                7,7,7,6,0,0,0,0,0,0,0,0,4,2,2,0,
                7,7,7,6,6,0,0,0,0,0,0,0,0,0,2,0,
                7,7,7,7,6,0,0,0,3,0,0,0,0,0,0,0,
                7,7,7,7,6,6,6,0,0,0,0,4,0,2,4,0,
                7,7,7,7,7,7,6,0,0,0,0,0,0,0,4,4
            }));                // 0
        m_MapData.Add(new Map(32, 15, new byte[] {
                1,1,1,1,3,3,3,3,3,1,1,1,1,1,1,1,3,3,0,0,0,0,0,0,0,0,1,1,1,1,1,1,
                1,1,1,1,1,1,1,3,3,3,1,1,1,1,1,3,3,3,3,0,0,0,3,3,0,2,2,10,11,1,1,1,
                1,1,1,1,1,2,9,3,3,3,3,1,1,1,1,1,3,8,3,0,0,3,3,0,0,0,2,12,13,1,1,1,
                0,0,1,1,2,0,0,0,2,3,0,0,1,1,1,3,3,0,0,0,0,0,0,0,3,0,0,3,3,1,1,1,
                0,0,0,0,0,2,2,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,3,2,3,3,1,1,
                0,0,0,0,0,0,0,2,2,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,3,0,0,3,3,3,1,1,
                0,0,4,0,0,0,3,0,0,0,0,1,1,1,1,0,0,0,3,0,0,0,3,0,0,3,3,3,3,3,3,3,
                0,0,0,2,0,0,2,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,1,1,
                0,0,0,0,0,0,0,0,2,0,0,0,0,0,3,0,0,0,6,6,6,0,0,0,0,0,1,1,1,1,1,1,
                3,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,6,6,7,6,6,6,1,1,1,1,1,7,7,7,7,
                0,3,0,0,2,2,3,0,0,0,0,1,1,1,0,6,6,6,7,7,7,7,6,6,1,6,7,7,7,1,1,1,
                0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,6,7,7,7,7,7,7,7,6,6,6,7,6,1,3,3,1,
                3,3,3,0,0,2,0,1,1,1,1,1,1,1,1,1,7,7,7,7,7,7,7,7,7,7,7,6,6,6,9,3,
                3,3,3,3,1,1,1,1,1,1,1,1,1,1,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,6,6,6,
                3,3,1,1,1,1,1,1,1,1,1,1,1,1,1,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,6
            }));                // 1

        m_MapData.Add(new Map(16, 24, new byte[] {
                15,15,15,15,2 ,0 ,0 ,0 ,17,17,0 ,0 ,0 ,0 ,0 ,0 ,
                15,15,15,2 ,2 ,9 ,0 ,0 ,17,0 ,0 ,0 ,0 ,10,11,0 ,
                15,15,15,15,2 ,2 ,0 ,0 ,17,0 ,0 ,0 ,0 ,12,13,0 ,
                15,15,15,15,15,16,0 ,0 ,17,2 ,0 ,0 ,0 ,0 ,0 ,0 ,
                15,15,15,6 ,16,16,0 ,0 ,17,0 ,18,2 ,0 ,0 ,0 ,0 ,
                15,15,6 ,6 ,6 ,16,0 ,0 ,17,2 ,2 ,0 ,18,18,18,0 ,
                7 ,7 ,7 ,6 ,6 ,16,16,0 ,17,0 ,0 ,17,17,17,17,17,
                7 ,7 ,7 ,7 ,6 ,6 ,16,0 ,0 ,0 ,18,18,18,18,2 ,0 ,
                7 ,7 ,7 ,7 ,7 ,6 ,0 ,18,0 ,0 ,0 ,2 ,18,18,18,2 ,
                7 ,7 ,7 ,7 ,7 ,6 ,6 ,0 ,0 ,0 ,2 ,18,18,18,2 ,2 ,
                7 ,7 ,7 ,7 ,7 ,7 ,6 ,0 ,0 ,0 ,0 ,2 ,0 ,18,2 ,2 ,
                7 ,7 ,7 ,7 ,7 ,7 ,6 ,0 ,0 ,0 ,2 ,0 ,0 ,0 ,18,0 ,
                7 ,7 ,7 ,7 ,7 ,7 ,7 ,7 ,0 ,0 ,0 ,0 ,0 ,0 ,2 ,2 ,
                7 ,7 ,7 ,7 ,6 ,6 ,0 ,7 ,7 ,7 ,0 ,0 ,2 ,0 ,0 ,0 ,
                7 ,7 ,7 ,6 ,6 ,0 ,0 ,18,0 ,7 ,7 ,7 ,0 ,0 ,2 ,15,
                7 ,7 ,7 ,6 ,0 ,19,18,18,0 ,0 ,2 ,7 ,7 ,7 ,7 ,7 ,
                7 ,7 ,7 ,6 ,0 ,0 ,2 ,18,0 ,0 ,0 ,0 ,0 ,0 ,0 ,15,
                7 ,7 ,6 ,6 ,0 ,0 ,18,0 ,0 ,0 ,0 ,18,0 ,0 ,15,15,
                7 ,7 ,6 ,0 ,2 ,0 ,0 ,0 ,0 ,0 ,2 ,0 ,0 ,15,15,15,
                7 ,6 ,6 ,0 ,18,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,15,15,15,
                6 ,6 ,2 ,0 ,0 ,0 ,0 ,0 ,18,0 ,0 ,0 ,15,15,15,15,
                0 ,0 ,0 ,0 ,0 ,18,0 ,0 ,2 ,0 ,16,16,15,15,15,15,
                0 ,2 ,0 ,0 ,0 ,2 ,0 ,0 ,0 ,16,16,15,15,15,15,15,
                2 ,0 ,0 ,0 ,0 ,0 ,2 ,0 ,0 ,16,15,15,15,15,15,15,
            }));                // 2
    }

    public Map this[int id] {
        get {
            return m_MapData[id];
        }
    }
}