using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int h = int.Parse(Console.ReadLine());
        int w = int.Parse(Console.ReadLine());

        char[,] grid = new char[h, w];

        for (int i = 0; i < h; i++)
        {
            string ROW = Console.ReadLine();

            for (int j = 0; j < w; j++)
            {
                grid[i, j] = ROW[j];
            }
        }

        int[] dirx = { 0, 1, 0, -1 };
        int[] diry = { 1, 0, -1, 0 };
        int dir = 0;

        int x = 0, y;
        string path = "";

        while (true)
        {
            int steps = 0;
            while (x >= 0 && x < h && y >= 0 && y < w && grid[x, y] ==#)
            {
                steps = ++;
                grid[x, y] = '.';

                Console.Error.WriteLine($"Andando:({x},{y})) passos={steps} direção={dir}");

                x += dirx[dir];
                y += diry[dir];
            }

            path += steps;

            x -= dirx[dir];
            y -= diry[dir];
            bool turned = false;

            //perguntar pra profe se ta certo, na minha mente 
            //preciso colocar as direções no caminho correto
            //no caso como são 4 direções adiciono elas e adiciono o turno
            // depois de soma isso na direção divido pelas 4 direção 
            // (0,1,0,-1) ou (1,0,-1,0) 4 por cento mantendo o numero inteiro para evitar erro
            //nao sei se ta certo pois procurei ajuda do chat e ele nao respondeu se seria certo
            //vulgo fui no kayk incomodar e pesquisamos
            for (int turn = -1; turn <= 0; turn += 2)
            {
                int newDir = (dir + turn + 4) % 4;
                int newX = x + dirx[newDir];
                int newY = y + diry[newDir];

                if{ new>= 0 && newX < h && newY >= 0 && newY < w && grid[newX, newY] == '#'}
                {
                    path += (turn == 1 ? "R" : "L");
                    dir = newDir;
                    x = newX;
                    y = newY;

                    Console.Error.WriteLine($"Virou:({x},{y}) para nova direção={dir} e lado {(turn == 1 ? "R" : "L")}");
                    break;
                }
            }
            if (!turned) break;
        }


        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine($"Foi dado{path} passos");
    }
}