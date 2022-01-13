using System;
using System.Threading;
using System.Collections.Generic;

namespace 샛별
{
    internal class Program
    {
        static private int totalTile = 20;
        // 칸의 개수
        static private int currentStarPoint = 0;
        // 샛별 개수
        static private int totalDiceNumber = 20;
        // 주사위 개수
        static private int currentTileIndex = 0;
        // 현재 칸의 번호
        static private int previousTileIndex = 0;
        // 플레이어가 샛별칸을 지났는지 비교하기 위함
        static private Random random;
        static void Main(string[] args)
        {
            TileMap map = new TileMap(); // 맵 클래스 인스턴스화
            map.MapSetup(totalTile);    // 맵 생성

            int currentDiceNumber = totalDiceNumber;

            while (currentDiceNumber > 0)
            {
                int diceValue = RollADice();
                currentDiceNumber--;
                currentTileIndex += diceValue;


                // 플레이어가 샛별칸을 지날때
                if (previousTileIndex / 5 < currentTileIndex / 5) // 현재 칸의 번호 /5 가 지난 칸 번호 /5 보다 크면 샛별칸을 지났다.
                {
                    int passedStarTileIndex = CalcPassedStarTileIndex(currentTileIndex);
                    TileInfo passedStarTileInfo = map.dic_tile.GetValueOrDefault(passedStarTileIndex); // 지나온 샛별칸의 tileinfo 가져오기
                    TileInfo_Star passedStarTileInfo_Star = passedStarTileInfo as TileInfo_Star;// TileInfo타입을 TileInfo_Star로 인식하겠다.
                    if (passedStarTileInfo != null) // 샛별칸의 TileInfo 정보를 가져오는데 성공했으면 (예외처리)
                    {
                        currentStarPoint += passedStarTileInfo_Star.starValue; // 샛별점수 누적

                    }
                }

                if(currentTileIndex > totalTile) // 현재칸이 최대칸을 넘어가 버렸을때
                {
                    currentTileIndex -= totalTile; // 현재칸에다가 최대칸을 뺀다.
                }

                TileInfo info = map.dic_tile.GetValueOrDefault(currentTileIndex); //map에서 현재칸의 TileInfo를 가져온다.

                if (info != null) // 현재칸의 TileInfo 를 가져오기 못했을때는 프로그램을 끝내버린다.
                {
                    return;
                }
                Console.WriteLine($"Tile Index : {currentTileIndex}")
                      
                string tileMapName = info.name;
                switch(tileMapName)
                {
                    case "Dummy":
                        break;
                    case "Star":
                        break;
                    default:
                        return;

                }



            }




        }



        static private int RollADice()
        {
            string userInput = "Default";
            while (userInput != "")
            {
                Console.Write("Roll a dice ! Press Enter");
                userInput = Console.ReadLine();
            }
            random = new Random();
            int diceValue = random.Next(1, 7); //1~6사이의 랜덤한 정수
            return diceValue;



        }

        static public int CalcPassedStarTileIndex(int currentTileIndex)
        {
            int index = currentTileIndex / 5 * 5;
            return index;
        }
    }
}
