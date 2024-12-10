<!-- 
# Name: Vanshika Rana
# email: ranava@mail.uc.edu
# Assignment Title: Final Project
# Due Date: December 10th 2024 at 7 am
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This assignment is about solving a problem taken from the website "Leetcode". I chose the problem 42: Trapping Rain Water: Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining. 
# Citations: https://leetcode.com/problems/trapping-rain-water/description/ , AI was used to develop code for the problem as instructed by the professor.
# Anything else that's relevant: n/a
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SurprisingSparrows_FinalProject.Index" %>
<!DOCTYPE html>
<html>
<head>
    <title>Rainwater Trapping Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Rainwater Trapping Calculator</h1>
            <asp:Label ID="lblPrompt" runat="server" Text="Enter heights (comma-separated):"></asp:Label>
            <br />
            <asp:TextBox ID="txtHeights" runat="server" Width="300"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
            <br /><br />
            <asp:Label ID="lblResult" runat="server" Font-Bold="True"></asp:Label>
        </div>
    </form>
</body>
</html>
