using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [Header("프리팹 연결")]
    public GameObject coinPrefab;          // 코인(1) 프리팹
    public GameObject wallPrefab;          // 벽(2) 프리팹

    [Header("맵 크기 및 배치 설정")]
    public int gridSize = 11;              // 홀수 권장 (정중앙이 정확히 (0,0,0)이 됨)
    public float spacing = 1.5f;           // 격자 한 칸 사이의 간격
    public float coinHeight = 0.5f;        // 코인이 바닥에서 떠 있는 높이

    [Header("벽 높이 및 색상 설정")]
    public float wallHeight = 10.0f;        // 벽의 특정 높이 (원하는 대로 조절)
    public Color wallColor = Color.red;    // 바닥과 구분되는 벽 색상 (기본: 빨간색)

    private int[,] map;

    void Start()
    {
        int center = gridSize / 2;

        // 1. 길 막힘 없는 맵 데이터 생성
        while (true)
        {
            CreateRandomData(center);
            if (CanReachAllCoins(center)) break;
        }

        // 2. 확정된 데이터대로 실제 3D 맵 생성 (높이, 색상 적용)
        BuildMap(center);
    }

    void CreateRandomData(int center)
    {
        map = new int[gridSize, gridSize];

        for (int z = 0; z < gridSize; z++)
        {
            for (int x = 0; x < gridSize; x++)
            {
                if (z == center && x == center)
                {
                    map[z, x] = 0; // 정중앙 시작 위치는 빈 공간(0)
                    continue;
                }

                map[z, x] = (Random.Range(0, 100) < 70) ? 1 : 2;
            }
        }
    }

    bool CanReachAllCoins(int center)
    {
        int totalCoins = 0;
        for (int z = 0; z < gridSize; z++)
            for (int x = 0; x < gridSize; x++)
                if (map[z, x] == 1) totalCoins++;

        bool[,] visited = new bool[gridSize, gridSize];
        Queue<Vector2Int> q = new Queue<Vector2Int>();

        q.Enqueue(new Vector2Int(center, center));
        visited[center, center] = true;

        int foundCoins = 0;
        int[] dx = { 0, 0, -1, 1 };
        int[] dz = { -1, 1, 0, 0 };

        while (q.Count > 0)
        {
            Vector2Int cur = q.Dequeue();
            if (map[cur.y, cur.x] == 1) foundCoins++;

            for (int i = 0; i < 4; i++)
            {
                int nx = cur.x + dx[i];
                int nz = cur.y + dz[i];

                if (nx >= 0 && nx < gridSize && nz >= 0 && nz < gridSize)
                {
                    if (!visited[nz, nx] && map[nz, nx] != 2)
                    {
                        visited[nz, nx] = true;
                        q.Enqueue(new Vector2Int(nx, nz));
                    }
                }
            }
        }

        return foundCoins == totalCoins;
    }

    // 3. 실제 3D 오브젝트 생성 및 벽 높이/색상 적용
    void BuildMap(int center)
    {
        for (int z = 0; z < gridSize; z++)
        {
            for (int x = 0; x < gridSize; x++)
            {
                // 정중앙(center, center)이 정확히 월드 좌표 (0, 0, 0)이 되도록 계산
                float posX = (x - center) * spacing;
                float posZ = (center - z) * spacing;

                int cell = map[z, x];

                if (cell == 1)
                {
                    // 코인 생성
                    Vector3 coinPos = new Vector3(posX, coinHeight, posZ);
                    Instantiate(coinPrefab, coinPos, coinPrefab.transform.rotation, transform);
                }
                else if (cell == 2)
                {
                    // 벽 생성 (바닥 y=0 위에 정확히 올라가도록 Y좌표를 wallHeight / 2f로 설정)
                    Vector3 wallPos = new Vector3(posX, wallHeight / 2f, posZ);
                    GameObject wall = Instantiate(wallPrefab, wallPos, Quaternion.identity, transform);

                    // 1) 벽의 특정 높이 적용 (가로, 세로 크기는 유지하고 Y 높이만 변경)
                    Vector3 scale = wall.transform.localScale;
                    scale.y = wallHeight;
                    wall.transform.localScale = scale;

                    // 2) 벽의 색상 변경 (바닥과 다른 색으로 구분)
                    Renderer wallRenderer = wall.GetComponent<Renderer>();
                    if (wallRenderer != null)
                    {
                        wallRenderer.material.color = wallColor;
                    }
                }
            }
        }
    }
}