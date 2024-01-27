
using System;

/// <summary>
/// This class convert number.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>27-01-2024</lastModified>

public class NumberConverter 
{

    public string UpdateUI(float number)
    {
        string moneyText = null;
        if(number < 1000) {
            moneyText = number.ToString("0.0");
        }
        else if(number < 1000000) {
            moneyText = (number / 1000).ToString("0.0") +"K";
        }
        else if(number < 1000000000) {
            moneyText = (number / 1000000).ToString("0.0") +"M";
        }
        else if(number < 1000000000000) {
            moneyText = (number / 1000000000).ToString("0.0") +"B";
        }
        else if(number < 1e15) {
            moneyText = (number / 1000000000000).ToString("0.0") +"T";
        }
        else if(number < 1e18) {
            moneyText = (number / 1e15).ToString("0.0") +"Q";
        }
        else if(number < 1e21) {
            moneyText = (number / 1e18).ToString("0.0") +"Qi";
        }
        else if(number < 1e24) {
            moneyText = (number / 1e21).ToString("0.0") +"S";
        }
        else if(number < 1e27) {
            moneyText = (number / 1e24).ToString("0.0") +"Sp";
        }
        else if(number < 1e30) {
            moneyText = (number / 1e27).ToString("0.0") +"O";
        }
        else if(number < 1e33) {
            moneyText = (number / 1e30).ToString("0.0") +"N";
        }
        else if(number < 1e36) {
            moneyText = (number / 1e33).ToString("0.0") +"D";
        }
        else if(number < 1e39) {
            moneyText = (number / 1e36).ToString("0.0") +"U";
        }
        else if(number < 1e42) {
            moneyText = (number / 1e39).ToString("0.0") +"Dc";
        }
        else if(number < 1e45) {
            moneyText = (number / 1e42).ToString("0.0") +"Td";
        }
        else if(number < 1e48) {
            moneyText = (number / 1e45).ToString("0.0") +"Qd";
        }
        else if(number < 1e51) {
            moneyText = (number / 1e48).ToString("0.0") +"Qid";
        }
        else if(number < 1e54) {
            moneyText = (number / 1e51).ToString("0.0") +"Sd";
        }
        else if(number < 1e57) {
            moneyText = (number / 1e54).ToString("0.0") +"Spd";
        }
        else if(number < 1e60) {
            moneyText = (number / 1e57).ToString("0.0") +"Od";
        }
        else if(number < 1e63) {
            moneyText = (number / 1e60).ToString("0.0") +"Nd";
        }
        else if(number < 1e66) {
            moneyText = (number / 1e63).ToString("0.0") +"V";
        }   
        return moneyText;
    }    

}