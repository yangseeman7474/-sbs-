﻿using System;
/*샛별을 30개 모으면 게임이 끝나는 주사위게임입니다.
엔터키 입력으로 주사위를 굴립니다.
주사위를 굴리면 플레이어가 전진하고, 샛별칸에 도착하거나 지나갈 시 샛별에 대한 이벤트가 발생합니다.
총 칸은 1에서 20까지 있으며, 20을 넘어가면 다시 1부터 전진을 계속합니다.
5배수 칸은 샛별칸이고, 이 칸을 지나거나 도착하면 샛별을 획득할 수 있습니다.
5배수 칸에 도착할 때에는 샛별 획득 개수가 영구적으로 1 증가합니다.
샛별을 획득할 시 , 새로 얻은 샛별 수와 총 획득한 샛별 수를 보여줍니다.*/


/*콘솔 출력 :
주사위를 돌려서 어떤 칸에 도착하면,
해당 칸의 번호 (1~20 중 하나 ), 해당 칸이 어떤칸인지 (그냥 일반인지 샛별인지 ),
현재 샛별수는 몇개인지 , 남은 주사위 수는 몇개인지 콘솔창에 출력해주고
다시 주사위를 굴리라고 콘솔창에 출력해줌.
주사위를 다쓰면 모은 샛별 수를 출력해주고 게임을 종료함. (초기 주사위 갯수 20개)*/


/*만들어야 하는 클래스 :
TileMap(맵을 세팅하고 맵에대한 정보를 가지고 있을 클래스)
TileInfo(각 칸들의 정보를 멤버로 가지는 클래스)
TileInfo_Star(샛별칸을 위한 클래스.TileInfo 를 상속받고 샛별칸에 대한 특수 정보를 멤버로 추가함)
주사위는 아래처럼 콘솔창에 찍어서 보여주면 됨.
Console.WriteLine("┌───────────┐");
Console.WriteLine("│ ●      ●│");
Console.WriteLine("│           │");
Console.WriteLine("│     ●    │");
Console.WriteLine("│           │");
Console.WriteLine("│ ●      ●│");
Console.WriteLine("└───────────┘");*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace UnityLesson_CSharp_DiceGame
{
    internal class Program
    {
        static private int totalTile = 20;
        static private int currentStarPoint = 0;
        static private int totalDiceNumber = 20;
        static private Random random;
        static private int currentTileIndex = 0;
        static private int previousTileIndex = 0;

        static void Main(string[] args)
        {
            TileMap map = new TileMap();
            map.MapSetup(totalTile);

            int currentDiceNumber = totalDiceNumber;
            while (currentDiceNumber > 0)
            {
                int diceValue = RollADice();
                Console.WriteLine($"주사위값은 : {diceValue}");
                currentDiceNumber--;
                currentTileIndex += diceValue;
                if (previousTileIndex/5 < currentTileIndex/5)
                {
                    int passedStarTileIndex = CalcPassedStarTileIndex(currentTileIndex);
                    TileInfo passedStarTileInfo = map.dic_tile.GetValueOrDefault(passedStarTileIndex);
                    TileInfo_Star passedStarTileInfo_Star = passedStarTileInfo as TileInfo_Star; // TileInfo 타입을 TileInfo_Star로 인식하겠다
                    if (passedStarTileInfo_Star != null)
                    {
                        currentStarPoint += passedStarTileInfo_Star.starValue;
                    }
                }

                if (currentTileIndex < totalTile)
                {
                    currentTileIndex -= totalTile;
                }

                TileInfo info = map.dic_tile.GetValueOrDefault(currentTileIndex);
                if (info == null)
                {
                    return;
                }
                Console.WriteLine($"Tile Index : {currentTileIndex}");
                string tileMapName = info.name;
                switch (tileMapName)
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
                Console.WriteLine("Roll a dice! Press Enter");
                userInput = Console.ReadLine();
            }
            random = new Random();
            int diceValue = random.Next(1, 7);
            return diceValue;
        }
        static public int CalcPassedStarTileIndex(int currentTileIndex)
        {
            int index = currentTileIndex / 5 * 5;
            return index;
        }
    }
}