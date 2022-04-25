﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsole.Codility.Lessons
{
    public static class FibFrog
    {
        public static int solution(int[] A)
        {
            int N = A.Length;
            int GOAL = N + 1;
            int START = -1;

            // fibonacci numbers array
            int[] fibs = new int[N + 2];
            fibs[0] = 1;
            fibs[1] = 2;
            for (int i = 2; i < fibs.Length; i++)
            {
                fibs[i] = fibs[i - 2] + fibs[i - 1];
                if (fibs[i] == GOAL) return 1;
            }

            // greedy array
            int[] greedy = new int[GOAL];
            for (int i = START; i < GOAL; i++)
            {
                // if current position is the Start position or a leaf
                if (i == START || greedy[i] > 0)
                {
                    // mark all reachable leaves from current leaf (or start position)
                    for (int j = 0; (i + fibs[j]) < GOAL; j++)
                    {
                        // frog jumps "i+fibs[j]"
                        int jumpToIndex = i + fibs[j];

                        // reached goal (index of GOAL is GOAL-1)
                        // or reached a leaf
                        if (jumpToIndex == GOAL - 1 || A[jumpToIndex] == 1)
                        {
                            // if current position is start, then the frog can reach the jumpToIndex leaf by 1 time jump
                            if (i == START) greedy[jumpToIndex] = 1;
                            // compute "Local optimal solution" of the leaf "A[jumpToIndex]"
                            else if (greedy[jumpToIndex] <= 0) greedy[jumpToIndex] = greedy[i] + 1;
                            else greedy[jumpToIndex] = Math.Min(greedy[jumpToIndex], greedy[i] + 1);
                        }
                    }
                }
            }
            return greedy[GOAL - 1] <= 0 ? -1 : greedy[GOAL - 1];
        }
    }
}
