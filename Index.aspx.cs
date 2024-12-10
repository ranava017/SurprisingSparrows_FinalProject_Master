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
using System.Linq;

namespace SurprisingSparrows_FinalProject
{
    public partial class Index : System.Web.UI.Page
    {
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Parse user input
                string[] input = txtHeights.Text.Split(',');
                int[] heights = input.Select(int.Parse).ToArray();

                //Constraint checks
                if (heights.Length < 1 || heights.Length > 20000)
                {
                    lblResult.Text = "Error: The number of heights (n) must be between 1 and 20,000.";
                    return;
                }

                if (heights.Any(h => h < 0 || h > 100000))
                {
                    lblResult.Text = "Error: Each height must be a non-negative integer between 0 and 100,000.";
                    return;
                }

                //RainWaterTrapping logic
                RainWaterTrapping calculator = new RainWaterTrapping();
                int result = calculator.Trap(heights);

                //Display of the result
                lblResult.Text = $"Water trapped: {result} units";
            }
            catch (Exception)
            {
                lblResult.Text = "Error: Invalid input. Please enter non-negative integers which are separated by commas.";
            }
        }
    }
}
