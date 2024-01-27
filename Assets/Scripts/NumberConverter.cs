
using System;

/// <summary>
/// This class convert number number.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>27-01-2024</lastModified>
/// 
public class NumberConverter 
{

    public string UpdateUI(float number, string type)
    {
        string moneyText = null;
        if(number < 1000) {
            moneyText = number.ToString("0.0") +type;
        }
        else if(number < 1000000) {
            moneyText = (number / 1000).ToString("0.0") +"K"+type;
        }
        else if(number < 1000000000) {
            moneyText = (number / 1000000).ToString("0.0") +"M"+type;
        }
        else if(number < 1000000000000) {
            moneyText = (number / 1000000000).ToString("0.0") +"B"+type;
        }
        else if(number < 1e15) {
            moneyText = (number / 1000000000000).ToString("0.0") +"T"+type;
        }
        else if(number < 1e18) {
            moneyText = (number / 1e15).ToString("0.0") +"Q"+type;
        }
        else if(number < 1e21) {
            moneyText = (number / 1e18).ToString("0.0") +"Qi"+type;
        }
        else if(number < 1e24) {
            moneyText = (number / 1e21).ToString("0.0") +"S"+type;
        }
        else if(number < 1e27) {
            moneyText = (number / 1e24).ToString("0.0") +"Sp"+type;
        }
        else if(number < 1e30) {
            moneyText = (number / 1e27).ToString("0.0") +"O"+type;
        }
        else if(number < 1e33) {
            moneyText = (number / 1e30).ToString("0.0") +"N"+type;
        }
        else if(number < 1e36) {
            moneyText = (number / 1e33).ToString("0.0") +"D"+type;
        }
        else if(number < 1e39) {
            moneyText = (number / 1e36).ToString("0.0") +"U"+type;
        }
        else if(number < 1e42) {
            moneyText = (number / 1e39).ToString("0.0") +"Dc"+type;
        }
        else if(number < 1e45) {
            moneyText = (number / 1e42).ToString("0.0") +"Td"+type;
        }
        else if(number < 1e48) {
            moneyText = (number / 1e45).ToString("0.0") +"Qd"+type;
        }
        else if(number < 1e51) {
            moneyText = (number / 1e48).ToString("0.0") +"Qid"+type;
        }
        else if(number < 1e54) {
            moneyText = (number / 1e51).ToString("0.0") +"Sd"+type;
        }
        else if(number < 1e57) {
            moneyText = (number / 1e54).ToString("0.0") +"Spd"+type;
        }
        else if(number < 1e60) {
            moneyText = (number / 1e57).ToString("0.0") +"Od"+type;
        }
        else if(number < 1e63) {
            moneyText = (number / 1e60).ToString("0.0") +"Nd"+type;
        }
        else if(number < 1e66) {
            moneyText = (number / 1e63).ToString("0.0") +"V"+type;
        }   
        return moneyText;
    }    

}