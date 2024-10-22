using UnityEngine;

[CreateAssetMenu(fileName = "collectedCandies", menuName="collected_candies")]
public class collectedCandies : ScriptableObject
{
    public string[] recievedCandies;
    private int amount = 0;
    private float randNum = 0f;
    private float randCandy = 0f;

    public void addCandies(){
        randNum = Random.Range(1,7);
        for (int i = 0; i<randNum; i++){
            randCandy = Random.Range(1,8);
            if (randCandy == 1){
                recievedCandies[amount] = "M&Ms";
                amount++;
            }
            if (randCandy == 2){
                recievedCandies[amount] = "Sour Patch Kids";
                amount++;
            }
            if (randCandy == 3){
                recievedCandies[amount] = "Swedish Fish";
                amount++;
            }
            if (randCandy == 4){
                recievedCandies[amount] = "Milky Way";
                amount++;
            }
            if (randCandy == 5){
                recievedCandies[amount] = "Reese's Peanut Butter Cup";
                amount++;
            }
            if (randCandy == 6){
                recievedCandies[amount] = "Hershey";
                amount++;
            }
            if (randCandy == 7){
                recievedCandies[amount] = "Nerds";
                amount++;
            }
            if (randCandy == 8){
                recievedCandies[amount] = "Skittles";
                amount++;
            }
        }
    }
}
