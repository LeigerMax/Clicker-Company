
/// <summary>
/// This class convert money number.
/// </summary>
/// <author> Maxou </author>
/// <lastModified>27-01-2024</lastModified>
/// 
public class NumberConverter 
{

    public string UpdateUI(float money)
    {
        string moneyText = "Money : ";
        if(money < 1000) {
            moneyText += money.ToString("0.0") +"$";
        }
        else if(money < 1000000) {
            moneyText += (money / 1000).ToString("0.0") +"K$";
        }
        else if(money < 1000000000) {
            moneyText += (money / 1000000).ToString("0.0") +"M$";
        }
        else if(money < 1000000000000) {
            moneyText += (money / 1000000000).ToString("0.0") +"B$";
        }
        else if(money < 1e15) {
            moneyText += (money / 1000000000000).ToString("0.0") +"T$";
        }
        else if(money < 1e18) {
            moneyText += (money / 1e15).ToString("0.0") +"Q$";
        }
        else if(money < 1e21) {
            moneyText += (money / 1e18).ToString("0.0") +"Qi$";
        }
        else if(money < 1e24) {
            moneyText += (money / 1e21).ToString("0.0") +"S$";
        }
        else if(money < 1e27) {
            moneyText += (money / 1e24).ToString("0.0") +"Sp$";
        }
        else if(money < 1e30) {
            moneyText += (money / 1e27).ToString("0.0") +"O$";
        }
        else if(money < 1e33) {
            moneyText += (money / 1e30).ToString("0.0") +"N$";
        }
        else if(money < 1e36) {
            moneyText += (money / 1e33).ToString("0.0") +"D$";
        }
        else if(money < 1e39) {
            moneyText += (money / 1e36).ToString("0.0") +"U$";
        }
        else if(money < 1e42) {
            moneyText += (money / 1e39).ToString("0.0") +"Dc$";
        }
        else if(money < 1e45) {
            moneyText += (money / 1e42).ToString("0.0") +"Td$";
        }
        else if(money < 1e48) {
            moneyText += (money / 1e45).ToString("0.0") +"Qd$";
        }
        else if(money < 1e51) {
            moneyText += (money / 1e48).ToString("0.0") +"Qid$";
        }
        else if(money < 1e54) {
            moneyText += (money / 1e51).ToString("0.0") +"Sd$";
        }
        else if(money < 1e57) {
            moneyText += (money / 1e54).ToString("0.0") +"Spd$";
        }
        else if(money < 1e60) {
            moneyText += (money / 1e57).ToString("0.0") +"Od$";
        }
        else if(money < 1e63) {
            moneyText += (money / 1e60).ToString("0.0") +"Nd$";
        }
        else if(money < 1e66) {
            moneyText += (money / 1e63).ToString("0.0") +"V$";
        }   
        return moneyText;
    }    

}