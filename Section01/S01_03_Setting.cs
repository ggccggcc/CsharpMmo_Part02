﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_mmoPart2.Section01
{
    internal class S01_03_Setting
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';

            int lastTick = 0;

            while (true)
            {
                #region 프레임관리
                int currentTick = System.Environment.TickCount;
                //int elapsedTick = currentTick - lastTick;

                //만약 경과한 시간이 1/30초 보다 작다면
                if (currentTick - lastTick < WAIT_TICK)
                    continue;
                lastTick = currentTick;
                #endregion


                //입력
                //로직
                //렌더링
                Console.SetCursorPosition(0, 0);

                for(int i =0; i<25; i++)
                {
                    for(int j = 0; j<25; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
