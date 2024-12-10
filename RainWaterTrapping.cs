//# Name: Vanshika Rana
//# email: ranava@mail.uc.edu
//# Assignment Title: Final Project
//# Due Date: December 10th 2024 at 7 am
//# Course: IS 3050
//# Semester/Year: Fall 2024
//# Brief Description: This assignment is about solving a problem taken from the website "Leetcode". I chose the problem 42: Trapping Rain Water: Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.
//# Citations: https://leetcode.com/problems/trapping-rain-water/description/ , AI was used to develop code for the problem as instructed by the professor.
//# Anything else that's relevant: n/a

using System;

namespace SurprisingSparrows_FinalProject
{
    public class RainWaterTrapping
    {
        public int Trap(int[] height)
        {
            if (height == null || height.Length == 0)
                return 0;

            int n = height.Length;
            int[] leftMax = new int[n];
            int[] rightMax = new int[n];
            int waterTrapped = 0;

            //Computing left max heights
            leftMax[0] = height[0];
            for (int i = 1; i < n; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
            }

            //Computing right max heights
            rightMax[n - 1] = height[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
            }

            //Calculation of trapped water
            for (int i = 0; i < n; i++)
            {
                waterTrapped += Math.Min(leftMax[i], rightMax[i]) - height[i];
            }

            return waterTrapped;
        }
    }
}
